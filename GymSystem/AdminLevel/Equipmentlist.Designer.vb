<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipmentlist
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
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        cmbPaymentType = New ComboBox()
        cmbStatus = New ComboBox()
        btnSearch = New Button()
        dgvEquipmentlist = New DataGridView()
        txtBoxSearchInput = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        bttnAddEquipment = New Button()
        Panel1.SuspendLayout()
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbPaymentType)
        Panel1.Controls.Add(cmbStatus)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(dgvEquipmentlist)
        Panel1.Controls.Add(txtBoxSearchInput)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(15, 38)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(23, 0, 23, 0)
        Panel1.Size = New Size(898, 495)
        Panel1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1077, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 8
        Label4.Text = "Type:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1285, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 7
        Label3.Text = "Status:"
        ' 
        ' cmbPaymentType
        ' 
        cmbPaymentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentType.FormattingEnabled = True
        cmbPaymentType.Items.AddRange(New Object() {"All", "Membership", "Reservation"})
        cmbPaymentType.Location = New Point(1129, 4)
        cmbPaymentType.Margin = New Padding(3, 4, 3, 4)
        cmbPaymentType.Name = "cmbPaymentType"
        cmbPaymentType.Size = New Size(138, 28)
        cmbPaymentType.TabIndex = 6
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(1337, 4)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(138, 28)
        cmbStatus.TabIndex = 5
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.ForeColor = Color.White
        btnSearch.Image = Cog_1
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch.Location = New Point(1866, 8)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(95, 32)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.TextAlign = ContentAlignment.BottomCenter
        btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvEquipmentlist
        ' 
        dgvEquipmentlist.AllowUserToAddRows = False
        dgvEquipmentlist.AllowUserToDeleteRows = False
        dgvEquipmentlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEquipmentlist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvEquipmentlist.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvEquipmentlist.BorderStyle = BorderStyle.None
        dgvEquipmentlist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEquipmentlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEquipmentlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEquipmentlist.DefaultCellStyle = DataGridViewCellStyle2
        dgvEquipmentlist.Dock = DockStyle.Fill
        dgvEquipmentlist.EditMode = DataGridViewEditMode.EditOnEnter
        dgvEquipmentlist.EnableHeadersVisualStyles = False
        dgvEquipmentlist.GridColor = Color.White
        dgvEquipmentlist.Location = New Point(23, 48)
        dgvEquipmentlist.Margin = New Padding(3, 4, 3, 4)
        dgvEquipmentlist.MultiSelect = False
        dgvEquipmentlist.Name = "dgvEquipmentlist"
        dgvEquipmentlist.ReadOnly = True
        dgvEquipmentlist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvEquipmentlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvEquipmentlist.RowHeadersVisible = False
        dgvEquipmentlist.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        dgvEquipmentlist.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvEquipmentlist.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvEquipmentlist.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvEquipmentlist.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        dgvEquipmentlist.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgvEquipmentlist.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvEquipmentlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEquipmentlist.ShowCellErrors = False
        dgvEquipmentlist.ShowRowErrors = False
        dgvEquipmentlist.Size = New Size(852, 447)
        dgvEquipmentlist.TabIndex = 0
        ' 
        ' txtBoxSearchInput
        ' 
        txtBoxSearchInput.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBoxSearchInput.BackColor = Color.Silver
        txtBoxSearchInput.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearchInput.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxSearchInput.Location = New Point(1681, 8)
        txtBoxSearchInput.Margin = New Padding(3, 4, 3, 4)
        txtBoxSearchInput.Name = "txtBoxSearchInput"
        txtBoxSearchInput.Size = New Size(184, 29)
        txtBoxSearchInput.TabIndex = 3
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
        Label2.Size = New Size(153, 48)
        Label2.TabIndex = 0
        Label2.Text = "Equipment List"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(15, 15)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(133, 23)
        Label1.TabIndex = 4
        Label1.Text = "Equipment List"
        ' 
        ' bttnAddEquipment
        ' 
        bttnAddEquipment.BackColor = Color.DimGray
        bttnAddEquipment.FlatStyle = FlatStyle.Popup
        bttnAddEquipment.ForeColor = Color.White
        bttnAddEquipment.Location = New Point(705, 9)
        bttnAddEquipment.Name = "bttnAddEquipment"
        bttnAddEquipment.Size = New Size(124, 29)
        bttnAddEquipment.TabIndex = 9
        bttnAddEquipment.Text = "Add Equipment"
        bttnAddEquipment.UseVisualStyleBackColor = False
        ' 
        ' Equipmentlist
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(bttnAddEquipment)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Equipmentlist"
        Padding = New Padding(15)
        Size = New Size(928, 548)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPaymentType As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvEquipmentlist As DataGridView
    Friend WithEvents txtBoxSearchInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnAddEquipment As Button

End Class
