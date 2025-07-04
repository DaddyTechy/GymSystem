<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaymentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMember = New Label()
        cmbMember = New ComboBox()
        lblAmount = New Label()
        txtAmount = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        lblPaymentType = New Label()
        cmbPaymentType = New ComboBox()
        SuspendLayout()
        ' 
        ' lblMember
        ' 
        lblMember.AutoSize = True
        lblMember.ForeColor = SystemColors.ButtonHighlight
        lblMember.Location = New Point(10, 14)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(55, 15)
        lblMember.TabIndex = 0
        lblMember.Text = "Member:"
        ' 
        ' cmbMember
        ' 
        cmbMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbMember.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbMember.FormattingEnabled = True
        cmbMember.Location = New Point(88, 11)
        cmbMember.Name = "cmbMember"
        cmbMember.Size = New Size(238, 23)
        cmbMember.TabIndex = 1
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.ForeColor = SystemColors.ButtonHighlight
        lblAmount.Location = New Point(10, 80)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(54, 15)
        lblAmount.TabIndex = 2
        lblAmount.Text = "Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(88, 77)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(238, 23)
        txtAmount.TabIndex = 3
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.ForeColor = SystemColors.ButtonHighlight
        lblDescription.Location = New Point(10, 112)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(70, 15)
        lblDescription.TabIndex = 4
        lblDescription.Text = "Description:"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(88, 109)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(238, 64)
        txtDescription.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Gold
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(172, 188)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(74, 28)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gold
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(252, 188)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(74, 28)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblPaymentType
        ' 
        lblPaymentType.AutoSize = True
        lblPaymentType.ForeColor = SystemColors.ButtonHighlight
        lblPaymentType.Location = New Point(10, 47)
        lblPaymentType.Name = "lblPaymentType"
        lblPaymentType.Size = New Size(35, 15)
        lblPaymentType.TabIndex = 7
        lblPaymentType.Text = "Type:"
        ' 
        ' cmbPaymentType
        ' 
        cmbPaymentType.FormattingEnabled = True
        cmbPaymentType.Items.AddRange(New Object() {"Reservation", "Membership"})
        cmbPaymentType.Location = New Point(88, 44)
        cmbPaymentType.Name = "cmbPaymentType"
        cmbPaymentType.Size = New Size(238, 23)
        cmbPaymentType.TabIndex = 2
        ' 
        ' AddPaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(336, 227)
        Controls.Add(cmbPaymentType)
        Controls.Add(lblPaymentType)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtDescription)
        Controls.Add(lblDescription)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(cmbMember)
        Controls.Add(lblMember)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddPaymentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Payment"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblMember As Label
    Friend WithEvents cmbMember As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents cmbPaymentType As ComboBox
End Class