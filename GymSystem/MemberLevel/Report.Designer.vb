<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(62, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(932, 221)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        Label1.Location = New Point(62, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 38)
        Label1.TabIndex = 1
        Label1.Text = "JJ Firness GYM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(393, 356)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 38)
        Label2.TabIndex = 2
        Label2.Text = "Last Payment Done: 1000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(576, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tel: 09123456789"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(777, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 20)
        Label4.TabIndex = 2
        Label4.Text = "Email:JJFitnessGYM@gmail.com"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(322, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 20)
        Label5.TabIndex = 2
        Label5.Text = "Daet, Camarines Norte"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(476, 408)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 20)
        Label6.TabIndex = 2
        Label6.Text = "Member Since: 06/22/23"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(62, 459)
        Label7.Name = "Label7"
        Label7.Size = New Size(269, 56)
        Label7.TabIndex = 2
        Label7.Text = "Dear Member," & vbCrLf & "Your Membership is Currently"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        Label8.Location = New Point(337, 487)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 28)
        Label8.TabIndex = 2
        Label8.Text = "Active!"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(62, 515)
        Label9.Name = "Label9"
        Label9.Size = New Size(252, 20)
        Label9.TabIndex = 2
        Label9.Text = "Thank you for Choosing our Services!"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(890, 487)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 20)
        Label10.TabIndex = 2
        Label10.Text = "Approved By:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Group_39
        PictureBox1.Location = New Point(890, 487)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(313, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1063, 674)
        Panel1.TabIndex = 4
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "Report"
        Size = New Size(1703, 709)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel

End Class
