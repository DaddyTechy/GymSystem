Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim input As String = txtEmailOrPhone.Text
            Dim role As String = cmbRole.SelectedItem.ToString()

            If String.IsNullOrEmpty(input) Then
                ErrorHandler.HandleInputError("Please enter your email or phone number.")
                Return
            End If

            Dim password As String = GetPassword(input, role)

            If Not String.IsNullOrEmpty(password) Then
                MessageBox.Show("Your password is: " & password, "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ErrorHandler.HandleError(ex)
        End Try
    End Sub

    Private Function GetPassword(input As String, role As String) As String
        Dim password As String = String.Empty
        Dim tableName As String = String.Empty

        Select Case role
            Case "Member"
                tableName = "memberlogin"
            Case "Staff"
                tableName = "stafflogin"
            Case "Admin"
                tableName = "adminlogin"
        End Select

        Try
            Using conn As New MySqlConnection("server=127.0.0.1;userid=root;password='';database=gym_infosys2;")
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT Password FROM " & tableName & " WHERE Email = @Input OR PhoneNumber = @Input", conn)
                cmd.Parameters.AddWithValue("@Input", input)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    password = reader("Password").ToString()
                End If
            End Using
        Catch ex As Exception
            ErrorHandler.HandleError(ex)
        End Try

        Return password
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSubmit.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class

