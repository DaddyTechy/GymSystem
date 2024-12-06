<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingPaymentForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtTaxAmount = New TextBox()
        Label5 = New Label()
        txtDiscountTotal = New TextBox()
        Label15 = New Label()
        txtSubTotal = New TextBox()
        Label14 = New Label()
        txtReceiptNumber = New TextBox()
        Label13 = New Label()
        txtInvoiceNumber = New TextBox()
        Label12 = New Label()
        dtpPaymentDate = New DateTimePicker()
        Label10 = New Label()
        Panel8 = New Panel()
        txtPaymentNotes = New TextBox()
        Label11 = New Label()
        txtDiscountAmount = New TextBox()
        lblDiscount = New Label()
        chkDiscount = New CheckBox()
        txtAmount = New TextBox()
        Label9 = New Label()
        cmbPaymentMethod = New ComboBox()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        txtTotalAmount = New TextBox()
        Label16 = New Label()
        btnSave = New Button()
        Panel2 = New Panel()
        btnbck = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(20, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(803, 470)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(txtTaxAmount)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txtDiscountTotal)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(txtSubTotal)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(txtReceiptNumber)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(txtInvoiceNumber)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(dtpPaymentDate)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 53)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(803, 417)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = JJ_Fitness_GYM
        PictureBox2.Location = New Point(38, 131)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(165, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 41
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(38, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' txtTaxAmount
        ' 
        txtTaxAmount.ForeColor = Color.Black
        txtTaxAmount.Location = New Point(406, 327)
        txtTaxAmount.Name = "txtTaxAmount"
        txtTaxAmount.ReadOnly = True
        txtTaxAmount.Size = New Size(83, 23)
        txtTaxAmount.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(373, 335)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 15)
        Label5.TabIndex = 38
        Label5.Text = "VAT"
        ' 
        ' txtDiscountTotal
        ' 
        txtDiscountTotal.Enabled = False
        txtDiscountTotal.ForeColor = Color.IndianRed
        txtDiscountTotal.Location = New Point(264, 327)
        txtDiscountTotal.Name = "txtDiscountTotal"
        txtDiscountTotal.ReadOnly = True
        txtDiscountTotal.Size = New Size(100, 23)
        txtDiscountTotal.TabIndex = 34
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.ForeColor = Color.White
        Label15.Location = New Point(196, 335)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 15)
        Label15.TabIndex = 33
        Label15.Text = "Discount"
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(264, 298)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.ReadOnly = True
        txtSubTotal.Size = New Size(100, 23)
        txtSubTotal.TabIndex = 34
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(185, 297)
        Label14.Name = "Label14"
        Label14.Size = New Size(68, 20)
        Label14.TabIndex = 37
        Label14.Text = "SubTotal"
        ' 
        ' txtReceiptNumber
        ' 
        txtReceiptNumber.Location = New Point(582, 109)
        txtReceiptNumber.Name = "txtReceiptNumber"
        txtReceiptNumber.ReadOnly = True
        txtReceiptNumber.Size = New Size(200, 23)
        txtReceiptNumber.TabIndex = 36
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(499, 109)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 15)
        Label13.TabIndex = 35
        Label13.Text = "Receipt No. : "
        ' 
        ' txtInvoiceNumber
        ' 
        txtInvoiceNumber.Location = New Point(582, 71)
        txtInvoiceNumber.Name = "txtInvoiceNumber"
        txtInvoiceNumber.ReadOnly = True
        txtInvoiceNumber.Size = New Size(200, 23)
        txtInvoiceNumber.TabIndex = 34
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Location = New Point(503, 71)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 15)
        Label12.TabIndex = 33
        Label12.Text = "Invoice No. :"
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Location = New Point(582, 34)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(200, 23)
        dtpPaymentDate.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(542, 34)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 15)
        Label10.TabIndex = 31
        Label10.Text = "Date:"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(txtPaymentNotes)
        Panel8.Controls.Add(Label11)
        Panel8.Controls.Add(txtDiscountAmount)
        Panel8.Controls.Add(lblDiscount)
        Panel8.Controls.Add(chkDiscount)
        Panel8.Controls.Add(txtAmount)
        Panel8.Controls.Add(Label9)
        Panel8.Controls.Add(cmbPaymentMethod)
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(252, 17)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(237, 255)
        Panel8.TabIndex = 20
        ' 
        ' txtPaymentNotes
        ' 
        txtPaymentNotes.Location = New Point(12, 194)
        txtPaymentNotes.Multiline = True
        txtPaymentNotes.Name = "txtPaymentNotes"
        txtPaymentNotes.ReadOnly = True
        txtPaymentNotes.Size = New Size(218, 61)
        txtPaymentNotes.TabIndex = 32
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(12, 176)
        Label11.Name = "Label11"
        Label11.Size = New Size(33, 15)
        Label11.TabIndex = 31
        Label11.Text = "Note"
        ' 
        ' txtDiscountAmount
        ' 
        txtDiscountAmount.Enabled = False
        txtDiscountAmount.Location = New Point(129, 106)
        txtDiscountAmount.Name = "txtDiscountAmount"
        txtDiscountAmount.Size = New Size(100, 23)
        txtDiscountAmount.TabIndex = 30
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.ForeColor = Color.White
        lblDiscount.Location = New Point(129, 88)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(101, 15)
        lblDiscount.TabIndex = 29
        lblDiscount.Text = "Discount Amount"
        ' 
        ' chkDiscount
        ' 
        chkDiscount.AutoSize = True
        chkDiscount.ForeColor = SystemColors.Control
        chkDiscount.Location = New Point(12, 137)
        chkDiscount.Name = "chkDiscount"
        chkDiscount.Size = New Size(73, 19)
        chkDiscount.TabIndex = 28
        chkDiscount.Text = "Discount"
        chkDiscount.UseVisualStyleBackColor = True
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(12, 106)
        txtAmount.Name = "txtAmount"
        txtAmount.ReadOnly = True
        txtAmount.Size = New Size(100, 23)
        txtAmount.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(12, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 15)
        Label9.TabIndex = 26
        Label9.Text = "Fee Amount"
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(12, 37)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(121, 23)
        cmbPaymentMethod.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 15)
        Label8.TabIndex = 24
        Label8.Text = "Payment Method"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(28, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(224, 19)
        Label4.TabIndex = 19
        Label4.Text = "Email: JJFITNESSGYM@gmail.com"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(28, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 19)
        Label3.TabIndex = 18
        Label3.Text = "Tel: 09123456789"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(28, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 19)
        Label2.TabIndex = 17
        Label2.Text = "Daet, Camarines Norte"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtTotalAmount)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(btnSave)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 364)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(801, 51)
        Panel4.TabIndex = 0
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalAmount.ForeColor = Color.Gold
        txtTotalAmount.Location = New Point(494, 13)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(100, 23)
        txtTotalAmount.TabIndex = 38
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(433, 11)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 21)
        Label16.TabIndex = 39
        Label16.Text = "Total"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(91))
        btnSave.BackgroundImageLayout = ImageLayout.None
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(648, 6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(133, 34)
        btnSave.TabIndex = 2
        btnSave.Text = "$ Make Payment"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnbck)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(803, 53)
        Panel2.TabIndex = 2
        ' 
        ' btnbck
        ' 
        btnbck.BackColor = Color.DimGray
        btnbck.FlatStyle = FlatStyle.Popup
        btnbck.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnbck.ForeColor = Color.White
        btnbck.Location = New Point(38, 14)
        btnbck.Name = "btnbck"
        btnbck.Size = New Size(75, 23)
        btnbck.TabIndex = 19
        btnbck.Text = "Back"
        btnbck.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Image = Vector_4
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(652, 10)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(3)
        Label1.Size = New Size(130, 27)
        Label1.TabIndex = 18
        Label1.Text = "Payments           "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BillingPaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Controls.Add(Panel1)
        Name = "BillingPaymentForm"
        Padding = New Padding(20)
        Size = New Size(843, 510)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtInvoiceNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPaymentNotes As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReceiptNumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtDiscountTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTaxAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnbck As Button

End Class
