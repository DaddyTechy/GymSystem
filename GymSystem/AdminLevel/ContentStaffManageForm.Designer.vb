<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentStaffManageForm
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
        Label14 = New Label()
        Label13 = New Label()
        txtbxSEFconfpass = New TextBox()
        txtbxSEFpass = New TextBox()
        txtbxSEFadname = New TextBox()
        Label12 = New Label()
        btnSubmitSEF = New Button()
        DTPSEFhiredate = New DateTimePicker()
        Label2 = New Label()
        CBSEFspecialize = New ComboBox()
        CBSEFcertif = New ComboBox()
        Label11 = New Label()
        CBSEFshiftsch = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label1 = New Label()
        txtbxSEFexp = New TextBox()
        txtbxSEFsalary = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        txtbxSEFpnumber = New TextBox()
        Label5 = New Label()
        txtbxSEFemail = New TextBox()
        Label4 = New Label()
        CBSEFpos = New ComboBox()
        txtboxSEFLname = New TextBox()
        txtbxSEFMname = New TextBox()
        txtbxSEFFname = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ControlLight
        Label14.Location = New Point(514, 382)
        Label14.Name = "Label14"
        Label14.Size = New Size(126, 17)
        Label14.TabIndex = 61
        Label14.Text = "Confirm Password*"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLight
        Label13.Location = New Point(514, 320)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 17)
        Label13.TabIndex = 60
        Label13.Text = "Password*"
        ' 
        ' txtbxSEFconfpass
        ' 
        txtbxSEFconfpass.Location = New Point(514, 400)
        txtbxSEFconfpass.Name = "txtbxSEFconfpass"
        txtbxSEFconfpass.Size = New Size(250, 23)
        txtbxSEFconfpass.TabIndex = 59
        ' 
        ' txtbxSEFpass
        ' 
        txtbxSEFpass.Location = New Point(514, 341)
        txtbxSEFpass.Name = "txtbxSEFpass"
        txtbxSEFpass.Size = New Size(250, 23)
        txtbxSEFpass.TabIndex = 58
        ' 
        ' txtbxSEFadname
        ' 
        txtbxSEFadname.Location = New Point(514, 281)
        txtbxSEFadname.Name = "txtbxSEFadname"
        txtbxSEFadname.Size = New Size(250, 23)
        txtbxSEFadname.TabIndex = 57
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ControlLight
        Label12.Location = New Point(514, 261)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 17)
        Label12.TabIndex = 56
        Label12.Text = "Admin Name*"
        ' 
        ' btnSubmitSEF
        ' 
        btnSubmitSEF.Anchor = AnchorStyles.Top
        btnSubmitSEF.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnSubmitSEF.FlatStyle = FlatStyle.Flat
        btnSubmitSEF.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitSEF.Location = New Point(639, 449)
        btnSubmitSEF.Name = "btnSubmitSEF"
        btnSubmitSEF.Size = New Size(125, 41)
        btnSubmitSEF.TabIndex = 55
        btnSubmitSEF.Text = "Submit"
        btnSubmitSEF.UseVisualStyleBackColor = False
        ' 
        ' DTPSEFhiredate
        ' 
        DTPSEFhiredate.Anchor = AnchorStyles.Top
        DTPSEFhiredate.Location = New Point(167, 397)
        DTPSEFhiredate.Name = "DTPSEFhiredate"
        DTPSEFhiredate.Size = New Size(312, 23)
        DTPSEFhiredate.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(314, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(302, 32)
        Label2.TabIndex = 33
        Label2.Text = "GYM STAFF ENTRY FORM"
        ' 
        ' CBSEFspecialize
        ' 
        CBSEFspecialize.Anchor = AnchorStyles.Top
        CBSEFspecialize.FormattingEnabled = True
        CBSEFspecialize.Items.AddRange(New Object() {"Fitness Training", "Customer Service", "Management", "Cleaning", "Security"})
        CBSEFspecialize.Location = New Point(167, 281)
        CBSEFspecialize.Name = "CBSEFspecialize"
        CBSEFspecialize.Size = New Size(312, 23)
        CBSEFspecialize.TabIndex = 54
        ' 
        ' CBSEFcertif
        ' 
        CBSEFcertif.Anchor = AnchorStyles.Top
        CBSEFcertif.FormattingEnabled = True
        CBSEFcertif.Items.AddRange(New Object() {"Certified Trainer", "First Aid", "Customer Service", "Security Training", "Management"})
        CBSEFcertif.Location = New Point(514, 223)
        CBSEFcertif.Name = "CBSEFcertif"
        CBSEFcertif.Size = New Size(250, 23)
        CBSEFcertif.TabIndex = 53
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLight
        Label11.Location = New Point(514, 203)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 17)
        Label11.TabIndex = 52
        Label11.Text = "Certification*"
        ' 
        ' CBSEFshiftsch
        ' 
        CBSEFshiftsch.Anchor = AnchorStyles.Top
        CBSEFshiftsch.FormattingEnabled = True
        CBSEFshiftsch.Items.AddRange(New Object() {"Morning", "Afternoon", "Night"})
        CBSEFshiftsch.Location = New Point(514, 163)
        CBSEFshiftsch.Name = "CBSEFshiftsch"
        CBSEFshiftsch.Size = New Size(250, 23)
        CBSEFshiftsch.TabIndex = 51
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLight
        Label10.Location = New Point(514, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 17)
        Label10.TabIndex = 50
        Label10.Text = "Shift Schedule*"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLight
        Label9.Location = New Point(166, 320)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 17)
        Label9.TabIndex = 48
        Label9.Text = "Salary*"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLight
        Label8.Location = New Point(166, 438)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 17)
        Label8.TabIndex = 47
        Label8.Text = "Experience*"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(167, 376)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 46
        Label1.Text = "Hire Date*"
        ' 
        ' txtbxSEFexp
        ' 
        txtbxSEFexp.Anchor = AnchorStyles.Top
        txtbxSEFexp.Location = New Point(166, 459)
        txtbxSEFexp.Name = "txtbxSEFexp"
        txtbxSEFexp.PlaceholderText = "ex. 9 years of experience in Cybersecurity"
        txtbxSEFexp.Size = New Size(313, 23)
        txtbxSEFexp.TabIndex = 45
        ' 
        ' txtbxSEFsalary
        ' 
        txtbxSEFsalary.Anchor = AnchorStyles.Top
        txtbxSEFsalary.Location = New Point(167, 341)
        txtbxSEFsalary.Name = "txtbxSEFsalary"
        txtbxSEFsalary.Size = New Size(312, 23)
        txtbxSEFsalary.TabIndex = 44
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLight
        Label7.Location = New Point(167, 261)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 43
        Label7.Text = "Specialization*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLight
        Label6.Location = New Point(167, 201)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 17)
        Label6.TabIndex = 42
        Label6.Text = "Phone Number*"
        ' 
        ' txtbxSEFpnumber
        ' 
        txtbxSEFpnumber.Anchor = AnchorStyles.Top
        txtbxSEFpnumber.Location = New Point(167, 223)
        txtbxSEFpnumber.Name = "txtbxSEFpnumber"
        txtbxSEFpnumber.PlaceholderText = "ex. 09123456789"
        txtbxSEFpnumber.Size = New Size(312, 23)
        txtbxSEFpnumber.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLight
        Label5.Location = New Point(167, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 17)
        Label5.TabIndex = 40
        Label5.Text = "Email*"
        ' 
        ' txtbxSEFemail
        ' 
        txtbxSEFemail.Anchor = AnchorStyles.Top
        txtbxSEFemail.Location = New Point(167, 163)
        txtbxSEFemail.Name = "txtbxSEFemail"
        txtbxSEFemail.PlaceholderText = "ex. example@xxx.com"
        txtbxSEFemail.Size = New Size(312, 23)
        txtbxSEFemail.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(514, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 17)
        Label4.TabIndex = 38
        Label4.Text = "Position*"
        ' 
        ' CBSEFpos
        ' 
        CBSEFpos.Anchor = AnchorStyles.Top
        CBSEFpos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBSEFpos.FormattingEnabled = True
        CBSEFpos.Items.AddRange(New Object() {"Trainer", "Receptionist", "Manager", "Cleaner", "Security"})
        CBSEFpos.Location = New Point(514, 104)
        CBSEFpos.Name = "CBSEFpos"
        CBSEFpos.Size = New Size(250, 25)
        CBSEFpos.TabIndex = 37
        ' 
        ' txtboxSEFLname
        ' 
        txtboxSEFLname.Anchor = AnchorStyles.Top
        txtboxSEFLname.Location = New Point(379, 104)
        txtboxSEFLname.Name = "txtboxSEFLname"
        txtboxSEFLname.PlaceholderText = "Last Name"
        txtboxSEFLname.Size = New Size(100, 23)
        txtboxSEFLname.TabIndex = 36
        ' 
        ' txtbxSEFMname
        ' 
        txtbxSEFMname.Anchor = AnchorStyles.Top
        txtbxSEFMname.Location = New Point(273, 104)
        txtbxSEFMname.Name = "txtbxSEFMname"
        txtbxSEFMname.PlaceholderText = "Middle Name"
        txtbxSEFMname.Size = New Size(100, 23)
        txtbxSEFMname.TabIndex = 35
        ' 
        ' txtbxSEFFname
        ' 
        txtbxSEFFname.Anchor = AnchorStyles.Top
        txtbxSEFFname.Location = New Point(167, 104)
        txtbxSEFFname.Name = "txtbxSEFFname"
        txtbxSEFFname.PlaceholderText = "First Name"
        txtbxSEFFname.Size = New Size(100, 23)
        txtbxSEFFname.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(167, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 17)
        Label3.TabIndex = 32
        Label3.Text = "Full Name (FN*, MI/MN*, LN*)"
        ' 
        ' ContentStaffManageForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(909, 541)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(txtbxSEFconfpass)
        Controls.Add(txtbxSEFpass)
        Controls.Add(txtbxSEFadname)
        Controls.Add(Label12)
        Controls.Add(btnSubmitSEF)
        Controls.Add(DTPSEFhiredate)
        Controls.Add(Label2)
        Controls.Add(CBSEFspecialize)
        Controls.Add(CBSEFcertif)
        Controls.Add(Label11)
        Controls.Add(CBSEFshiftsch)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(txtbxSEFexp)
        Controls.Add(txtbxSEFsalary)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtbxSEFpnumber)
        Controls.Add(Label5)
        Controls.Add(txtbxSEFemail)
        Controls.Add(Label4)
        Controls.Add(CBSEFpos)
        Controls.Add(txtboxSEFLname)
        Controls.Add(txtbxSEFMname)
        Controls.Add(txtbxSEFFname)
        Controls.Add(Label3)
        MaximumSize = New Size(925, 580)
        MinimumSize = New Size(925, 580)
        Name = "ContentStaffManageForm"
        Text = "ContentStaffManageForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbxSEFconfpass As TextBox
    Friend WithEvents txtbxSEFpass As TextBox
    Friend WithEvents txtbxSEFadname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSubmitSEF As Button
    Friend WithEvents DTPSEFhiredate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CBSEFspecialize As ComboBox
    Friend WithEvents CBSEFcertif As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBSEFshiftsch As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxSEFexp As TextBox
    Friend WithEvents txtbxSEFsalary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxSEFpnumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxSEFemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBSEFpos As ComboBox
    Friend WithEvents txtboxSEFLname As TextBox
    Friend WithEvents txtbxSEFMname As TextBox
    Friend WithEvents txtbxSEFFname As TextBox
    Friend WithEvents Label3 As Label
End Class
