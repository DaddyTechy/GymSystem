Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ContentStaffManageForm
    Inherits Form

    Private Function GenerateRandomString(length As Integer) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim random As New Random()
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function

    Private Sub ContentStaffManageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbxSEFFname_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFFname.TextChanged

    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check phone number format
        If Not Regex.IsMatch(txtbxSEFpnumber.Text, "^\d{11}$") Then
            MessageBox.Show("Phone number must be 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check salary format
        Dim salary As Decimal
        If Not Decimal.TryParse(txtbxSEFsalary.Text, salary) Then
            MessageBox.Show("Salary must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check email format
        If Not Regex.IsMatch(txtbxSEFemail.Text, "^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Email must be in a valid format (e.g., user@example.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function


    Private Sub txtbxPNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxSEFpnumber.KeyPress, txtbxSEFsalary.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnSubmitSEF_Click(sender As Object, e As EventArgs) Handles btnSubmitSEF.Click
        Try
            ' Validate inputs
            If Not ValidateInputs() Then
                Exit Sub
            End If

            ' Step 2: Retrieve input values from text boxes
            Dim firstName As String = txtbxSEFFname.Text
            Dim middleName As String = txtbxSEFMname.Text
            Dim lastName As String = txtboxSEFLname.Text
            Dim hireDate As Date = DTPSEFhiredate.Value
            Dim salary As Decimal = Decimal.Parse(txtbxSEFsalary.Text)
            Dim email As String = txtbxSEFemail.Text
            Dim specialize As String = CBSEFspecialize.Text
            Dim position As String = CBSEFpos.Text
            Dim phoneNumber As String = txtbxSEFpnumber.Text
            Dim experience As String = txtbxSEFexp.Text
            Dim shiftSchedule As String = CBSEFshiftsch.Text
            Dim certification As String = CBSEFcertif.Text

            ' Check if any required text boxes are empty
            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(specialize) OrElse String.IsNullOrWhiteSpace(position) OrElse String.IsNullOrWhiteSpace(phoneNumber) OrElse String.IsNullOrWhiteSpace(experience) OrElse String.IsNullOrWhiteSpace(shiftSchedule) OrElse String.IsNullOrWhiteSpace(certification) Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Step 3: Create SQL INSERT statement for staff
            Dim query As String = $"INSERT INTO staff (FirstName, MiddleName, LastName, HireDate, Email, Specialization, Position, Salary, PhoneNumber, Experience, ShiftSchedule, Certification) " &
                              $"VALUES ('{firstName}', '{middleName}', '{lastName}', '{hireDate:yyyy-MM-dd}', '{email}', '{specialize}', '{position}', {salary}, '{phoneNumber}', '{experience}', '{shiftSchedule}', '{certification}')"

            ' Step 4: Execute the SQL statement using readQuery
            readQuery(query)

            ' Retrieve the StaffID of the newly added staff
            Dim staffID As Integer = Convert.ToInt32(executeSelectQuery("SELECT LAST_INSERT_ID()"))

            ' Generate username and random password
            Dim username As String = (firstName & lastName).ToLower()
            Dim password As String = GenerateRandomString(12)
            Dim encryptedPassword As String = Encrypt(password) ' Implement your encryption method
            Dim isEncrypted As Boolean = True

            ' Step 5: Create SQL INSERT statement for staff login
            Dim loginQuery As String = $"INSERT INTO stafflogin (StaffID, Username, Password, Email, PhoneNumber, EncryptedPassword, IsEncrypted) " &
                                   $"VALUES ({staffID}, '{username}', '{password}', '{email}', '{phoneNumber}', '{encryptedPassword}', {isEncrypted})"

            ' Execute the SQL statement using readQuery
            readQuery(loginQuery)

            ' Show success message with account details
            Dim accountDetails As String = $"Staff details added successfully.{Environment.NewLine}Username: {staffID}{Environment.NewLine}Password: {password}{Environment.NewLine}Copy the password to not forget it."
            Dim accountDetailsForm As New AccountDetailsForm(accountDetails)
            accountDetailsForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the staff details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Hide()
    End Sub



    Private Sub CBSEFspecialize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEFspecialize.SelectedIndexChanged

    End Sub

    Private Sub txtbxSEFMname_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFMname.TextChanged

    End Sub

    Private Sub txtboxSEFLname_TextChanged(sender As Object, e As EventArgs) Handles txtboxSEFLname.TextChanged

    End Sub

    Private Sub txtbxSEFemail_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFemail.TextChanged

    End Sub

    Private Sub txtbxSEFpnumber_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFpnumber.TextChanged

    End Sub

    Private Sub txtbxSEFsalary_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFsalary.TextChanged

    End Sub

    Private Sub DTPSEFhiredate_ValueChanged(sender As Object, e As EventArgs) Handles DTPSEFhiredate.ValueChanged

    End Sub

    Private Sub txtbxSEFexp_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFexp.TextChanged

    End Sub

    Private Sub CBSEFpos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEFpos.SelectedIndexChanged

    End Sub

    Private Sub CBSEFshiftsch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEFshiftsch.SelectedIndexChanged

    End Sub

    Private Sub CBSEFcertif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEFcertif.SelectedIndexChanged

    End Sub



End Class
