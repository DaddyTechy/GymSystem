Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomBorder
    Inherits Panel

    Public Sub New(control As Control)
        Me.BackColor = Color.FromArgb(245, 203, 92)
        Me.Size = New Size(control.Width + 2, control.Height + 2)
        Me.Location = control.Location

        Me.Anchor = AnchorStyles.None
        Me.Dock = DockStyle.None

        ' Add Control to Panel
        Me.Controls.Add(control)
        control.Location = New Point(1, 1)
    End Sub
End Class
