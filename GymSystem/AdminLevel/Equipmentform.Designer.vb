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
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox2 = New TextBox()
        equipmentnametxtbox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(equipmentnametxtbox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(768, 658)
        Panel1.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Image = CType(resources.GetObject("Label12.Image"), Image)
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(472, 427)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 20)
        Label12.TabIndex = 40
        Label12.Text = "       Pricing"
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
        Label11.Size = New Size(113, 20)
        Label11.TabIndex = 39
        Label11.Text = "Equipment-Info"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(472, 277)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 20)
        Label10.TabIndex = 38
        Label10.Text = "Order Details"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(419, 463)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 20)
        Label9.TabIndex = 37
        Label9.Text = "Cost Per Item:"
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
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(561, 507)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 29)
        Button1.TabIndex = 34
        Button1.Text = "Submit Details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Gray
        TextBox6.ForeColor = Color.White
        TextBox6.Location = New Point(536, 456)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 27)
        TextBox6.TabIndex = 33
        TextBox6.Text = "₱ Amount"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gray
        TextBox5.ForeColor = Color.White
        TextBox5.Location = New Point(536, 358)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 27)
        TextBox5.TabIndex = 32
        TextBox5.Text = "Vendor Address"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gray
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(536, 312)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(200, 27)
        TextBox4.TabIndex = 31
        TextBox4.Text = "Vendor"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gray
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(180, 499)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 27)
        TextBox3.TabIndex = 30
        TextBox3.Text = "Equipment Qty"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(180, 438)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 27)
        DateTimePicker1.TabIndex = 29
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gray
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(180, 378)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 28
        TextBox2.Text = "Short Description"
        ' 
        ' equipmentnametxtbox
        ' 
        equipmentnametxtbox.BackColor = Color.DimGray
        equipmentnametxtbox.ForeColor = Color.White
        equipmentnametxtbox.Location = New Point(180, 316)
        equipmentnametxtbox.Name = "equipmentnametxtbox"
        equipmentnametxtbox.Size = New Size(200, 27)
        equipmentnametxtbox.TabIndex = 27
        equipmentnametxtbox.Text = "Equipment Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(419, 361)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 26
        Label6.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(419, 315)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 25
        Label5.Text = "Vendor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(49, 502)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 24
        Label4.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
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
        Label2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(49, 381)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 22
        Label2.Text = "Description"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(49, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 21
        Label1.Text = "Equipment:"
        ' 
        ' Gym_Equipment
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents equipmentnametxtbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
