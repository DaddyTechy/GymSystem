Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class ContentRepMemRep
    Private currentOffset As Integer = 0
    Private batchSize As Integer = 25
    ' Stores the RDLC path of the most recently loaded report
    Private lastReportPath As String = Nothing

    Private Sub ContentRepMemRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial setup if needed
        DateTimePicker1.Visible = False
        btnApplyBatchSize.Visible = False
        txtBatchSize.Visible = False
        Label4.Visible = False
        btnBack.Visible = False
        btnNext.Visible = False
        FormatDataGridView()
    End Sub

    Private Sub btnRevenue_Click(sender As Object, e As EventArgs) Handles btnRevenue.Click
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        DateTimePicker3.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Dim startDate As DateTime = DateTimePicker2.Value.Date
        Dim endDate As DateTime = DateTimePicker3.Value.Date

        ' Use parameterized query for revenue data
        LoadRevenueData(startDate, endDate)

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
        ' Display in grid first; PDF export can be triggered separately
        lastReportPath = Path.Combine(Application.StartupPath, "Reports", "RevenueReport.rdlc")
        BindReport(lastReportPath, False, False)
    End Sub

    Private Sub LoadDataWithFilter()
        Dim startDate As DateTime = DateTimePicker2.Value
        Dim endDate As DateTime = DateTimePicker3.Value
        Dim query As String = $"SELECT MembershipCost, ReservationFee, PaymentDate FROM payment WHERE PaymentStatus = 'Paid' AND PaymentDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'"
        LoadData(query)
    End Sub

    Private Sub LoadData(query As String)
        UpdateConnectionString()
        ' Use Using blocks and parameterless command for simpler queries
        Using conn As New MySqlConnection(strConnection)
            Try
                conn.Open()
                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            Catch ex As Exception
                Debug.WriteLine("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Parameterised loader specifically for revenue data (startDate inclusive, endDate exclusive)
    Private Sub LoadRevenueData(startDate As DateTime, endDate As DateTime)
        UpdateConnectionString()
        Dim query As String = $"SELECT MembershipCost, ReservationFee, PaymentDate FROM payment WHERE PaymentStatus = 'Paid' AND PaymentDate >= @StartDate AND PaymentDate < @EndDate LIMIT {batchSize}"
        Using conn As New MySqlConnection(strConnection)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StartDate", startDate)
                cmd.Parameters.AddWithValue("@EndDate", endDate.AddDays(1)) ' make end date exclusive
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub BindReport(reportPath As String, Optional exportPdf As Boolean = False, Optional showPreview As Boolean = True)
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

        #If DEBUG Then
        ' Debug: Check if DataTable is populated
        Debug.WriteLine("DataTable populated with data:")
        For Each row As DataRow In dt.Rows
            Debug.WriteLine(String.Join(", ", row.ItemArray))
        Next
        #End If

        Dim report As New LocalReport()
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim fullReportPath As String = Path.Combine(baseDirectory, reportPath)

        #If DEBUG Then
        ' Debug: Check the constructed report path
        Debug.WriteLine("Constructed report path: " & fullReportPath)
        #End If

        report.ReportPath = fullReportPath

        ' Define the data source
        Dim dataSource As New ReportDataSource("DataSet1", dt)
        report.DataSources.Clear()
        report.DataSources.Add(dataSource)

        #If DEBUG Then
        ' Debug: Check if data source is added to the report
        Debug.WriteLine("Data source added to the report.")
        #End If

        If exportPdf Then
            pdfBytes = ExportToPDF(report)

            #If DEBUG Then
            If pdfBytes IsNot Nothing AndAlso pdfBytes.Length > 0 Then
                Debug.WriteLine("PDF bytes generated successfully.")
            Else
                Debug.WriteLine("Failed to generate PDF bytes.")
            End If
            #End If
        End If

        If showPreview Then
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
        End If
    End Sub

    Private Function ExportToPDF(report As LocalReport) As Byte()
        Dim warnings As Warning()
        Dim streamIds As String()
        Dim mimeType As String = String.Empty
        Dim encoding As String = String.Empty
        Dim extension As String = String.Empty

        Dim bytes As Byte() = report.Render("PDF", Nothing, mimeType, encoding, extension, streamIds, warnings)

        #If DEBUG Then
        ' Debug: Check if PDF rendering warnings are generated
        If warnings IsNot Nothing AndAlso warnings.Length > 0 Then
            Debug.WriteLine("PDF rendering warnings:")
            For Each warning As Warning In warnings
                Debug.WriteLine(warning.Message)
            Next
        End If
        #End If

        Return bytes
    End Function

    Private pdfBytes As Byte()

    Private lastClickedButton As Button

    Private Sub ReloadData(query As String, reportPath As String)
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        DateTimePicker3.Visible = False
        btnApplyBatchSize.Visible = True
        txtBatchSize.Visible = True
        Label4.Visible = True
        btnBack.Visible = True
        btnNext.Visible = True
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
        lastReportPath = reportPath
        BindReport(lastReportPath, False, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lastClickedButton = Button1
        ReloadData($"SELECT AttendanceID, StaffID, MemberID, Date, CheckInTime, CheckOutTime, SessionType FROM attendance LIMIT {batchSize} OFFSET 0", Path.Combine(Application.StartupPath, "Reports", "Report2.rdlc"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lastClickedButton = Button2
        ReloadData($"SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, Province, City, Street, ZipCode FROM members LIMIT {batchSize} OFFSET 0", Path.Combine(Application.StartupPath, "Reports", "Report1.rdlc"))
    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click
        lastClickedButton = btnEquipment
        ReloadData($"SELECT EquipmentID, Name, Type, Brand, PurchaseDate, Status, PurchasePlace, MaintenanceCost FROM equipment LIMIT {batchSize} OFFSET 0", Path.Combine(Application.StartupPath, "Reports", "Report3.rdlc"))
    End Sub

    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        lastClickedButton = btnMembership
        ReloadData($"SELECT MembershipID, MemberID, MemberShipName, Duration, Cost, Benefits, StartDate, EndDate, DiscountAvailable, CancelationPolicy, RenewalPolicy, TrainingSession, LockerAccess, MembershipType FROM membership LIMIT {batchSize} OFFSET 0", Path.Combine(Application.StartupPath, "Reports", "Report4.rdlc"))
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

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        If batchSize > 25 Then
            batchSize -= 25 ' Decrease the limit by 25
        End If
        If lastClickedButton IsNot Nothing Then
            lastClickedButton.PerformClick()
        End If
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        batchSize += 25 ' Increase the limit by 25
        If lastClickedButton IsNot Nothing Then
            lastClickedButton.PerformClick()
        End If
    End Sub

    Private Sub btnApplyBatchSize_Click_1(sender As Object, e As EventArgs) Handles btnApplyBatchSize.Click
        Dim userInput = txtBatchSize.Text
        Dim newBatchSize As Integer
        If Integer.TryParse(userInput, newBatchSize) AndAlso newBatchSize > 0 Then
            batchSize = newBatchSize
            currentOffset = 0 ' Reset the offset when batch size changes
            If lastClickedButton IsNot Nothing Then
                lastClickedButton.PerformClick()
            End If
        Else
            MessageBox.Show("Please enter a valid positive number for batch size.")
        End If
    End Sub

    ' Universal export button handler
    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        If String.IsNullOrEmpty(lastReportPath) Then
            MessageBox.Show("Load a report first before exporting.")
            Return
        End If
        ' Ensure DataGridView has data
        If DataGridView1.DataSource Is Nothing Then
            MessageBox.Show("No data to export.")
            Return
        End If
        BindReport(lastReportPath, True)
    End Sub
End Class
