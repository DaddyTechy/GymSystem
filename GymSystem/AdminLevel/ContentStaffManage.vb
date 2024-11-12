Public Class ContentStaffManage
    Private Sub addnewStaffBtn_Click(sender As Object, e As EventArgs) Handles addnewStaffBtn.Click
        Dim newstaffform As New ContentStaffManageForm
        newstaffform.ShowDialog()
    End Sub


End Class

