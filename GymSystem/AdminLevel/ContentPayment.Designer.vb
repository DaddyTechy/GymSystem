<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentPayment
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        dgvPayment = New DataGridView()
        cmbStatus = New ComboBox()
        cmbPaymentType = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        CType(dgvPayment, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(17, 20)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(89, 23)
        Label1.TabIndex = 2
        Label1.Text = "Payments"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(23, 0)
        Label2.Margin = New Padding(3, 0, 3, 13)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 7, 0, 13)
        Label2.Size = New Size(134, 48)
        Label2.TabIndex = 0
        Label2.Text = "Payment List"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvPayment
        ' 
        dgvPayment.AllowUserToAddRows = False
        dgvPayment.AllowUserToDeleteRows = False
        dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPayment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvPayment.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvPayment.BorderStyle = BorderStyle.None
        dgvPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPayment.DefaultCellStyle = DataGridViewCellStyle2
        dgvPayment.Dock = DockStyle.Fill
        dgvPayment.EditMode = DataGridViewEditMode.EditOnEnter
        dgvPayment.EnableHeadersVisualStyles = False
        dgvPayment.GridColor = Color.White
        dgvPayment.Location = New Point(23, 48)
        dgvPayment.Margin = New Padding(3, 4, 3, 4)
        dgvPayment.MultiSelect = False
        dgvPayment.Name = "dgvPayment"
        dgvPayment.ReadOnly = True
        dgvPayment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPayment.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPayment.RowHeadersVisible = False
        dgvPayment.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        dgvPayment.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvPayment.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPayment.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvPayment.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        dgvPayment.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgvPayment.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPayment.ShowCellErrors = False
        dgvPayment.ShowRowErrors = False
        dgvPayment.Size = New Size(777, 597)
        dgvPayment.TabIndex = 0
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(662, 4)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(138, 28)
        cmbStatus.TabIndex = 5
        ' 
        ' cmbPaymentType
        ' 
        cmbPaymentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentType.FormattingEnabled = True
        cmbPaymentType.Items.AddRange(New Object() {"All", "Membership", "Reservation"})
        cmbPaymentType.Location = New Point(454, 4)
        cmbPaymentType.Margin = New Padding(3, 4, 3, 4)
        cmbPaymentType.Name = "cmbPaymentType"
        cmbPaymentType.Size = New Size(138, 28)
        cmbPaymentType.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(610, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 7
        Label3.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(402, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 8
        Label4.Text = "Type:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbPaymentType)
        Panel1.Controls.Add(cmbStatus)
        Panel1.Controls.Add(dgvPayment)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(17, 43)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(23, 0, 23, 0)
        Panel1.Size = New Size(823, 645)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnNext)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(23, 48)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(777, 25)
        Panel2.TabIndex = 10
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.Dock = DockStyle.Left
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(0, 0)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(56, 25)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Gray
        btnNext.Dock = DockStyle.Right
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.ForeColor = SystemColors.ControlLightLight
        btnNext.Location = New Point(721, 0)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(56, 25)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ContentPayment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ContentPayment"
        Padding = New Padding(17, 20, 17, 20)
        Size = New Size(857, 708)
        CType(dgvPayment, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPayment As DataGridView
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbPaymentType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button

End Class
