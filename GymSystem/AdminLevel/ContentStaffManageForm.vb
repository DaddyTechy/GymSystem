Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Imports System.Data.SqlClient

Public Class ContentStaffManageForm
    Inherits Form

    Private Sub ContentStaffManageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbxSEFFname_TextChanged(sender As Object, e As EventArgs) Handles txtbxSEFFname.TextChanged

    End Sub

    Private Sub btnSubmitSEF_Click(sender As Object, e As EventArgs) Handles btnSubmitSEF.Click
        Try
            ' Step 2: Retrieve input values from text boxes
            Dim firstName As String = txtbxSEFFname.Text
            Dim middleName As String = txtbxSEFMname.Text
            Dim lastName As String = txtboxSEFLname.Text
            Dim hireDate As Date = DTPSEFhiredate.Value
            Dim salary As Decimal = 0
            Dim email As String = txtbxSEFemail.Text
            Dim specialize As String = CBSEFspecialize.Text
            Dim position As String = CBSEFpos.Text
            Dim phoneNumber As String = txtbxSEFpnumber.Text
            Dim experience As String = txtbxSEFexp.Text
            Dim shiftSchedule As String = CBSEFshiftsch.Text
            Dim certification As String = CBSEFcertif.Text


            ' Check if any required text boxes are empty
            If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(middleName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(txtbxSEFsalary.Text) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(specialize) OrElse String.IsNullOrWhiteSpace(position) OrElse String.IsNullOrWhiteSpace(phoneNumber) OrElse String.IsNullOrWhiteSpace(experience) OrElse String.IsNullOrWhiteSpace(shiftSchedule) OrElse String.IsNullOrWhiteSpace(certification) Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Parse salary
            salary = Decimal.Parse(txtbxSEFsalary.Text)

            ' Step 3: Create SQL INSERT statement
            Dim query As String = $"INSERT INTO staff (FirstName, MiddleName, LastName, HireDate, Email, Specialization, Position, Salary, PhoneNumber, Experience, ShiftSchedule, Certification) " &
                                  $"VALUES ('{firstName}', '{middleName}', '{lastName}', '{hireDate:yyyy-MM-dd}', '{email}', '{specialize}', '{position}', {salary}, '{phoneNumber}', '{experience}', '{shiftSchedule}', '{certification}')"

            ' Step 4: Execute the SQL statement using readQuery
            readQuery(query)

            ' Show success message
            MessageBox.Show("Staff details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
