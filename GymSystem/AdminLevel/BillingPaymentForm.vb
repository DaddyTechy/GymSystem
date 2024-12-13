Public Class BillingPaymentForm
    Public Property isMembership As Boolean
    Public Property paymentID As Integer
    Public Property memberID As Integer

    ' Constructor that accepts necessary data
    Public Sub New(fee As Decimal, isMembership As Boolean, paymentID As Integer, memberID As Integer)
        InitializeComponent()
        txtAmount.Text = fee.ToString("F2")
        Debug.WriteLine("asdasd " & fee)
        txtSubTotal.Text = fee.ToString("F2")
        Me.isMembership = isMembership
        Me.paymentID = paymentID
        Me.memberID = memberID
    End Sub

    Private Sub BillingPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Auto-generate InvoiceNumber and ReceiptNumber
        txtInvoiceNumber.Text = GenerateInvoiceNumber()
        txtReceiptNumber.Text = GenerateReceiptNumber()

        ' Auto-generate PaymentDate and make it read-only
        dtpPaymentDate.Value = DateTime.Now
        dtpPaymentDate.Enabled = False

        ' Calculate Tax Amount
        CalculateTaxAmount()

        ' Add items to cmbPaymentMethod
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Credit Card")
        cmbPaymentMethod.Items.Add("E-Wallet")

    End Sub

    Private Sub CalculateTaxAmount()
        Dim subTotal As Decimal = Decimal.Parse(txtSubTotal.Text)
        Dim taxRate As Decimal = 0.12 ' Example VAT rate of 12%
        txtTaxAmount.Text = (subTotal * taxRate).ToString("F2")
        CalculateTotalAmount()
    End Sub

    Private Sub CalculateTotalAmount()
        Dim subTotal As Decimal = Decimal.Parse(txtSubTotal.Text)
        Dim discountApplied As Decimal = If(String.IsNullOrEmpty(txtDiscountAmount.Text), 0, Decimal.Parse(txtDiscountAmount.Text))
        Dim taxAmount As Decimal = Decimal.Parse(txtTaxAmount.Text)
        Dim totalAmount As Decimal = subTotal - discountApplied + taxAmount
        txtTotalAmount.Text = totalAmount.ToString("F2")
    End Sub

    Private Sub chkDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscount.CheckedChanged
        txtDiscountAmount.Enabled = chkDiscount.Checked
        If Not chkDiscount.Checked Then
            txtDiscountAmount.Text = "0.00"
            txtDiscountTotal.Text = "0.00"
        End If
        CalculateTotalAmount()
    End Sub

    Private Sub txtDiscountAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountAmount.KeyPress
        ' Allow only digits, the decimal point, and control characters
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso txtDiscountAmount.Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiscountAmount_Leave(sender As Object, e As EventArgs) Handles txtDiscountAmount.Leave
        ' Format the text to a valid number
        Dim value As Decimal
        If Decimal.TryParse(txtDiscountAmount.Text, value) Then
            txtDiscountAmount.Text = value.ToString("F2")
            txtDiscountTotal.Text = value.ToString("F2")
        ElseIf txtDiscountAmount.Text <> String.Empty Then
            txtDiscountAmount.Text = "0.00"
            txtDiscountTotal.Text = "0.00"
        End If

        ' Call the CalculateTotalAmount method
        CalculateTotalAmount()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate input
        If String.IsNullOrEmpty(cmbPaymentMethod.SelectedItem.ToString()) Then
            MessageBox.Show("Please select a payment method.")
            Return
        End If

        ' Confirm before saving
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this payment?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' Insert payment data into the payment table
        Dim paymentMethod As String = cmbPaymentMethod.SelectedItem.ToString()
        Dim paymentDate As DateTime = dtpPaymentDate.Value
        Dim subTotal As Decimal = Convert.ToDecimal(txtSubTotal.Text)
        Dim invoiceNumber As String = txtInvoiceNumber.Text
        Dim receiptNumber As String = txtReceiptNumber.Text
        Dim discountApplied As Decimal = If(String.IsNullOrEmpty(txtDiscountAmount.Text), 0, Convert.ToDecimal(txtDiscountAmount.Text))
        Dim taxAmount As Decimal = Convert.ToDecimal(txtTaxAmount.Text)
        Dim totalAmount As Decimal = Convert.ToDecimal(txtTotalAmount.Text)
        Dim paymentNotes As String = txtPaymentNotes.Text

        Dim queryPayment As String = $"UPDATE payment SET PaymentMethod = '{paymentMethod}', PaymentDate = '{paymentDate:yyyy-MM-dd}', Amount = {subTotal}, InvoiceNumber = '{invoiceNumber}', ReceiptNumber = '{receiptNumber}', DiscountApplied = {discountApplied}, TaxAmount = {taxAmount}, TotalAmount = {totalAmount}, PaymentNotes = '{paymentNotes}', PaymentStatus = 'Paid' WHERE PaymentID = {paymentID}"
        readQuery(queryPayment)

        ' Update status in the relevant table
        If isMembership Then
            Dim queryMembership As String = $"UPDATE members SET Status = '1' WHERE MemberID = {memberID}"
            readQuery(queryMembership)
        Else
            Dim queryReservation As String = $"UPDATE reservation SET PaymentStatus = 'Paid' WHERE MemberID = {memberID}"
            readQuery(queryReservation)
        End If

        ' Notify user of successful save
        MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
    End Sub


    Private Function GenerateInvoiceNumber() As String
        ' Logic to generate a new InvoiceNumber
        Return "INV" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Function GenerateReceiptNumber() As String
        ' Logic to generate a new ReceiptNumber
        Return "REC" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub btnbck_Click(sender As Object, e As EventArgs) Handles btnbck.Click
        ' Ask for confirmation before going back if there are inputs in the form
        If Not String.IsNullOrEmpty(txtSubTotal.Text) OrElse Not String.IsNullOrEmpty(txtDiscountAmount.Text) OrElse Not String.IsNullOrEmpty(txtPaymentNotes.Text) Then
            Dim result As DialogResult = MessageBox.Show("There are unsaved changes. Are you sure you want to go back?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If
        Me.Hide()
    End Sub
End Class
