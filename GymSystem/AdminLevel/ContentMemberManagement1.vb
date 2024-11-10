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

    Private Sub MembersTable_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles MembersTable.DataBindingComplete
        ' Clear the initial selection
        Me.MembersTable.ClearSelection()
        ' Remove the event handler to allow future selections
        RemoveHandler MembersTable.DataBindingComplete, AddressOf MembersTable_DataBindingComplete
    End Sub



End Class
