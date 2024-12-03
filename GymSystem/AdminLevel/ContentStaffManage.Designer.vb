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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label2 = New Label()
        Label1 = New Label()
        dgvStafflist = New DataGridView()
        AddStaff = New Button()
        CType(dgvStafflist, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Size = New Size(97, 48)
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
        Label1.Location = New Point(15, 15)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(85, 23)
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
        dgvStafflist.Location = New Point(15, 86)
        dgvStafflist.Margin = New Padding(3, 4, 3, 4)
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
        dgvStafflist.Size = New Size(741, 560)
        dgvStafflist.TabIndex = 8
        ' 
        ' AddStaff
        ' 
        AddStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddStaff.BackColor = Color.DimGray
        AddStaff.FlatStyle = FlatStyle.Popup
        AddStaff.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        AddStaff.ForeColor = Color.White
        AddStaff.Location = New Point(596, 38)
        AddStaff.Name = "AddStaff"
        AddStaff.Size = New Size(86, 29)
        AddStaff.TabIndex = 9
        AddStaff.Text = "Add Staff"
        AddStaff.UseVisualStyleBackColor = False
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(AddStaff)
        Controls.Add(dgvStafflist)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentStaffManage"
        Padding = New Padding(15)
        Size = New Size(771, 661)
        CType(dgvStafflist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvStafflist As DataGridView
    Friend WithEvents AddStaff As Button

End Class
