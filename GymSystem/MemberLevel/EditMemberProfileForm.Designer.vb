<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMemberProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        lblContact = New Label()
        txtContact = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblWeight = New Label()
        txtWeight = New TextBox()
        lblHeight = New Label()
        txtHeight = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.ForeColor = SystemColors.ButtonFace
        lblContact.Location = New Point(26, 28)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(99, 15)
        lblContact.TabIndex = 0
        lblContact.Text = "Contact Number:"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(131, 25)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(176, 23)
        txtContact.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = SystemColors.ButtonFace
        lblEmail.Location = New Point(26, 66)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(84, 15)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email Address:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(131, 63)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(176, 23)
        txtEmail.TabIndex = 3
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.ForeColor = SystemColors.ButtonFace
        lblWeight.Location = New Point(26, 103)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(72, 15)
        lblWeight.TabIndex = 4
        lblWeight.Text = "Weight (kg):"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(131, 100)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(176, 23)
        txtWeight.TabIndex = 5
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.ForeColor = SystemColors.ButtonFace
        lblHeight.Location = New Point(26, 141)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(68, 15)
        lblHeight.TabIndex = 6
        lblHeight.Text = "Height (ft.):"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(131, 138)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(176, 23)
        txtHeight.TabIndex = 7
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Gold
        btnSave.ForeColor = SystemColors.ActiveCaptionText
        btnSave.Location = New Point(131, 188)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(79, 28)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gold
        btnCancel.ForeColor = SystemColors.ActiveCaptionText
        btnCancel.Location = New Point(228, 188)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(79, 28)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditMemberProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(350, 234)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtHeight)
        Controls.Add(lblHeight)
        Controls.Add(txtWeight)
        Controls.Add(lblWeight)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtContact)
        Controls.Add(lblContact)
        ForeColor = SystemColors.ButtonFace
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditMemberProfileForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Profile"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
