Public Class ContentMemEntryForm
    Private Sub ContentMemEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim joinNowForm As New JoinNow()
        LoadChildForm(joinNowForm)
        joinNowForm.BLoginBtn.Visible = False
    End Sub

    Private Sub LoadChildForm(childForm As Form)
        ' Remove any existing form
        If panelContainer.Controls.Count > 0 Then
            panelContainer.Controls(0).Dispose()
        End If

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Top
        panelContainer.Controls.Add(childForm)
        panelContainer.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub panelContainer_Paint(sender As Object, e As PaintEventArgs) Handles panelContainer.Paint

    End Sub
End Class
