Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        Dim schedule As New calendarForm
        schedule.Show()
        Hide()
    End Sub

    Private Sub RemindBtn_Click(sender As Object, e As EventArgs) Handles RemindBtn.Click
        Dim remind As New Reminders
        remind.Show()
        Hide()
    End Sub

    Private Sub AnnounceBtn_Click(sender As Object, e As EventArgs) Handles AnnounceBtn.Click
        Dim Announce As New Announcement
        Announce.Show()
        Hide()
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        Dim reps As New Reports
        reps.Show()
        Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim LogoutB As New Member
        LogoutB.Show()
        Hide()
    End Sub

    Private Sub Bill_Click(sender As Object, e As EventArgs) Handles Bills.Click
        Dim Billpay As New Billings
        Billpay.Show()
        Hide()
    End Sub

End Class