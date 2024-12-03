Public Class Reminders
    Private Sub Reminders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DashBtn_Click(sender As Object, e As EventArgs) Handles DashBtn.Click
        Dim DashB As New DashBoard
        DashB.Show()
        Hide()
    End Sub

    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        Dim sched As New CalendarForm
        sched.Show()
        Hide()
    End Sub

    Private Sub AnnounceBtn_Click(sender As Object, e As EventArgs) Handles AnnounceBtn.Click
        Dim Announce As New Announcement
        Announce.Show()
        Hide()
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Dim reps As New Reports
        reps.Show()
        Hide()
    End Sub

End Class