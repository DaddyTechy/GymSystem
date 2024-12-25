<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMembershipForm
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
        SubmitBtn = New Button()
        PlansCB = New ComboBox()
        Label1 = New Label()
        PlansLbl = New Label()
        ServiceCB = New ComboBox()
        SuspendLayout()
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.Anchor = AnchorStyles.None
        SubmitBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        SubmitBtn.FlatStyle = FlatStyle.Flat
        SubmitBtn.Location = New Point(104, 230)
        SubmitBtn.Margin = New Padding(3, 2, 3, 2)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.Size = New Size(108, 38)
        SubmitBtn.TabIndex = 54
        SubmitBtn.Text = "Save"
        SubmitBtn.UseVisualStyleBackColor = False
        ' 
        ' PlansCB
        ' 
        PlansCB.Anchor = AnchorStyles.None
        PlansCB.DropDownStyle = ComboBoxStyle.DropDownList
        PlansCB.FormattingEnabled = True
        PlansCB.Location = New Point(104, 110)
        PlansCB.Margin = New Padding(3, 2, 3, 2)
        PlansCB.Name = "PlansCB"
        PlansCB.Size = New Size(219, 23)
        PlansCB.TabIndex = 53
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(104, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 52
        Label1.Text = "Service"
        ' 
        ' PlansLbl
        ' 
        PlansLbl.Anchor = AnchorStyles.None
        PlansLbl.AutoSize = True
        PlansLbl.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PlansLbl.ForeColor = Color.White
        PlansLbl.Location = New Point(104, 91)
        PlansLbl.Name = "PlansLbl"
        PlansLbl.Size = New Size(42, 19)
        PlansLbl.TabIndex = 51
        PlansLbl.Text = "Plans"
        ' 
        ' ServiceCB
        ' 
        ServiceCB.Anchor = AnchorStyles.None
        ServiceCB.DropDownStyle = ComboBoxStyle.DropDownList
        ServiceCB.FormattingEnabled = True
        ServiceCB.Location = New Point(104, 168)
        ServiceCB.Margin = New Padding(3, 2, 3, 2)
        ServiceCB.Name = "ServiceCB"
        ServiceCB.Size = New Size(219, 23)
        ServiceCB.TabIndex = 55
        ' 
        ' NewMembershipForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(426, 358)
        Controls.Add(ServiceCB)
        Controls.Add(SubmitBtn)
        Controls.Add(PlansCB)
        Controls.Add(Label1)
        Controls.Add(PlansLbl)
        Name = "NewMembershipForm"
        Padding = New Padding(20)
        Text = "NewMembershipForm"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents PlansCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlansLbl As Label
    Friend WithEvents ServiceCB As ComboBox
End Class
