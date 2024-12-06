<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newAdminform
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
        DTPhiredate = New DateTimePicker()
        CBStatus = New ComboBox()
        txtbxExp = New TextBox()
        Label5 = New Label()
        txtbxSpecial = New TextBox()
        Label6 = New Label()
        txtbxSalary = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtbxPNumber = New TextBox()
        Label1 = New Label()
        txtbxLname = New TextBox()
        txtbxMname = New TextBox()
        txtbxFname = New TextBox()
        btnBack = New Button()
        btnSubmit = New Button()
        txtxtbxEmail = New TextBox()
        lblEmail = New Label()
        lblRole = New Label()
        PictureBox1 = New PictureBox()
        LabelSign = New Label()
        txtbxAdminPass2 = New TextBox()
        Label2 = New Label()
        txtbxAdminPass = New TextBox()
        Label8 = New Label()
        txtbxAdminName = New TextBox()
        Label9 = New Label()
        CBRole = New ComboBox()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DTPhiredate
        ' 
        DTPhiredate.CalendarFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DTPhiredate.CalendarMonthBackground = Color.LightGray
        DTPhiredate.Location = New Point(90, 425)
        DTPhiredate.Name = "DTPhiredate"
        DTPhiredate.Size = New Size(200, 23)
        DTPhiredate.TabIndex = 115
        ' 
        ' CBStatus
        ' 
        CBStatus.BackColor = Color.LightGray
        CBStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CBStatus.FlatStyle = FlatStyle.Flat
        CBStatus.FormattingEnabled = True
        CBStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        CBStatus.Location = New Point(487, 184)
        CBStatus.Name = "CBStatus"
        CBStatus.Size = New Size(121, 23)
        CBStatus.TabIndex = 114
        ' 
        ' txtbxExp
        ' 
        txtbxExp.BackColor = Color.LightGray
        txtbxExp.BorderStyle = BorderStyle.FixedSingle
        txtbxExp.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxExp.ForeColor = Color.Black
        txtbxExp.Location = New Point(90, 479)
        txtbxExp.Margin = New Padding(3, 2, 3, 2)
        txtbxExp.Multiline = True
        txtbxExp.Name = "txtbxExp"
        txtbxExp.PlaceholderText = "ex. 9 years of experience in Cybersecurity"
        txtbxExp.Size = New Size(339, 23)
        txtbxExp.TabIndex = 113
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Location = New Point(90, 460)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 17)
        Label5.TabIndex = 112
        Label5.Text = "Experience*"
        ' 
        ' txtbxSpecial
        ' 
        txtbxSpecial.BackColor = Color.LightGray
        txtbxSpecial.BorderStyle = BorderStyle.FixedSingle
        txtbxSpecial.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxSpecial.ForeColor = Color.Black
        txtbxSpecial.Location = New Point(90, 302)
        txtbxSpecial.Margin = New Padding(3, 2, 3, 2)
        txtbxSpecial.Name = "txtbxSpecial"
        txtbxSpecial.PlaceholderText = "ex. Network Security"
        txtbxSpecial.Size = New Size(339, 26)
        txtbxSpecial.TabIndex = 111
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label6.Location = New Point(90, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 17)
        Label6.TabIndex = 110
        Label6.Text = "Specialization*"
        ' 
        ' txtbxSalary
        ' 
        txtbxSalary.BackColor = Color.LightGray
        txtbxSalary.BorderStyle = BorderStyle.FixedSingle
        txtbxSalary.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxSalary.ForeColor = Color.Black
        txtbxSalary.Location = New Point(91, 363)
        txtbxSalary.Margin = New Padding(3, 2, 3, 2)
        txtbxSalary.Name = "txtbxSalary"
        txtbxSalary.Size = New Size(339, 26)
        txtbxSalary.TabIndex = 109
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label7.Location = New Point(91, 344)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(53, 17)
        Label7.TabIndex = 108
        Label7.Text = "Salary*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(486, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 17)
        Label4.TabIndex = 107
        Label4.Text = "Status*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(90, 405)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 17)
        Label3.TabIndex = 106
        Label3.Text = "Hire Date*"
        ' 
        ' txtbxPNumber
        ' 
        txtbxPNumber.BackColor = Color.LightGray
        txtbxPNumber.BorderStyle = BorderStyle.FixedSingle
        txtbxPNumber.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxPNumber.ForeColor = Color.Black
        txtbxPNumber.Location = New Point(90, 241)
        txtbxPNumber.Margin = New Padding(3, 2, 3, 2)
        txtbxPNumber.Name = "txtbxPNumber"
        txtbxPNumber.PlaceholderText = "ex. 09123456789"
        txtbxPNumber.Size = New Size(339, 26)
        txtbxPNumber.TabIndex = 103
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(90, 222)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 17)
        Label1.TabIndex = 102
        Label1.Text = "Phone Number*"
        ' 
        ' txtbxLname
        ' 
        txtbxLname.BackColor = Color.LightGray
        txtbxLname.BorderStyle = BorderStyle.FixedSingle
        txtbxLname.CharacterCasing = CharacterCasing.Upper
        txtbxLname.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxLname.ForeColor = Color.Black
        txtbxLname.Location = New Point(320, 123)
        txtbxLname.Margin = New Padding(3, 2, 3, 2)
        txtbxLname.Name = "txtbxLname"
        txtbxLname.Size = New Size(109, 26)
        txtbxLname.TabIndex = 101
        ' 
        ' txtbxMname
        ' 
        txtbxMname.BackColor = Color.LightGray
        txtbxMname.BorderStyle = BorderStyle.FixedSingle
        txtbxMname.CharacterCasing = CharacterCasing.Upper
        txtbxMname.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxMname.ForeColor = Color.Black
        txtbxMname.Location = New Point(205, 123)
        txtbxMname.Margin = New Padding(3, 2, 3, 2)
        txtbxMname.Name = "txtbxMname"
        txtbxMname.Size = New Size(109, 26)
        txtbxMname.TabIndex = 100
        ' 
        ' txtbxFname
        ' 
        txtbxFname.BackColor = Color.LightGray
        txtbxFname.BorderStyle = BorderStyle.FixedSingle
        txtbxFname.CharacterCasing = CharacterCasing.Upper
        txtbxFname.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxFname.ForeColor = Color.Black
        txtbxFname.Location = New Point(90, 123)
        txtbxFname.Margin = New Padding(3, 2, 3, 2)
        txtbxFname.Name = "txtbxFname"
        txtbxFname.Size = New Size(109, 26)
        txtbxFname.TabIndex = 99
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ActiveCaptionText
        btnBack.Location = New Point(91, 40)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(65, 29)
        btnBack.TabIndex = 98
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSubmit.ForeColor = SystemColors.ActiveCaptionText
        btnSubmit.Location = New Point(709, 483)
        btnSubmit.Margin = New Padding(3, 2, 3, 2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(109, 38)
        btnSubmit.TabIndex = 97
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtxtbxEmail
        ' 
        txtxtbxEmail.BackColor = Color.LightGray
        txtxtbxEmail.BorderStyle = BorderStyle.FixedSingle
        txtxtbxEmail.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtxtbxEmail.ForeColor = Color.Black
        txtxtbxEmail.Location = New Point(90, 182)
        txtxtbxEmail.Margin = New Padding(3, 2, 3, 2)
        txtxtbxEmail.Name = "txtxtbxEmail"
        txtxtbxEmail.PlaceholderText = "ex. example@xxx.com"
        txtxtbxEmail.Size = New Size(339, 26)
        txtxtbxEmail.TabIndex = 96
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblEmail.Location = New Point(90, 163)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(47, 17)
        lblEmail.TabIndex = 94
        lblEmail.Text = "Email*"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblRole.Location = New Point(90, 104)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(182, 17)
        lblRole.TabIndex = 95
        lblRole.Text = "Full Name (FN*, MI/MN, LN*)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(275, 20)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 93
        PictureBox1.TabStop = False
        ' 
        ' LabelSign
        ' 
        LabelSign.AutoSize = True
        LabelSign.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSign.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelSign.Location = New Point(347, 40)
        LabelSign.Name = "LabelSign"
        LabelSign.Size = New Size(347, 31)
        LabelSign.TabIndex = 92
        LabelSign.Text = "Create New Admin Account"
        ' 
        ' txtbxAdminPass2
        ' 
        txtbxAdminPass2.BackColor = Color.LightGray
        txtbxAdminPass2.BorderStyle = BorderStyle.FixedSingle
        txtbxAdminPass2.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxAdminPass2.ForeColor = Color.Black
        txtbxAdminPass2.Location = New Point(482, 424)
        txtbxAdminPass2.Margin = New Padding(3, 2, 3, 2)
        txtbxAdminPass2.Name = "txtbxAdminPass2"
        txtbxAdminPass2.Size = New Size(339, 26)
        txtbxAdminPass2.TabIndex = 121
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(482, 405)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 17)
        Label2.TabIndex = 120
        Label2.Text = "Confirm password*"
        ' 
        ' txtbxAdminPass
        ' 
        txtbxAdminPass.BackColor = Color.LightGray
        txtbxAdminPass.BorderStyle = BorderStyle.FixedSingle
        txtbxAdminPass.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxAdminPass.ForeColor = Color.Black
        txtbxAdminPass.Location = New Point(482, 363)
        txtbxAdminPass.Margin = New Padding(3, 2, 3, 2)
        txtbxAdminPass.Name = "txtbxAdminPass"
        txtbxAdminPass.Size = New Size(339, 26)
        txtbxAdminPass.TabIndex = 119
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label8.Location = New Point(482, 344)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 17)
        Label8.TabIndex = 118
        Label8.Text = "Password*"
        ' 
        ' txtbxAdminName
        ' 
        txtbxAdminName.BackColor = Color.LightGray
        txtbxAdminName.BorderStyle = BorderStyle.FixedSingle
        txtbxAdminName.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxAdminName.ForeColor = Color.Black
        txtbxAdminName.Location = New Point(482, 304)
        txtbxAdminName.Margin = New Padding(3, 2, 3, 2)
        txtbxAdminName.Name = "txtbxAdminName"
        txtbxAdminName.Size = New Size(339, 26)
        txtbxAdminName.TabIndex = 117
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label9.Location = New Point(482, 283)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 17)
        Label9.TabIndex = 116
        Label9.Text = "AdminName*"
        ' 
        ' CBRole
        ' 
        CBRole.BackColor = Color.LightGray
        CBRole.DropDownStyle = ComboBoxStyle.DropDownList
        CBRole.FlatStyle = FlatStyle.Flat
        CBRole.FormattingEnabled = True
        CBRole.Items.AddRange(New Object() {"Normal Admin", "Super Admin"})
        CBRole.Location = New Point(487, 123)
        CBRole.Name = "CBRole"
        CBRole.Size = New Size(121, 23)
        CBRole.TabIndex = 123
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label10.Location = New Point(486, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 17)
        Label10.TabIndex = 122
        Label10.Text = "Role*"
        ' 
        ' newAdminform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(909, 541)
        Controls.Add(CBRole)
        Controls.Add(Label10)
        Controls.Add(txtbxAdminPass2)
        Controls.Add(Label2)
        Controls.Add(txtbxAdminPass)
        Controls.Add(Label8)
        Controls.Add(txtbxAdminName)
        Controls.Add(Label9)
        Controls.Add(DTPhiredate)
        Controls.Add(CBStatus)
        Controls.Add(txtbxExp)
        Controls.Add(Label5)
        Controls.Add(txtbxSpecial)
        Controls.Add(Label6)
        Controls.Add(txtbxSalary)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtbxPNumber)
        Controls.Add(Label1)
        Controls.Add(txtbxLname)
        Controls.Add(txtbxMname)
        Controls.Add(txtbxFname)
        Controls.Add(btnBack)
        Controls.Add(btnSubmit)
        Controls.Add(txtxtbxEmail)
        Controls.Add(lblEmail)
        Controls.Add(lblRole)
        Controls.Add(PictureBox1)
        Controls.Add(LabelSign)
        MaximumSize = New Size(925, 580)
        MinimumSize = New Size(925, 580)
        Name = "newAdminform"
        Text = "Admin Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DTPhiredate As DateTimePicker
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents txtbxExp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxSpecial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxSalary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxPNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxLname As TextBox
    Friend WithEvents txtbxMname As TextBox
    Friend WithEvents txtbxFname As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtxtbxEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelSign As Label
    Friend WithEvents txtbxAdminPass2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxAdminPass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbxAdminName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBRole As ComboBox
    Friend WithEvents Label10 As Label
End Class
