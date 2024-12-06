Imports MySql.Data.MySqlClient

Public Class ContentMemberManagement1
    Dim conn As MySqlConnection
    Dim dtMember As New DataTable()
    Private originalValues As New Dictionary(Of Integer, Dictionary(Of String, String))
    Private selectedCell As DataGridViewCell
    Private selectedMemberID As Integer = -1
    Private contentPanel As Panel

    Private currentOffset As Integer = 0
    Private batchSize As Integer = 100
    Private isLoading As Boolean = False

    Private Sub ContentMemberManagement1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        If isLoading Then Return
        isLoading = True

        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Try
            conn.Open()
            ' Retrieve data from members table
            Dim queryMembers As String = $"SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, DTCreated, Province, City, Street, ZipCode, Status FROM members LIMIT {batchSize} OFFSET {currentOffset}"
            Dim adapterMembers As New MySqlDataAdapter(queryMembers, conn)
            Dim dtMembers As New DataTable()
            adapterMembers.Fill(dtMembers)

            ' Retrieve data from memberlogin table
            Dim queryLogin As String = $"SELECT MemberID, Username FROM memberlogin LIMIT {batchSize} OFFSET {currentOffset}"
            Dim adapterLogin As New MySqlDataAdapter(queryLogin, conn)
            Dim dtLogin As New DataTable()
            adapterLogin.Fill(dtLogin)

            ' Retrieve data from membership table
            Dim queryMembership As String = $"SELECT MemberID, Cost, MembershipType, Duration FROM membership LIMIT {batchSize} OFFSET {currentOffset}"
            Dim adapterMembership As New MySqlDataAdapter(queryMembership, conn)
            Dim dtMembership As New DataTable()
            adapterMembership.Fill(dtMembership)

            ' Combine data into a single DataTable
            If currentOffset = 0 Then
                dtMember.Columns.Add("MemberID", GetType(Integer))
                dtMember.Columns.Add("FirstName", GetType(String))
                dtMember.Columns.Add("MiddleName", GetType(String))
                dtMember.Columns.Add("LastName", GetType(String))
                dtMember.Columns.Add("Username", GetType(String))
                dtMember.Columns.Add("Sex", GetType(String))
                dtMember.Columns.Add("PhoneNumber", GetType(String))
                dtMember.Columns.Add("DTCreated", GetType(DateTime))
                dtMember.Columns.Add("Address", GetType(String))
                dtMember.Columns.Add("Cost", GetType(Decimal))
                dtMember.Columns.Add("MembershipType", GetType(String))
                dtMember.Columns.Add("Duration", GetType(String))
                dtMember.Columns.Add("Status", GetType(String))
            End If

            For Each memberRow As DataRow In dtMembers.Rows
                Dim memberID As Integer = memberRow("MemberID")
                Dim firstName As String = memberRow("FirstName").ToString()
                Dim middleName As String = memberRow("MiddleName").ToString()
                Dim lastName As String = memberRow("LastName").ToString()
                Dim username As String = dtLogin.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)?.Field(Of String)("Username")
                Dim address As String = memberRow("Province") & ", " & memberRow("City") & ", " & memberRow("Street") & ", " & memberRow("ZipCode")
                Dim status As String = If(memberRow("Status").ToString() = "True", "Active", "Inactive")
                Dim membershipRow As DataRow = dtMembership.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)

                ' Check if membershipRow is not null
                If membershipRow IsNot Nothing Then
                    dtMember.Rows.Add(memberID, firstName, middleName, lastName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, membershipRow("Cost"), membershipRow("MembershipType"), membershipRow("Duration"), status)
                Else
                    dtMember.Rows.Add(memberID, firstName, middleName, lastName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, DBNull.Value, DBNull.Value, DBNull.Value, status)
                End If
            Next

            ' Add Edit button
            If currentOffset = 0 Then
                Dim editButtonColumn As New DataGridViewButtonColumn()
                editButtonColumn.HeaderText = "Edit"
                editButtonColumn.Name = "Edit"
                editButtonColumn.Text = ""
                editButtonColumn.UseColumnTextForButtonValue = True
                editButtonColumn.MinimumWidth = 60 ' Set a minimum width
                MembersTable.Columns.Add(editButtonColumn)

                ' Add Delete button
                Dim deleteButtonColumn As New DataGridViewButtonColumn()
                deleteButtonColumn.HeaderText = "Delete"
                deleteButtonColumn.Name = "Delete"
                deleteButtonColumn.Text = ""
                deleteButtonColumn.UseColumnTextForButtonValue = True
                deleteButtonColumn.MinimumWidth = 72 ' Set a minimum width
                MembersTable.Columns.Add(deleteButtonColumn)

                ' Add View button
                Dim viewButtonColumn As New DataGridViewButtonColumn()
                viewButtonColumn.HeaderText = "View"
                viewButtonColumn.Name = "View"
                viewButtonColumn.Text = "View"
                viewButtonColumn.UseColumnTextForButtonValue = True
                viewButtonColumn.MinimumWidth = 60 ' Set a minimum width
                MembersTable.Columns.Add(viewButtonColumn)
            End If

            MembersTable.DataSource = dtMember

            ' Customize DataGridView appearance
            MembersTable.BackgroundColor = Color.LightBlue
            MembersTable.Columns("MemberID").HeaderText = "#"
            MembersTable.Columns("FirstName").HeaderText = "First Name"
            MembersTable.Columns("MiddleName").HeaderText = "Middle Name"
            MembersTable.Columns("LastName").HeaderText = "Last Name"
            MembersTable.Columns("Username").HeaderText = "Username"
            MembersTable.Columns("Sex").HeaderText = "Gender"
            MembersTable.Columns("PhoneNumber").HeaderText = "Phone Number"
            MembersTable.Columns("DTCreated").HeaderText = "Date of Registration"
            MembersTable.Columns("Address").HeaderText = "Address"
            MembersTable.Columns("Cost").HeaderText = "Amount"
            MembersTable.Columns("MembershipType").HeaderText = "Chosen Service/s"
            MembersTable.Columns("Duration").HeaderText = "Duration"
            MembersTable.Columns("Status").HeaderText = "Status"
            MembersTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            ' Assuming the parent control's background color is set to a specific color
            Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40) ' Replace Me with the actual parent control if different

            ' Set the background color of the DataGridView to match the parent control's background color
            MembersTable.BackgroundColor = Color.FromArgb(20, 20, 20)

            ' Set the forecolor to white
            MembersTable.DefaultCellStyle.ForeColor = Color.White

            ' Set the background color of the cells to match the parent control's background color
            MembersTable.DefaultCellStyle.BackColor = parentBackgroundColor

            ' Set the background color of the column headers to match the parent control's background color
            MembersTable.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor

            ' Set the background color of the row headers to match the parent control's background color
            MembersTable.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

            MembersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            isLoading = False
        End Try
        MembersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub


    Public Event ViewMemberProfile(memberData As MemberData)
    Private editedRows As New Dictionary(Of Integer, Boolean)
    Private isEditMode As Boolean = False

    Private Sub MembersTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MembersTable.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = MembersTable.Rows(e.RowIndex)
            selectedCell = MembersTable.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim memberId As Integer = selectedRow.Cells("MemberID").Value

            ' Debug: Log the ReadOnly status of each cell in the selected row
            Debug.WriteLine($"Clicked row: {e.RowIndex}, MemberID: {memberId}")
            For Each cell As DataGridViewCell In selectedRow.Cells
                Debug.WriteLine($"Cell [{cell.ColumnIndex}] ReadOnly: {cell.ReadOnly}")
            Next

            If e.ColumnIndex = MembersTable.Columns("Edit").Index Then
                ' Handle Edit button click
                If Not editedRows.ContainsKey(memberId) OrElse Not editedRows(memberId) Then
                    selectedMemberID = memberId
                    StoreOriginalValues(selectedRow)
                    EnableRowEditing(selectedRow)
                    isEditMode = True ' Start edit mode
                    MessageBox.Show("Cells in Selected Row are now EDITABLE for MemberID: " & memberId)
                    ' Debug: Log the state of the DataGridView
                    Debug.WriteLine("Row is now editable for MemberID: " & memberId)
                    For Each cell As DataGridViewCell In selectedRow.Cells
                        Debug.WriteLine("Cell [" & cell.ColumnIndex & "]: ReadOnly = " & cell.ReadOnly)
                    Next
                Else
                    MessageBox.Show("This row is locked and cannot be edited.")
                End If
            ElseIf e.ColumnIndex = MembersTable.Columns("Delete").Index Then
                ' Handle Delete button click
                Dim resultDelete As DialogResult = MessageBox.Show("Do you want to delete the entire row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultDelete = DialogResult.Yes Then
                    ' Delete entire row
                    DeleteRow(memberId)
                    MembersTable.Rows.Remove(selectedRow)
                    MessageBox.Show("Record deleted successfully for MemberID: " & memberId)
                Else
                    ' Ask if set to inactive
                    Dim resultInactive As DialogResult = MessageBox.Show("Do you want to set the member to inactive?", "Set to Inactive", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resultInactive = DialogResult.Yes Then
                        SetMemberInactive(memberId)
                        selectedRow.Cells("Status").Value = "Inactive"
                        MessageBox.Show("Member set to inactive for MemberID: " & memberId)
                        Logs("Status Updated to inactive for MemberID: " & memberId, "Status Update")
                    End If
                End If
            ElseIf e.ColumnIndex = MembersTable.Columns("View").Index Then
                selectedMemberID = memberId
                LoadUserControlWithMemberData(memberId)
            Else
                ' Ensure the row remains read-only if it has been locked
                If isEditMode Then
                    If memberId = selectedMemberID Then
                        If Not editedRows.ContainsKey(memberId) OrElse Not editedRows(memberId) Then
                            For Each cell As DataGridViewCell In selectedRow.Cells
                                cell.ReadOnly = False
                            Next
                            MembersTable.ReadOnly = False
                        Else
                            MessageBox.Show("This row is locked and cannot be edited.")
                        End If
                    Else
                        LockDataGridView()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub DeleteRow(memberID As Integer)
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Using conn
            conn.Open()

            ' Delete from the members table
            Dim query As String = "DELETE FROM members WHERE MemberID = @MemberID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show($"Successfully deleted from members table: MemberID {memberID}", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Logs("Deleted from members table: MemberID " & memberID, "Delete From members Table")
                Else
                    MessageBox.Show($"No record found in members table for MemberID {memberID}", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

            ' Delete from the memberlogin table
            Dim queryLogin As String = "DELETE FROM memberlogin WHERE MemberID = @MemberID"
            Using cmdLogin As New MySqlCommand(queryLogin, conn)
                cmdLogin.Parameters.AddWithValue("@MemberID", memberID)
                Dim rowsAffectedLogin As Integer = cmdLogin.ExecuteNonQuery()
                If rowsAffectedLogin > 0 Then
                    MessageBox.Show($"Successfully deleted from memberlogin table: MemberID {memberID}", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Logs("Deleted from memberlogin table: MemberID " & memberID, "Delete From memberlogin Table")
                Else
                    MessageBox.Show($"No record found in memberlogin table for MemberID {memberID}", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using
    End Sub

    Private Sub SetMemberInactive(memberID As Integer)
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Using conn
            conn.Open()
            Dim query As String = "UPDATE members SET Status = 0 WHERE MemberID = @MemberID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show($"Successfully set to inactive in members table: MemberID {memberID}", "Set Inactive Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"No record found in members table for MemberID {memberID}", "Set Inactive Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End Using
    End Sub


    Private Sub StoreOriginalValues(row As DataGridViewRow)
        Dim memberID As Integer = row.Cells("MemberID").Value
        If Not originalValues.ContainsKey(memberID) Then
            originalValues(memberID) = New Dictionary(Of String, String)()
            For Each cell As DataGridViewCell In row.Cells
                originalValues(memberID)(cell.OwningColumn.Name) = cell.Value.ToString()
            Next
        End If
    End Sub

    Private Sub EnableRowEditing(row As DataGridViewRow)
        ' Make the entire row editable if it is not locked
        Dim memberId As Integer = row.Cells("MemberID").Value
        If Not editedRows.ContainsKey(memberId) OrElse Not editedRows(memberId) Then
            For Each cell As DataGridViewCell In row.Cells
                cell.ReadOnly = False
                Debug.WriteLine("Cell [" & cell.ColumnIndex & "]: ReadOnly = " & cell.ReadOnly)
            Next
            MembersTable.ReadOnly = False
            MembersTable.CurrentCell = row.Cells(0)
            MembersTable.BeginEdit(True)
            Debug.WriteLine("MembersTable.ReadOnly = " & MembersTable.ReadOnly)
        Else
            MessageBox.Show("This row is locked and cannot be edited.")
        End If
    End Sub

    Private Sub LockDataGridView()
        ' Make the entire DataGridView read-only
        For Each row As DataGridViewRow In MembersTable.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.ReadOnly = True
            Next
        Next
        MembersTable.ReadOnly = True
        Debug.WriteLine("All cells in MembersTable are now ReadOnly.")
    End Sub

    Private Sub MembersTable_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles MembersTable.CellBeginEdit
        ' Allow editing if the cell being edited is within the same row as the initially selected cell
        If selectedCell IsNot Nothing AndAlso MembersTable.Rows(e.RowIndex).Cells("MemberID").Value = selectedMemberID Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MembersTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MembersTable.CellEndEdit
        Dim editedRow As DataGridViewRow = MembersTable.Rows(e.RowIndex)
        Dim memberID As Integer = editedRow.Cells("MemberID").Value
        Dim changes As New List(Of String)

        If originalValues.ContainsKey(memberID) Then
            For Each cell As DataGridViewCell In editedRow.Cells
                Dim columnName As String = MembersTable.Columns(cell.ColumnIndex).Name
                If originalValues(memberID)(columnName) <> cell.Value.ToString() Then
                    changes.Add($"{columnName}: {originalValues(memberID)(columnName)} -> {cell.Value}")
                End If
            Next

            If changes.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show($"The following changes were made:{Environment.NewLine}{String.Join(Environment.NewLine, changes)}{Environment.NewLine}Do you want to save these changes?", "Confirm Save", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    SaveEditedRow(editedRow)
                    MessageBox.Show("Changes Saved")
                    Logs($"Edited: {String.Join(Environment.NewLine, changes)}", "Edited Details of the Member with ID: " & memberID)
                    ' Lock the edited row to prevent further editing
                    For Each cell As DataGridViewCell In editedRow.Cells
                        cell.ReadOnly = True
                        Debug.WriteLine($"Cell [{cell.ColumnIndex}] for MemberID: {memberID} is now ReadOnly.")
                    Next
                    editedRows(memberID) = True
                Else
                    ' Revert changes
                    For Each cell As DataGridViewCell In editedRow.Cells
                        Dim columnName As String = MembersTable.Columns(cell.ColumnIndex).Name
                        cell.Value = originalValues(memberID)(columnName)
                    Next
                End If
            End If
        Else
            Debug.WriteLine($"Original values not found for MemberID: {memberID}")
        End If

        ' Prompt to end edit mode
        Dim endEditModeResult As DialogResult = MessageBox.Show("Do you want to end the edit mode?", "End Edit Mode", MessageBoxButtons.YesNo)
        If endEditModeResult = DialogResult.Yes Then
            LockDataGridView()
            isEditMode = False ' End edit mode
            Debug.WriteLine("MembersTable is now ReadOnly.")

            ' Debug: Log the ReadOnly status of each cell in the edited row
            Debug.WriteLine($"Checking ReadOnly status of each cell in row for MemberID: {memberID} after ending edit mode:")
            For Each cell As DataGridViewCell In editedRow.Cells
                Debug.WriteLine($"Cell [{cell.ColumnIndex}] ReadOnly: {cell.ReadOnly}")
            Next
        Else
            MembersTable.ReadOnly = False
            Debug.WriteLine("MembersTable remains editable.")
        End If
    End Sub


    Private Sub SaveEditedRow(row As DataGridViewRow)
        Dim memberID As Integer = row.Cells("MemberID").Value
        Dim firstName As String = row.Cells("FirstName").Value.ToString().Trim()
        Dim middleName As String = row.Cells("MiddleName").Value.ToString().Trim()
        Dim lastName As String = row.Cells("LastName").Value.ToString().Trim()
        Dim sex As String = row.Cells("Sex").Value.ToString().Trim()
        Dim phoneNumber As String = row.Cells("PhoneNumber").Value.ToString().Trim()
        Dim dtCreated As DateTime
        Dim address As String = row.Cells("Address").Value.ToString().Trim()
        Dim cost As Decimal = 0
        Dim membershipType As String = String.Empty
        Dim duration As String = String.Empty
        Dim statusInput As String = row.Cells("Status").Value.ToString().Trim().ToLower()

        ' Check for blank or space-only values
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(sex) OrElse String.IsNullOrWhiteSpace(phoneNumber) OrElse String.IsNullOrWhiteSpace(address) Then
            MessageBox.Show("Fields cannot be blank or contain only spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate phone number format
        If Not System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^09\d{9}$") Then
            MessageBox.Show("Phone number must start with '09' followed by 9 other digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate status format
        If statusInput <> "active" AndAlso statusInput <> "inactive" Then
            MessageBox.Show("Status must be 'active' or 'inactive'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convert status to 1 or 0
        Dim status As Integer = If(statusInput = "active", 1, 0)

        ' Check for invalid number formats
        If Not DateTime.TryParse(row.Cells("DTCreated").Value.ToString(), dtCreated) Then
            MessageBox.Show("Invalid date format for Date of Registration.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Separate address components
        Dim addressParts As String() = address.Split(","c)
        If addressParts.Length < 4 OrElse addressParts.Any(Function(part) String.IsNullOrWhiteSpace(part.Trim())) Then
            MessageBox.Show("Address must be in the format: Province, City, Street, ZipCode.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim province As String = addressParts(0).Trim()
        Dim city As String = addressParts(1).Trim()
        Dim street As String = addressParts(2).Trim()
        Dim zipCode As String = addressParts(3).Trim()

        ' Retrieve cost, membership type, and duration from membership table
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Using conn
            conn.Open()
            Dim queryMembership As String = "SELECT Cost, MembershipType, Duration FROM membership WHERE MemberID = @MemberID"
            Using cmdMembership As New MySqlCommand(queryMembership, conn)
                cmdMembership.Parameters.AddWithValue("@MemberID", memberID)
                Using reader As MySqlDataReader = cmdMembership.ExecuteReader()
                    If reader.Read() Then
                        cost = Convert.ToDecimal(reader("Cost"))
                        membershipType = reader("MembershipType").ToString().Trim()
                        duration = reader("Duration").ToString().Trim()
                    End If
                End Using
            End Using

            ' Update the members table with the edited values
            Dim query As String = "UPDATE members SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Sex = @Sex, PhoneNumber = @PhoneNumber, DTCreated = @DTCreated, Province = @Province, City = @City, Street = @Street, ZipCode = @ZipCode, Status = @Status WHERE MemberID = @MemberID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@Sex", sex)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@DTCreated", dtCreated)
                cmd.Parameters.AddWithValue("@Province", province)
                cmd.Parameters.AddWithValue("@City", city)
                cmd.Parameters.AddWithValue("@Street", street)
                cmd.Parameters.AddWithValue("@ZipCode", zipCode)
                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                cmd.ExecuteNonQuery()
            End Using

            ' Update the memberlogin table with the edited username
            Dim username As String = row.Cells("Username").Value.ToString().Trim()
            If String.IsNullOrWhiteSpace(username) Then
                MessageBox.Show("Username cannot be blank or contain only spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim queryLogin As String = "UPDATE memberlogin SET Username = @Username WHERE MemberID = @MemberID"
            Using cmdLogin As New MySqlCommand(queryLogin, conn)
                cmdLogin.Parameters.AddWithValue("@Username", username)
                cmdLogin.Parameters.AddWithValue("@MemberID", memberID)
                cmdLogin.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub MembersTable_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles MembersTable.CellPainting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            If MembersTable.Columns(e.ColumnIndex).Name = "Edit" OrElse MembersTable.Columns(e.ColumnIndex).Name = "Delete" OrElse MembersTable.Columns(e.ColumnIndex).Name = "View" Then
                ' Paint the cell background
                e.PaintBackground(e.CellBounds, True)

                ' Set the button colors
                Dim buttonColor As Color = Color.FromArgb(40, 40, 40) ' Background color
                Dim textColor As Color = Color.White ' Foreground color

                ' Draw the button background
                Using brush As New SolidBrush(buttonColor)
                    e.Graphics.FillRectangle(brush, e.CellBounds)
                End Using

                ' Draw the icon
                Dim icon As Bitmap
                If MembersTable.Columns(e.ColumnIndex).Name = "Edit" Then
                    icon = My.Resources.edit1 ' Access the edit icon from resources
                ElseIf MembersTable.Columns(e.ColumnIndex).Name = "Delete" Then
                    icon = My.Resources.delete1 ' Access the delete icon from resources
                Else
                    icon = My.Resources.View ' Access the view icon from resources
                End If
                e.Graphics.DrawImage(icon, e.CellBounds.Left + 5, e.CellBounds.Top + (e.CellBounds.Height - icon.Height) \ 2)

                ' Draw the button text
                Dim buttonText As String = If(MembersTable.Columns(e.ColumnIndex).Name = "Edit", "Edit", If(MembersTable.Columns(e.ColumnIndex).Name = "Delete", "Delete", "View"))
                TextRenderer.DrawText(e.Graphics, buttonText, e.CellStyle.Font, New Rectangle(e.CellBounds.Left + icon.Width + 10, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height), textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)

                e.Handled = True
            End If
        End If
    End Sub


    Public Sub New(contentPnl As Panel)

        ' This call is required by the designer.
        InitializeComponent()
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(600, 500)

        Me.contentPanel = contentPnl

    End Sub

    Private Function GetAdditionalMemberData(memberId As Integer) As MemberData
        UpdateConnectionString()
        Dim conn As New MySqlConnection(strConnection)
        Dim additionalData As New MemberData()
        Try
            conn.Open()
            Dim query As String = "SELECT m.Weight, m.Height, m.Email, m.DOB, ms.StartDate, ms.EndDate, ms.RenewalPolicy, ms.Benefits, ms.MemberShipName " &
                              "FROM members m " &
                              "JOIN membership ms ON m.MemberID = ms.MemberID " &
                              "WHERE m.MemberID = @MemberID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MemberID", memberId)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                additionalData.Weight = Decimal.Parse(reader("Weight").ToString())
                additionalData.Height = Decimal.Parse(reader("Height").ToString())
                additionalData.Email = reader("Email").ToString()
                additionalData.DOB = DateTime.Parse(reader("DOB").ToString())
                additionalData.StartDate = DateTime.Parse(reader("StartDate").ToString())
                additionalData.EndDate = DateTime.Parse(reader("EndDate").ToString())
                additionalData.RenewalPolicy = reader("RenewalPolicy").ToString()
                additionalData.Benefits = reader("Benefits").ToString()
                additionalData.MemberShipName = reader("MemberShipName").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        Return additionalData
    End Function



    Private Sub LoadUserControlWithMemberData(memberId As Integer)
        ' Retrieve the selected member's data from the DataGridView
        Dim selectedRow As DataGridViewRow = MembersTable.Rows.Cast(Of DataGridViewRow)().Where(Function(row) CInt(row.Cells("MemberID").Value) = memberId).FirstOrDefault()
        If selectedRow IsNot Nothing Then
            Dim memberData As New MemberData() With {
            .MemberID = CInt(selectedRow.Cells("MemberID").Value),
            .FirstName = selectedRow.Cells("FirstName").Value.ToString(),
            .MiddleName = selectedRow.Cells("MiddleName").Value.ToString(),
            .LastName = selectedRow.Cells("LastName").Value.ToString(),
            .Username = selectedRow.Cells("Username").Value.ToString(),
            .Sex = selectedRow.Cells("Sex").Value.ToString(),
            .PhoneNumber = selectedRow.Cells("PhoneNumber").Value.ToString(),
            .DTCreated = DateTime.Parse(selectedRow.Cells("DTCreated").Value.ToString()),
            .Address = selectedRow.Cells("Address").Value.ToString(),
            .Cost = Decimal.Parse(selectedRow.Cells("Cost").Value.ToString()),
            .MembershipType = selectedRow.Cells("MembershipType").Value.ToString(),
            .Duration = selectedRow.Cells("Duration").Value.ToString(),
            .Status = selectedRow.Cells("Status").Value.ToString()
        }

            ' Fetch additional data from the database
            Dim additionalData As MemberData = GetAdditionalMemberData(memberId)
            memberData.Weight = additionalData.Weight
            memberData.Height = additionalData.Height
            memberData.Email = additionalData.Email
            memberData.DOB = additionalData.DOB
            memberData.Benefits = additionalData.Benefits
            memberData.StartDate = additionalData.StartDate
            memberData.EndDate = additionalData.EndDate
            memberData.MemberShipName = additionalData.MemberShipName
            memberData.RenewalPolicy = additionalData.RenewalPolicy

            ' Create an instance of the user control
            Dim memberProfileControl As New memberProfileControl()

            ' Load the data for the selected member into the user control
            memberProfileControl.LoadMemberData(memberData)

            ' Show the user control using the provided function
            ShowUserControl(memberProfileControl)
        End If
    End Sub

    Private Sub ShowUserControl(control As UserControl)
        control.Dock = DockStyle.Fill
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(control)
        contentPanel.AutoScroll = True
        contentPanel.AutoScrollMinSize = New Size(600, 500)
        control.BringToFront()
    End Sub

    'Search
    Private Sub FilterMembersTable(searchText As String)
        ' Retrieve data from members table
        Dim queryMembers As String = $"SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, DTCreated, Province, City, Street, ZipCode, Status FROM members WHERE FirstName LIKE '%{searchText}%' OR LastName LIKE '%{searchText}%' OR MemberID LIKE '%{searchText}%'"
        Dim adapterMembers As New MySqlDataAdapter(queryMembers, conn)
        Dim dtMembers As New DataTable()
        adapterMembers.Fill(dtMembers)

        ' Retrieve data from memberlogin table
        Dim queryLogin As String = "SELECT MemberID, Username FROM memberlogin"
        Dim adapterLogin As New MySqlDataAdapter(queryLogin, conn)
        Dim dtLogin As New DataTable()
        adapterLogin.Fill(dtLogin)

        ' Retrieve data from membership table
        Dim queryMembership As String = "SELECT MemberID, Cost, MembershipType, Duration FROM membership"
        Dim adapterMembership As New MySqlDataAdapter(queryMembership, conn)
        Dim dtMembership As New DataTable()
        adapterMembership.Fill(dtMembership)

        ' Combine data into a single DataTable
        Dim dtMember As New DataTable()
        dtMember.Columns.Add("MemberID", GetType(Integer))
        dtMember.Columns.Add("FirstName", GetType(String))
        dtMember.Columns.Add("MiddleName", GetType(String))
        dtMember.Columns.Add("LastName", GetType(String))
        dtMember.Columns.Add("Username", GetType(String))
        dtMember.Columns.Add("Sex", GetType(String))
        dtMember.Columns.Add("PhoneNumber", GetType(String))
        dtMember.Columns.Add("DTCreated", GetType(DateTime))
        dtMember.Columns.Add("Address", GetType(String))
        dtMember.Columns.Add("Cost", GetType(Decimal))
        dtMember.Columns.Add("MembershipType", GetType(String))
        dtMember.Columns.Add("Duration", GetType(String))
        dtMember.Columns.Add("Status", GetType(String))

        For Each memberRow As DataRow In dtMembers.Rows
            Dim memberID As Integer = memberRow("MemberID")
            Dim firstName As String = memberRow("FirstName").ToString()
            Dim middleName As String = memberRow("MiddleName").ToString()
            Dim lastName As String = memberRow("LastName").ToString()
            Dim username As String = dtLogin.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)?.Field(Of String)("Username")
            Dim address As String = memberRow("Province") & ", " & memberRow("City") & ", " & memberRow("Street") & ", " & memberRow("ZipCode")
            Dim status As String = If(memberRow("Status").ToString() = "True", "Active", "Inactive")
            Dim membershipRow As DataRow = dtMembership.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)

            ' Check if membershipRow is not null
            If membershipRow IsNot Nothing Then
                dtMember.Rows.Add(memberID, firstName, middleName, lastName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, membershipRow("Cost"), membershipRow("MembershipType"), membershipRow("Duration"), status)
            Else
                dtMember.Rows.Add(memberID, firstName, middleName, lastName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, DBNull.Value, DBNull.Value, DBNull.Value, status)
            End If
        Next

        ' Bind DataTable to DataGridView


        ' Add Edit, Delete, and View buttons
        If MembersTable.Columns("Edit") Is Nothing Then
            Dim editButtonColumn As New DataGridViewButtonColumn()
            editButtonColumn.HeaderText = "Edit"
            editButtonColumn.Name = "Edit"
            editButtonColumn.Text = "Edit"
            editButtonColumn.UseColumnTextForButtonValue = True
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            MembersTable.Columns.Add(editButtonColumn)
        End If

        If MembersTable.Columns("Delete") Is Nothing Then
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            MembersTable.Columns.Add(deleteButtonColumn)
        End If

        If MembersTable.Columns("View") Is Nothing Then
            Dim viewButtonColumn As New DataGridViewButtonColumn()
            viewButtonColumn.HeaderText = "View"
            viewButtonColumn.Name = "View"
            viewButtonColumn.Text = "View"
            viewButtonColumn.UseColumnTextForButtonValue = True
            viewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            MembersTable.Columns.Add(viewButtonColumn)
        End If

        MembersTable.DataSource = dtMember
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtBoxSearchInput.Text
        FilterMembersTable(searchText)
    End Sub

    Private Sub txtBoxSearchInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxSearchInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True ' Prevent the beep sound on Enter key press
        End If
    End Sub

    Private Sub btnLoadMore_Click(sender As Object, e As EventArgs) Handles btnLoadMore.Click
        currentOffset += batchSize
        LoadData()
    End Sub
End Class
