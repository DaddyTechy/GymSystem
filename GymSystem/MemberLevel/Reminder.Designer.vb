<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
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
        notesDGV = New DataGridView()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnAddNotes = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(notesDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(notesDGV)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(7, 7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1707, 547)
        Panel1.TabIndex = 1
        ' 
        ' notesDGV
        ' 
        notesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        notesDGV.Dock = DockStyle.Fill
        notesDGV.Location = New Point(0, 85)
        notesDGV.Name = "notesDGV"
        notesDGV.RowHeadersWidth = 51
        notesDGV.Size = New Size(1707, 462)
        notesDGV.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnAddNotes)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1707, 85)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = Resources.Reminder
        PictureBox1.Location = New Point(874, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnAddNotes
        ' 
        btnAddNotes.AutoSize = True
        btnAddNotes.BackColor = Color.Black
        btnAddNotes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddNotes.ForeColor = Color.Gold
        btnAddNotes.ImageAlign = ContentAlignment.MiddleLeft
        btnAddNotes.Location = New Point(1609, 56)
        btnAddNotes.Margin = New Padding(3, 0, 0, 0)
        btnAddNotes.Name = "btnAddNotes"
        btnAddNotes.Padding = New Padding(1)
        btnAddNotes.Size = New Size(108, 27)
        btnAddNotes.TabIndex = 6
        btnAddNotes.Text = "Add Notes"
        btnAddNotes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(798, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 31)
        Label1.TabIndex = 4
        Label1.Text = "Notes"
        ' 
        ' Reminder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Panel1)
        Name = "Reminder"
        Padding = New Padding(17, 20, 17, 20)
        Size = New Size(1717, 567)
        Panel1.ResumeLayout(False)
        CType(notesDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddNotes As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents notesDGV As DataGridView

End Class
