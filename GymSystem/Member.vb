Imports MySql.Data.MySqlClient

Public Class Member
    Private originalColor As Color = Color.FromArgb(245, 203, 92)
    Private originalButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverDarkenAmount As Single = 0.7
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mainPanel As New Panel()
        mainPanel.Size = New Size(925, 580)
        mainPanel.Location = New Point(0, 0)
        mainPanel.Anchor = AnchorStyles.None
        mainPanel.Dock = DockStyle.None

        ' Remove underline from link labels
        ForgotLL.LinkBehavior = LinkBehavior.NeverUnderline
        StaffLL.LinkBehavior = LinkBehavior.NeverUnderline
        AdminLL.LinkBehavior = LinkBehavior.NeverUnderline

        ' Use a Panel to simulate TextBox border color change
        Dim textBoxPanel As New Panel()
        textBoxPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        textBoxPanel.Size = New Size(IDBox.Width + 2, IDBox.Height + 2) ' Add space for border
        textBoxPanel.Location = New Point(IDBox.Location.X - 0, IDBox.Location.Y - 0)

        ' Set TextBox properties
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.BackColor = Color.Gray  'Background color

        ' Add TextBox to Panel
        textBoxPanel.Controls.Add(IDBox)
        IDBox.Location = New Point(1, 1)

        ' Add Panel to the Form
        mainPanel.Controls.Add(textBoxPanel)

        ' Repeat for PassBox
        Dim passBoxPanel As New Panel()
        passBoxPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        passBoxPanel.Size = New Size(PassBox.Width + 2, PassBox.Height + 2) ' Add space for border
        passBoxPanel.Location = New Point(PassBox.Location.X - 0, PassBox.Location.Y - 0)

        ' Set TextBox properties
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.BackColor = Color.Gray ' Background color

        ' Add TextBox to Panel
        passBoxPanel.Controls.Add(PassBox)
        PassBox.Location = New Point(1, 1)

        ' Add Panel to the Form
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


        ' Add Panel to the Form
        mainPanel.Controls.Add(buttonPanel)

        IDBox.Focus()
        PassBox.Focus()

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

    Private Sub RegisterBtn_MouseEnter(sender As Object, e As EventArgs) Handles RegisterBtn.MouseEnter
        RegisterBtn.BackColor = hoverButtonColor
        RegisterBtn.ForeColor = Color.White
    End Sub

    Private Sub RegisterBtn_MouseLeave(sender As Object, e As EventArgs) Handles RegisterBtn.MouseLeave
        RegisterBtn.BackColor = originalButtonColor
        RegisterBtn.ForeColor = Color.Black
    End Sub

    Private Sub CBMe_CheckedChanged(sender As Object, e As EventArgs) Handles CBMe.CheckedChanged
        If CBMe.Checked Then
            CBMe.ForeColor = Color.FromArgb(245, 203, 92)
        Else
            CBMe.ForeColor = Color.FromArgb(224, 224, 224)
        End If
    End Sub

    Private Sub ForgotLL_MouseEnter(sender As Object, e As EventArgs) Handles ForgotLL.MouseEnter
        ForgotLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub ForgotLL_MouseLeave(sender As Object, e As EventArgs) Handles ForgotLL.MouseLeave
        ForgotLL.LinkColor = originalColor
    End Sub

    Private Sub StaffLL_MouseEnter(sender As Object, e As EventArgs) Handles StaffLL.MouseEnter
        StaffLL.LinkColor = ControlPaint.Dark(originalColor, 0.3F)
    End Sub

    Private Sub StaffLL_MouseLeave(sender As Object, e As EventArgs) Handles StaffLL.MouseLeave
        StaffLL.LinkColor = originalColor
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

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim memberID As Integer
        If Integer.TryParse(IDBox.Text, memberID) Then
            Dim password As String = PassBox.Text

            ' Authenticate user
            Dim user = AuthenticateMember(memberID, password)
            If user IsNot Nothing Then
                ' Check membership status
                If user.Status = "Inactive" Then
                    Dim result As DialogResult = MessageBox.Show("Your membership is inactive. You need an active membership to access your account. Would you like to renew it?", "Membership Renewal", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        RenewMembership(memberID)
                    Else
                        ' Redirect to create a new membership
                        CreateNewMembership(memberID)
                    End If
                Else
                    ' Show the main member form
                    Dim memberMain As New MemberMain()
                    memberMain.Show()
                    Me.Hide()
                    Logs($"Member with ID: {CurrentLoggedUser.id} logged in", "memberlogin")
                    Debug.WriteLine("id: " & CurrentLoggedUser.id)
                End If
            Else
                MessageBox.Show("Invalid MemberID or password.")
            End If
        Else
            MessageBox.Show("Please enter a valid MemberID.")
        End If
    End Sub

    Private Sub CreateNewMembership(memberID As Integer)
        ' Load the new membership form
        Dim newMembershipForm As New NewMembershipForm(memberID)
        newMembershipForm.ShowDialog()

        ' No need to ask for payment confirmation here, as it's already handled in the NewMembershipForm
    End Sub

    Private Sub RenewMembership(memberID As Integer)
        Dim fee As Decimal = GetCurrentMembershipFee(memberID)
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE membership SET EndDate = DATE_ADD(CURDATE(), INTERVAL Duration MONTH), Status = 'Active' WHERE MemberID = @MemberID AND Status = 'Inactive'", conn)
            cmd.Parameters.AddWithValue("@MemberID", memberID)
            cmd.ExecuteNonQuery()
        End Using

        ' Trigger the payment process
        AskPaymentOption(memberID, fee, True)
    End Sub

    Private paymentCompleted As Boolean = False

    Private Sub AskPaymentOption(memberID As Integer, fee As Decimal, isMembership As Boolean)
        Dim result As DialogResult = MessageBox.Show("Would you like to pay for the membership now?", "Payment Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Handle immediate payment
            HandleImmediatePayment(memberID, fee, isMembership)

            Dim accountDetails As String = $"Details added successfully.{Environment.NewLine}Username: {memberID}{Environment.NewLine}Use this as Your UserName/UserID for login."
            Dim accountDetailsForm As New AccountDetailsForm(accountDetails)
            accountDetailsForm.ShowDialog()
        Else
            ' Handle later payment
            HandleLaterPayment(memberID)
            CloseForm() ' Separate method to close and return to admin login
        End If

        ' Check the payment status and close the form if the payment is completed
        If paymentCompleted Then
            CloseForm() ' Separate method to close and return to admin login
        End If
    End Sub

    Private Sub CloseForm()
        Dim backtoAdminLogin As New Member
        backtoAdminLogin.Show()
    End Sub

    Private Function CheckPaymentStatus(memberID As Integer) As Boolean
        Dim paymentExists As Boolean = False

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim query As String = $"SELECT COUNT(*) FROM payment WHERE MemberID = {memberID} AND PaymentStatus = 'Paid'"
            Using cmd As New MySqlCommand(query, conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    paymentExists = True
                End If
            End Using
        End Using

        MessageBox.Show($"Payment Made:{paymentExists}")
        Return paymentExists
    End Function

    Private Sub HandleImmediatePayment(memberID As Integer, fee As Decimal, isMembership As Boolean)
        ' Create a new payment record if it's a new payment
        Dim newPaymentID As Integer = CreateNewPayment(memberID)

        ' Create a new instance of the BillingPaymentForm with the necessary data
        Dim paymentForm As New BillingPaymentForm(fee, isMembership, newPaymentID, memberID)

        ' Subscribe to the PaymentCompleted event
        AddHandler paymentForm.PaymentCompleted, AddressOf OnPaymentCompleted

        ' Calculate the center point
        Dim centerX As Integer = (ClientSize.Width - paymentForm.Width) / 2
        Dim centerY As Integer = (ClientSize.Height - paymentForm.Height) / 2

        ' Set the location of the BillingPaymentForm to the center
        paymentForm.Location = New Point(centerX, centerY)

        ' Add the BillingPaymentForm to the form
        Controls.Add(paymentForm)
        paymentForm.BringToFront()

        Debug.WriteLine("Debug: BillingPaymentForm user control added.")
        Debug.WriteLine($"Debug: Form Amount = {paymentForm.txtAmount.Text}, SubTotal = {paymentForm.txtSubTotal.Text}")
    End Sub

    Private Sub OnPaymentCompleted(sender As Object, e As EventArgs)
        ' Set the paymentCompleted flag to True
        paymentCompleted = True
    End Sub

    Private Function CreateNewPayment(memberID As Integer) As Integer
        Dim newPaymentID As Integer = 0
        Dim fee As Decimal = 0

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            ' Fetch the Cost from the membership table
            Dim query As String = $"SELECT Cost FROM membership WHERE MemberID = {memberID}"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    fee = Convert.ToDecimal(reader("Cost"))
                    Debug.WriteLine("Cost: " & fee)
                End If
                reader.Close()
            End Using

            ' Insert a new payment record
            Dim insertQuery As String = $"INSERT INTO payment (MemberID, Amount, PaymentStatus, PaymentMethod, PaymentDate, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, MembershipID) " &
                                    $"VALUES ({memberID}, {fee}, 'Unpaid', 'N/A', '{DateTime.MinValue:yyyy-MM-dd}', 'N/A', 'N/A', 0, 0, 0, 'N/A', {memberID}); SELECT LAST_INSERT_ID();"
            Using cmd As New MySqlCommand(insertQuery, conn)
                newPaymentID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        Return newPaymentID
    End Function

    Private Sub HandleLaterPayment(memberID As Integer)
        ' Custom logic for handling later payment
        MessageBox.Show("You can pay later. Remember to complete your payment before the due date.", "Payment Deferred", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Add any additional logic for deferred payment here
    End Sub


    Private Function GetCurrentMembershipFee(memberID As Integer) As Decimal
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT Cost FROM membership WHERE MemberID = @MemberID", conn)
            cmd.Parameters.AddWithValue("@MemberID", memberID)
            Return Convert.ToDecimal(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function GetNewPaymentID() As Integer
        ' Implement the logic to get the new payment ID
        ' Example:
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT MAX(PaymentID) + 1 FROM payment", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function AuthenticateMember(memberID As Integer, password As String) As MemberUser
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Debug.WriteLine("Connection opened successfully.")

                Dim query As String = "SELECT m.MemberID, m.Username, m.Password, m.IsEncrypted, ms.Status " &
                                  "FROM memberlogin m " &
                                  "JOIN membership ms ON m.MemberID = ms.MemberID " &
                                  "WHERE m.MemberID = @MemberID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MemberID", memberID)
                Debug.WriteLine($"Executing query: {query} with MemberID: {memberID}")

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
                        Dim updateQuery As String = $"UPDATE memberlogin SET EncryptedPassword = '{encryptedPassword}', IsEncrypted = TRUE WHERE MemberID = {memberID}"
                        readQuery(updateQuery)
                        Debug.WriteLine($"Updated database with encrypted password: {encryptedPassword}")

                        ' Set the decrypted password to the original plain password
                        decryptedPassword = storedPassword
                    End If
                    Debug.WriteLine($"Decrypted password: {decryptedPassword}")

                    ' Compare the decrypted password with the entered password
                    If decryptedPassword = password Then
                        Debug.WriteLine("Password matches.")

                        ' Create a MemberUser object to hold the user details
                        Dim user As New MemberUser()
                        user.MemberID = reader("MemberID")
                        user.Username = reader("Username")
                        user.Status = reader("Status").ToString()
                        user.Role = "Member"

                        ' Set the current logged user after successful login
                        CurrentLoggedUser.id = user.MemberID
                        CurrentLoggedUser.name = user.Username
                        ' ... set other fields as needed

                        ' Access the current logged user's details
                        MsgBox("Welcome, Member: " & memberID & " " & CurrentLoggedUser.name.ToUpper & "!")

                        Logs($"Member user {user.Username} logged in", "Login")

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



    Public Class MemberUser
        Public Property MemberID As Integer
        Public Property Username As String
        Public Property Role As String
        Public Property Status As String
    End Class


    Private Sub StaffLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles StaffLL.LinkClicked
        ' Navigate to Staff form
        Dim staffForm As New Staff
        staffForm.Show()
        Hide()
    End Sub

    Private Sub AdminLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminLL.LinkClicked
        Dim adminform As New Admin
        adminform.Show()
        Hide()
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim registerform As New JoinNow
        registerform.WindowState = FormWindowState.Maximized
        registerform.Show()
        Hide()
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
