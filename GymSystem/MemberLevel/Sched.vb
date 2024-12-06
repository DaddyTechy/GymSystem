Public Class Sched
    ' Global variables for managing the calendar
    Private currentDate As Date = Date.Today
    Private viewMode As String = "Month" ' Default to Month view
    Private eventForm As EventForm = Nothing

    ' Sample events
    Private allEvents As List(Of CalendarEvent)

    ' Calendar Event Class
    Public Class CalendarEvent
        Public Property EventDate As DateTime
        Public Property Title As String
        Public Property Time As String
        Public Property Instructor As String
    End Class

    ' Form Load Event
    Private Sub Sched_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Initialize sample events
        allEvents = New List(Of CalendarEvent) From {
            New CalendarEvent With {.EventDate = New Date(2024, 10, 2), .Title = "Power Lifting Session", .Time = "1:00 PM - 3:00 PM", .Instructor = "Jake"},
            New CalendarEvent With {.EventDate = New Date(2024, 10, 5), .Title = "Yoga Class", .Time = "10:00 AM - 11:00 AM", .Instructor = "Anna"}
        }

        ' Set up DataGridView styling
        SetupDataGridViewStyle()

        ' Load default view
        LoadCalendar(viewMode, currentDate)
    End Sub

    ' Load Calendar
    Private Sub LoadCalendar(viewMode As String, selectedDate As Date)
        DataGridView1.Rows.Clear()

        If viewMode = "Month" Then
            LoadMonthView(selectedDate)
        ElseIf viewMode = "Week" Then
            LoadWeekView(selectedDate)
        ElseIf viewMode = "Day" Then
            LoadDayView(selectedDate)
        End If

        lblCurrentDate.Text = selectedDate.ToString("MMMM yyyy")
        SetCellBackgroundColor()
    End Sub

    ' Method to apply background color to all cells
    Private Sub SetCellBackgroundColor()
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Style.BackColor = Color.FromArgb(40, 40, 40)
                cell.Style.ForeColor = Color.White
            Next
        Next
    End Sub

    Private Sub LoadDayView(selectedDate As Date)
        ' TODO: Implement day view
        MessageBox.Show("Day view not yet implemented", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LoadWeekView(selectedDate As Date)
        ' TODO: Implement week view
        MessageBox.Show("Week view not yet implemented", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Load Month View
    Private Sub LoadMonthView(selectedDate As Date)
        Dim firstDay As Date = New Date(selectedDate.Year, selectedDate.Month, 1)
        Dim startDay As Integer = firstDay.DayOfWeek
        Dim daysInMonth As Integer = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month)

        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).HeaderText = "Sunday"
        DataGridView1.Columns(1).HeaderText = "Monday"
        DataGridView1.Columns(2).HeaderText = "Tuesday"
        DataGridView1.Columns(3).HeaderText = "Wednesday"
        DataGridView1.Columns(4).HeaderText = "Thursday"
        DataGridView1.Columns(5).HeaderText = "Friday"
        DataGridView1.Columns(6).HeaderText = "Saturday"

        Dim currentDay As Integer = 1
        Dim row As DataGridViewRow = Nothing

        While currentDay <= daysInMonth
            row = New DataGridViewRow()
            For i As Integer = 0 To 6
                If (currentDay > daysInMonth OrElse (i < startDay AndAlso currentDay = 1)) Then
                    row.Cells.Add(New DataGridViewTextBoxCell With {.Value = ""})
                Else
                    Dim cellDate As Date = New Date(selectedDate.Year, selectedDate.Month, currentDay)
                    Dim cell = New DataGridViewTextBoxCell With {.Value = currentDay.ToString()}
                    AddEventsToCell(cell, cellDate)
                    row.Cells.Add(cell)
                    currentDay += 1
                End If
            Next
            DataGridView1.Rows.Add(row)
        End While

        AdjustRowHeights()
    End Sub

    ' Add Events to Calendar Cell
    Private Sub AddEventsToCell(cell As DataGridViewCell, cellDate As DateTime)
        Dim eventsForDay = allEvents.Where(Function(ev) ev.EventDate.Date = cellDate.Date).ToList()

        ' Start with the day number
        Dim cellText As String = cell.Value.ToString() ' Keep the day number

        ' Add each event on a new line with wrapped text
        For Each ev In eventsForDay
            ' Format the event text to be more compact
            Dim eventText = $"{Environment.NewLine}{TruncateText(ev.Title, 15)}"
            If Not String.IsNullOrEmpty(ev.Instructor) Then
                eventText &= $"{Environment.NewLine}({TruncateText(ev.Instructor, 10)})"
            End If
            cellText &= eventText
        Next

        cell.Value = cellText

        ' Set cell style for word wrapping
        cell.Style.WrapMode = DataGridViewTriState.True
    End Sub

    ' Helper function to truncate text
    Private Function TruncateText(text As String, maxLength As Integer) As String
        If String.IsNullOrEmpty(text) Then Return String.Empty
        If text.Length <= maxLength Then Return text
        Return text.Substring(0, maxLength - 3) & "..."
    End Function

    ' Update the AdjustRowHeights method to accommodate the wrapped text
    Private Sub AdjustRowHeights()
        ' Set column widths
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Set minimum row height
        Dim minimumHeight As Integer = 80 ' Adjust this value as needed

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.MinimumHeight = minimumHeight
            row.Height = minimumHeight
        Next

        ' Additional DataGridView styling
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridView1.RowHeadersVisible = False

        ' Adjust column headers
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    ' Add this to your Form_Load or constructor
    Private Sub SetupDataGridViewStyle()
        ' Set general DataGridView properties
        With DataGridView1
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .DefaultCellStyle.Padding = New Padding(5)
            .RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

            ' Prevent cell content from being cut off
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .RowTemplate.Height = 80 ' Minimum row height

            ' Optional: Prevent user from resizing rows
            .AllowUserToResizeRows = False
        End With
    End Sub

    ' Navigation Buttons
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If viewMode = "Month" Then
            currentDate = currentDate.AddMonths(-1)
        End If
        LoadCalendar(viewMode, currentDate)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If viewMode = "Month" Then
            currentDate = currentDate.AddMonths(1)
        End If
        LoadCalendar(viewMode, currentDate)
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        currentDate = Date.Today
        LoadCalendar(viewMode, currentDate)
    End Sub



    ' Handle double-click on calendar cell
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()
            MessageBox.Show($"Cell Value: {cellValue}")

            ' Check if the cell contains a valid day number
            If Not String.IsNullOrEmpty(cellValue) AndAlso Integer.TryParse(cellValue.Split(Environment.NewLine)(0), Nothing) Then
                Dim selectedDate As DateTime = New Date(currentDate.Year, currentDate.Month, CInt(cellValue.Split(Environment.NewLine)(0)))
                ShowEventForm(selectedDate)
            Else
                MessageBox.Show("Invalid cell value or no day number found.")
            End If
        End If
    End Sub


    ' Show the event form
    Private Sub ShowEventForm(selectedDate As DateTime)
        ' Remove existing event form if any
        If eventForm IsNot Nothing Then
            Controls.Remove(eventForm)
        End If

        ' Create and position the new event form
        eventForm = New EventForm(selectedDate)
        AddHandler eventForm.EventSaved, AddressOf HandleEventSaved

        ' Center the event form
        eventForm.Location = New Point(
            (ClientSize.Width - eventForm.Width) \ 2,
            (ClientSize.Height - eventForm.Height) \ 2
        )

        Controls.Add(eventForm)
        eventForm.BringToFront()
    End Sub

    ' Handle saved events
    Private Sub HandleEventSaved(newEvent As CalendarEvent)
        ' Add the new event to the list
        allEvents.Add(newEvent)
        ' Reload the calendar to show the new event
        LoadCalendar(viewMode, currentDate)
    End Sub

    ' Public method to add new events
    Public Sub AddNewEvent(newEvent As CalendarEvent)
        allEvents.Add(newEvent)
        LoadCalendar(viewMode, currentDate)
    End Sub
End Class
