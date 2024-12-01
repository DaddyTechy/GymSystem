Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class ContentRepMemRep
    Private Sub ContentRepMemRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        dt.Columns.Add("MemberID")
        dt.Columns.Add("Name")
        dt.Columns.Add("MembershipStatus")

        ' Add sample data
        dt.Rows.Add("1", "John Doe", "Active")
        dt.Rows.Add("2", "Jane Smith", "Active")

        DataGridView1.DataSource = dt

        ' Debug: Check if DataGridView is populated
        Debug.WriteLine("DataGridView populated with data:")
        For Each row As DataRow In dt.Rows
            Debug.WriteLine(String.Join(", ", row.ItemArray))
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell content click event if needed
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Bind data to RDLC report and export to PDF
        BindReport()

        ' Debug: Check if PDF bytes are generated
        If pdfBytes IsNot Nothing AndAlso pdfBytes.Length > 0 Then
            Debug.WriteLine("PDF bytes generated successfully.")
        Else
            Debug.WriteLine("Failed to generate PDF bytes.")
        End If

        ' Show the report preview
        Dim reportViewer As New ReportViewer()
        reportViewer.LocalReport.ReportPath = "C:\Users\Kenji\Source\Repos\GymSystem\GymSystem\AdminLevel\Reports\Report1.rdlc" ' Update with the actual path to your RDLC report
        reportViewer.LocalReport.DataSources.Clear()
        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", CType(DataGridView1.DataSource, DataTable)))
        reportViewer.RefreshReport()

        Dim previewForm As New Form()
        previewForm.Controls.Add(reportViewer)
        reportViewer.Dock = DockStyle.Fill
        previewForm.ShowDialog()
    End Sub

    Private Sub BindReport()
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

        ' Debug: Check if DataTable is populated
        Debug.WriteLine("DataTable populated with data:")
        For Each row As DataRow In dt.Rows
            Debug.WriteLine(String.Join(", ", row.ItemArray))
        Next

        Dim report As New LocalReport()
        report.ReportPath = "C:\Users\Kenji\Source\Repos\GymSystem\GymSystem\AdminLevel\Reports\Report1.rdlc" ' Update with the actual path to your RDLC report

        ' Define the data source
        Dim dataSource As New ReportDataSource("DataSet1", dt)
        report.DataSources.Clear()
        report.DataSources.Add(dataSource)

        ' Debug: Check if data source is added to the report
        Debug.WriteLine("Data source added to the report.")

        pdfBytes = ExportToPDF(report)
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
