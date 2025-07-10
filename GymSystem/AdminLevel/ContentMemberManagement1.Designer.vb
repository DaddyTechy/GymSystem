<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentMemberManagement1
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        btnNext = New Button()
        btnBack = New Button()
        flpControls = New FlowLayoutPanel()
        FilterBtn = New Button()
        txtBoxSearchInput = New TextBox()
        btnSearch = New Button()
        MembersTable = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        flpControls.SuspendLayout()
        CType(MembersTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(flpControls)
        Panel1.Controls.Add(MembersTable)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(15, 32)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 0, 20, 0)
        Panel1.Size = New Size(645, 449)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel3.Controls.Add(btnNext)
        Panel3.Controls.Add(btnBack)
        Panel3.Location = New Point(501, 418)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(121, 28)
        Panel3.TabIndex = 11
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Gray
        btnNext.Dock = DockStyle.Right
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.ForeColor = SystemColors.ControlLightLight
        btnNext.Location = New Point(72, 0)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(49, 28)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.Dock = DockStyle.Left
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(0, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(49, 28)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' flpControls
        ' 
        flpControls.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        flpControls.AutoSize = True
        flpControls.Controls.Add(FilterBtn)
        flpControls.Controls.Add(txtBoxSearchInput)
        flpControls.Controls.Add(btnSearch)
        flpControls.Location = New Point(280, 6)
        flpControls.Name = "flpControls"
        flpControls.Size = New Size(342, 35)
        flpControls.TabIndex = 12
        flpControls.WrapContents = False
        ' 
        ' FilterBtn
        ' 
        FilterBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        FilterBtn.FlatStyle = FlatStyle.Flat
        FilterBtn.Location = New Point(3, 3)
        FilterBtn.Name = "FilterBtn"
        FilterBtn.Size = New Size(80, 25)
        FilterBtn.TabIndex = 5
        FilterBtn.Text = "Filter"
        FilterBtn.UseVisualStyleBackColor = False
        ' 
        ' txtBoxSearchInput
        ' 
        txtBoxSearchInput.BackColor = Color.Silver
        txtBoxSearchInput.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearchInput.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxSearchInput.Location = New Point(89, 3)
        txtBoxSearchInput.Name = "txtBoxSearchInput"
        txtBoxSearchInput.Size = New Size(161, 25)
        txtBoxSearchInput.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.ForeColor = Color.White
        btnSearch.Image = search11
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch.Location = New Point(256, 3)
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
        MembersTable.EditMode = DataGridViewEditMode.EditProgrammatically
        MembersTable.EnableHeadersVisualStyles = False
        MembersTable.GridColor = Color.White
        MembersTable.Location = New Point(20, 36)
        MembersTable.MultiSelect = False
        MembersTable.Name = "MembersTable"
        MembersTable.ReadOnly = True
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
        Panel3.ResumeLayout(False)
        flpControls.ResumeLayout(False)
        flpControls.PerformLayout()
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
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents FilterBtn As Button
    Friend WithEvents flpControls As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel

End Class
