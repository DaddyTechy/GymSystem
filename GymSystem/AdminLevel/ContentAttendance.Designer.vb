﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentAttendance
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
        btnAddAttendance = New Button()
        btnSearch2 = New Button()
        txtUserInput = New TextBox()
        btnSearch = New Button()
        attendanceDGV = New DataGridView()
        txtBoxSearchInput = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(attendanceDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnAddAttendance)
        Panel1.Controls.Add(btnSearch2)
        Panel1.Controls.Add(txtUserInput)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(attendanceDGV)
        Panel1.Controls.Add(txtBoxSearchInput)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(17, 43)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(23, 0, 23, 0)
        Panel1.Size = New Size(737, 598)
        Panel1.TabIndex = 3
        ' 
        ' btnAddAttendance
        ' 
        btnAddAttendance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddAttendance.FlatStyle = FlatStyle.Popup
        btnAddAttendance.ForeColor = Color.White
        btnAddAttendance.Image = edit
        btnAddAttendance.ImageAlign = ContentAlignment.MiddleRight
        btnAddAttendance.Location = New Point(341, 0)
        btnAddAttendance.Margin = New Padding(3, 4, 3, 4)
        btnAddAttendance.Name = "btnAddAttendance"
        btnAddAttendance.Size = New Size(86, 39)
        btnAddAttendance.TabIndex = 13
        btnAddAttendance.Text = "Add"
        btnAddAttendance.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnSearch2
        ' 
        btnSearch2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch2.FlatStyle = FlatStyle.Popup
        btnSearch2.ForeColor = Color.White
        btnSearch2.Image = Cog_1
        btnSearch2.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch2.Location = New Point(618, 7)
        btnSearch2.Margin = New Padding(3, 4, 3, 4)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(95, 32)
        btnSearch2.TabIndex = 6
        btnSearch2.Text = "Search"
        btnSearch2.TextAlign = ContentAlignment.BottomCenter
        btnSearch2.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSearch2.UseVisualStyleBackColor = True
        ' 
        ' txtUserInput
        ' 
        txtUserInput.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtUserInput.BackColor = Color.Silver
        txtUserInput.BorderStyle = BorderStyle.FixedSingle
        txtUserInput.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUserInput.Location = New Point(433, 7)
        txtUserInput.Margin = New Padding(3, 4, 3, 4)
        txtUserInput.Name = "txtUserInput"
        txtUserInput.Size = New Size(184, 29)
        txtUserInput.TabIndex = 5
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.ForeColor = Color.White
        btnSearch.Image = Cog_1
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch.Location = New Point(1105, 8)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(95, 32)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.TextAlign = ContentAlignment.BottomCenter
        btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' attendanceDGV
        ' 
        attendanceDGV.AllowUserToAddRows = False
        attendanceDGV.AllowUserToDeleteRows = False
        attendanceDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        attendanceDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        attendanceDGV.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        attendanceDGV.BorderStyle = BorderStyle.None
        attendanceDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        attendanceDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        attendanceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        attendanceDGV.DefaultCellStyle = DataGridViewCellStyle2
        attendanceDGV.Dock = DockStyle.Fill
        attendanceDGV.EditMode = DataGridViewEditMode.EditOnEnter
        attendanceDGV.EnableHeadersVisualStyles = False
        attendanceDGV.GridColor = Color.White
        attendanceDGV.Location = New Point(23, 48)
        attendanceDGV.Margin = New Padding(3, 4, 3, 4)
        attendanceDGV.MultiSelect = False
        attendanceDGV.Name = "attendanceDGV"
        attendanceDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.WindowFrame
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        attendanceDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        attendanceDGV.RowHeadersVisible = False
        attendanceDGV.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        attendanceDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        attendanceDGV.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        attendanceDGV.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        attendanceDGV.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9F)
        attendanceDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        attendanceDGV.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        attendanceDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        attendanceDGV.ShowCellErrors = False
        attendanceDGV.ShowRowErrors = False
        attendanceDGV.Size = New Size(691, 550)
        attendanceDGV.TabIndex = 0
        ' 
        ' txtBoxSearchInput
        ' 
        txtBoxSearchInput.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBoxSearchInput.BackColor = Color.Silver
        txtBoxSearchInput.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearchInput.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBoxSearchInput.Location = New Point(920, 8)
        txtBoxSearchInput.Margin = New Padding(3, 4, 3, 4)
        txtBoxSearchInput.Name = "txtBoxSearchInput"
        txtBoxSearchInput.Size = New Size(184, 29)
        txtBoxSearchInput.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(23, 0)
        Label2.Margin = New Padding(3, 0, 3, 13)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 7, 0, 13)
        Label2.Size = New Size(177, 48)
        Label2.TabIndex = 0
        Label2.Text = "Attendance Table"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(17, 20)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(2, 0, 0, 0)
        Label1.Size = New Size(207, 23)
        Label1.TabIndex = 2
        Label1.Text = "Members Attendace List"
        ' 
        ' ContentAttendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentAttendance"
        Padding = New Padding(17, 20, 17, 20)
        Size = New Size(771, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(attendanceDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents attendanceDGV As DataGridView
    Friend WithEvents txtBoxSearchInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents btnAddAttendance As Button

End Class
