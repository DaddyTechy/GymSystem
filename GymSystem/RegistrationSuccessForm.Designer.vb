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
        pnlMain = New Panel()
        lblTitle = New Label()
        lblMemberIDInfo = New Label()
        lblMemberID = New Label()
        btnDone = New Button()
        Label1 = New Label()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Controls.Add(lblMemberIDInfo)
        pnlMain.Controls.Add(lblMemberID)
        pnlMain.Controls.Add(btnDone)
        pnlMain.Controls.Add(Label1)
        pnlMain.Location = New Point(171, 95)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(500, 320)
        pnlMain.TabIndex = 6
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(92, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(355, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Registration Payment Successful!"
        ' 
        ' lblMemberIDInfo
        ' 
        lblMemberIDInfo.AutoSize = True
        lblMemberIDInfo.Font = New Font("Segoe UI", 12.0F)
        lblMemberIDInfo.ForeColor = Color.White
        lblMemberIDInfo.Location = New Point(58, 81)
        lblMemberIDInfo.Name = "lblMemberIDInfo"
        lblMemberIDInfo.Size = New Size(175, 21)
        lblMemberIDInfo.TabIndex = 1
        lblMemberIDInfo.Text = "Your new Member ID is:"
        ' 
        ' lblMemberID
        ' 
        lblMemberID.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblMemberID.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblMemberID.ForeColor = Color.White
        lblMemberID.Location = New Point(16, 115)
        lblMemberID.Name = "lblMemberID"
        lblMemberID.Size = New Size(467, 25)
        lblMemberID.TabIndex = 2
        lblMemberID.Text = "10010"
        lblMemberID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnDone
        ' 
        btnDone.Font = New Font("Segoe UI", 12.0F)
        btnDone.Location = New Point(163, 227)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(175, 46)
        btnDone.TabIndex = 3
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(58, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 21)
        Label1.TabIndex = 5
        Label1.Text = "You can now log in with your credentials."
        ' 
        ' RegistrationSuccessForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(40, 40, 40)
        ClientSize = New Size(843, 510)
        Controls.Add(pnlMain)
        Name = "RegistrationSuccessForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Success"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
#End Region

    Private lblTitle As Label
    Private lblMemberIDInfo As Label
    Private lblMemberID As Label
    Private WithEvents btnDone As Button
    Private WithEvents Label1 As Label
End Class
