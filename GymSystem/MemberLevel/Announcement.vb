﻿Public Class Announcement
    Private Sub Announcement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub DashBtn_Click(sender As Object, e As EventArgs) Handles DashBtn.Click
        Dim DashB As New DashBoard
        DashB.Show()
        Hide()
    End Sub

    Private Sub RemindBtn_Click(sender As Object, e As EventArgs) Handles RemindBtn.Click
        Dim remind As New Reminders
        remind.Show()
        Hide()
    End Sub

    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        Dim sched As New Sched
        sched.Show()
        Hide()
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Dim reps As New Reports
        reps.Show()
        Hide()
    End Sub

End Class