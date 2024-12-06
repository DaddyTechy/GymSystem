<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gym_Equipment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gym_Equipment))
        Panel1 = New Panel()
        Label13 = New Label()
        Label4 = New Label()
        Statustxtbox = New TextBox()
        MaintenanceScheduletxtbox = New TextBox()
        Button2 = New Button()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        SubmitDetailstxtbox = New Button()
        MainetenanceCosttxtbox = New TextBox()
        PurchasePlacetxtbox = New TextBox()
        Brandtxtbox = New TextBox()
        dtpDateofaPurchase = New DateTimePicker()
        Typetxtbox = New TextBox()
        nametxtbox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Statustxtbox)
        Panel1.Controls.Add(MaintenanceScheduletxtbox)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(SubmitDetailstxtbox)
        Panel1.Controls.Add(MainetenanceCosttxtbox)
        Panel1.Controls.Add(PurchasePlacetxtbox)
        Panel1.Controls.Add(Brandtxtbox)
        Panel1.Controls.Add(dtpDateofaPurchase)
        Panel1.Controls.Add(Typetxtbox)
        Panel1.Controls.Add(nametxtbox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(768, 658)
        Panel1.TabIndex = 0
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(50, 545)
        Label13.Name = "Label13"
        Label13.Size = New Size(50, 20)
        Label13.TabIndex = 46
        Label13.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(49, 496)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 20)
        Label4.TabIndex = 45
        Label4.Text = "Maintenance Schedule"
        ' 
        ' Statustxtbox
        ' 
        Statustxtbox.BackColor = Color.Gray
        Statustxtbox.Location = New Point(180, 542)
        Statustxtbox.Name = "Statustxtbox"
        Statustxtbox.Size = New Size(200, 27)
        Statustxtbox.TabIndex = 44
        ' 
        ' MaintenanceScheduletxtbox
        ' 
        MaintenanceScheduletxtbox.BackColor = Color.Gray
        MaintenanceScheduletxtbox.Location = New Point(223, 493)
        MaintenanceScheduletxtbox.Name = "MaintenanceScheduletxtbox"
        MaintenanceScheduletxtbox.Size = New Size(157, 27)
        MaintenanceScheduletxtbox.TabIndex = 43
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(49, 36)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 31)
        Button2.TabIndex = 41
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Image = CType(resources.GetObject("Label12.Image"), Image)
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(412, 423)
        Label12.Name = "Label12"
        Label12.Size = New Size(122, 20)
        Label12.TabIndex = 40
        Label12.Text = "       Maintenance"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        Label12.UseMnemonic = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Image = CType(resources.GetObject("Label11.Image"), Image)
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(49, 277)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 20)
        Label11.TabIndex = 39
        Label11.Text = "       Equipment-Info"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 42
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(452, 462)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 37
        Label9.Text = "Cost:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(33, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(414, 50)
        Label8.TabIndex = 36
        Label8.Text = "Equipment Entry Form"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Yellow
        Label7.Location = New Point(139, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 20)
        Label7.TabIndex = 35
        Label7.Text = "Add Equipments"
        ' 
        ' SubmitDetailstxtbox
        ' 
        SubmitDetailstxtbox.BackColor = Color.Gold
        SubmitDetailstxtbox.ForeColor = Color.Black
        SubmitDetailstxtbox.Location = New Point(554, 510)
        SubmitDetailstxtbox.Name = "SubmitDetailstxtbox"
        SubmitDetailstxtbox.Size = New Size(115, 29)
        SubmitDetailstxtbox.TabIndex = 34
        SubmitDetailstxtbox.Text = "Submit Details"
        SubmitDetailstxtbox.UseVisualStyleBackColor = False
        ' 
        ' MainetenanceCosttxtbox
        ' 
        MainetenanceCosttxtbox.BackColor = Color.Gray
        MainetenanceCosttxtbox.ForeColor = Color.White
        MainetenanceCosttxtbox.Location = New Point(529, 459)
        MainetenanceCosttxtbox.Name = "MainetenanceCosttxtbox"
        MainetenanceCosttxtbox.Size = New Size(200, 27)
        MainetenanceCosttxtbox.TabIndex = 33
        ' 
        ' PurchasePlacetxtbox
        ' 
        PurchasePlacetxtbox.BackColor = Color.Gray
        PurchasePlacetxtbox.ForeColor = Color.White
        PurchasePlacetxtbox.Location = New Point(529, 361)
        PurchasePlacetxtbox.Name = "PurchasePlacetxtbox"
        PurchasePlacetxtbox.Size = New Size(200, 27)
        PurchasePlacetxtbox.TabIndex = 32
        ' 
        ' Brandtxtbox
        ' 
        Brandtxtbox.BackColor = Color.Gray
        Brandtxtbox.ForeColor = Color.White
        Brandtxtbox.Location = New Point(529, 315)
        Brandtxtbox.Name = "Brandtxtbox"
        Brandtxtbox.Size = New Size(200, 27)
        Brandtxtbox.TabIndex = 31
        ' 
        ' dtpDateofaPurchase
        ' 
        dtpDateofaPurchase.Location = New Point(180, 438)
        dtpDateofaPurchase.Name = "dtpDateofaPurchase"
        dtpDateofaPurchase.Size = New Size(200, 27)
        dtpDateofaPurchase.TabIndex = 29
        ' 
        ' Typetxtbox
        ' 
        Typetxtbox.BackColor = Color.Gray
        Typetxtbox.ForeColor = Color.White
        Typetxtbox.Location = New Point(180, 378)
        Typetxtbox.Name = "Typetxtbox"
        Typetxtbox.PlaceholderText = "Ex.Strength"
        Typetxtbox.Size = New Size(200, 27)
        Typetxtbox.TabIndex = 28
        ' 
        ' nametxtbox
        ' 
        nametxtbox.BackColor = Color.DimGray
        nametxtbox.ForeColor = Color.White
        nametxtbox.Location = New Point(180, 316)
        nametxtbox.Name = "nametxtbox"
        nametxtbox.PlaceholderText = "ex. Dumbell"
        nametxtbox.Size = New Size(200, 27)
        nametxtbox.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(412, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 20)
        Label6.TabIndex = 26
        Label6.Text = "Purchase Place"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(412, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 25
        Label5.Text = "Brand"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(49, 443)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 20)
        Label3.TabIndex = 23
        Label3.Text = "Date of Purchase"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(49, 381)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 22
        Label2.Text = "Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(49, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 21
        Label1.Text = "Equipment:"
        ' 
        ' Gym_Equipment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(Panel1)
        ForeColor = Color.Aqua
        MinimumSize = New Size(771, 661)
        Name = "Gym_Equipment"
        Size = New Size(771, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SubmitDetailstxtbox As Button
    Friend WithEvents MainetenanceCosttxtbox As TextBox
    Friend WithEvents PurchasePlacetxtbox As TextBox
    Friend WithEvents Brandtxtbox As TextBox
    Friend WithEvents dtpDateofaPurchase As DateTimePicker
    Friend WithEvents Typetxtbox As TextBox
    Friend WithEvents nametxtbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Statustxtbox As TextBox
    Friend WithEvents MaintenanceScheduletxtbox As TextBox
    Friend WithEvents Label13 As Label

End Class
