<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentMemEntryForm
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
        panelContainer = New Panel()
        SuspendLayout()
        ' 
        ' panelContainer
        ' 
        panelContainer.BackColor = Color.Transparent
        panelContainer.Dock = DockStyle.Fill
        panelContainer.Location = New Point(0, 0)
        panelContainer.Margin = New Padding(3, 4, 3, 4)
        panelContainer.Name = "panelContainer"
        panelContainer.Size = New Size(771, 661)
        panelContainer.TabIndex = 0
        ' 
        ' ContentMemEntryForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(panelContainer)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(771, 661)
        Name = "ContentMemEntryForm"
        Size = New Size(771, 661)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelContainer As Panel

End Class
