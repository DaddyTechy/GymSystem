<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        PictureBox1 = New PictureBox()
        btnSubmit = New Button()
        txtEmailOrPhone = New TextBox()
        lblEmailOrPhone = New Label()
        lblRole = New Label()
        LabelSign = New Label()
        cmbRole = New ComboBox()
        btnBack = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._929005d9_38b9_4cc8_a97c_a1d57a1bbc1f_1_removebg_preview__1_
        PictureBox1.Location = New Point(568, 125)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSubmit.ForeColor = SystemColors.ActiveCaptionText
        btnSubmit.Location = New Point(121, 343)
        btnSubmit.Margin = New Padding(3, 2, 3, 2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(109, 38)
        btnSubmit.TabIndex = 35
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtEmailOrPhone
        ' 
        txtEmailOrPhone.BackColor = Color.LightGray
        txtEmailOrPhone.BorderStyle = BorderStyle.FixedSingle
        txtEmailOrPhone.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailOrPhone.ForeColor = Color.Black
        txtEmailOrPhone.Location = New Point(121, 279)
        txtEmailOrPhone.Margin = New Padding(3, 2, 3, 2)
        txtEmailOrPhone.Name = "txtEmailOrPhone"
        txtEmailOrPhone.Size = New Size(306, 26)
        txtEmailOrPhone.TabIndex = 32
        ' 
        ' lblEmailOrPhone
        ' 
        lblEmailOrPhone.AutoSize = True
        lblEmailOrPhone.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmailOrPhone.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblEmailOrPhone.Location = New Point(121, 261)
        lblEmailOrPhone.Name = "lblEmailOrPhone"
        lblEmailOrPhone.Size = New Size(160, 17)
        lblEmailOrPhone.TabIndex = 30
        lblEmailOrPhone.Text = "Email or Phone Number*"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblRole.Location = New Point(121, 193)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(65, 17)
        lblRole.TabIndex = 31
        lblRole.Text = "User Role"
        ' 
        ' LabelSign
        ' 
        LabelSign.AutoSize = True
        LabelSign.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        LabelSign.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LabelSign.Location = New Point(121, 125)
        LabelSign.Name = "LabelSign"
        LabelSign.Size = New Size(274, 31)
        LabelSign.TabIndex = 29
        LabelSign.Text = "Password Recovery"
        ' 
        ' cmbRole
        ' 
        cmbRole.BackColor = Color.LightGray
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FlatStyle = FlatStyle.Flat
        cmbRole.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbRole.ForeColor = Color.Black
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Member", "Staff", "Admin"})
        cmbRole.Location = New Point(121, 213)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(88, 23)
        cmbRole.TabIndex = 40
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ActiveCaptionText
        btnBack.Location = New Point(121, 417)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(65, 29)
        btnBack.TabIndex = 41
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(909, 541)
        Controls.Add(btnBack)
        Controls.Add(cmbRole)
        Controls.Add(PictureBox1)
        Controls.Add(btnSubmit)
        Controls.Add(txtEmailOrPhone)
        Controls.Add(lblEmailOrPhone)
        Controls.Add(lblRole)
        Controls.Add(LabelSign)
        MaximumSize = New Size(925, 580)
        MinimumSize = New Size(925, 580)
        Name = "ForgotPasswordForm"
        Text = "Recover Password"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtEmailOrPhone As TextBox
    Friend WithEvents lblEmailOrPhone As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents LabelSign As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnBack As Button
End Class
