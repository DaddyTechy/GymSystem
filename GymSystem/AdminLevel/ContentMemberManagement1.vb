Imports MySql.Data.MySqlClient

Public Class ContentMemberManagement1
    Dim conn As MySqlConnection
    Dim dtMember As New DataTable()

    Private Sub ContentMemberManagement1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=gym_infosys")
        Try
            conn.Open()

            ' Retrieve data from members table
            Dim queryMembers As String = "SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, DTCreated, Province, City, Street, ZipCode FROM members"
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
            dtMember.Columns.Add("MemberID", GetType(Integer))
            dtMember.Columns.Add("FullName", GetType(String))
            dtMember.Columns.Add("Username", GetType(String))
            dtMember.Columns.Add("Sex", GetType(String))
            dtMember.Columns.Add("PhoneNumber", GetType(String))
            dtMember.Columns.Add("DTCreated", GetType(DateTime))
            dtMember.Columns.Add("Address", GetType(String))
            dtMember.Columns.Add("Cost", GetType(Decimal))
            dtMember.Columns.Add("MembershipType", GetType(String))
            dtMember.Columns.Add("Duration", GetType(String))

            For Each memberRow As DataRow In dtMembers.Rows
                Dim memberID As Integer = memberRow("MemberID")
                Dim fullName As String = memberRow("FirstName") & " " & memberRow("MiddleName") & " " & memberRow("LastName")
                Dim username As String = dtLogin.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)?.Field(Of String)("Username")
                Dim address As String = memberRow("Province") & ", " & memberRow("City") & ", " & memberRow("Street") & ", " & memberRow("ZipCode")
                Dim membershipRow As DataRow = dtMembership.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("MemberID") = memberID)

                ' Check if membershipRow is not null
                If membershipRow IsNot Nothing Then
                    dtMember.Rows.Add(memberID, fullName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, membershipRow("Cost"), membershipRow("MembershipType"), membershipRow("Duration"))
                Else
                    dtMember.Rows.Add(memberID, fullName, username, memberRow("Sex"), memberRow("PhoneNumber"), memberRow("DTCreated"), address, DBNull.Value, DBNull.Value, DBNull.Value)
                End If
            Next

            ' Bind DataTable to DataGridView
            MembersTable.DataSource = dtMember

            ' Add Edit and Delete buttons
            Dim editButtonColumn As New DataGridViewButtonColumn()
            editButtonColumn.HeaderText = "Edit"
            editButtonColumn.Name = "Edit"
            editButtonColumn.Text = "Edit"
            editButtonColumn.UseColumnTextForButtonValue = True
            MembersTable.Columns.Add(editButtonColumn)

            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            MembersTable.Columns.Add(deleteButtonColumn)

            ' Customize DataGridView appearance
            MembersTable.BackgroundColor = Color.LightBlue
            MembersTable.Columns("MemberID").HeaderText = "#"
            MembersTable.Columns("FullName").HeaderText = "Full Name"
            MembersTable.Columns("Username").HeaderText = "Username"
            MembersTable.Columns("Sex").HeaderText = "Gender"
            MembersTable.Columns("PhoneNumber").HeaderText = "Phone Number"
            MembersTable.Columns("DTCreated").HeaderText = "Date of Registration"
            MembersTable.Columns("Address").HeaderText = "Address"
            MembersTable.Columns("Cost").HeaderText = "Amount"
            MembersTable.Columns("MembershipType").HeaderText = "Chosen Service/s"
            MembersTable.Columns("Duration").HeaderText = "Duration"
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

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub MembersTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MembersTable.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = MembersTable.Rows(e.RowIndex)
            If e.ColumnIndex = MembersTable.Columns("Edit").Index Then
                ' Handle Edit button click
                Dim memberID As Integer = selectedRow.Cells("MemberID").Value
                EnableRowEditing(selectedRow)
                MessageBox.Show("Edit button clicked for MemberID: " & memberID)
            ElseIf e.ColumnIndex = MembersTable.Columns("Delete").Index Then
                ' Handle Delete button click
                Dim memberID As Integer = selectedRow.Cells("MemberID").Value
                ' Add your delete logic here
                MessageBox.Show("Delete button clicked for MemberID: " & memberID)
            End If
        End If
    End Sub

    Private Sub EnableRowEditing(row As DataGridViewRow)
        ' Make the row editable
        For Each cell As DataGridViewCell In row.Cells
            cell.ReadOnly = False
        Next
    End Sub

    Private Sub SaveEditedRow(row As DataGridViewRow)
        Dim memberID As Integer = row.Cells("MemberID").Value
        Dim fullName As String = row.Cells("FullName").Value.ToString()
        Dim nameParts As String() = fullName.Split(" "c)
        Dim firstName As String = nameParts(0)
        Dim middleName As String = If(nameParts.Length > 2, nameParts(1), "")
        Dim lastName As String = If(nameParts.Length > 2, nameParts(2), nameParts(1))

        ' Update the database with the edited values
        Using conn As New MySqlConnection("server=127.0.0.1;userid=root;password='';database=gym_infosys")
            conn.Open()
            Dim query As String = "UPDATE members SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName WHERE MemberID = @MemberID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub MembersTable_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles MembersTable.CellPainting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            If MembersTable.Columns(e.ColumnIndex).Name = "Edit" OrElse MembersTable.Columns(e.ColumnIndex).Name = "Delete" Then
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
                    icon = My.Resources.edit ' Access the edit icon from resources
                Else
                    icon = My.Resources.delete ' Access the delete icon from resources
                End If
                e.Graphics.DrawImage(icon, e.CellBounds.Left + 5, e.CellBounds.Top + (e.CellBounds.Height - icon.Height) \ 2)

                ' Draw the button text
                Dim buttonText As String = If(MembersTable.Columns(e.ColumnIndex).Name = "Edit", "Edit", "Delete")
                TextRenderer.DrawText(e.Graphics, buttonText, e.CellStyle.Font, New Rectangle(e.CellBounds.Left + icon.Width + 10, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height), textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)

                e.Handled = True
            End If
        End If
    End Sub


    Private Sub MembersTable_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles MembersTable.DataBindingComplete
        ' Clear the initial selection
        Me.MembersTable.ClearSelection()
        ' Remove the event handler to allow future selections
        RemoveHandler MembersTable.DataBindingComplete, AddressOf MembersTable_DataBindingComplete
    End Sub
End Class
