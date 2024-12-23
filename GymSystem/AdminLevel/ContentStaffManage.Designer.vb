<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentStaffManage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        AddStaff = New Button()
        Panel2 = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        dgvStaffList = New DataGridView()
        Panel2.SuspendLayout()
        CType(dgvStaffList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Label2.Size = New Size(157, 48)
        Label2.TabIndex = 6
        Label2.Text = "Staff List12131"
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
        Label1.Size = New Size(85, 23)
        Label1.TabIndex = 7
        Label1.Text = "Staff List"
        ' 
        ' AddStaff
        ' 
        AddStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddStaff.BackColor = Color.DimGray
        AddStaff.FlatStyle = FlatStyle.Popup
        AddStaff.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        AddStaff.ForeColor = Color.White
        AddStaff.Location = New Point(597, 37)
        AddStaff.Name = "AddStaff"
        AddStaff.Size = New Size(86, 29)
        AddStaff.TabIndex = 9
        AddStaff.Text = "Add Staff"
        AddStaff.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnNext)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(15, 617)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(741, 29)
        Panel2.TabIndex = 12
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
        btnBack.Size = New Size(56, 29)
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
        btnNext.Location = New Point(685, 0)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(56, 29)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' dgvStaffList
        ' 
        dgvStaffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaffList.Dock = DockStyle.Fill
        dgvStaffList.Location = New Point(15, 86)
        dgvStaffList.Margin = New Padding(3, 4, 3, 4)
        dgvStaffList.Name = "dgvStaffList"
        dgvStaffList.ReadOnly = True
        dgvStaffList.RowHeadersWidth = 51
        dgvStaffList.Size = New Size(741, 531)
        dgvStaffList.TabIndex = 13
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(dgvStaffList)
        Controls.Add(Panel2)
        Controls.Add(AddStaff)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentStaffManage"
        Padding = New Padding(15)
        Size = New Size(771, 661)
        Panel2.ResumeLayout(False)
        CType(dgvStaffList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddStaff As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents dgvStaffList As DataGridView

End Class
