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
        ' Set up the form and panel
        Me.Text = "Payment Receipt"
        Me.Size = New Size(420, 700) ' Increased height to accommodate buttons

        Dim receiptPanel As New Panel()
        receiptPanel.Dock = DockStyle.Top
        receiptPanel.BackColor = Color.White
        receiptPanel.Height = 550 ' Set height to leave space for buttons
        Me.Controls.Add(receiptPanel)

        ' Add receipt details to the panel
        Dim receiptDetails As String = GenerateReceiptDetails()
        Dim receiptLabel As New Label()
        receiptLabel.Text = receiptDetails
        receiptLabel.Font = New Font("Consolas", 10) ' Use a fixed-width font for alignment
        receiptLabel.AutoSize = True
        receiptLabel.Location = New Point(10, 10) ' Position at the top
        receiptPanel.Controls.Add(receiptLabel)

        ' Add Print and Save buttons
        Dim printButton As New Button()
        printButton.Text = "Print"
        printButton.Location = New Point(50, receiptPanel.Bottom + 10)
        AddHandler printButton.Click, AddressOf PrintReceipt
        Me.Controls.Add(printButton)

        Dim saveButton As New Button()
        saveButton.Text = "Save"
        saveButton.Location = New Point(200, receiptPanel.Bottom + 10)
        AddHandler saveButton.Click, AddressOf SaveReceipt
        Me.Controls.Add(saveButton)
    End Sub


    Private Function GenerateReceiptDetails() As String
        ' Generate the receipt details based on the payment information
        Dim companyName As String = "JJ Fitness Gym"
        Dim receiptTitle As String = "Payment Receipt "
        Dim dateStr As String = "Date: " & paymentDate.ToString("yyyy-MM-dd")
        Dim timeStr As String = "Time: " & paymentDate.ToString("HH:mm:ss")
        Dim invoiceStr As String = "Invoice Number: " & invoiceNumber
        Dim receiptStr As String = "Receipt Number: " & receiptNumber
        Dim memberIDStr As String = "Member ID: " & memberID
        Dim memberNameStr As String = "Member Name: " & memberName
        Dim paymentMethodStr As String = "Payment Method: " & paymentMethod
        Dim subTotalStr As String = "Subtotal: " & subTotal.ToString("C")
        Dim discountStr As String = "Discount: " & discountApplied.ToString("C")
        Dim taxStr As String = "Tax: " & taxAmount.ToString("C")
        Dim totalAmountStr As String = "Total Amount: " & totalAmount.ToString("C")
        Dim paymentNotesStr As String = "Payment Notes: " & paymentNotes
        Dim thankYouStr As String = "Thank You for Your Payment! "

        ' Define the width of the receipt
        Dim receiptWidth As Integer = 50

        ' Function to center-align text
        Dim CenterAlign As Func(Of String, String) = Function(text As String) As String
                                                         Dim padding As Integer = (receiptWidth - text.Length) \ 2
                                                         Return New String(" "c, padding) & text & New String(" "c, padding)
                                                     End Function

        ' Function to left-align text with padding
        Dim LeftAlign As Func(Of String, String) = Function(text As String) As String
                                                       Return text & New String(" "c, receiptWidth - text.Length)
                                                   End Function

        ' Generate the receipt details
        Dim receiptDetails As String = CenterAlign(companyName) & Environment.NewLine &
                                   Environment.NewLine &
                                   CenterAlign(receiptTitle) & Environment.NewLine &
                                   Environment.NewLine &
                                   LeftAlign(dateStr) & Environment.NewLine &
                                   LeftAlign(timeStr) & Environment.NewLine &
                                   LeftAlign(invoiceStr) & Environment.NewLine &
                                   LeftAlign(receiptStr) & Environment.NewLine &
                                   Environment.NewLine &
                                   LeftAlign(memberIDStr) & Environment.NewLine &
                                   LeftAlign(memberNameStr) &
                                   Environment.NewLine &
                                   LeftAlign(paymentMethodStr) & Environment.NewLine &
                                   LeftAlign(subTotalStr) & Environment.NewLine &
                                   LeftAlign(discountStr) & Environment.NewLine &
                                   LeftAlign(taxStr) & Environment.NewLine &
                                   LeftAlign(totalAmountStr) & Environment.NewLine &
                                   Environment.NewLine &
                                   LeftAlign(paymentNotesStr) & Environment.NewLine &
                                   Environment.NewLine &
                                   CenterAlign(thankYouStr)

        Return receiptDetails
    End Function

    Private Sub PrintReceipt(sender As Object, e As EventArgs)
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

    Private Sub SaveReceipt(sender As Object, e As EventArgs)
        ' Show the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveFileDialog.Title = "Save Receipt As"
        saveFileDialog.FileName = "Receipt.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Save the receipt details to the selected file
            Dim receiptDetails As String = GenerateReceiptDetails()
            System.IO.File.WriteAllText(saveFileDialog.FileName, receiptDetails)
            MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Hide()
    End Sub

    ' PrintDocument1 PrintPage event handler
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Create a bitmap of the receipt panel
        Dim receiptPanel As Panel = CType(Me.Controls(0), Panel) ' Assuming the receipt panel is the first control
        Dim bmp As New Bitmap(receiptPanel.Width, receiptPanel.Height)
        receiptPanel.DrawToBitmap(bmp, New Rectangle(0, 0, receiptPanel.Width, receiptPanel.Height))

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
