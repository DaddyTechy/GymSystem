Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Reflection.Metadata.Ecma335

Public Class ContentDashboard
    Private conn As MySqlConnection

    Private Sub ContentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        CustomizeChartAxis()
        Try
            conn.Open()
            Dim membershipData As DataTable = FetchMembershipData()
            LoadMembershipChartData(membershipData)

            ' Load earnings and expenses chart
            LoadEarningsAndExpensesChart()

            ' Load gender chart
            Dim genderData As DataTable = FetchGenderData()
            LoadGenderChartData(genderData)

            ' Load staff specialization chart
            Dim staffSpecializationData As DataTable = FetchStaffSpecializationData()
            LoadStaffSpecializationChartData(staffSpecializationData)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'dashboard data right
        ' Fetch total members count
        Dim totalMembers As Integer = GetTotalMembers()

        ' Update the label with the total members count
        dashbrdTMData.Text = (totalMembers * 100).ToString()
    End Sub


    Private Sub InitializeConnection()
        'conn = New MySqlConnection("server=ec2-54-152-32-19.compute-1.amazonaws.com;userid=remote_user;password=Aqua44.5;database=gym_infosys;port=3306;") '
        conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=gym_infosys;")
    End Sub

    Private Function FetchMembershipData() As DataTable
        Dim query As String = "SELECT MembershipType, COUNT(*) AS Count FROM membership GROUP BY MembershipType"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchEarningsData() As DataTable
        Dim query As String = "
        SELECT 'Membership Fees' AS Source, SUM(Cost) AS Amount FROM membership
        UNION ALL
        SELECT 'Reservation Fees' AS Source, SUM(ReservationFee) AS Amount FROM reservation"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Private Function FetchExpensesData() As DataTable
        Dim query As String = "
        SELECT 'Staff Salaries' AS Source, SUM(Salary) AS Amount FROM staff
        UNION ALL
        SELECT 'Equipment Maintenance' AS Source, SUM(MaintenanceCost) AS Amount FROM equipment
        UNION ALL
        SELECT 'Operational Costs' AS Source, SUM(Salary) AS Amount FROM admin"
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
        ' Clear existing series
        servicesreportChart.Series.Clear()

        ' Create and configure the Series
        Dim series As New Series("MembershipData")
        series.ChartType = SeriesChartType.Column

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
            dp.Color = colors(i Mod colors.Count)
            series.Points.Add(dp)
        Next

        ' Add Series to Chart
        servicesreportChart.Series.Add(series)

        ' Refresh the chart to ensure it's updated
        servicesreportChart.Invalidate()
    End Sub

    Private Sub LoadChartData(earningsData As DataTable, expensesData As DataTable)
        ' Clear existing series
        chartEarnings.Series.Clear()

        ' Create and configure the Series for Earnings
        Dim earningsSeries As New Series("Earnings")
        earningsSeries.ChartType = SeriesChartType.Bar
        earningsSeries.SetCustomProperty("PointWidth", "1") ' Adjust the width of the bars
        earningsSeries.IsValueShownAsLabel = True ' Show values as labels
        earningsSeries.LabelForeColor = Color.White ' Set label font color to white
        earningsSeries.LabelBackColor = Color.FromArgb(128, Color.Black) ' Set label background color to semi-transparent black
        Dim earningsColors As New List(Of Color) From {Color.Gold}
        earningsSeries.LabelAngle = 40

        ' Create and configure the Series for Expenses
        Dim expensesSeries As New Series("Expenses")
        expensesSeries.ChartType = SeriesChartType.Bar
        expensesSeries.SetCustomProperty("PointWidth", "1") ' Adjust the width of the bars
        expensesSeries.IsValueShownAsLabel = True ' Show values as labels
        expensesSeries.LabelForeColor = Color.White ' Set label font color to white
        expensesSeries.LabelBackColor = Color.FromArgb(128, Color.Black) ' Set label background color to semi-transparent black
        Dim expensesColors As New List(Of Color) From {Color.Red}
        expensesSeries.LabelAngle = 40

        ' Add data points to the Earnings Series with labels and values
        Dim totalEarnings As Double = 0
        For Each row As DataRow In earningsData.Rows
            totalEarnings += Convert.ToDouble(row("Amount") * 10)
        Next
        Dim earningsPoint As New DataPoint()
        earningsPoint.SetValueXY(2, Math.Round(totalEarnings, 2)) ' Format the value to 2 decimal places
        earningsPoint.AxisLabel = "Earnings"
        earningsPoint.Color = earningsColors(0)
        earningsPoint.Label = totalEarnings.ToString("F2") ' Display the value with 2 decimal places
        earningsSeries.Points.Add(earningsPoint)

        ' Add data points to the Expenses Series with labels and values
        Dim totalExpenses As Double = 0
        For Each row As DataRow In expensesData.Rows
            totalExpenses += Convert.ToDouble(row("Amount"))
        Next
        Dim expensesPoint As New DataPoint()
        expensesPoint.SetValueXY(1, Math.Round(totalExpenses, 2)) ' Format the value to 2 decimal places
        expensesPoint.AxisLabel = "Expenses"
        expensesPoint.Color = expensesColors(0)
        expensesPoint.Label = totalExpenses.ToString("F2") ' Display the value with 2 decimal places
        expensesSeries.Points.Add(expensesPoint)

        ' Add Series to Chart
        chartEarnings.Series.Add(earningsSeries)
        chartEarnings.Series.Add(expensesSeries)

        ' Refresh the chart to ensure it's updated
        chartEarnings.Invalidate()
    End Sub

    Private Sub LoadEarningsAndExpensesChart()
        ' Fetch data
        Dim earningsData As DataTable = FetchEarningsData()
        Dim expensesData As DataTable = FetchExpensesData()

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

        ' Clear existing text
        richTextBoxAnnouncements.Clear()

        ' Append each announcement to the RichTextBox
        For Each row As DataRow In announcements.Rows
            Dim title As String = row("Title").ToString()
            Dim content As String = row("Content").ToString()

            ' Append the title with a larger font size
            richTextBoxAnnouncements.SelectionFont = New Font("Segoe UI", 12, FontStyle.Bold)
            richTextBoxAnnouncements.AppendText(title & Environment.NewLine)

            ' Append the content with the default font size
            richTextBoxAnnouncements.SelectionFont = New Font("Segoe UI", 9, FontStyle.Regular)
            richTextBoxAnnouncements.AppendText(content & Environment.NewLine)
            richTextBoxAnnouncements.AppendText(Environment.NewLine) ' Add a blank line for separation
        Next

        ' Scroll to the bottom to show the latest announcement
        richTextBoxAnnouncements.SelectionStart = richTextBoxAnnouncements.Text.Length
        richTextBoxAnnouncements.ScrollToCaret()
    End Sub


    Private Sub AnnouncementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        LoadAnnouncements()
    End Sub


    Private Sub CustomizeChartAxis()
        Dim chartArea As ChartArea = servicesreportChart.ChartAreas(0)
        chartArea.AxisX.LabelStyle.ForeColor = Color.White ' Change to your preferred color
        Dim chartArea2 As ChartArea = chartEarnings.ChartAreas(0)
        chartArea2.AxisX.LabelStyle.ForeColor = Color.White ' Change to your preferred color
    End Sub

    Private Function GetTotalMembers() As Integer
        Dim query As String = "SELECT COUNT(*) FROM membership"
        Dim totalMembers As Integer = 0

        Using command As New MySqlCommand(query, conn)
            conn.Open()
            totalMembers = Convert.ToInt32(command.ExecuteScalar())
            conn.Close()
        End Using

        Return totalMembers
    End Function

End Class
