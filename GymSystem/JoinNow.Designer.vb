<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoinNow
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BLoginBtn = New Button()
        SubmitBtn = New Button()
        ShowLL = New LinkLabel()
        ServiceCB = New ComboBox()
        PlansCB = New ComboBox()
        LastLbl = New Label()
        MiddleLbl = New Label()
        DoBLbl = New Label()
        EmailLbl = New Label()
        KgLbl = New Label()
        HeightLbl = New Label()
        SexLbl = New Label()
        ZipCLbl = New Label()
        CityLbl = New Label()
        PassLbl = New Label()
        CPassLbl = New Label()
        Label1 = New Label()
        PlansLbl = New Label()
        StreetLbl = New Label()
        ProvinceLbl = New Label()
        ContactLbl = New Label()
        FirstLbl = New Label()
        HeightTxt = New TextBox()
        SexTxt = New TextBox()
        CPassTxt = New TextBox()
        PassTxt = New TextBox()
        KgTxt = New TextBox()
        ContactTxt = New TextBox()
        EmailTxt = New TextBox()
        FirstTxt = New TextBox()
        MiddleTxt = New TextBox()
        LastTxt = New TextBox()
        TxtLbl = New Label()
        CustomCalendar1 = New CustomCalendar()
        CustomComboProvince = New CustomComboBox()
        CustomComboCity = New CustomComboBox()
        CustomComboStreet = New CustomComboBox()
        CustomComboZip = New CustomComboBox()
        SuspendLayout()
        ' 
        ' BLoginBtn
        ' 
        BLoginBtn.Anchor = AnchorStyles.None
        BLoginBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        BLoginBtn.FlatStyle = FlatStyle.Flat
        BLoginBtn.Location = New Point(312, 456)
        BLoginBtn.Margin = New Padding(3, 2, 3, 2)
        BLoginBtn.Name = "BLoginBtn"
        BLoginBtn.Size = New Size(108, 38)
        BLoginBtn.TabIndex = 42
        BLoginBtn.Text = "Back to Login"
        BLoginBtn.UseVisualStyleBackColor = False
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.Anchor = AnchorStyles.None
        SubmitBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        SubmitBtn.FlatStyle = FlatStyle.Flat
        SubmitBtn.Location = New Point(471, 456)
        SubmitBtn.Margin = New Padding(3, 2, 3, 2)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(108, 38)
        SubmitBtn.TabIndex = 41
        SubmitBtn.Text = "Submit Details"
        SubmitBtn.UseVisualStyleBackColor = False
        ' 
        ' ShowLL
        ' 
        ShowLL.Anchor = AnchorStyles.None
        ShowLL.AutoSize = True
        ShowLL.LinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ShowLL.Location = New Point(510, 335)
        ShowLL.Name = "ShowLL"
        ShowLL.Size = New Size(36, 15)
        ShowLL.TabIndex = 40
        ShowLL.TabStop = True
        ShowLL.Text = "Show"
        ShowLL.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        ' 
        ' ServiceCB
        ' 
        ServiceCB.Anchor = AnchorStyles.None
        ServiceCB.FormattingEnabled = True
        ServiceCB.Location = New Point(471, 408)
        ServiceCB.Margin = New Padding(3, 2, 3, 2)
        ServiceCB.Name = "ServiceCB"
        ServiceCB.Size = New Size(219, 23)
        ServiceCB.TabIndex = 39
        ' 
        ' PlansCB
        ' 
        PlansCB.Anchor = AnchorStyles.None
        PlansCB.FormattingEnabled = True
        PlansCB.Location = New Point(202, 408)
        PlansCB.Margin = New Padding(3, 2, 3, 2)
        PlansCB.Name = "PlansCB"
        PlansCB.Size = New Size(219, 23)
        PlansCB.TabIndex = 38
        ' 
        ' LastLbl
        ' 
        LastLbl.Anchor = AnchorStyles.None
        LastLbl.AutoSize = True
        LastLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LastLbl.ForeColor = Color.White
        LastLbl.Location = New Point(571, 134)
        LastLbl.Name = "LastLbl"
        LastLbl.Size = New Size(76, 19)
        LastLbl.TabIndex = 27
        LastLbl.Text = "Last Name"
        ' 
        ' MiddleLbl
        ' 
        MiddleLbl.Anchor = AnchorStyles.None
        MiddleLbl.AutoSize = True
        MiddleLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MiddleLbl.ForeColor = Color.White
        MiddleLbl.Location = New Point(331, 134)
        MiddleLbl.Name = "MiddleLbl"
        MiddleLbl.Size = New Size(98, 19)
        MiddleLbl.TabIndex = 28
        MiddleLbl.Text = "Middle Name"
        ' 
        ' DoBLbl
        ' 
        DoBLbl.Anchor = AnchorStyles.None
        DoBLbl.AutoSize = True
        DoBLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DoBLbl.ForeColor = Color.White
        DoBLbl.Location = New Point(571, 183)
        DoBLbl.Name = "DoBLbl"
        DoBLbl.Size = New Size(91, 19)
        DoBLbl.TabIndex = 32
        DoBLbl.Text = "Date of Birth"
        ' 
        ' EmailLbl
        ' 
        EmailLbl.Anchor = AnchorStyles.None
        EmailLbl.AutoSize = True
        EmailLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailLbl.ForeColor = Color.White
        EmailLbl.Location = New Point(331, 183)
        EmailLbl.Name = "EmailLbl"
        EmailLbl.Size = New Size(43, 19)
        EmailLbl.TabIndex = 30
        EmailLbl.Text = "Email"
        ' 
        ' KgLbl
        ' 
        KgLbl.Anchor = AnchorStyles.None
        KgLbl.AutoSize = True
        KgLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KgLbl.ForeColor = Color.White
        KgLbl.Location = New Point(571, 283)
        KgLbl.Name = "KgLbl"
        KgLbl.Size = New Size(26, 19)
        KgLbl.TabIndex = 37
        KgLbl.Text = "Kg"
        ' 
        ' HeightLbl
        ' 
        HeightLbl.Anchor = AnchorStyles.None
        HeightLbl.AutoSize = True
        HeightLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HeightLbl.ForeColor = Color.White
        HeightLbl.Location = New Point(691, 283)
        HeightLbl.Name = "HeightLbl"
        HeightLbl.Size = New Size(53, 19)
        HeightLbl.TabIndex = 33
        HeightLbl.Text = "Height"
        ' 
        ' SexLbl
        ' 
        SexLbl.Anchor = AnchorStyles.None
        SexLbl.AutoSize = True
        SexLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SexLbl.ForeColor = Color.White
        SexLbl.Location = New Point(691, 232)
        SexLbl.Name = "SexLbl"
        SexLbl.Size = New Size(32, 19)
        SexLbl.TabIndex = 34
        SexLbl.Text = "Sex"
        ' 
        ' ZipCLbl
        ' 
        ZipCLbl.Anchor = AnchorStyles.None
        ZipCLbl.AutoSize = True
        ZipCLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ZipCLbl.ForeColor = Color.White
        ZipCLbl.Location = New Point(571, 232)
        ZipCLbl.Name = "ZipCLbl"
        ZipCLbl.Size = New Size(69, 19)
        ZipCLbl.TabIndex = 35
        ZipCLbl.Text = "Zip Code"
        ' 
        ' CityLbl
        ' 
        CityLbl.Anchor = AnchorStyles.None
        CityLbl.AutoSize = True
        CityLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CityLbl.ForeColor = Color.White
        CityLbl.Location = New Point(331, 232)
        CityLbl.Name = "CityLbl"
        CityLbl.Size = New Size(34, 19)
        CityLbl.TabIndex = 36
        CityLbl.Text = "City"
        ' 
        ' PassLbl
        ' 
        PassLbl.Anchor = AnchorStyles.None
        PassLbl.AutoSize = True
        PassLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PassLbl.ForeColor = Color.White
        PassLbl.Location = New Point(90, 334)
        PassLbl.Name = "PassLbl"
        PassLbl.Size = New Size(70, 19)
        PassLbl.TabIndex = 26
        PassLbl.Text = "Password"
        ' 
        ' CPassLbl
        ' 
        CPassLbl.Anchor = AnchorStyles.None
        CPassLbl.AutoSize = True
        CPassLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CPassLbl.ForeColor = Color.White
        CPassLbl.Location = New Point(331, 334)
        CPassLbl.Name = "CPassLbl"
        CPassLbl.Size = New Size(126, 19)
        CPassLbl.TabIndex = 29
        CPassLbl.Text = "Confirm Password"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(471, 389)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 25
        Label1.Text = "Service"
        ' 
        ' PlansLbl
        ' 
        PlansLbl.Anchor = AnchorStyles.None
        PlansLbl.AutoSize = True
        PlansLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PlansLbl.ForeColor = Color.White
        PlansLbl.Location = New Point(202, 389)
        PlansLbl.Name = "PlansLbl"
        PlansLbl.Size = New Size(42, 19)
        PlansLbl.TabIndex = 20
        PlansLbl.Text = "Plans"
        ' 
        ' StreetLbl
        ' 
        StreetLbl.Anchor = AnchorStyles.None
        StreetLbl.AutoSize = True
        StreetLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StreetLbl.ForeColor = Color.White
        StreetLbl.Location = New Point(90, 283)
        StreetLbl.Name = "StreetLbl"
        StreetLbl.Size = New Size(48, 19)
        StreetLbl.TabIndex = 24
        StreetLbl.Text = "Street"
        ' 
        ' ProvinceLbl
        ' 
        ProvinceLbl.Anchor = AnchorStyles.None
        ProvinceLbl.AutoSize = True
        ProvinceLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProvinceLbl.ForeColor = Color.White
        ProvinceLbl.Location = New Point(90, 232)
        ProvinceLbl.Name = "ProvinceLbl"
        ProvinceLbl.Size = New Size(65, 19)
        ProvinceLbl.TabIndex = 23
        ProvinceLbl.Text = "Province"
        ' 
        ' ContactLbl
        ' 
        ContactLbl.Anchor = AnchorStyles.None
        ContactLbl.AutoSize = True
        ContactLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ContactLbl.ForeColor = Color.White
        ContactLbl.Location = New Point(90, 183)
        ContactLbl.Name = "ContactLbl"
        ContactLbl.Size = New Size(116, 19)
        ContactLbl.TabIndex = 22
        ContactLbl.Text = "Contact Number"
        ' 
        ' FirstLbl
        ' 
        FirstLbl.Anchor = AnchorStyles.None
        FirstLbl.AutoSize = True
        FirstLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstLbl.ForeColor = Color.White
        FirstLbl.Location = New Point(90, 134)
        FirstLbl.Name = "FirstLbl"
        FirstLbl.Size = New Size(78, 19)
        FirstLbl.TabIndex = 21
        FirstLbl.Text = "First Name"
        ' 
        ' HeightTxt
        ' 
        HeightTxt.Anchor = AnchorStyles.None
        HeightTxt.BackColor = Color.Gray
        HeightTxt.BorderStyle = BorderStyle.None
        HeightTxt.Font = New Font("Segoe UI", 12.0F)
        HeightTxt.ForeColor = Color.White
        HeightTxt.Location = New Point(691, 302)
        HeightTxt.Margin = New Padding(3, 2, 3, 2)
        HeightTxt.Name = "HeightTxt"
        HeightTxt.Size = New Size(99, 22)
        HeightTxt.TabIndex = 9
        ' 
        ' SexTxt
        ' 
        SexTxt.Anchor = AnchorStyles.None
        SexTxt.BackColor = Color.Gray
        SexTxt.BorderStyle = BorderStyle.None
        SexTxt.Font = New Font("Segoe UI", 12.0F)
        SexTxt.ForeColor = Color.White
        SexTxt.Location = New Point(691, 250)
        SexTxt.Margin = New Padding(3, 2, 3, 2)
        SexTxt.Name = "SexTxt"
        SexTxt.Size = New Size(99, 22)
        SexTxt.TabIndex = 10
        ' 
        ' CPassTxt
        ' 
        CPassTxt.Anchor = AnchorStyles.None
        CPassTxt.BackColor = Color.Gray
        CPassTxt.BorderStyle = BorderStyle.None
        CPassTxt.Font = New Font("Segoe UI", 12.0F)
        CPassTxt.ForeColor = Color.White
        CPassTxt.Location = New Point(331, 352)
        CPassTxt.Margin = New Padding(3, 2, 3, 2)
        CPassTxt.Name = "CPassTxt"
        CPassTxt.Size = New Size(219, 22)
        CPassTxt.TabIndex = 11
        ' 
        ' PassTxt
        ' 
        PassTxt.Anchor = AnchorStyles.None
        PassTxt.BackColor = Color.Gray
        PassTxt.BorderStyle = BorderStyle.None
        PassTxt.Font = New Font("Segoe UI", 12.0F)
        PassTxt.ForeColor = Color.White
        PassTxt.Location = New Point(90, 352)
        PassTxt.Margin = New Padding(3, 2, 3, 2)
        PassTxt.Name = "PassTxt"
        PassTxt.Size = New Size(219, 22)
        PassTxt.TabIndex = 12
        ' 
        ' KgTxt
        ' 
        KgTxt.Anchor = AnchorStyles.None
        KgTxt.BackColor = Color.Gray
        KgTxt.BorderStyle = BorderStyle.None
        KgTxt.Font = New Font("Segoe UI", 12.0F)
        KgTxt.ForeColor = Color.White
        KgTxt.Location = New Point(571, 302)
        KgTxt.Margin = New Padding(3, 2, 3, 2)
        KgTxt.Name = "KgTxt"
        KgTxt.Size = New Size(99, 22)
        KgTxt.TabIndex = 18
        ' 
        ' ContactTxt
        ' 
        ContactTxt.Anchor = AnchorStyles.None
        ContactTxt.BackColor = Color.Gray
        ContactTxt.BorderStyle = BorderStyle.None
        ContactTxt.Font = New Font("Segoe UI", 12.0F)
        ContactTxt.ForeColor = Color.White
        ContactTxt.Location = New Point(90, 202)
        ContactTxt.Margin = New Padding(3, 2, 3, 2)
        ContactTxt.Name = "ContactTxt"
        ContactTxt.Size = New Size(219, 22)
        ContactTxt.TabIndex = 14
        ' 
        ' EmailTxt
        ' 
        EmailTxt.Anchor = AnchorStyles.None
        EmailTxt.BackColor = Color.Gray
        EmailTxt.BorderStyle = BorderStyle.None
        EmailTxt.Font = New Font("Segoe UI", 12.0F)
        EmailTxt.ForeColor = Color.White
        EmailTxt.Location = New Point(331, 202)
        EmailTxt.Margin = New Padding(3, 2, 3, 2)
        EmailTxt.Name = "EmailTxt"
        EmailTxt.Size = New Size(219, 22)
        EmailTxt.TabIndex = 15
        ' 
        ' FirstTxt
        ' 
        FirstTxt.Anchor = AnchorStyles.None
        FirstTxt.BackColor = Color.Gray
        FirstTxt.BorderStyle = BorderStyle.None
        FirstTxt.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstTxt.ForeColor = Color.White
        FirstTxt.Location = New Point(90, 152)
        FirstTxt.Margin = New Padding(3, 2, 3, 2)
        FirstTxt.Name = "FirstTxt"
        FirstTxt.Size = New Size(219, 22)
        FirstTxt.TabIndex = 16
        ' 
        ' MiddleTxt
        ' 
        MiddleTxt.Anchor = AnchorStyles.None
        MiddleTxt.BackColor = Color.Gray
        MiddleTxt.BorderStyle = BorderStyle.None
        MiddleTxt.Font = New Font("Segoe UI", 12.0F)
        MiddleTxt.ForeColor = Color.White
        MiddleTxt.Location = New Point(331, 152)
        MiddleTxt.Margin = New Padding(3, 2, 3, 2)
        MiddleTxt.Name = "MiddleTxt"
        MiddleTxt.Size = New Size(219, 22)
        MiddleTxt.TabIndex = 17
        ' 
        ' LastTxt
        ' 
        LastTxt.Anchor = AnchorStyles.None
        LastTxt.BackColor = Color.Gray
        LastTxt.BorderStyle = BorderStyle.None
        LastTxt.Font = New Font("Segoe UI", 12.0F)
        LastTxt.ForeColor = Color.White
        LastTxt.Location = New Point(571, 152)
        LastTxt.Margin = New Padding(3, 2, 3, 2)
        LastTxt.Name = "LastTxt"
        LastTxt.Size = New Size(219, 22)
        LastTxt.TabIndex = 19
        ' 
        ' TxtLbl
        ' 
        TxtLbl.Anchor = AnchorStyles.Top
        TxtLbl.AutoSize = True
        TxtLbl.Font = New Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtLbl.ForeColor = Color.White
        TxtLbl.Location = New Point(202, 47)
        TxtLbl.Name = "TxtLbl"
        TxtLbl.RightToLeft = RightToLeft.No
        TxtLbl.Size = New Size(436, 60)
        TxtLbl.TabIndex = 8
        TxtLbl.Text = "Enter your details below and we will send " & vbCrLf & "your details for further activation process."
        ' 
        ' CustomCalendar1
        ' 
        CustomCalendar1.Anchor = AnchorStyles.None
        CustomCalendar1.CustomFormat = "MM/dd/yyyy"
        CustomCalendar1.Format = DateTimePickerFormat.Custom
        CustomCalendar1.Location = New Point(571, 202)
        CustomCalendar1.Margin = New Padding(3, 2, 3, 2)
        CustomCalendar1.Name = "CustomCalendar1"
        CustomCalendar1.Size = New Size(219, 23)
        CustomCalendar1.TabIndex = 43
        ' 
        ' CustomComboProvince
        ' 
        CustomComboProvince.Anchor = AnchorStyles.None
        CustomComboProvince.BackColor = Color.Gray
        CustomComboProvince.BgColor = Color.Gray
        CustomComboProvince.BorderColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        CustomComboProvince.CustomForeColor = Color.Black
        CustomComboProvince.DrawMode = DrawMode.OwnerDrawFixed
        CustomComboProvince.FlatStyle = FlatStyle.Flat
        CustomComboProvince.ForeColor = Color.White
        CustomComboProvince.FormattingEnabled = True
        CustomComboProvince.Location = New Point(90, 254)
        CustomComboProvince.Margin = New Padding(3, 2, 3, 2)
        CustomComboProvince.Name = "CustomComboProvince"
        CustomComboProvince.Size = New Size(219, 24)
        CustomComboProvince.TabIndex = 44
        ' 
        ' CustomComboCity
        ' 
        CustomComboCity.Anchor = AnchorStyles.None
        CustomComboCity.BackColor = Color.Gray
        CustomComboCity.BgColor = Color.Gray
        CustomComboCity.BorderColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        CustomComboCity.CustomForeColor = Color.Black
        CustomComboCity.DrawMode = DrawMode.OwnerDrawFixed
        CustomComboCity.FlatStyle = FlatStyle.Flat
        CustomComboCity.ForeColor = Color.White
        CustomComboCity.FormattingEnabled = True
        CustomComboCity.Location = New Point(331, 254)
        CustomComboCity.Margin = New Padding(3, 2, 3, 2)
        CustomComboCity.Name = "CustomComboCity"
        CustomComboCity.Size = New Size(219, 24)
        CustomComboCity.TabIndex = 45
        ' 
        ' CustomComboStreet
        ' 
        CustomComboStreet.Anchor = AnchorStyles.None
        CustomComboStreet.BackColor = Color.Gray
        CustomComboStreet.BgColor = Color.Gray
        CustomComboStreet.BorderColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        CustomComboStreet.CustomForeColor = Color.Black
        CustomComboStreet.DrawMode = DrawMode.OwnerDrawFixed
        CustomComboStreet.FlatStyle = FlatStyle.Flat
        CustomComboStreet.ForeColor = Color.White
        CustomComboStreet.FormattingEnabled = True
        CustomComboStreet.Location = New Point(90, 302)
        CustomComboStreet.Margin = New Padding(3, 2, 3, 2)
        CustomComboStreet.Name = "CustomComboStreet"
        CustomComboStreet.Size = New Size(219, 24)
        CustomComboStreet.TabIndex = 47
        ' 
        ' CustomComboZip
        ' 
        CustomComboZip.Anchor = AnchorStyles.None
        CustomComboZip.BackColor = Color.Gray
        CustomComboZip.BgColor = Color.Gray
        CustomComboZip.BorderColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        CustomComboZip.CustomForeColor = Color.Black
        CustomComboZip.DrawMode = DrawMode.OwnerDrawFixed
        CustomComboZip.FlatStyle = FlatStyle.Flat
        CustomComboZip.ForeColor = Color.White
        CustomComboZip.FormattingEnabled = True
        CustomComboZip.Location = New Point(571, 250)
        CustomComboZip.Margin = New Padding(3, 2, 3, 2)
        CustomComboZip.Name = "CustomComboZip"
        CustomComboZip.Size = New Size(99, 24)
        CustomComboZip.TabIndex = 48
        ' 
        ' JoinNow
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        ClientSize = New Size(880, 541)
        Controls.Add(CustomComboZip)
        Controls.Add(CustomComboStreet)
        Controls.Add(CustomComboCity)
        Controls.Add(CustomComboProvince)
        Controls.Add(CustomCalendar1)
        Controls.Add(BLoginBtn)
        Controls.Add(SubmitBtn)
        Controls.Add(ShowLL)
        Controls.Add(ServiceCB)
        Controls.Add(PlansCB)
        Controls.Add(LastLbl)
        Controls.Add(MiddleLbl)
        Controls.Add(DoBLbl)
        Controls.Add(EmailLbl)
        Controls.Add(KgLbl)
        Controls.Add(HeightLbl)
        Controls.Add(SexLbl)
        Controls.Add(ZipCLbl)
        Controls.Add(CityLbl)
        Controls.Add(PassLbl)
        Controls.Add(CPassLbl)
        Controls.Add(Label1)
        Controls.Add(PlansLbl)
        Controls.Add(StreetLbl)
        Controls.Add(ProvinceLbl)
        Controls.Add(ContactLbl)
        Controls.Add(FirstLbl)
        Controls.Add(HeightTxt)
        Controls.Add(SexTxt)
        Controls.Add(CPassTxt)
        Controls.Add(PassTxt)
        Controls.Add(KgTxt)
        Controls.Add(ContactTxt)
        Controls.Add(EmailTxt)
        Controls.Add(FirstTxt)
        Controls.Add(MiddleTxt)
        Controls.Add(LastTxt)
        Controls.Add(TxtLbl)
        Margin = New Padding(3, 2, 3, 2)
        Name = "JoinNow"
        Text = "JoinNow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BLoginBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents ShowLL As LinkLabel
    Friend WithEvents ServiceCB As ComboBox
    Friend WithEvents PlansCB As ComboBox
    Friend WithEvents LastLbl As Label
    Friend WithEvents MiddleLbl As Label
    Friend WithEvents DoBLbl As Label
    Friend WithEvents EmailLbl As Label
    Friend WithEvents KgLbl As Label
    Friend WithEvents HeightLbl As Label
    Friend WithEvents SexLbl As Label
    Friend WithEvents ZipCLbl As Label
    Friend WithEvents CityLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents CPassLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlansLbl As Label
    Friend WithEvents StreetLbl As Label
    Friend WithEvents ProvinceLbl As Label
    Friend WithEvents ContactLbl As Label
    Friend WithEvents FirstLbl As Label
    Friend WithEvents HeightTxt As TextBox
    Friend WithEvents SexTxt As TextBox
    Friend WithEvents CPassTxt As TextBox
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents KgTxt As TextBox
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents FirstTxt As TextBox
    Friend WithEvents MiddleTxt As TextBox
    Friend WithEvents LastTxt As TextBox
    Friend WithEvents TxtLbl As Label
    Friend WithEvents CustomCalendar1 As CustomCalendar
    Friend WithEvents CustomComboProvince As CustomComboBox
    Friend WithEvents CustomComboCity As CustomComboBox
    Friend WithEvents CustomComboStreet As CustomComboBox
    Friend WithEvents CustomComboZip As CustomComboBox
End Class
