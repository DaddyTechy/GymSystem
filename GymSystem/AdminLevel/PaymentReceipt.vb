Imports System.Drawing.Printing

Public Class PaymentReceipt
    Private paymentMethod As String
    Private paymentDate As DateTime
    Private subTotal As Decimal
    Private invoiceNumber As String
    Private receiptNumber As String
    Private discountApplied As Decimal
    Private taxAmount As Decimal
    Private totalAmount As Decimal
    Private paymentNotes As String
    Private memberID As Integer
    Private memberName As String

    Private PrintDialog1 As New PrintDialog()
    Private PrintPreviewDialog1 As New PrintPreviewDialog()
    Private PrintDocument1 As New Printing.PrintDocument()

    Public Sub New(paymentMethod As String, paymentDate As DateTime, subTotal As Decimal, invoiceNumber As String, receiptNumber As String, discountApplied As Decimal, taxAmount As Decimal, totalAmount As Decimal, paymentNotes As String, memberID As Integer, memberName As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.paymentMethod = paymentMethod
        Me.paymentDate = paymentDate
        Me.subTotal = subTotal
        Me.invoiceNumber = invoiceNumber
        Me.receiptNumber = receiptNumber
        Me.discountApplied = discountApplied
        Me.taxAmount = taxAmount
        Me.totalAmount = totalAmount
        Me.paymentNotes = paymentNotes
        Me.memberID = memberID
        Me.memberName = memberName

        ' Add PrintPage event handler
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub

    Private Sub PaymentReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateReceiptData()
    End Sub

    Private Sub PopulateReceiptData()
        ' Populate the new controls with data
        lblDate.Text = paymentDate.ToString("yyyy-MM-dd")
        lblReceiptNumber.Text = receiptNumber

        ' Customer details
        lblCustomerName.Text = memberName
        ' You may need to fetch and add other customer details like address, phone, etc.
        ' For now, we'll leave them as placeholders.
        lblCustomerCompany.Text = ""
        lblCustomerAddress.Text = ""
        lblCustomerCity.Text = ""
        lblCustomerPhone.Text = ""
        lblCustomerID.Text = memberID.ToString()

        ' Payment details
        lblPaymentMethod.Text = paymentMethod

        ' Line items - you will need to fetch these from the database based on the payment/invoice
        ' For this example, I will add a single line item representing the total payment.
        tblLineItems.RowCount = 2 ' Header + 1 data row
        tblLineItems.Controls.Add(New Label() With {.Text = "1", .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 0, 1)
        tblLineItems.Controls.Add(New Label() With {.Text = "Membership/Reservation", .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 1, 1)
        tblLineItems.Controls.Add(New Label() With {.Text = "Payment", .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 2, 1)
        tblLineItems.Controls.Add(New Label() With {.Text = subTotal.ToString("N2"), .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 3, 1)
        tblLineItems.Controls.Add(New Label() With {.Text = discountApplied.ToString("N2"), .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 4, 1)
        tblLineItems.Controls.Add(New Label() With {.Text = totalAmount.ToString("N2"), .Anchor = AnchorStyles.None, .TextAlign = ContentAlignment.MiddleCenter}, 5, 1)

        ' Totals
        lblSubtotal.Text = subTotal.ToString("N2")
        lblSalesTax.Text = taxAmount.ToString("N2")
        lblTotal.Text = totalAmount.ToString("N2")

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Set the page settings
        Dim pageSettings As New PageSettings()
        pageSettings.Margins = New Margins(50, 50, 50, 50) ' Set margins (left, right, top, bottom)

        PrintDocument1.DefaultPageSettings = pageSettings

        ' Show the PrintPreviewDialog
        PrintPreviewDialog1.Document = PrintDocument1
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            ' Show the PrintDialog
            PrintDialog1.Document = PrintDocument1
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        End If
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Show the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*"
        saveFileDialog.Title = "Save Receipt As"
        saveFileDialog.FileName = "Receipt.png"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Save the receipt panel as an image
            Dim bmp As New Bitmap(pnlReceipt.Width, pnlReceipt.Height)
            pnlReceipt.DrawToBitmap(bmp, New Rectangle(0, 0, pnlReceipt.Width, pnlReceipt.Height))
            bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
            MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Hide()
    End Sub

    ' PrintDocument1 PrintPage event handler
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Create a bitmap of the receipt panel
        Dim bmp As New Bitmap(pnlReceipt.Width, pnlReceipt.Height)
        pnlReceipt.DrawToBitmap(bmp, New Rectangle(0, 0, pnlReceipt.Width, pnlReceipt.Height))

        ' Calculate the scaling factor to fit the panel within the printable area
        Dim scaleFactor As Single = Math.Min(e.MarginBounds.Width / bmp.Width, e.MarginBounds.Height / bmp.Height)

        ' Calculate the scaled width and height
        Dim scaledWidth As Integer = CInt(bmp.Width * scaleFactor)
        Dim scaledHeight As Integer = CInt(bmp.Height * scaleFactor)

        ' Draw the bitmap on the PrintPage event, scaled to fit within the margins
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top, scaledWidth, scaledHeight)
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        e.Cancel = True
        Me.Hide()
    End Sub

End Class
