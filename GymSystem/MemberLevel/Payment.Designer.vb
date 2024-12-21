<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Label1 = New Label()
        lblCurrentPlan = New TableLayoutPanel()
        lblCurrentP = New Label()
        lblService = New Label()
        lblStatus = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        TextBox1 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Button1 = New Button()
        lblCurrentPlan.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(63, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "Payments"
        ' 
        ' lblCurrentPlan
        ' 
        lblCurrentPlan.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        lblCurrentPlan.ColumnCount = 3
        lblCurrentPlan.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 46.82081F))
        lblCurrentPlan.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 53.17919F))
        lblCurrentPlan.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 234F))
        lblCurrentPlan.Controls.Add(lblCurrentP, 0, 0)
        lblCurrentPlan.Controls.Add(lblService, 1, 0)
        lblCurrentPlan.Controls.Add(lblStatus, 2, 0)
        lblCurrentPlan.ForeColor = Color.White
        lblCurrentPlan.Location = New Point(63, 73)
        lblCurrentPlan.Margin = New Padding(9, 8, 3, 2)
        lblCurrentPlan.Name = "lblCurrentPlan"
        lblCurrentPlan.RowCount = 1
        lblCurrentPlan.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        lblCurrentPlan.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        lblCurrentPlan.Size = New Size(794, 31)
        lblCurrentPlan.TabIndex = 1
        ' 
        ' lblCurrentP
        ' 
        lblCurrentP.AutoSize = True
        lblCurrentP.ForeColor = Color.White
        lblCurrentP.Location = New Point(4, 1)
        lblCurrentP.Name = "lblCurrentP"
        lblCurrentP.Padding = New Padding(4, 5, 0, 0)
        lblCurrentP.Size = New Size(63, 20)
        lblCurrentP.TabIndex = 0
        lblCurrentP.Text = "Payments"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.ForeColor = Color.White
        lblService.Location = New Point(265, 1)
        lblService.Name = "lblService"
        lblService.Padding = New Padding(4, 5, 0, 0)
        lblService.Size = New Size(63, 20)
        lblService.TabIndex = 0
        lblService.Text = "Payments"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(561, 1)
        lblStatus.Name = "lblStatus"
        lblStatus.Padding = New Padding(4, 5, 0, 0)
        lblStatus.Size = New Size(63, 20)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Payments"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = _929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(94, 154)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 85)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        Label2.Location = New Point(63, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 30)
        Label2.TabIndex = 3
        Label2.Text = "JJ Firness GYM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(66, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 15)
        Label5.TabIndex = 4
        Label5.Text = "Daet, Camarines Norte"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(66, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 5
        Label3.Text = "Tel: 09123456789"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(66, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 15)
        Label4.TabIndex = 6
        Label4.Text = "Email:JJFitnessGYM@gmail.com"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(482, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 15)
        Label6.TabIndex = 0
        Label6.Text = "Member's Full Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(482, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 15)
        Label7.TabIndex = 0
        Label7.Text = "Plan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(482, 187)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(130, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(482, 210)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 0
        Label8.Text = "Services"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(482, 227)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(130, 23)
        ComboBox2.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(482, 250)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 15)
        Label9.TabIndex = 0
        Label9.Text = "Amount"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(482, 265)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(130, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(482, 287)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 15)
        Label10.TabIndex = 0
        Label10.Text = "Member Status"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(482, 302)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 15)
        Label11.TabIndex = 0
        Label11.Text = "Active"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(310, 418)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(292, 41)
        Button1.TabIndex = 9
        Button1.Text = "Make Payment"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(lblCurrentPlan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label11)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Payment"
        Size = New Size(877, 506)
        lblCurrentPlan.ResumeLayout(False)
        lblCurrentPlan.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrentPlan As TableLayoutPanel
    Friend WithEvents lblCurrentP As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button

End Class
