Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ContentDashboard
    Private conn As MySqlConnection

    Private Sub ContentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        CustomizeChartAxis()
        Try
            conn.Open()
            Dim dt As DataTable = FetchMembershipData()
            LoadChartData(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'dashboard data right
        ' Fetch total members count
        Dim totalMembers As Integer = GetTotalMembers()

        ' Update the label with the total members count
        dashbrdTMData.Text = totalMembers * 100.ToString()
    End Sub

    Private Sub InitializeConnection()
        conn = New MySqlConnection("server=ec2-54-152-32-19.compute-1.amazonaws.com;userid=remote_user;password=Aqua44.5;database=gym_infosys;port=3306;")
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

    Private Sub LoadChartData(dt As DataTable)
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

    Private Sub CustomizeChartAxis()
        Dim chartArea As ChartArea = servicesreportChart.ChartAreas(0)
        chartArea.AxisX.LabelStyle.ForeColor = Color.White ' Change to your preferred color

    End Sub

    'dashboard data

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

    Private Sub dashbrdTMData_Click(sender As Object, e As EventArgs) Handles dashbrdTMData.Click

    End Sub


End Class
