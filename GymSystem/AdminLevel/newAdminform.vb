Imports MySql.Data.MySqlClient
Imports Mysqlx.Datatypes
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class newAdminform

    ' Function to retrieve values from text boxes and combo boxes
    Private Function RetrieveValues() As Dictionary(Of String, Object)
        Dim values As New Dictionary(Of String, Object) From {
        {"FirstName", If(txtbxFname.Text, String.Empty)},
        {"MiddleName", If(txtbxMname.Text, String.Empty)},
        {"LastName", If(txtbxLname.Text, String.Empty)},
        {"Email", If(txtxtbxEmail.Text, String.Empty)},
        {"PhoneNumber", If(txtbxPNumber.Text, String.Empty)},
        {"HireDate", DTPhiredate.Value.ToString("yyyy-MM-dd HH:mm:ss")},
        {"Salary", If(txtbxSalary.Text, String.Empty)},
        {"Status", If(CBStatus.SelectedItem?.ToString(), String.Empty)},
        {"Specialization", If(txtbxSpecial.Text, String.Empty)},
        {"Experience", If(txtbxExp.Text, String.Empty)},
        {"LastLogin", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},
        {"Role", If(CBRole.SelectedItem?.ToString(), String.Empty)},
        {"AdminName", If(txtbxAdminName.Text, String.Empty)},
        {"AdminPass", If(txtbxAdminPass.Text, String.Empty)},
        {"AdminPass2", If(txtbxAdminPass2.Text, String.Empty)}
    }
        Return values
    End Function


    ' Function to validate input values
    Private Function ValidateInputs(values As Dictionary(Of String, Object)) As Boolean
        ' Check mandatory fields
        If String.IsNullOrWhiteSpace(values("FirstName").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("LastName").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Email").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("PhoneNumber").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Specialization").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Experience").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Salary").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Role").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("Status").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("AdminName").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("AdminPass").ToString()) OrElse
           String.IsNullOrWhiteSpace(values("AdminPass2").ToString()) Then
            MessageBox.Show("All fields are mandatory.")
            Return False
        End If

        ' Check phone number format
        If Not Regex.IsMatch(values("PhoneNumber").ToString(), "^\d{11}$") Then
            MessageBox.Show("Phone number must be 11 digits.")
            Return False
        End If

        ' Check salary format
        Dim salary As Decimal
        If Not Decimal.TryParse(values("Salary").ToString(), salary) Then
            MessageBox.Show("Salary must be a valid number.")
            Return False
        End If

        ' Check email format
        If Not Regex.IsMatch(values("Email").ToString(), "^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Email must be in a valid format (e.g., user@example.com).")
            Return False
        End If

        ' Ensure passwords match
        If values("AdminPass").ToString() <> values("AdminPass2").ToString() Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        Return True
    End Function

    ' Function to insert values into the admin table
    Private Sub InsertIntoAdmin(values As Dictionary(Of String, Object))
        Try
            ' Construct the SQL query
            Dim query As String = $"INSERT INTO admin (FirstName, MiddleName, LastName, Email, PhoneNumber, HireDate, Salary, Status, Specialization, Experience, LastLogin, Role) VALUES ('{values("FirstName")}', '{values("MiddleName")}', '{values("LastName")}', '{values("Email")}', '{values("PhoneNumber")}', '{values("HireDate")}', '{values("Salary")}', '{values("Status")}', '{values("Specialization")}', '{values("Experience")}', '{values("LastLogin")}', '{values("Role")}')"

            ' Execute the query using readQuery
            readQuery(query)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertIntoAdminLogin(values As Dictionary(Of String, Object))
        Try
            ' Encrypt the password before inserting it into the database
            Dim encryptedPassword As String = Encrypt(values("AdminPass").ToString())

            ' Construct the SQL query
            Dim query As String = $"INSERT INTO adminlogin (AdminID, Username, EncryptedPassword, Email, PhoneNumber, Role) VALUES (LAST_INSERT_ID(), '{values("AdminName")}', '{encryptedPassword}', '{values("Email")}', '{values("PhoneNumber")}', '{values("Role")}')"

            ' Execute the query using readQuery
            readQuery(query)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the admin login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Function to create a new admin
    Public Sub CreateNewAdmin()
        Dim values = RetrieveValues()

        ' Validate inputs
        If Not ValidateInputs(values) Then
            Return
        End If

        ' Insert into admin table
        InsertIntoAdmin(values)

        ' Insert into adminlogin table
        InsertIntoAdminLogin(values)

        MessageBox.Show("New admin account created successfully.")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            CreateNewAdmin()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Event handler to make Experience text box expandable when Enter key is pressed
    Private Sub txtbxExp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxExp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbxExp.ScrollBars = ScrollBars.Vertical
            txtbxExp.Multiline = True
            txtbxExp.Height = 65 ' Adjust the height as needed
        End If
    End Sub

    ' Event handler to return Experience text box to original size when it loses focus
    Private Sub txtbxExp_Leave(sender As Object, e As EventArgs) Handles txtbxExp.Leave
        txtbxExp.ScrollBars = ScrollBars.None
        txtbxExp.Multiline = True ' Keep multiline to retain new lines
        txtbxExp.Height = 23 ' Adjust the height to original size
    End Sub

    ' Event handler to return Experience text box to original size when clicking anywhere else on the form
    Private Sub Form_Click(sender As Object, e As EventArgs) Handles Me.Click, txtbxFname.Click, txtbxMname.Click, txtbxLname.Click, txtxtbxEmail.Click, txtbxPNumber.Click, DTPhiredate.Click, txtbxSalary.Click, CBStatus.Click, txtbxSpecial.Click, txtbxAdminName.Click, txtbxAdminPass.Click, txtbxAdminPass2.Click, btnSubmit.Click
        txtbxExp.ScrollBars = ScrollBars.None
        txtbxExp.Multiline = True ' Keep multiline to retain new lines
        txtbxExp.Height = 23 ' Adjust the height to original size
    End Sub


    ' Event handler to ensure Phone Number and Salary only accept numbers
    Private Sub txtbxPNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPNumber.KeyPress, txtbxSalary.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub newAdminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
    End Sub
End Class
