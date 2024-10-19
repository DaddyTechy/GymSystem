

Public Class Admin
    Private originalColor As Color = Color.FromArgb(245, 203, 92)
    Private originalButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverButtonColor As Color = Color.FromArgb(245, 203, 92)
    Private hoverDarkenAmount As Single = 0.7

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        IDBox.BackColor = Color.Gray ' Background color

        ' Add TextBox to Panel
        textBoxPanel.Controls.Add(IDBox)
        IDBox.Location = New Point(1, 1)

        ' Add Panel to the Form
        Me.Controls.Add(textBoxPanel)

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
        Me.Controls.Add(passBoxPanel)

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
        Me.Controls.Add(buttonPanel)

        Dim verticalLine As New Label()
        verticalLine.Width = 2
        verticalLine.Height = 20 ' Set desired height
        verticalLine.BackColor = Color.FromArgb(245, 203, 92) ' Set the desired color
        verticalLine.Location = New Point(292, 393) ' Custom location

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
        hostForm.MinimumSize = New Size(925, 580) ' You can adjust the size as needed
        hostForm.Controls.Add(control)
        control.Dock = DockStyle.Fill
        hostForm.Show()
    End Sub


    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim adminMain As New AdminMain()
        ShowUserControlInForm(adminMain, "Admin Main")
        Me.Hide()
    End Sub

End Class