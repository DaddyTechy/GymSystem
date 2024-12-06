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
        panelContainer.Name = "panelContainer"
        panelContainer.Size = New Size(675, 496)
        panelContainer.TabIndex = 0
        ' 
        ' ContentMemEntryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(panelContainer)
        MinimumSize = New Size(675, 496)
        Name = "ContentMemEntryForm"
        Size = New Size(675, 496)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelContainer As Panel

End Class
