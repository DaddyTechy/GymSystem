' In AccountDetailsForm.vb
Public Class AccountDetailsForm
    Public Sub New(accountDetails As String)
        InitializeComponent()
        ' Set the account details text
        RichTextBox1.Text = accountDetails
        ' Make the RichTextBox read-only
        RichTextBox1.ReadOnly = True
    End Sub
End Class
