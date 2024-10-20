Public Class CustomTextBox
    Inherits TextBox

    Private caretColor As Color = Color.Red
    Private caretTimer As Timer

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        caretTimer = New Timer()
        AddHandler caretTimer.Tick, AddressOf OnCaretTimerTick
        caretTimer.Interval = 500
        caretTimer.Start()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        DrawCaret(e.Graphics)
    End Sub

    Private Sub DrawCaret(g As Graphics)
        ' Get caret position
        Dim caretPos As Point = Me.GetPositionFromCharIndex(Me.SelectionStart)
        ' Draw custom caret
        Using caretBrush As New SolidBrush(caretColor)
            g.FillRectangle(caretBrush, caretPos.X, caretPos.Y, 2, Me.Font.Height)
        End Using
    End Sub

    Private Sub OnCaretTimerTick(sender As Object, e As EventArgs)
        Me.Invalidate()
    End Sub
End Class


