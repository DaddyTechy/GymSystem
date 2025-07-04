<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MembershipHistoryForm
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
        Me.flpMembershipHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        ' 
        ' flpMembershipHistory
        ' 
        Me.flpMembershipHistory.AutoScroll = True
        Me.flpMembershipHistory.BackColor = System.Drawing.Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Me.flpMembershipHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMembershipHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMembershipHistory.Location = New System.Drawing.Point(0, 0)
        Me.flpMembershipHistory.Name = "flpMembershipHistory"
        Me.flpMembershipHistory.Padding = New System.Windows.Forms.Padding(10)
        Me.flpMembershipHistory.Size = New System.Drawing.Size(800, 450)
        Me.flpMembershipHistory.TabIndex = 0
        Me.flpMembershipHistory.WrapContents = False
        ' 
        ' MembershipHistoryForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.flpMembershipHistory)
        Me.Name = "MembershipHistoryForm"
        Me.Text = "Membership History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpMembershipHistory As FlowLayoutPanel
End Class
