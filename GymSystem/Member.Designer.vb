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
        LoginBtn = New Button()
        IDBox = New TextBox()
        PassBox = New TextBox()
        ForgotLL = New LinkLabel()
        StaffLL = New LinkLabel()
        AdminLL = New LinkLabel()
        MeCB = New CheckBox()
        IDLbl = New Label()
        PassLbl = New Label()
        JoinBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        LoginBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        LoginBtn.Font = New Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LoginBtn.ForeColor = Color.Black
        LoginBtn.Location = New Point(370, 416)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(130, 50)
        LoginBtn.TabIndex = 0
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' IDBox
        ' 
        IDBox.BackColor = Color.Silver
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.Location = New Point(200, 223)
        IDBox.Name = "IDBox"
        IDBox.Size = New Size(300, 27)
        IDBox.TabIndex = 1
        ' 
        ' PassBox
        ' 
        PassBox.BackColor = Color.Silver
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.Location = New Point(200, 293)
        PassBox.Name = "PassBox"
        PassBox.Size = New Size(300, 27)
        PassBox.TabIndex = 2
        ' 
        ' ForgotLL
        ' 
        ForgotLL.ActiveLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        ForgotLL.AutoSize = True
        ForgotLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        ForgotLL.Location = New Point(375, 330)
        ForgotLL.Name = "ForgotLL"
        ForgotLL.Size = New Size(125, 20)
        ForgotLL.TabIndex = 3
        ForgotLL.TabStop = True
        ForgotLL.Text = "Forgot Password?"
        ForgotLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        ' 
        ' StaffLL
        ' 
        StaffLL.ActiveLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        StaffLL.AutoSize = True
        StaffLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        StaffLL.Location = New Point(249, 479)
        StaffLL.Name = "StaffLL"
        StaffLL.Size = New Size(81, 20)
        StaffLL.TabIndex = 3
        StaffLL.TabStop = True
        StaffLL.Text = "Staff Login"
        StaffLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        ' 
        ' AdminLL
        ' 
        AdminLL.ActiveLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        AdminLL.AutoSize = True
        AdminLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        AdminLL.Location = New Point(370, 479)
        AdminLL.Name = "AdminLL"
        AdminLL.Size = New Size(94, 20)
        AdminLL.TabIndex = 3
        AdminLL.TabStop = True
        AdminLL.Text = "Admin Login"
        AdminLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        ' 
        ' MeCB
        ' 
        MeCB.AutoSize = True
        MeCB.Font = New Font("UD Digi Kyokasho NK-R", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        MeCB.ForeColor = Color.White
        MeCB.Location = New Point(200, 331)
        MeCB.Name = "MeCB"
        MeCB.Size = New Size(119, 19)
        MeCB.TabIndex = 4
        MeCB.Text = "Remember Me"
        MeCB.UseVisualStyleBackColor = True
        ' 
        ' IDLbl
        ' 
        IDLbl.AutoSize = True
        IDLbl.Font = New Font("UD Digi Kyokasho NK-R", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        IDLbl.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        IDLbl.Location = New Point(200, 205)
        IDLbl.Name = "IDLbl"
        IDLbl.Size = New Size(91, 15)
        IDLbl.TabIndex = 5
        IDLbl.Text = "ID Number*"
        ' 
        ' PassLbl
        ' 
        PassLbl.AutoSize = True
        PassLbl.Font = New Font("UD Digi Kyokasho NK-R", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        PassLbl.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        PassLbl.Location = New Point(200, 275)
        PassLbl.Name = "PassLbl"
        PassLbl.Size = New Size(84, 15)
        PassLbl.TabIndex = 5
        PassLbl.Text = "Password*"
        ' 
        ' JoinBtn
        ' 
        JoinBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        JoinBtn.Font = New Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        JoinBtn.ForeColor = Color.Black
        JoinBtn.Location = New Point(200, 416)
        JoinBtn.Name = "JoinBtn"
        JoinBtn.Size = New Size(130, 50)
        JoinBtn.TabIndex = 0
        JoinBtn.Text = "Join Now!"
        JoinBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("UD Digi Kyokasho NK-R", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(200, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 39)
        Label1.TabIndex = 5
        Label1.Text = "Sign-In"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(539, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(436, 508)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Member
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(1006, 721)
        Controls.Add(PictureBox1)
        Controls.Add(PassLbl)
        Controls.Add(Label1)
        Controls.Add(IDLbl)
        Controls.Add(MeCB)
        Controls.Add(AdminLL)
        Controls.Add(StaffLL)
        Controls.Add(ForgotLL)
        Controls.Add(PassBox)
        Controls.Add(IDBox)
        Controls.Add(JoinBtn)
        Controls.Add(LoginBtn)
        Name = "Member"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents IDBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents ForgotLL As LinkLabel
    Friend WithEvents StaffLL As LinkLabel
    Friend WithEvents AdminLL As LinkLabel
    Friend WithEvents MeCB As CheckBox
    Friend WithEvents IDLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents JoinBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
