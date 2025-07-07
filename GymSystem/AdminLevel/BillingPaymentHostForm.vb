Imports MySql.Data.MySqlClient

Public Class BillingPaymentHostForm
    Private ReadOnly _paymentControl As BillingPaymentForm

    ' Constructor for transactional reservation
    Public Sub New(conn As MySqlConnection, transaction As MySqlTransaction, details As ReservationDetails)
        InitializeComponent()
        Text = "Reservation Payment"
        StartPosition = FormStartPosition.CenterParent
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False

        ' Initialize the user control
        _paymentControl = New BillingPaymentForm(conn, transaction, details)
        _paymentControl.Dock = DockStyle.Fill
        Me.Controls.Add(_paymentControl)

        ' Adjust form size to fit the control
        Me.ClientSize = _paymentControl.Size

        ' Handle the PaymentCompleted event from the user control
        AddHandler _paymentControl.PaymentCompleted, AddressOf PaymentControl_PaymentCompleted
    End Sub

    Private Sub PaymentControl_PaymentCompleted(sender As Object, e As EventArgs)
        ' When the payment is completed, set the dialog result and close the form
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
