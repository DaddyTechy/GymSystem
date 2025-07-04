Imports MySql.Data.MySqlClient

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
        Public Property EndTime As String
        Public Property Instructor As String
        Public Property Status As String
    End Class

    ' Form Load Event
    Private Sub Sched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize sample events
        allEvents = New List(Of CalendarEvent)()

        ' Load events from the database
        LoadEventsFromDatabase()

        ' Set up DataGridView styling
        SetupDataGridViewStyle()

        ' Load default view
        LoadCalendar(viewMode, currentDate)

        ' Add this code to your form's constructor or Load event
        AddHandler DataGridView1.CellMouseClick, AddressOf DataGridView1_CellMouseClick
    End Sub

    ' Load Events from Database
    Private Sub LoadEventsFromDatabase()
        allEvents.Clear() ' Clear existing events before loading new ones
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            ' Corrected query to fetch StartTime and EndTime
            Dim query As String = "SELECT CAST(CONCAT(r.ReservationDate, ' ', r.StartTime) AS DATETIME) AS EventDateTime, " &
                                  "r.StartTime, r.EndTime, r.Purpose AS Title, CONCAT(s.FirstName, ' ', s.LastName) AS Instructor, r.ReservationStatus AS Status " &
                                  "FROM reservation r " &
                                  "JOIN staff s ON r.StaffID = s.StaffID " &
                                  $"WHERE s.Position = 'Trainer' AND r.MemberID = {CurrentLoggedUser.id}"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim eventDateTime As DateTime = reader.GetDateTime("EventDateTime")
                        Dim startTime As TimeSpan = reader.GetTimeSpan("StartTime")
                        Dim endTime As TimeSpan = reader.GetTimeSpan("EndTime")

                        Dim newEvent As New CalendarEvent With {
                            .EventDate = eventDateTime,
                            .Time = DateTime.Today.Add(startTime).ToString("hh:mm tt"),
                            .EndTime = DateTime.Today.Add(endTime).ToString("hh:mm tt"),
                            .Title = reader.GetString("Title"),
                            .Instructor = reader.GetString("Instructor"),
                            .Status = reader.GetString("Status")
                        }
                        allEvents.Add(newEvent)
                    End While
                End Using
            End Using
        End Using
    End Sub


    ' Event handler for CellMouseClick event
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString()

            If Not String.IsNullOrEmpty(cellValue) AndAlso Integer.TryParse(cellValue.Split(Environment.NewLine)(0), Nothing) Then
                Dim day As Integer = Integer.Parse(cellValue.Split(Environment.NewLine)(0))
                Dim selectedDate As DateTime = New Date(currentDate.Year, currentDate.Month, day)

                Dim eventsForDay = allEvents.Where(Function(ev) ev.EventDate.Date = selectedDate.Date).ToList()

                If eventsForDay.Any() Then
                    Dim contextMenu = New ContextMenuStrip()

                    ' --- View Details ---
                    Dim viewDetailsItem = New ToolStripMenuItem("View Details")
                    AddHandler viewDetailsItem.Click, Sub(s, args) ViewDetails_Click(selectedDate)
                    contextMenu.Items.Add(viewDetailsItem)

                    ' --- Cancel Reservation ---
                    Dim cancellableEvents = eventsForDay.Where(Function(ev) (ev.EventDate - DateTime.Now).TotalHours > 24).ToList()

                    If cancellableEvents.Any() Then
                        Dim cancelMenuItem = New ToolStripMenuItem("Cancel Reservation")
                        If cancellableEvents.Count = 1 Then
                            ' If only one event, make it a direct click
                            AddHandler cancelMenuItem.Click, Sub(s, args) CancelReservation_Click(cancellableEvents.First())
                        Else
                            ' If multiple events, create a sub-menu
                            For Each ev In cancellableEvents
                                Dim subMenuItem = New ToolStripMenuItem($"{ev.Title} at {ev.Time}")
                                AddHandler subMenuItem.Click, Sub(s, args) CancelReservation_Click(ev)
                                cancelMenuItem.DropDownItems.Add(subMenuItem)
                            Next
                        End If
                        contextMenu.Items.Add(cancelMenuItem)
                    End If

                    contextMenu.Show(DataGridView1, e.Location)
                End If
            End If
        End If
    End Sub

    Private Sub ViewDetails_Click(selectedDate As DateTime)
        Dim eventsForDay = allEvents.Where(Function(ev) ev.EventDate.Date = selectedDate.Date).ToList()
        Dim details As String = ""
        For Each ev In eventsForDay
            details &= $"Session: {ev.Title}{Environment.NewLine}"
            details &= $"Time: {ev.Time}{Environment.NewLine}"
            details &= $"Instructor: {ev.Instructor}{Environment.NewLine}{Environment.NewLine}"
        Next
        MessageBox.Show(details, "Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CancelReservation_Click(eventToCancel As CalendarEvent)
        Dim confirmationText As String = $"Are you sure you want to cancel the '{eventToCancel.Title}' session at {eventToCancel.Time}?"
        Dim result = MessageBox.Show(confirmationText, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(strConnection)
                    conn.Open()
                    ' Use the full EventDate (which includes time) to be specific
                    Dim query As String = "UPDATE reservation SET ReservationStatus = 'Cancelled' WHERE MemberID = @MemberID AND ReservationDate = @ReservationDate"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@MemberID", CurrentLoggedUser.id)
                        cmd.Parameters.AddWithValue("@ReservationDate", eventToCancel.EventDate)

                        Dim rowsAffected = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Remove the specific event from the local list
                            allEvents.Remove(eventToCancel)

                            ' Refresh the calendar
                            LoadCalendar(viewMode, currentDate)

                            MessageBox.Show("Reservation successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Could not find the reservation to cancel. It might have been modified by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while cancelling the reservation: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    ' Load Calendar
    Private Sub LoadCalendar(viewMode As String, selectedDate As Date)
        DataGridView1.Rows.Clear()
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        If viewMode = "Month" Then
            LoadMonthView(selectedDate)
        ElseIf viewMode = "Week" Then
            LoadWeekView(selectedDate)
        ElseIf viewMode = "Day" Then
            LoadDayView(selectedDate)
        End If

        lblCurrentDate.Text = selectedDate.ToString("MMMM yyyy")
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
                    Dim emptyCell = New DataGridViewTextBoxCell With {.Value = ""}
                    emptyCell.Style.BackColor = Color.FromArgb(40, 40, 40)
                    row.Cells.Add(emptyCell)
                Else
                    Dim cellDate As Date = New Date(selectedDate.Year, selectedDate.Month, currentDay)
                    Dim cell = New DataGridViewTextBoxCell With {.Value = currentDay.ToString()}

                    ' Set default style first
                    cell.Style.BackColor = Color.FromArgb(40, 40, 40)
                    cell.Style.ForeColor = Color.White

                    ' Highlight the current day (overrides default)
                    If cellDate.Date = Date.Today Then
                        cell.Style.BackColor = Color.DodgerBlue
                    End If

                    ' Add events, which may override the color again for events
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
    Private Sub AddEventsToCell(cell As DataGridViewCell, cellDate As Date)
        Dim eventsForDay = allEvents.Where(Function(ev) ev.EventDate.Date = cellDate.Date).OrderBy(Function(ev) ev.EventDate).ToList()
        Dim cellText As String = cell.Value.ToString()
        Dim tooltipParts As New List(Of String)()

        If eventsForDay.Any() Then
            For Each ev In eventsForDay
                ' Append event text with full time range and status
                Dim eventText = $"{Environment.NewLine}{ev.Time} - {ev.EndTime} - {ev.Title} ({ev.Status})"
                cellText &= eventText
                ' Add tooltip part to list with full time range
                tooltipParts.Add($"Session: {ev.Title}{Environment.NewLine}Time: {ev.Time} - {ev.EndTime}{Environment.NewLine}Status: {ev.Status}{Environment.NewLine}Instructor: {ev.Instructor}")

                ' Set background color based on status first, then event type
                Dim isToday As Boolean = (cell.Style.BackColor = Color.DodgerBlue)

                Select Case ev.Status.ToLower()
                    Case "completed", "cancelled"
                        cell.Style.BackColor = Color.Gray
                    Case Else
                        ' Only set event type color if not 'Today' or if status doesn't override
                        If Not isToday Then
                            Select Case ev.Title.ToLower()
                                Case "strength"
                                    cell.Style.BackColor = Color.FromArgb(219, 8, 32) ' Red
                                Case "cardio"
                                    cell.Style.BackColor = Color.FromArgb(3, 155, 229) ' Cyan
                                Case "yoga"
                                    cell.Style.BackColor = Color.FromArgb(76, 175, 80) ' Green
                            End Select
                        End If
                End Select
            Next
            cell.Value = cellText
            ' Join tooltip parts with a separator
            cell.ToolTipText = String.Join($"{Environment.NewLine}--------------------{Environment.NewLine}", tooltipParts)
            cell.Style.WrapMode = DataGridViewTriState.True
        End If
    End Sub

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
            MessageBox.Show($"Reserve for this day: {cellValue}")

            ' Check if the cell contains a valid day number
            If Not String.IsNullOrEmpty(cellValue) AndAlso Integer.TryParse(cellValue.Split(Environment.NewLine)(0), Nothing) Then
                Dim selectedDate As DateTime = New Date(currentDate.Year, currentDate.Month, CInt(cellValue.Split(Environment.NewLine)(0)))
                ShowEventForm(selectedDate)
            Else
                MessageBox.Show("Invalid cell value or no day number found.")
            End If
        End If
    End Sub

    ' In your main form or a shared module
    ' In your main form or a shared module
    Private Sub ShowEventForm(selectedDate As DateTime)
        ' Check if there are any events for the selected date
        Dim eventsForDay = allEvents.Where(Function(ev) ev.EventDate.Date = selectedDate.Date).ToList()

        If eventsForDay.Count > 0 Then
            MessageBox.Show("There is already a reservation for this day.", "Reservation Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

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