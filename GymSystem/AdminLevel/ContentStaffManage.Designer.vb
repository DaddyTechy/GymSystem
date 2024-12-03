<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentStaffManage
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvStafflist = New DataGridView()
        addnewStaffBtn = New Button()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvStafflist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(771, 661)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(771, 661)
        Panel2.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(dgvStafflist, 0, 2)
        TableLayoutPanel1.Controls.Add(addnewStaffBtn, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Location = New Point(25, 20)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 48.2456131F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51.7543869F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 481F))
        TableLayoutPanel1.Size = New Size(722, 596)
        TableLayoutPanel1.TabIndex = 0
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvStafflist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvStafflist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvStafflist.DefaultCellStyle = DataGridViewCellStyle6
        dgvStafflist.Dock = DockStyle.Fill
        dgvStafflist.EditMode = DataGridViewEditMode.EditOnEnter
        dgvStafflist.EnableHeadersVisualStyles = False
        dgvStafflist.GridColor = Color.White
        dgvStafflist.Location = New Point(4, 117)
        dgvStafflist.Margin = New Padding(3, 4, 3, 4)
        dgvStafflist.MultiSelect = False
        dgvStafflist.Name = "dgvStafflist"
        dgvStafflist.ReadOnly = True
        dgvStafflist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvStafflist.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvStafflist.RowHeadersVisible = False
        dgvStafflist.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        dgvStafflist.RowsDefaultCellStyle = DataGridViewCellStyle8
        dgvStafflist.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvStafflist.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dgvStafflist.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        dgvStafflist.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgvStafflist.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvStafflist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStafflist.ShowCellErrors = False
        dgvStafflist.ShowRowErrors = False
        dgvStafflist.Size = New Size(714, 474)
        dgvStafflist.TabIndex = 2
        ' 
        ' addnewStaffBtn
        ' 
        addnewStaffBtn.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        addnewStaffBtn.BackgroundImageLayout = ImageLayout.Zoom
        addnewStaffBtn.FlatAppearance.BorderColor = Color.Black
        addnewStaffBtn.FlatAppearance.BorderSize = 0
        addnewStaffBtn.FlatStyle = FlatStyle.Flat
        addnewStaffBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addnewStaffBtn.ForeColor = SystemColors.ControlLight
        addnewStaffBtn.Image = Group
        addnewStaffBtn.ImageAlign = ContentAlignment.MiddleLeft
        addnewStaffBtn.Location = New Point(4, 5)
        addnewStaffBtn.Margin = New Padding(3, 4, 3, 4)
        addnewStaffBtn.Name = "addnewStaffBtn"
        addnewStaffBtn.Size = New Size(181, 45)
        addnewStaffBtn.TabIndex = 0
        addnewStaffBtn.Text = "Add New Staff"
        addnewStaffBtn.TextAlign = ContentAlignment.MiddleRight
        addnewStaffBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(4, 55)
        Label2.Margin = New Padding(3, 0, 3, 13)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 7, 0, 13)
        Label2.Size = New Size(714, 44)
        Label2.TabIndex = 1
        Label2.Text = "Staff List"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentStaffManage"
        Size = New Size(771, 661)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvStafflist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents addnewStaffBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvStafflist As DataGridView

End Class
