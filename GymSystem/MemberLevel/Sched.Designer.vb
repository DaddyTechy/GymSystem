<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sched
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
        lblCurrentDate = New Label()
        btnToday = New Button()
        btnNext = New Button()
        btnPrevious = New Button()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblCurrentDate)
        Panel1.Controls.Add(btnToday)
        Panel1.Controls.Add(btnNext)
        Panel1.Controls.Add(btnPrevious)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1246, 696)
        Panel1.TabIndex = 0
        ' 
        ' lblCurrentDate
        ' 
        lblCurrentDate.AutoSize = True
        lblCurrentDate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrentDate.ForeColor = Color.White
        lblCurrentDate.Location = New Point(483, 73)
        lblCurrentDate.Name = "lblCurrentDate"
        lblCurrentDate.Size = New Size(81, 31)
        lblCurrentDate.TabIndex = 2
        lblCurrentDate.Text = "Label1"
        ' 
        ' btnToday
        ' 
        btnToday.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnToday.FlatAppearance.BorderSize = 0
        btnToday.FlatStyle = FlatStyle.Flat
        btnToday.Location = New Point(210, 67)
        btnToday.Name = "btnToday"
        btnToday.Size = New Size(97, 37)
        btnToday.TabIndex = 1
        btnToday.Text = "Today"
        btnToday.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(313, 67)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(97, 37)
        btnNext.TabIndex = 1
        btnNext.Text = ">"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(107, 67)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(97, 37)
        btnPrevious.TabIndex = 1
        btnPrevious.Text = "<"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(107, 110)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1034, 454)
        DataGridView1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.calendar
        PictureBox1.Location = New Point(107, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(151, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 20)
        Label1.TabIndex = 4
        Label1.Text = "Session Schedules"
        ' 
        ' Sched
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "Sched"
        Size = New Size(1246, 702)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents btnToday As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
