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
        pnlFilter = New FlowLayoutPanel()
        cmbPositionFilter = New ComboBox()
        txtSearch = New TextBox()
        Panel2.SuspendLayout()
        CType(dgvStaffList, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilter.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 28)
        Label2.Margin = New Padding(3, 0, 3, 10)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 5, 0, 10)
        Label2.Size = New Size(76, 36)
        Label2.TabIndex = 6
        Label2.Text = "Staff List"
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
        Label1.Size = New Size(65, 17)
        Label1.TabIndex = 7
        Label1.Text = "Staff List"
        ' 
        ' AddStaff
        ' 
        AddStaff.BackColor = Color.DimGray
        AddStaff.FlatStyle = FlatStyle.Popup
        AddStaff.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        AddStaff.ForeColor = Color.White
        AddStaff.Location = New Point(285, 2)
        AddStaff.Margin = New Padding(3, 2, 3, 2)
        AddStaff.Name = "AddStaff"
        AddStaff.Size = New Size(75, 23)
        AddStaff.TabIndex = 9
        AddStaff.Text = "Add Staff"
        AddStaff.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnNext)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(13, 463)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(649, 22)
        Panel2.TabIndex = 12
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
        btnNext.Location = New Point(600, 0)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(49, 22)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' dgvStaffList
        ' 
        dgvStaffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaffList.Dock = DockStyle.Fill
        dgvStaffList.Location = New Point(13, 64)
        dgvStaffList.Name = "dgvStaffList"
        dgvStaffList.ReadOnly = True
        dgvStaffList.RowHeadersWidth = 51
        dgvStaffList.Size = New Size(649, 399)
        dgvStaffList.TabIndex = 13
        ' 
        ' pnlFilter
        ' 
        pnlFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlFilter.AutoSize = True
        pnlFilter.Controls.Add(cmbPositionFilter)
        pnlFilter.Controls.Add(txtSearch)
        pnlFilter.Controls.Add(AddStaff)
        pnlFilter.Location = New Point(299, 28)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Size = New Size(363, 29)
        pnlFilter.TabIndex = 14
        ' 
        ' cmbPositionFilter
        ' 
        cmbPositionFilter.FormattingEnabled = True
        cmbPositionFilter.Location = New Point(3, 3)
        cmbPositionFilter.Name = "cmbPositionFilter"
        cmbPositionFilter.Size = New Size(150, 23)
        cmbPositionFilter.TabIndex = 10
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(159, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(120, 23)
        txtSearch.TabIndex = 11
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(pnlFilter)
        Controls.Add(dgvStaffList)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MinimumSize = New Size(675, 496)
        Name = "ContentStaffManage"
        Padding = New Padding(13, 11, 13, 11)
        Size = New Size(675, 496)
        Panel2.ResumeLayout(False)
        CType(dgvStaffList, ComponentModel.ISupportInitialize).EndInit()
        pnlFilter.ResumeLayout(False)
        pnlFilter.PerformLayout()
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
    Friend WithEvents pnlFilter As FlowLayoutPanel
    Friend WithEvents cmbPositionFilter As ComboBox
    Friend WithEvents txtSearch As TextBox

End Class
