

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Admin
    Private originalColor As Color = Color.FromArgb(245, 203, 92)
    Private originalButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverDarkenAmount As Single = 0.7

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a main panel to hold all controls
        Dim mainPanel As New Panel()
        mainPanel.Size = New Size(925, 580)
        mainPanel.Location = New Point(0, 0)
        mainPanel.Anchor = AnchorStyles.None
        mainPanel.Dock = DockStyle.None

        ' Remove underline from link labels
        ForgotLL.LinkBehavior = LinkBehavior.NeverUnderline
        StaffLL.LinkBehavior = LinkBehavior.NeverUnderline
        MemberLL.LinkBehavior = LinkBehavior.NeverUnderline

        ' Use a Panel to simulate TextBox border color change
        Dim textBoxPanel As New Panel()
        textBoxPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        textBoxPanel.Size = New Size(IDBox.Width + 2, IDBox.Height + 2) ' Add space for border
        textBoxPanel.Location = New Point(IDBox.Location.X - 0, IDBox.Location.Y - 0)

        ' Set TextBox properties
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.BackColor = Color.DimGray ' Background color

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

        ' Set TextBox properties
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.BackColor = Color.DimGray ' Background color

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

        Dim verticalLine As New Label()
        verticalLine.Width = 2
        verticalLine.Height = 20 ' Set desired height
        verticalLine.BackColor = Color.FromArgb(245, 203, 92) ' Set the desired color
        verticalLine.Location = New Point(292, 393) ' Custom location

        mainPanel.Controls.Add(verticalLine)

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
    Private Sub CBMe_CheckedChanged(sender As Object, e As EventArgs) Handles CBMe.CheckedChanged
        If CBMe.Checked Then
            CBMe.ForeColor = Color.FromArgb(245, 203, 92)
        Else
            CBMe.ForeColor = Color.FromArgb(224, 224, 224)
        End If
    End Sub

    Private Sub StaffLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles StaffLL.LinkClicked
        ' Navigate to Staff form
        Dim staffForm As New Staff
        staffForm.Show()
        Hide()
    End Sub

    Private Sub MemberLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MemberLL.LinkClicked
        ' Navigate to Staff form
        Dim memberform As New Member()
        memberform.Show()
        Me.Hide()
    End Sub

    Private Sub ForgotLL_MouseEnter(sender As Object, e As EventArgs) Handles ForgotLL.MouseEnter
        ForgotLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub ForgotLL_MouseLeave(sender As Object, e As EventArgs) Handles ForgotLL.MouseLeave
        ForgotLL.LinkColor = originalColor
    End Sub

    Private Sub MemeberLL_MouseEnter(sender As Object, e As EventArgs) Handles MemberLL.MouseEnter
        MemberLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub StaffLL_MouseEnter(sender As Object, e As EventArgs) Handles StaffLL.MouseEnter
        StaffLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub StaffLL_MouseLeave(sender As Object, e As EventArgs) Handles StaffLL.MouseLeave
        StaffLL.LinkColor = originalColor
    End Sub

    Private Sub MemberLL_MouseLeave(sender As Object, e As EventArgs) Handles MemberLL.MouseLeave
        MemberLL.LinkColor = originalColor
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
        Dim adminID As Integer
        If Integer.TryParse(IDBox.Text, adminID) Then
            Dim password As String = PassBox.Text

            ' Check if a role is selected
            If AdminRole.SelectedItem IsNot Nothing Then
                Dim role As String = AdminRole.SelectedItem.ToString()

                ' Authenticate user
                Dim user = AuthenticateUser(adminID, password, role)
                If user IsNot Nothing Then
                    ' Show the main admin form
                    Dim adminMain As New Staffmain()
                    adminMain.ConfigureMenu(user.Role)
                    ShowUserControlInForm(adminMain, "Admin Main")
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid AdminID, password, or role.")
                End If
            Else
                MessageBox.Show("Please select a role.")
            End If
        Else
            MessageBox.Show("Please enter a valid AdminID.")
        End If
    End Sub
    Private Function AuthenticateUser(adminID As Integer, password As String, role As String) As AdminUser
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Debug.WriteLine("Connection opened successfully.")

                Dim query As String = "SELECT * FROM adminlogin WHERE AdminID = @AdminID AND Role = @Role"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@AdminID", adminID)
                cmd.Parameters.AddWithValue("@Role", role)
                Debug.WriteLine($"Executing query: {query} with AdminID: {adminID} and Role: {role}")

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Debug.WriteLine("User found in database.")

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
                        Dim updateQuery As String = $"UPDATE adminlogin SET EncryptedPassword = '{encryptedPassword}', IsEncrypted = TRUE WHERE AdminID = {adminID}"
                        readQuery(updateQuery)
                        Debug.WriteLine($"Updated database with encrypted password: {encryptedPassword}")

                        ' Set the decrypted password to the original plain password
                        decryptedPassword = storedPassword
                    End If
                    Debug.WriteLine($"Decrypted password: {decryptedPassword}")

                    ' Compare the decrypted password with the entered password
                    If decryptedPassword = password Then
                        Debug.WriteLine("Password matches.")

                        ' Create an AdminUser object to hold the user details
                        Dim user As New AdminUser()
                        user.AdminID = reader("AdminID")
                        user.Username = reader("Username")
                        user.Role = reader("Role")

                        ' Set the current logged user after successful login
                        CurrentLoggedUser.id = user.AdminID
                        CurrentLoggedUser.name = user.Username
                        CurrentLoggedUser.position = user.Role
                        ' ... set other fields as needed

                        ' Access the current logged user's details
                        MsgBox("Welcome, " & CurrentLoggedUser.position & " " & CurrentLoggedUser.name & "!")

                        Logs($"{CurrentLoggedUser.position} user {user.Username} logged in", "Login")

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


    Private Sub EncryptExistingPasswords()
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT AdminID, Password FROM adminlogin WHERE IsEncrypted = FALSE"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Using writer As New System.IO.StreamWriter("encrypted_passwords.txt", True)
                    While reader.Read()
                        Dim adminID As Integer = reader("AdminID")
                        Dim plainPassword As String = reader("Password").ToString()
                        Dim encryptedPassword As String = Encrypt(plainPassword)

                        ' Save the encrypted password to a file
                        writer.WriteLine($"{adminID},{encryptedPassword}")

                        ' Update the password to encrypted and set IsEncrypted to TRUE
                        Dim updateQuery As String = $"UPDATE adminlogin SET EncryptedPassword = '{encryptedPassword}', IsEncrypted = TRUE WHERE AdminID = {adminID}"
                        readQuery(updateQuery)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while encrypting existing passwords: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Class AdminUser
        Public Property AdminID As Integer
        Public Property Username As String
        Public Property Role As String
    End Class


    Private Sub ForgotLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotLL.LinkClicked
        Dim forgotPasswordForm As New ForgotPasswordForm()
        forgotPasswordForm.ShowDialog()
    End Sub

    Private Sub templogin_Click(sender As Object, e As EventArgs) Handles templogin.Click
        Dim adminMain As New Staffmain()
        ShowUserControlInForm(AdminMain, "Admin Main")
        Me.Hide()
    End Sub
End Class