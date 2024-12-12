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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblCurrentDate = New Label()
        btnToday = New Button()
        btnNext = New Button()
        btnPrevious = New Button()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Location = New Point(0, 22)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1090, 537)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(132, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 4
        Label1.Text = "Session Schedules"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = calendar
        PictureBox1.Location = New Point(94, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' lblCurrentDate
        ' 
        lblCurrentDate.AutoSize = True
        lblCurrentDate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrentDate.ForeColor = Color.White
        lblCurrentDate.Location = New Point(423, 55)
        lblCurrentDate.Name = "lblCurrentDate"
        lblCurrentDate.Size = New Size(67, 25)
        lblCurrentDate.TabIndex = 2
        lblCurrentDate.Text = "Label1"
        ' 
        ' btnToday
        ' 
        btnToday.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnToday.FlatAppearance.BorderSize = 0
        btnToday.FlatStyle = FlatStyle.Flat
        btnToday.Location = New Point(184, 50)
        btnToday.Margin = New Padding(3, 2, 3, 2)
        btnToday.Name = "btnToday"
        btnToday.Size = New Size(85, 28)
        btnToday.TabIndex = 1
        btnToday.Text = "Today"
        btnToday.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(274, 50)
        btnNext.Margin = New Padding(3, 2, 3, 2)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(85, 28)
        btnNext.TabIndex = 1
        btnNext.Text = ">"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(94, 50)
        btnPrevious.Margin = New Padding(3, 2, 3, 2)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(85, 28)
        btnPrevious.TabIndex = 1
        btnPrevious.Text = "<"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(59, 82)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(988, 439)
        DataGridView1.TabIndex = 0
        ' 
        ' Sched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Sched"
        Padding = New Padding(10)
        Size = New Size(1090, 571)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
