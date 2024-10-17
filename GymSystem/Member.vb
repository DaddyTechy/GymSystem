Public Class Member

    '-------Point & Lines----------------
    Private HorX1 As Integer = 200
    Private HorX2 As Integer = 500
    Private HorY1 As Integer = 380
    Private HorY2 As Integer = 380

    Private VerX1 As Integer = 350
    Private VerX2 As Integer = 350
    Private VerY1 As Integer = 480
    Private VerY2 As Integer = 500

    Private Sub Horizontal_Line(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.WhiteSmoke, 1.5)
        g.DrawLine(pen, HorX1, HorY1, HorX2, HorY2)
    End Sub

    Private Sub Vertical_Line(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.FromArgb(245, 203, 92), 2)
        g.DrawLine(pen, VerX1, VerY1, VerX2, VerY2)
    End Sub
    '------------Caret------------------
    Private Declare Function CreateCaret Lib "user32" (ByVal hWnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As Boolean
    Private Declare Function DestroyCaret Lib "user32" () As Long
    Private Declare Function SetCaretBlinkTime Lib "user32" (ByVal wMSeconds As Long) As Long
    Private Declare Function SetCaretPos Lib "user32" (ByVal x As Long, ByVal y As Long) As Long
    Private Declare Function ShowCaret Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Function HideCaret Lib "user32" (ByVal hwnd As Long) As Long
    Private caretBitmap As Bitmap

    Private Sub ID_Caret(sender As Object, e As EventArgs) Handles IDBox.GotFocus
        If caretBitmap Is Nothing Then
            caretBitmap = CreateCaretBitmap()
        End If
        CreateCaret(IDBox.Handle, caretBitmap.GetHbitmap(), 5, 10)
        ShowCaret(IDBox.Handle)
    End Sub

    Private Sub Password_Caret(sender As Object, e As EventArgs) Handles PassBox.GotFocus
        If caretBitmap Is Nothing Then
            caretBitmap = CreateCaretBitmap()
        End If
        CreateCaret(PassBox.Handle, caretBitmap.GetHbitmap(), 5, 10)
        ShowCaret(PassBox.Handle)
    End Sub

    Private Function CreateCaretBitmap() As Bitmap
        Dim flag As New Bitmap(2, 25)
        Dim flagGraphics As Graphics = Graphics.FromImage(flag)
        flagGraphics.FillRectangle(New SolidBrush(Color.FromArgb(0, 255, 255, 255)), 0, 0, 5, 10) ' Uses ARGB values for white
        Return flag
    End Function
    '---------------CheckBox------------------
    Private Sub MeCB_CheckedChanged(sender As Object, e As EventArgs) Handles MeCB.CheckedChanged
        If MeCB.Checked Then
            MeCB.ForeColor = Color.FromArgb(245, 203, 45)
        Else
            MeCB.ForeColor = Color.White
        End If
    End Sub
    '---------------Borders--------------------
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button(LoginBtn)
        Button(JoinBtn)


        Dim idBoxPanel As New Panel()
        idBoxPanel.BackColor = Color.FromArgb(245, 203, 92)
        idBoxPanel.Size = New Size(IDBox.Width + 2, IDBox.Height + 2)
        idBoxPanel.Location = New Point(IDBox.Location.X, IDBox.Location.Y)
        ' Add IDBox to Panel
        idBoxPanel.Controls.Add(IDBox)
        IDBox.Location = New Point(1, 1)
        ' Add Panel to the Form
        Me.Controls.Add(idBoxPanel)

        Dim passBoxPanel As New Panel()
        passBoxPanel.BackColor = Color.FromArgb(245, 203, 92)
        passBoxPanel.Size = New Size(PassBox.Width + 2, PassBox.Height + 2)
        passBoxPanel.Location = New Point(PassBox.Location.X, PassBox.Location.Y)
        ' Add PassBox to Panel
        passBoxPanel.Controls.Add(PassBox)
        PassBox.Location = New Point(1, 1)
        ' Add Panel to the Form
        Me.Controls.Add(passBoxPanel)

    End Sub
    '--------------------------------------------------------
    Private Sub IDBox_TextChanged(sender As Object, e As EventArgs) Handles IDBox.TextChanged
    End Sub

    Private Sub PassBox_TextChanged(sender As Object, e As EventArgs) Handles PassBox.TextChanged
    End Sub

    Private Sub Button(j As Button)
        j.FlatAppearance.BorderSize = 0
        j.FlatStyle = FlatStyle.Flat
        j.BackColor = Color.FromArgb(245, 203, 45)
        j.ForeColor = Color.Black
        j.Cursor = Cursors.Hand
        j.Font = New Font("Century Gothic", 12)

        Dim v As New Drawing2D.GraphicsPath
        v.StartFigure()

        v.AddArc(New RectangleF(0, 0, 20, 20), 180, 90)
        v.AddLine(20, 0, j.Width - 20, 0)

        v.AddArc(New Rectangle(j.Width - 20, 0, 20, 20), -90, 90)
        v.AddLine(j.Width, 20, j.Width, j.Height - 20)

        v.AddArc(New RectangleF(j.Width - 20, j.Height - 20, 20, 20), 10, 90)
        v.AddLine(j.Width - 20, j.Height, 20, j.Height)

        v.AddArc(New Rectangle(0, j.Height - 20, 20, 20), 100, 90)
        v.CloseAllFigures()

        j.Region = New Region(v)
    End Sub


End Class



