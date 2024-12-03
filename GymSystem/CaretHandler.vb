Imports System.Runtime.InteropServices

Public Class CaretHandler
    <DllImport("user32.dll")>
    Private Shared Function CreateCaret(ByVal hWnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Integer, ByVal nHeight As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function DestroyCaret() As Long
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetCaretBlinkTime(ByVal wMSeconds As Long) As Long
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetCaretPos(ByVal x As Long, ByVal y As Long) As Long
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ShowCaret(ByVal hwnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function HideCaret(ByVal hwnd As Long) As Long
    End Function

    Private caretBitmap As Bitmap

    Private Function CreateCaretBitmap(color As Color) As Bitmap
        Dim bitmap As New Bitmap(3, 30) ' Example size
        Using g As Graphics = Graphics.FromImage(bitmap)
            Using brush As New SolidBrush(color)
                g.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height)
            End Using
        End Using
        Return bitmap
    End Function

    Public Sub InitializeCaret(ByVal control As Control, color As Color)
        If caretBitmap Is Nothing Then
            caretBitmap = CreateCaretBitmap(color)
        End If
        CreateCaret(control.Handle, caretBitmap.GetHbitmap(), caretBitmap.Width, caretBitmap.Height)
        ShowCaret(control.Handle)
    End Sub

    Public Sub HideCaret(ByVal control As Control)
        HideCaret(control.Handle)
        DestroyCaret()
    End Sub
End Class
