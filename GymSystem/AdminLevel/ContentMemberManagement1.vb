Imports MySql.Data.MySqlClient

Public Class ContentMemberManagement1
    Dim conn As MySqlConnection
    Dim dtMember As New DataTable()
    Private selectedMemberID As Integer = -1
    Private contentPanel As Panel

    Private currentOffset As Integer = 0
    Private batchSize As Integer = 25
    Private isLoading As Boolean = False
    Private isSearchActive As Boolean = False

    Private filterControl As FilterControl
    Private activeFilters As New List(Of String)
    Private activeGenderFilter As String = ""


    Private memberContextMenu As ContextMenuStrip

    Private Sub ContentMemberManagement1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeContextMenu()
        Dim filterControl As New FilterControl()
        filterControl.SetCheckBoxStates()
        SimulateFilterApplied()
        AddHandler txtBoxSearchInput.TextChanged, AddressOf txtBoxSearchInput_TextChanged
    End Sub

    Private Sub InitializeContextMenu()
        memberContextMenu = New ContextMenuStrip()
        Dim viewItem As New ToolStripMenuItem("View Profile")
        Dim editItem As New ToolStripMenuItem("Edit Member")
        '  Dim deleteItem As New ToolStripMenuItem("Delete Member")

        memberContextMenu.Items.Add(viewItem)
        memberContextMenu.Items.Add(editItem)
        '  memberContextMenu.Items.Add(deleteItem)

        AddHandler viewItem.Click, AddressOf ViewMenuItem_Click
        AddHandler editItem.Click, AddressOf EditMenuItem_Click
        '  AddHandler deleteItem.Click, AddressOf DeleteMenuItem_Click

        MembersTable.ContextMenuStrip = memberContextMenu
    End Sub

    Public Sub SimulateFilterApplied()
        ' Simulate the FilterApplied event
        Dim selectedFilters As New List(Of String) From {"ID", "FirstName", "LastName", "Address"}
        Dim genderFilter As String = "" ' Set the default gender filter

        OnFilterApplied(selectedFilters, genderFilter)
    End Sub




    Private Sub LoadData(Optional searchTerm As String = "")
        If isLoading Then Return
        isLoading = True

        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Try
            conn.Open()

            Dim whereClauses As New List(Of String)
            whereClauses.Add("1=1")

            ' Add gender filter if active
            If Not String.IsNullOrEmpty(activeGenderFilter) Then
                whereClauses.Add($"m.Sex = '{activeGenderFilter}'")
            End If

            ' Add search term filter if provided
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                isSearchActive = True ' Set search flag
                Dim searchCondition As String = $"(CONCAT(m.FirstName, ' ', m.LastName) LIKE '%{searchTerm}%' OR m.MemberID LIKE '%{searchTerm}%' OR m.DTCreated LIKE '%{searchTerm}%' OR m.DOB LIKE '%{searchTerm}%' OR CONCAT(m.Province, ', ', m.City, ', ', m.Street, ', ', m.ZipCode) LIKE '%{searchTerm}%' OR m.Email LIKE '%{searchTerm}%')"
                whereClauses.Add(searchCondition)
            Else
                isSearchActive = False ' Clear search flag
            End If

            Dim whereClause As String = String.Join(" AND ", whereClauses)

            Dim query As String = "SELECT m.MemberID, m.FirstName, m.MiddleName, m.LastName, " &
                                 "ml.Username, m.Sex, m.PhoneNumber, m.DTCreated, " &
                                 "CONCAT(m.Province, ', ', m.City, ', ', m.Street, ', ', m.ZipCode) AS Address, " &
                                 "mm.Cost, mm.MembershipType, mm.Duration, mm.Status " &
                                 "FROM members m " &
                                 "LEFT JOIN memberlogin ml ON m.MemberID = ml.MemberID " &
                                 "LEFT JOIN membership mm ON m.MemberID = mm.MemberID " &
                                 $"WHERE {whereClause} " &
                                 "ORDER BY m.MemberID " &
                                 $"LIMIT {batchSize} OFFSET {currentOffset}"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dtMember = dt ' Replace data for pagination
            MembersTable.DataSource = dtMember

            ' Update button states
            btnNext.Enabled = (dt.Rows.Count = batchSize)
            btnBack.Enabled = (currentOffset > 0)

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
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            isLoading = False
        End Try
        MembersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub



    Public Event ViewMemberProfile(memberData As MemberData)

    Private Sub MembersTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MembersTable.CellDoubleClick
        If e.RowIndex >= 0 Then
            selectedMemberID = MembersTable.Rows(e.RowIndex).Cells("MemberID").Value
            LoadUserControlWithMemberData(selectedMemberID)
        End If
    End Sub

    Private Sub MembersTable_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MembersTable.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            MembersTable.ClearSelection()
            MembersTable.Rows(e.RowIndex).Selected = True
            selectedMemberID = MembersTable.Rows(e.RowIndex).Cells("MemberID").Value
        End If
    End Sub

    Private Sub ViewMenuItem_Click(sender As Object, e As EventArgs)
        If selectedMemberID <> -1 Then
            LoadUserControlWithMemberData(selectedMemberID)
        End If
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        If selectedMemberID <> -1 Then
            Dim memberData As MemberData = GetMemberData(selectedMemberID)
            Dim editPanel As New EditMemberPanel()
            editPanel.LoadMemberData(memberData)

            AddHandler editPanel.MemberUpdated, AddressOf EditPanel_MemberUpdated
            AddHandler editPanel.EditCancelled, AddressOf EditPanel_EditCancelled

            ShowUserControl(editPanel)
        End If
    End Sub

    Private Sub EditPanel_MemberUpdated(sender As Object, e As EventArgs)
        LoadData() ' Refresh the grid
        ShowUserControl(Me) ' Return to the main view
    End Sub

    Private Sub EditPanel_EditCancelled(sender As Object, e As EventArgs)
        ShowUserControl(Me) ' Return to the main view
    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        If selectedMemberID <> -1 Then
            Dim selectedRow As DataGridViewRow = MembersTable.SelectedRows(0)
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()
            Dim fullName As String = $"{firstName} {lastName}"

            Dim resultDelete As DialogResult = MessageBox.Show($"Are you sure you want to delete {fullName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultDelete = DialogResult.Yes Then
                DeleteRow(selectedMemberID)
                MembersTable.Rows.Remove(selectedRow)
                MessageBox.Show("Record deleted successfully for MemberID: " & selectedMemberID)

            End If
        End If
    End Sub


    Private Sub DeleteRow(memberID As Integer)
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            Dim transaction As MySqlTransaction = Nothing
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                ' Delete from payment table
                Dim paymentQuery As String = "DELETE FROM payment WHERE MemberID = @MemberID"
                Using cmdPayment As New MySqlCommand(paymentQuery, conn, transaction)
                    cmdPayment.Parameters.AddWithValue("@MemberID", memberID)
                    cmdPayment.ExecuteNonQuery()
                End Using

                ' Delete from membership table
                Dim membershipQuery As String = "DELETE FROM membership WHERE MemberID = @MemberID"
                Using cmdMembership As New MySqlCommand(membershipQuery, conn, transaction)
                    cmdMembership.Parameters.AddWithValue("@MemberID", memberID)
                    cmdMembership.ExecuteNonQuery()
                End Using

                ' Delete from memberlogin table
                Dim loginQuery As String = "DELETE FROM memberlogin WHERE MemberID = @MemberID"
                Using cmdLogin As New MySqlCommand(loginQuery, conn, transaction)
                    cmdLogin.Parameters.AddWithValue("@MemberID", memberID)
                    cmdLogin.ExecuteNonQuery()
                End Using

                ' Finally, delete from the members table
                Dim memberQuery As String = "DELETE FROM members WHERE MemberID = @MemberID"
                Using cmdMember As New MySqlCommand(memberQuery, conn, transaction)
                    cmdMember.Parameters.AddWithValue("@MemberID", memberID)
                    Dim rowsAffected As Integer = cmdMember.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        transaction.Commit()
                        MessageBox.Show($"Successfully deleted member and all related data for MemberID {memberID}", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Logs("Deleted member and related data for MemberID " & memberID, "Full Member Delete")
                    Else
                        transaction.Rollback()
                        MessageBox.Show($"No record found in members table for MemberID {memberID}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

            Catch ex As Exception
                Try
                    transaction?.Rollback()
                Catch exRollback As Exception
                    ' Log rollback error if necessary
                End Try
                MessageBox.Show("An error occurred while deleting the member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Logs("Error deleting member: " & ex.Message, "Delete Error")
            End Try
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
            Dim query As String = "SELECT m.Weight, m.Height, m.Email, m.DOB, ms.StartDate, ms.EndDate, ms.RenewalPolicy, ms.Benefits, ms.MemberShipName, p.PaymentStatus " &
                              "FROM members m " &
                              "JOIN membership ms ON m.MemberID = ms.MemberID " &
                              "JOIN payment p ON m.MemberID = p.MemberID " &
                              "WHERE m.MemberID = @MemberID " &
                              "ORDER BY p.PaymentID DESC LIMIT 1"
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
                additionalData.PaymentStatus = reader("PaymentStatus").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        Debug.WriteLine("12status: " & additionalData.PaymentStatus)
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
            memberData.PaymentStatus = additionalData.PaymentStatus

            ' Create an instance of the user control
            Dim memberProfileControl As New memberProfileControl()

            ' Load the data for the selected member into the user control
            memberProfileControl.LoadMemberData(memberData)

            Debug.WriteLine("122status: " & memberData.PaymentStatus)

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


    ' Add the WHERE clause based on the selected filter


    ' The AddButtonColumnsIfNeeded method has been removed.

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentOffset += batchSize
        If isSearchActive Then
            LoadData(txtBoxSearchInput.Text.Trim())
        Else
            LoadData()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentOffset >= batchSize Then
            currentOffset -= batchSize
        Else
            currentOffset = 0
        End If

        If isSearchActive Then
            LoadData(txtBoxSearchInput.Text.Trim())
        Else
            LoadData()
        End If
    End Sub

    Private Sub txtBoxSearchInput_TextChanged(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtBoxSearchInput.Text) Then
            currentOffset = 0
            isSearchActive = False
            LoadData()
        End If
    End Sub

    Private Sub LoadMemberProfileControl(memberId As Integer)
        ' Retrieve the selected member's data from the database
        Dim memberData As MemberData = GetMemberData(memberId)

        ' Create an instance of the user control
        Dim memberProfileControl As New memberProfileControl()

        ' Load the data for the selected member into the user control
        memberProfileControl.LoadMemberData(memberData)

        ' Show the user control using the provided function
        ShowUserControl(memberProfileControl)
    End Sub

    Private Function GetMemberData(memberId As Integer) As MemberData
        Dim memberData As New MemberData()
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            Try
                conn.Open()
                Dim query As String = "SELECT m.*, ml.Username FROM members m LEFT JOIN memberlogin ml ON m.MemberID = ml.MemberID WHERE m.MemberID = @MemberID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            memberData.MemberID = CInt(reader("MemberID"))
                            memberData.FirstName = reader("FirstName").ToString()
                            memberData.MiddleName = reader("MiddleName").ToString()
                            memberData.LastName = reader("LastName").ToString()
                            memberData.Username = reader("Username").ToString()
                            memberData.Sex = reader("Sex").ToString()
                            memberData.PhoneNumber = reader("PhoneNumber").ToString()
                            memberData.Province = reader("Province").ToString()
                            memberData.City = reader("City").ToString()
                            memberData.Street = reader("Street").ToString()
                            memberData.ZipCode = reader("ZipCode").ToString()
                            memberData.Status = reader("Status").ToString()
                            memberData.Email = reader("Email").ToString()
                            memberData.Address = $"{reader("Province")}, {reader("City")}, {reader("Street")}, {reader("ZipCode")}"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching member data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
        Return memberData
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        currentOffset = 0
        isSearchActive = True
        LoadData(txtBoxSearchInput.Text.Trim())
    End Sub



    Private Sub txtBoxSearchInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxSearchInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
            e.SuppressKeyPress = True ' Prevent the beep sound on Enter key press
        End If
    End Sub


    Private Sub FilterBtn_Click(sender As Object, e As EventArgs) Handles FilterBtn.Click
        filterControl = New FilterControl()
        filterControl.Location = New Point(FilterBtn.Location.X, FilterBtn.Location.Y + FilterBtn.Height)

        ' Set the initial state with current filters
        filterControl.SetInitialState(activeFilters, activeGenderFilter)

        AddHandler filterControl.FilterApplied, AddressOf OnFilterApplied
        AddHandler filterControl.FilterCancelled, AddressOf OnFilterCancelled
        Panel1.Controls.Add(filterControl)
        filterControl.BringToFront()
    End Sub

    Private Sub OnFilterApplied(selectedFilters As List(Of String), genderFilter As String)
        activeFilters = New List(Of String)(selectedFilters) ' Create a new list to store the filters
        activeGenderFilter = genderFilter
        Panel1.Controls.Remove(filterControl)

        ' Clear the search box
        txtBoxSearchInput.Clear()

        ' Reset the display to show all data with new filters
        LoadData()
    End Sub

    Private Sub OnFilterCancelled()
        Panel1.Controls.Remove(filterControl)

        ' Clear filters
        activeFilters.Clear()
        activeGenderFilter = ""

        ' Clear the search box
        txtBoxSearchInput.Clear()

        ' Reset the display to show all data
        LoadData()
    End Sub


End Class
