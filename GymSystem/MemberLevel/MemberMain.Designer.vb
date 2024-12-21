<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberMain
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
        Panel1 = New Panel()
        btnAnnouncement = New Button()
        btnReport = New Button()
        Reminder = New Button()
        SchedBtn = New Button()
        btnDash = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        LogoutBtn = New Button()
        ContentPanel = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnAnnouncement)
        Panel1.Controls.Add(btnReport)
        Panel1.Controls.Add(Reminder)
        Panel1.Controls.Add(SchedBtn)
        Panel1.Controls.Add(btnDash)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 73)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.MinimumSize = New Size(0, 1500)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 1500)
        Panel1.TabIndex = 0
        ' 
        ' btnAnnouncement
        ' 
        btnAnnouncement.BackColor = Color.Transparent
        btnAnnouncement.FlatAppearance.BorderSize = 0
        btnAnnouncement.FlatStyle = FlatStyle.Flat
        btnAnnouncement.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAnnouncement.ForeColor = SystemColors.ButtonHighlight
        btnAnnouncement.Image = Vector_5
        btnAnnouncement.ImageAlign = ContentAlignment.MiddleLeft
        btnAnnouncement.Location = New Point(37, 272)
        btnAnnouncement.Margin = New Padding(3, 2, 3, 2)
        btnAnnouncement.Name = "btnAnnouncement"
        btnAnnouncement.Size = New Size(167, 47)
        btnAnnouncement.TabIndex = 22
        btnAnnouncement.Text = "     Announcement"
        btnAnnouncement.TextAlign = ContentAlignment.MiddleLeft
        btnAnnouncement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAnnouncement.UseVisualStyleBackColor = False
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.Transparent
        btnReport.FlatAppearance.BorderSize = 0
        btnReport.FlatAppearance.MouseOverBackColor = Color.Khaki
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnReport.ForeColor = Color.White
        btnReport.Image = Vector3
        btnReport.ImageAlign = ContentAlignment.MiddleLeft
        btnReport.Location = New Point(37, 226)
        btnReport.Margin = New Padding(3, 2, 3, 2)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(167, 42)
        btnReport.TabIndex = 4
        btnReport.Text = "      Reports"
        btnReport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' Reminder
        ' 
        Reminder.BackColor = Color.Transparent
        Reminder.FlatAppearance.BorderSize = 0
        Reminder.FlatAppearance.MouseOverBackColor = Color.Khaki
        Reminder.FlatStyle = FlatStyle.Flat
        Reminder.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Reminder.ForeColor = Color.White
        Reminder.Image = Resources.Reminder
        Reminder.ImageAlign = ContentAlignment.MiddleLeft
        Reminder.Location = New Point(37, 180)
        Reminder.Margin = New Padding(3, 2, 3, 2)
        Reminder.Name = "Reminder"
        Reminder.Size = New Size(167, 42)
        Reminder.TabIndex = 4
        Reminder.Text = "        Notes"
        Reminder.TextImageRelation = TextImageRelation.ImageBeforeText
        Reminder.UseVisualStyleBackColor = False
        ' 
        ' SchedBtn
        ' 
        SchedBtn.BackColor = Color.Transparent
        SchedBtn.FlatAppearance.BorderSize = 0
        SchedBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        SchedBtn.FlatStyle = FlatStyle.Flat
        SchedBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        SchedBtn.ForeColor = Color.White
        SchedBtn.Image = calendar
        SchedBtn.ImageAlign = ContentAlignment.MiddleLeft
        SchedBtn.Location = New Point(37, 134)
        SchedBtn.Margin = New Padding(3, 2, 3, 2)
        SchedBtn.Name = "SchedBtn"
        SchedBtn.Size = New Size(167, 42)
        SchedBtn.TabIndex = 4
        SchedBtn.Text = "      Scheduling"
        SchedBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SchedBtn.UseVisualStyleBackColor = False
        ' 
        ' btnDash
        ' 
        btnDash.BackColor = Color.Transparent
        btnDash.FlatAppearance.BorderSize = 0
        btnDash.FlatAppearance.MouseOverBackColor = Color.Khaki
        btnDash.FlatStyle = FlatStyle.Flat
        btnDash.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDash.ForeColor = Color.White
        btnDash.Image = dashbo
        btnDash.ImageAlign = ContentAlignment.MiddleLeft
        btnDash.Location = New Point(37, 88)
        btnDash.Margin = New Padding(3, 2, 3, 2)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(167, 42)
        btnDash.TabIndex = 4
        btnDash.Text = "     Dashboard"
        btnDash.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDash.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(110, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 38)
        Label1.TabIndex = 3
        Label1.Text = "JJ Fitness" & vbCrLf & "Gym"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(24, 4)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        Panel2.Controls.Add(LogoutBtn)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(781, 73)
        Panel2.TabIndex = 1
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        LogoutBtn.BackColor = Color.Transparent
        LogoutBtn.FlatAppearance.BorderSize = 0
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        LogoutBtn.ForeColor = SystemColors.ButtonHighlight
        LogoutBtn.Image = Vector_21
        LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogoutBtn.Location = New Point(683, 12)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(86, 50)
        LogoutBtn.TabIndex = 6
        LogoutBtn.Text = " Logout"
        LogoutBtn.TextAlign = ContentAlignment.MiddleLeft
        LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' ContentPanel
        ' 
        ContentPanel.Dock = DockStyle.Fill
        ContentPanel.Location = New Point(204, 73)
        ContentPanel.Margin = New Padding(3, 2, 3, 2)
        ContentPanel.Name = "ContentPanel"
        ContentPanel.Size = New Size(577, 337)
        ContentPanel.TabIndex = 2
        ' 
        ' MemberMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(781, 410)
        Controls.Add(ContentPanel)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MemberMain"
        Text = "MemberMain"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents Reminder As Button
    Friend WithEvents SchedBtn As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents btnAnnouncement As Button
End Class
