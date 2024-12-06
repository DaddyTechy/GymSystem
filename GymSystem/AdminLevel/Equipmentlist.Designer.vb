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
        dgvEquipmentlist = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        AddEquipment = New Button()
        Panel1 = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        dgvEquipmentlist.Location = New Point(13, 64)
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
        dgvEquipmentlist.Size = New Size(786, 336)
        dgvEquipmentlist.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 28)
        Label2.Margin = New Padding(3, 0, 3, 10)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 5, 0, 10)
        Label2.Size = New Size(124, 36)
        Label2.TabIndex = 4
        Label2.Text = "Equipment List"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(13, 11)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(103, 17)
        Label1.TabIndex = 5
        Label1.Text = "Equipment List"
        ' 
        ' AddEquipment
        ' 
        AddEquipment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddEquipment.BackColor = Color.DimGray
        AddEquipment.FlatStyle = FlatStyle.Popup
        AddEquipment.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        AddEquipment.ForeColor = Color.White
        AddEquipment.Location = New Point(646, 14)
        AddEquipment.Margin = New Padding(3, 2, 3, 2)
        AddEquipment.Name = "AddEquipment"
        AddEquipment.Size = New Size(110, 22)
        AddEquipment.TabIndex = 6
        AddEquipment.Text = "Add Equipment"
        AddEquipment.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnNext)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(13, 378)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(786, 22)
        Panel1.TabIndex = 7
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.Dock = DockStyle.Left
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(0, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(49, 22)
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
        btnNext.Location = New Point(737, 0)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(49, 22)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Equipmentlist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(Panel1)
        Controls.Add(AddEquipment)
        Controls.Add(dgvEquipmentlist)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Equipmentlist"
        Padding = New Padding(13, 11, 13, 11)
        Size = New Size(812, 411)
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEquipmentlist As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEquipment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button

End Class
