Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DashBtn_Click(sender As Object, e As EventArgs) Handles DashBtn.Click
        Dim DashB As New DashBoard
        DashB.Show()
        Hide()
    End Sub

    Private Sub ReminderBtn_Click(sender As Object, e As EventArgs) Handles RemindBtn.Click
        Dim remind As New Reminders
        remind.Show()
        Hide()
    End Sub

    Private Sub AnnounceBtn_Click(sender As Object, e As EventArgs) Handles AnnounceBtn.Click
        Dim Announce As New Announcement
        Announce.Show()
        Hide()
    End Sub

    Private Sub RemindBtn_Click(sender As Object, e As EventArgs) Handles RemindBtn.Click
        Dim Remi As New Reminders
        Remi.Show()
        Hide()
    End Sub
End Class