Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class EditMemberProfileForm
    Private memberId As Integer

    Public Sub New(currentMemberId As Integer, contact As String, email As String, weight As Decimal, height As Decimal)
        InitializeComponent()
        memberId = currentMemberId

        ' Populate the textboxes with the current data
        txtContact.Text = contact
        txtEmail.Text = email
        txtWeight.Text = weight.ToString()
        txtHeight.Text = height.ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' --- Input Validation ---
        If Not IsNumeric(txtContact.Text) OrElse txtContact.Text.Length < 10 Then
            MessageBox.Show("Please enter a valid contact number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim mail As New System.Net.Mail.MailAddress(txtEmail.Text)
        Catch ex As FormatException
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        If Not IsNumeric(txtWeight.Text) OrElse CDec(txtWeight.Text) <= 0 Then
            MessageBox.Show("Please enter a valid weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsNumeric(txtHeight.Text) OrElse CDec(txtHeight.Text) <= 0 Then
            MessageBox.Show("Please enter a valid height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Database Update ---
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "UPDATE members SET PhoneNumber = @Phone, Email = @Email, Weight = @Weight, Height = @Height WHERE MemberID = @MemberID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Phone", txtContact.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Weight", CDec(txtWeight.Text))
                    cmd.Parameters.AddWithValue("@Height", CDec(txtHeight.Text))
                    cmd.Parameters.AddWithValue("@MemberID", memberId)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating your profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
