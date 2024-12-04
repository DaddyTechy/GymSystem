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
        Panel1 = New Panel()
        Panel2 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        addnewStaffBtn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 496)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 496)
        Panel2.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(addnewStaffBtn, 0, 0)
        TableLayoutPanel1.Location = New Point(22, 15)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.9013453F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 86.0986557F))
        TableLayoutPanel1.Size = New Size(632, 447)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' addnewStaffBtn
        ' 
        addnewStaffBtn.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        addnewStaffBtn.BackgroundImageLayout = ImageLayout.Zoom
        addnewStaffBtn.Dock = DockStyle.Left
        addnewStaffBtn.FlatAppearance.BorderColor = Color.Black
        addnewStaffBtn.FlatAppearance.BorderSize = 0
        addnewStaffBtn.FlatStyle = FlatStyle.Flat
        addnewStaffBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addnewStaffBtn.ForeColor = SystemColors.ControlLight
        addnewStaffBtn.Image = My.Resources.Resources.Group
        addnewStaffBtn.ImageAlign = ContentAlignment.MiddleLeft
        addnewStaffBtn.Location = New Point(4, 4)
        addnewStaffBtn.Name = "addnewStaffBtn"
        addnewStaffBtn.Size = New Size(158, 55)
        addnewStaffBtn.TabIndex = 0
        addnewStaffBtn.Text = "Add New Staff"
        addnewStaffBtn.TextAlign = ContentAlignment.MiddleRight
        addnewStaffBtn.UseVisualStyleBackColor = False
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(Panel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentStaffManage"
        Size = New Size(675, 496)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents addnewStaffBtn As Button

End Class
