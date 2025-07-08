Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PaymentFormHost
    Inherits Form

    Public Event PaymentCompleted As EventHandler

    Public Sub New(fee As Decimal, isMembership As Boolean, paymentID As Integer, memberID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Complete Your Payment"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        ' Set size to comfortably fit the user control
        Me.Size = New System.Drawing.Size(860, 640)

        Dim paymentControl As New BillingPaymentForm(fee, isMembership, paymentID, memberID)
        paymentControl.Dock = DockStyle.Fill
        Me.Controls.Add(paymentControl)

        ' Forward the event from the user control
        AddHandler paymentControl.PaymentCompleted, AddressOf HandlePaymentCompleted
    End Sub

    Public Sub New(conn As MySqlConnection, transaction As MySqlTransaction, fee As Decimal, isMembership As Boolean, paymentID As Integer, memberID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Complete Your Payment"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        ' Set size to comfortably fit the user control
        Me.Size = New System.Drawing.Size(860, 640)

        ' Pass the existing connection and transaction to the payment control
        Dim paymentControl As New BillingPaymentForm(conn, transaction, fee, isMembership, paymentID, memberID)
        paymentControl.Dock = DockStyle.Fill
        Me.Controls.Add(paymentControl)

        ' Forward the event from the user control
        AddHandler paymentControl.PaymentCompleted, AddressOf HandlePaymentCompleted
    End Sub

    Private Sub HandlePaymentCompleted(sender As Object, e As EventArgs)
        RaiseEvent PaymentCompleted(Me, e)
        Me.DialogResult = DialogResult.OK ' Set dialog result
        Me.Close()
    End Sub

#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' PaymentFormHost
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(738, 526)
        Name = "PaymentFormHost"
        Text = "PaymentFormHost"
        ResumeLayout(False)

    End Sub

    Private Sub PaymentFormHost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
