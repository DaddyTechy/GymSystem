<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        LabelSign = New Label()
        LabelID = New Label()
        LabelPass = New Label()
        IDBox = New TextBox()
        PassBox = New TextBox()
        CBMe = New CheckBox()
        LoginBtn = New Button()
        StaffLL = New LinkLabel()
        AdminLL = New LinkLabel()
        ForgotLL = New LinkLabel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        RegisterBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelSign
        ' 
        LabelSign.AutoSize = True
        LabelSign.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LabelSign.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelSign.Location = New Point(122, 105)
        LabelSign.Name = "LabelSign"
        LabelSign.Size = New Size(197, 31)
        LabelSign.TabIndex = 0
        LabelSign.Text = "Member Login"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelID.Location = New Point(122, 173)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(83, 17)
        LabelID.TabIndex = 1
        LabelID.Text = "ID Number*"
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPass.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelPass.Location = New Point(122, 241)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(74, 17)
        LabelPass.TabIndex = 1
        LabelPass.Text = "Password*"
        ' 
        ' IDBox
        ' 
        IDBox.BackColor = Color.Gray
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.Cursor = Cursors.IBeam
        IDBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDBox.ForeColor = Color.White
        IDBox.Location = New Point(122, 191)
        IDBox.Margin = New Padding(3, 2, 3, 2)
        IDBox.Name = "IDBox"
        IDBox.Size = New Size(306, 26)
        IDBox.TabIndex = 2
        ' 
        ' PassBox
        ' 
        PassBox.BackColor = Color.Gray
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PassBox.ForeColor = Color.White
        PassBox.Location = New Point(122, 259)
        PassBox.Margin = New Padding(3, 2, 3, 2)
        PassBox.Name = "PassBox"
        PassBox.Size = New Size(306, 26)
        PassBox.TabIndex = 2
        ' 
        ' CBMe
        ' 
        CBMe.AutoSize = True
        CBMe.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBMe.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CBMe.Location = New Point(122, 292)
        CBMe.Margin = New Padding(3, 2, 3, 2)
        CBMe.Name = "CBMe"
        CBMe.Size = New Size(94, 17)
        CBMe.TabIndex = 3
        CBMe.Text = "Remember me"
        CBMe.UseVisualStyleBackColor = True
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        LoginBtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LoginBtn.ForeColor = SystemColors.ActiveCaptionText
        LoginBtn.Location = New Point(173, 326)
        LoginBtn.Margin = New Padding(3, 2, 3, 2)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(214, 38)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' StaffLL
        ' 
        StaffLL.AutoSize = True
        StaffLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        StaffLL.Location = New Point(178, 380)
        StaffLL.Name = "StaffLL"
        StaffLL.Size = New Size(64, 15)
        StaffLL.TabIndex = 5
        StaffLL.TabStop = True
        StaffLL.Text = "Staff Login"
        StaffLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' AdminLL
        ' 
        AdminLL.AutoSize = True
        AdminLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        AdminLL.Location = New Point(310, 380)
        AdminLL.Name = "AdminLL"
        AdminLL.Size = New Size(76, 15)
        AdminLL.TabIndex = 5
        AdminLL.TabStop = True
        AdminLL.Text = "Admin Login"
        AdminLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' ForgotLL
        ' 
        ForgotLL.AutoSize = True
        ForgotLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ForgotLL.Location = New Point(318, 292)
        ForgotLL.Name = "ForgotLL"
        ForgotLL.Size = New Size(100, 15)
        ForgotLL.TabIndex = 5
        ForgotLL.TabStop = True
        ForgotLL.Text = "Forgot Password?"
        ForgotLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(569, 105)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(187, 434)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 14)
        Label1.TabIndex = 8
        Label1.Text = "Not a Member?"
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        RegisterBtn.FlatAppearance.BorderColor = Color.Yellow
        RegisterBtn.FlatAppearance.MouseDownBackColor = Color.Yellow
        RegisterBtn.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        RegisterBtn.ForeColor = SystemColors.ActiveCaptionText
        RegisterBtn.Location = New Point(280, 423)
        RegisterBtn.Margin = New Padding(3, 2, 3, 2)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(81, 34)
        RegisterBtn.TabIndex = 9
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = False
        ' 
        ' Member
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(909, 541)
        Controls.Add(RegisterBtn)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(ForgotLL)
        Controls.Add(AdminLL)
        Controls.Add(StaffLL)
        Controls.Add(LoginBtn)
        Controls.Add(CBMe)
        Controls.Add(PassBox)
        Controls.Add(IDBox)
        Controls.Add(LabelPass)
        Controls.Add(LabelID)
        Controls.Add(LabelSign)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(925, 580)
        MinimumSize = New Size(925, 580)
        Name = "Member"
        Text = "Member Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelSign As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents CBMe As CheckBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents StaffLL As LinkLabel
    Friend WithEvents AdminLL As LinkLabel
    Friend WithEvents ForgotLL As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RegisterBtn As Button

End Class
