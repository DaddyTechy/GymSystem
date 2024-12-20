﻿Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class ContentRepMemRep
    Private currentOffset As Integer = 0
    Private batchSize As Integer = 25

    Private Sub ContentRepMemRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial setup if needed
        DateTimePicker1.Visible = False
        btnApplyBatchSize.Visible = False
        txtBatchSize.Visible = False
        Label4.Visible = False
        FormatDataGridView()
    End Sub

    Private Sub btnRevenue_Click(sender As Object, e As EventArgs) Handles btnRevenue.Click, btnRevenue.Click
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        DateTimePicker3.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Dim startDate As DateTime = DateTimePicker2.Value
        Dim endDate As DateTime = DateTimePicker3.Value
        LoadData($"SELECT MembershipCost, ReservationFee, PaymentDate FROM payment WHERE PaymentStatus = 'Paid' AND PaymentDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'")

        Dim adminID As String = CurrentLoggedUser.id ' Replace with actual value if admin is making the report
        Dim staffID As String = CurrentLoggedUser.id ' Assuming CurrentLoggedUser.id is the StaffID
        Dim title = "Revenue Report" ' Replace with actual value
        Dim reportDate = DateTimePicker1.Value.ToString("yyyy-MM-dd") ' Format the date
        Dim content = "Details about revenue" ' Replace with actual value
        Dim type = "A" ' Replace with actual value
        Dim status = "A" ' Replace with actual value
        Dim attachments = "None" ' Replace with actual value

        ' Determine if the report is made by staff or admin
        Dim query As String
        If CurrentLoggedUser.position = "Super Admin" Or CurrentLoggedUser.position = "Normal Admin" Then
            query = $"INSERT INTO `reports`(`AdminID`, `Title`, `ReportDate`, `Content`, `Type`, `Status`, `Attachments`) VALUES ('{adminID}','{title}','{reportDate}','{content}','{type}','{status}','{attachments}')"
        Else
            query = $"INSERT INTO `reports`(`StaffID`, `Title`, `ReportDate`, `Content`, `Type`, `Status`, `Attachments`) VALUES ('{staffID}','{title}','{reportDate}','{content}','{type}','{status}','{attachments}')"
        End If

        ' Execute the query
        readQuery(query)
        ' Bind data to RDLC report and export to PDF
        BindReport("..\..\..\AdminLevel\Reports\RevenueReport.rdlc")
    End Sub
    Private Sub LoadDataWithFilter()
        Dim startDate As DateTime = DateTimePicker2.Value
        Dim endDate As DateTime = DateTimePicker3.Value
        Dim query As String = $"SELECT MembershipCost, ReservationFee, PaymentDate FROM payment WHERE PaymentStatus = 'Paid' AND PaymentDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'"
        LoadData(query)
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
        reportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        reportViewer.RefreshReport()

        Dim previewForm As New Form()
        previewForm.Controls.Add(reportViewer)
        previewForm.Text = "Report Preview"
        reportViewer.Dock = DockStyle.Fill
        previewForm.WindowState = FormWindowState.Maximized
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

    Private lastClickedButton As Button

    Private Sub ReloadData(query As String, reportPath As String)
        DateTimePicker1.Visible = False
        btnApplyBatchSize.Visible = True
        txtBatchSize.Visible = True
        Label4.Visible = True
        LoadData(query)

        Dim adminID As String = CurrentLoggedUser.id
        Dim staffID As String = CurrentLoggedUser.id
        Dim title As String = "Report" ' Replace with actual value
        Dim reportDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim content As String = "Details" ' Replace with actual value
        Dim type As String = "A" ' Replace with actual value
        Dim status As String = "A" ' Replace with actual value
        Dim attachments As String = "None" ' Replace with actual value

        Dim insertQuery As String
        If CurrentLoggedUser.position = "Super Admin" Or CurrentLoggedUser.position = "Normal Admin" Then
            insertQuery = $"INSERT INTO `reports`(`AdminID`, `Title`, `ReportDate`, `Content`, `Type`, `Status`, `Attachments`) VALUES ('{adminID}','{title}','{reportDate}','{content}','{type}','{status}','{attachments}')"
        Else
            insertQuery = $"INSERT INTO `reports`(`StaffID`, `Title`, `ReportDate`, `Content`, `Type`, `Status`, `Attachments`) VALUES ('{staffID}','{title}','{reportDate}','{content}','{type}','{status}','{attachments}')"
        End If

        readQuery(insertQuery)
        BindReport(reportPath)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        batchSize += 25 ' Increase the limit by 25
        If lastClickedButton IsNot Nothing Then
            lastClickedButton.PerformClick
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        If batchSize > 25 Then
            batchSize -= 25 ' Decrease the limit by 25
        End If
        If lastClickedButton IsNot Nothing Then
            lastClickedButton.PerformClick
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.Click
        lastClickedButton = Button1
        ReloadData($"SELECT AttendanceID, StaffID, MemberID, Date, CheckInTime, CheckOutTime, SessionType FROM attendance LIMIT {batchSize} OFFSET 0", "..\..\..\AdminLevel\Reports\Report2.rdlc")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button2.Click
        lastClickedButton = Button2
        ReloadData($"SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, Province, City, Street, ZipCode FROM members LIMIT {batchSize} OFFSET 0", "..\..\..\AdminLevel\Reports\Report1.rdlc")
    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click, btnEquipment.Click
        lastClickedButton = btnEquipment
        ReloadData($"SELECT EquipmentID, Name, Type, Brand, PurchaseDate, Status, PurchasePlace, MaintenanceCost FROM equipment LIMIT {batchSize} OFFSET 0", "..\..\..\AdminLevel\Reports\Report3.rdlc")
    End Sub

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click, btnMembership.Click
        lastClickedButton = btnMembership
        ReloadData($"SELECT MembershipID, MemberID, MemberShipName, Duration, Cost, Benefits, StartDate, EndDate, DiscountAvailable, CancelationPolicy, RenewalPolicy, TrainingSession, LockerAccess, MembershipType FROM membership LIMIT {batchSize} OFFSET 0", "..\..\..\AdminLevel\Reports\Report4.rdlc")
    End Sub

    Private Sub btnApplyBatchSize_Click(sender As Object, e As EventArgs)
        Dim userInput = txtBatchSize.Text
        Dim newBatchSize As Integer
        If Integer.TryParse(userInput, newBatchSize) AndAlso newBatchSize > 0 Then
            batchSize = newBatchSize
            currentOffset = 0 ' Reset the offset when batch size changes
            If lastClickedButton IsNot Nothing Then
                lastClickedButton.PerformClick
            End If
        Else
            MessageBox.Show("Please enter a valid positive number for batch size.")
        End If
    End Sub

    Private Sub FormatDataGridView()
        ' Set the background color to match the form's background color
        DataGridView1.BackgroundColor = Me.BackColor
        DataGridView1.DefaultCellStyle.BackColor = Me.BackColor
        DataGridView1.DefaultCellStyle.ForeColor = Color.White ' Set text color
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Me.BackColor
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black ' Set header text color

        ' Set the DataGridView to fill the entire space
        DataGridView1.Dock = DockStyle.Fill

        ' Auto size columns and rows
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
End Class
