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
        RichTextBox2 = New RichTextBox()
        LeftNavPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TopNavPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TopPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
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
        ' RichTextBox2
        ' 
        RichTextBox2.Anchor = AnchorStyles.Top
        RichTextBox2.BackColor = Color.DimGray
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Location = New Point(443, 268)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(1000, 364)
        RichTextBox2.TabIndex = 27
        RichTextBox2.Text = ""
        ' 
        ' Announcement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(1511, 740)
        Controls.Add(RichTextBox2)
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
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
