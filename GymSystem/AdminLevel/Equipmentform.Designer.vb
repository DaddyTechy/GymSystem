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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(39, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 1
        Label1.Text = "Equipment:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(39, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 2
        Label2.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(39, 356)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 20)
        Label3.TabIndex = 3
        Label3.Text = "Date of Purchase"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 415)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 4
        Label4.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(409, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 5
        Label5.Text = "Vendor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(409, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 6
        Label6.Text = "Address"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DimGray
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(170, 229)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 27)
        TextBox1.TabIndex = 7
        TextBox1.Text = "Equipment Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gray
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(170, 291)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 27)
        TextBox2.TabIndex = 8
        TextBox2.Text = "Short Description"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(170, 351)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 27)
        DateTimePicker1.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gray
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(170, 412)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 27)
        TextBox3.TabIndex = 10
        TextBox3.Text = "Equipment Qty"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gray
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(526, 225)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(200, 27)
        TextBox4.TabIndex = 11
        TextBox4.Text = "Vendor"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gray
        TextBox5.ForeColor = Color.White
        TextBox5.Location = New Point(526, 271)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 27)
        TextBox5.TabIndex = 12
        TextBox5.Text = "Vendor Address"
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Gray
        TextBox6.ForeColor = Color.White
        TextBox6.Location = New Point(526, 369)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 27)
        TextBox6.TabIndex = 13
        TextBox6.Text = "₱ Amount"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(551, 420)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 29)
        Button1.TabIndex = 14
        Button1.Text = "Submit Details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Yellow
        Label7.Location = New Point(129, 36)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 20)
        Label7.TabIndex = 15
        Label7.Text = "Add Equipments"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(23, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(414, 50)
        Label8.TabIndex = 16
        Label8.Text = "Equipment Entry Form"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(409, 376)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 20)
        Label9.TabIndex = 17
        Label9.Text = "Cost Per Item:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(462, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 20)
        Label10.TabIndex = 18
        Label10.Text = "Order Details"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Image = CType(resources.GetObject("Label11.Image"), Image)
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(39, 190)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 20)
        Label11.TabIndex = 19
        Label11.Text = "Equipment-Info"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.White
        Label12.Image = CType(resources.GetObject("Label12.Image"), Image)
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(462, 340)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 20)
        Label12.TabIndex = 20
        Label12.Text = "       Pricing"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        Label12.UseMnemonic = False
        ' 
        ' Gym_Equipment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Aqua
        MinimumSize = New Size(771, 661)
        Name = "Gym_Equipment"
        Size = New Size(771, 661)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label

End Class
