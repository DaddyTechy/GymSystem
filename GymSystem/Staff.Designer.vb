<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        AdminLL = New LinkLabel()
        MemberLL = New LinkLabel()
        LoginBtn = New Button()
        PassBox = New TextBox()
        IDBox = New TextBox()
        LabelPass = New Label()
        LabelID = New Label()
        LabelSign = New Label()
        Splitter1 = New Splitter()
        Splitter2 = New Splitter()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(663, 160)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' ForgotLL
        ' 
        ForgotLL.AutoSize = True
        ForgotLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ForgotLL.Location = New Point(376, 409)
        ForgotLL.Name = "ForgotLL"
        ForgotLL.Size = New Size(125, 20)
        ForgotLL.TabIndex = 14
        ForgotLL.TabStop = True
        ForgotLL.Text = "Forgot Password?"
        ForgotLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' AdminLL
        ' 
        AdminLL.AutoSize = True
        AdminLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        AdminLL.Location = New Point(367, 527)
        AdminLL.Name = "AdminLL"
        AdminLL.Size = New Size(94, 20)
        AdminLL.TabIndex = 15
        AdminLL.TabStop = True
        AdminLL.Text = "Admin Login"
        AdminLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' MemberLL
        ' 
        MemberLL.AutoSize = True
        MemberLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        MemberLL.Location = New Point(210, 527)
        MemberLL.Name = "MemberLL"
        MemberLL.Size = New Size(106, 20)
        MemberLL.TabIndex = 16
        MemberLL.TabStop = True
        MemberLL.Text = "Member Login"
        MemberLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        LoginBtn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LoginBtn.ForeColor = SystemColors.ActiveCaptionText
        LoginBtn.Location = New Point(210, 455)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(245, 51)
        LoginBtn.TabIndex = 13
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' PassBox
        ' 
        PassBox.BackColor = Color.Gray
        PassBox.BorderStyle = BorderStyle.FixedSingle
        PassBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PassBox.ForeColor = Color.White
        PassBox.Location = New Point(152, 365)
        PassBox.Name = "PassBox"
        PassBox.Size = New Size(349, 30)
        PassBox.TabIndex = 10
        ' 
        ' IDBox
        ' 
        IDBox.BackColor = Color.Gray
        IDBox.BorderStyle = BorderStyle.FixedSingle
        IDBox.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDBox.ForeColor = Color.White
        IDBox.Location = New Point(152, 276)
        IDBox.Name = "IDBox"
        IDBox.Size = New Size(349, 30)
        IDBox.TabIndex = 11
        ' 
        ' LabelPass
        ' 
        LabelPass.AutoSize = True
        LabelPass.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPass.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelPass.Location = New Point(152, 341)
        LabelPass.Name = "LabelPass"
        LabelPass.Size = New Size(90, 21)
        LabelPass.TabIndex = 8
        LabelPass.Text = "Password*"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelID.Location = New Point(152, 251)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(100, 21)
        LabelID.TabIndex = 9
        LabelID.Text = "ID Number*"
        ' 
        ' LabelSign
        ' 
        LabelSign.AutoSize = True
        LabelSign.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LabelSign.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelSign.Location = New Point(152, 160)
        LabelSign.Name = "LabelSign"
        LabelSign.Size = New Size(190, 39)
        LabelSign.TabIndex = 7
        LabelSign.Text = "Staff Login"
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Margin = New Padding(3, 4, 3, 4)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 711)
        Splitter1.TabIndex = 18
        Splitter1.TabStop = False
        ' 
        ' Splitter2
        ' 
        Splitter2.Location = New Point(3, 0)
        Splitter2.Margin = New Padding(3, 4, 3, 4)
        Splitter2.Name = "Splitter2"
        Splitter2.Size = New Size(3, 711)
        Splitter2.TabIndex = 19
        Splitter2.TabStop = False
        ' 
        ' Staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(1037, 711)
        Controls.Add(Splitter2)
        Controls.Add(Splitter1)
        Controls.Add(PictureBox1)
        Controls.Add(ForgotLL)
        Controls.Add(AdminLL)
        Controls.Add(MemberLL)
        Controls.Add(LoginBtn)
        Controls.Add(PassBox)
        Controls.Add(IDBox)
        Controls.Add(LabelPass)
        Controls.Add(LabelID)
        Controls.Add(LabelSign)
        MaximumSize = New Size(1055, 758)
        MinimumSize = New Size(1055, 758)
        Name = "Staff"
        Text = "Staff"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ForgotLL As LinkLabel
    Friend WithEvents AdminLL As LinkLabel
    Friend WithEvents MemberLL As LinkLabel
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PassBox As TextBox
    Friend WithEvents IDBox As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelSign As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Splitter2 As Splitter
End Class
