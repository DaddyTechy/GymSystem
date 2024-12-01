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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnAddAttendanceFromPF = New Button()
        Panel2 = New Panel()
        notesDGV = New DataGridView()
        TableLayoutPanel6 = New TableLayoutPanel()
        btnAddNotes = New Label()
        Label2 = New Label()
        chartAttendance = New DataVisualization.Charting.Chart()
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
        Panel5 = New Panel()
        reservationsDGV = New DataGridView()
        TableLayoutPanel10 = New TableLayoutPanel()
        btnAddReservation = New Label()
        Label13 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        Panel2.SuspendLayout()
        CType(notesDGV, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel6.SuspendLayout()
        CType(chartAttendance, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        Panel5.SuspendLayout()
        CType(reservationsDGV, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
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
        TableLayoutPanel1.Size = New Size(749, 19)
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
        Panel1.Size = New Size(277, 1536)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Label7, 0, 6)
        TableLayoutPanel3.Controls.Add(lbldtcreated, 0, 3)
        TableLayoutPanel3.Controls.Add(lblStatus, 0, 1)
        TableLayoutPanel3.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 5)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel5, 0, 7)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel9, 0, 2)
        TableLayoutPanel3.Controls.Add(btnAddAttendanceFromPF, 0, 4)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(10, 60, 10, 0)
        TableLayoutPanel3.RowCount = 8
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 84F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 23F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 65F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 98F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 152F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 17F))
        TableLayoutPanel3.Size = New Size(277, 1536)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(13, 426)
        Label7.Margin = New Padding(3, 0, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(254, 25)
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
        lbldtcreated.Size = New Size(254, 36)
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
        lblStatus.Size = New Size(254, 23)
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
        PictureBox1.Size = New Size(251, 78)
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
        TableLayoutPanel4.Location = New Point(13, 331)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(251, 92)
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
        Label6.Location = New Point(169, 0)
        Label6.Margin = New Padding(3, 0, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 92)
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
        Label5.Location = New Point(86, 0)
        Label5.Margin = New Padding(3, 0, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 92)
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
        Label4.Size = New Size(80, 92)
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
        TableLayoutPanel5.Location = New Point(13, 454)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 4
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.Size = New Size(251, 195)
        TableLayoutPanel5.TabIndex = 7
        ' 
        ' lblWeightHeight
        ' 
        lblWeightHeight.AutoSize = True
        lblWeightHeight.Dock = DockStyle.Fill
        lblWeightHeight.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblWeightHeight.ForeColor = Color.White
        lblWeightHeight.Location = New Point(99, 144)
        lblWeightHeight.Margin = New Padding(3, 0, 0, 0)
        lblWeightHeight.Name = "lblWeightHeight"
        lblWeightHeight.Size = New Size(152, 51)
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
        Label14.Size = New Size(93, 51)
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
        lblEmail.Location = New Point(99, 96)
        lblEmail.Margin = New Padding(3, 0, 0, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(152, 48)
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
        Label12.Size = New Size(93, 48)
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
        lblContactNo.Location = New Point(99, 48)
        lblContactNo.Margin = New Padding(3, 0, 0, 0)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(152, 48)
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
        Label10.Size = New Size(93, 48)
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
        lbldob.Location = New Point(99, 0)
        lbldob.Margin = New Padding(3, 0, 0, 0)
        lbldob.Name = "lbldob"
        lbldob.Size = New Size(152, 48)
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
        Label8.Size = New Size(93, 48)
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
        TableLayoutPanel9.Size = New Size(251, 59)
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
        lblUserHandle.Size = New Size(248, 21)
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
        lblUserName.Size = New Size(248, 30)
        lblUserName.TabIndex = 9
        lblUserName.Text = "User Name"
        lblUserName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAddAttendanceFromPF
        ' 
        btnAddAttendanceFromPF.Anchor = AnchorStyles.None
        btnAddAttendanceFromPF.FlatStyle = FlatStyle.Popup
        btnAddAttendanceFromPF.ForeColor = Color.White
        btnAddAttendanceFromPF.Image = My.Resources.Resources.edit
        btnAddAttendanceFromPF.ImageAlign = ContentAlignment.MiddleRight
        btnAddAttendanceFromPF.Location = New Point(77, 273)
        btnAddAttendanceFromPF.Name = "btnAddAttendanceFromPF"
        btnAddAttendanceFromPF.Size = New Size(122, 49)
        btnAddAttendanceFromPF.TabIndex = 12
        btnAddAttendanceFromPF.Text = "Attendance"
        btnAddAttendanceFromPF.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAddAttendanceFromPF.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(notesDGV)
        Panel2.Controls.Add(TableLayoutPanel6)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(13, 283)
        Panel2.Margin = New Padding(3, 10, 3, 3)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20, 10, 20, 10)
        Panel2.Size = New Size(446, 220)
        Panel2.TabIndex = 15
        ' 
        ' notesDGV
        ' 
        notesDGV.AllowUserToAddRows = False
        notesDGV.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        notesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Transparent
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        notesDGV.DefaultCellStyle = DataGridViewCellStyle1
        notesDGV.Dock = DockStyle.Fill
        notesDGV.GridColor = Color.White
        notesDGV.Location = New Point(20, 42)
        notesDGV.Name = "notesDGV"
        notesDGV.ReadOnly = True
        notesDGV.Size = New Size(406, 168)
        notesDGV.TabIndex = 9
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.Transparent
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
        TableLayoutPanel6.Size = New Size(406, 32)
        TableLayoutPanel6.TabIndex = 8
        ' 
        ' btnAddNotes
        ' 
        btnAddNotes.AutoSize = True
        btnAddNotes.BackColor = Color.Black
        btnAddNotes.Dock = DockStyle.Fill
        btnAddNotes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddNotes.ForeColor = Color.Gold
        btnAddNotes.ImageAlign = ContentAlignment.MiddleLeft
        btnAddNotes.Location = New Point(320, 0)
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
        Label2.Size = New Size(314, 27)
        Label2.TabIndex = 4
        Label2.Text = "Notes"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' chartAttendance
        ' 
        chartAttendance.BackColor = Color.Transparent
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
        chartAttendance.ChartAreas.Add(ChartArea1)
        chartAttendance.Dock = DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        chartAttendance.Legends.Add(Legend1)
        chartAttendance.Location = New Point(13, 13)
        chartAttendance.Name = "chartAttendance"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = Color.Gold
        Series1.LabelForeColor = Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        chartAttendance.Series.Add(Series1)
        chartAttendance.Size = New Size(446, 257)
        chartAttendance.TabIndex = 13
        chartAttendance.Text = "Chart1"
        Title1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.ForeColor = Color.White
        Title1.Name = "Title1"
        Title1.Text = "Total"
        chartAttendance.Titles.Add(Title1)
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
        Panel3.Location = New Point(13, 516)
        Panel3.Margin = New Padding(3, 10, 3, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 10, 20, 10)
        Panel3.Size = New Size(446, 282)
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
        TableLayoutPanel8.Size = New Size(406, 181)
        TableLayoutPanel8.TabIndex = 6
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Dock = DockStyle.Fill
        lblEndDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblEndDate.ForeColor = Color.White
        lblEndDate.Location = New Point(87, 88)
        lblEndDate.Margin = New Padding(3, 0, 0, 0)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(61, 73)
        lblEndDate.TabIndex = 19
        lblEndDate.Text = "Info"
        lblEndDate.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblRenewalPolicy
        ' 
        lblRenewalPolicy.AutoSize = True
        lblRenewalPolicy.Dock = DockStyle.Fill
        lblRenewalPolicy.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRenewalPolicy.ForeColor = Color.White
        lblRenewalPolicy.Location = New Point(283, 88)
        lblRenewalPolicy.Margin = New Padding(3, 0, 0, 0)
        lblRenewalPolicy.Name = "lblRenewalPolicy"
        lblRenewalPolicy.Size = New Size(113, 73)
        lblRenewalPolicy.TabIndex = 18
        lblRenewalPolicy.Text = "Info"
        lblRenewalPolicy.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label19.ForeColor = Color.White
        Label19.Location = New Point(283, 15)
        Label19.Margin = New Padding(3, 0, 0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(113, 73)
        Label19.TabIndex = 17
        Label19.Text = "Renewal Policy"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPlanCost
        ' 
        lblPlanCost.AutoSize = True
        lblPlanCost.Dock = DockStyle.Fill
        lblPlanCost.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanCost.ForeColor = Color.White
        lblPlanCost.Location = New Point(227, 88)
        lblPlanCost.Margin = New Padding(3, 0, 0, 0)
        lblPlanCost.Name = "lblPlanCost"
        lblPlanCost.Size = New Size(53, 73)
        lblPlanCost.TabIndex = 15
        lblPlanCost.Text = "Info"
        lblPlanCost.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPlanAccess
        ' 
        lblPlanAccess.AutoSize = True
        lblPlanAccess.Dock = DockStyle.Fill
        lblPlanAccess.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanAccess.ForeColor = Color.White
        lblPlanAccess.Location = New Point(151, 88)
        lblPlanAccess.Margin = New Padding(3, 0, 0, 0)
        lblPlanAccess.Name = "lblPlanAccess"
        lblPlanAccess.Size = New Size(73, 73)
        lblPlanAccess.TabIndex = 14
        lblPlanAccess.Text = "Info"
        lblPlanAccess.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPlanStartDate
        ' 
        lblPlanStartDate.AutoSize = True
        lblPlanStartDate.Dock = DockStyle.Fill
        lblPlanStartDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanStartDate.ForeColor = Color.White
        lblPlanStartDate.Location = New Point(13, 88)
        lblPlanStartDate.Margin = New Padding(3, 0, 0, 0)
        lblPlanStartDate.Name = "lblPlanStartDate"
        lblPlanStartDate.Size = New Size(71, 73)
        lblPlanStartDate.TabIndex = 12
        lblPlanStartDate.Text = "Info"
        lblPlanStartDate.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label18.ForeColor = Color.White
        Label18.Location = New Point(227, 15)
        Label18.Margin = New Padding(3, 0, 0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 73)
        Label18.TabIndex = 11
        Label18.Text = "Cost"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label17.ForeColor = Color.White
        Label17.Location = New Point(151, 15)
        Label17.Margin = New Padding(3, 0, 0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 73)
        Label17.TabIndex = 10
        Label17.Text = "Benefits"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Fill
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(87, 15)
        Label16.Margin = New Padding(3, 0, 0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 73)
        Label16.TabIndex = 9
        Label16.Text = "End Date"
        Label16.TextAlign = ContentAlignment.MiddleCenter
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
        Label15.Size = New Size(71, 73)
        Label15.TabIndex = 8
        Label15.Text = "Start Date"
        Label15.TextAlign = ContentAlignment.MiddleCenter
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
        Panel4.Size = New Size(406, 49)
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
        TableLayoutPanel7.Size = New Size(406, 32)
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
        Label9.Location = New Point(251, 0)
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
        Label11.Size = New Size(245, 27)
        Label11.TabIndex = 4
        Label11.Text = "Membership"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(reservationsDGV)
        Panel5.Controls.Add(TableLayoutPanel10)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(13, 811)
        Panel5.Margin = New Padding(3, 10, 3, 3)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20, 10, 20, 10)
        Panel5.Size = New Size(446, 638)
        Panel5.TabIndex = 16
        ' 
        ' reservationsDGV
        ' 
        reservationsDGV.AllowUserToAddRows = False
        reservationsDGV.BackgroundColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        reservationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Transparent
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.Padding = New Padding(10, 0, 10, 0)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        reservationsDGV.DefaultCellStyle = DataGridViewCellStyle2
        reservationsDGV.Dock = DockStyle.Fill
        reservationsDGV.GridColor = Color.White
        reservationsDGV.Location = New Point(20, 42)
        reservationsDGV.Name = "reservationsDGV"
        reservationsDGV.ReadOnly = True
        reservationsDGV.Size = New Size(406, 586)
        reservationsDGV.TabIndex = 9
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.BackColor = Color.Transparent
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 89F))
        TableLayoutPanel10.Controls.Add(btnAddReservation, 1, 0)
        TableLayoutPanel10.Controls.Add(Label13, 0, 0)
        TableLayoutPanel10.Dock = DockStyle.Top
        TableLayoutPanel10.Location = New Point(20, 10)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.Padding = New Padding(0, 0, 0, 5)
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.Size = New Size(406, 32)
        TableLayoutPanel10.TabIndex = 8
        ' 
        ' btnAddReservation
        ' 
        btnAddReservation.AutoSize = True
        btnAddReservation.BackColor = Color.Black
        btnAddReservation.Dock = DockStyle.Fill
        btnAddReservation.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddReservation.ForeColor = Color.Gold
        btnAddReservation.ImageAlign = ContentAlignment.MiddleLeft
        btnAddReservation.Location = New Point(320, 0)
        btnAddReservation.Margin = New Padding(3, 0, 0, 0)
        btnAddReservation.Name = "btnAddReservation"
        btnAddReservation.Padding = New Padding(1)
        btnAddReservation.Size = New Size(86, 27)
        btnAddReservation.TabIndex = 5
        btnAddReservation.Text = "Add Reservation"
        btnAddReservation.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Dock = DockStyle.Fill
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(3, 0)
        Label13.Margin = New Padding(3, 0, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(314, 27)
        Label13.TabIndex = 4
        Label13.Text = "Reservations"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Panel5, 0, 3)
        TableLayoutPanel2.Controls.Add(Panel3, 0, 2)
        TableLayoutPanel2.Controls.Add(chartAttendance, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(292, 34)
        TableLayoutPanel2.MinimumSize = New Size(0, 1000)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(10, 10, 10, 0)
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.31398F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 29.4254227F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 37.2605934F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 734F))
        TableLayoutPanel2.Size = New Size(472, 1536)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' memberProfileControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(600, 496)
        AutoSize = True
        BackColor = Color.Transparent
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        MinimumSize = New Size(675, 496)
        Name = "memberProfileControl"
        Padding = New Padding(15)
        Size = New Size(779, 1585)
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
        Panel2.ResumeLayout(False)
        CType(notesDGV, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(chartAttendance, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(reservationsDGV, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lblUserHandle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents notesDGV As DataGridView
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnAddNotes As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chartAttendance As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblRenewalPolicy As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblPlanCost As Label
    Friend WithEvents lblPlanAccess As Label
    Friend WithEvents lblPlanStartDate As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPlanType As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents reservationsDGV As DataGridView
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents btnAddReservation As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAddAttendanceFromPF As Button

End Class
