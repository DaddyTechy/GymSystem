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
        btnReport = New Button()
        announcebtn = New Button()
        Reminder = New Button()
        SchedBtn = New Button()
        btnDash = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ContentPanel = New Panel()
        LogoutBtn = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnReport)
        Panel1.Controls.Add(announcebtn)
        Panel1.Controls.Add(Reminder)
        Panel1.Controls.Add(SchedBtn)
        Panel1.Controls.Add(btnDash)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, -2)
        Panel1.MinimumSize = New Size(0, 2000)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(178, 2000)
        Panel1.TabIndex = 0
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.Transparent
        btnReport.FlatAppearance.BorderSize = 0
        btnReport.FlatAppearance.MouseOverBackColor = Color.Khaki
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.ForeColor = Color.White
        btnReport.Image = Vector3
        btnReport.ImageAlign = ContentAlignment.MiddleRight
        btnReport.Location = New Point(3, 396)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(175, 56)
        btnReport.TabIndex = 4
        btnReport.Text = "   Reports"
        btnReport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' announcebtn
        ' 
        announcebtn.BackColor = Color.Transparent
        announcebtn.FlatAppearance.BorderSize = 0
        announcebtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        announcebtn.FlatStyle = FlatStyle.Flat
        announcebtn.ForeColor = Color.White
        announcebtn.Image = Commercial_1
        announcebtn.ImageAlign = ContentAlignment.MiddleRight
        announcebtn.Location = New Point(3, 334)
        announcebtn.Name = "announcebtn"
        announcebtn.Size = New Size(175, 56)
        announcebtn.TabIndex = 4
        announcebtn.Text = "  Announcements"
        announcebtn.TextImageRelation = TextImageRelation.ImageBeforeText
        announcebtn.UseVisualStyleBackColor = False
        ' 
        ' Reminder
        ' 
        Reminder.BackColor = Color.Transparent
        Reminder.FlatAppearance.BorderSize = 0
        Reminder.FlatAppearance.MouseOverBackColor = Color.Khaki
        Reminder.FlatStyle = FlatStyle.Flat
        Reminder.ForeColor = Color.White
        Reminder.Image = Resources.Reminder
        Reminder.ImageAlign = ContentAlignment.MiddleRight
        Reminder.Location = New Point(3, 272)
        Reminder.Name = "Reminder"
        Reminder.Size = New Size(175, 56)
        Reminder.TabIndex = 4
        Reminder.Text = "   Reminders"
        Reminder.TextImageRelation = TextImageRelation.ImageBeforeText
        Reminder.UseVisualStyleBackColor = False
        ' 
        ' SchedBtn
        ' 
        SchedBtn.BackColor = Color.Transparent
        SchedBtn.FlatAppearance.BorderSize = 0
        SchedBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        SchedBtn.FlatStyle = FlatStyle.Flat
        SchedBtn.ForeColor = Color.White
        SchedBtn.Image = calendar
        SchedBtn.ImageAlign = ContentAlignment.MiddleRight
        SchedBtn.Location = New Point(3, 210)
        SchedBtn.Name = "SchedBtn"
        SchedBtn.Size = New Size(175, 56)
        SchedBtn.TabIndex = 4
        SchedBtn.Text = "   Scheduling"
        SchedBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SchedBtn.UseVisualStyleBackColor = False
        ' 
        ' btnDash
        ' 
        btnDash.BackColor = Color.Transparent
        btnDash.FlatAppearance.BorderSize = 0
        btnDash.FlatAppearance.MouseOverBackColor = Color.Khaki
        btnDash.FlatStyle = FlatStyle.Flat
        btnDash.ForeColor = Color.White
        btnDash.Image = dashbo
        btnDash.ImageAlign = ContentAlignment.MiddleRight
        btnDash.Location = New Point(3, 148)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(175, 56)
        btnDash.TabIndex = 4
        btnDash.Text = "   Dashboard"
        btnDash.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDash.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(85, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 44)
        Label1.TabIndex = 3
        Label1.Text = "JJ Fitness" & vbCrLf & "Gym"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 94)
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
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(893, 97)
        Panel2.TabIndex = 1
        ' 
        ' ContentPanel
        ' 
        ContentPanel.Location = New Point(204, 127)
        ContentPanel.MinimumSize = New Size(1920, 1080)
        ContentPanel.Name = "ContentPanel"
        ContentPanel.Size = New Size(1920, 1080)
        ContentPanel.TabIndex = 2
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
        LogoutBtn.Location = New Point(792, -2)
        LogoutBtn.Margin = New Padding(3, 4, 3, 4)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(98, 67)
        LogoutBtn.TabIndex = 6
        LogoutBtn.Text = " Logout"
        LogoutBtn.TextAlign = ContentAlignment.MiddleLeft
        LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' MemberMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(893, 547)
        Controls.Add(ContentPanel)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "MemberMain"
        Text = "MemberMain"
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
    Friend WithEvents announcebtn As Button
    Friend WithEvents Reminder As Button
    Friend WithEvents SchedBtn As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents LogoutBtn As Button
End Class
