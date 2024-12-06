Public Class ContentMemEntryForm
    Private Sub ContentMemEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim joinNowForm As New JoinNow()
        LoadChildForm(New JoinNow())
        joinNowForm.BLoginBtn.Visible = False
    End Sub

    Private Sub LoadChildForm(childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Top
        panelContainer.Controls.Add(childForm)
        panelContainer.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

End Class
