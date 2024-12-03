Public Class CalendarForm
    Private currentDate As DateTime = DateTime.Now
    ' Dictionary to store activities for each date (Key: Date, Value: Activity)
    Private activities As New Dictionary(Of DateTime, String)()

    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCalendar()
        DisplayMonthView()
    End Sub

    ' Initialize DataGridView
    Private Sub InitializeCalendar()
        dgvCalendar.ColumnCount = 7
        dgvCalendar.RowHeadersVisible = False
        dgvCalendar.AllowUserToAddRows = False
        dgvCalendar.AllowUserToResizeColumns = False
        dgvCalendar.AllowUserToResizeRows = False
        dgvCalendar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Set column headers for days of the week
        Dim daysOfWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        For i As Integer = 0 To 6
            dgvCalendar.Columns(i).HeaderText = daysOfWeek(i)
            dgvCalendar.Columns(i).Width = 200 ' Increase width to make each day box bigger
        Next

        ' Set up the current month and year label
        lblMonthYear.Text = currentDate.ToString("MMMM yyyy") ' Add this label in the form
    End Sub

    ' Display the current month's view
    Private Sub DisplayMonthView()
        dgvCalendar.Rows.Clear()

        Dim firstDayOfMonth As New DateTime(currentDate.Year, currentDate.Month, 1)
        Dim daysInMonth As Integer = DateTime.DaysInMonth(currentDate.Year, currentDate.Month)
        Dim startDay As Integer = CInt(firstDayOfMonth.DayOfWeek)

        Dim rowIndex As Integer = 0
        dgvCalendar.Rows.Add()
        For i As Integer = 1 To startDay
            dgvCalendar.Rows(rowIndex).Cells(i - 1).Value = ""
        Next

        For day As Integer = 1 To daysInMonth
            Dim cellIndex As Integer = (startDay + day - 1) Mod 7
            If cellIndex = 0 AndAlso day > 1 Then
                rowIndex += 1
                dgvCalendar.Rows.Add()
            End If

            dgvCalendar.Rows(rowIndex).Cells(cellIndex).Value = day
            dgvCalendar.Rows(rowIndex).Height = 200 ' Set the height of each row explicitly

            ' Highlight the current day
            If day = currentDate.Day AndAlso currentDate.Month = DateTime.Now.Month AndAlso currentDate.Year = DateTime.Now.Year Then
                dgvCalendar.Rows(rowIndex).Cells(cellIndex).Style.BackColor = Color.LightBlue
            End If

            ' Check if an activity is assigned to this day
            Dim selectedDate As New DateTime(currentDate.Year, currentDate.Month, day)
            If activities.ContainsKey(selectedDate) Then
                ' Set the background color and forecolor for the cell where activity is present
                dgvCalendar.Rows(rowIndex).Cells(cellIndex).Style.BackColor = Color.DimGray
                dgvCalendar.Rows(rowIndex).Cells(cellIndex).Style.ForeColor = Color.White
                ' Append the activity text without converting the value
                dgvCalendar.Rows(rowIndex).Cells(cellIndex).Value = day & vbCrLf & "Activity: " & activities(selectedDate)
            End If
        Next
    End Sub

    ' Button Click Handlers
    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        currentDate = currentDate.AddMonths(-1)
        lblMonthYear.Text = currentDate.ToString("MMMM yyyy") ' Update month and year
        DisplayMonthView()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        currentDate = currentDate.AddMonths(1)
        lblMonthYear.Text = currentDate.ToString("MMMM yyyy") ' Update month and year
        DisplayMonthView()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles BtnToday.Click
        currentDate = DateTime.Now
        lblMonthYear.Text = currentDate.ToString("MMMM yyyy") ' Update month and year
        DisplayMonthView()
    End Sub

    Private Sub btnDayView_Click(sender As Object, e As EventArgs) Handles btnDayView.Click
        MessageBox.Show("Day View is under construction.")
    End Sub

    Private Sub btnMonthView_Click(sender As Object, e As EventArgs) Handles btnMonthView.Click
        DisplayMonthView()
    End Sub

    Private Sub btnYearView_Click(sender As Object, e As EventArgs) Handles btnYearView.Click
        MessageBox.Show("Year View is under construction.")
    End Sub

    ' Button to enter activity for a selected day
    Private Sub btnEnterActivity_Click(sender As Object, e As EventArgs) Handles btnEnterActivity.Click
        ' Get the selected cell in the DataGridView
        If dgvCalendar.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = dgvCalendar.SelectedCells(0)
            If selectedCell.Value IsNot Nothing AndAlso IsNumeric(selectedCell.Value) Then
                ' Get the day number from the selected cell
                Dim selectedDay As Integer = Convert.ToInt32(selectedCell.Value)
                Dim selectedDate As New DateTime(currentDate.Year, currentDate.Month, selectedDay)

                ' Show the input box or a form to enter the activity
                Dim activity As String = InputBox("Enter your activity for " & selectedDate.ToShortDateString(), "Enter Activity")

                ' If an activity was entered, store it
                If Not String.IsNullOrEmpty(activity) Then
                    activities(selectedDate) = activity
                End If

                ' Refresh the calendar to display activities (if any)
                DisplayMonthView()
            End If
        End If
    End Sub

End Class
