<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentStaffManage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel2 = New Panel()
        btnSubmitSEF = New Button()
        CBSEFspecialize = New ComboBox()
        CBSEFcertif = New ComboBox()
        Label11 = New Label()
        CBSEFshiftsch = New ComboBox()
        Label10 = New Label()
        DTPSEFhiredate = New DateTimePicker()
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
        Label2 = New Label()
        Label12 = New Label()
        txtbxSEFadname = New TextBox()
        txtbxSEFpass = New TextBox()
        txtbxSEFconfpass = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 496)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(txtbxSEFconfpass)
        Panel2.Controls.Add(txtbxSEFpass)
        Panel2.Controls.Add(txtbxSEFadname)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(btnSubmitSEF)
        Panel2.Controls.Add(CBSEFspecialize)
        Panel2.Controls.Add(CBSEFcertif)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(CBSEFshiftsch)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(DTPSEFhiredate)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtbxSEFexp)
        Panel2.Controls.Add(txtbxSEFsalary)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtbxSEFpnumber)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtbxSEFemail)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(CBSEFpos)
        Panel2.Controls.Add(txtboxSEFLname)
        Panel2.Controls.Add(txtbxSEFMname)
        Panel2.Controls.Add(txtbxSEFFname)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(0, 30)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 463)
        Panel2.TabIndex = 2
        ' 
        ' btnSubmitSEF
        ' 
        btnSubmitSEF.Anchor = AnchorStyles.Top
        btnSubmitSEF.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnSubmitSEF.FlatStyle = FlatStyle.Flat
        btnSubmitSEF.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitSEF.Location = New Point(506, 383)
        btnSubmitSEF.Name = "btnSubmitSEF"
        btnSubmitSEF.Size = New Size(125, 41)
        btnSubmitSEF.TabIndex = 25
        btnSubmitSEF.Text = "Submit"
        btnSubmitSEF.UseVisualStyleBackColor = False
        ' 
        ' CBSEFspecialize
        ' 
        CBSEFspecialize.Anchor = AnchorStyles.Top
        CBSEFspecialize.FormattingEnabled = True
        CBSEFspecialize.Items.AddRange(New Object() {"Fitness Training", "Customer Service", "Management", "Cleaning", "Security"})
        CBSEFspecialize.Location = New Point(34, 215)
        CBSEFspecialize.Name = "CBSEFspecialize"
        CBSEFspecialize.Size = New Size(312, 23)
        CBSEFspecialize.TabIndex = 24
        ' 
        ' CBSEFcertif
        ' 
        CBSEFcertif.Anchor = AnchorStyles.Top
        CBSEFcertif.FormattingEnabled = True
        CBSEFcertif.Items.AddRange(New Object() {"Certified Trainer", "First Aid", "Customer Service", "Security Training", "Management"})
        CBSEFcertif.Location = New Point(381, 157)
        CBSEFcertif.Name = "CBSEFcertif"
        CBSEFcertif.Size = New Size(250, 23)
        CBSEFcertif.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLight
        Label11.Location = New Point(381, 137)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 17)
        Label11.TabIndex = 22
        Label11.Text = "Certification*"
        ' 
        ' CBSEFshiftsch
        ' 
        CBSEFshiftsch.Anchor = AnchorStyles.Top
        CBSEFshiftsch.FormattingEnabled = True
        CBSEFshiftsch.Items.AddRange(New Object() {"Morning", "Afternoon", "Night"})
        CBSEFshiftsch.Location = New Point(381, 97)
        CBSEFshiftsch.Name = "CBSEFshiftsch"
        CBSEFshiftsch.Size = New Size(250, 23)
        CBSEFshiftsch.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLight
        Label10.Location = New Point(381, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 17)
        Label10.TabIndex = 20
        Label10.Text = "Shift Schedule*"
        ' 
        ' DTPSEFhiredate
        ' 
        DTPSEFhiredate.Anchor = AnchorStyles.Top
        DTPSEFhiredate.Location = New Point(34, 331)
        DTPSEFhiredate.Name = "DTPSEFhiredate"
        DTPSEFhiredate.Size = New Size(312, 23)
        DTPSEFhiredate.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLight
        Label9.Location = New Point(33, 254)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 17)
        Label9.TabIndex = 18
        Label9.Text = "Salary*"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLight
        Label8.Location = New Point(33, 372)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 17)
        Label8.TabIndex = 17
        Label8.Text = "Experience*"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(34, 310)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 16
        Label1.Text = "Hire Date*"
        ' 
        ' txtbxSEFexp
        ' 
        txtbxSEFexp.Anchor = AnchorStyles.Top
        txtbxSEFexp.Location = New Point(33, 393)
        txtbxSEFexp.Name = "txtbxSEFexp"
        txtbxSEFexp.PlaceholderText = "ex. 9 years of experience in Cybersecurity"
        txtbxSEFexp.Size = New Size(313, 23)
        txtbxSEFexp.TabIndex = 15
        ' 
        ' txtbxSEFsalary
        ' 
        txtbxSEFsalary.Anchor = AnchorStyles.Top
        txtbxSEFsalary.Location = New Point(34, 275)
        txtbxSEFsalary.Name = "txtbxSEFsalary"
        txtbxSEFsalary.Size = New Size(312, 23)
        txtbxSEFsalary.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLight
        Label7.Location = New Point(34, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 11
        Label7.Text = "Specialization*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLight
        Label6.Location = New Point(34, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 17)
        Label6.TabIndex = 10
        Label6.Text = "Phone Number*"
        ' 
        ' txtbxSEFpnumber
        ' 
        txtbxSEFpnumber.Anchor = AnchorStyles.Top
        txtbxSEFpnumber.Location = New Point(34, 157)
        txtbxSEFpnumber.Name = "txtbxSEFpnumber"
        txtbxSEFpnumber.PlaceholderText = "ex. 09123456789"
        txtbxSEFpnumber.Size = New Size(312, 23)
        txtbxSEFpnumber.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLight
        Label5.Location = New Point(34, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 17)
        Label5.TabIndex = 7
        Label5.Text = "Email*"
        ' 
        ' txtbxSEFemail
        ' 
        txtbxSEFemail.Anchor = AnchorStyles.Top
        txtbxSEFemail.Location = New Point(34, 97)
        txtbxSEFemail.Name = "txtbxSEFemail"
        txtbxSEFemail.PlaceholderText = "ex. example@xxx.com"
        txtbxSEFemail.Size = New Size(312, 23)
        txtbxSEFemail.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(381, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 17)
        Label4.TabIndex = 5
        Label4.Text = "Position*"
        ' 
        ' CBSEFpos
        ' 
        CBSEFpos.Anchor = AnchorStyles.Top
        CBSEFpos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBSEFpos.FormattingEnabled = True
        CBSEFpos.Items.AddRange(New Object() {"Trainer", "Receptionist", "Manager", "Cleaner", "Security"})
        CBSEFpos.Location = New Point(381, 38)
        CBSEFpos.Name = "CBSEFpos"
        CBSEFpos.Size = New Size(250, 25)
        CBSEFpos.TabIndex = 4
        ' 
        ' txtboxSEFLname
        ' 
        txtboxSEFLname.Anchor = AnchorStyles.Top
        txtboxSEFLname.Location = New Point(246, 38)
        txtboxSEFLname.Name = "txtboxSEFLname"
        txtboxSEFLname.PlaceholderText = "Last Name"
        txtboxSEFLname.Size = New Size(100, 23)
        txtboxSEFLname.TabIndex = 3
        ' 
        ' txtbxSEFMname
        ' 
        txtbxSEFMname.Anchor = AnchorStyles.Top
        txtbxSEFMname.Location = New Point(140, 38)
        txtbxSEFMname.Name = "txtbxSEFMname"
        txtbxSEFMname.PlaceholderText = "Middle Name"
        txtbxSEFMname.Size = New Size(100, 23)
        txtbxSEFMname.TabIndex = 2
        ' 
        ' txtbxSEFFname
        ' 
        txtbxSEFFname.Anchor = AnchorStyles.Top
        txtbxSEFFname.Location = New Point(34, 38)
        txtbxSEFFname.Name = "txtbxSEFFname"
        txtbxSEFFname.PlaceholderText = "First Name"
        txtbxSEFFname.Size = New Size(100, 23)
        txtbxSEFFname.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(34, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 17)
        Label3.TabIndex = 0
        Label3.Text = "Full Name (FN*, MI/MN*, LN*)"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(14, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(302, 32)
        Label2.TabIndex = 1
        Label2.Text = "GYM STAFF ENTRY FORM"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ControlLight
        Label12.Location = New Point(381, 195)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 17)
        Label12.TabIndex = 26
        Label12.Text = "Admin Name*"
        ' 
        ' txtbxSEFadname
        ' 
        txtbxSEFadname.Location = New Point(381, 215)
        txtbxSEFadname.Name = "txtbxSEFadname"
        txtbxSEFadname.Size = New Size(250, 23)
        txtbxSEFadname.TabIndex = 27
        ' 
        ' txtbxSEFpass
        ' 
        txtbxSEFpass.Location = New Point(381, 275)
        txtbxSEFpass.Name = "txtbxSEFpass"
        txtbxSEFpass.Size = New Size(250, 23)
        txtbxSEFpass.TabIndex = 28
        ' 
        ' txtbxSEFconfpass
        ' 
        txtbxSEFconfpass.Location = New Point(381, 334)
        txtbxSEFconfpass.Name = "txtbxSEFconfpass"
        txtbxSEFconfpass.Size = New Size(250, 23)
        txtbxSEFconfpass.TabIndex = 29
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLight
        Label13.Location = New Point(381, 254)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 17)
        Label13.TabIndex = 30
        Label13.Text = "Password*"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ControlLight
        Label14.Location = New Point(381, 316)
        Label14.Name = "Label14"
        Label14.Size = New Size(126, 17)
        Label14.TabIndex = 31
        Label14.Text = "Confirm Password*"
        ' 
        ' ContentStaffManage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(Panel1)
        MinimumSize = New Size(675, 496)
        Name = "ContentStaffManage"
        Size = New Size(675, 496)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbxSEFFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxSEFMname As TextBox
    Friend WithEvents CBSEFpos As ComboBox
    Friend WithEvents txtboxSEFLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxSEFemail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxSEFpnumber As TextBox
    Friend WithEvents txtbxSEFsalary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DTPSEFhiredate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxSEFexp As TextBox
    Friend WithEvents btnSubmitSEF As Button
    Friend WithEvents CBSEFspecialize As ComboBox
    Friend WithEvents CBSEFcertif As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBSEFshiftsch As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbxSEFconfpass As TextBox
    Friend WithEvents txtbxSEFpass As TextBox
    Friend WithEvents txtbxSEFadname As TextBox
    Friend WithEvents Label12 As Label

End Class
