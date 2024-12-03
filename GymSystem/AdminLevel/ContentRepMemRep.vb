Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class ContentRepMemRep

    Private Sub ContentRepMemRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial setup if needed
        DateTimePicker1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DateTimePicker1.Visible = False
        ' Load data from members table
        LoadData("SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, Province, City, Street, ZipCode FROM members")
        ' Bind data to RDLC report and export to PDF
        BindReport("..\..\..\AdminLevel\Reports\Report1.rdlc")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTimePicker1.Visible = False
        ' Load data from attendance table
        LoadData("SELECT AttendanceID, StaffID, MemberID, Date, CheckInTime, CheckOutTime, SessionType FROM attendance")
        ' Bind data to RDLC report and export to PDF
        BindReport("..\..\..\AdminLevel\Reports\Report2.rdlc")
    End Sub

    Private Sub btnRevenue_Click(sender As Object, e As EventArgs) Handles btnRevenue.Click
        DateTimePicker1.Visible = True
        LoadData("SELECT MembershipCost, ReservationFee, PaymentDate FROM payment")
        LoadDataWithFilter()
        ' Bind data to RDLC report and export to PDF
        BindReport("..\..\..\AdminLevel\Reports\RevenueReport.rdlc")
    End Sub

    Private Sub LoadDataWithFilter()
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim query As String = $"SELECT MembershipCost, ReservationFee, PaymentDate FROM payment WHERE MONTH(PaymentDate) = {selectedDate.Month} AND YEAR(PaymentDate) = {selectedDate.Year}"
        LoadData(query)
    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click
        DateTimePicker1.Visible = False
        ' Load data from attendance table
        LoadData("SELECT EquipmentID, Name, Type, Brand, PurchaseDate, Status, PurchasePlace, MaintenanceCost FROM equipment")
        ' Bind data to RDLC report and export to PDF
        BindReport("..\..\..\AdminLevel\Reports\Report3.rdlc")
    End Sub

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click

    End Sub

    Private Sub LoadData(query As String)
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Assign the DataTable as the DataSource for the DataGridView
            DataGridView1.DataSource = dt

            ' Debug: Check if DataGridView is populated
            Debug.WriteLine("DataGridView populated with data:")
            For Each row As DataRow In dt.Rows
                Debug.WriteLine(String.Join(", ", row.ItemArray))
            Next

        Catch ex As Exception
            ' Handle any errors that occur
            Debug.WriteLine("An error occurred: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell content click event if needed
    End Sub

    Private Sub BindReport(reportPath As String)
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

        ' Debug: Check if DataTable is populated
        Debug.WriteLine("DataTable populated with data:")
        For Each row As DataRow In dt.Rows
            Debug.WriteLine(String.Join(", ", row.ItemArray))
        Next

        Dim report As New LocalReport()
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim fullReportPath As String = Path.Combine(baseDirectory, reportPath)

        ' Debug: Check the constructed report path
        Debug.WriteLine("Constructed report path: " & fullReportPath)

        report.ReportPath = fullReportPath

        ' Define the data source
        Dim dataSource As New ReportDataSource("DataSet1", dt)
        report.DataSources.Clear()
        report.DataSources.Add(dataSource)

        ' Debug: Check if data source is added to the report
        Debug.WriteLine("Data source added to the report.")

        pdfBytes = ExportToPDF(report)

        ' Debug: Check if PDF bytes are generated
        If pdfBytes IsNot Nothing AndAlso pdfBytes.Length > 0 Then
            Debug.WriteLine("PDF bytes generated successfully.")
        Else
            Debug.WriteLine("Failed to generate PDF bytes.")
        End If

        ' Show the report preview
        Dim reportViewer As New ReportViewer()
        reportViewer.LocalReport.ReportPath = fullReportPath
        reportViewer.LocalReport.DataSources.Clear()
        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
        reportViewer.RefreshReport()

        Dim previewForm As New Form()
        previewForm.Controls.Add(reportViewer)
        reportViewer.Dock = DockStyle.Fill
        previewForm.ShowDialog()
    End Sub

    Private Function ExportToPDF(report As LocalReport) As Byte()
        Dim warnings As Warning()
        Dim streamIds As String()
        Dim mimeType As String = String.Empty
        Dim encoding As String = String.Empty
        Dim extension As String = String.Empty

        Dim bytes As Byte() = report.Render("PDF", Nothing, mimeType, encoding, extension, streamIds, warnings)

        ' Debug: Check if PDF rendering warnings are generated
        If warnings IsNot Nothing AndAlso warnings.Length > 0 Then
            Debug.WriteLine("PDF rendering warnings:")
            For Each warning As Warning In warnings
                Debug.WriteLine(warning.Message)
            Next
        End If

        Return bytes
    End Function

    Private pdfBytes As Byte()
End Class
