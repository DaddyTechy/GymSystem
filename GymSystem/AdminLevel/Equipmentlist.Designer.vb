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
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).BeginInit()
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
        dgvEquipmentlist.Location = New Point(15, 86)
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
        dgvEquipmentlist.Size = New Size(898, 447)
        dgvEquipmentlist.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 38)
        Label2.Margin = New Padding(3, 0, 3, 13)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 7, 0, 13)
        Label2.Size = New Size(153, 48)
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
        Label1.Location = New Point(15, 15)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(133, 23)
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
        AddEquipment.Location = New Point(738, 18)
        AddEquipment.Name = "AddEquipment"
        AddEquipment.Size = New Size(126, 29)
        AddEquipment.TabIndex = 6
        AddEquipment.Text = "Add Equipment"
        AddEquipment.UseVisualStyleBackColor = False
        ' 
        ' Equipmentlist
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(AddEquipment)
        Controls.Add(dgvEquipmentlist)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Equipmentlist"
        Padding = New Padding(15)
        Size = New Size(928, 548)
        CType(dgvEquipmentlist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEquipmentlist As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEquipment As Button

End Class
