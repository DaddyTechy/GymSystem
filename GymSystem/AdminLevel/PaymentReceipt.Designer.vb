<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlReceipt = New Panel()
        lblFooter = New Label()
        lblThankYou = New Label()
        lblTotal = New Label()
        Label14 = New Label()
        lblSalesTax = New Label()
        Label12 = New Label()
        lblSubtotal = New Label()
        Label10 = New Label()
        tblLineItems = New TableLayoutPanel()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Panel2 = New Panel()
        lblPaymentMethod = New Label()
        Label16 = New Label()
        lblCustomerID = New Label()
        lblCustomerPhone = New Label()
        lblCustomerCity = New Label()
        lblCustomerAddress = New Label()
        lblCustomerCompany = New Label()
        lblCustomerName = New Label()
        Label9 = New Label()
        lblReceiptNumber = New Label()
        Label7 = New Label()
        lblDate = New Label()
        Label5 = New Label()
        lblTitle = New Label()
        lblSlogan = New Label()
        lblLogoName = New Label()
        PictureBox1 = New PictureBox()
        btnSave = New Button()
        btnPrint = New Button()
        pnlReceipt.SuspendLayout()
        tblLineItems.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlReceipt
        ' 
        pnlReceipt.BackColor = Color.White
        pnlReceipt.Controls.Add(lblFooter)
        pnlReceipt.Controls.Add(lblThankYou)
        pnlReceipt.Controls.Add(lblTotal)
        pnlReceipt.Controls.Add(Label14)
        pnlReceipt.Controls.Add(lblSalesTax)
        pnlReceipt.Controls.Add(Label12)
        pnlReceipt.Controls.Add(lblSubtotal)
        pnlReceipt.Controls.Add(Label10)
        pnlReceipt.Controls.Add(tblLineItems)
        pnlReceipt.Controls.Add(Panel2)
        pnlReceipt.Controls.Add(lblCustomerID)
        pnlReceipt.Controls.Add(lblCustomerPhone)
        pnlReceipt.Controls.Add(lblCustomerCity)
        pnlReceipt.Controls.Add(lblCustomerAddress)
        pnlReceipt.Controls.Add(lblCustomerCompany)
        pnlReceipt.Controls.Add(lblCustomerName)
        pnlReceipt.Controls.Add(Label9)
        pnlReceipt.Controls.Add(lblReceiptNumber)
        pnlReceipt.Controls.Add(Label7)
        pnlReceipt.Controls.Add(lblDate)
        pnlReceipt.Controls.Add(Label5)
        pnlReceipt.Controls.Add(lblTitle)
        pnlReceipt.Controls.Add(lblSlogan)
        pnlReceipt.Controls.Add(lblLogoName)
        pnlReceipt.Controls.Add(PictureBox1)
        pnlReceipt.Location = New Point(12, 12)
        pnlReceipt.Name = "pnlReceipt"
        pnlReceipt.Size = New Size(800, 1000)
        pnlReceipt.TabIndex = 0
        ' 
        ' lblFooter
        ' 
        lblFooter.AutoSize = True
        lblFooter.Location = New Point(180, 950)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(410, 15)
        lblFooter.TabIndex = 25
        lblFooter.Text = "JJ Gym Camarines Norte, Daet   4600  +63923456789  Fax   JJgym@gmail.com" & vbCrLf
        ' 
        ' lblThankYou
        ' 
        lblThankYou.AutoSize = True
        lblThankYou.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblThankYou.Location = New Point(321, 923)
        lblThankYou.Name = "lblThankYou"
        lblThankYou.Size = New Size(176, 17)
        lblThankYou.TabIndex = 24
        lblThankYou.Text = "Thank you for your business!"
        ' 
        ' lblTotal
        ' 
        lblTotal.Location = New Point(688, 880)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(100, 23)
        lblTotal.TabIndex = 23
        lblTotal.Text = "0.00"
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(604, 883)
        Label14.Name = "Label14"
        Label14.Size = New Size(39, 17)
        Label14.TabIndex = 22
        Label14.Text = "Total"
        ' 
        ' lblSalesTax
        ' 
        lblSalesTax.Location = New Point(688, 854)
        lblSalesTax.Name = "lblSalesTax"
        lblSalesTax.Size = New Size(100, 23)
        lblSalesTax.TabIndex = 21
        lblSalesTax.Text = "0.00"
        lblSalesTax.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(604, 857)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 15)
        Label12.TabIndex = 20
        Label12.Text = "Sales Tax"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.Location = New Point(688, 828)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(100, 23)
        lblSubtotal.TabIndex = 19
        lblSubtotal.Text = "0.00"
        lblSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(604, 831)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 15)
        Label10.TabIndex = 18
        Label10.Text = "Subtotal"
        ' 
        ' tblLineItems
        ' 
        tblLineItems.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tblLineItems.ColumnCount = 6
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.6683941F))
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.81347F))
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13F))
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12F))
        tblLineItems.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        tblLineItems.Controls.Add(Label22, 5, 0)
        tblLineItems.Controls.Add(Label21, 4, 0)
        tblLineItems.Controls.Add(Label20, 3, 0)
        tblLineItems.Controls.Add(Label19, 2, 0)
        tblLineItems.Controls.Add(Label18, 1, 0)
        tblLineItems.Controls.Add(Label17, 0, 0)
        tblLineItems.Location = New Point(15, 300)
        tblLineItems.Name = "tblLineItems"
        tblLineItems.RowCount = 1
        tblLineItems.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tblLineItems.Size = New Size(773, 500)
        tblLineItems.TabIndex = 17
        ' 
        ' Label22
        ' 
        Label22.BackColor = Color.Gold
        Label22.Dock = DockStyle.Fill
        Label22.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label22.ForeColor = Color.Black
        Label22.Location = New Point(657, 1)
        Label22.Name = "Label22"
        Label22.Size = New Size(112, 498)
        Label22.TabIndex = 5
        Label22.Text = "Line Total"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label21
        ' 
        Label21.BackColor = Color.Gold
        Label21.Dock = DockStyle.Fill
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(564, 1)
        Label21.Name = "Label21"
        Label21.Size = New Size(86, 498)
        Label21.TabIndex = 4
        Label21.Text = "Discount"
        Label21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.BackColor = Color.Gold
        Label20.Dock = DockStyle.Fill
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(463, 1)
        Label20.Name = "Label20"
        Label20.Size = New Size(94, 498)
        Label20.TabIndex = 3
        Label20.Text = "Unit Price"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.BackColor = Color.Gold
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(256, 1)
        Label19.Name = "Label19"
        Label19.Size = New Size(200, 498)
        Label19.TabIndex = 2
        Label19.Text = "Description"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.BackColor = Color.Gold
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(81, 1)
        Label18.Name = "Label18"
        Label18.Size = New Size(168, 498)
        Label18.TabIndex = 1
        Label18.Text = "Item"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.BackColor = Color.Gold
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(4, 1)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 498)
        Label17.TabIndex = 0
        Label17.Text = "Qty"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gold
        Panel2.Controls.Add(lblPaymentMethod)
        Panel2.Controls.Add(Label16)
        Panel2.Location = New Point(15, 250)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(773, 30)
        Panel2.TabIndex = 16
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPaymentMethod.ForeColor = Color.Black
        lblPaymentMethod.Location = New Point(119, 0)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(120, 30)
        lblPaymentMethod.TabIndex = 1
        lblPaymentMethod.Text = "Cash"
        lblPaymentMethod.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(3, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(110, 30)
        Label16.TabIndex = 0
        Label16.Text = "Payment Method"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Location = New Point(115, 215)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(95, 15)
        lblCustomerID.TabIndex = 15
        lblCustomerID.Text = "Customer ID No."
        ' 
        ' lblCustomerPhone
        ' 
        lblCustomerPhone.AutoSize = True
        lblCustomerPhone.Location = New Point(115, 200)
        lblCustomerPhone.Name = "lblCustomerPhone"
        lblCustomerPhone.Size = New Size(41, 15)
        lblCustomerPhone.TabIndex = 14
        lblCustomerPhone.Text = "Phone"
        ' 
        ' lblCustomerCity
        ' 
        lblCustomerCity.AutoSize = True
        lblCustomerCity.Location = New Point(115, 185)
        lblCustomerCity.Name = "lblCustomerCity"
        lblCustomerCity.Size = New Size(98, 15)
        lblCustomerCity.TabIndex = 13
        lblCustomerCity.Text = "City, ST ZIP Code"
        ' 
        ' lblCustomerAddress
        ' 
        lblCustomerAddress.AutoSize = True
        lblCustomerAddress.Location = New Point(115, 170)
        lblCustomerAddress.Name = "lblCustomerAddress"
        lblCustomerAddress.Size = New Size(82, 15)
        lblCustomerAddress.TabIndex = 12
        lblCustomerAddress.Text = "Street Address"
        ' 
        ' lblCustomerCompany
        ' 
        lblCustomerCompany.AutoSize = True
        lblCustomerCompany.Location = New Point(115, 155)
        lblCustomerCompany.Name = "lblCustomerCompany"
        lblCustomerCompany.Size = New Size(94, 15)
        lblCustomerCompany.TabIndex = 11
        lblCustomerCompany.Text = "Company Name"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(115, 140)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(94, 15)
        lblCustomerName.TabIndex = 10
        lblCustomerName.Text = "Customer Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(40, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 17)
        Label9.TabIndex = 9
        Label9.Text = "Sold To"
        ' 
        ' lblReceiptNumber
        ' 
        lblReceiptNumber.AutoSize = True
        lblReceiptNumber.Location = New Point(688, 100)
        lblReceiptNumber.Name = "lblReceiptNumber"
        lblReceiptNumber.Size = New Size(43, 15)
        lblReceiptNumber.TabIndex = 8
        lblReceiptNumber.Text = "000000"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(604, 100)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 15)
        Label7.TabIndex = 7
        Label7.Text = "Receipt # No."
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(688, 80)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(65, 15)
        lblDate.TabIndex = 6
        lblDate.Text = "2024-01-01"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(604, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 5
        Label5.Text = "Date:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(79), CByte(112), CByte(145))
        lblTitle.Location = New Point(400, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(249, 50)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Sales Receipt"
        ' 
        ' lblSlogan
        ' 
        lblSlogan.AutoSize = True
        lblSlogan.Location = New Point(100, 80)
        lblSlogan.Name = "lblSlogan"
        lblSlogan.Size = New Size(0, 15)
        lblSlogan.TabIndex = 3
        ' 
        ' lblLogoName
        ' 
        lblLogoName.AutoSize = True
        lblLogoName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogoName.Location = New Point(96, 70)
        lblLogoName.Name = "lblLogoName"
        lblLogoName.Size = New Size(74, 25)
        lblLogoName.TabIndex = 2
        lblLogoName.Text = "JJ Gym"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(29, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(737, 1018)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(656, 1018)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' PaymentReceipt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(834, 1061)
        Controls.Add(btnPrint)
        Controls.Add(btnSave)
        Controls.Add(pnlReceipt)
        Name = "PaymentReceipt"
        Text = "Payment Receipt"
        pnlReceipt.ResumeLayout(False)
        pnlReceipt.PerformLayout()
        tblLineItems.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReceipt As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSlogan As Label
    Friend WithEvents lblLogoName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblReceiptNumber As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerCompany As Label
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents lblCustomerCity As Label
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents tblLineItems As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblThankYou As Label
    Friend WithEvents lblFooter As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class

