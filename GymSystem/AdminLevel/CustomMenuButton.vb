Imports System.Drawing.Drawing2D

Public Class CustomMenuButton
    Inherits Button

    ' Properties for customization
    Public Property CornerRadius As Integer = 20
    Public Property HoverColor As Color = Color.FromArgb(220, 220, 220)
    Public Property ActiveColor As Color = Color.FromArgb(180, 180, 180)
    Private originalButtonColor As Color
    Private hoverButtonColor As Color
    Private hoverDarkenAmount As Single = 0.7

    ' Constructor
    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        originalButtonColor = Me.BackColor
        hoverButtonColor = ControlPaint.Dark(originalButtonColor, hoverDarkenAmount)
    End Sub

    ' Override OnPaint method to customize button appearance
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Create rounded rectangle path (right-side only rounded)
        path.StartFigure()
        path.AddLine(0, 0, Me.Width - CornerRadius, 0)
        path.AddArc(New Rectangle(Me.Width - CornerRadius, 0, CornerRadius, CornerRadius), -90, 90)
        path.AddLine(Me.Width, CornerRadius, Me.Width, Me.Height - CornerRadius)
        path.AddArc(New Rectangle(Me.Width - CornerRadius, Me.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90)
        path.AddLine(Me.Width - CornerRadius, Me.Height, 0, Me.Height)
        path.CloseFigure()

        Me.Region = New Region(path)

        ' Fill button background
        Using brush As New SolidBrush(Me.BackColor)
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pevent.Graphics.FillPath(brush, path)
        End Using

        ' Draw text
        TextRenderer.DrawText(pevent.Graphics, Me.Text, Me.Font, Me.ClientRectangle, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    ' Event handlers for hover and active states
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        Me.BackColor = hoverButtonColor
        Me.ForeColor = Color.White
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.BackColor = originalButtonColor
        Me.ForeColor = Color.Black
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        Me.BackColor = ActiveColor
        Me.ForeColor = Color.White
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        Me.BackColor = hoverButtonColor
        Me.ForeColor = Color.White
    End Sub
End Class
