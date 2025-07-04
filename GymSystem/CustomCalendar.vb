Public Class CustomCalendar
    Inherits DateTimePicker

    Private calendarButton As Button
    Private indicator As String = "MM/dd/yyyy"
    Private indicatorBrush As SolidBrush = New SolidBrush(Color.Gray)

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.CustomFormat = indicator
        Me.Format = DateTimePickerFormat.Custom
        ' Initialize the calendar button
        InitializeCalendarButton()
        ' Subscribe to the ValueChanged event
        AddHandler Me.ValueChanged, AddressOf OnValueChanged
    End Sub

    Private Sub InitializeCalendarButton()
        calendarButton = New Button()
        calendarButton.Size = New Size(SystemInformation.VerticalScrollBarWidth, Me.ClientSize.Height)
        calendarButton.Location = New Point(Me.ClientSize.Width - calendarButton.Width, 0)
        calendarButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        ' Resize the image to a fixed icon size
        Dim originalImage As Image = My.Resources.calendar
        Dim resizedImage As New Bitmap(originalImage, New Size(18, 18))
        calendarButton.Image = resizedImage
        calendarButton.ImageAlign = ContentAlignment.MiddleCenter

        calendarButton.Cursor = Cursors.Hand
        calendarButton.FlatStyle = FlatStyle.Flat
        calendarButton.FlatAppearance.BorderSize = 0
        calendarButton.BackColor = SystemColors.Control

        Me.Controls.Add(calendarButton)
        AddHandler calendarButton.Click, AddressOf CalendarButton_Click
    End Sub

    Private Sub CalendarButton_Click(sender As Object, e As EventArgs)
        ' Focus the DateTimePicker to show the calendar
        Me.Focus()
        Me.Select()
        SendKeys.Send("%{DOWN}") ' Send ALT+DOWN to open the calendar
    End Sub

    Private Sub OnValueChanged(sender As Object, e As EventArgs)
        ' Update the display format once a date is selected
        Me.CustomFormat = indicator
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        ' Fill the background
        e.Graphics.FillRectangle(New SolidBrush(Color.Gray), ClientRectangle)
        ' Draw the border
        Using pen As New Pen(Color.FromArgb(245, 203, 92), 2)
            e.Graphics.DrawRectangle(pen, 0, 0, Me.Width - 0, Me.Height - 0)
        End Using
        ' Draw the text, showing the indicator initially
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Color.White), 0, 3)
    End Sub
End Class
