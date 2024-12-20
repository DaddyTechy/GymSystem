﻿Imports MySql.Data.MySqlClient

Public Class Staff
    Private originalColor As Color = Color.FromArgb(245, 203, 92)
    Private originalButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverDarkenAmount As Single = 0.7
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create a main panel to hold all controls
        Dim mainPanel As New Panel()
        mainPanel.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        mainPanel.Location = New Point(0, 0)
        mainPanel.Anchor = AnchorStyles.None
        mainPanel.Dock = DockStyle.None

        ' Remove underline from link labels
        ForgotLL.LinkBehavior = LinkBehavior.NeverUnderline
        MemberLL.LinkBehavior = LinkBehavior.NeverUnderline
        AdminLL.LinkBehavior = LinkBehavior.NeverUnderline

        ' Use a Panel to simulate TextBox border color change
        Dim textBoxPanel As New Panel()
        textBoxPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        textBoxPanel.Size = New Size(IDBox.Width + 2, IDBox.Height + 2) ' Add space for border
        textBoxPanel.Location = New Point(IDBox.Location.X - 0, IDBox.Location.Y - 0)

        ' Add TextBox to Panel
        textBoxPanel.Controls.Add(IDBox)
        IDBox.Location = New Point(1, 1)

        ' Add Panel to the main panel
        mainPanel.Controls.Add(textBoxPanel)

        ' Repeat for PassBox
        Dim passBoxPanel As New Panel()
        passBoxPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        passBoxPanel.Size = New Size(PassBox.Width + 2, PassBox.Height + 2) ' Add space for border
        passBoxPanel.Location = New Point(PassBox.Location.X - 0, PassBox.Location.Y - 0)

        ' Add TextBox to Panel
        passBoxPanel.Controls.Add(PassBox)
        PassBox.Location = New Point(1, 1)

        ' Add Panel to the main panel
        mainPanel.Controls.Add(passBoxPanel)

        ' Use a Panel to simulate Button border color change
        Dim buttonPanel As New Panel()
        buttonPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        buttonPanel.Size = New Size(LoginBtn.Width + 4, LoginBtn.Height + 4) ' Add space for border
        buttonPanel.Location = New Point(LoginBtn.Location.X - 2, LoginBtn.Location.Y - 2)

        ' Set Button properties
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.BackColor = Color.FromArgb(245, 203, 92) ' Button background color

        ' Add Button to Panel
        buttonPanel.Controls.Add(LoginBtn)
        LoginBtn.Location = New Point(2, 2)

        ' Add Panel to the main panel
        mainPanel.Controls.Add(buttonPanel)


        ' Add the main panel to the form
        Me.Controls.Add(mainPanel)

        ' Initialize button colors
        originalButtonColor = LoginBtn.BackColor
        hoverButtonColor = ControlPaint.Dark(originalButtonColor, hoverDarkenAmount)

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub IDBox_TextChanged(sender As Object, e As EventArgs) Handles IDBox.TextChanged
        ' Ensure IDBox text length does not exceed 11 characters
        If IDBox.Text.Length > 11 Then
            IDBox.Text = IDBox.Text.Substring(0, 11)
            IDBox.SelectionStart = IDBox.Text.Length ' Move cursor to end
            MessageBox.Show("ID cannot exceed 11 characters.")
        End If

        ' Filter out invalid characters
        Dim validText As String = New String(IDBox.Text.Where(Function(c) Char.IsDigit(c) OrElse c = "-"c).ToArray())
        If validText <> IDBox.Text Then
            IDBox.Text = validText
            IDBox.SelectionStart = IDBox.Text.Length ' Move cursor to end
        End If
    End Sub

    Private Sub IDBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDBox.KeyPress
        ' Allow only numbers and hyphen
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub LoginBtn_MouseEnter(sender As Object, e As EventArgs) Handles LoginBtn.MouseEnter
        LoginBtn.BackColor = hoverButtonColor
        LoginBtn.ForeColor = Color.White
    End Sub

    Private Sub LoginBtn_MouseLeave(sender As Object, e As EventArgs) Handles LoginBtn.MouseLeave
        LoginBtn.BackColor = originalButtonColor
        LoginBtn.ForeColor = Color.Black
    End Sub
    Private Sub ForgotLL_MouseEnter(sender As Object, e As EventArgs) Handles ForgotLL.MouseEnter
        ForgotLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub ForgotLL_MouseLeave(sender As Object, e As EventArgs) Handles ForgotLL.MouseLeave
        ForgotLL.LinkColor = originalColor
    End Sub

    Private Sub StaffLL_MouseEnter(sender As Object, e As EventArgs) Handles MemberLL.MouseEnter
        MemberLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub MemberLL_MouseLeave(sender As Object, e As EventArgs) Handles MemberLL.MouseLeave
        MemberLL.LinkColor = originalColor
    End Sub

    Private Sub AdminLL_MouseEnter(sender As Object, e As EventArgs) Handles AdminLL.MouseEnter
        AdminLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub AdminLL_MouseLeave(sender As Object, e As EventArgs) Handles AdminLL.MouseLeave
        AdminLL.LinkColor = originalColor
    End Sub

    Private Sub ForgotLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotLL.LinkClicked
        Dim forgotPasswordForm As New ForgotPasswordForm()
        forgotPasswordForm.ShowDialog()
    End Sub

    Public Sub ShowUserControlInForm(control As UserControl, formTitle As String)
        ' Create a new form to host the UserControl
        Dim hostForm As New Form()
        hostForm.Text = formTitle
        hostForm.MinimumSize = New Size(925, 580)
        hostForm.WindowState = FormWindowState.Maximized ' You can adjust the size as needed
        hostForm.Controls.Add(control)
        control.Dock = DockStyle.Fill
        hostForm.Show()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim staffID As Integer
        If Integer.TryParse(IDBox.Text, staffID) Then
            Dim password As String = PassBox.Text

            ' Authenticate user
            Dim user = AuthenticateStaff(staffID, password)
            If user IsNot Nothing Then
                ' Show the main staff form
                Dim staffMain As New Staffmain()
                staffMain.ConfigureMenu("Staff")
                ShowUserControlInForm(staffMain, "Staff Main")
                Me.Hide()
                Logs($"staff with ID: {CurrentLoggedUser.id} logged in", "stafflogin")
            Else
                MessageBox.Show("Invalid StaffID or password.")
            End If
        Else
            MessageBox.Show("Please enter a valid StaffID.")
        End If
    End Sub

    Private Function AuthenticateStaff(staffID As Integer, password As String) As StaffUser
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Debug.WriteLine("Connection opened successfully.")

                Dim query As String = "SELECT * FROM stafflogin WHERE StaffID = @StaffID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StaffID", staffID)
                Debug.WriteLine($"Executing query: {query} with StaffID: {staffID}")

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Debug.WriteLine("User found in database.")

                    ' List available columns in the result set
                    For i As Integer = 0 To reader.FieldCount - 1
                        Debug.WriteLine($"Column {i}: {reader.GetName(i)}")
                    Next

                    ' Retrieve the encrypted password and IsEncrypted flag from the database
                    Dim storedPassword As String = reader("Password").ToString()
                    Dim isEncrypted As Boolean = Convert.ToBoolean(reader("IsEncrypted"))
                    Debug.WriteLine($"Stored password: {storedPassword}, IsEncrypted: {isEncrypted}")

                    ' Decrypt the stored password if it is encrypted
                    Dim decryptedPassword As String
                    If isEncrypted Then
                        decryptedPassword = storedPassword
                    Else
                        ' Encrypt the plain password and update the database
                        Dim encryptedPassword As String = Encrypt(storedPassword)
                        Dim updateQuery As String = $"UPDATE stafflogin SET EncryptedPassword = '{encryptedPassword}', IsEncrypted = TRUE WHERE StaffID = {staffID}"
                        readQuery(updateQuery)
                        Debug.WriteLine($"Updated database with encrypted password: {encryptedPassword}")

                        ' Set the decrypted password to the original plain password
                        decryptedPassword = storedPassword
                    End If
                    Debug.WriteLine($"Decrypted password: {decryptedPassword}")

                    ' Compare the decrypted password with the entered password
                    If decryptedPassword = password Then
                        Debug.WriteLine("Password matches.")

                        ' Create a StaffUser object to hold the user details
                        Dim user As New StaffUser()
                        user.StaffID = reader("StaffID")
                        user.Username = reader("Username")
                        user.Role = "Staff" ' Corrected the role assignment

                        ' Set the current logged user after successful login
                        CurrentLoggedUser.id = user.StaffID
                        CurrentLoggedUser.name = user.Username
                        ' ... set other fields as needed

                        ' Access the current logged user's details
                        MsgBox("Welcome, Staff: " & staffID & " " & CurrentLoggedUser.name & "!")

                        Logs($"Staff user {user.Username} logged in", "Login")

                        ' Return the user object
                        Return user
                    Else
                        Debug.WriteLine("Password does not match.")
                        ' Return Nothing if the password does not match
                        Return Nothing
                    End If
                Else
                    Debug.WriteLine("User not found in database.")
                    ' Return Nothing if no user is found
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error: {ex.Message}")
            ErrorHandler.HandleError(ex)
            Return Nothing
        End Try
    End Function



    Public Class StaffUser
        Public Property StaffID As Integer
        Public Property Username As String
        Public Property Role As String
    End Class


    Private Sub EncryptExistingStaffPasswords()
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT StaffID, password FROM stafflogin WHERE IsEncrypted = False"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Using writer As New System.IO.StreamWriter("encrypted_staff_passwords.txt", True)
                    While reader.Read()
                        Dim staffID As Integer = reader("StaffID")
                        Dim plainPassword As String = reader("Password").ToString()
                        Dim encryptedPassword As String = Encrypt(plainPassword)

                        ' Save the encrypted password to a file
                        writer.WriteLine($"{staffID}, {encryptedPassword}")

                        ' Update the password to encrypted and set IsEncrypted to TRUE
                        Dim updateQuery As String = $"UPDATE stafflogin SET EncryptedPassword = '{encryptedPassword}', IsEncrypted = TRUE WHERE StaffID = {staffID}"
                        readQuery(updateQuery)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while encrypting existing staff passwords: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MemberLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MemberLL.LinkClicked
        ' Navigate to Staff form
        Dim staffForm As New Member()
        staffForm.Show()
        Me.Hide()
    End Sub

    Private Sub AdminLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminLL.LinkClicked
        Dim adminform As New Admin
        adminform.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private caretHandler As New CaretHandler()

    Private Sub ID_GotFocus(sender As Object, e As EventArgs) Handles IDBox.GotFocus
        caretHandler.InitializeCaret(IDBox, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub IDBox_LostFocus(sender As Object, e As EventArgs) Handles IDBox.LostFocus
        caretHandler.HideCaret(IDBox)
    End Sub

    Private Sub PasswordBoxFocus(sender As Object, e As EventArgs) Handles PassBox.GotFocus
        caretHandler.InitializeCaret(PassBox, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub PasswordBox_LostFocus(sender As Object, e As EventArgs) Handles PassBox.LostFocus
        caretHandler.HideCaret(PassBox)
    End Sub

End Class
