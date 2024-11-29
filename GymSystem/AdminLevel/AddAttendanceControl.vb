Imports System.Text

Public Class AddAttendanceControl
    ' Event to notify when the Save button is clicked
    Public Event SaveAttendance(memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)

    ' Reference to the DataGridView
    Public Property AttendanceDataGridView As DataGridView

    ' Button click event to save the attendance details
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Ensure the AttendanceDataGridView is not null
        If AttendanceDataGridView Is Nothing Then
            MessageBox.Show("DataGridView reference is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the input values
        Dim memberID As Integer = Convert.ToInt32(cmbMemberID.Text)
        Dim staffID As Integer = CurrentLoggedUser.id ' Use the current logged-in user's ID
        Dim checkInTime As TimeSpan = dtpCheckInTime.Value.TimeOfDay
        Dim checkOutTime As TimeSpan = dtpCheckOutTime.Value.TimeOfDay
        Dim sessionType As String = cmbSessionType.SelectedItem.ToString()
        Dim dateValue As DateTime = dtpDate.Value
        Dim status As String = cmbStatus.SelectedItem.ToString()

        ' Validate inputs
        If String.IsNullOrWhiteSpace(cmbMemberID.Text) Then
            MessageBox.Show("Member ID cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(cmbSessionType.SelectedItem?.ToString()) Then
            MessageBox.Show("Session Type cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(cmbStatus.SelectedItem?.ToString()) Then
            MessageBox.Show("Status cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Show a confirmation dialog before saving
        Dim confirmationMessage As String = $"Are you sure you want to save the following attendance record?{Environment.NewLine}" &
                                            $"Member ID: {memberID}{Environment.NewLine}" &
                                            $"Staff ID: {staffID}{Environment.NewLine}" &
                                            $"Check-In Time: {checkInTime}{Environment.NewLine}" &
                                            $"Check-Out Time: {checkOutTime}{Environment.NewLine}" &
                                            $"Session Type: {sessionType}{Environment.NewLine}" &
                                            $"Date: {dateValue:yyyy-MM-dd}{Environment.NewLine}" &
                                            $"Status: {status}"
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Raise the SaveAttendance event
            RaiseEvent SaveAttendance(memberID, staffID, checkInTime, checkOutTime, sessionType, dateValue, status)

            Logs("Added Atendance", "Attendance table Update")
            ' Hide the control after saving
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
        Dim sql As String = $"SELECT COUNT(*) FROM members WHERE MemberID = {memberID}"
        Dim memberExists As Boolean = False

        Try
            readQuery(sql)
            If cmdRead.Read() Then
                memberExists = cmdRead.GetInt32(0) > 0
            End If
            cmdRead.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return memberExists
    End Function

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

End Class




