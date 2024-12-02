<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentMemberManagement1
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
        Panel1 = New Panel()
        btnSearch = New Button()
        MembersTable = New DataGridView()
        txtBoxSearchInput = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(MembersTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(MembersTable)
        Panel1.Controls.Add(txtBoxSearchInput)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(15, 32)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 0, 20, 0)
        Panel1.Size = New Size(645, 449)
        Panel1.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.ForeColor = Color.White
        btnSearch.Image = Cog_1
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch.Location = New Point(542, 6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(83, 24)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.TextAlign = ContentAlignment.BottomCenter
        btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' MembersTable
        ' 
        MembersTable.AllowUserToAddRows = False
        MembersTable.AllowUserToDeleteRows = False
        MembersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        MembersTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        MembersTable.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        MembersTable.BorderStyle = BorderStyle.None
        MembersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        MembersTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        MembersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        MembersTable.DefaultCellStyle = DataGridViewCellStyle2
        MembersTable.Dock = DockStyle.Fill
        MembersTable.EditMode = DataGridViewEditMode.EditOnEnter
        MembersTable.EnableHeadersVisualStyles = False
        MembersTable.GridColor = Color.White
        MembersTable.Location = New Point(20, 36)
        MembersTable.MultiSelect = False
        MembersTable.Name = "MembersTable"
        MembersTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        MembersTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        MembersTable.RowHeadersVisible = False
        MembersTable.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        MembersTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        MembersTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MembersTable.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        MembersTable.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        MembersTable.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        MembersTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MembersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        MembersTable.ShowCellErrors = False
        MembersTable.ShowRowErrors = False
        MembersTable.Size = New Size(605, 413)
        MembersTable.TabIndex = 0
        ' 
        ' txtBoxSearchInput
        ' 
        txtBoxSearchInput.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBoxSearchInput.BackColor = Color.Silver
        txtBoxSearchInput.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearchInput.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxSearchInput.Location = New Point(380, 6)
        txtBoxSearchInput.Name = "txtBoxSearchInput"
        txtBoxSearchInput.Size = New Size(161, 25)
        txtBoxSearchInput.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 0)
        Label2.Margin = New Padding(3, 0, 3, 10)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 5, 0, 10)
        Label2.Size = New Size(119, 36)
        Label2.TabIndex = 0
        Label2.Text = "Member Table"
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
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 0
        Label1.Text = "Registered Members"
        ' 
        ' ContentMemberManagement1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(600, 0)
        BackColor = Color.Transparent
        Controls.Add(Panel1)
        Controls.Add(Label1)
        MinimumSize = New Size(675, 496)
        Name = "ContentMemberManagement1"
        Padding = New Padding(15)
        Size = New Size(675, 496)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(MembersTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MembersTable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtBoxSearchInput As TextBox

End Class
