<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        PictureBox1 = New PictureBox()
        ForgotLL = New LinkLabel()
        StaffLL = New LinkLabel()
        LoginBtn = New Button()
        CBMe = New CheckBox()
        PassBox = New TextBox()
        IDBox = New TextBox()
        LabelPass = New Label()
        LabelID = New Label()
        LabelSign = New Label()
        MemberLL = New LinkLabel()
        lblRole = New Label()
        AdminRole = New ComboBox()
        templogin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(580, 120)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' ForgotLL
        ' 
        ForgotLL.AutoSize = True
        ForgotLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ForgotLL.Location = New Point(329, 307)
        ForgotLL.Name = "ForgotLL"
        ForgotLL.Size = New Size(100, 15)
        ForgotLL.TabIndex = 25
        ForgotLL.TabStop = True
        ForgotLL.Text = "Forgot Password?"
        ForgotLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' StaffLL
        ' 
        StaffLL.AutoSize = True
        StaffLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        StaffLL.Location = New Point(321, 395)
        StaffLL.Name = "StaffLL"
        StaffLL.Size = New Size(64, 15)
        StaffLL.TabIndex = 26
        StaffLL.TabStop = True
        StaffLL.Text = "Staff Login"
        StaffLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        LoginBtn.FlatStyle = FlatStyle.Popup
        LoginBtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LoginBtn.ForeColor = SystemColors.ActiveCaptionText
        LoginBtn.Location = New Point(184, 341)
        LoginBtn.Margin = New Padding(3, 2, 3, 2)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(214, 38)
        LoginBtn.TabIndex = 24
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' CBMe
        ' 
        CBMe.AutoSize = True
        CBMe.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBMe.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CBMe.Location = New Point(133, 307)
        CBMe.Margin = New Padding(3, 2, 3, 2)
        CBMe.Name = "CBMe"
        CBMe.Size = New Size(94, 17)
        CBMe.TabIndex = 23
        CBMe.Text = "Remember me"
        CBMe.UseVisualStyleBackColor = True
        ' 
        ' PassBox
        ' 
        PassBox.BackColor = Color.LightGray
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PassBox.ForeColor = Color.White
        PassBox.Location = New Point(133, 274)
        PassBox.Margin = New Padding(3, 2, 3, 2)
        PassBox.Name = "PassBox"
        PassBox.Size = New Size(306, 26)
        PassBox.TabIndex = 21
        ' 
        ' IDBox
        ' 
        IDBox.BackColor = Color.LightGray
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDBox.ForeColor = Color.White
        IDBox.Location = New Point(133, 207)
        IDBox.Margin = New Padding(3, 2, 3, 2)
        IDBox.Name = "IDBox"
        IDBox.PlaceholderText = "ex. 1"
        IDBox.Size = New Size(306, 26)
        IDBox.TabIndex = 22
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPass.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelPass.Location = New Point(133, 256)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(74, 17)
        LabelPass.TabIndex = 19
        LabelPass.Text = "Password*"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelID.Location = New Point(133, 188)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(83, 17)
        LabelID.TabIndex = 20
        LabelID.Text = "ID Number*"
        ' 
        ' LabelSign
        ' 
        LabelSign.AutoSize = True
        LabelSign.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LabelSign.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelSign.Location = New Point(133, 72)
        LabelSign.Name = "LabelSign"
        LabelSign.Size = New Size(174, 31)
        LabelSign.TabIndex = 18
        LabelSign.Text = "Admin Login"
        ' 
        ' MemberLL
        ' 
        MemberLL.AutoSize = True
        MemberLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        MemberLL.Location = New Point(184, 395)
        MemberLL.Name = "MemberLL"
        MemberLL.Size = New Size(85, 15)
        MemberLL.TabIndex = 27
        MemberLL.TabStop = True
        MemberLL.Text = "Member Login"
        MemberLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblRole.Location = New Point(133, 125)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(89, 17)
        lblRole.TabIndex = 41
        lblRole.Text = "Admin Type*"
        ' 
        ' AdminRole
        ' 
        AdminRole.BackColor = Color.DimGray
        AdminRole.DropDownStyle = ComboBoxStyle.DropDownList
        AdminRole.FlatStyle = FlatStyle.Flat
        AdminRole.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminRole.ForeColor = Color.White
        AdminRole.FormattingEnabled = True
        AdminRole.Items.AddRange(New Object() {"Normal Admin", "Super Admin"})
        AdminRole.Location = New Point(133, 145)
        AdminRole.Name = "AdminRole"
        AdminRole.Size = New Size(88, 23)
        AdminRole.TabIndex = 43
        ' 
        ' templogin
        ' 
        templogin.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        templogin.FlatStyle = FlatStyle.Popup
        templogin.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        templogin.ForeColor = SystemColors.ActiveCaptionText
        templogin.Location = New Point(372, 444)
        templogin.Margin = New Padding(3, 2, 3, 2)
        templogin.Name = "templogin"
        templogin.Size = New Size(214, 38)
        templogin.TabIndex = 44
        templogin.Text = "ito muna"
        templogin.UseVisualStyleBackColor = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(909, 541)
        Controls.Add(templogin)
        Controls.Add(AdminRole)
        Controls.Add(lblRole)
        Controls.Add(PictureBox1)
        Controls.Add(ForgotLL)
        Controls.Add(StaffLL)
        Controls.Add(MemberLL)
        Controls.Add(LoginBtn)
        Controls.Add(CBMe)
        Controls.Add(PassBox)
        Controls.Add(IDBox)
        Controls.Add(LabelPass)
        Controls.Add(LabelID)
        Controls.Add(LabelSign)
        MaximumSize = New Size(925, 580)
        MinimumSize = New Size(925, 580)
        Name = "Admin"
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ForgotLL As LinkLabel
    Friend WithEvents StaffLL As LinkLabel
    Friend WithEvents LoginBtn As Button
    Friend WithEvents CBMe As CheckBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents IDBox As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelSign As Label
    Friend WithEvents MemberLL As LinkLabel
    Friend WithEvents lblRole As Label
    Friend WithEvents AdminRole As ComboBox
    Friend WithEvents templogin As Button
End Class
