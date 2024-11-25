<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberProfileControl
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblMemberName = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label7 = New Label()
        lbldtcreated = New Label()
        lblStatus = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblWeightHeight = New Label()
        Label14 = New Label()
        lblEmail = New Label()
        Label12 = New Label()
        lblContactNo = New Label()
        Label10 = New Label()
        lbldob = New Label()
        Label8 = New Label()
        TableLayoutPanel9 = New TableLayoutPanel()
        lblUserHandle = New Label()
        lblUserName = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel3 = New Panel()
        TableLayoutPanel8 = New TableLayoutPanel()
        lblEndDate = New Label()
        lblRenewalPolicy = New Label()
        Label19 = New Label()
        lblPlanCost = New Label()
        lblPlanAccess = New Label()
        lblPlanStartDate = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Panel4 = New Panel()
        lblPlanType = New Label()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label9 = New Label()
        Label11 = New Label()
        servicesreportChart = New DataVisualization.Charting.Chart()
        Panel2 = New Panel()
        TableLayoutPanel6 = New TableLayoutPanel()
        btnAddNotes = New Label()
        Label2 = New Label()
        textBoxForNotes = New RichTextBox()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        CType(servicesreportChart, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 155F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 81F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 21F))
        TableLayoutPanel1.Controls.Add(lblMemberName, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(15, 15)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(746, 19)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblMemberName
        ' 
        lblMemberName.AutoSize = True
        lblMemberName.Dock = DockStyle.Left
        lblMemberName.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMemberName.ForeColor = Color.Yellow
        lblMemberName.Location = New Point(158, 0)
        lblMemberName.Name = "lblMemberName"
        lblMemberName.Size = New Size(69, 19)
        lblMemberName.TabIndex = 7
        lblMemberName.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Margin = New Padding(3, 0, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 19)
        Label1.TabIndex = 6
        Label1.Text = "Registered Members  >"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(15, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(321, 594)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Label7, 0, 5)
        TableLayoutPanel3.Controls.Add(lbldtcreated, 0, 3)
        TableLayoutPanel3.Controls.Add(lblStatus, 0, 1)
        TableLayoutPanel3.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 4)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel5, 0, 6)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel9, 0, 2)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(10, 60, 10, 0)
        TableLayoutPanel3.RowCount = 7
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 84F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 23F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 65F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(321, 594)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(13, 368)
        Label7.Margin = New Padding(3, 0, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(298, 21)
        Label7.TabIndex = 6
        Label7.Text = "Personal Info"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbldtcreated
        ' 
        lbldtcreated.AutoSize = True
        lbldtcreated.Dock = DockStyle.Fill
        lbldtcreated.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldtcreated.ForeColor = Color.White
        lbldtcreated.Location = New Point(13, 232)
        lbldtcreated.Margin = New Padding(3, 0, 0, 0)
        lbldtcreated.Name = "lbldtcreated"
        lbldtcreated.Size = New Size(298, 36)
        lbldtcreated.TabIndex = 4
        lbldtcreated.Text = "Member Since: 00/00/00"
        lbldtcreated.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Gold
        lblStatus.Location = New Point(13, 144)
        lblStatus.Margin = New Padding(3, 0, 0, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(298, 23)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Active"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Personal_Trainer
        PictureBox1.Location = New Point(13, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(295, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Controls.Add(Label6, 2, 0)
        TableLayoutPanel4.Controls.Add(Label5, 1, 0)
        TableLayoutPanel4.Controls.Add(Label4, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(13, 271)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(295, 94)
        TableLayoutPanel4.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Image = My.Resources.Resources.Cog_1
        Label6.ImageAlign = ContentAlignment.TopCenter
        Label6.Location = New Point(199, 0)
        Label6.Margin = New Padding(3, 0, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 94)
        Label6.TabIndex = 7
        Label6.Text = "Card"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Image = My.Resources.Resources.Cog_1
        Label5.ImageAlign = ContentAlignment.TopCenter
        Label5.Location = New Point(101, 0)
        Label5.Margin = New Padding(3, 0, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 94)
        Label5.TabIndex = 6
        Label5.Text = "Email"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Image = My.Resources.Resources.Cog_1
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(3, 0)
        Label4.Margin = New Padding(3, 0, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 94)
        Label4.TabIndex = 5
        Label4.Text = "Call"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.64407F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 61.35593F))
        TableLayoutPanel5.Controls.Add(lblWeightHeight, 1, 3)
        TableLayoutPanel5.Controls.Add(Label14, 0, 3)
        TableLayoutPanel5.Controls.Add(lblEmail, 1, 2)
        TableLayoutPanel5.Controls.Add(Label12, 0, 2)
        TableLayoutPanel5.Controls.Add(lblContactNo, 1, 1)
        TableLayoutPanel5.Controls.Add(Label10, 0, 1)
        TableLayoutPanel5.Controls.Add(lbldob, 1, 0)
        TableLayoutPanel5.Controls.Add(Label8, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Top
        TableLayoutPanel5.Location = New Point(13, 392)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 4
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.Size = New Size(295, 195)
        TableLayoutPanel5.TabIndex = 7
        ' 
        ' lblWeightHeight
        ' 
        lblWeightHeight.AutoSize = True
        lblWeightHeight.Dock = DockStyle.Fill
        lblWeightHeight.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblWeightHeight.ForeColor = Color.White
        lblWeightHeight.Location = New Point(117, 144)
        lblWeightHeight.Margin = New Padding(3, 0, 0, 0)
        lblWeightHeight.Name = "lblWeightHeight"
        lblWeightHeight.Size = New Size(178, 51)
        lblWeightHeight.TabIndex = 14
        lblWeightHeight.Text = "Personal Info"
        lblWeightHeight.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Fill
        Label14.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(3, 144)
        Label14.Margin = New Padding(3, 0, 0, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 51)
        Label14.TabIndex = 13
        Label14.Text = "Weight and Height"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Dock = DockStyle.Fill
        lblEmail.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(117, 96)
        lblEmail.Margin = New Padding(3, 0, 0, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(178, 48)
        lblEmail.TabIndex = 12
        lblEmail.Text = "Personal Info"
        lblEmail.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Fill
        Label12.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(3, 96)
        Label12.Margin = New Padding(3, 0, 0, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 48)
        Label12.TabIndex = 11
        Label12.Text = "Email Address"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Dock = DockStyle.Fill
        lblContactNo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblContactNo.ForeColor = Color.White
        lblContactNo.Location = New Point(117, 48)
        lblContactNo.Margin = New Padding(3, 0, 0, 0)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(178, 48)
        lblContactNo.TabIndex = 10
        lblContactNo.Text = "Personal Info"
        lblContactNo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(3, 48)
        Label10.Margin = New Padding(3, 0, 0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 48)
        Label10.TabIndex = 9
        Label10.Text = "Contact Number"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbldob
        ' 
        lbldob.AutoSize = True
        lbldob.Dock = DockStyle.Fill
        lbldob.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lbldob.ForeColor = Color.White
        lbldob.Location = New Point(117, 0)
        lbldob.Margin = New Padding(3, 0, 0, 0)
        lbldob.Name = "lbldob"
        lbldob.Size = New Size(178, 48)
        lbldob.TabIndex = 8
        lbldob.Text = "Personal Info"
        lbldob.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(3, 0)
        Label8.Margin = New Padding(3, 0, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 48)
        Label8.TabIndex = 7
        Label8.Text = "Birthday"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 1
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Controls.Add(lblUserHandle, 0, 1)
        TableLayoutPanel9.Controls.Add(lblUserName, 0, 0)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(13, 170)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50.84746F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 49.1525421F))
        TableLayoutPanel9.Size = New Size(295, 59)
        TableLayoutPanel9.TabIndex = 8
        ' 
        ' lblUserHandle
        ' 
        lblUserHandle.AutoSize = True
        lblUserHandle.Dock = DockStyle.Top
        lblUserHandle.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        lblUserHandle.ForeColor = Color.White
        lblUserHandle.Location = New Point(3, 30)
        lblUserHandle.Margin = New Padding(3, 0, 0, 0)
        lblUserHandle.Name = "lblUserHandle"
        lblUserHandle.Size = New Size(292, 21)
        lblUserHandle.TabIndex = 10
        lblUserHandle.Text = "@000"
        lblUserHandle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Dock = DockStyle.Top
        lblUserName.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold)
        lblUserName.ForeColor = Color.White
        lblUserName.Location = New Point(3, 0)
        lblUserName.Margin = New Padding(3, 0, 0, 0)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(292, 30)
        lblUserName.TabIndex = 9
        lblUserName.Text = "User Name"
        lblUserName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Panel3, 0, 2)
        TableLayoutPanel2.Controls.Add(servicesreportChart, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(336, 34)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(10, 10, 10, 0)
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 29.4425087F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 37.28223F))
        TableLayoutPanel2.Size = New Size(425, 594)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.AutoSize = True
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(TableLayoutPanel8)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(TableLayoutPanel7)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(13, 385)
        Panel3.Margin = New Padding(3, 10, 3, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 10, 20, 10)
        Panel3.Size = New Size(399, 206)
        Panel3.TabIndex = 14
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.Black
        TableLayoutPanel8.ColumnCount = 5
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.1740417F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.81416F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.7640114F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.7492628F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.4985256F))
        TableLayoutPanel8.Controls.Add(lblEndDate, 1, 1)
        TableLayoutPanel8.Controls.Add(lblRenewalPolicy, 4, 1)
        TableLayoutPanel8.Controls.Add(Label19, 4, 0)
        TableLayoutPanel8.Controls.Add(lblPlanCost, 3, 1)
        TableLayoutPanel8.Controls.Add(lblPlanAccess, 2, 1)
        TableLayoutPanel8.Controls.Add(lblPlanStartDate, 0, 1)
        TableLayoutPanel8.Controls.Add(Label18, 3, 0)
        TableLayoutPanel8.Controls.Add(Label17, 2, 0)
        TableLayoutPanel8.Controls.Add(Label16, 1, 0)
        TableLayoutPanel8.Controls.Add(Label15, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(20, 91)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.Padding = New Padding(10, 15, 10, 20)
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(359, 105)
        TableLayoutPanel8.TabIndex = 6
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Dock = DockStyle.Fill
        lblEndDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblEndDate.ForeColor = Color.White
        lblEndDate.Location = New Point(78, 50)
        lblEndDate.Margin = New Padding(3, 0, 0, 0)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(54, 35)
        lblEndDate.TabIndex = 19
        lblEndDate.Text = "Info"
        ' 
        ' lblRenewalPolicy
        ' 
        lblRenewalPolicy.AutoSize = True
        lblRenewalPolicy.Dock = DockStyle.Fill
        lblRenewalPolicy.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRenewalPolicy.ForeColor = Color.White
        lblRenewalPolicy.Location = New Point(252, 50)
        lblRenewalPolicy.Margin = New Padding(3, 0, 0, 0)
        lblRenewalPolicy.Name = "lblRenewalPolicy"
        lblRenewalPolicy.Size = New Size(97, 35)
        lblRenewalPolicy.TabIndex = 18
        lblRenewalPolicy.Text = "Info"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label19.ForeColor = Color.White
        Label19.Location = New Point(252, 15)
        Label19.Margin = New Padding(3, 0, 0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(97, 35)
        Label19.TabIndex = 17
        Label19.Text = "Renewal Policy"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPlanCost
        ' 
        lblPlanCost.AutoSize = True
        lblPlanCost.Dock = DockStyle.Fill
        lblPlanCost.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanCost.ForeColor = Color.White
        lblPlanCost.Location = New Point(202, 50)
        lblPlanCost.Margin = New Padding(3, 0, 0, 0)
        lblPlanCost.Name = "lblPlanCost"
        lblPlanCost.Size = New Size(47, 35)
        lblPlanCost.TabIndex = 15
        lblPlanCost.Text = "Info"
        ' 
        ' lblPlanAccess
        ' 
        lblPlanAccess.AutoSize = True
        lblPlanAccess.Dock = DockStyle.Fill
        lblPlanAccess.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanAccess.ForeColor = Color.White
        lblPlanAccess.Location = New Point(135, 50)
        lblPlanAccess.Margin = New Padding(3, 0, 0, 0)
        lblPlanAccess.Name = "lblPlanAccess"
        lblPlanAccess.Size = New Size(64, 35)
        lblPlanAccess.TabIndex = 14
        lblPlanAccess.Text = "Info"
        ' 
        ' lblPlanStartDate
        ' 
        lblPlanStartDate.AutoSize = True
        lblPlanStartDate.Dock = DockStyle.Fill
        lblPlanStartDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanStartDate.ForeColor = Color.White
        lblPlanStartDate.Location = New Point(13, 50)
        lblPlanStartDate.Margin = New Padding(3, 0, 0, 0)
        lblPlanStartDate.Name = "lblPlanStartDate"
        lblPlanStartDate.Size = New Size(62, 35)
        lblPlanStartDate.TabIndex = 12
        lblPlanStartDate.Text = "Info"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label18.ForeColor = Color.White
        Label18.Location = New Point(202, 15)
        Label18.Margin = New Padding(3, 0, 0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(47, 35)
        Label18.TabIndex = 11
        Label18.Text = "Cost"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label17.ForeColor = Color.White
        Label17.Location = New Point(135, 15)
        Label17.Margin = New Padding(3, 0, 0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 35)
        Label17.TabIndex = 10
        Label17.Text = "Benefits"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Fill
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(78, 15)
        Label16.Margin = New Padding(3, 0, 0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(54, 35)
        Label16.TabIndex = 9
        Label16.Text = "End Date"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Fill
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(13, 15)
        Label15.Margin = New Padding(3, 0, 0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(62, 35)
        Label15.TabIndex = 8
        Label15.Text = "Start Date"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Controls.Add(lblPlanType)
        Panel4.Dock = DockStyle.Top
        Panel4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(20, 42)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10)
        Panel4.Size = New Size(359, 49)
        Panel4.TabIndex = 5
        ' 
        ' lblPlanType
        ' 
        lblPlanType.AutoSize = True
        lblPlanType.Dock = DockStyle.Fill
        lblPlanType.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold)
        lblPlanType.ForeColor = Color.White
        lblPlanType.Location = New Point(10, 10)
        lblPlanType.Margin = New Padding(3, 0, 0, 0)
        lblPlanType.Name = "lblPlanType"
        lblPlanType.Size = New Size(266, 32)
        lblPlanType.TabIndex = 4
        lblPlanType.Text = "JJ Fitness Plan - Type"
        lblPlanType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 158F))
        TableLayoutPanel7.Controls.Add(Label9, 1, 0)
        TableLayoutPanel7.Controls.Add(Label11, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Top
        TableLayoutPanel7.Location = New Point(20, 10)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.Padding = New Padding(0, 0, 0, 5)
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(359, 32)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Black
        Label9.Dock = DockStyle.Fill
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Gold
        Label9.ImageAlign = ContentAlignment.MiddleLeft
        Label9.Location = New Point(204, 0)
        Label9.Margin = New Padding(3, 0, 0, 0)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(1)
        Label9.Size = New Size(155, 27)
        Label9.TabIndex = 5
        Label9.Text = "Update Membership"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(3, 0)
        Label11.Margin = New Padding(3, 0, 0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(198, 27)
        Label11.TabIndex = 4
        Label11.Text = "Memberships"
        Label11.TextAlign = ContentAlignment.MiddleLeft
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
        servicesreportChart.Location = New Point(13, 13)
        servicesreportChart.Name = "servicesreportChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = Color.Gold
        Series1.LabelForeColor = Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        servicesreportChart.Series.Add(Series1)
        servicesreportChart.Size = New Size(399, 188)
        servicesreportChart.TabIndex = 13
        servicesreportChart.Text = "Chart1"
        Title1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.ForeColor = Color.White
        Title1.Name = "Title1"
        Title1.Text = "Total"
        servicesreportChart.Titles.Add(Title1)
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.AutoSize = True
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(TableLayoutPanel6)
        Panel2.Controls.Add(textBoxForNotes)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(13, 207)
        Panel2.Margin = New Padding(3, 3, 3, 10)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20, 10, 20, 10)
        Panel2.Size = New Size(399, 158)
        Panel2.TabIndex = 2
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 89F))
        TableLayoutPanel6.Controls.Add(btnAddNotes, 1, 0)
        TableLayoutPanel6.Controls.Add(Label2, 0, 0)
        TableLayoutPanel6.Dock = DockStyle.Top
        TableLayoutPanel6.Location = New Point(20, 10)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.Padding = New Padding(0, 0, 0, 5)
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(359, 32)
        TableLayoutPanel6.TabIndex = 4
        ' 
        ' btnAddNotes
        ' 
        btnAddNotes.AutoSize = True
        btnAddNotes.BackColor = Color.Black
        btnAddNotes.Dock = DockStyle.Fill
        btnAddNotes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddNotes.ForeColor = Color.Gold
        btnAddNotes.ImageAlign = ContentAlignment.MiddleLeft
        btnAddNotes.Location = New Point(273, 0)
        btnAddNotes.Margin = New Padding(3, 0, 0, 0)
        btnAddNotes.Name = "btnAddNotes"
        btnAddNotes.Padding = New Padding(1)
        btnAddNotes.Size = New Size(86, 27)
        btnAddNotes.TabIndex = 5
        btnAddNotes.Text = "Add Notes"
        btnAddNotes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(3, 0)
        Label2.Margin = New Padding(3, 0, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(267, 27)
        Label2.TabIndex = 4
        Label2.Text = "Notes"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' textBoxForNotes
        ' 
        textBoxForNotes.BackColor = Color.Black
        textBoxForNotes.BorderStyle = BorderStyle.None
        textBoxForNotes.Dock = DockStyle.Fill
        textBoxForNotes.ForeColor = SystemColors.Window
        textBoxForNotes.Location = New Point(20, 10)
        textBoxForNotes.Name = "textBoxForNotes"
        textBoxForNotes.ReadOnly = True
        textBoxForNotes.ScrollBars = RichTextBoxScrollBars.Vertical
        textBoxForNotes.Size = New Size(359, 138)
        textBoxForNotes.TabIndex = 3
        textBoxForNotes.Text = ""
        ' 
        ' memberProfileControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Transparent
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(675, 496)
        Name = "memberProfileControl"
        Padding = New Padding(15)
        Size = New Size(776, 643)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel3.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        CType(servicesreportChart, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblMemberName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbldtcreated As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblWeightHeight As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents textBoxForNotes As RichTextBox
    Friend WithEvents servicesreportChart As DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnAddNotes As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPlanType As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPlanAccess As Label
    Friend WithEvents lblPlanCost As Label
    Friend WithEvents lblPlanStartDate As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblRenewalPolicy As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lblUserHandle As Label
    Friend WithEvents lblUserName As Label

End Class
