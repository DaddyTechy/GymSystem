Imports MySql.Data.MySqlClient
Imports System.Text

Public Class AddAttendanceControl
    ' Event to notify when the Save button is clicked
    Public Event SaveAttendance(memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
    Public Event UpdateAttendance(attendanceID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)

    Private _attendanceID As Integer
    Public Property IsEditMode As Boolean = False

    ' Reference to the DataGridView
    Public Property AttendanceDataGridView As DataGridView

    ' Button click event to save the attendance details
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs before processing
        Dim memberID As Integer
        If Not Integer.TryParse(cmbMemberID.Text, memberID) Then
            MessageBox.Show("Member ID cannot be empty and must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(cmbSessionType.SelectedItem?.ToString()) Then
            MessageBox.Show("Please select a Session Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(cmbStatus.SelectedItem?.ToString()) Then
            MessageBox.Show("Please select a Status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the input values now that they are validated
        Dim staffID As Integer = CurrentLoggedUser.id ' Use the current logged-in user's ID
        Dim checkInTime As TimeSpan = dtpCheckInTime.Value.TimeOfDay
        Dim checkOutTime As TimeSpan = dtpCheckOutTime.Value.TimeOfDay
        Dim sessionType As String = cmbSessionType.SelectedItem.ToString()
        Dim dateValue As DateTime = dtpDate.Value
        Dim status As String = cmbStatus.SelectedItem.ToString()

        ' Confirm with the user
        Dim action As String = If(IsEditMode, "update", "save")
        Dim confirmationMessage As String = $"Are you sure you want to {action} the following attendance record?{Environment.NewLine}" &
                                            $"Member ID: {memberID}{Environment.NewLine}" &
                                            $"Staff ID: {staffID}{Environment.NewLine}" &
                                            $"Check-In Time: {checkInTime}{Environment.NewLine}" &
                                            $"Check-Out Time: {checkOutTime}{Environment.NewLine}" &
                                            $"Session Type: {sessionType}{Environment.NewLine}" &
                                            $"Date: {dateValue:yyyy-MM-dd}{Environment.NewLine}" &
                                            $"Status: {status}"
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, $"Confirm {If(IsEditMode, "Update", "Save")}", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If IsEditMode Then
                RaiseEvent UpdateAttendance(_attendanceID, staffID, checkInTime, checkOutTime, sessionType, dateValue, status)
                Logs("Updated Attendance", "Attendance Table Update")
            Else
                RaiseEvent SaveAttendance(memberID, staffID, checkInTime, checkOutTime, sessionType, dateValue, status)
                Logs("Added Attendance", "Attendance Table Update")
            End If
            Me.Visible = False
        End If
    End Sub

    ' Event to check if the MemberID exists
    Private Sub cmbMemberID_Leave(sender As Object, e As EventArgs) Handles cmbMemberID.Leave
        Dim memberID As Integer
        If Integer.TryParse(cmbMemberID.Text, memberID) Then
            If CheckMemberIDExists(memberID) Then
                lblMemberStatus.Text = "Member found"
                lblMemberStatus.ForeColor = Color.Green
            Else
                lblMemberStatus.Text = "Member not found"
                lblMemberStatus.ForeColor = Color.Red
            End If
        Else
            lblMemberStatus.Text = "Invalid ID"
            lblMemberStatus.ForeColor = Color.Red
        End If
    End Sub

    ' Method to check if the MemberID exists in the database
    Private Function CheckMemberIDExists(memberID As Integer) As Boolean
        Dim memberExists As Boolean = False
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM members WHERE MemberID = @MemberID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Convert.ToInt32(result) > 0 Then
                        memberExists = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while verifying the member ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return memberExists
    End Function

    Public Sub LoadDataForEdit(attendanceID As Integer, memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        _attendanceID = attendanceID
        cmbMemberID.Text = memberID.ToString()
        ' staffID is not directly editable here, it's based on logged-in user
        dtpCheckInTime.Value = DateTime.Today + checkInTime
        dtpCheckOutTime.Value = DateTime.Today + checkOutTime
        cmbSessionType.SelectedItem = sessionType
        Try
            dtpDate.Value = dateValue
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show($"The date for this record ({dateValue.ToShortDateString()}) is invalid or out of the allowed range. Please correct it manually.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Set a safe default to prevent crashing
            dtpDate.Value = If(DateTime.Today <= dtpDate.MaxDate AndAlso DateTime.Today >= dtpDate.MinDate, DateTime.Today, dtpDate.MinDate)
        End Try
        cmbStatus.SelectedItem = status

        IsEditMode = True
        btnSave.Text = "Update"
        cmbMemberID.Enabled = False
        lblMemberStatus.Text = ""
    End Sub

    Public Sub ResetFields()
        _attendanceID = 0
        cmbMemberID.Text = ""
        dtpCheckInTime.Value = DateTime.Now
        dtpCheckOutTime.Value = DateTime.Now
        cmbSessionType.SelectedIndex = -1
        dtpDate.Value = DateTime.Today
        cmbStatus.SelectedIndex = -1
        IsEditMode = False
        btnSave.Text = "Save"
        cmbMemberID.Enabled = True
        lblMemberStatus.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub cmbMemberID_TextChanged(sender As Object, e As EventArgs) Handles cmbMemberID.TextChanged
        Dim input As String = cmbMemberID.Text
        Dim output As New StringBuilder()
        Dim isValid As Boolean = True

        For Each ch As Char In input
            If Char.IsDigit(ch) Then
                output.Append(ch)
            Else
                isValid = False
            End If
        Next

        If Not isValid Then
            MessageBox.Show("Please enter only numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        cmbMemberID.Text = output.ToString()
        cmbMemberID.SelectionStart = cmbMemberID.Text.Length ' Move the cursor to the end of the text
    End Sub

    Private Sub dtpCheckInTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckInTime.ValueChanged
        If dtpCheckInTime.Value.TimeOfDay < TimeSpan.FromHours(6) Then
            dtpCheckInTime.Value = DateTime.Today.AddHours(6)
        ElseIf dtpCheckInTime.Value.TimeOfDay > TimeSpan.FromHours(22) Then
            dtpCheckInTime.Value = DateTime.Today.AddHours(22)
        End If
    End Sub

    Private Sub dtpCheckOutTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOutTime.ValueChanged
        If dtpCheckOutTime.Value.TimeOfDay < TimeSpan.FromHours(6.5) Then
            dtpCheckOutTime.Value = DateTime.Today.AddHours(6)
        ElseIf dtpCheckOutTime.Value.TimeOfDay > TimeSpan.FromHours(22) Then
            dtpCheckOutTime.Value = DateTime.Today.AddHours(22)
        End If
    End Sub
End Class




