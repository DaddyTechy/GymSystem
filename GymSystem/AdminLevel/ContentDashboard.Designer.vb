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
        Panel6 = New Panel()
        PictureBox6 = New PictureBox()
        Label7 = New Label()
        dashbrdPMdata = New Label()
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        Label5 = New Label()
        dashbrdACTdata = New Label()
        Panel4 = New Panel()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        dashbrdTEdata = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        dashbrdAEdata = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        dashbrdSUdata = New Label()
        dashbrdData1 = New Panel()
        PictureBox1 = New PictureBox()
        dashbrdTM = New Label()
        dashbrdTMData = New Label()
        TableLayoutPanel1.SuspendLayout()
        servicesPanel.SuspendLayout()
        CType(servicesreportChart, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        dashbrdData1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        servicesPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54.103344F))
        servicesPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.896656F))
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
        Label1.Size = New Size(356, 33)
        Label1.TabIndex = 8
        Label1.Text = "           | Services Report"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' servicesreportChart
        ' 
        servicesreportChart.BackColor = Color.Transparent
        ChartArea1.AxisX.LabelStyle.ForeColor = Color.White
        ChartArea1.AxisX.LineColor = Color.White
        ChartArea1.AxisX.MajorGrid.LineColor = Color.Transparent
        ChartArea1.AxisX.MajorTickMark.Enabled = False
        ChartArea1.AxisX.MajorTickMark.LineColor = Color.Transparent
        ChartArea1.AxisX.MinorGrid.LineColor = Color.White
        ChartArea1.AxisX.TitleForeColor = Color.White
        ChartArea1.AxisX2.LabelStyle.ForeColor = Color.White
        ChartArea1.AxisX2.LineColor = Color.White
        ChartArea1.AxisX2.MinorTickMark.Enabled = True
        ChartArea1.AxisX2.MinorTickMark.LineColor = Color.White
        ChartArea1.AxisY.LabelStyle.ForeColor = Color.White
        ChartArea1.AxisY.LineColor = Color.Transparent
        ChartArea1.AxisY.MajorGrid.LineColor = Color.White
        ChartArea1.AxisY.MajorTickMark.LineColor = Color.White
        ChartArea1.AxisY2.LabelStyle.ForeColor = Color.White
        ChartArea1.AxisY2.LineColor = Color.White
        ChartArea1.AxisY2.MajorGrid.LineColor = Color.White
        ChartArea1.AxisY2.TitleForeColor = Color.White
        ChartArea1.BackColor = Color.Transparent
        ChartArea1.Name = "ChartArea1"
        servicesreportChart.ChartAreas.Add(ChartArea1)
        servicesreportChart.Dock = DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        servicesreportChart.Legends.Add(Legend1)
        servicesreportChart.Location = New Point(3, 51)
        servicesreportChart.Name = "servicesreportChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = Color.Gold
        Series1.LabelForeColor = Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        servicesreportChart.Series.Add(Series1)
        servicesreportChart.Size = New Size(350, 355)
        servicesreportChart.TabIndex = 12
        servicesreportChart.Text = "Chart1"
        Title1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.ForeColor = Color.White
        Title1.Name = "Title1"
        Title1.Text = "Total"
        servicesreportChart.Titles.Add(Title1)
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Panel6, 1, 2)
        TableLayoutPanel2.Controls.Add(Panel5, 0, 2)
        TableLayoutPanel2.Controls.Add(Panel4, 1, 1)
        TableLayoutPanel2.Controls.Add(Panel3, 0, 1)
        TableLayoutPanel2.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel2.Controls.Add(dashbrdData1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(359, 51)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(10, 0, 20, 0)
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Size = New Size(296, 355)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(dashbrdPMdata)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(148, 241)
        Panel6.Margin = New Padding(5, 5, 3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(125, 111)
        Panel6.TabIndex = 5
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Dock = DockStyle.Top
        PictureBox6.Image = My.Resources.Resources.Checked_User_Male2
        PictureBox6.Location = New Point(0, 0)
        PictureBox6.Margin = New Padding(0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(125, 49)
        PictureBox6.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(0, 81)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(5, 0, 0, 0)
        Label7.Size = New Size(120, 17)
        Label7.TabIndex = 2
        Label7.Text = "Present Members"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdPMdata
        ' 
        dashbrdPMdata.Anchor = AnchorStyles.None
        dashbrdPMdata.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashbrdPMdata.ForeColor = SystemColors.ControlLightLight
        dashbrdPMdata.ImageAlign = ContentAlignment.MiddleRight
        dashbrdPMdata.Location = New Point(2, 37)
        dashbrdPMdata.Name = "dashbrdPMdata"
        dashbrdPMdata.Size = New Size(120, 44)
        dashbrdPMdata.TabIndex = 1
        dashbrdPMdata.Text = "0"
        dashbrdPMdata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(dashbrdACTdata)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(13, 241)
        Panel5.Margin = New Padding(3, 5, 5, 3)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(0, 3, 0, 0)
        Panel5.Size = New Size(125, 111)
        Panel5.TabIndex = 4
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Dock = DockStyle.Top
        PictureBox5.Image = My.Resources.Resources.Personal_Trainer
        PictureBox5.Location = New Point(0, 3)
        PictureBox5.Margin = New Padding(0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(125, 44)
        PictureBox5.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(25, 76)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(5, 0, 0, 0)
        Label5.Size = New Size(73, 30)
        Label5.TabIndex = 2
        Label5.Text = "Active Gym" & vbCrLf & "Trainers"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdACTdata
        ' 
        dashbrdACTdata.Anchor = AnchorStyles.None
        dashbrdACTdata.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        dashbrdACTdata.ForeColor = SystemColors.ControlLightLight
        dashbrdACTdata.Location = New Point(2, 37)
        dashbrdACTdata.Name = "dashbrdACTdata"
        dashbrdACTdata.Padding = New Padding(3, 0, 0, 0)
        dashbrdACTdata.Size = New Size(120, 44)
        dashbrdACTdata.TabIndex = 1
        dashbrdACTdata.Text = "0"
        dashbrdACTdata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(dashbrdTEdata)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(148, 123)
        Panel4.Margin = New Padding(5, 5, 3, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(125, 108)
        Panel4.TabIndex = 3
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Dock = DockStyle.Top
        PictureBox4.Image = My.Resources.Resources.Peso_Symbol1
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 47)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(11, 81)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(5, 0, 0, 0)
        Label4.Size = New Size(102, 17)
        Label4.TabIndex = 2
        Label4.Text = "Total Expenses"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdTEdata
        ' 
        dashbrdTEdata.Anchor = AnchorStyles.None
        dashbrdTEdata.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashbrdTEdata.ForeColor = SystemColors.ControlLightLight
        dashbrdTEdata.ImageAlign = ContentAlignment.MiddleRight
        dashbrdTEdata.Location = New Point(2, 35)
        dashbrdTEdata.Name = "dashbrdTEdata"
        dashbrdTEdata.Size = New Size(120, 44)
        dashbrdTEdata.TabIndex = 1
        dashbrdTEdata.Text = "0"
        dashbrdTEdata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(dashbrdAEdata)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(13, 123)
        Panel3.Margin = New Padding(3, 5, 5, 5)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 3, 0, 0)
        Panel3.Size = New Size(125, 108)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Top
        PictureBox3.Image = My.Resources.Resources.Dumbbell
        PictureBox3.Location = New Point(0, 3)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(25, 75)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5, 0, 0, 0)
        Label3.Size = New Size(75, 30)
        Label3.TabIndex = 2
        Label3.Text = "Available " & vbCrLf & "Equipments"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdAEdata
        ' 
        dashbrdAEdata.Anchor = AnchorStyles.None
        dashbrdAEdata.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        dashbrdAEdata.ForeColor = SystemColors.ControlLightLight
        dashbrdAEdata.Location = New Point(2, 35)
        dashbrdAEdata.Name = "dashbrdAEdata"
        dashbrdAEdata.Padding = New Padding(3, 0, 0, 0)
        dashbrdAEdata.Size = New Size(120, 44)
        dashbrdAEdata.TabIndex = 1
        dashbrdAEdata.Text = "0"
        dashbrdAEdata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(dashbrdSUdata)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(148, 3)
        Panel2.Margin = New Padding(5, 3, 3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(125, 112)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Top
        PictureBox2.Image = My.Resources.Resources.Badge
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(22, 88)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5, 0, 0, 0)
        Label2.Size = New Size(77, 17)
        Label2.TabIndex = 2
        Label2.Text = "Staff Users"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdSUdata
        ' 
        dashbrdSUdata.Anchor = AnchorStyles.None
        dashbrdSUdata.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashbrdSUdata.ForeColor = SystemColors.ControlLightLight
        dashbrdSUdata.ImageAlign = ContentAlignment.MiddleRight
        dashbrdSUdata.Location = New Point(2, 40)
        dashbrdSUdata.Name = "dashbrdSUdata"
        dashbrdSUdata.Size = New Size(120, 45)
        dashbrdSUdata.TabIndex = 1
        dashbrdSUdata.Text = "0"
        dashbrdSUdata.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdData1
        ' 
        dashbrdData1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        dashbrdData1.Controls.Add(PictureBox1)
        dashbrdData1.Controls.Add(dashbrdTM)
        dashbrdData1.Controls.Add(dashbrdTMData)
        dashbrdData1.Dock = DockStyle.Fill
        dashbrdData1.Location = New Point(13, 3)
        dashbrdData1.Margin = New Padding(3, 3, 5, 5)
        dashbrdData1.Name = "dashbrdData1"
        dashbrdData1.Size = New Size(125, 110)
        dashbrdData1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.People4
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dashbrdTM
        ' 
        dashbrdTM.Anchor = AnchorStyles.None
        dashbrdTM.AutoSize = True
        dashbrdTM.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        dashbrdTM.ForeColor = SystemColors.ButtonHighlight
        dashbrdTM.Location = New Point(10, 87)
        dashbrdTM.Name = "dashbrdTM"
        dashbrdTM.Padding = New Padding(5, 0, 0, 0)
        dashbrdTM.Size = New Size(103, 17)
        dashbrdTM.TabIndex = 2
        dashbrdTM.Text = "Total Members"
        dashbrdTM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashbrdTMData
        ' 
        dashbrdTMData.Anchor = AnchorStyles.None
        dashbrdTMData.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashbrdTMData.ForeColor = SystemColors.ControlLightLight
        dashbrdTMData.ImageAlign = ContentAlignment.MiddleRight
        dashbrdTMData.Location = New Point(2, 39)
        dashbrdTMData.Name = "dashbrdTMData"
        dashbrdTMData.Size = New Size(120, 45)
        dashbrdTMData.TabIndex = 1
        dashbrdTMData.Text = "0"
        dashbrdTMData.TextAlign = ContentAlignment.MiddleCenter
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
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        dashbrdData1.ResumeLayout(False)
        dashbrdData1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dashbrdData1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashbrdTM As Label
    Friend WithEvents dashbrdTMData As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dashbrdSUdata As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dashbrdAEdata As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dashbrdTEdata As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dashbrdACTdata As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dashbrdPMdata As Label

End Class
