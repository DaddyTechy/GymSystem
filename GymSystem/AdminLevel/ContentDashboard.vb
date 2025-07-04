Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Reflection.Metadata.Ecma335

Public Class ContentDashboard
    Private conn As MySqlConnection
    Private toolTip1 As New ToolTip()
    Private WithEvents staffReservationsContextMenu As New ContextMenuStrip()
    Private dgvStaffReservations As DataGridView
    Private gbStaffReservations As GroupBox
    Private Sub ContentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        CustomizeChartAxis()
        Try
            conn.Open()
            Debug.WriteLine("Connection opened successfully.")

            ' Load initial data for an 'all-time' range
            LoadInitialData()

            ' Load announcements
            LoadAnnouncements()

        Catch ex As Exception
            MsgBox(ex.Message)
            Debug.WriteLine($"Error: {ex.Message}")
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
                Debug.WriteLine("Connection closed.")
            End If
        End Try
        InitializeStaffReservationsControls()
        InitializeAnnouncementsControls()
        LoadStaffReservations()
    End Sub

    Private Sub LoadInitialData()
        ' Load initial data for an 'all-time' range
        Dim allTimeStart As DateTime = DateTime.MinValue
        Dim allTimeEnd As DateTime = DateTime.MaxValue

        ' Load charts with all-time data
        Dim membershipData As DataTable = FetchMembershipData(allTimeStart, allTimeEnd)
        LoadMembershipChartData(membershipData)

        ' Fetch, calculate, and display Total Expenses for all-time
        Dim allTimeExpensesData As DataTable = FetchExpensesData(allTimeStart, allTimeEnd)
        Dim totalExpenses As Double = CalculateTotalExpenses(allTimeExpensesData)
        toolTip1.SetToolTip(dashbrdTEdata, totalExpenses.ToString("N2"))
        dashbrdTEdata.Text = FormatNumber(totalExpenses)

        LoadEarningsAndExpensesChart(allTimeStart, allTimeEnd)

        ' Load non-date-filtered charts
        Dim genderData As DataTable = FetchGenderData()
        LoadGenderChartData(genderData)
        Dim staffSpecializationData As DataTable = FetchStaffSpecializationData()
        LoadStaffSpecializationChartData(staffSpecializationData)

        ' Load summary data with all-time values
        LoadDashboardSummaryData(allTimeStart, allTimeEnd)

    End Sub


    Private Function CalculateTotalExpenses(expensesData As DataTable) As Double
        Dim totalExpenses As Double = 0
        For Each row As DataRow In expensesData.Rows
            Dim amount As Double = If(IsDBNull(row("Amount")), 0, Convert.ToDouble(row("Amount")))
            totalExpenses += amount
        Next
        Return totalExpenses
    End Function


    Private Sub LoadDashboardSummaryData(startDate As DateTime, endDate As DateTime)
        Dim query As String = ""
        ' Query for new memberships within the date range
        query &= $"SELECT 'TotalMembers', COUNT(*) FROM membership WHERE StartDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'; "
        ' Query for total staff (not date-dependent)
        query &= "SELECT 'StaffUsers', COUNT(*) FROM staff; "
        ' Query for operational equipment (not date-dependent)
        query &= "SELECT 'ActiveEquipment', COUNT(*) FROM equipment WHERE Status = 'Operational'; "
        ' Query for active trainers (not date-dependent)
        query &= "SELECT 'ActiveTrainers', COUNT(*) FROM staff WHERE Position = 'Trainer'; "
        ' Query for attendance within the date range
        query &= $"SELECT 'PresentMembers', COUNT(*) FROM attendance WHERE Date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'; "

        Using command As New MySqlCommand(query, conn)
            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Read TotalMembers
                If reader.HasRows Then
                    reader.Read()
                    dashbrdTMData.Text = If(reader.IsDBNull(1), "0", FormatNumber(Convert.ToDouble(reader.GetValue(1))))
                End If

                ' Read StaffUsers
                reader.NextResult()
                If reader.HasRows Then
                    reader.Read()
                    dashbrdSUdata.Text = If(reader.IsDBNull(1), "0", FormatNumber(Convert.ToDouble(reader.GetValue(1))))
                End If

                ' Read ActiveEquipment
                reader.NextResult()
                If reader.HasRows Then
                    reader.Read()
                    dashbrdAEdata.Text = If(reader.IsDBNull(1), "0", FormatNumber(Convert.ToDouble(reader.GetValue(1))))
                End If

                ' Read ActiveTrainers
                reader.NextResult()
                If reader.HasRows Then
                    reader.Read()
                    dashbrdACTdata.Text = If(reader.IsDBNull(1), "0", FormatNumber(Convert.ToDouble(reader.GetValue(1))))
                End If

                ' Read PresentMembers
                reader.NextResult()
                If reader.HasRows Then
                    reader.Read()
                    dashbrdPMdata.Text = If(reader.IsDBNull(1), "0", FormatNumber(Convert.ToDouble(reader.GetValue(1))))
                End If
            End Using
        End Using
    End Sub

    Private Sub InitializeConnection()
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
    End Sub
    Private Sub dtpStartFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartFilter.ValueChanged
        ValidateDateRange()
    End Sub

    Private Sub dtpEndFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndFilter.ValueChanged
        ValidateDateRange()
    End Sub

    Private Sub ValidateDateRange()
        If dtpEndFilter.Value < dtpStartFilter.Value Then
            MessageBox.Show("End date cannot be earlier than start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndFilter.Value = dtpStartFilter.Value ' This will trigger the ValueChanged event and re-run this logic
        Else
            ' Call your methods to filter and load data based on the selected date range
            Try
                conn.Open()
                FilterAndLoadData()
            Catch ex As Exception
                MsgBox(ex.Message)
                Debug.WriteLine($"Error in ValidateDateRange: {ex.Message}")
            Finally
                If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub FilterAndLoadData()
        Try
            ' Implement your logic to filter data based on the selected date range
            Dim startDate As DateTime = dtpStartFilter.Value
            Dim endDate As DateTime = dtpEndFilter.Value
            Debug.WriteLine($"Selected date range: {startDate} to {endDate}")

            ' Fetch chart and summary data
            Dim membershipData As DataTable = FetchMembershipData(startDate, endDate)
            Dim earningsData As DataTable = FetchEarningsData(startDate, endDate)
            Dim expensesData As DataTable = FetchExpensesData(startDate, endDate)
            LoadDashboardSummaryData(startDate, endDate)

            If membershipData.Rows.Count = 0 AndAlso earningsData.Rows.Count = 0 AndAlso expensesData.Rows.Count = 0 Then
                MessageBox.Show("No data available for the selected date range.", "Data Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear the charts and totals since there is no data
                servicesreportChart.Series.Clear()
                chartEarnings.Series.Clear()
                dashbrdTEdata.Text = "0.00"
            Else
                ' Load the data into the charts
                LoadMembershipChartData(membershipData)
                LoadChartData(earningsData, expensesData)

                ' Calculate and update total expenses
                Dim totalExpenses As Double = CalculateTotalExpenses(expensesData)
                toolTip1.SetToolTip(dashbrdTEdata, totalExpenses.ToString("N2")) ' Set full value in tooltip
                dashbrdTEdata.Text = FormatNumber(totalExpenses) ' Set formatted value in label
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("A data conversion error occurred. Please check the data for the selected range.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MsgBox(ex.Message)
            Debug.WriteLine($"Error in FilterAndLoadData: {ex.Message}")
        End Try
    End Sub


    Private Sub ResetDatePickers()
        dtpStartFilter.Value = DateTime.Now.AddMonths(-10) ' Set to one month ago
        dtpEndFilter.Value = DateTime.Now ' Set to today
    End Sub

    Private Function FetchMembershipData(startDate As DateTime, endDate As DateTime) As DataTable
        Dim query As String = $"SELECT MembershipType, COUNT(*) AS Count FROM membership WHERE StartDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY MembershipType"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchEarningsData(startDate As DateTime, endDate As DateTime) As DataTable
        Dim query As String = $"
    SELECT 'Membership Fees' AS Source, SUM(Cost) AS Amount FROM membership WHERE StartDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
    UNION ALL
    SELECT 'Reservation Fees' AS Source, SUM(ReservationFee) AS Amount FROM reservation WHERE ReservationDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchExpensesData(startDate As DateTime, endDate As DateTime) As DataTable
        Dim query As String = $"
    SELECT 'Staff Salaries' AS Source, SUM(Salary) AS Amount FROM staff WHERE HireDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
    UNION ALL
    SELECT 'Equipment Maintenance' AS Source, SUM(MaintenanceCost) AS Amount FROM equipment WHERE PurchaseDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
    UNION ALL
    SELECT 'Operational Costs' AS Source, SUM(Salary) AS Amount FROM admin WHERE HireDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function


    Private Function FetchGenderData() As DataTable
        Dim query As String = "SELECT Sex, COUNT(*) AS Count FROM members GROUP BY Sex"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchStaffSpecializationData() As DataTable
        Dim query As String = "SELECT Specialization, COUNT(*) AS Count FROM staff GROUP BY Specialization"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchAnnouncements() As DataTable
        Dim query As String = "SELECT Title, Content FROM announcement ORDER BY DatePosted DESC"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function


    Private Sub LoadMembershipChartData(dt As DataTable)
        ' Clear existing series and annotations
        servicesreportChart.Series.Clear()
        servicesreportChart.Annotations.Clear()
        Dim chartArea As ChartArea = servicesreportChart.ChartAreas(0)

        ' Check if there is data to display
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            ' Set a default axis maximum so the chart area is still visible
            chartArea.AxisY.Maximum = 40 ' Default value when no data

            ' Refresh the chart and exit
            servicesreportChart.Invalidate()
            Return
        End If

        ' Create and configure the Series
        Dim series As New Series("MembershipData")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White
        series.LabelBackColor = Color.FromArgb(128, Color.Black)

        ' Define custom colors for the data points
        Dim colors As New List(Of Color) From {Color.Gold}

        ' Add data points to the Series with labels and values
        Dim xValues As New List(Of Integer)
        Dim yValues As New List(Of Double)
        Dim xLabels As New List(Of String)

        For Each row As DataRow In dt.Rows
            xValues.Add(xValues.Count) ' Use index as X value
            yValues.Add(Convert.ToDouble(row("Count")))
            xLabels.Add(row("MembershipType").ToString())
        Next

        For i = 0 To xValues.Count - 1
            Dim dp As New DataPoint()
            dp.SetValueXY(xValues(i), yValues(i))
            dp.AxisLabel = xLabels(i)
            dp.Label = FormatNumber(yValues(i))
            dp.Color = colors(i Mod colors.Count)
            series.Points.Add(dp)
        Next

        ' Add Series to Chart
        servicesreportChart.Series.Add(series)

        ' Dynamically adjust Y-axis to prevent labels from being cut off
        Dim maxValue As Double = If(yValues.Count > 0, yValues.Max(), 0)
        chartArea.AxisY.Maximum = If(maxValue > 0, maxValue * 1.2, 40) ' Add 20% padding, default to 40 if no data

        ' Refresh the chart to ensure it's updated
        servicesreportChart.Invalidate()
    End Sub

    Private Sub LoadChartData(earningsData As DataTable, expensesData As DataTable)
        Try
            chartEarnings.Series.Clear()

            ' Calculate totals first to determine the appropriate scale
            Dim totalEarnings As Double = 0
            For Each row As DataRow In earningsData.Rows
                If Not IsDBNull(row("Amount")) Then
                    totalEarnings += Convert.ToDouble(row("Amount"))
                End If
            Next

            Dim totalExpenses As Double = 0
            For Each row As DataRow In expensesData.Rows
                If Not IsDBNull(row("Amount")) Then
                    totalExpenses += Convert.ToDouble(row("Amount"))
                End If
            Next

            ' Dynamically set the Y-axis scale to prevent crashes with zero or small values
            Dim chartArea As ChartArea = chartEarnings.ChartAreas(0)
            Dim maxValue = Math.Max(totalEarnings, totalExpenses)

            If maxValue > 10000 Then
                chartArea.AxisY.IsLogarithmic = True
                chartArea.AxisY.Maximum = Double.NaN ' Let the chart auto-scale in log mode
            Else
                chartArea.AxisY.IsLogarithmic = False
                chartArea.AxisY.Maximum = If(maxValue > 0, maxValue * 1.2, 100) ' Dynamic max for linear scale
            End If

            ' Configure and add Earnings series
            Dim earningsSeries As New Series("Earnings") With {
                .ChartType = SeriesChartType.Bar,
                .IsValueShownAsLabel = True,
                .LabelForeColor = Color.White,
                .LabelBackColor = Color.FromArgb(128, Color.Black),
                .LabelAngle = 40
            }
            earningsSeries.SetCustomProperty("PointWidth", "2")
            Dim earningsPoint As New DataPoint()
            earningsPoint.SetValueXY(2, totalEarnings)
            earningsPoint.AxisLabel = "Earnings"
            earningsPoint.Color = Color.YellowGreen
            earningsPoint.Label = FormatNumber(totalEarnings)
            earningsSeries.Points.Add(earningsPoint)

            ' Configure and add Expenses series
            Dim expensesSeries As New Series("Expenses") With {
                .ChartType = SeriesChartType.Bar,
                .IsValueShownAsLabel = True,
                .LabelForeColor = Color.White,
                .LabelBackColor = Color.FromArgb(128, Color.Black),
                .LabelAngle = 40
            }
            expensesSeries.SetCustomProperty("PointWidth", "2")
            Dim expensesPoint As New DataPoint()
            expensesPoint.SetValueXY(1, totalExpenses)
            expensesPoint.AxisLabel = "Expenses"
            expensesPoint.Color = Color.Red
            expensesPoint.Label = FormatNumber(totalExpenses)
            expensesSeries.Points.Add(expensesPoint)

            ' Add series to the chart
            chartEarnings.Series.Add(earningsSeries)
            chartEarnings.Series.Add(expensesSeries)

            chartEarnings.Invalidate()
        Catch ex As Exception
            ' Fallback error handler for any chart-related exceptions
            MessageBox.Show($"An error occurred while rendering the financial chart: {ex.Message}", "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"Chart rendering error: {ex.Message}")
        End Try
    End Sub


    Private Sub LoadEarningsAndExpensesChart(startDate As DateTime, endDate As DateTime)
        ' Fetch data
        Dim earningsData As DataTable = FetchEarningsData(startDate, endDate)
        Dim expensesData As DataTable = FetchExpensesData(startDate, endDate)

        ' Load data into the chart
        LoadChartData(earningsData, expensesData)
    End Sub



    Private Sub LoadGenderChartData(dt As DataTable)
        ' Clear existing series
        pieGender.Series.Clear()

        ' Create and configure the Series
        Dim series As New Series("GenderData")
        series.ChartType = SeriesChartType.Doughnut ' Change to Doughnut chart
        series.LabelForeColor = Color.White ' Set the font color to white
        series.Font = New Font("Segoe UI", 9, FontStyle.Bold) ' Set the font to Segoe UI, size 9, bold
        series.IsValueShownAsLabel = True ' Show values as labels
        series.Label = "#PERCENT" ' Show percentage
        series.LabelBackColor = Color.FromArgb(128, Color.Black)

        ' Define custom colors for the data points
        Dim colors As New List(Of Color) From {Color.Red, Color.YellowGreen, Color.Gray}

        ' Add data points to the Series with labels and values
        Dim colorIndex As Integer = 0
        For Each row As DataRow In dt.Rows
            Dim dp As New DataPoint()
            dp.SetValueXY(row("Sex").ToString(), Convert.ToDouble(row("Count")))
            dp.Color = colors(colorIndex Mod colors.Count)
            dp.LegendText = row("Sex").ToString() ' Use Sex as the source for the legends
            series.Points.Add(dp)
            colorIndex += 1
        Next

        ' Add Series to Chart
        pieGender.Series.Add(series)

        ' Configure the legend
        pieGender.Legends.Clear()
        Dim legend As New Legend()
        legend.Docking = Docking.Right
        legend.Alignment = StringAlignment.Center
        legend.Font = New Font("Segoe UI", 9, FontStyle.Bold) ' Set the font to Segoe UI, size 9, bold
        legend.BackColor = Color.Transparent ' Make the background of the legends transparent
        legend.ForeColor = Color.White
        pieGender.Legends.Add(legend)

        ' Refresh the chart to ensure it's updated
        pieGender.Invalidate()
    End Sub


    Private Sub LoadStaffSpecializationChartData(dt As DataTable)
        ' Clear existing series
        chartStaffs.Series.Clear()

        ' Create and configure the Series
        Dim series As New Series("StaffSpecializationData")
        series.ChartType = SeriesChartType.Doughnut ' Change to Doughnut chart
        series.LabelForeColor = Color.White ' Set the font color to white
        series.Font = New Font("Segoe UI", 7, FontStyle.Bold) ' Set the font to Segoe UI, size 7, bold
        series.IsValueShownAsLabel = True ' Show values as labels
        series.Label = "#PERCENT" ' Show percentage
        series.LabelBackColor = Color.FromArgb(128, Color.Black)
        series.LabelFormat = "F"

        ' Define custom colors for the data points
        Dim colors As New List(Of Color) From {Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Red}

        ' Add data points to the Series with labels and values
        Dim colorIndex As Integer = 0
        For Each row As DataRow In dt.Rows
            Dim dp As New DataPoint()
            dp.SetValueXY(row("Specialization").ToString(), Convert.ToDouble(row("Count")))
            dp.Color = colors(colorIndex Mod colors.Count)
            dp.LegendText = row("Specialization").ToString() ' Use Specialization as the source for the legends
            series.Points.Add(dp)
            colorIndex += 1
        Next

        ' Add Series to Chart
        chartStaffs.Series.Add(series)

        ' Configure the legend
        chartStaffs.Legends.Clear()
        Dim legend As New Legend()
        legend.Docking = Docking.Right
        legend.Alignment = StringAlignment.Center
        legend.Font = New Font("Segoe UI", 7, FontStyle.Bold) ' Set the font to Segoe UI, size 7, bold
        legend.BackColor = Color.Transparent ' Make the background of the legends transparent
        legend.ForeColor = Color.White
        chartStaffs.Legends.Add(legend)

        ' Refresh the chart to ensure it's updated
        chartStaffs.Invalidate()
    End Sub

    Private Sub LoadAnnouncements()
        ' Fetch announcements from the database
        Dim announcements As DataTable = FetchAnnouncements()

        ' Bind the DataTable to the DataGridView
        dgvAnnouncements.DataSource = announcements


    End Sub

    Private Sub btnRefreshAnnouncements_Click(sender As Object, e As EventArgs) Handles btnRefreshAnnouncements.Click
        LoadAnnouncements()
    End Sub

    Private Sub AnnouncementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        LoadAnnouncements()
    End Sub


    Private Sub InitializeAnnouncementsControls()
        dgvAnnouncements.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvAnnouncements.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvAnnouncements.DefaultCellStyle.ForeColor = Color.White
        dgvAnnouncements.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvAnnouncements.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvAnnouncements.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvAnnouncements.RowHeadersVisible = False
        dgvAnnouncements.AllowUserToAddRows = False
        dgvAnnouncements.AllowUserToDeleteRows = False
        dgvAnnouncements.ReadOnly = True
        dgvAnnouncements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAnnouncements.BorderStyle = BorderStyle.None
        dgvAnnouncements.EnableHeadersVisualStyles = False
        dgvAnnouncements.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAnnouncements.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvAnnouncements.RowTemplate.Height = 25
        dgvAnnouncements.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60)
        dgvAnnouncements.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White
        dgvAnnouncements.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAnnouncements.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAnnouncements.ColumnHeadersHeight = 30
        dgvAnnouncements.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
    End Sub

    Private Sub CustomizeChartAxis()
        Dim chartArea As ChartArea = servicesreportChart.ChartAreas(0)
        chartArea.AxisX.LabelStyle.ForeColor = Color.White ' Change to your preferred color

        Dim chartArea2 As ChartArea = chartEarnings.ChartAreas(0)
        chartArea2.AxisX.LabelStyle.ForeColor = Color.White ' Change to your preferred color
        ' The Y-axis scale will now be set dynamically in LoadChartData
        chartArea2.AxisY.LabelStyle.ForeColor = Color.White
    End Sub



    Private Sub dashbrdTMData_Click(sender As Object, e As EventArgs) Handles dashbrdTMData.Click

    End Sub

    Private Sub InitializeStaffReservationsControls()
        gbStaffReservations = New GroupBox()
        gbStaffReservations.Text = "Reservations"
        If servicesreportChart.Parent IsNot Nothing Then
            Dim leftMargin As Integer = servicesreportChart.Parent.Left
            gbStaffReservations.Location = New Point(leftMargin, servicesreportChart.Parent.Bottom + 10)
            gbStaffReservations.Size = New Size(Me.Width - (leftMargin * 2), 280)
            gbStaffReservations.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Else
            ' Fallback to a default position and size if parent is not found
            gbStaffReservations.Location = New Point(20, 420)
            gbStaffReservations.Size = New Size(1200, 280) ' Wider fallback
            gbStaffReservations.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        End If
        gbStaffReservations.ForeColor = Color.White
        gbStaffReservations.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        gbStaffReservations.Padding = New Padding(10, 25, 10, 10) ' Left, Top, Right, Bottom

        dgvStaffReservations = New DataGridView()
        dgvStaffReservations.Dock = DockStyle.Fill
        dgvStaffReservations.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgvStaffReservations.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvStaffReservations.DefaultCellStyle.ForeColor = Color.White
        dgvStaffReservations.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvStaffReservations.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvStaffReservations.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgvStaffReservations.RowHeadersVisible = False ' Hide the row header column
        dgvStaffReservations.AllowUserToAddRows = False
        dgvStaffReservations.AllowUserToDeleteRows = False
        dgvStaffReservations.ReadOnly = True ' Make table read-only
        dgvStaffReservations.AutoGenerateColumns = False ' Disable auto-generation of columns
        dgvStaffReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaffReservations.BorderStyle = BorderStyle.None
        dgvStaffReservations.EnableHeadersVisualStyles = False
        dgvStaffReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStaffReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvStaffReservations.RowTemplate.Height = 25 ' Increase row height for better readability
        dgvStaffReservations.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60) ' Subtle selection color
        dgvStaffReservations.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White
        dgvStaffReservations.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvStaffReservations.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvStaffReservations.ColumnHeadersHeight = 30 ' Increase header height
        dgvStaffReservations.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        gbStaffReservations.Controls.Add(dgvStaffReservations)
        Me.Controls.Add(gbStaffReservations)

        ' Add essential columns
        ' MemberName
        If dgvStaffReservations.Columns("MemberName") Is Nothing Then
            Dim memberNameColumn As New DataGridViewTextBoxColumn()
            memberNameColumn.Name = "MemberName"
            memberNameColumn.DataPropertyName = "MemberName"
            memberNameColumn.HeaderText = "Member Name"
            memberNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            memberNameColumn.FillWeight = 25 ' Set proportional width
            dgvStaffReservations.Columns.Add(memberNameColumn)
        End If

        ' ReservationDate
        If dgvStaffReservations.Columns("ReservationDate") Is Nothing Then
            Dim dateColumn As New DataGridViewTextBoxColumn()
            dateColumn.Name = "ReservationDate"
            dateColumn.DataPropertyName = "ReservationDate"
            dateColumn.HeaderText = "Date"
            dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dateColumn.FillWeight = 15 ' Set proportional width
            dgvStaffReservations.Columns.Add(dateColumn)
        End If

        ' StartTime
        If dgvStaffReservations.Columns("StartTime") Is Nothing Then
            Dim startTimeColumn As New DataGridViewTextBoxColumn()
            startTimeColumn.Name = "StartTime"
            startTimeColumn.DataPropertyName = "StartTime"
            startTimeColumn.HeaderText = "Start Time"
            startTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            startTimeColumn.FillWeight = 15 ' Set proportional width
            dgvStaffReservations.Columns.Add(startTimeColumn)
        End If

        ' Purpose
        If dgvStaffReservations.Columns("Purpose") Is Nothing Then
            Dim purposeColumn As New DataGridViewTextBoxColumn()
            purposeColumn.Name = "Purpose"
            purposeColumn.DataPropertyName = "Purpose"
            purposeColumn.HeaderText = "Purpose"
            purposeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            purposeColumn.FillWeight = 25 ' Set proportional width
            dgvStaffReservations.Columns.Add(purposeColumn)
        End If

        ' Status
        If dgvStaffReservations.Columns("Status") Is Nothing Then
            Dim statusColumn As New DataGridViewTextBoxColumn()
            statusColumn.Name = "Status"
            statusColumn.DataPropertyName = "ReservationStatus"
            statusColumn.HeaderText = "Status"
            statusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            statusColumn.FillWeight = 20 ' Set proportional width
            dgvStaffReservations.Columns.Add(statusColumn)
        End If

        AddHandler dgvStaffReservations.CellClick, AddressOf dgvStaffReservations_CellClick
        AddHandler dgvStaffReservations.MouseDown, AddressOf dgvStaffReservations_MouseDown

        ' Setup Context Menu
        staffReservationsContextMenu.Items.Add("Set to Ongoing")
        staffReservationsContextMenu.Items.Add("Set to Completed")
        staffReservationsContextMenu.Items.Add("Set to Cancelled")
        dgvStaffReservations.ContextMenuStrip = staffReservationsContextMenu

        AddHandler staffReservationsContextMenu.Opening, AddressOf staffReservationsContextMenu_Opening
        For Each item As ToolStripMenuItem In staffReservationsContextMenu.Items
            AddHandler item.Click, AddressOf StatusMenuItem_Click
        Next
    End Sub

    Private Sub LoadStaffReservations()
        Try
            UpdateConnectionString()
            Using tempConn As New MySqlConnection(strConnection)
                tempConn.Open()
                ' Fetch all reservations for the currently logged-in staff member, including status
                Dim query As String = "SELECT r.ReservationID, CONCAT(mem.FirstName, ' ', mem.LastName) AS MemberName, r.ReservationDate, r.StartTime, r.EndTime, r.Purpose, r.ReservationStatus FROM reservation r JOIN members mem ON r.MemberID = mem.MemberID WHERE r.StaffID = @StaffID ORDER BY r.ReservationDate DESC, r.StartTime DESC"
                Dim dt As New DataTable()
                Using cmd As New MySqlCommand(query, tempConn)
                    cmd.Parameters.AddWithValue("@StaffID", CurrentLoggedUser.id)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
                dgvStaffReservations.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading your reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dgvStaffReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim dgv = CType(sender, DataGridView)
        If e.RowIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).Name = "Status" Then
            Dim rowView As DataRowView = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, DataRowView)
            If rowView IsNot Nothing Then
                Dim status As String = rowView("ReservationStatus").ToString()
                If status = "Pending" Then
                    Dim reservationID As Integer = Convert.ToInt32(rowView("ReservationID"))
                    ConfirmReservation(reservationID)
                End If
            End If
        End If
    End Sub

    Private Sub dgvStaffReservations_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim hitTestInfo = dgvStaffReservations.HitTest(e.X, e.Y)
            If hitTestInfo.RowIndex >= 0 Then
                dgvStaffReservations.ClearSelection()
                dgvStaffReservations.Rows(hitTestInfo.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub staffReservationsContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If dgvStaffReservations.SelectedRows.Count = 0 Then
            e.Cancel = True
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvStaffReservations.SelectedRows(0)
        Dim rowView As DataRowView = TryCast(selectedRow.DataBoundItem, DataRowView)
        If rowView Is Nothing Then
            e.Cancel = True
            Return
        End If

        Dim currentStatus As String = rowView("ReservationStatus").ToString()

        staffReservationsContextMenu.Items(0).Enabled = (currentStatus = "Pending") ' Ongoing
        staffReservationsContextMenu.Items(1).Enabled = (currentStatus = "Ongoing") ' Completed
        staffReservationsContextMenu.Items(2).Enabled = (currentStatus = "Pending" OrElse currentStatus = "Ongoing") ' Cancelled
    End Sub

    Private Sub StatusMenuItem_Click(sender As Object, e As EventArgs)
        If dgvStaffReservations.SelectedRows.Count = 0 Then Return

        Dim selectedRow As DataGridViewRow = dgvStaffReservations.SelectedRows(0)
        Dim rowView As DataRowView = TryCast(selectedRow.DataBoundItem, DataRowView)
        If rowView Is Nothing Then Return

        Dim reservationID As Integer = Convert.ToInt32(rowView("ReservationID"))
        Dim menuItem = CType(sender, ToolStripMenuItem)
        Dim newStatus As String = ""

        Select Case menuItem.Text
            Case "Set to Ongoing"
                newStatus = "Ongoing"
            Case "Set to Completed"
                newStatus = "Completed"
            Case "Set to Cancelled"
                newStatus = "Cancelled"
        End Select

        If Not String.IsNullOrEmpty(newStatus) Then
            UpdateReservationStatus(reservationID, newStatus)
        End If
    End Sub

    Private Sub UpdateReservationStatus(reservationID As Integer, newStatus As String)
        Dim success As Boolean = False
        Try
            UpdateConnectionString()
            Using tempConn As New MySqlConnection(strConnection)
                tempConn.Open()
                Dim query As String = "UPDATE reservation SET ReservationStatus = @NewStatus WHERE ReservationID = @ReservationID"
                Using cmd As New MySqlCommand(query, tempConn)
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID)
                    cmd.Parameters.AddWithValue("@NewStatus", newStatus)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show($"Reservation status updated to '{newStatus}' successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                success = True
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating reservation status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If success Then
            LoadStaffReservations()
        End If
    End Sub

    Private Sub ConfirmReservation(reservationID As Integer)
        UpdateReservationStatus(reservationID, "Ongoing")
    End Sub

    Private Function FormatNumber(number As Double) As String
        If number >= 1000000 Then
            Return (number / 1000000).ToString("0.##M")
        ElseIf number >= 1000 Then
            Return (number / 1000).ToString("0.##K")
        Else
            Return number.ToString("F2")
        End If
    End Function
End Class
