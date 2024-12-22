<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDetailsForm
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
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 0)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(265, 325)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' AccountDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(265, 325)
        Controls.Add(RichTextBox1)
        Name = "AccountDetailsForm"
        Text = "AccountDetailsForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
End Class
