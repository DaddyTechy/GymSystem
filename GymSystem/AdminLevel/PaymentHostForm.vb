Imports MySql.Data.MySqlClient

Public Class PaymentHostForm
    Inherits Form

    Private _billingControl As BillingPaymentForm

    Public Sub New(billingControl As BillingPaymentForm)
        InitializeComponent()
        Me.Text = "Complete Your Payment"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        _billingControl = billingControl
        Me.Controls.Add(_billingControl)
        _billingControl.Dock = DockStyle.Fill

        ' Adjust form size to match the control's size
        Me.Size = New System.Drawing.Size(_billingControl.Width + 20, _billingControl.Height + 40)

        ' Handle the payment completed event to close the dialog
        AddHandler _billingControl.PaymentAttemptCompleted, AddressOf OnPaymentAttemptCompleted
    End Sub

    Private Sub OnPaymentAttemptCompleted(result As DialogResult)
        Me.DialogResult = result
        Me.Close()
    End Sub

    ' Designer generated code (simplified)
    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' PaymentHostForm
        ' 
        ClientSize = New Size(933, 519)
        Name = "PaymentHostForm"
        ResumeLayout(False)
    End Sub

End Class
