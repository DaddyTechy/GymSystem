<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentStaffManageList
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
        btnsearchStaff = New Button()
        txtboxinputstaff = New TextBox()
        StaffList = New DataGridView()
        Label1 = New Label()
        AddNewStaff = New Button()
        Panel1.SuspendLayout()
        CType(StaffList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnsearchStaff)
        Panel1.Controls.Add(txtboxinputstaff)
        Panel1.Controls.Add(StaffList)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(26, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(719, 578)
        Panel1.TabIndex = 0
        ' 
        ' btnsearchStaff
        ' 
        btnsearchStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnsearchStaff.FlatStyle = FlatStyle.Popup
        btnsearchStaff.ForeColor = Color.White
        btnsearchStaff.Image = search11
        btnsearchStaff.ImageAlign = ContentAlignment.MiddleLeft
        btnsearchStaff.Location = New Point(609, 12)
        btnsearchStaff.Margin = New Padding(3, 4, 3, 4)
        btnsearchStaff.Name = "btnsearchStaff"
        btnsearchStaff.Size = New Size(95, 32)
        btnsearchStaff.TabIndex = 5
        btnsearchStaff.Text = "Search"
        btnsearchStaff.TextAlign = ContentAlignment.BottomCenter
        btnsearchStaff.TextImageRelation = TextImageRelation.ImageBeforeText
        btnsearchStaff.UseVisualStyleBackColor = True
        ' 
        ' txtboxinputstaff
        ' 
        txtboxinputstaff.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtboxinputstaff.Location = New Point(416, 15)
        txtboxinputstaff.Name = "txtboxinputstaff"
        txtboxinputstaff.Size = New Size(184, 27)
        txtboxinputstaff.TabIndex = 2
        ' 
        ' StaffList
        ' 
        StaffList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        StaffList.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        StaffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StaffList.Location = New Point(14, 45)
        StaffList.Margin = New Padding(3, 4, 3, 4)
        StaffList.Name = "StaffList"
        StaffList.RowHeadersWidth = 51
        StaffList.Size = New Size(690, 518)
        StaffList.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(14, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 31)
        Label1.TabIndex = 0
        Label1.Text = "Staff List"
        ' 
        ' AddNewStaff
        ' 
        AddNewStaff.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AddNewStaff.BackColor = Color.Gold
        AddNewStaff.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddNewStaff.Location = New Point(516, 604)
        AddNewStaff.Name = "AddNewStaff"
        AddNewStaff.Size = New Size(214, 47)
        AddNewStaff.TabIndex = 1
        AddNewStaff.Text = "Add New Staff"
        AddNewStaff.UseVisualStyleBackColor = False
        ' 
        ' ContentStaffManageList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(AddNewStaff)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentStaffManageList"
        Padding = New Padding(23, 27, 23, 27)
        Size = New Size(771, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(StaffList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffList As DataGridView
    Friend WithEvents txtboxinputstaff As TextBox
    Friend WithEvents btnsearchStaff As Button

    Private Sub SetDGVProperties(dgv As DataGridView)
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40)

        dgv.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgv.DefaultCellStyle.ForeColor = Color.White
        dgv.DefaultCellStyle.BackColor = parentBackgroundColor
        dgv.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor
        dgv.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.BorderStyle = BorderStyle.None
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 10.0F)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        cellStyle.Font = New Font("Segoe UI", 9.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.True
        dgv.DefaultCellStyle = cellStyle

        dgv.Dock = DockStyle.Fill
        dgv.EditMode = DataGridViewEditMode.EditOnEnter
        dgv.EnableHeadersVisualStyles = False
        dgv.GridColor = Color.White
        dgv.MultiSelect = False
        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Dim rowHeaderStyle As New DataGridViewCellStyle()
        rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        rowHeaderStyle.BackColor = SystemColors.WindowFrame
        rowHeaderStyle.Font = New Font("Segoe UI", 9.75F)
        rowHeaderStyle.ForeColor = Color.White
        rowHeaderStyle.SelectionBackColor = SystemColors.Highlight
        rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        rowHeaderStyle.WrapMode = DataGridViewTriState.True
        dgv.RowHeadersDefaultCellStyle = rowHeaderStyle

        dgv.RowHeadersVisible = False
        dgv.RowHeadersWidth = 51

        Dim rowsStyle As New DataGridViewCellStyle()
        rowsStyle.BackColor = Color.FromArgb(40, 40, 40)
        rowsStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rowsStyle.ForeColor = Color.White
        dgv.RowsDefaultCellStyle = rowsStyle

        dgv.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgv.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.0F)
        dgv.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgv.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ShowCellErrors = False
        dgv.ShowRowErrors = False
    End Sub

    Friend WithEvents AddNewStaff As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddNewStaff.Click
        Dim AddNewStaff As New ContentStaffManageForm
        AddNewStaff.ShowDialog()
    End Sub
End Class
