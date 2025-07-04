Partial Class RegistrationSuccessForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMemberIDInfo = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.btnProceedToPayment = New System.Windows.Forms.Button()
        Me.btnPayLater = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' pnlMain
        ' 
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Controls.Add(Me.lblMemberIDInfo)
        Me.pnlMain.Controls.Add(Me.lblMemberID)
        Me.pnlMain.Controls.Add(Me.btnProceedToPayment)
        Me.pnlMain.Controls.Add(Me.btnPayLater)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Location = New System.Drawing.Point(171, 95) ' Temporary location
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(500, 320)
        Me.pnlMain.TabIndex = 6
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(121, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Registration Successful!"
        ' 
        ' lblMemberIDInfo
        ' 
        Me.lblMemberIDInfo.AutoSize = True
        Me.lblMemberIDInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblMemberIDInfo.ForeColor = System.Drawing.Color.White
        Me.lblMemberIDInfo.Location = New System.Drawing.Point(58, 81)
        Me.lblMemberIDInfo.Name = "lblMemberIDInfo"
        Me.lblMemberIDInfo.Size = New System.Drawing.Size(175, 21)
        Me.lblMemberIDInfo.TabIndex = 1
        Me.lblMemberIDInfo.Text = "Your new Member ID is:"
        ' 
        ' lblMemberID
        ' 
        Me.lblMemberID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMemberID.ForeColor = System.Drawing.Color.White
        Me.lblMemberID.Location = New System.Drawing.Point(16, 115)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(467, 25)
        Me.lblMemberID.TabIndex = 2
        Me.lblMemberID.Text = "10010"
        Me.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' btnProceedToPayment
        ' 
        Me.btnProceedToPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnProceedToPayment.Location = New System.Drawing.Point(60, 227)
        Me.btnProceedToPayment.Name = "btnProceedToPayment"
        Me.btnProceedToPayment.Size = New System.Drawing.Size(175, 46)
        Me.btnProceedToPayment.TabIndex = 3
        Me.btnProceedToPayment.Text = "Proceed to Payment"
        Me.btnProceedToPayment.UseVisualStyleBackColor = True
        ' 
        ' btnPayLater
        ' 
        Me.btnPayLater.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPayLater.Location = New System.Drawing.Point(260, 227)
        Me.btnPayLater.Name = "btnPayLater"
        Me.btnPayLater.Size = New System.Drawing.Size(175, 46)
        Me.btnPayLater.TabIndex = 4
        Me.btnPayLater.Text = "Pay Later"
        Me.btnPayLater.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(58, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Use it as Username/ID."
        ' 
        ' RegistrationSuccessForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(40, Byte), CType(40, Byte), CType(40, Byte))
        Me.ClientSize = New System.Drawing.Size(843, 510)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Name = "RegistrationSuccessForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Success"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
#End Region

    Private lblTitle As Label
    Private lblMemberIDInfo As Label
    Private lblMemberID As Label
    Private WithEvents btnProceedToPayment As Button
    Private WithEvents btnPayLater As Button
    Private WithEvents Label1 As Label
End Class
