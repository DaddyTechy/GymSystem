Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ContentAttendance
    Private dtAttendance As New DataTable()
    Private currentOffset As Integer = 0
    Private Const batchSize As Integer = 40
    Private isLoading As Boolean = False
    Private isSearchActive As Boolean = False
    Private selectedAttendanceID As Integer = -1
    Private memberContextMenu As ContextMenuStrip

    Private Sub ContentAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeContextMenu()
        LoadAttendanceData()
        ' Add event handlers for the AddAttendanceControl
        AddHandler addAttendanceControl.SaveAttendance, AddressOf OnSaveAttendance
        AddHandler addAttendanceControl.UpdateAttendance, AddressOf OnUpdateAttendance
        AddHandler txtUserInput.TextChanged, AddressOf txtUserInput_TextChanged
        AddHandler txtUserInput.KeyDown, AddressOf txtUserInput_KeyDown
    End Sub

    Private Sub InitializeContextMenu()
        memberContextMenu = New ContextMenuStrip()
        Dim editItem As New ToolStripMenuItem("Edit")
        Dim deleteItem As New ToolStripMenuItem("Delete")

        memberContextMenu.Items.Add(editItem)
        memberContextMenu.Items.Add(deleteItem)

        AddHandler editItem.Click, AddressOf EditMenuItem_Click
        AddHandler deleteItem.Click, AddressOf DeleteMenuItem_Click

        attendanceDGV.ContextMenuStrip = memberContextMenu
    End Sub

    Private Sub LoadAttendanceData(Optional searchTerm As String = "")
        If isLoading Then Return
        isLoading = True
        btnNext.Enabled = False
        btnBack.Enabled = False

        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()

                Dim whereClauses As New List(Of String)
                whereClauses.Add("1=1")

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    Dim searchCondition As String = $"(CONCAT(m.FirstName, ' ', m.LastName) LIKE '%{searchTerm}%' OR a.MemberID LIKE '%{searchTerm}%' OR a.Date LIKE '%{searchTerm}%')"
                    whereClauses.Add(searchCondition)
                End If

                Dim whereClause As String = String.Join(" AND ", whereClauses)

                Dim query As String = $"SELECT a.AttendanceID, a.StaffID, a.MemberID, CONCAT(m.FirstName, ' ', m.LastName) AS MemberFullName, a.Date, a.CheckInTime, a.CheckOutTime, a.SessionType, a.Status " &
                                  $"FROM attendance a " &
                                  $"JOIN members m ON a.MemberID = m.MemberID " &
                                  $"WHERE {whereClause} " &
                                  $"ORDER BY a.AttendanceID DESC " &
                                  $"LIMIT {batchSize} OFFSET {currentOffset}"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dtAttendance = dt ' Replace data for pagination
                attendanceDGV.DataSource = dtAttendance
                UIUtils.FormatAndStyleDGV(attendanceDGV)

                ' Update button states
                btnNext.Enabled = (dt.Rows.Count = batchSize)
                btnBack.Enabled = (currentOffset > 0)

            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading attendance data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isLoading = False
        End Try
    End Sub

    Private Sub attendanceDGV_MouseClick(sender As Object, e As MouseEventArgs) Handles attendanceDGV.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim hitTestInfo As DataGridView.HitTestInfo = attendanceDGV.HitTest(e.X, e.Y)
            If hitTestInfo.RowIndex >= 0 Then
                attendanceDGV.ClearSelection()
                attendanceDGV.Rows(hitTestInfo.RowIndex).Selected = True
                selectedAttendanceID = Convert.ToInt32(attendanceDGV.Rows(hitTestInfo.RowIndex).Cells("AttendanceID").Value)
            End If
        End If
    End Sub



    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        If selectedAttendanceID <> -1 Then
            DeleteAttendance(selectedAttendanceID)
        End If
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        If attendanceDGV.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = attendanceDGV.SelectedRows(0).Index
            EditAttendance(selectedRowIndex)
        End If
    End Sub

    Private Sub DeleteAttendance(attendanceID As Integer)
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "DELETE FROM attendance WHERE AttendanceID = @AttendanceID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadAttendanceData()
            MessageBox.Show("Attendance record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the attendance record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditAttendance(rowIndex As Integer)
        Try
            Dim row As DataGridViewRow = attendanceDGV.Rows(rowIndex)

            ' Retrieve data from the selected row
            Dim attendanceID As Integer = Convert.ToInt32(row.Cells("AttendanceID").Value)
            Dim memberID As Integer = Convert.ToInt32(row.Cells("MemberID").Value)
            Dim staffID As Integer = Convert.ToInt32(row.Cells("StaffID").Value)
            Dim dateValue As DateTime
            If Not DateTime.TryParse(row.Cells("Date").Value.ToString(), dateValue) OrElse dateValue < addAttendanceControl.dtpDate.MinDate OrElse dateValue > addAttendanceControl.dtpDate.MaxDate Then
                dateValue = DateTime.Now ' Default to today if the date is invalid or out of range
            End If

            Dim checkInTime As TimeSpan = TimeSpan.Parse(row.Cells("CheckInTime").Value.ToString())
            Dim checkOutTime As TimeSpan = TimeSpan.Parse(row.Cells("CheckOutTime").Value.ToString())
            Dim sessionType As String = row.Cells("SessionType").Value.ToString()
            Dim status As String = row.Cells("Status").Value.ToString()

            ' Load data into the control and set it to edit mode
            addAttendanceControl.LoadDataForEdit(attendanceID, memberID, staffID, checkInTime, checkOutTime, sessionType, dateValue, status)

            ' Show the control
            addAttendanceControl.Visible = True
            addAttendanceControl.BringToFront()
        Catch ex As Exception
            MessageBox.Show("An error occurred while preparing the edit form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentOffset += batchSize
        If isSearchActive Then
            LoadAttendanceData(txtUserInput.Text.Trim())
        Else
            LoadAttendanceData()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentOffset >= batchSize Then
            currentOffset -= batchSize
        Else
            currentOffset = 0
        End If

        If isSearchActive Then
            LoadAttendanceData(txtUserInput.Text.Trim())
        Else
            LoadAttendanceData()
        End If
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        currentOffset = 0
        isSearchActive = True
        LoadAttendanceData(txtUserInput.Text.Trim())
    End Sub

    Private Sub txtUserInput_TextChanged(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtUserInput.Text) Then
            currentOffset = 0
            isSearchActive = False
            LoadAttendanceData()
        End If
    End Sub

    Private Sub txtUserInput_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSearch2.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub OnSaveAttendance(memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        Try
            UpdateConnectionString()
            Dim query As String = "INSERT INTO attendance (MemberID, StaffID, CheckInTime, CheckOutTime, SessionType, Date, Status) VALUES (@MemberID, @StaffID, @CheckInTime, @CheckOutTime, @SessionType, @Date, @Status)"
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    cmd.Parameters.AddWithValue("@StaffID", staffID)
                    cmd.Parameters.AddWithValue("@CheckInTime", checkInTime)
                    cmd.Parameters.AddWithValue("@CheckOutTime", checkOutTime)
                    cmd.Parameters.AddWithValue("@SessionType", sessionType)
                    cmd.Parameters.AddWithValue("@Date", dateValue)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadAttendanceData()
            MessageBox.Show("Attendance record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the attendance record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnUpdateAttendance(attendanceID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        UpdateAttendance(attendanceID, staffID, checkInTime, checkOutTime, sessionType, dateValue, status)
    End Sub

    Private Sub UpdateAttendance(attendanceID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        Try
            UpdateConnectionString()
            Dim query As String = "UPDATE attendance SET StaffID = @StaffID, CheckInTime = @CheckInTime, CheckOutTime = @CheckOutTime, SessionType = @SessionType, Date = @Date, Status = @Status WHERE AttendanceID = @AttendanceID"
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StaffID", staffID)
                    cmd.Parameters.AddWithValue("@CheckInTime", checkInTime)
                    cmd.Parameters.AddWithValue("@CheckOutTime", checkOutTime)
                    cmd.Parameters.AddWithValue("@SessionType", sessionType)
                    cmd.Parameters.AddWithValue("@Date", dateValue)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadAttendanceData()
            MessageBox.Show("Attendance record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the attendance record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnAddAttendance_Click(sender As Object, e As EventArgs) Handles btnAddAttendance.Click
        Try
            addAttendanceControl.Visible = True
            addAttendanceControl.BringToFront()
            addAttendanceControl.ResetFields() ' Assuming a method to clear fields for a new entry
        Catch ex As Exception
            MessageBox.Show("An error occurred while preparing the form for a new entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
