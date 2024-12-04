Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomBorder
    Inherits Panel

    Public Sub New(textBox As TextBox)
        Me.BackColor = Color.FromArgb(245, 203, 92)
        Me.Size = New Size(textBox.Width + 2, textBox.Height + 2)
        Me.Location = textBox.Location

        Me.Anchor = AnchorStyles.None
        Me.Dock = DockStyle.None

        ' Add TextBox to Panel
        Me.Controls.Add(textBox)
        textBox.Location = New Point(1, 1)
    End Sub
End Class
