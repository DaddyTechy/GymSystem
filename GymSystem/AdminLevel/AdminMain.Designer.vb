﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMain
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
        LogoTxtLbl = New Label()
        LogoPicBox = New PictureBox()
        Panel1 = New Panel()
        Menu2Pnl = New Panel()
        MenuPnl = New Panel()
        othersBtn = New Button()
        ReportsSubMenu = New Panel()
        MemProgRepBtn = New Button()
        MemRepBtn = New Button()
        ChartsBtn = New Button()
        ReportsBtn = New Button()
        GymEqpSubMenu = New Panel()
        UpdEqpDetBtn = New Button()
        RemoveEqpBtn = New Button()
        AddEqpBtn = New Button()
        EqpListBtn = New Button()
        GymEquipmentBtn = New Button()
        StaffMngmtBtn = New Button()
        AnnouncementBtn = New Button()
        PaymentsBtn = New Button()
        MemStatBtn = New Button()
        MemProgBtn = New Button()
        AttendanceSubMenu = New Panel()
        AttenChckNBtn = New Button()
        AttendanceBtn = New Button()
        MemManSubMenu = New Panel()
        MemEntryFormBtn = New Button()
        ListAllMembersBtn = New Button()
        MemManBtn = New Button()
        DashboardBtn = New Button()
        Panel3 = New Panel()
        UserPnl = New Panel()
        Panel2 = New Panel()
        LogoutBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ContentPnl = New Panel()
        PictureBox2 = New PictureBox()
        CType(LogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Menu2Pnl.SuspendLayout()
        MenuPnl.SuspendLayout()
        ReportsSubMenu.SuspendLayout()
        GymEqpSubMenu.SuspendLayout()
        AttendanceSubMenu.SuspendLayout()
        MemManSubMenu.SuspendLayout()
        UserPnl.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContentPnl.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' LogoPicBox
        ' 
        LogoPicBox.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        LogoPicBox.Location = New Point(9, 29)
        LogoPicBox.Margin = New Padding(1)
        LogoPicBox.Name = "LogoPicBox"
        LogoPicBox.Size = New Size(115, 135)
        LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPicBox.TabIndex = 0
        LogoPicBox.TabStop = False
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
        Menu2Pnl.Size = New Size(303, 773)
        Menu2Pnl.TabIndex = 6
        ' 
        ' MenuPnl
        ' 
        MenuPnl.AutoScroll = True
        MenuPnl.AutoScrollMargin = New Size(0, 45)
        MenuPnl.AutoScrollMinSize = New Size(0, 100)
        MenuPnl.AutoSize = True
        MenuPnl.BackColor = Color.Black
        MenuPnl.Controls.Add(othersBtn)
        MenuPnl.Controls.Add(ReportsSubMenu)
        MenuPnl.Controls.Add(ReportsBtn)
        MenuPnl.Controls.Add(GymEqpSubMenu)
        MenuPnl.Controls.Add(GymEquipmentBtn)
        MenuPnl.Controls.Add(StaffMngmtBtn)
        MenuPnl.Controls.Add(AnnouncementBtn)
        MenuPnl.Controls.Add(PaymentsBtn)
        MenuPnl.Controls.Add(MemStatBtn)
        MenuPnl.Controls.Add(MemProgBtn)
        MenuPnl.Controls.Add(AttendanceSubMenu)
        MenuPnl.Controls.Add(AttendanceBtn)
        MenuPnl.Controls.Add(MemManSubMenu)
        MenuPnl.Controls.Add(MemManBtn)
        MenuPnl.Controls.Add(DashboardBtn)
        MenuPnl.Controls.Add(Panel3)
        MenuPnl.Dock = DockStyle.Fill
        MenuPnl.Location = New Point(0, 221)
        MenuPnl.MinimumSize = New Size(0, 51)
        MenuPnl.Name = "MenuPnl"
        MenuPnl.Size = New Size(303, 552)
        MenuPnl.TabIndex = 4
        ' 
        ' othersBtn
        ' 
        othersBtn.BackColor = Color.Black
        othersBtn.Dock = DockStyle.Top
        othersBtn.FlatAppearance.BorderSize = 0
        othersBtn.FlatStyle = FlatStyle.Flat
        othersBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        othersBtn.ForeColor = SystemColors.ButtonHighlight
        othersBtn.Image = My.Resources.Resources.Cog1
        othersBtn.ImageAlign = ContentAlignment.MiddleLeft
        othersBtn.Location = New Point(13, 886)
        othersBtn.Margin = New Padding(3, 2, 3, 2)
        othersBtn.Name = "othersBtn"
        othersBtn.Size = New Size(267, 63)
        othersBtn.TabIndex = 20
        othersBtn.Text = "   Miscellaneous"
        othersBtn.TextAlign = ContentAlignment.MiddleLeft
        othersBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        othersBtn.UseVisualStyleBackColor = False
        ' 
        ' ReportsSubMenu
        ' 
        ReportsSubMenu.Controls.Add(MemProgRepBtn)
        ReportsSubMenu.Controls.Add(MemRepBtn)
        ReportsSubMenu.Controls.Add(ChartsBtn)
        ReportsSubMenu.Dock = DockStyle.Top
        ReportsSubMenu.Location = New Point(13, 800)
        ReportsSubMenu.Margin = New Padding(3, 2, 3, 2)
        ReportsSubMenu.Name = "ReportsSubMenu"
        ReportsSubMenu.Size = New Size(267, 115)
        ReportsSubMenu.TabIndex = 19
        ' 
        ' MemProgRepBtn
        ' 
        MemProgRepBtn.Dock = DockStyle.Top
        MemProgRepBtn.FlatAppearance.BorderSize = 0
        MemProgRepBtn.FlatStyle = FlatStyle.Flat
        MemProgRepBtn.ForeColor = SystemColors.ButtonHighlight
        MemProgRepBtn.Image = My.Resources.Resources.Vector_1
        MemProgRepBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemProgRepBtn.Location = New Point(0, 69)
        MemProgRepBtn.Margin = New Padding(3, 4, 3, 4)
        MemProgRepBtn.Name = "MemProgRepBtn"
        MemProgRepBtn.Padding = New Padding(39, 0, 0, 0)
        MemProgRepBtn.Size = New Size(235, 29)
        MemProgRepBtn.TabIndex = 6
        MemProgRepBtn.Text = "  Members' Progress"
        MemProgRepBtn.TextAlign = ContentAlignment.TopLeft
        MemProgRepBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemProgRepBtn.UseVisualStyleBackColor = True
        ' 
        ' MemRepBtn
        ' 
        MemRepBtn.Dock = DockStyle.Top
        MemRepBtn.FlatAppearance.BorderSize = 0
        MemRepBtn.FlatStyle = FlatStyle.Flat
        MemRepBtn.ForeColor = SystemColors.ButtonHighlight
        MemRepBtn.Image = My.Resources.Resources.Vector_1
        MemRepBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemRepBtn.Location = New Point(0, 37)
        MemRepBtn.Margin = New Padding(3, 4, 3, 4)
        MemRepBtn.Name = "MemRepBtn"
        MemRepBtn.Padding = New Padding(45, 0, 0, 0)
        MemRepBtn.Size = New Size(267, 32)
        MemRepBtn.TabIndex = 5
        MemRepBtn.Text = "  Members' Report"
        MemRepBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemRepBtn.UseVisualStyleBackColor = True
        ' 
        ' ChartsBtn
        ' 
        ChartsBtn.BackColor = Color.Black
        ChartsBtn.Dock = DockStyle.Top
        ChartsBtn.FlatAppearance.BorderSize = 0
        ChartsBtn.FlatStyle = FlatStyle.Flat
        ChartsBtn.ForeColor = SystemColors.ButtonHighlight
        ChartsBtn.Image = My.Resources.Resources.Vector_1
        ChartsBtn.ImageAlign = ContentAlignment.MiddleLeft
        ChartsBtn.Location = New Point(0, 0)
        ChartsBtn.Margin = New Padding(3, 4, 3, 4)
        ChartsBtn.Name = "ChartsBtn"
        ChartsBtn.Padding = New Padding(45, 0, 0, 0)
        ChartsBtn.Size = New Size(267, 37)
        ChartsBtn.TabIndex = 4
        ChartsBtn.Text = "  Charts"
        ChartsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ChartsBtn.UseVisualStyleBackColor = False
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
        ReportsBtn.Location = New Point(13, 737)
        ReportsBtn.Margin = New Padding(3, 2, 3, 2)
        ReportsBtn.Name = "ReportsBtn"
        ReportsBtn.Size = New Size(267, 84)
        ReportsBtn.TabIndex = 18
        ReportsBtn.Text = "   Reports"
        ReportsBtn.TextAlign = ContentAlignment.MiddleLeft
        ReportsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ReportsBtn.UseVisualStyleBackColor = False
        ' 
        ' GymEqpSubMenu
        ' 
        GymEqpSubMenu.Controls.Add(UpdEqpDetBtn)
        GymEqpSubMenu.Controls.Add(RemoveEqpBtn)
        GymEqpSubMenu.Controls.Add(AddEqpBtn)
        GymEqpSubMenu.Controls.Add(EqpListBtn)
        GymEqpSubMenu.Dock = DockStyle.Top
        GymEqpSubMenu.Location = New Point(13, 632)
        GymEqpSubMenu.Margin = New Padding(3, 2, 3, 2)
        GymEqpSubMenu.Name = "GymEqpSubMenu"
        GymEqpSubMenu.Size = New Size(267, 140)
        GymEqpSubMenu.TabIndex = 17
        ' 
        ' UpdEqpDetBtn
        ' 
        UpdEqpDetBtn.Dock = DockStyle.Top
        UpdEqpDetBtn.FlatAppearance.BorderSize = 0
        UpdEqpDetBtn.FlatStyle = FlatStyle.Flat
        UpdEqpDetBtn.ForeColor = SystemColors.ButtonHighlight
        UpdEqpDetBtn.Image = My.Resources.Resources.Vector_1
        UpdEqpDetBtn.ImageAlign = ContentAlignment.MiddleLeft
        UpdEqpDetBtn.Location = New Point(0, 103)
        UpdEqpDetBtn.Margin = New Padding(3, 4, 3, 4)
        UpdEqpDetBtn.Name = "UpdEqpDetBtn"
        UpdEqpDetBtn.Padding = New Padding(45, 0, 0, 0)
        UpdEqpDetBtn.Size = New Size(267, 37)
        UpdEqpDetBtn.TabIndex = 7
        UpdEqpDetBtn.Text = "  Update Equipment Details"
        UpdEqpDetBtn.TextAlign = ContentAlignment.MiddleLeft
        UpdEqpDetBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        UpdEqpDetBtn.UseVisualStyleBackColor = True
        ' 
        ' RemoveEqpBtn
        ' 
        RemoveEqpBtn.Dock = DockStyle.Top
        RemoveEqpBtn.FlatAppearance.BorderSize = 0
        RemoveEqpBtn.FlatStyle = FlatStyle.Flat
        RemoveEqpBtn.ForeColor = SystemColors.ButtonHighlight
        RemoveEqpBtn.Image = My.Resources.Resources.Vector_1
        RemoveEqpBtn.ImageAlign = ContentAlignment.MiddleLeft
        RemoveEqpBtn.Location = New Point(0, 64)
        RemoveEqpBtn.Margin = New Padding(3, 4, 3, 4)
        RemoveEqpBtn.Name = "RemoveEqpBtn"
        RemoveEqpBtn.Padding = New Padding(45, 0, 0, 0)
        RemoveEqpBtn.Size = New Size(267, 39)
        RemoveEqpBtn.TabIndex = 6
        RemoveEqpBtn.Text = "  Remove Equipment"
        RemoveEqpBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        RemoveEqpBtn.UseVisualStyleBackColor = True
        ' 
        ' AddEqpBtn
        ' 
        AddEqpBtn.Dock = DockStyle.Top
        AddEqpBtn.FlatAppearance.BorderSize = 0
        AddEqpBtn.FlatStyle = FlatStyle.Flat
        AddEqpBtn.ForeColor = SystemColors.ButtonHighlight
        AddEqpBtn.Image = My.Resources.Resources.Vector_1
        AddEqpBtn.ImageAlign = ContentAlignment.MiddleLeft
        AddEqpBtn.Location = New Point(0, 29)
        AddEqpBtn.Margin = New Padding(3, 4, 3, 4)
        AddEqpBtn.Name = "AddEqpBtn"
        AddEqpBtn.Padding = New Padding(45, 0, 0, 0)
        AddEqpBtn.Size = New Size(267, 35)
        AddEqpBtn.TabIndex = 5
        AddEqpBtn.Text = "  Add Equipment"
        AddEqpBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AddEqpBtn.UseVisualStyleBackColor = True
        ' 
        ' EqpListBtn
        ' 
        EqpListBtn.BackColor = Color.Black
        EqpListBtn.Dock = DockStyle.Top
        EqpListBtn.FlatAppearance.BorderSize = 0
        EqpListBtn.FlatStyle = FlatStyle.Flat
        EqpListBtn.ForeColor = SystemColors.ButtonHighlight
        EqpListBtn.Image = My.Resources.Resources.Vector_1
        EqpListBtn.ImageAlign = ContentAlignment.MiddleLeft
        EqpListBtn.Location = New Point(0, 0)
        EqpListBtn.Margin = New Padding(3, 4, 3, 4)
        EqpListBtn.Name = "EqpListBtn"
        EqpListBtn.Padding = New Padding(45, 0, 0, 0)
        EqpListBtn.Size = New Size(267, 29)
        EqpListBtn.TabIndex = 4
        EqpListBtn.Text = "  Equipment List"
        EqpListBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        EqpListBtn.UseVisualStyleBackColor = False
        ' 
        ' GymEquipmentBtn
        ' 
        GymEquipmentBtn.BackColor = Color.Black
        GymEquipmentBtn.Dock = DockStyle.Top
        GymEquipmentBtn.FlatAppearance.BorderSize = 0
        GymEquipmentBtn.FlatStyle = FlatStyle.Flat
        GymEquipmentBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        GymEquipmentBtn.ForeColor = SystemColors.ButtonHighlight
        GymEquipmentBtn.Image = My.Resources.Resources.Vector2
        GymEquipmentBtn.ImageAlign = ContentAlignment.MiddleLeft
        GymEquipmentBtn.Location = New Point(13, 573)
        GymEquipmentBtn.Margin = New Padding(3, 2, 3, 2)
        GymEquipmentBtn.Name = "GymEquipmentBtn"
        GymEquipmentBtn.Size = New Size(267, 79)
        GymEquipmentBtn.TabIndex = 15
        GymEquipmentBtn.Text = "   Gym Equipments"
        GymEquipmentBtn.TextAlign = ContentAlignment.MiddleLeft
        GymEquipmentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        GymEquipmentBtn.UseVisualStyleBackColor = False
        ' 
        ' StaffMngmtBtn
        ' 
        StaffMngmtBtn.BackColor = Color.Black
        StaffMngmtBtn.Dock = DockStyle.Top
        StaffMngmtBtn.FlatAppearance.BorderSize = 0
        StaffMngmtBtn.FlatStyle = FlatStyle.Flat
        StaffMngmtBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        StaffMngmtBtn.ForeColor = SystemColors.ButtonHighlight
        StaffMngmtBtn.Image = My.Resources.Resources.Group_26
        StaffMngmtBtn.ImageAlign = ContentAlignment.MiddleLeft
        StaffMngmtBtn.Location = New Point(13, 510)
        StaffMngmtBtn.Margin = New Padding(3, 2, 3, 2)
        StaffMngmtBtn.Name = "StaffMngmtBtn"
        StaffMngmtBtn.Size = New Size(267, 84)
        StaffMngmtBtn.TabIndex = 14
        StaffMngmtBtn.Text = "   Staff Management"
        StaffMngmtBtn.TextAlign = ContentAlignment.MiddleLeft
        StaffMngmtBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        StaffMngmtBtn.UseVisualStyleBackColor = False
        ' 
        ' AnnouncementBtn
        ' 
        AnnouncementBtn.BackColor = Color.Black
        AnnouncementBtn.Dock = DockStyle.Top
        AnnouncementBtn.FlatAppearance.BorderSize = 0
        AnnouncementBtn.FlatStyle = FlatStyle.Flat
        AnnouncementBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        AnnouncementBtn.ForeColor = SystemColors.ButtonHighlight
        AnnouncementBtn.Image = Vector_5
        AnnouncementBtn.ImageAlign = ContentAlignment.MiddleLeft
        AnnouncementBtn.Location = New Point(13, 446)
        AnnouncementBtn.Margin = New Padding(3, 2, 3, 2)
        AnnouncementBtn.Name = "AnnouncementBtn"
        AnnouncementBtn.Size = New Size(267, 85)
        AnnouncementBtn.TabIndex = 13
        AnnouncementBtn.Text = "   Announcements"
        AnnouncementBtn.TextAlign = ContentAlignment.MiddleLeft
        AnnouncementBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AnnouncementBtn.UseVisualStyleBackColor = False
        ' 
        ' PaymentsBtn
        ' 
        PaymentsBtn.BackColor = Color.Black
        PaymentsBtn.Dock = DockStyle.Top
        PaymentsBtn.FlatAppearance.BorderSize = 0
        PaymentsBtn.FlatStyle = FlatStyle.Flat
        PaymentsBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        PaymentsBtn.ForeColor = SystemColors.ButtonHighlight
        PaymentsBtn.Image = Vector_4
        PaymentsBtn.ImageAlign = ContentAlignment.MiddleLeft
        PaymentsBtn.Location = New Point(13, 388)
        PaymentsBtn.Margin = New Padding(3, 2, 3, 2)
        PaymentsBtn.Name = "PaymentsBtn"
        PaymentsBtn.Size = New Size(267, 77)
        PaymentsBtn.TabIndex = 12
        PaymentsBtn.Text = "   Payments"
        PaymentsBtn.TextAlign = ContentAlignment.MiddleLeft
        PaymentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        PaymentsBtn.UseVisualStyleBackColor = False
        ' 
        ' MemStatBtn
        ' 
        MemStatBtn.BackColor = Color.Black
        MemStatBtn.Dock = DockStyle.Top
        MemStatBtn.FlatAppearance.BorderSize = 0
        MemStatBtn.FlatStyle = FlatStyle.Flat
        MemStatBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        MemStatBtn.ForeColor = SystemColors.ButtonHighlight
        MemStatBtn.Image = My.Resources.Resources.Vector4
        MemStatBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemStatBtn.Location = New Point(13, 330)
        MemStatBtn.Margin = New Padding(3, 2, 3, 2)
        MemStatBtn.Name = "MemStatBtn"
        MemStatBtn.Size = New Size(267, 77)
        MemStatBtn.TabIndex = 11
        MemStatBtn.Text = "   Members' Status"
        MemStatBtn.TextAlign = ContentAlignment.MiddleLeft
        MemStatBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemStatBtn.UseVisualStyleBackColor = False
        ' 
        ' MemProgBtn
        ' 
        MemProgBtn.BackColor = Color.Black
        MemProgBtn.Dock = DockStyle.Top
        MemProgBtn.FlatAppearance.BorderSize = 0
        MemProgBtn.FlatStyle = FlatStyle.Flat
        MemProgBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        MemProgBtn.ForeColor = SystemColors.ButtonHighlight
        MemProgBtn.Image = My.Resources.Resources.Group_241
        MemProgBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemProgBtn.Location = New Point(13, 277)
        MemProgBtn.Margin = New Padding(3, 2, 3, 2)
        MemProgBtn.Name = "MemProgBtn"
        MemProgBtn.Size = New Size(267, 71)
        MemProgBtn.TabIndex = 10
        MemProgBtn.Text = "  Members' Progress"
        MemProgBtn.TextAlign = ContentAlignment.MiddleLeft
        MemProgBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemProgBtn.UseVisualStyleBackColor = False
        ' 
        ' AttendanceSubMenu
        ' 
        AttendanceSubMenu.Controls.Add(AttenChckNBtn)
        AttendanceSubMenu.Dock = DockStyle.Top
        AttendanceSubMenu.Location = New Point(15, 298)
        AttendanceSubMenu.Name = "AttendanceSubMenu"
        AttendanceSubMenu.Size = New Size(235, 54)
        AttendanceSubMenu.TabIndex = 9
        ' 
        ' AttnViewBtn
        ' 
        AttnViewBtn.Dock = DockStyle.Top
        AttnViewBtn.FlatAppearance.BorderSize = 0
        AttnViewBtn.FlatStyle = FlatStyle.Flat
        AttnViewBtn.ForeColor = SystemColors.ButtonHighlight
        AttnViewBtn.Image = My.Resources.Resources.Vector_1
        AttnViewBtn.ImageAlign = ContentAlignment.MiddleLeft
        AttnViewBtn.Location = New Point(0, 28)
        AttnViewBtn.Name = "AttnViewBtn"
        AttnViewBtn.Padding = New Padding(39, 0, 0, 0)
        AttnViewBtn.Size = New Size(235, 25)
        AttnViewBtn.TabIndex = 5
        AttnViewBtn.Text = "  View"
        AttnViewBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AttnViewBtn.UseVisualStyleBackColor = True
        ' 
        ' AttenChckNBtn
        ' 
        AttenChckNBtn.BackColor = Color.Black
        AttenChckNBtn.Dock = DockStyle.Top
        AttenChckNBtn.FlatAppearance.BorderSize = 0
        AttenChckNBtn.FlatStyle = FlatStyle.Flat
        AttenChckNBtn.ForeColor = SystemColors.ButtonHighlight
        AttenChckNBtn.Image = My.Resources.Resources.Vector_1
        AttenChckNBtn.ImageAlign = ContentAlignment.MiddleLeft
        AttenChckNBtn.Location = New Point(0, 0)
        AttenChckNBtn.Margin = New Padding(3, 4, 3, 4)
        AttenChckNBtn.Name = "AttenChckNBtn"
        AttenChckNBtn.Padding = New Padding(45, 0, 0, 0)
        AttenChckNBtn.Size = New Size(267, 37)
        AttenChckNBtn.TabIndex = 4
        AttenChckNBtn.Text = "  Check In/Out"
        AttenChckNBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AttenChckNBtn.UseVisualStyleBackColor = False
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
        AttendanceBtn.Location = New Point(15, 230)
        AttendanceBtn.Name = "AttendanceBtn"
        AttendanceBtn.Size = New Size(267, 68)
        AttendanceBtn.TabIndex = 8
        AttendanceBtn.Text = "   Attendance"
        AttendanceBtn.TextAlign = ContentAlignment.MiddleLeft
        AttendanceBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AttendanceBtn.UseVisualStyleBackColor = False
        ' 
        ' MemManSubMenu
        ' 
        MemManSubMenu.Controls.Add(MemEntryFormBtn)
        MemManSubMenu.Controls.Add(ListAllMembersBtn)
        MemManSubMenu.Dock = DockStyle.Top
        MemManSubMenu.Location = New Point(15, 151)
        MemManSubMenu.Margin = New Padding(3, 4, 3, 4)
        MemManSubMenu.Name = "MemManSubMenu"
        MemManSubMenu.Size = New Size(267, 79)
        MemManSubMenu.TabIndex = 7
        ' 
        ' MemEntryFormBtn
        ' 
        MemEntryFormBtn.Dock = DockStyle.Top
        MemEntryFormBtn.FlatAppearance.BorderSize = 0
        MemEntryFormBtn.FlatStyle = FlatStyle.Flat
        MemEntryFormBtn.ForeColor = SystemColors.ButtonHighlight
        MemEntryFormBtn.Image = My.Resources.Resources.Vector_1
        MemEntryFormBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemEntryFormBtn.Location = New Point(0, 36)
        MemEntryFormBtn.Margin = New Padding(3, 4, 3, 4)
        MemEntryFormBtn.Name = "MemEntryFormBtn"
        MemEntryFormBtn.Padding = New Padding(45, 0, 0, 0)
        MemEntryFormBtn.Size = New Size(267, 33)
        MemEntryFormBtn.TabIndex = 5
        MemEntryFormBtn.Text = "  Member Entry Form"
        MemEntryFormBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemEntryFormBtn.UseVisualStyleBackColor = True
        ' 
        ' ListAllMembersBtn
        ' 
        ListAllMembersBtn.BackColor = Color.Black
        ListAllMembersBtn.Dock = DockStyle.Top
        ListAllMembersBtn.FlatAppearance.BorderSize = 0
        ListAllMembersBtn.FlatStyle = FlatStyle.Flat
        ListAllMembersBtn.ForeColor = SystemColors.ButtonHighlight
        ListAllMembersBtn.Image = My.Resources.Resources.Vector_1
        ListAllMembersBtn.ImageAlign = ContentAlignment.MiddleLeft
        ListAllMembersBtn.Location = New Point(0, 0)
        ListAllMembersBtn.Margin = New Padding(3, 4, 3, 4)
        ListAllMembersBtn.Name = "ListAllMembersBtn"
        ListAllMembersBtn.Padding = New Padding(45, 0, 0, 0)
        ListAllMembersBtn.Size = New Size(267, 36)
        ListAllMembersBtn.TabIndex = 4
        ListAllMembersBtn.Text = "  List All Members"
        ListAllMembersBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ListAllMembersBtn.UseVisualStyleBackColor = False
        ' 
        ' MemManBtn
        ' 
        MemManBtn.BackColor = Color.Black
        MemManBtn.Dock = DockStyle.Top
        MemManBtn.FlatAppearance.BorderSize = 0
        MemManBtn.FlatStyle = FlatStyle.Flat
        MemManBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        MemManBtn.ForeColor = SystemColors.ButtonHighlight
        MemManBtn.Image = My.Resources.Resources.tdesign_member
        MemManBtn.ImageAlign = ContentAlignment.MiddleLeft
        MemManBtn.Location = New Point(15, 83)
        MemManBtn.Margin = New Padding(3, 4, 3, 4)
        MemManBtn.Name = "MemManBtn"
        MemManBtn.Size = New Size(267, 68)
        MemManBtn.TabIndex = 4
        MemManBtn.Text = "   Member Management"
        MemManBtn.TextAlign = ContentAlignment.MiddleLeft
        MemManBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        MemManBtn.UseVisualStyleBackColor = False
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
        DashboardBtn.Size = New Size(267, 83)
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
        Panel3.Size = New Size(13, 978)
        Panel3.TabIndex = 6
        ' 
        ' UserPnl
        ' 
        UserPnl.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        UserPnl.Controls.Add(Panel2)
        UserPnl.Dock = DockStyle.Top
        UserPnl.Location = New Point(303, 0)
        UserPnl.Name = "UserPnl"
        UserPnl.Size = New Size(754, 99)
        UserPnl.TabIndex = 7
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
        LogoutBtn.Location = New Point(219, 13)
        LogoutBtn.Margin = New Padding(3, 4, 3, 4)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(98, 67)
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
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(56, 33)
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
        ' ContentPnl
        ' 
        ContentPnl.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ContentPnl.Controls.Add(PictureBox2)
        ContentPnl.Dock = DockStyle.Fill
        ContentPnl.Location = New Point(303, 99)
        ContentPnl.Name = "ContentPnl"
        ContentPnl.Size = New Size(754, 674)
        ContentPnl.TabIndex = 8
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox2.Location = New Point(124, 75)
        PictureBox2.Margin = New Padding(1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(482, 496)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' AdminMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(ContentPnl)
        Controls.Add(UserPnl)
        Controls.Add(Menu2Pnl)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1057, 773)
        Name = "AdminMain"
        Size = New Size(1057, 773)
        CType(LogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Menu2Pnl.ResumeLayout(False)
        Menu2Pnl.PerformLayout()
        MenuPnl.ResumeLayout(False)
        ReportsSubMenu.ResumeLayout(False)
        GymEqpSubMenu.ResumeLayout(False)
        AttendanceSubMenu.ResumeLayout(False)
        MemManSubMenu.ResumeLayout(False)
        UserPnl.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ContentPnl.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents LogoTxtLbl As Label
    Friend WithEvents Menu2Pnl As Panel
    Friend WithEvents UserPnl As Panel
    Friend WithEvents MenuPnl As Panel
    Friend WithEvents ReportsSubMenu As Panel
    Friend WithEvents MemProgRepBtn As Button
    Friend WithEvents MemRepBtn As Button
    Friend WithEvents ChartsBtn As Button
    Friend WithEvents ReportsBtn As Button
    Friend WithEvents GymEqpSubMenu As Panel
    Friend WithEvents UpdEqpDetBtn As Button
    Friend WithEvents RemoveEqpBtn As Button
    Friend WithEvents AddEqpBtn As Button
    Friend WithEvents EqpListBtn As Button
    Friend WithEvents GymEquipmentBtn As Button
    Friend WithEvents StaffMngmtBtn As Button
    Friend WithEvents AnnouncementBtn As Button
    Friend WithEvents PaymentsBtn As Button
    Friend WithEvents MemStatBtn As Button
    Friend WithEvents MemProgBtn As Button
    Friend WithEvents AttendanceSubMenu As Panel
    Friend WithEvents AttnViewBtn As Button
    Friend WithEvents AttenChckNBtn As Button
    Friend WithEvents AttendanceBtn As Button
    Friend WithEvents MemManSubMenu As Panel
    Friend WithEvents MemEntryFormBtn As Button
    Friend WithEvents ListAllMembersBtn As Button
    Friend WithEvents MemManBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ContentPnl As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents othersBtn As Button

End Class
