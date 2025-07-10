' In PaymentForm.vb
Public Class PaymentForm
    Public Sub New(newEvent As CalendarEvent)
        InitializeComponent()

        ' Create an instance of the BillingPaymentForm UserControl
        Dim paymentControl As New BillingPaymentForm(newEvent.ReservationFee, False, newEvent.MemberID, newEvent.MemberID)

        ' Set the size of the BillingPaymentForm
        paymentControl.Size = New Size(400, 300) ' Adjust the size as needed

        ' Use AutoSize and AutoSizeMode properties
        paymentControl.AutoSize = True
        paymentControl.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' Use Dock property to fill the form
        paymentControl.Dock = DockStyle.Fill

        ' Add the BillingPaymentForm to the form
        Controls.Add(paymentControl)
        paymentControl.BringToFront()

        ' Add event handler for the save button
        AddHandler paymentControl.btnSave.Click, Sub(sender As Object, e As EventArgs)
                                                     ' Insert payment data into the payment table
                                                     Dim paymentMethod As String = paymentControl.cmbPaymentMethod.SelectedItem.ToString()
                                                     Dim paymentDate As DateTime = paymentControl.dtpPaymentDate.Value
                                                     Dim subTotal As Decimal = Convert.ToDecimal(paymentControl.txtSubTotal.Text)
                                                     Dim invoiceNumber As String = paymentControl.txtInvoiceNumber.Text
                                                     Dim receiptNumber As String = paymentControl.txtReceiptNumber.Text
                                                     Dim discountApplied As Decimal = If(String.IsNullOrEmpty(paymentControl.txtDiscountAmount.Text), 0, Convert.ToDecimal(paymentControl.txtDiscountAmount.Text))
                                                     Dim taxAmount As Decimal = Convert.ToDecimal(paymentControl.txtTaxAmount.Text)
                                                     Dim totalAmount As Decimal = Convert.ToDecimal(paymentControl.txtTotalAmount.Text)
                                                     Dim paymentNotes As String = paymentControl.txtPaymentNotes.Text

                                                     Dim queryPayment As String = $"INSERT INTO payment (MemberID, ReservationFee, PaymentMethod, PaymentDate, Amount, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, PaymentStatus, MembershipID) " &
                                                                                  $"VALUES ({newEvent.MemberID}, {newEvent.ReservationFee}, '{paymentMethod}', '{paymentDate:yyyy-MM-dd}', {subTotal}, '{invoiceNumber}', '{receiptNumber}', {discountApplied}, {taxAmount}, {totalAmount}, '{paymentNotes}', 'Paid', '{newEvent.MemberID}')"
                                                     ExecuteQuery(queryPayment)

                                                     ' Update status in the relevant table
                                                     Dim queryReservation As String = $"UPDATE reservation SET PaymentStatus = 'Paid' WHERE MemberID = {newEvent.MemberID}"
                                                     ExecuteQuery(queryReservation)

                                                     ' Notify user of successful save
                                                     MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                     Me.Close()
                                                 End Sub
    End Sub

    Private Sub ExecuteQuery(query As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = query
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
