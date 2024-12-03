Imports Bunifu.UI.WinForms.Extensions

Public Class Billings
    Private Sub Billings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        Dim schedule As New CalendarForm
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

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Dim reps As New Reports
        reps.Show()
        Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim LogoutB As New Member
        LogoutB.Show()
        Hide()
    End Sub

    Private Sub Dash_clic(sender As Object, e As EventArgs) Handles DashBtn.Click
        Dim Dashhh As New DashBoard
        Dashhh.Show()
        Hide()
    End Sub
End Class