Public Class Member
    Private originalColor As Color = Color.FromArgb(245, 203, 92)
    Private originalButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverDarkenAmount As Single = 0.7
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Remove underline from link labels
        ForgotLL.LinkBehavior = LinkBehavior.NeverUnderline
        StaffLL.LinkBehavior = LinkBehavior.NeverUnderline
        AdminLL.LinkBehavior = LinkBehavior.NeverUnderline

        ' Use a Panel to simulate TextBox border color change
        Dim IDPanel As New Panel()
        IDPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        IDPanel.Size = New Size(IDBox.Width + 2, IDBox.Height + 2) ' Add space for border
        IDPanel.Location = New Point(IDBox.Location.X - 0, IDBox.Location.Y - 0)

        ' Add TextBox to Panel
        IDPanel.Controls.Add(IDBox)
        IDBox.Location = New Point(1, 1)

        ' Add Panel to the Form
        Me.Controls.Add(IDPanel)

        ' Repeat for PassBox
        Dim PasswordPanel As New Panel()
        PasswordPanel.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        PasswordPanel.Size = New Size(PassBox.Width + 2, PassBox.Height + 2) ' Add space for border
        PasswordPanel.Location = New Point(PassBox.Location.X - 0, PassBox.Location.Y - 0)

        ' Add TextBox to Panel
        PasswordPanel.Controls.Add(PassBox)
        PassBox.Location = New Point(1, 1)

        ' Add Panel to the Form
        Me.Controls.Add(PasswordPanel)

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

        ' Use a Panel to simulate Button border color change
        Dim Register As New Panel()
        Register.BackColor = Color.FromArgb(245, 203, 92) ' Border color
        Register.Size = New Size(RegisterBtn.Width + 4, RegisterBtn.Height + 4) ' Add space for border
        Register.Location = New Point(RegisterBtn.Location.X - 2, RegisterBtn.Location.Y - 2)

        ' Set Button properties
        RegisterBtn.FlatStyle = FlatStyle.Flat
        RegisterBtn.FlatAppearance.BorderSize = 0
        RegisterBtn.BackColor = Color.FromArgb(245, 203, 92)

        Register.Controls.Add(RegisterBtn)

        RegisterBtn.Location = New Point(2, 2)


        ' Add Panel to the Form'
        Me.Controls.Add(Register)
        Me.Controls.Add(buttonPanel)

        IDBox.Focus()
        PassBox.Focus()

        Dim verticalLine As New Label()
        verticalLine.Width = 2
        verticalLine.Height = 20 ' Set desired height
        verticalLine.BackColor = Color.FromArgb(245, 203, 92) ' Set the desired color
        verticalLine.Location = New Point(277, 378) ' Custom location

        Me.Controls.Add(verticalLine)

        ' Initialize button colors
        originalButtonColor = LoginBtn.BackColor
        hoverButtonColor = ControlPaint.Dark(originalButtonColor, hoverDarkenAmount)

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
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim MeMain As New MemberMain
        MeMain.Show()
        Hide()
    End Sub

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
        registerform.Show()
        Hide()
    End Sub

    Private caretHandler As New CaretHandler()

    Private Sub ID_GotFocus(sender As Object, e As EventArgs) Handles IDBox.GotFocus
        CaretHandler.InitializeCaret(IDBox, Color.FromArgb(245, 203, 92))
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
