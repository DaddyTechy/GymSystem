<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentDashboard
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        TableLayoutPanel1 = New TableLayoutPanel()
        AnnouncesBtn = New Button()
        TotEarnBtn = New Button()
        RegisteredMemBtn = New Button()
        ActiveMemBtn = New Button()
        Panel1 = New Panel()
        servicesPanel = New TableLayoutPanel()
        Label1 = New Label()
        servicesreportChart = New DataVisualization.Charting.Chart()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TableLayoutPanel1.SuspendLayout()
        servicesPanel.SuspendLayout()
        CType(servicesreportChart, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(AnnouncesBtn, 3, 0)
        TableLayoutPanel1.Controls.Add(TotEarnBtn, 2, 0)
        TableLayoutPanel1.Controls.Add(RegisteredMemBtn, 1, 0)
        TableLayoutPanel1.Controls.Add(ActiveMemBtn, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 20, 20, 0)
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(658, 140)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' AnnouncesBtn
        ' 
        AnnouncesBtn.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        AnnouncesBtn.Dock = DockStyle.Fill
        AnnouncesBtn.FlatAppearance.BorderSize = 0
        AnnouncesBtn.FlatStyle = FlatStyle.Flat
        AnnouncesBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        AnnouncesBtn.ForeColor = SystemColors.ButtonHighlight
        AnnouncesBtn.Image = My.Resources.Resources.Commercial1
        AnnouncesBtn.ImageAlign = ContentAlignment.BottomCenter
        AnnouncesBtn.Location = New Point(490, 28)
        AnnouncesBtn.Margin = New Padding(8)
        AnnouncesBtn.Name = "AnnouncesBtn"
        AnnouncesBtn.Padding = New Padding(0, 0, 0, 1)
        AnnouncesBtn.Size = New Size(140, 104)
        AnnouncesBtn.TabIndex = 3
        AnnouncesBtn.Text = "Announcements"
        AnnouncesBtn.TextAlign = ContentAlignment.BottomCenter
        AnnouncesBtn.TextImageRelation = TextImageRelation.ImageAboveText
        AnnouncesBtn.UseVisualStyleBackColor = False
        ' 
        ' TotEarnBtn
        ' 
        TotEarnBtn.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        TotEarnBtn.Dock = DockStyle.Fill
        TotEarnBtn.FlatAppearance.BorderSize = 0
        TotEarnBtn.FlatStyle = FlatStyle.Flat
        TotEarnBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TotEarnBtn.ForeColor = SystemColors.ButtonHighlight
        TotEarnBtn.Image = My.Resources.Resources.Peso_Symbol
        TotEarnBtn.ImageAlign = ContentAlignment.BottomCenter
        TotEarnBtn.Location = New Point(336, 28)
        TotEarnBtn.Margin = New Padding(8)
        TotEarnBtn.Name = "TotEarnBtn"
        TotEarnBtn.Padding = New Padding(0, 0, 0, 1)
        TotEarnBtn.Size = New Size(138, 104)
        TotEarnBtn.TabIndex = 2
        TotEarnBtn.Text = "Total Earnings"
        TotEarnBtn.TextAlign = ContentAlignment.BottomCenter
        TotEarnBtn.TextImageRelation = TextImageRelation.ImageAboveText
        TotEarnBtn.UseVisualStyleBackColor = False
        ' 
        ' RegisteredMemBtn
        ' 
        RegisteredMemBtn.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        RegisteredMemBtn.Dock = DockStyle.Fill
        RegisteredMemBtn.FlatAppearance.BorderSize = 0
        RegisteredMemBtn.FlatStyle = FlatStyle.Flat
        RegisteredMemBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        RegisteredMemBtn.ForeColor = SystemColors.ButtonHighlight
        RegisteredMemBtn.Image = My.Resources.Resources.People
        RegisteredMemBtn.ImageAlign = ContentAlignment.BottomCenter
        RegisteredMemBtn.Location = New Point(182, 28)
        RegisteredMemBtn.Margin = New Padding(8)
        RegisteredMemBtn.Name = "RegisteredMemBtn"
        RegisteredMemBtn.Padding = New Padding(0, 0, 0, 1)
        RegisteredMemBtn.Size = New Size(138, 104)
        RegisteredMemBtn.TabIndex = 1
        RegisteredMemBtn.Text = "Registered Members"
        RegisteredMemBtn.TextAlign = ContentAlignment.BottomCenter
        RegisteredMemBtn.TextImageRelation = TextImageRelation.ImageAboveText
        RegisteredMemBtn.UseVisualStyleBackColor = False
        ' 
        ' ActiveMemBtn
        ' 
        ActiveMemBtn.AutoSize = True
        ActiveMemBtn.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ActiveMemBtn.Dock = DockStyle.Fill
        ActiveMemBtn.FlatAppearance.BorderSize = 0
        ActiveMemBtn.FlatStyle = FlatStyle.Flat
        ActiveMemBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ActiveMemBtn.ForeColor = SystemColors.ButtonHighlight
        ActiveMemBtn.Image = My.Resources.Resources.Checked_User_Male1
        ActiveMemBtn.ImageAlign = ContentAlignment.BottomCenter
        ActiveMemBtn.Location = New Point(28, 28)
        ActiveMemBtn.Margin = New Padding(8)
        ActiveMemBtn.Name = "ActiveMemBtn"
        ActiveMemBtn.Padding = New Padding(0, 0, 0, 1)
        ActiveMemBtn.Size = New Size(138, 104)
        ActiveMemBtn.TabIndex = 0
        ActiveMemBtn.Text = "Active Members"
        ActiveMemBtn.TextAlign = ContentAlignment.BottomCenter
        ActiveMemBtn.TextImageRelation = TextImageRelation.ImageAboveText
        ActiveMemBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 549)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(658, 123)
        Panel1.TabIndex = 2
        ' 
        ' servicesPanel
        ' 
        servicesPanel.ColumnCount = 2
        servicesPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        servicesPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        servicesPanel.Controls.Add(Label1, 0, 0)
        servicesPanel.Controls.Add(servicesreportChart, 0, 1)
        servicesPanel.Controls.Add(TableLayoutPanel2, 1, 1)
        servicesPanel.Dock = DockStyle.Top
        servicesPanel.Location = New Point(0, 140)
        servicesPanel.Name = "servicesPanel"
        servicesPanel.Padding = New Padding(0, 15, 0, 0)
        servicesPanel.RowCount = 2
        servicesPanel.RowStyles.Add(New RowStyle())
        servicesPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        servicesPanel.Size = New Size(658, 409)
        servicesPanel.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Image = My.Resources.Resources.File
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(0, 15)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(13, 10, 0, 10)
        Label1.Size = New Size(427, 33)
        Label1.TabIndex = 8
        Label1.Text = "           | Services Report"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' servicesreportChart
        ' 
        ChartArea1.Name = "ChartArea1"
        servicesreportChart.ChartAreas.Add(ChartArea1)
        servicesreportChart.Dock = DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        servicesreportChart.Legends.Add(Legend1)
        servicesreportChart.Location = New Point(3, 51)
        servicesreportChart.Name = "servicesreportChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        servicesreportChart.Series.Add(Series1)
        servicesreportChart.Size = New Size(421, 355)
        servicesreportChart.TabIndex = 12
        servicesreportChart.Text = "Chart1"
        Title1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.Name = "Title1"
        Title1.Text = "Total"
        servicesreportChart.Titles.Add(Title1)
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Button6, 1, 2)
        TableLayoutPanel2.Controls.Add(Button5, 0, 2)
        TableLayoutPanel2.Controls.Add(Button4, 1, 1)
        TableLayoutPanel2.Controls.Add(Button3, 0, 1)
        TableLayoutPanel2.Controls.Add(Button2, 1, 0)
        TableLayoutPanel2.Controls.Add(Button1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(430, 51)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Size = New Size(225, 355)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button6.Dock = DockStyle.Fill
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Image = My.Resources.Resources.Peso_Symbol
        Button6.ImageAlign = ContentAlignment.BottomCenter
        Button6.Location = New Point(120, 244)
        Button6.Margin = New Padding(8)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(0, 0, 0, 1)
        Button6.Size = New Size(97, 103)
        Button6.TabIndex = 8
        Button6.Text = "Total Earnings"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button5.Dock = DockStyle.Fill
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Image = My.Resources.Resources.Peso_Symbol
        Button5.ImageAlign = ContentAlignment.BottomCenter
        Button5.Location = New Point(8, 244)
        Button5.Margin = New Padding(8)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(0, 0, 0, 1)
        Button5.Size = New Size(96, 103)
        Button5.TabIndex = 7
        Button5.Text = "Total Earnings"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button4.Dock = DockStyle.Fill
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Image = My.Resources.Resources.Peso_Symbol
        Button4.ImageAlign = ContentAlignment.BottomCenter
        Button4.Location = New Point(120, 126)
        Button4.Margin = New Padding(8)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(0, 0, 0, 1)
        Button4.Size = New Size(97, 102)
        Button4.TabIndex = 6
        Button4.Text = "Total Earnings"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button3.Dock = DockStyle.Fill
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Image = My.Resources.Resources.Peso_Symbol
        Button3.ImageAlign = ContentAlignment.BottomCenter
        Button3.Location = New Point(8, 126)
        Button3.Margin = New Padding(8)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(0, 0, 0, 1)
        Button3.Size = New Size(96, 102)
        Button3.TabIndex = 5
        Button3.Text = "Total Earnings"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button2.Dock = DockStyle.Fill
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = My.Resources.Resources.Peso_Symbol
        Button2.ImageAlign = ContentAlignment.BottomCenter
        Button2.Location = New Point(120, 8)
        Button2.Margin = New Padding(8)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(0, 0, 0, 1)
        Button2.Size = New Size(97, 102)
        Button2.TabIndex = 4
        Button2.Text = "Total Earnings"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button1.Dock = DockStyle.Fill
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Image = My.Resources.Resources.Peso_Symbol
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(8, 8)
        Button1.Margin = New Padding(8)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(0, 0, 0, 1)
        Button1.Size = New Size(96, 102)
        Button1.TabIndex = 3
        Button1.Text = "Total Earnings"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ContentDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Transparent
        Controls.Add(servicesPanel)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentDashboard"
        Size = New Size(658, 496)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        servicesPanel.ResumeLayout(False)
        servicesPanel.PerformLayout()
        CType(servicesreportChart, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ActiveMemBtn As Button
    Friend WithEvents AnnouncesBtn As Button
    Friend WithEvents TotEarnBtn As Button
    Friend WithEvents RegisteredMemBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents servicesPanel As TableLayoutPanel
    Friend WithEvents servicesreportChart As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
