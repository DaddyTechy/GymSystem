<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnnouncement
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
        Button1 = New Button()
        btnSaveAnn = New Button()
        Label3 = New Label()
        dtpDateAdded = New DateTimePicker()
        Label2 = New Label()
        txtAuthor = New TextBox()
        Label1 = New Label()
        txtAnnDetails = New TextBox()
        Label4 = New Label()
        txtAnnTitle = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(20, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 15
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAnn
        ' 
        btnSaveAnn.BackColor = Color.Gold
        btnSaveAnn.FlatStyle = FlatStyle.Flat
        btnSaveAnn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveAnn.Location = New Point(20, 345)
        btnSaveAnn.Name = "btnSaveAnn"
        btnSaveAnn.Size = New Size(75, 23)
        btnSaveAnn.TabIndex = 14
        btnSaveAnn.Text = "Save"
        btnSaveAnn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(20, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 13
        Label3.Text = "Date"
        ' 
        ' dtpDateAdded
        ' 
        dtpDateAdded.Location = New Point(20, 301)
        dtpDateAdded.Name = "dtpDateAdded"
        dtpDateAdded.Size = New Size(200, 23)
        dtpDateAdded.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(20, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 11
        Label2.Text = "Author"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.BackColor = Color.DarkGray
        txtAuthor.BorderStyle = BorderStyle.FixedSingle
        txtAuthor.Location = New Point(20, 243)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.PlaceholderText = "Current User"
        txtAuthor.ReadOnly = True
        txtAuthor.Size = New Size(257, 23)
        txtAuthor.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(20, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 9
        Label1.Text = "Details"
        ' 
        ' txtAnnDetails
        ' 
        txtAnnDetails.BackColor = Color.DarkGray
        txtAnnDetails.BorderStyle = BorderStyle.FixedSingle
        txtAnnDetails.Location = New Point(20, 149)
        txtAnnDetails.Multiline = True
        txtAnnDetails.Name = "txtAnnDetails"
        txtAnnDetails.Size = New Size(257, 64)
        txtAnnDetails.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(20, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 16
        Label4.Text = "Title"
        ' 
        ' txtAnnTitle
        ' 
        txtAnnTitle.BackColor = Color.DarkGray
        txtAnnTitle.BorderStyle = BorderStyle.FixedSingle
        txtAnnTitle.Location = New Point(20, 91)
        txtAnnTitle.Name = "txtAnnTitle"
        txtAnnTitle.Size = New Size(100, 23)
        txtAnnTitle.TabIndex = 17
        ' 
        ' AddAnnouncement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(txtAnnTitle)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(btnSaveAnn)
        Controls.Add(Label3)
        Controls.Add(dtpDateAdded)
        Controls.Add(Label2)
        Controls.Add(txtAuthor)
        Controls.Add(Label1)
        Controls.Add(txtAnnDetails)
        Name = "AddAnnouncement"
        Size = New Size(341, 412)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveAnn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateAdded As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnnDetails As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAnnTitle As TextBox

End Class
