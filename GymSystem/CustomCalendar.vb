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
        calendarButton.Size = New Size(20, 20)
        calendarButton.Location = New Point(Me.Width - calendarButton.Width - -43, 2.8)
        ' Resize the image
        Dim originalImage As Image = My.Resources.calendar ' Your resource name
        Dim resizedImage As New Bitmap(originalImage, New Size(calendarButton.Width, calendarButton.Height))
        calendarButton.Image = resizedImage
        calendarButton.Cursor = Cursors.Hand
        calendarButton.BackColor = Color.Gray ' Match the background color
        calendarButton.FlatStyle = FlatStyle.Flat
        calendarButton.FlatAppearance.BorderSize = 0
        ' Add the button to the parent control
        Me.Controls.Add(calendarButton)
        ' Add a click event handler to show the calendar
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
