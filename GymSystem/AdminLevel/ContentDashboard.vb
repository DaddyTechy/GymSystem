
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Public Class ContentDashboard

    Private Sub ContentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSampleData()

    End Sub
    Private Sub LoadSampleData()
        ' Ensure the Series collection is cleared but keep the layout
        servicesreportChart.Series.Clear()

        ' Create and configure the Series
        Dim series As New Series("SampleData")
        series.ChartType = SeriesChartType.Column

        ' Create a sample list with X and Y values
        Dim xValues As New List(Of Integer) From {0, 1, 2, 3}
        Dim yValues As New List(Of Double) From {10, 20, 30, 40}
        Dim xLabels As New List(Of String) From {"Category1", "Category2", "Category3", "Category4"}

        ' Add data points to the Series with labels and values
        For i = 0 To xValues.Count - 1
            Dim dp As New DataPoint()
            dp.SetValueXY(xValues(i), yValues(i))
            dp.AxisLabel = xLabels(i)
            series.Points.Add(dp)
        Next

        ' Add Series to Chart
        servicesreportChart.Series.Add(series)

        ' Refresh the chart to ensure it's updated
        servicesreportChart.Invalidate()
    End Sub



    Private Function GetSampleData() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Category", GetType(String))
        dt.Columns.Add("Value", GetType(Double))

        ' Add sample data
        dt.Rows.Add("Category1", 10)
        dt.Rows.Add("Category2", 20)
        dt.Rows.Add("Category3", 30)
        dt.Rows.Add("Category4", 35)

        Return dt
    End Function

End Class
