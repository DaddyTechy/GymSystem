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
        Label2 = New Label()
        Label1 = New Label()
        AddEquipment = New Button()
        Panel1 = New Panel()
        dgvEquipmentList = New DataGridView()
        Panel2 = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        Panel1.SuspendLayout()
        CType(dgvEquipmentList, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 37)
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
        Label1.Location = New Point(20, 20)
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
        AddEquipment.Location = New Point(639, 23)
        AddEquipment.Margin = New Padding(3, 2, 3, 2)
        AddEquipment.Name = "AddEquipment"
        AddEquipment.Size = New Size(110, 22)
        AddEquipment.TabIndex = 6
        AddEquipment.Text = "Add Equipment"
        AddEquipment.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvEquipmentList)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(20, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(772, 318)
        Panel1.TabIndex = 7
        ' 
        ' dgvEquipmentList
        ' 
        dgvEquipmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEquipmentList.Dock = DockStyle.Fill
        dgvEquipmentList.Location = New Point(0, 0)
        dgvEquipmentList.Name = "dgvEquipmentList"
        dgvEquipmentList.ReadOnly = True
        dgvEquipmentList.Size = New Size(772, 296)
        dgvEquipmentList.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnNext)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 296)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(772, 22)
        Panel2.TabIndex = 9
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
        btnNext.Location = New Point(723, 0)
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
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Equipmentlist"
        Padding = New Padding(20)
        Size = New Size(812, 411)
        Panel1.ResumeLayout(False)
        CType(dgvEquipmentList, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEquipment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents dgvEquipmentList As DataGridView

End Class
