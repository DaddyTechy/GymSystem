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
        Label1 = New Label()
        lblLastPaymentDone = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblMemberSince = New Label()
        Label7 = New Label()
        lblMembershipStatus = New Label()
        Label9 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        TableLayoutPanel8 = New TableLayoutPanel()
        lblServiceTaken = New Label()
        lblAttendanceCount = New Label()
        Label19 = New Label()
        lblPlanCost = New Label()
        lblPlanDuration = New Label()
        lblMembershipID = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Panel4 = New Panel()
        lblPlanType = New Label()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label11 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        btnPrint = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(45))
        Label1.Location = New Point(54, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 30)
        Label1.TabIndex = 1
        Label1.Text = "JJ Firness GYM"
        ' 
        ' lblLastPaymentDone
        ' 
        lblLastPaymentDone.AutoSize = True
        lblLastPaymentDone.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastPaymentDone.ForeColor = Color.Black
        lblLastPaymentDone.Location = New Point(344, 286)
        lblLastPaymentDone.Name = "lblLastPaymentDone"
        lblLastPaymentDone.Size = New Size(256, 30)
        lblLastPaymentDone.TabIndex = 2
        lblLastPaymentDone.Text = "Last Payment Done: 1000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(504, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 2
        Label3.Text = "Tel: 09123456789"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(680, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 15)
        Label4.TabIndex = 2
        Label4.Text = "Email:JJFitnessGYM@gmail.com"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(282, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 15)
        Label5.TabIndex = 2
        Label5.Text = "Daet, Camarines Norte"
        ' 
        ' lblMemberSince
        ' 
        lblMemberSince.AutoSize = True
        lblMemberSince.ForeColor = Color.Black
        lblMemberSince.Location = New Point(416, 325)
        lblMemberSince.Name = "lblMemberSince"
        lblMemberSince.Size = New Size(135, 15)
        lblMemberSince.TabIndex = 2
        lblMemberSince.Text = "Member Since: 06/22/23"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(54, 362)
        Label7.Name = "Label7"
        Label7.Size = New Size(218, 42)
        Label7.TabIndex = 2
        Label7.Text = "Dear Member," & vbCrLf & "Your Membership is Currently"
        ' 
        ' lblMembershipStatus
        ' 
        lblMembershipStatus.AutoSize = True
        lblMembershipStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMembershipStatus.ForeColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        lblMembershipStatus.Location = New Point(278, 383)
        lblMembershipStatus.Name = "lblMembershipStatus"
        lblMembershipStatus.Size = New Size(57, 21)
        lblMembershipStatus.TabIndex = 2
        lblMembershipStatus.Text = "Active!"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(54, 404)
        Label9.Name = "Label9"
        Label9.Size = New Size(204, 15)
        Label9.TabIndex = 2
        Label9.Text = "Thank you for Choosing our Services!"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(779, 365)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 15)
        Label10.TabIndex = 2
        Label10.Text = "Approved By:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Group_39
        PictureBox1.Location = New Point(779, 365)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(123, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblMembershipStatus)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblMemberSince)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblLastPaymentDone)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(274, 10)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(930, 506)
        Panel1.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.AutoSize = True
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(TableLayoutPanel8)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(TableLayoutPanel7)
        Panel3.Location = New Point(54, 88)
        Panel3.Margin = New Padding(3, 10, 3, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20, 10, 20, 10)
        Panel3.Size = New Size(818, 184)
        Panel3.TabIndex = 15
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.BackColor = Color.Transparent
        TableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel8.ColumnCount = 5
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.1740417F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.81416F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.7640114F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.7492628F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.4985256F))
        TableLayoutPanel8.Controls.Add(lblServiceTaken, 1, 1)
        TableLayoutPanel8.Controls.Add(lblAttendanceCount, 4, 1)
        TableLayoutPanel8.Controls.Add(Label19, 4, 0)
        TableLayoutPanel8.Controls.Add(lblPlanCost, 3, 1)
        TableLayoutPanel8.Controls.Add(lblPlanDuration, 2, 1)
        TableLayoutPanel8.Controls.Add(lblMembershipID, 0, 1)
        TableLayoutPanel8.Controls.Add(Label18, 3, 0)
        TableLayoutPanel8.Controls.Add(Label17, 2, 0)
        TableLayoutPanel8.Controls.Add(Label16, 1, 0)
        TableLayoutPanel8.Controls.Add(Label15, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(20, 91)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.Padding = New Padding(10, 15, 10, 20)
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(776, 81)
        TableLayoutPanel8.TabIndex = 6
        ' 
        ' lblServiceTaken
        ' 
        lblServiceTaken.AutoSize = True
        lblServiceTaken.Dock = DockStyle.Fill
        lblServiceTaken.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblServiceTaken.ForeColor = Color.Black
        lblServiceTaken.Location = New Point(158, 38)
        lblServiceTaken.Margin = New Padding(3, 0, 0, 0)
        lblServiceTaken.Name = "lblServiceTaken"
        lblServiceTaken.Size = New Size(123, 22)
        lblServiceTaken.TabIndex = 19
        lblServiceTaken.Text = "Info"
        lblServiceTaken.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblAttendanceCount
        ' 
        lblAttendanceCount.AutoSize = True
        lblAttendanceCount.Dock = DockStyle.Fill
        lblAttendanceCount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblAttendanceCount.ForeColor = Color.Black
        lblAttendanceCount.Location = New Point(545, 38)
        lblAttendanceCount.Margin = New Padding(3, 0, 0, 0)
        lblAttendanceCount.Name = "lblAttendanceCount"
        lblAttendanceCount.Size = New Size(220, 22)
        lblAttendanceCount.TabIndex = 18
        lblAttendanceCount.Text = "Info"
        lblAttendanceCount.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(545, 16)
        Label19.Margin = New Padding(3, 0, 0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(220, 21)
        Label19.TabIndex = 17
        Label19.Text = "Attendance Count"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPlanCost
        ' 
        lblPlanCost.AutoSize = True
        lblPlanCost.Dock = DockStyle.Fill
        lblPlanCost.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanCost.ForeColor = Color.Black
        lblPlanCost.Location = New Point(434, 38)
        lblPlanCost.Margin = New Padding(3, 0, 0, 0)
        lblPlanCost.Name = "lblPlanCost"
        lblPlanCost.Size = New Size(107, 22)
        lblPlanCost.TabIndex = 15
        lblPlanCost.Text = "Info"
        lblPlanCost.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPlanDuration
        ' 
        lblPlanDuration.AutoSize = True
        lblPlanDuration.Dock = DockStyle.Fill
        lblPlanDuration.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPlanDuration.ForeColor = Color.Black
        lblPlanDuration.Location = New Point(285, 38)
        lblPlanDuration.Margin = New Padding(3, 0, 0, 0)
        lblPlanDuration.Name = "lblPlanDuration"
        lblPlanDuration.Size = New Size(145, 22)
        lblPlanDuration.TabIndex = 14
        lblPlanDuration.Text = "Info"
        lblPlanDuration.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblMembershipID
        ' 
        lblMembershipID.AutoSize = True
        lblMembershipID.Dock = DockStyle.Fill
        lblMembershipID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblMembershipID.ForeColor = Color.Black
        lblMembershipID.Location = New Point(14, 38)
        lblMembershipID.Margin = New Padding(3, 0, 0, 0)
        lblMembershipID.Name = "lblMembershipID"
        lblMembershipID.Size = New Size(140, 22)
        lblMembershipID.TabIndex = 12
        lblMembershipID.Text = "Info"
        lblMembershipID.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(434, 16)
        Label18.Margin = New Padding(3, 0, 0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(107, 21)
        Label18.TabIndex = 11
        Label18.Text = "Cost"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Fill
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(285, 16)
        Label17.Margin = New Padding(3, 0, 0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(145, 21)
        Label17.TabIndex = 10
        Label17.Text = "My Plan"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Fill
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(158, 16)
        Label16.Margin = New Padding(3, 0, 0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(123, 21)
        Label16.TabIndex = 9
        Label16.Text = "Service Taken"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Fill
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(14, 16)
        Label15.Margin = New Padding(3, 0, 0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(140, 21)
        Label15.TabIndex = 8
        Label15.Text = "Membership ID"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lblPlanType)
        Panel4.Dock = DockStyle.Top
        Panel4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(20, 42)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10)
        Panel4.Size = New Size(776, 49)
        Panel4.TabIndex = 5
        ' 
        ' lblPlanType
        ' 
        lblPlanType.AutoSize = True
        lblPlanType.Dock = DockStyle.Fill
        lblPlanType.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold)
        lblPlanType.ForeColor = Color.Black
        lblPlanType.Location = New Point(10, 10)
        lblPlanType.Margin = New Padding(3, 0, 0, 0)
        lblPlanType.Name = "lblPlanType"
        lblPlanType.Size = New Size(266, 32)
        lblPlanType.TabIndex = 4
        lblPlanType.Text = "JJ Fitness Plan - Type"
        lblPlanType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 8F))
        TableLayoutPanel7.Controls.Add(Label11, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Top
        TableLayoutPanel7.Location = New Point(20, 10)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.Padding = New Padding(0, 0, 0, 5)
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(776, 32)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(4, 1)
        Label11.Margin = New Padding(3, 0, 0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(762, 25)
        Label11.TabIndex = 4
        Label11.Text = "Membership"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(1222, 493)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 5
        btnPrint.Text = "Save/Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(btnPrint)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Report"
        Size = New Size(1490, 532)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLastPaymentDone As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMemberSince As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMembershipStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblServiceTaken As Label
    Friend WithEvents lblAttendanceCount As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblPlanCost As Label
    Friend WithEvents lblPlanDuration As Label
    Friend WithEvents lblMembershipID As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPlanType As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label11 As Label

End Class
