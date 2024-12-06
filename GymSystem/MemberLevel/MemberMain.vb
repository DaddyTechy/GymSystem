Public Class MemberMain
    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim sched As New Sched With {.Top = False, .AutoSize = True}
        sched.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(sched)
        sched.Show()

    End Sub

    Private Sub Announce_Click(sender As Object, e As EventArgs) Handles announcebtn.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim Announce As New Announcements With {.Top = False, .AutoSize = True}
        Announce.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(Announce)
        Announce.Show()
    End Sub

    Private Sub Reminder_Click(sender As Object, e As EventArgs) Handles Reminder.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim Remind As New Reminder With {.Top = False, .AutoSize = True}
        Remind.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(Remind)
        Remind.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim reports As New Report With {.Top = False, .AutoSize = True}
        reports.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(reports)
        reports.Show()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim reports As New Payment With {.Top = False, .AutoSize = True}
        reports.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(reports)
        reports.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim memberForm As New Member() ' Create an instance of MemberForm
        memberForm.Show()
        Me.Hide()
    End Sub
End Class