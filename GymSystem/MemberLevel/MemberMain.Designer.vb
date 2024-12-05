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
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        SchedBtn = New Button()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ContentPanel = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(SchedBtn)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, -2)
        Panel1.MinimumSize = New Size(0, 2000)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(178, 2000)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.Khaki
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.White
        Button5.Image = My.Resources.Resources.Vector3
        Button5.ImageAlign = ContentAlignment.MiddleRight
        Button5.Location = New Point(3, 396)
        Button5.Name = "Button5"
        Button5.Size = New Size(175, 56)
        Button5.TabIndex = 4
        Button5.Text = "   Reports"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.Khaki
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.Commercial_1
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(3, 334)
        Button4.Name = "Button4"
        Button4.Size = New Size(175, 56)
        Button4.TabIndex = 4
        Button4.Text = "  Announcements"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.Khaki
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.Reminder
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(3, 272)
        Button3.Name = "Button3"
        Button3.Size = New Size(175, 56)
        Button3.TabIndex = 4
        Button3.Text = "   Reminders"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' SchedBtn
        ' 
        SchedBtn.BackColor = Color.Transparent
        SchedBtn.FlatAppearance.BorderSize = 0
        SchedBtn.FlatAppearance.MouseOverBackColor = Color.Khaki
        SchedBtn.FlatStyle = FlatStyle.Flat
        SchedBtn.ForeColor = Color.White
        SchedBtn.Image = My.Resources.Resources.calendar
        SchedBtn.ImageAlign = ContentAlignment.MiddleRight
        SchedBtn.Location = New Point(3, 210)
        SchedBtn.Name = "SchedBtn"
        SchedBtn.Size = New Size(175, 56)
        SchedBtn.TabIndex = 4
        SchedBtn.Text = "   Scheduling"
        SchedBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        SchedBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.Khaki
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.dashbo
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(3, 148)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 56)
        Button1.TabIndex = 4
        Button1.Text = "   Dashboard"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
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
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SchedBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ContentPanel As Panel
End Class
