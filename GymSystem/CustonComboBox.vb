Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomComboBox
    Inherits ComboBox

    ' Property for the custom border color
    Private _borderColor As Color = Color.FromArgb(245, 203, 92)

    ' Property for the custom background color
    Private _bgColor As Color = Color.Gray

    ' Property for the custom foreground color
    Private _foreColor As Color = Color.White

    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BgColor() As Color
        Get
            Return _bgColor
        End Get
        Set(ByVal value As Color)
            _bgColor = value
            Me.BackColor = _bgColor
            Me.Invalidate()
        End Set
    End Property

    Public Property CustomForeColor() As Color
        Get
            Return _foreColor
        End Get
        Set(ByVal value As Color)
            _foreColor = value
            Me.ForeColor = _foreColor
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.DrawMode = DrawMode.OwnerDrawFixed
        Me.DropDownStyle = ComboBoxStyle.DropDown
        Me.FlatStyle = FlatStyle.Flat
    End Sub

    ' Override WndProc for custom border
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = &H85 OrElse m.Msg = &HF Then ' WM_NCPAINT or WM_PAINT
            Dim hdc As IntPtr = GetWindowDC(Me.Handle)
            If hdc <> IntPtr.Zero Then
                Using g As Graphics = Graphics.FromHdc(hdc)
                    ' Draw the border
                    Using pen As New Pen(_borderColor, 2)
                        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
                        g.DrawRectangle(pen, rect)
                    End Using
                End Using
                ReleaseDC(Me.Handle, hdc)
            End If
        End If
    End Sub

    ' Custom draw method to apply background and foreground colors to items
    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        If e.Index >= 0 Then
            Dim backColor As Color = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, SystemColors.Highlight, _bgColor)
            Dim textColor As Color = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, SystemColors.HighlightText, _foreColor)

            Using bgBrush As New SolidBrush(backColor), textBrush As New SolidBrush(textColor)
                e.Graphics.FillRectangle(bgBrush, e.Bounds)
                e.Graphics.DrawString(Me.Items(e.Index).ToString(), Me.Font, textBrush, e.Bounds)
            End Using
        End If
    End Sub

    Public Sub SetItems(items As List(Of String))
        Me.Items.Clear()
        Me.Items.AddRange(items.ToArray())
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetWindowDC(hWnd As IntPtr) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
    End Function


End Class
