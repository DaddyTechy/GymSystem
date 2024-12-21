<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentAnnouncement
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
        notesDGV = New DataGridView()
        btnAddNotes = New Label()
        CType(notesDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 40)
        Label1.TabIndex = 0
        Label1.Text = "Announcement"
        ' 
        ' notesDGV
        ' 
        notesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        notesDGV.Dock = DockStyle.Fill
        notesDGV.Location = New Point(20, 60)
        notesDGV.Margin = New Padding(3, 2, 3, 2)
        notesDGV.Name = "notesDGV"
        notesDGV.ReadOnly = True
        notesDGV.RowHeadersWidth = 51
        notesDGV.Size = New Size(788, 464)
        notesDGV.TabIndex = 9
        ' 
        ' btnAddNotes
        ' 
        btnAddNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddNotes.AutoSize = True
        btnAddNotes.BackColor = Color.Black
        btnAddNotes.FlatStyle = FlatStyle.Popup
        btnAddNotes.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddNotes.ForeColor = Color.Gold
        btnAddNotes.ImageAlign = ContentAlignment.MiddleLeft
        btnAddNotes.Location = New Point(656, 35)
        btnAddNotes.Margin = New Padding(3, 0, 0, 0)
        btnAddNotes.Name = "btnAddNotes"
        btnAddNotes.Padding = New Padding(1)
        btnAddNotes.Size = New Size(152, 22)
        btnAddNotes.TabIndex = 10
        btnAddNotes.Text = "Add Announcement"
        btnAddNotes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContentAnnouncement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(btnAddNotes)
        Controls.Add(notesDGV)
        Controls.Add(Label1)
        Name = "ContentAnnouncement"
        Padding = New Padding(20)
        Size = New Size(828, 544)
        CType(notesDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents notesDGV As DataGridView
    Friend WithEvents btnAddNotes As Label

End Class
