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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label2 = New Label()
        Label1 = New Label()
        dgvStafflist = New DataGridView()
        AddStaff = New Button()
        Panel1 = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        CType(dgvStafflist, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        ' dgvStafflist
        ' 
        dgvStafflist.AllowUserToAddRows = False
        dgvStafflist.AllowUserToDeleteRows = False
        dgvStafflist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStafflist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvStafflist.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvStafflist.BorderStyle = BorderStyle.None
        dgvStafflist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStafflist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStafflist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStafflist.DefaultCellStyle = DataGridViewCellStyle2
        dgvStafflist.Dock = DockStyle.Fill
        dgvStafflist.EditMode = DataGridViewEditMode.EditOnEnter
        dgvStafflist.EnableHeadersVisualStyles = False
        dgvStafflist.GridColor = Color.White
        dgvStafflist.Location = New Point(13, 64)
        dgvStafflist.MultiSelect = False
        dgvStafflist.Name = "dgvStafflist"
        dgvStafflist.ReadOnly = True
        dgvStafflist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvStafflist.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvStafflist.RowHeadersVisible = False
        dgvStafflist.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        dgvStafflist.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvStafflist.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvStafflist.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvStafflist.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        dgvStafflist.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgvStafflist.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvStafflist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStafflist.ShowCellErrors = False
        dgvStafflist.ShowRowErrors = False
        dgvStafflist.Size = New Size(649, 421)
        dgvStafflist.TabIndex = 8
        ' 
        ' AddStaff
        ' 
        AddStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddStaff.BackColor = Color.DimGray
        AddStaff.FlatStyle = FlatStyle.Popup
        AddStaff.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        AddStaff.ForeColor = Color.White
        AddStaff.Location = New Point(522, 28)
        AddStaff.Margin = New Padding(3, 2, 3, 2)
        AddStaff.Name = "AddStaff"
        AddStaff.Size = New Size(75, 22)
        AddStaff.TabIndex = 9
        AddStaff.Text = "Add Staff"
        AddStaff.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnNext)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(13, 463)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(649, 22)
        Panel1.TabIndex = 10
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
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(Panel1)
        Controls.Add(AddStaff)
        Controls.Add(dgvStafflist)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MinimumSize = New Size(675, 496)
        Name = "ContentStaffManage"
        Padding = New Padding(13, 11, 13, 11)
        Size = New Size(675, 496)
        CType(dgvStafflist, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvStafflist As DataGridView
    Friend WithEvents AddStaff As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button

End Class
