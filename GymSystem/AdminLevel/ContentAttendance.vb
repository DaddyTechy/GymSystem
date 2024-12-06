Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ContentAttendance

    Private Sub LoadAttendanceData()
        UpdateConnectionString()
        Dim query As String = $"SELECT a.AttendanceID, a.StaffID, a.MemberID, a.Date, a.CheckInTime, a.CheckOutTime, a.SessionType, a.Status " &
                          $"FROM attendance a"
        LoadToDGV(query, attendanceDGV)

        ' Set the properties for attendanceDGV
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40) ' Replace with the actual parent control if different

        ' Set the background color of the DataGridView to match the parent control's background color
        attendanceDGV.BackgroundColor = Color.FromArgb(20, 20, 20)

        ' Set the forecolor to white
        attendanceDGV.DefaultCellStyle.ForeColor = Color.White

        ' Set the background color of the cells to match the parent control's background color
        attendanceDGV.DefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the column headers to match the parent control's background color
        attendanceDGV.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the row headers to match the parent control's background color
        attendanceDGV.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Additional properties copied from MembersTable
        attendanceDGV.AllowUserToAddRows = False
        attendanceDGV.AllowUserToDeleteRows = False
        attendanceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        attendanceDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        attendanceDGV.BorderStyle = BorderStyle.None
        attendanceDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 10.0F)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        attendanceDGV.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        attendanceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        cellStyle.Font = New Font("Segoe UI", 9.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.True
        attendanceDGV.DefaultCellStyle = cellStyle

        attendanceDGV.Dock = DockStyle.Fill
        attendanceDGV.EditMode = DataGridViewEditMode.EditOnEnter
        attendanceDGV.EnableHeadersVisualStyles = False
        attendanceDGV.GridColor = Color.White
        attendanceDGV.MultiSelect = False
        attendanceDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Dim rowHeaderStyle As New DataGridViewCellStyle()
        rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        rowHeaderStyle.BackColor = SystemColors.WindowFrame
        rowHeaderStyle.Font = New Font("Segoe UI", 9.75F)
        rowHeaderStyle.ForeColor = Color.White
        rowHeaderStyle.SelectionBackColor = SystemColors.Highlight
        rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        rowHeaderStyle.WrapMode = DataGridViewTriState.True
        attendanceDGV.RowHeadersDefaultCellStyle = rowHeaderStyle

        attendanceDGV.RowHeadersVisible = False
        attendanceDGV.RowHeadersWidth = 51

        Dim rowsStyle As New DataGridViewCellStyle()
        rowsStyle.BackColor = Color.FromArgb(40, 40, 40)
        rowsStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rowsStyle.ForeColor = Color.White
        attendanceDGV.RowsDefaultCellStyle = rowsStyle

        attendanceDGV.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        attendanceDGV.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        attendanceDGV.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.0F)
        attendanceDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        attendanceDGV.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        attendanceDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        attendanceDGV.ShowCellErrors = False
        attendanceDGV.ShowRowErrors = False

        ' Check if Edit and Delete columns already exist
        If attendanceDGV.Columns("Edit") Is Nothing Then
            ' Add Edit button
            Dim editButtonColumn As New DataGridViewButtonColumn()
            editButtonColumn.Name = "Edit"
            editButtonColumn.HeaderText = "Edit"
            editButtonColumn.Text = "Edit"
            editButtonColumn.UseColumnTextForButtonValue = True
            editButtonColumn.FlatStyle = FlatStyle.Flat
            editButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            attendanceDGV.Columns.Add(editButtonColumn)
        End If

        If attendanceDGV.Columns("Delete") Is Nothing Then
            ' Add Delete button
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            deleteButtonColumn.FlatStyle = FlatStyle.Flat
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            attendanceDGV.Columns.Add(deleteButtonColumn)
        End If

        ' Add columns to the DataGridView
        attendanceDGV.Columns("AttendanceID").HeaderText = "Attendance #"
        attendanceDGV.Columns("StaffID").HeaderText = "Staff ID"
        attendanceDGV.Columns("MemberID").HeaderText = "Member ID"
        attendanceDGV.Columns("Date").HeaderText = "Date"
        attendanceDGV.Columns("CheckInTime").HeaderText = "Check-In Time"
        attendanceDGV.Columns("CheckOutTime").HeaderText = "Check-Out Time"
        attendanceDGV.Columns("SessionType").HeaderText = "Session Type"
        attendanceDGV.Columns("Status").HeaderText = "Status"
    End Sub

    Private Sub attendanceDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles attendanceDGV.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = attendanceDGV.Columns("Edit").Index Then
                ' Handle Edit button click
                Dim attendanceID As Integer = If(attendanceDGV.Rows(e.RowIndex).Cells("AttendanceID").Value IsNot Nothing, Convert.ToInt32(attendanceDGV.Rows(e.RowIndex).Cells("AttendanceID").Value), 0)
                EditAttendance(attendanceID, e.RowIndex)
            ElseIf e.ColumnIndex = attendanceDGV.Columns("Delete").Index Then
                ' Handle Delete button click
                Dim attendanceID As Integer = If(attendanceDGV.Rows(e.RowIndex).Cells("AttendanceID").Value IsNot Nothing, Convert.ToInt32(attendanceDGV.Rows(e.RowIndex).Cells("AttendanceID").Value), 0)
                DeleteAttendance(attendanceID)
            ElseIf e.ColumnIndex = attendanceDGV.Columns("CheckInTime").Index OrElse e.ColumnIndex = attendanceDGV.Columns("CheckOutTime").Index Then
                ' Show DateTimePicker for CheckInTime and CheckOutTime cells
                ShowDateTimePicker(e.RowIndex, e.ColumnIndex)
            End If
        End If
    End Sub

    Private Sub EditAttendance(attendanceID As Integer, rowIndex As Integer)
        ' Enable editing for the entire row
        For Each cell As DataGridViewCell In attendanceDGV.Rows(rowIndex).Cells
            cell.ReadOnly = False
        Next
        MessageBox.Show("You can now edit the selected row.")

        ' Handle the DateTimePicker for CheckInTime and CheckOutTime cells
        AddHandler attendanceDGV.CellBeginEdit, AddressOf attendanceDGV_CellBeginEdit
        AddHandler attendanceDGV.CellEndEdit, AddressOf attendanceDGV_CellEndEdit
    End Sub

    Private Sub DeleteAttendance(attendanceID As Integer)
        ' Implement logic to delete the attendance record
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete attendance record with ID: {attendanceID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = $"DELETE FROM attendance WHERE AttendanceID = {attendanceID}"
            readQuery(query)
            ' Refresh the DataGridView
            LoadAttendanceData()
        End If
    End Sub

    Private Sub ShowDateTimePicker(rowIndex As Integer, columnIndex As Integer)
        Dim dtp As New DateTimePicker()
        dtp.Format = DateTimePickerFormat.Time
        dtp.ShowUpDown = True
        dtp.Location = attendanceDGV.GetCellDisplayRectangle(columnIndex, rowIndex, True).Location
        dtp.Width = attendanceDGV.Columns(columnIndex).Width

        ' Add the DateTimePicker to the DataGridView
        attendanceDGV.Controls.Add(dtp)

        ' Set the initial value of the DateTimePicker to the cell value
        If attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing Then
            Dim cellValue As Object = attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value
            If TypeOf cellValue Is TimeSpan Then
                dtp.Value = DateTime.Today.Add(CType(cellValue, TimeSpan))
            Else
                dtp.Value = Convert.ToDateTime(cellValue)
            End If
        End If

        ' Handle the DateTimePicker's ValueChanged event
        AddHandler dtp.ValueChanged, Sub(sender, e)
                                         Dim timeValue As TimeSpan = dtp.Value.TimeOfDay
                                         If timeValue.TotalHours < 24 Then
                                             attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value = timeValue
                                         Else
                                             HandleError("Invalid time input. Please enter a valid time in HH:mm:ss format.")
                                         End If
                                     End Sub

        ' Handle the DateTimePicker's LostFocus event to remove it
        AddHandler dtp.LostFocus, Sub(sender, e)
                                      attendanceDGV.Controls.Remove(dtp)
                                  End Sub

        ' Focus the DateTimePicker
        dtp.Focus()
    End Sub


    Private Sub ShowComboBox(rowIndex As Integer, columnIndex As Integer)
        Dim comboBox As New ComboBox()
        comboBox.Items.AddRange(New String() {"Fitness", "Endurance", "Sauna"}) ' Add your session types here
        comboBox.DropDownStyle = ComboBoxStyle.DropDown
        comboBox.Location = attendanceDGV.GetCellDisplayRectangle(columnIndex, rowIndex, True).Location
        comboBox.Width = attendanceDGV.Columns(columnIndex).Width

        ' Add the ComboBox to the DataGridView
        attendanceDGV.Controls.Add(comboBox)

        ' Set the initial value of the ComboBox to the cell value
        If attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing Then
            comboBox.SelectedItem = attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value.ToString()
        End If

        ' Handle the ComboBox's SelectedIndexChanged event
        AddHandler comboBox.SelectedIndexChanged, Sub(sender, e)
                                                      attendanceDGV.Rows(rowIndex).Cells(columnIndex).Value = comboBox.SelectedItem.ToString()
                                                  End Sub

        ' Handle the ComboBox's LostFocus event to remove it
        AddHandler comboBox.LostFocus, Sub(sender, e)
                                           attendanceDGV.Controls.Remove(comboBox)
                                       End Sub

        ' Focus the ComboBox
        comboBox.Focus()
    End Sub

    Private Sub attendanceDGV_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles attendanceDGV.CellBeginEdit
        Dim row As DataGridViewRow = attendanceDGV.Rows(e.RowIndex)
        Dim isNewRow As Boolean = row.Cells("AttendanceID").Value Is Nothing OrElse row.Cells("AttendanceID").Value.ToString() = String.Empty

        If isNewRow Then
            ' Enable editing for all cells in the new row
            For Each cell As DataGridViewCell In row.Cells
                cell.ReadOnly = False
            Next

            ' Show appropriate control based on the column
            If e.ColumnIndex = attendanceDGV.Columns("CheckInTime").Index OrElse e.ColumnIndex = attendanceDGV.Columns("CheckOutTime").Index Then
                ' Show DateTimePicker for CheckInTime and CheckOutTime cells
                ShowDateTimePicker(e.RowIndex, e.ColumnIndex)
            ElseIf e.ColumnIndex = attendanceDGV.Columns("SessionType").Index Then
                ' Show ComboBox for SessionType cell
                ShowComboBox(e.RowIndex, e.ColumnIndex)
            End If
        End If
    End Sub
    ' Method to handle the CellEndEdit event for the DataGridView
    Private Sub attendanceDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles attendanceDGV.CellEndEdit
        Try
            Dim row As DataGridViewRow = attendanceDGV.Rows(e.RowIndex)
            Dim editCheckInTime As String = row.Cells("CheckInTime").Value?.ToString()
            Dim editCheckOutTime As String = row.Cells("CheckOutTime").Value?.ToString()

            ' Update the status based on CheckInTime and CheckOutTime
            If Not String.IsNullOrEmpty(editCheckInTime) AndAlso Not String.IsNullOrEmpty(editCheckOutTime) Then
                row.Cells("Status").Value = "Present"
            Else
                row.Cells("Status").Value = "Absent"
            End If

            ' Validate the entire row
            If ValidateRow(row) Then
                ' Prompt the user to continue editing or save the changes
                Dim result As DialogResult = MessageBox.Show("Do you want to continue editing?", "Continue Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    ' Prompt the user to save the changes and display summary
                    Dim summary As String = GetSummary(row)
                    Dim saveResult As DialogResult = MessageBox.Show($"{summary}{Environment.NewLine}Do you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If saveResult = DialogResult.Yes Then
                        Try
                            ' Save the edited or new row
                            Dim attendanceID As Integer = Convert.ToInt32(row.Cells("AttendanceID").Value)
                            Dim memberID As Integer = Convert.ToInt32(row.Cells("MemberID").Value)
                            Dim staffID As Integer = Convert.ToInt32(row.Cells("StaffID").Value)
                            Dim editCheckInTimeSpan As TimeSpan = TimeSpan.Parse(row.Cells("CheckInTime").Value.ToString())
                            Dim editCheckOutTimeSpan As TimeSpan = TimeSpan.Parse(row.Cells("CheckOutTime").Value.ToString())
                            Dim sessionType As String = row.Cells("SessionType").Value.ToString()
                            Dim dateValue As DateTime = DateTime.Parse(row.Cells("Date").Value.ToString())
                            Dim status As String = row.Cells("Status").Value.ToString()

                            ' Update the attendance record
                            UpdateAttendance(attendanceID, memberID, staffID, editCheckInTimeSpan, editCheckOutTimeSpan, sessionType, dateValue, status)

                            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' End edit mode and lock the DataGridView
                            attendanceDGV.ReadOnly = True
                        Catch ex As Exception
                            MessageBox.Show($"An error occurred: {ex.Message}. Please correct the error and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        ' Go back to editing
                        attendanceDGV.CurrentCell = attendanceDGV.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        attendanceDGV.BeginEdit(True)
                    End If
                End If
            End If
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show($"An error occurred: {ex.Message}. Please ensure the index is within the valid range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetSummary(row As DataGridViewRow) As String
        Dim summary As New StringBuilder()
        summary.AppendLine("Summary of changes:")
        summary.AppendLine($"Member ID: {row.Cells("MemberID").Value}")
        summary.AppendLine($"Staff ID: {row.Cells("StaffID").Value}")
        summary.AppendLine($"Check-In Time: {row.Cells("CheckInTime").Value}")
        summary.AppendLine($"Check-Out Time: {row.Cells("CheckOutTime").Value}")
        summary.AppendLine($"Session Type: {row.Cells("SessionType").Value}")
        summary.AppendLine($"Date: {row.Cells("Date").Value}")
        summary.AppendLine($"Status: {row.Cells("Status").Value}")
        Return summary.ToString()
    End Function

    Private Function ValidateRow(row As DataGridViewRow) As Boolean
        Try
            ' Validate CheckInTime
            Dim checkInTime As TimeSpan
            If Not TimeSpan.TryParse(row.Cells("CheckInTime").Value?.ToString(), checkInTime) Then
                HandleError("Invalid CheckInTime format. Please enter the time in HH:mm:ss format.")
                Return False
            End If

            ' Validate CheckOutTime
            Dim checkOutTime As TimeSpan
            If Not TimeSpan.TryParse(row.Cells("CheckOutTime").Value?.ToString(), checkOutTime) Then
                HandleError("Invalid CheckOutTime format. Please enter the time in HH:mm:ss format.")
                Return False
            End If

            ' Validate MemberID
            Dim memberID As Integer
            If Not Integer.TryParse(row.Cells("MemberID").Value?.ToString(), memberID) Then
                HandleError("Invalid MemberID format. Please enter a valid integer.")
                Return False
            End If

            ' Validate StaffID
            Dim staffID As Integer
            If Not Integer.TryParse(row.Cells("StaffID").Value?.ToString(), staffID) Then
                HandleError("Invalid StaffID format. Please enter a valid integer.")
                Return False
            End If

            ' Validate SessionType
            Dim sessionType As String = row.Cells("SessionType").Value?.ToString()
            If String.IsNullOrEmpty(sessionType) Then
                HandleError("SessionType cannot be empty. Please enter a valid session type.")
                Return False
            End If

            ' Validate Date
            Dim currDate As DateTime
            If Not DateTime.TryParse(row.Cells("Date").Value?.ToString(), currDate) Then
                HandleError("Invalid Date format. Please enter the date in yyyy-MM-dd format.")
                Return False
            End If

            ' Validate Status
            Dim status As String = row.Cells("Status").Value?.ToString()
            If String.IsNullOrEmpty(status) Then
                HandleError("Status cannot be empty. Please enter a valid status.")
                Return False
            End If

            Return True
        Catch ex As Exception
            HandleError($"An error occurred during validation: {ex.Message}")
            Return False
        End Try
    End Function


    Private Sub HandleError(errorMessage As String)
        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' DataError Event Handler
    Private Sub attendanceDGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles attendanceDGV.DataError
        Dim errorMessage As String = $"An error occurred in column '{attendanceDGV.Columns(e.ColumnIndex).HeaderText}' at row {e.RowIndex + 1}. " &
                                 $"Error: {e.Exception.Message}"
        HandleError(errorMessage)
        e.ThrowException = False ' Prevent the exception from being thrown again
    End Sub


    Private Sub ContentAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attendanceDGV.ReadOnly = True
        LoadAttendanceData()
    End Sub

    Private Sub txtUserInput_TextChanged(sender As Object, e As EventArgs) Handles txtUserInput.TextChanged
        Dim searchText As String = txtUserInput.Text
        FilterAttendanceTable(searchText)
    End Sub


    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim searchText As String = txtUserInput.Text
        FilterAttendanceTable(searchText)
    End Sub

    Private Sub FilterAttendanceTable(searchText As String)
        ' Retrieve data from attendance table
        Dim queryAttendance As String = $"SELECT a.AttendanceID, a.MemberID, CONCAT(m.FirstName, ' ', m.LastName) AS MemberFullName, a.CheckInTime, a.CheckOutTime, a.SessionType, a.Date AS currDate, a.StaffID, a.Status " &
                                    $"FROM attendance a " &
                                    $"JOIN members m ON a.MemberID = m.MemberID " &
                                    $"WHERE m.FirstName LIKE '%{searchText}%' OR m.LastName LIKE '%{searchText}%' OR a.MemberID LIKE '%{searchText}%'"
        Dim adapterAttendance As New MySqlDataAdapter(queryAttendance, conn)
        Dim dtAttendance As New DataTable()
        adapterAttendance.Fill(dtAttendance)

        ' Bind DataTable to DataGridView
        attendanceDGV.DataSource = dtAttendance

        ' Add Edit and Delete buttons
        If attendanceDGV.Columns("Edit") Is Nothing Then
            Dim editButtonColumn As New DataGridViewButtonColumn()
            editButtonColumn.HeaderText = "Edit"
            editButtonColumn.Name = "Edit"
            editButtonColumn.Text = "Edit"
            editButtonColumn.UseColumnTextForButtonValue = True
            attendanceDGV.Columns.Add(editButtonColumn)
        End If

        If attendanceDGV.Columns("Delete") Is Nothing Then
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            attendanceDGV.Columns.Add(deleteButtonColumn)
        End If
    End Sub

    Private addAttendanceControl As AddAttendanceControl

    Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Initialize the AddAttendanceControl
            addAttendanceControl = New AddAttendanceControl()
            addAttendanceControl.AttendanceDataGridView = attendanceDGV ' Set the reference to the DataGridView

            ' Add the AddAttendanceControl to the form
            Me.Controls.Add(addAttendanceControl)
            addAttendanceControl.Visible = False

            ' Add any initialization after the InitializeComponent() call.
            AddHandler addAttendanceControl.SaveAttendance, AddressOf OnSaveAttendance
        End Sub


    ' Button click event to show the AddAttendanceControl
    Private Sub btnAddAttendance_Click(sender As Object, e As EventArgs) Handles btnAddAttendance.Click
        addAttendanceControl.Location = New Point(100, 200)

        ' Set the size of the AddAttendanceControl
        addAttendanceControl.Size = New Size(405, 486) ' Set the desired size

        ' Add the AddAttendanceControl to the form
        If Not Controls.Contains(addAttendanceControl) Then
            Controls.Add(addAttendanceControl)
            Debug.WriteLine("AddAttendanceControl added to the form.")
        Else
            Debug.WriteLine("AddAttendanceControl already exists on the form.")
        End If

        addAttendanceControl.BringToFront()
        addAttendanceControl.Visible = True
        Debug.WriteLine("AddAttendanceControl is now visible.")
    End Sub


    Private Sub OnSaveAttendance(memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        Try
            ' Insert the new attendance record into the attendance table
            Dim query As String = $"INSERT INTO attendance (MemberID, StaffID, CheckInTime, CheckOutTime, SessionType, Date, Status) " &
                                  $"VALUES ({memberID}, {staffID}, '{checkInTime}', '{checkOutTime}', '{sessionType}', '{dateValue:yyyy-MM-dd}', '{status}')"
            readQuery(query)

            ' Refresh the DataGridView
            LoadToDGV("SELECT * FROM attendance", attendanceDGV)
            MessageBox.Show("Attendance record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the attendance record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to update an existing attendance record
    Private Sub UpdateAttendance(attendanceID As Integer, memberID As Integer, staffID As Integer, checkInTime As TimeSpan, checkOutTime As TimeSpan, sessionType As String, dateValue As DateTime, status As String)
        Try
            ' Update the existing attendance record in the attendance table
            Dim query As String = $"UPDATE attendance SET MemberID = {memberID}, StaffID = {staffID}, CheckInTime = '{checkInTime}', CheckOutTime = '{checkOutTime}', " &
                                  $"SessionType = '{sessionType}', Date = '{dateValue:yyyy-MM-dd}', Status = '{status}' WHERE AttendanceID = {attendanceID}"
            readQuery(query)

            ' Refresh the DataGridView
            LoadToDGV("SELECT * FROM attendance", attendanceDGV)
            MessageBox.Show("Attendance record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the attendance record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Method to show the attendance DataGridView
    Private Sub ShowAttendanceList()
            ' Implement the logic to display the attendance DataGridView
            ' For example, you can make the attendance DataGridView visible
            attendanceDGV.Visible = True
            ' Optionally, you can bring the DataGridView to the front
            attendanceDGV.BringToFront()
        End Sub


    End Class
