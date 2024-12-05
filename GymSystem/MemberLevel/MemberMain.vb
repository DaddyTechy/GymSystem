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

End Class