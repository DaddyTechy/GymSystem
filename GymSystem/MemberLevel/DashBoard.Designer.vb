<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        PictureBox2 = New PictureBox()
        LogoutBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ReportsBtn = New Button()
        ContentPnl = New Panel()
        AnnouncementBtn = New Button()
        UserPnl = New Panel()
        LogoPicBox = New PictureBox()
        LogoTxtLbl = New Label()
        PaymentsBtn = New Button()
        Panel1 = New Panel()
        Menu2Pnl = New Panel()
        MenuPnl = New Panel()
        AttendanceBtn = New Button()
        DashboardBtn = New Button()
        Panel3 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        ContentPnl.SuspendLayout()
        UserPnl.SuspendLayout()
        CType(LogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Menu2Pnl.SuspendLayout()
        MenuPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox2.Location = New Point(169, 67)
        PictureBox2.Margin = New Padding(1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(482, 496)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        LogoutBtn.BackColor = Color.Transparent
        LogoutBtn.FlatAppearance.BorderSize = 0
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        LogoutBtn.ForeColor = SystemColors.ButtonHighlight
        LogoutBtn.Image = My.Resources.Resources.Vector_21
        LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogoutBtn.Location = New Point(344, 13)
        LogoutBtn.Margin = New Padding(3, 4, 3, 4)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(98, 66)
        LogoutBtn.TabIndex = 5
        LogoutBtn.Text = " Logout"
        LogoutBtn.TextAlign = ContentAlignment.MiddleLeft
        LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(118, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 28)
        Label1.TabIndex = 1
        Label1.Text = "Welcome Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = My.Resources.Resources.Vector_11
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(LogoutBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(325, 99)
        Panel2.TabIndex = 2
        ' 
        ' ReportsBtn
        ' 
        ReportsBtn.BackColor = Color.Black
        ReportsBtn.Dock = DockStyle.Top
        ReportsBtn.FlatAppearance.BorderSize = 0
        ReportsBtn.FlatStyle = FlatStyle.Flat
        ReportsBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        ReportsBtn.ForeColor = SystemColors.ButtonHighlight
        ReportsBtn.Image = My.Resources.Resources.Vector3
        ReportsBtn.ImageAlign = ContentAlignment.MiddleLeft
        ReportsBtn.Location = New Point(15, 313)
        ReportsBtn.Name = "ReportsBtn"
        ReportsBtn.Size = New Size(288, 84)
        ReportsBtn.TabIndex = 18
        ReportsBtn.Text = "   Reports"
        ReportsBtn.TextAlign = ContentAlignment.MiddleLeft
        ReportsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ReportsBtn.UseVisualStyleBackColor = False
        ' 
        ' ContentPnl
        ' 
        ContentPnl.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ContentPnl.Controls.Add(PictureBox2)
        ContentPnl.Dock = DockStyle.Fill
        ContentPnl.Location = New Point(303, 99)
        ContentPnl.Name = "ContentPnl"
        ContentPnl.Size = New Size(832, 645)
        ContentPnl.TabIndex = 11
        ' 
        ' AnnouncementBtn
        ' 
        AnnouncementBtn.BackColor = Color.Black
        AnnouncementBtn.Dock = DockStyle.Top
        AnnouncementBtn.FlatAppearance.BorderSize = 0
        AnnouncementBtn.FlatStyle = FlatStyle.Flat
        AnnouncementBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        AnnouncementBtn.ForeColor = SystemColors.ButtonHighlight
        AnnouncementBtn.Image = CType(resources.GetObject("AnnouncementBtn.Image"), Image)
        AnnouncementBtn.ImageAlign = ContentAlignment.MiddleLeft
        AnnouncementBtn.Location = New Point(15, 228)
        AnnouncementBtn.Name = "AnnouncementBtn"
        AnnouncementBtn.Size = New Size(288, 85)
        AnnouncementBtn.TabIndex = 13
        AnnouncementBtn.Text = "   Announcemnet"
        AnnouncementBtn.TextAlign = ContentAlignment.MiddleLeft
        AnnouncementBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AnnouncementBtn.UseVisualStyleBackColor = False
        ' 
        ' UserPnl
        ' 
        UserPnl.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        UserPnl.Controls.Add(Panel2)
        UserPnl.Dock = DockStyle.Top
        UserPnl.Location = New Point(303, 0)
        UserPnl.Name = "UserPnl"
        UserPnl.Size = New Size(832, 99)
        UserPnl.TabIndex = 10
        ' 
        ' LogoPicBox
        ' 
        LogoPicBox.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        LogoPicBox.Location = New Point(10, 39)
        LogoPicBox.Margin = New Padding(1)
        LogoPicBox.Name = "LogoPicBox"
        LogoPicBox.Size = New Size(115, 135)
        LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPicBox.TabIndex = 0
        LogoPicBox.TabStop = False
        ' 
        ' LogoTxtLbl
        ' 
        LogoTxtLbl.AutoSize = True
        LogoTxtLbl.BackColor = Color.Black
        LogoTxtLbl.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoTxtLbl.ForeColor = SystemColors.ButtonHighlight
        LogoTxtLbl.Location = New Point(121, 69)
        LogoTxtLbl.Margin = New Padding(0)
        LogoTxtLbl.Name = "LogoTxtLbl"
        LogoTxtLbl.Size = New Size(139, 62)
        LogoTxtLbl.TabIndex = 1
        LogoTxtLbl.Text = "JJ Fitness " & vbCrLf & "GYM"
        ' 
        ' PaymentsBtn
        ' 
        PaymentsBtn.BackColor = Color.Black
        PaymentsBtn.Dock = DockStyle.Top
        PaymentsBtn.FlatAppearance.BorderSize = 0
        PaymentsBtn.FlatStyle = FlatStyle.Flat
        PaymentsBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        PaymentsBtn.ForeColor = SystemColors.ButtonHighlight
        PaymentsBtn.Image = CType(resources.GetObject("PaymentsBtn.Image"), Image)
        PaymentsBtn.ImageAlign = ContentAlignment.MiddleLeft
        PaymentsBtn.Location = New Point(15, 151)
        PaymentsBtn.Name = "PaymentsBtn"
        PaymentsBtn.Size = New Size(288, 77)
        PaymentsBtn.TabIndex = 12
        PaymentsBtn.Text = "   Payments"
        PaymentsBtn.TextAlign = ContentAlignment.MiddleLeft
        PaymentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        PaymentsBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(LogoPicBox)
        Panel1.Controls.Add(LogoTxtLbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(303, 221)
        Panel1.TabIndex = 2
        ' 
        ' Menu2Pnl
        ' 
        Menu2Pnl.Controls.Add(MenuPnl)
        Menu2Pnl.Controls.Add(Panel1)
        Menu2Pnl.Dock = DockStyle.Left
        Menu2Pnl.Location = New Point(0, 0)
        Menu2Pnl.Margin = New Padding(3, 4, 3, 4)
        Menu2Pnl.Name = "Menu2Pnl"
        Menu2Pnl.Size = New Size(303, 744)
        Menu2Pnl.TabIndex = 9
        ' 
        ' MenuPnl
        ' 
        MenuPnl.AutoScroll = True
        MenuPnl.AutoScrollMargin = New Size(0, 45)
        MenuPnl.AutoScrollMinSize = New Size(0, 100)
        MenuPnl.AutoSize = True
        MenuPnl.BackColor = Color.Black
        MenuPnl.Controls.Add(ReportsBtn)
        MenuPnl.Controls.Add(AnnouncementBtn)
        MenuPnl.Controls.Add(PaymentsBtn)
        MenuPnl.Controls.Add(AttendanceBtn)
        MenuPnl.Controls.Add(DashboardBtn)
        MenuPnl.Controls.Add(Panel3)
        MenuPnl.Dock = DockStyle.Fill
        MenuPnl.Location = New Point(0, 221)
        MenuPnl.MinimumSize = New Size(0, 51)
        MenuPnl.Name = "MenuPnl"
        MenuPnl.Size = New Size(303, 523)
        MenuPnl.TabIndex = 4
        ' 
        ' AttendanceBtn
        ' 
        AttendanceBtn.BackColor = Color.Black
        AttendanceBtn.Dock = DockStyle.Top
        AttendanceBtn.FlatAppearance.BorderSize = 0
        AttendanceBtn.FlatStyle = FlatStyle.Flat
        AttendanceBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        AttendanceBtn.ForeColor = SystemColors.ButtonHighlight
        AttendanceBtn.Image = My.Resources.Resources.Vector1
        AttendanceBtn.ImageAlign = ContentAlignment.MiddleLeft
        AttendanceBtn.Location = New Point(15, 83)
        AttendanceBtn.Name = "AttendanceBtn"
        AttendanceBtn.Size = New Size(288, 68)
        AttendanceBtn.TabIndex = 8
        AttendanceBtn.Text = "   Attendance"
        AttendanceBtn.TextAlign = ContentAlignment.MiddleLeft
        AttendanceBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AttendanceBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.Black
        DashboardBtn.Dock = DockStyle.Top
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DashboardBtn.ForeColor = SystemColors.ButtonHighlight
        DashboardBtn.Image = My.Resources.Resources.Vector
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(15, 0)
        DashboardBtn.Margin = New Padding(3, 4, 3, 4)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(288, 83)
        DashboardBtn.TabIndex = 3
        DashboardBtn.Text = "   Dashboard"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 523)
        Panel3.TabIndex = 6
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ContentPnl)
        Controls.Add(UserPnl)
        Controls.Add(Menu2Pnl)
        Name = "dashboard"
        Size = New Size(1135, 744)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ContentPnl.ResumeLayout(False)
        UserPnl.ResumeLayout(False)
        CType(LogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Menu2Pnl.ResumeLayout(False)
        Menu2Pnl.PerformLayout()
        MenuPnl.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReportsBtn As Button
    Friend WithEvents ContentPnl As Panel
    Friend WithEvents AnnouncementBtn As Button
    Friend WithEvents UserPnl As Panel
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents LogoTxtLbl As Label
    Friend WithEvents PaymentsBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Menu2Pnl As Panel
    Friend WithEvents MenuPnl As Panel
    Friend WithEvents AttendanceBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Panel3 As Panel

End Class
