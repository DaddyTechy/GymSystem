<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNotesControl
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
        txtNoteDetails = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtAuthor = New TextBox()
        dtpDateAdded = New DateTimePicker()
        Label3 = New Label()
        btnSaveNote = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtNoteDetails
        ' 
        txtNoteDetails.BackColor = Color.DarkGray
        txtNoteDetails.BorderStyle = BorderStyle.FixedSingle
        txtNoteDetails.Location = New Point(101, 70)
        txtNoteDetails.Multiline = True
        txtNoteDetails.Name = "txtNoteDetails"
        txtNoteDetails.Size = New Size(257, 64)
        txtNoteDetails.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(101, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 1
        Label1.Text = "Note Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(101, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 3
        Label2.Text = "Author"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.BackColor = Color.DarkGray
        txtAuthor.BorderStyle = BorderStyle.FixedSingle
        txtAuthor.Location = New Point(101, 164)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(257, 23)
        txtAuthor.TabIndex = 2
        ' 
        ' dtpDateAdded
        ' 
        dtpDateAdded.Location = New Point(101, 222)
        dtpDateAdded.Name = "dtpDateAdded"
        dtpDateAdded.Size = New Size(200, 23)
        dtpDateAdded.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(101, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 5
        Label3.Text = "Date"
        ' 
        ' btnSaveNote
        ' 
        btnSaveNote.BackColor = Color.Gold
        btnSaveNote.FlatStyle = FlatStyle.Flat
        btnSaveNote.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveNote.Location = New Point(101, 266)
        btnSaveNote.Name = "btnSaveNote"
        btnSaveNote.Size = New Size(75, 23)
        btnSaveNote.TabIndex = 6
        btnSaveNote.Text = "Save"
        btnSaveNote.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(24, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AddNotesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(Button1)
        Controls.Add(btnSaveNote)
        Controls.Add(Label3)
        Controls.Add(dtpDateAdded)
        Controls.Add(Label2)
        Controls.Add(txtAuthor)
        Controls.Add(Label1)
        Controls.Add(txtNoteDetails)
        Name = "AddNotesControl"
        Size = New Size(470, 328)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNoteDetails As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents dtpDateAdded As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSaveNote As Button
    Friend WithEvents Button1 As Button

End Class
