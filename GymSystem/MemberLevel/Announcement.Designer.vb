<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Announcement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        LeftNavPanel = New Panel()
        ReportsBtn = New Button()
        AnnounceBtn = New Button()
        RemindBtn = New Button()
        SchedBtn = New Button()
        DashBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TopNavPanel = New Panel()
        LogoutBtn = New Button()
        WelcomeLbl = New Label()
        PictureBox2 = New PictureBox()
        TopPanel = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        AnnouncementPanel = New Panel()
        SubAnnounce3Lbl = New Label()
        SubAnnounce2Lbl = New Label()
        SubAnnounce1 = New Label()
        Announce3Lbl = New Label()
        Announce2Lbl = New Label()
        Announce1Lbl = New Label()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        LeftNavPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TopNavPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TopPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        AnnouncementPanel.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LeftNavPanel
        ' 
        LeftNavPanel.BackColor = Color.Black
        LeftNavPanel.Controls.Add(ReportsBtn)
        LeftNavPanel.Controls.Add(AnnounceBtn)
        LeftNavPanel.Controls.Add(RemindBtn)
        LeftNavPanel.Controls.Add(SchedBtn)
        LeftNavPanel.Controls.Add(DashBtn)
        LeftNavPanel.Controls.Add(Label1)
        LeftNavPanel.Controls.Add(PictureBox1)
        LeftNavPanel.Location = New Point(0, 0)
        LeftNavPanel.MinimumSize = New Size(350, 2000)
        LeftNavPanel.Name = "LeftNavPanel"
        LeftNavPanel.Size = New Size(353, 2000)
        LeftNavPanel.TabIndex = 2
        ' 
        ' ReportsBtn
        ' 
        ReportsBtn.FlatAppearance.BorderSize = 0
        ReportsBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        ReportsBtn.FlatStyle = FlatStyle.Flat
        ReportsBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReportsBtn.ForeColor = Color.White
        ReportsBtn.Image = My.Resources.Resources.Vector3
        ReportsBtn.Location = New Point(-9, 550)
        ReportsBtn.Name = "ReportsBtn"
        ReportsBtn.Size = New Size(362, 60)
        ReportsBtn.TabIndex = 4
        ReportsBtn.Text = "Reports"
        ReportsBtn.TextAlign = ContentAlignment.MiddleRight
        ReportsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ReportsBtn.UseVisualStyleBackColor = True
        ' 
        ' AnnounceBtn
        ' 
        AnnounceBtn.BackColor = Color.Black
        AnnounceBtn.FlatAppearance.BorderSize = 0
        AnnounceBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        AnnounceBtn.FlatStyle = FlatStyle.Flat
        AnnounceBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AnnounceBtn.ForeColor = Color.White
        AnnounceBtn.Image = My.Resources.Resources.Commercial_1
        AnnounceBtn.ImageAlign = ContentAlignment.MiddleRight
        AnnounceBtn.Location = New Point(-9, 475)
        AnnounceBtn.Name = "AnnounceBtn"
        AnnounceBtn.Size = New Size(362, 60)
        AnnounceBtn.TabIndex = 4
        AnnounceBtn.Text = "Announcement"
        AnnounceBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        AnnounceBtn.UseVisualStyleBackColor = False
        ' 
        ' RemindBtn
        ' 
        RemindBtn.BackColor = Color.Black
        RemindBtn.FlatAppearance.BorderSize = 0
        RemindBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        RemindBtn.FlatStyle = FlatStyle.Flat
        RemindBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RemindBtn.ForeColor = Color.White
        RemindBtn.Image = My.Resources.Resources.Reminder
        RemindBtn.Location = New Point(-9, 400)
        RemindBtn.Name = "RemindBtn"
        RemindBtn.Size = New Size(362, 60)
        RemindBtn.TabIndex = 4
        RemindBtn.Text = "Reminders"
        RemindBtn.TextAlign = ContentAlignment.MiddleRight
        RemindBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        RemindBtn.UseVisualStyleBackColor = False
        ' 
        ' SchedBtn
        ' 
        SchedBtn.BackColor = Color.Black
        SchedBtn.FlatAppearance.BorderSize = 0
        SchedBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        SchedBtn.FlatStyle = FlatStyle.Flat
        SchedBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SchedBtn.ForeColor = Color.White
        SchedBtn.Image = My.Resources.Resources.calendar
        SchedBtn.ImageAlign = ContentAlignment.MiddleRight
        SchedBtn.Location = New Point(-9, 325)
        SchedBtn.Name = "SchedBtn"
        SchedBtn.Size = New Size(362, 60)
        SchedBtn.TabIndex = 4
        SchedBtn.Text = "Scheduling"
        SchedBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SchedBtn.UseVisualStyleBackColor = False
        ' 
        ' DashBtn
        ' 
        DashBtn.BackColor = Color.Black
        DashBtn.FlatAppearance.BorderSize = 0
        DashBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        DashBtn.FlatStyle = FlatStyle.Flat
        DashBtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashBtn.ForeColor = Color.White
        DashBtn.Image = My.Resources.Resources.dashbo
        DashBtn.ImageAlign = ContentAlignment.MiddleRight
        DashBtn.Location = New Point(-9, 250)
        DashBtn.Name = "DashBtn"
        DashBtn.Size = New Size(362, 60)
        DashBtn.TabIndex = 4
        DashBtn.Text = "Dashboard"
        DashBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        DashBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        Label1.Location = New Point(177, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 68)
        Label1.TabIndex = 3
        Label1.Text = "JJ Fitness " & vbCrLf & "GYM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TopNavPanel
        ' 
        TopNavPanel.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        TopNavPanel.Controls.Add(LogoutBtn)
        TopNavPanel.Controls.Add(WelcomeLbl)
        TopNavPanel.Controls.Add(PictureBox2)
        TopNavPanel.Dock = DockStyle.Top
        TopNavPanel.Location = New Point(0, 0)
        TopNavPanel.Name = "TopNavPanel"
        TopNavPanel.Size = New Size(1511, 99)
        TopNavPanel.TabIndex = 3
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.BackColor = Color.Transparent
        LogoutBtn.BackgroundImageLayout = ImageLayout.None
        LogoutBtn.Cursor = Cursors.Hand
        LogoutBtn.FlatAppearance.BorderSize = 0
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutBtn.ForeColor = Color.White
        LogoutBtn.Image = My.Resources.Resources.Vector_21
        LogoutBtn.ImageAlign = ContentAlignment.MiddleRight
        LogoutBtn.Location = New Point(636, 39)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(94, 29)
        LogoutBtn.TabIndex = 2
        LogoutBtn.Text = "Logout"
        LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' WelcomeLbl
        ' 
        WelcomeLbl.AutoSize = True
        WelcomeLbl.FlatStyle = FlatStyle.Flat
        WelcomeLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WelcomeLbl.ForeColor = Color.White
        WelcomeLbl.Image = My.Resources.Resources.Vector_11
        WelcomeLbl.ImageAlign = ContentAlignment.MiddleLeft
        WelcomeLbl.Location = New Point(415, 37)
        WelcomeLbl.Name = "WelcomeLbl"
        WelcomeLbl.RightToLeft = RightToLeft.No
        WelcomeLbl.Size = New Size(197, 28)
        WelcomeLbl.TabIndex = 1
        WelcomeLbl.Text = "     Welcome Member"
        WelcomeLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 35)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TopPanel
        ' 
        TopPanel.Anchor = AnchorStyles.Top
        TopPanel.BorderStyle = BorderStyle.FixedSingle
        TopPanel.Controls.Add(Label2)
        TopPanel.Controls.Add(PictureBox3)
        TopPanel.Location = New Point(443, 218)
        TopPanel.MinimumSize = New Size(1000, 50)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1000, 50)
        TopPanel.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(56, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 25)
        Label2.TabIndex = 6
        Label2.Text = "Gym Announcements"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Commercial_1
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = My.Resources.Resources.Commercial_1
        PictureBox4.Location = New Point(1045, 136)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 70)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(767, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(272, 46)
        Label3.TabIndex = 6
        Label3.Text = "Announcements"
        ' 
        ' AnnouncementPanel
        ' 
        AnnouncementPanel.Anchor = AnchorStyles.Top
        AnnouncementPanel.BorderStyle = BorderStyle.FixedSingle
        AnnouncementPanel.Controls.Add(SubAnnounce3Lbl)
        AnnouncementPanel.Controls.Add(SubAnnounce2Lbl)
        AnnouncementPanel.Controls.Add(SubAnnounce1)
        AnnouncementPanel.Controls.Add(Announce3Lbl)
        AnnouncementPanel.Controls.Add(Announce2Lbl)
        AnnouncementPanel.Controls.Add(Announce1Lbl)
        AnnouncementPanel.Controls.Add(PictureBox7)
        AnnouncementPanel.Controls.Add(PictureBox6)
        AnnouncementPanel.Controls.Add(PictureBox5)
        AnnouncementPanel.Location = New Point(443, 268)
        AnnouncementPanel.Name = "AnnouncementPanel"
        AnnouncementPanel.Size = New Size(1000, 373)
        AnnouncementPanel.TabIndex = 7
        ' 
        ' SubAnnounce3Lbl
        ' 
        SubAnnounce3Lbl.AutoSize = True
        SubAnnounce3Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubAnnounce3Lbl.ForeColor = Color.Gainsboro
        SubAnnounce3Lbl.Location = New Point(84, 156)
        SubAnnounce3Lbl.Name = "SubAnnounce3Lbl"
        SubAnnounce3Lbl.Size = New Size(187, 25)
        SubAnnounce3Lbl.TabIndex = 6
        SubAnnounce3Lbl.Text = "Demo Announcement"
        ' 
        ' SubAnnounce2Lbl
        ' 
        SubAnnounce2Lbl.AutoSize = True
        SubAnnounce2Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubAnnounce2Lbl.ForeColor = Color.Gainsboro
        SubAnnounce2Lbl.Location = New Point(84, 92)
        SubAnnounce2Lbl.Name = "SubAnnounce2Lbl"
        SubAnnounce2Lbl.Size = New Size(279, 25)
        SubAnnounce2Lbl.TabIndex = 6
        SubAnnounce2Lbl.Text = "This is a Demo Announcement!!!!!"
        ' 
        ' SubAnnounce1
        ' 
        SubAnnounce1.AutoSize = True
        SubAnnounce1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubAnnounce1.ForeColor = Color.Gainsboro
        SubAnnounce1.Location = New Point(84, 30)
        SubAnnounce1.Name = "SubAnnounce1"
        SubAnnounce1.Size = New Size(199, 25)
        SubAnnounce1.TabIndex = 6
        SubAnnounce1.Text = "Renovating Going On...."
        ' 
        ' Announce3Lbl
        ' 
        Announce3Lbl.AutoSize = True
        Announce3Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Announce3Lbl.ForeColor = Color.White
        Announce3Lbl.Location = New Point(84, 131)
        Announce3Lbl.Name = "Announce3Lbl"
        Announce3Lbl.Size = New Size(364, 25)
        Announce3Lbl.TabIndex = 6
        Announce3Lbl.Text = "By: System Administrator / Date 2023-01-01"
        ' 
        ' Announce2Lbl
        ' 
        Announce2Lbl.AutoSize = True
        Announce2Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Announce2Lbl.ForeColor = Color.White
        Announce2Lbl.Location = New Point(84, 67)
        Announce2Lbl.Name = "Announce2Lbl"
        Announce2Lbl.Size = New Size(364, 25)
        Announce2Lbl.TabIndex = 6
        Announce2Lbl.Text = "By: System Administrator / Date 2023-01-01"
        ' 
        ' Announce1Lbl
        ' 
        Announce1Lbl.AutoSize = True
        Announce1Lbl.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Announce1Lbl.ForeColor = Color.White
        Announce1Lbl.Location = New Point(84, 5)
        Announce1Lbl.Name = "Announce1Lbl"
        Announce1Lbl.Size = New Size(364, 25)
        Announce1Lbl.TabIndex = 6
        Announce1Lbl.Text = "By: System Administrator / Date 2023-01-01"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.MessageIc
        PictureBox7.Location = New Point(32, 131)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(46, 49)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.MessageIc
        PictureBox6.Location = New Point(32, 67)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(46, 49)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.MessageIc
        PictureBox5.Location = New Point(32, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(46, 49)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Announcement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(1511, 740)
        Controls.Add(AnnouncementPanel)
        Controls.Add(Label3)
        Controls.Add(TopPanel)
        Controls.Add(PictureBox4)
        Controls.Add(LeftNavPanel)
        Controls.Add(TopNavPanel)
        Name = "Announcement"
        Text = "Announcement"
        LeftNavPanel.ResumeLayout(False)
        LeftNavPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TopNavPanel.ResumeLayout(False)
        TopNavPanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        AnnouncementPanel.ResumeLayout(False)
        AnnouncementPanel.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LeftNavPanel As Panel
    Friend WithEvents ReportsBtn As Button
    Friend WithEvents AnnounceBtn As Button
    Friend WithEvents RemindBtn As Button
    Friend WithEvents SchedBtn As Button
    Friend WithEvents DashBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TopNavPanel As Panel
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents WelcomeLbl As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AnnouncementPanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Announce1Lbl As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SubAnnounce1 As Label
    Friend WithEvents SubAnnounce2Lbl As Label
    Friend WithEvents Announce2Lbl As Label
    Friend WithEvents Announce3Lbl As Label
    Friend WithEvents SubAnnounce3Lbl As Label
End Class
