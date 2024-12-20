﻿Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class memberProfileControl
    Public selectedMember As MemberData

    Private Sub memberProfileControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable AutoScroll for the control
        Me.AutoScroll = True

        If lblStatus.Text = "Inactive" Then
            lblStatus.ForeColor = Color.Red
        Else
            lblStatus.ForeColor = Color.Gold
        End If

        ' Check if selectedMember is not null
        If selectedMember IsNot Nothing Then

            ' Load reservations for the selected member
            LoadReservationsForMember(selectedMember.MemberID)

            LoadNotesForMember(selectedMember.MemberID)

            Dim dtAttendance As DataTable = FetchAttendanceData(selectedMember.MemberID)

            LoadAttendanceChartData(selectedMember.MemberID, dtAttendance)
        Else
            MessageBox.Show("Member data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub InitializeConnection()
        UpdateConnectionString()
        conn = New MySqlConnection(strConnection)
    End Sub

    Private Function FetchAttendanceData(memberID As Integer) As DataTable
        Dim query As String = $"SELECT MemberID, Date, CheckInTime, CheckOutTime FROM attendance WHERE MemberID = {memberID}"
        Dim dt As New DataTable()
        Using command As New MySqlCommand(query, conn)
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
    Private Sub LoadAttendanceChartData(memberID As Integer, dt As DataTable)
        ' Clear existing series
        chartAttendance.Series.Clear()

        ' Create and configure the Series
        Dim series As New Series("AttendanceData")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True ' Show values as labels on the Y-axis

        ' Define custom colors for the data points
        Dim colors As New List(Of Color) From {Color.Gold}
        Dim labelColor As Color = Color.White ' Set the desired label font color

        ' Add data points to the Series with labels and values
        Dim xValues As New List(Of Integer)
        Dim yValues As New List(Of Double)
        Dim xLabels As New List(Of String)

        For Each row As DataRow In dt.Rows
            If Convert.ToInt32(row("MemberID")) = memberID Then
                Dim checkInTime As TimeSpan = TimeSpan.Parse(row("CheckInTime").ToString())
                Dim checkOutTime As TimeSpan = TimeSpan.Parse(row("CheckOutTime").ToString())
                Dim hours As Double = (checkOutTime - checkInTime).TotalHours

                xValues.Add(xValues.Count) ' Use index as X value
                yValues.Add(hours)
                xLabels.Add(Convert.ToDateTime(row("Date")).ToString("MMM d"))
            End If
        Next

        For i = 0 To xValues.Count - 1
            Dim dp As New DataPoint()
            dp.SetValueXY(xValues(i), yValues(i))
            dp.AxisLabel = xLabels(i)
            dp.Color = colors(i Mod colors.Count)
            dp.Label = $"{yValues(i):F2} Hour/s" ' Add label to show hours on Y-axis
            dp.LabelForeColor = labelColor ' Set the font color of the label
            series.Points.Add(dp)
        Next

        ' Add Series to Chart
        chartAttendance.Series.Add(series)

        ' Refresh the chart to ensure it's updated
        chartAttendance.Invalidate()
    End Sub

    Private Sub LoadNotesForMember(memberID As Integer)
        LoadToDGV($"SELECT NoteID, NoteDetails, Author, DateAdded FROM notes WHERE MemberID = {memberID}", notesDGV)

        ' Set the properties for notesDGV
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40) ' Replace with the actual parent control if different

        ' Set the background color of the DataGridView to match the parent control's background color
        notesDGV.BackgroundColor = Color.FromArgb(20, 20, 20)

        ' Set the forecolor to white
        notesDGV.DefaultCellStyle.ForeColor = Color.White

        ' Set the background color of the cells to match the parent control's background color
        notesDGV.DefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the column headers to match the parent control's background color
        notesDGV.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the row headers to match the parent control's background color
        notesDGV.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Additional properties copied from MembersTable
        notesDGV.AllowUserToAddRows = False
        notesDGV.AllowUserToDeleteRows = False
        notesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        notesDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        notesDGV.BorderStyle = BorderStyle.None
        notesDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 17.0F)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        notesDGV.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        notesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        cellStyle.Font = New Font("Segoe UI", 15.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.True
        notesDGV.DefaultCellStyle = cellStyle

        notesDGV.Dock = DockStyle.Fill
        notesDGV.EditMode = DataGridViewEditMode.EditOnEnter
        notesDGV.EnableHeadersVisualStyles = False
        notesDGV.GridColor = Color.White
        notesDGV.MultiSelect = False
        notesDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Dim rowHeaderStyle As New DataGridViewCellStyle()
        rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        rowHeaderStyle.BackColor = SystemColors.WindowFrame
        rowHeaderStyle.Font = New Font("Segoe UI", 9.75F)
        rowHeaderStyle.ForeColor = Color.White
        rowHeaderStyle.SelectionBackColor = SystemColors.Highlight
        rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        rowHeaderStyle.WrapMode = DataGridViewTriState.True
        notesDGV.RowHeadersDefaultCellStyle = rowHeaderStyle

        notesDGV.RowHeadersVisible = False
        notesDGV.RowHeadersWidth = 51

        Dim rowsStyle As New DataGridViewCellStyle()
        rowsStyle.BackColor = Color.FromArgb(40, 40, 40)
        rowsStyle.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rowsStyle.ForeColor = Color.White
        notesDGV.RowsDefaultCellStyle = rowsStyle

        notesDGV.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        notesDGV.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        notesDGV.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 15.0F)
        notesDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        notesDGV.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        notesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        notesDGV.ShowCellErrors = False
        notesDGV.ShowRowErrors = False

        notesDGV.Columns("NoteID").HeaderText = "Note #"
        notesDGV.Columns("NoteDetails").HeaderText = "Note Details"
        notesDGV.Columns("Author").HeaderText = "Author"
        notesDGV.Columns("DateAdded").HeaderText = "Date Added"
    End Sub


    ' Define the LoadMemberData method
    Public Sub LoadMemberData(memberData As MemberData)
        ' Use the memberData object to populate the controls in the user control
        lblMemberName.Text = memberData.FirstName & " " & memberData.LastName
        lblContactNo.Text = memberData.PhoneNumber
        lbldob.Text = memberData.DOB & "  |  Age: " & CalculateAge(memberData.DOB)
        lblEmail.Text = memberData.Email
        lblUserName.Text = memberData.FirstName & " " & memberData.LastName
        lblUserHandle.Text = "@" & memberData.Username
        lblWeightHeight.Text = memberData.Weight & "kg  |  " & memberData.Height & "ft"
        lbldtcreated.Text = "Member Since: " & memberData.DTCreated
        lblStatus.Text = memberData.Status

        lblPlanCost.Text = "Php " & memberData.Cost
        lblPlanAccess.Text = memberData.Benefits & ":" & Environment.NewLine & memberData.MembershipType
        lblPlanStartDate.Text = memberData.StartDate
        lblEndDate.Text = memberData.EndDate
        lblPlanType.Text = "JJ Fitness GYM: " & memberData.MemberShipName & " - " & memberData.Duration
        lblRenewalPolicy.Text = memberData.RenewalPolicy

        Dim paymentID As Integer = GetLatestPaymentID(CurrentLoggedUser.id)
        UpdatePaymentStatusLabel(paymentID)

        ' Store the memberData object in the selectedMember field
        Me.selectedMember = memberData

        ' Load notes for the selected member
        LoadNotesForMember(selectedMember.MemberID)
    End Sub

    Private Function GetLatestPaymentID(memberID As Integer) As Integer
        Dim latestPaymentID As Integer = 0
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim query As String = $"SELECT PaymentID FROM payment WHERE MemberID = {memberID} ORDER BY PaymentDate DESC LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                latestPaymentID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return latestPaymentID
    End Function

    Private Function GetPaymentStatus(paymentID As Integer) As String
        UpdateConnectionString()
        Dim conn As New MySqlConnection(strConnection)
        Dim paymentStatus As String = String.Empty
        Try
            conn.Open()
            Dim query As String = "SELECT CASE WHEN TotalAmount IS NOT NULL THEN PaymentStatus ELSE 'Unpaid' END AS PaymentStatus " &
                              "FROM payment " &
                              "WHERE PaymentID = @PaymentID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@PaymentID", paymentID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                paymentStatus = reader("PaymentStatus").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        Debug.WriteLine("status: " & paymentStatus)
        Return paymentStatus
    End Function

    Private Sub UpdatePaymentStatusLabel(paymentID As Integer)
        Dim paymentStatus As String = GetPaymentStatus(paymentID)
        lblPaymentStatus.Text = paymentStatus
        Debug.WriteLine("status: " & paymentStatus)
    End Sub

    Private Function CalculateAge(dob As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year
        If (dob > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim color1 = Color.Gold
        Dim color2 = Color.White
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, Panel3.Width, Panel3.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 45.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint
        Dim color1 = Color.FromArgb(20, 20, 20)
        Dim color2 = Color.FromArgb(70, 70, 70)
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, TableLayoutPanel2.Width, TableLayoutPanel2.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 90.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    Private Sub btnAddNotes_Click(sender As Object, e As EventArgs) Handles btnAddNotes.Click
        Dim addNotesControl As New AddNotesControl
        AddHandler addNotesControl.NoteAdded, AddressOf OnNoteAdded

        ' Calculate the center point
        Dim centerX As Integer = (ClientSize.Width - addNotesControl.Width) / 2
        Dim centerY As Integer = (ClientSize.Height - addNotesControl.Height) / 2

        ' Set the location of the AddNotesControl to the center
        addNotesControl.Location = New Point(centerX, centerY)

        ' Set the size of the AddNotesControl
        addNotesControl.Size = New Size(470, 328) ' Set the desired size

        ' Add the AddNotesControl to the form
        Controls.Add(addNotesControl)
        addNotesControl.BringToFront
    End Sub

    Private Sub OnNoteAdded(noteDetails As String, author As String, dateAdded As DateTime)
        Try
            ' Insert the new note into the notes table
            Dim query As String = $"INSERT INTO notes (NoteDetails, Author, DateAdded, MemberID) VALUES ('{noteDetails}', '{author}', '{dateAdded.ToString("yyyy-MM-dd")}', '{selectedMember.MemberID}')"
            readQuery(query)

            ' Refresh the DataGridView
            LoadNotesForMember(selectedMember.MemberID)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim color1 = Color.Gold
        Dim color2 = Color.White
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, Panel2.Width, Panel2.Height - 1)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color2, color1, 45.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    Private Sub btnAddReservation_Click(sender As Object, e As EventArgs) Handles btnAddReservation.Click
        Dim addReservationControl As New addReservationControl()
        AddHandler addReservationControl.ReservationAdded, AddressOf OnReservationAdded

        ' Pass the selectedMember.MemberID to the addReservationControl
        addReservationControl.MemberID = selectedMember.MemberID

        ' Calculate the center point
        Dim centerX As Integer = (ClientSize.Width - addReservationControl.Width) / 2
        Dim centerY As Integer = (ClientSize.Height - addReservationControl.Height) / 2

        ' Set the location of the AddReservationControl to the center
        addReservationControl.Location = New Point(centerX, centerY)

        ' Add the AddReservationControl to the form
        Controls.Add(addReservationControl)
        addReservationControl.BringToFront()
    End Sub
    Private Sub OnReservationAdded(memberID As Integer, equipmentID As Integer, staffID As Integer, reservationDate As DateTime, startTime As DateTime, endTime As DateTime, reservationFee As Decimal, reservationNotes As String, purpose As String)
        Try
            ' Insert the new reservation into the reservations table
            Dim query As String = $"INSERT INTO reservation (MemberID, EquipmentID, StaffID, ReservationDate, StartTime, EndTime, ReservationFee, ReservationNotes, ReservationStatus, Cancellation, Reschedule, PaymentStatus, Feedback, Purpose) " &
                              $"VALUES ({memberID}, {equipmentID}, {staffID}, '{reservationDate:yyyy-MM-dd}', '{startTime:HH:mm:ss}', '{endTime:HH:mm:ss}', {reservationFee}, '{reservationNotes}', 'Pending', False, False, 'Unpaid', '', '{purpose}')"
            ExecuteQuery(query)
            MessageBox.Show($"Debug: inserted MemberID = {memberID}")

            ' Refresh the DataGridView
            LoadReservationsForMember(memberID)

            ' Ask if the user wants to make the payment now or later
            Dim result As DialogResult = MessageBox.Show("Do you want to make the payment now?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Open the BillingPaymentForm
                Dim paymentControl As New BillingPaymentForm(reservationFee, False, memberID, memberID)

                ' Calculate the center point
                Dim centerX As Integer = (ClientSize.Width - paymentControl.Width) / 2
                Dim centerY As Integer = (ClientSize.Height - paymentControl.Height) / 2

                ' Set the location of the BillingPaymentForm to the center
                paymentControl.Location = New Point(centerX, centerY)

                ' Add the BillingPaymentForm to the form
                Controls.Add(paymentControl)
                paymentControl.BringToFront()

                AddHandler paymentControl.btnSave.Click, Sub(sender As Object, e As EventArgs)
                                                             ' Insert payment data into the payment table
                                                             Dim paymentMethod As String = paymentControl.cmbPaymentMethod.SelectedItem.ToString()
                                                             Dim paymentDate As DateTime = paymentControl.dtpPaymentDate.Value
                                                             Dim subTotal As Decimal = Convert.ToDecimal(paymentControl.txtSubTotal.Text)
                                                             Dim invoiceNumber As String = paymentControl.txtInvoiceNumber.Text
                                                             Dim receiptNumber As String = paymentControl.txtReceiptNumber.Text
                                                             Dim discountApplied As Decimal = If(String.IsNullOrEmpty(paymentControl.txtDiscountAmount.Text), 0, Convert.ToDecimal(paymentControl.txtDiscountAmount.Text))
                                                             Dim taxAmount As Decimal = Convert.ToDecimal(paymentControl.txtTaxAmount.Text)
                                                             Dim totalAmount As Decimal = Convert.ToDecimal(paymentControl.txtTotalAmount.Text)
                                                             Dim paymentNotes As String = paymentControl.txtPaymentNotes.Text

                                                             Dim queryPayment As String = $"INSERT INTO payment (MemberID, ReservationFee, PaymentMethod, PaymentDate, Amount, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, PaymentStatus, MembershipID) " &
                                                                                      $"VALUES ({memberID}, {reservationFee}, '{paymentMethod}', '{paymentDate:yyyy-MM-dd}', {subTotal}, '{invoiceNumber}', '{receiptNumber}', {discountApplied}, {taxAmount}, {totalAmount}, '{paymentNotes}', 'Paid', '{selectedMember.MemberID}')"
                                                             readQuery(queryPayment)

                                                             ' Update status in the relevant table
                                                             Dim queryReservation As String = $"UPDATE reservation SET PaymentStatus = 'Paid' WHERE MemberID = {memberID}"
                                                             readQuery(queryReservation)

                                                             ' Notify user of successful save
                                                             MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                             paymentControl.Hide()
                                                         End Sub

                MessageBox.Show("Debug: Payment data inserted successfully.")
            Else
                ' Set payment status to Unpaid and set default values for other fields
                Dim defaultPaymentDate As DateTime = DateTime.MinValue
                Dim queryPayment As String = $"INSERT INTO payment (MemberID, ReservationFee, PaymentStatus, PaymentDate, Amount, PaymentMethod, InvoiceNumber, DiscountApplied, TaxAmount, TotalAmount, ReceiptNumber, PaymentNotes, MembershipID) " &
                                         $"VALUES ({memberID}, {reservationFee}, 'Unpaid', '{defaultPaymentDate:yyyy-MM-dd}', 0, 'N/A', 'N/A', 0, 0, 0, 'N/A', 'N/A', '{selectedMember.MemberID}')"
                ExecuteQuery(queryPayment)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the reservation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExecuteQuery(query As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = query
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub LoadReservationsForMember(memberID As Integer)
        Dim query As String = $"SELECT r.ReservationID, r.MemberID, e.Name AS Name, s.FirstName AS FirstName, r.ReservationDate, r.StartTime, r.EndTime, r.ReservationStatus, r.Purpose, r.ReservationNotes, r.Cancellation, r.Reschedule, r.PaymentStatus, r.Feedback, r.ReservationFee " &
                          $"FROM reservation r " &
                          $"JOIN equipment e ON r.EquipmentID = e.EquipmentID " &
                          $"JOIN staff s ON r.StaffID = s.StaffID " &
                          $"WHERE r.MemberID = {memberID}"
        LoadToDGV(query, reservationsDGV)

        ' Set the properties for reservationsDGV
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40) ' Replace with the actual parent control if different

        ' Set the background color of the DataGridView to match the parent control's background color
        reservationsDGV.BackgroundColor = Color.FromArgb(20, 20, 20)

        ' Set the forecolor to white
        reservationsDGV.DefaultCellStyle.ForeColor = Color.White

        ' Set the background color of the cells to match the parent control's background color
        reservationsDGV.DefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the column headers to match the parent control's background color
        reservationsDGV.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Set the background color of the row headers to match the parent control's background color
        reservationsDGV.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        ' Additional properties copied from MembersTable
        reservationsDGV.AllowUserToAddRows = False
        reservationsDGV.AllowUserToDeleteRows = False
        reservationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        reservationsDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        reservationsDGV.BorderStyle = BorderStyle.None
        reservationsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 10.0F)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        reservationsDGV.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        reservationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        cellStyle.Font = New Font("Segoe UI", 9.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.True
        reservationsDGV.DefaultCellStyle = cellStyle

        reservationsDGV.Dock = DockStyle.Fill
        reservationsDGV.EditMode = DataGridViewEditMode.EditOnEnter
        reservationsDGV.EnableHeadersVisualStyles = False
        reservationsDGV.GridColor = Color.White
        reservationsDGV.MultiSelect = False
        reservationsDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Dim rowHeaderStyle As New DataGridViewCellStyle()
        rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        rowHeaderStyle.BackColor = SystemColors.WindowFrame
        rowHeaderStyle.Font = New Font("Segoe UI", 9.75F)
        rowHeaderStyle.ForeColor = Color.White
        rowHeaderStyle.SelectionBackColor = SystemColors.Highlight
        rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        rowHeaderStyle.WrapMode = DataGridViewTriState.True
        reservationsDGV.RowHeadersDefaultCellStyle = rowHeaderStyle

        reservationsDGV.RowHeadersVisible = False
        reservationsDGV.RowHeadersWidth = 51

        Dim rowsStyle As New DataGridViewCellStyle()
        rowsStyle.BackColor = Color.FromArgb(40, 40, 40)
        rowsStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rowsStyle.ForeColor = Color.White
        reservationsDGV.RowsDefaultCellStyle = rowsStyle

        reservationsDGV.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        reservationsDGV.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        reservationsDGV.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.0F)
        reservationsDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        reservationsDGV.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        reservationsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        reservationsDGV.ShowCellErrors = False
        reservationsDGV.ShowRowErrors = False

        ' Check if Edit and Delete columns already exist
        If reservationsDGV.Columns("Edit") Is Nothing Then
            ' Add Edit button
            Dim editButtonColumn As New DataGridViewButtonColumn()
            editButtonColumn.Name = "Edit"
            editButtonColumn.HeaderText = "Edit"
            editButtonColumn.Text = "Edit"
            editButtonColumn.UseColumnTextForButtonValue = True
            editButtonColumn.FlatStyle = FlatStyle.Standard
            editButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            editButtonColumn.MinimumWidth = 50
            reservationsDGV.Columns.Insert(0, editButtonColumn)
        End If

        If reservationsDGV.Columns("Delete") Is Nothing Then
            ' Add Delete button
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            deleteButtonColumn.FlatStyle = FlatStyle.Standard
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            deleteButtonColumn.MinimumWidth = 52
            reservationsDGV.Columns.Insert(1, deleteButtonColumn)
        End If

        ' Add columns to the DataGridView
        reservationsDGV.Columns("ReservationID").HeaderText = "Reservation #"
        reservationsDGV.Columns("MemberID").HeaderText = "Member ID"
        reservationsDGV.Columns("Name").HeaderText = "Equipment Name"
        reservationsDGV.Columns("FirstName").HeaderText = "Staff Name"
        reservationsDGV.Columns("ReservationDate").HeaderText = "Reservation Date"
        reservationsDGV.Columns("StartTime").HeaderText = "Start Time"
        reservationsDGV.Columns("EndTime").HeaderText = "End Time"
        reservationsDGV.Columns("ReservationStatus").HeaderText = "Status"
        reservationsDGV.Columns("Purpose").HeaderText = "Training Type"
        reservationsDGV.Columns("ReservationNotes").HeaderText = "Notes"
        reservationsDGV.Columns("Cancellation").HeaderText = "Cancellation"
        reservationsDGV.Columns("Reschedule").HeaderText = "Reschedule"
        reservationsDGV.Columns("PaymentStatus").HeaderText = "Payment Status"
        reservationsDGV.Columns("Feedback").HeaderText = "Feedback"
        reservationsDGV.Columns("ReservationFee").HeaderText = "Fee"
    End Sub

    Private isEditMode As Boolean = False
    Private originalValues As New Dictionary(Of Integer, Dictionary(Of String, String))
    Private selectedReservationID As Integer
    Private selectedCell As DataGridViewCell
    Private editedRows As New Dictionary(Of Integer, Boolean)

    Private Sub reservationsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles reservationsDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = reservationsDGV.Rows(e.RowIndex)
            selectedCell = reservationsDGV.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim reservationID As Integer = selectedRow.Cells("ReservationID").Value

            ' Debug: Log the ReadOnly status of each cell in the selected row
            Debug.WriteLine($"Clicked row: {e.RowIndex}, ReservationID: {reservationID}")
            For Each cell As DataGridViewCell In selectedRow.Cells
                Debug.WriteLine($"Cell [{cell.ColumnIndex}] ReadOnly: {cell.ReadOnly}")
            Next

            If e.ColumnIndex = reservationsDGV.Columns("Edit").Index Then
                ' Handle Edit button click
                If Not editedRows.ContainsKey(reservationID) OrElse Not editedRows(reservationID) Then
                    selectedReservationID = reservationID
                    StoreOriginalValues(selectedRow)
                    EnableRowEditing(selectedRow)
                    isEditMode = True ' Start edit mode
                    MessageBox.Show("Cells in Selected Row are now EDITABLE for ReservationID: " & reservationID)
                    ' Debug: Log the state of the DataGridView
                    Debug.WriteLine("Row is now editable for ReservationID: " & reservationID)
                    For Each cell As DataGridViewCell In selectedRow.Cells
                        Debug.WriteLine("Cell [" & cell.ColumnIndex & "]: ReadOnly = " & cell.ReadOnly)
                    Next
                Else
                    MessageBox.Show("This row is locked and cannot be edited.")
                End If
            ElseIf e.ColumnIndex = reservationsDGV.Columns("Delete").Index Then
                ' Handle Delete button click
                Dim resultDelete As DialogResult = MessageBox.Show("Do you want to delete the entire row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultDelete = DialogResult.Yes Then
                    ' Delete entire row
                    DeleteReservation(reservationID)
                    If reservationsDGV.Rows.Contains(selectedRow) Then
                        reservationsDGV.Rows.Remove(selectedRow)
                        MessageBox.Show("Record deleted successfully for ReservationID: " & reservationID)
                    Else
                        MessageBox.Show("Row does not belong to this DataGridView.")
                    End If
                End If
            Else
                ' Ensure the row remains read-only if it has been locked
                If isEditMode Then
                    If reservationID = selectedReservationID Then
                        If Not editedRows.ContainsKey(reservationID) OrElse Not editedRows(reservationID) Then
                            For Each cell As DataGridViewCell In selectedRow.Cells
                                cell.ReadOnly = False
                            Next
                            reservationsDGV.ReadOnly = False
                        Else
                            MessageBox.Show("This row is locked and cannot be edited.")
                        End If
                    Else
                        LockDataGridView()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub StoreOriginalValues(row As DataGridViewRow)
        Dim reservationID As Integer = row.Cells("ReservationID").Value
        If Not originalValues.ContainsKey(reservationID) Then
            originalValues(reservationID) = row.Cells.Cast(Of DataGridViewCell).ToDictionary(Function(cell) cell.OwningColumn.Name, Function(cell) cell.Value.ToString())
        End If
    End Sub

    Private Sub EnableRowEditing(row As DataGridViewRow)
        Dim reservationID As Integer = row.Cells("ReservationID").Value
        If Not editedRows.ContainsKey(reservationID) OrElse Not editedRows(reservationID) Then
            For Each cell As DataGridViewCell In row.Cells
                cell.ReadOnly = False
                Debug.WriteLine("Cell [" & cell.ColumnIndex & "]: ReadOnly = " & cell.ReadOnly)
            Next
            reservationsDGV.ReadOnly = False
            reservationsDGV.CurrentCell = row.Cells(0)
            reservationsDGV.BeginEdit(True)
            Debug.WriteLine("reservationsDGV.ReadOnly = " & reservationsDGV.ReadOnly)
        Else
            MessageBox.Show("This row is locked and cannot be edited.")
        End If
    End Sub

    Private Sub LockDataGridView()
        For Each row As DataGridViewRow In reservationsDGV.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.ReadOnly = True
            Next
        Next
        reservationsDGV.ReadOnly = True
        Debug.WriteLine("All cells in reservationsDGV are now ReadOnly.")
    End Sub

    Private Sub reservationsDGV_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles reservationsDGV.CellBeginEdit
        ' Allow editing if the cell being edited is within the same row as the initially selected cell
        If selectedCell IsNot Nothing AndAlso reservationsDGV.Rows(e.RowIndex).Cells("ReservationID").Value = selectedReservationID Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub reservationsDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles reservationsDGV.CellEndEdit
        Dim editedRow As DataGridViewRow = reservationsDGV.Rows(e.RowIndex)
        Dim reservationID As Integer = editedRow.Cells("ReservationID").Value
        Dim changes As New List(Of String)

        If originalValues.ContainsKey(reservationID) Then
            For Each cell As DataGridViewCell In editedRow.Cells
                Dim columnName As String = reservationsDGV.Columns(cell.ColumnIndex).Name
                If originalValues(reservationID)(columnName) <> cell.Value.ToString() Then
                    changes.Add($"{columnName}: {originalValues(reservationID)(columnName)} -> {cell.Value}")
                End If
            Next

            If changes.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show($"The following changes were made:{Environment.NewLine}{String.Join(Environment.NewLine, changes)}{Environment.NewLine}Do you want to save these changes?", "Confirm Save", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    SaveEditedRow(editedRow)
                    MessageBox.Show("Changes Saved")
                    ' Lock the edited row to prevent further editing
                    For Each cell As DataGridViewCell In editedRow.Cells
                        cell.ReadOnly = True
                        Debug.WriteLine($"Cell [{cell.ColumnIndex}] for ReservationID: {reservationID} is now ReadOnly.")
                    Next
                    editedRows(reservationID) = True
                Else
                    ' Revert changes
                    For Each cell As DataGridViewCell In editedRow.Cells
                        Dim columnName As String = reservationsDGV.Columns(cell.ColumnIndex).Name
                        cell.Value = originalValues(reservationID)(columnName)
                    Next
                End If
            End If
        Else
            Debug.WriteLine($"Original values not found for ReservationID: {reservationID}")
        End If

        ' Prompt to end edit mode
        Dim endEditModeResult As DialogResult = MessageBox.Show("Do you want to end the edit mode?", "End Edit Mode", MessageBoxButtons.YesNo)
        If endEditModeResult = DialogResult.Yes Then
            LockDataGridView()
            isEditMode = False ' End edit mode
            Debug.WriteLine("reservationsDGV is now ReadOnly.")

            ' Debug: Log the ReadOnly status of each cell in the edited row
            Debug.WriteLine($"Checking ReadOnly status of each cell in row for ReservationID: {reservationID} after ending edit mode:")
            For Each cell As DataGridViewCell In editedRow.Cells
                Debug.WriteLine($"Cell [{cell.ColumnIndex}] ReadOnly: {cell.ReadOnly}")
            Next
        Else
            reservationsDGV.ReadOnly = False
            Debug.WriteLine("reservationsDGV remains editable.")
        End If
    End Sub
    Private Sub SaveEditedRow(row As DataGridViewRow)
        Try
            Dim reservationID As Integer = row.Cells("ReservationID").Value
            Dim memberID As Integer = ValidateInteger(row.Cells("MemberID").Value, "MemberID")
            Dim equipmentName As String = row.Cells("Name").Value.ToString().Trim()
            Dim staffName As String = row.Cells("FirstName").Value.ToString().Trim()
            Dim reservationDate As DateTime
            Dim startTime As TimeSpan
            Dim endTime As TimeSpan
            Dim reservationStatus As String = row.Cells("ReservationStatus").Value.ToString().Trim()
            Dim purpose As String = row.Cells("Purpose").Value.ToString().Trim()
            Dim reservationNotes As String = row.Cells("ReservationNotes").Value.ToString().Trim()
            Dim cancellation As Boolean
            Dim reschedule As Boolean
            Dim paymentStatus As String = row.Cells("PaymentStatus").Value.ToString().Trim()
            Dim feedback As String = row.Cells("Feedback").Value.ToString().Trim()
            Dim reservationFee As Decimal

            ' Check for blank or space-only values
            If String.IsNullOrWhiteSpace(equipmentName) OrElse String.IsNullOrWhiteSpace(staffName) OrElse String.IsNullOrWhiteSpace(reservationStatus) OrElse String.IsNullOrWhiteSpace(purpose) OrElse String.IsNullOrWhiteSpace(reservationNotes) OrElse String.IsNullOrWhiteSpace(paymentStatus) OrElse String.IsNullOrWhiteSpace(feedback) Then
                MessageBox.Show("Fields cannot be blank or contain only spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate date format
            If Not DateTime.TryParse(row.Cells("ReservationDate").Value.ToString(), reservationDate) Then
                MessageBox.Show("Invalid date format for Reservation Date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate time format
            If Not TimeSpan.TryParse(row.Cells("StartTime").Value.ToString(), startTime) Then
                MessageBox.Show("Invalid time format for Start Time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not TimeSpan.TryParse(row.Cells("EndTime").Value.ToString(), endTime) Then
                MessageBox.Show("Invalid time format for End Time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If endTime <= startTime Then
                MessageBox.Show("End Time must be after Start Time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate boolean values
            If Not Boolean.TryParse(row.Cells("Cancellation").Value.ToString(), cancellation) Then
                MessageBox.Show("Invalid value for Cancellation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not Boolean.TryParse(row.Cells("Reschedule").Value.ToString(), reschedule) Then
                MessageBox.Show("Invalid value for Reschedule.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate decimal format
            If Not Decimal.TryParse(row.Cells("ReservationFee").Value.ToString(), reservationFee) Then
                MessageBox.Show("Invalid format for Reservation Fee.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Retrieve equipment and staff IDs
            Dim equipmentID As Integer = ValidateEquipmentID(equipmentName)
            Dim staffID As Integer = ValidateStaffID(staffName)

            ' Update the reservation table with the edited values
            Dim updateQuery As String = $"UPDATE reservation SET " &
                                    $"MemberID = {memberID}, " &
                                    $"EquipmentID = {equipmentID}, " &
                                    $"StaffID = {staffID}, " &
                                    $"ReservationDate = '{reservationDate:yyyy-MM-dd}', " &
                                    $"StartTime = '{startTime}', " &
                                    $"EndTime = '{endTime}', " &
                                    $"ReservationStatus = '{reservationStatus}', " &
                                    $"Purpose = '{purpose}', " &
                                    $"ReservationNotes = '{reservationNotes}', " &
                                    $"Cancellation = {cancellation}, " &
                                    $"Reschedule = {reschedule}, " &
                                    $"PaymentStatus = '{paymentStatus}', " &
                                    $"Feedback = '{feedback}', " &
                                    $"ReservationFee = {reservationFee} " &
                                    $"WHERE ReservationID = {reservationID}"
            readQuery(updateQuery)
        Catch ex As Exception
            MessageBox.Show($"Error saving reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInteger(value As Object, fieldName As String) As Integer
        Dim result As Integer
        If Not Integer.TryParse(value.ToString(), result) Then
            Throw New ArgumentException($"{fieldName} must be a valid integer.")
        End If
        Return result
    End Function

    Private Function ValidateEquipmentID(name As String) As Integer
        If String.IsNullOrWhiteSpace(name) Then
            Throw New ArgumentException("Equipment Name cannot be empty.")
        End If
        Dim equipmentID As Object = ExecuteScalar($"SELECT EquipmentID FROM equipment WHERE Name = '{name}'")
        If equipmentID Is Nothing OrElse IsDBNull(equipmentID) Then
            Throw New ArgumentException("Invalid Equipment Name.")
        End If
        Return Convert.ToInt32(equipmentID)
    End Function

    Private Function ValidateStaffID(name As String) As Integer
        If String.IsNullOrWhiteSpace(name) Then
            Throw New ArgumentException("Staff Name cannot be empty.")
        End If
        Dim staffID As Object = ExecuteScalar($"SELECT StaffID FROM staff WHERE FirstName = '{name}'")
        If staffID Is Nothing OrElse IsDBNull(staffID) Then
            Throw New ArgumentException("Invalid Staff Name.")
        End If
        Return Convert.ToInt32(staffID)
    End Function

    Private Function ExecuteScalar(query As String) As Object
        Dim result As Object = Nothing
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    result = cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function


    Private Sub DeleteReservation(reservationID As Integer)
        ' Implement logic to delete the reservation
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete reservation with ID: {reservationID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = $"DELETE FROM reservation WHERE ReservationID = {reservationID}"
            readQuery(query)
            ' Refresh the DataGridView
            LoadReservationsForMember(reservationsDGV.Rows(0).Cells("MemberID").Value)
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Dim color1 = Color.Gold
        Dim color2 = Color.White
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, Panel5.Width, Panel5.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 90.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    Private Sub btnForPayment_Click(sender As Object, e As EventArgs) Handles btnForPayment.Click
        UpdateConnectionString()
        ' Fetch data from the membership table in the database
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim query As String = $"SELECT m.MemberID, p.PaymentStatus, m.Cost FROM membership m LEFT JOIN payment p ON m.MemberID = p.MemberID WHERE m.MemberID = {CurrentLoggedUser.id}"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim memberID As Integer = Convert.ToInt32(reader("MemberID"))
                        Dim paymentStatus As String = reader("PaymentStatus").ToString()

                        ' Check if Cost is 0 or null
                        Dim isMembership As Boolean = False
                        Dim fee As Decimal = 0
                        If Not IsDBNull(reader("Cost")) Then
                            fee = Convert.ToDecimal(reader("Cost"))
                            isMembership = True
                        End If

                        ' Check if the fee is greater than 0 and payment status is "Unpaid" before opening the BillingPaymentForm
                        If fee >= 0 AndAlso paymentStatus = "Unpaid" Then
                            Debug.WriteLine("asdassasd: " & fee)
                            ' Create a new payment record if it's a new payment
                            Dim newPaymentID As Integer = CreateNewPayment(memberID)

                            ' Create a new instance of the BillingPaymentForm with the necessary data
                            Dim paymentForm As New BillingPaymentForm(fee, isMembership, newPaymentID, memberID)

                            ' Calculate the center point
                            Dim centerX As Integer = (ClientSize.Width - paymentForm.Width) / 2
                            Dim centerY As Integer = (ClientSize.Height - paymentForm.Height) / 2

                            ' Set the location of the BillingPaymentForm to the center
                            paymentForm.Location = New Point(centerX, centerY)

                            ' Add the BillingPaymentForm to the form
                            Controls.Add(paymentForm)
                            paymentForm.BringToFront()
                            Debug.WriteLine("Debug: BillingPaymentForm user control added.")
                            Debug.WriteLine($"Debug: Form Amount = {paymentForm.txtAmount.Text}, SubTotal = {paymentForm.txtSubTotal.Text}")
                        Else
                            Debug.WriteLine("Debug: Fee is not greater than zero or PaymentStatus is not Unpaid, BillingPaymentForm not added.")
                            MessageBox.Show("This payment cannot be made.", "Payment Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Function CreateNewPayment(memberID As Integer) As Integer
        Dim newPaymentID As Integer = 0
        Dim fee As Decimal = 0

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            ' Fetch the Cost from the membership table
            Dim query As String = $"SELECT Cost FROM membership WHERE MemberID = {memberID}"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    fee = Convert.ToDecimal(reader("Cost"))
                    Debug.WriteLine("Cost: " & fee)
                End If
                reader.Close()
            End Using

            ' Insert a new payment record
            Dim insertQuery As String = $"INSERT INTO payment (MemberID, Amount, PaymentStatus, PaymentMethod, PaymentDate, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, MembershipID) " &
                                        $"VALUES ({memberID}, {fee}, 'Unpaid', 'N/A', '{DateTime.MinValue:yyyy-MM-dd}', 'N/A', 'N/A', 0, 0, 0, 'N/A', {memberID}); SELECT LAST_INSERT_ID();"
            Using cmd As New MySqlCommand(insertQuery, conn)
                newPaymentID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        Return newPaymentID
    End Function

End Class

Public Class MemberData
    Public Property MemberID As Integer
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property Username As String
    Public Property Sex As String
    Public Property PhoneNumber As String
    Public Property DTCreated As DateTime
    Public Property Address As String
    Public Property Cost As Decimal
    Public Property MembershipType As String
    Public Property Duration As String
    Public Property Status As String
    Public Property Weight As Decimal
    Public Property Height As Decimal
    Public Property Email As String
    Public Property DOB As DateTime
    Public Property StartDate As DateTime
    Public Property EndDate As DateTime
    Public Property RenewalPolicy As String
    Public Property Benefits As String
    Public Property MemberShipName As String
    Public Property PaymentStatus As String
End Class
