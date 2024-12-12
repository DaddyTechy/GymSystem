Imports MySql.Data.MySqlClient

Partial Class EventForm
    ' Event declaration for when an event is saved
    Public Event EventSaved(newEvent As Sched.CalendarEvent)

    ' Event date storage
    Private _eventDate As DateTime

    Public Property EventDate As DateTime
        Get
            Return _eventDate
        End Get
        Set(value As DateTime)
            _eventDate = value
        End Set
    End Property

    ' Constructor that accepts a DateTime parameter
    Public Sub New(selectedDate As DateTime)
        InitializeComponent()
        Me.EventDate = selectedDate
        dtpReservationDate.Value = selectedDate
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(200, 40, 40, 40)
        Label1.Text = $"Add Event for {selectedDate:d}"

        ' Add event handlers
        AddHandler btnSaveReservation.Click, AddressOf SaveEvent
        AddHandler Button1.Click, AddressOf CloseForm
    End Sub

    Private Sub SaveEvent(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(cmbTrainingType.Text) Then
            MessageBox.Show("Please enter an event title", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate times
        Dim startTime As DateTime = dtpStartTime.Value
        Dim endTime As DateTime = dtpEndTime.Value

        ' Check if end time is after start time
        If endTime <= startTime Or endTime = startTime Then
            MessageBox.Show("End time must be after start time.")
            Return
        End If

        ' Define the valid time range
        Dim validStartTime As DateTime = DateTime.Today.AddHours(6) ' 6 AM
        Dim validEndTime As DateTime = DateTime.Today.AddHours(22) ' 10 PM

        ' Check if start time and end time are within the valid range
        If startTime < validStartTime Or startTime > validEndTime Or endTime < validStartTime Or endTime > validEndTime Then
            MessageBox.Show("Start time and end time must be between 6 AM and 10 PM.")
            Return
        End If

        ' Validate input
        If cmbTrainingType.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cmbTrainingType.SelectedItem.ToString()) Then
            MessageBox.Show("Please select a training type.")
            Return
        End If

        If cmbEquipmentType.SelectedValue Is Nothing OrElse String.IsNullOrEmpty(cmbEquipmentType.SelectedValue.ToString()) Then
            MessageBox.Show("Please select an equipment type.")
            Return
        End If

        If cmbTrainer.SelectedValue Is Nothing OrElse String.IsNullOrEmpty(cmbTrainer.SelectedValue.ToString()) Then
            MessageBox.Show("Please select a trainer.")
            Return
        End If

        ' Calculate the total fee
        Dim memberID As Integer = CurrentLoggedUser.id
        Dim totalFee As Decimal = CalculateTotalFee(memberID, startTime, endTime)
        lblTotalFee.Text = $"Php {totalFee:C}"

        ' Create new event
        Dim newEvent As New Sched.CalendarEvent With {
        .EventDate = EventDate,
        .Title = cmbTrainingType.SelectedItem.ToString(),
        .Instructor = cmbTrainer.SelectedItem.ToString()
    }

        ' Raise the event
        RaiseEvent EventSaved(newEvent)

        Dim newEventForDatabase As New CalendarEvent With {
    .EventDate = EventDate,
    .StartTime = dtpStartTime.Value,
    .EndTime = dtpEndTime.Value,
    .Title = cmbTrainingType.SelectedItem.ToString(),
    .EquipmentType = cmbEquipmentType.SelectedItem.ToString(),
    .Instructor = cmbTrainer.SelectedItem.ToString(),
    .Notes = txtReservationNotes.Text,
    .MemberID = CurrentLoggedUser.id,
    .ReservationFee = CalculateTotalFee(CurrentLoggedUser.id, dtpStartTime.Value, dtpEndTime.Value),
    .EquipmentID = Convert.ToInt32(cmbEquipmentType.SelectedValue), ' Add the EquipmentID here
    .StaffID = Convert.ToInt32(cmbTrainer.SelectedValue) ' Add the StaffID here
}


        ' Raise the event for saving to database
        SaveEventToDatabase(newEventForDatabase)

        ' Close the form
        Parent.Controls.Remove(Me)
    End Sub

    Private Function IsDiamondMember(memberID As Integer) As Boolean
        UpdateConnectionString()
        Dim query As String = $"SELECT MemberShipName FROM membership WHERE MemberID = {memberID}"
        Dim isDiamond As Boolean = False

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() AndAlso reader("MemberShipName").ToString() = "Diamond" Then
                        isDiamond = True
                    End If
                End Using
            End Using
        End Using

        Return isDiamond
    End Function


    Private Function CalculateTotalFee(memberID As Integer, startTime As DateTime, endTime As DateTime) As Decimal
        If IsDiamondMember(memberID) Then
            Return 0
        End If

        Dim duration As TimeSpan = endTime - startTime
        If duration.TotalHours < 1 Then
            Return 50D
        ElseIf duration.TotalHours < 2 Then
            Return 75D
        Else
            Return 100D
        End If
    End Function

    Private Sub CloseForm(sender As Object, e As EventArgs)
        Parent.Controls.Remove(Me)
    End Sub

    ' Handle value changed and selected index changed events
    Private Sub dtpReservationDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReservationDate.ValueChanged
        Me.EventDate = dtpReservationDate.Value
    End Sub


    Private Sub InitializeComponents()
        InitializeComboBoxes()
        InitializeDateTimePickers()
    End Sub

    Private Sub InitializeComboBoxes()
        ' Initialize ComboBoxes
        Debug.WriteLine("Initializing ComboBoxes...")
        cmbTrainingType.Items.AddRange(New String() {"Strength", "Endurance", "Flexibility"})
        cmbTrainingType.SelectedIndex = 0 ' Set default selection
        Debug.WriteLine("cmbTrainingType initialized with items.")

        ' Load initial data
        LoadEquipmentByTrainingType(cmbTrainingType.SelectedItem.ToString())
        LoadCertifiedTrainers()
    End Sub


    Private Sub InitializeDateTimePickers()
        ' Set the format to show only time for start and end time pickers
        dtpStartTime.Format = DateTimePickerFormat.Custom
        dtpStartTime.CustomFormat = "HH:mm"
        dtpStartTime.ShowUpDown = True

        dtpEndTime.Format = DateTimePickerFormat.Custom
        dtpEndTime.CustomFormat = "HH:mm"
        dtpEndTime.ShowUpDown = True

        ' Set the format to show only date for reservation date picker
        dtpReservationDate.Format = DateTimePickerFormat.Short
        dtpReservationDate.MinDate = DateTime.Now.Date ' Set minimum date to current date

        ' Set initial values for start and end time pickers
        dtpStartTime.Value = DateTime.Today.AddHours(22) ' Set to 6 AM
        dtpEndTime.Value = DateTime.Today.AddHours(6) ' Set to 10 PM
    End Sub

    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        ' Restrict time selection to between 6 AM and 10 PM
        If dtpStartTime.Value.TimeOfDay < TimeSpan.FromHours(6) Then
            dtpStartTime.Value = DateTime.Today.AddHours(6)
        ElseIf dtpStartTime.Value.TimeOfDay > TimeSpan.FromHours(22) Then
            dtpStartTime.Value = DateTime.Today.AddHours(22)
        End If
    End Sub

    Private Sub dtpEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndTime.ValueChanged
        ' Restrict time selection to between 6 AM and 10 PM
        If dtpEndTime.Value.TimeOfDay < TimeSpan.FromHours(6.5) Then
            dtpEndTime.Value = DateTime.Today.AddHours(6)
        ElseIf dtpEndTime.Value.TimeOfDay > TimeSpan.FromHours(22) Then
            dtpEndTime.Value = DateTime.Today.AddHours(22)
        End If
    End Sub

    Private Sub cmbTrainingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrainingType.SelectedIndexChanged
        Debug.WriteLine("cmbTrainingType_SelectedIndexChanged triggered.")
        Dim selectedTrainingType As String = cmbTrainingType.SelectedItem.ToString()
        Debug.WriteLine($"Selected Training Type: {selectedTrainingType}")
        LoadEquipmentByTrainingType(selectedTrainingType)
    End Sub

    Private Sub LoadEquipmentByTrainingType(trainingType As String)
        Dim query As String = $"SELECT EquipmentID, Name FROM equipment WHERE Type = '{trainingType}' AND Status = 'Operational'"
        Dim dt As New DataTable()

        UpdateConnectionString() ' Ensure the connection string is updated

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        ' Bind the data to the ComboBox or other controls
        cmbEquipmentType.DataSource = dt
        cmbEquipmentType.DisplayMember = "Name"
        cmbEquipmentType.ValueMember = "EquipmentID"
        LoadCertifiedTrainers()
    End Sub


    Private Sub LoadCertifiedTrainers()
        UpdateConnectionString()
        Debug.WriteLine("Loading certified trainers...")

        ' Implement logic to load trainers with the "Certified Trainer" certification
        Dim query As String = "SELECT StaffID, FirstName, LastName, Position FROM staff WHERE Position IN ('Trainer')"
        Dim dt As New DataTable()

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        ' Create a new column for the full name and position
        dt.Columns.Add("FullNamePosition", GetType(String), "FirstName + ' ' + LastName")

        cmbTrainer.DataSource = Nothing ' Clear existing data source
        cmbTrainer.DataSource = dt
        cmbTrainer.DisplayMember = "FullNamePosition"
        cmbTrainer.ValueMember = "StaffID"
        Debug.WriteLine($"Loaded {dt.Rows.Count} certified trainers.")
    End Sub


    Public Sub SaveEventToDatabase(newEvent As CalendarEvent)
        Try
            ' Insert the new reservation into the reservations table
            Dim query As String = $"INSERT INTO reservation (MemberID, EquipmentID, StaffID, ReservationDate, StartTime, EndTime, ReservationFee, ReservationNotes, ReservationStatus, Cancellation, Reschedule, PaymentStatus, Feedback, Purpose) " &
                              $"VALUES ({newEvent.MemberID}, {newEvent.EquipmentID}, {newEvent.StaffID}, '{newEvent.EventDate:yyyy-MM-dd}', '{newEvent.StartTime:HH:mm:ss}', '{newEvent.EndTime:HH:mm:ss}', {newEvent.ReservationFee}, '{newEvent.Notes}', 'Pending', False, False, 'Unpaid', '', '{newEvent.Title}')"
            ExecuteQuery(query)


            ' Ask if the user wants to make the payment now or later
            Dim result As DialogResult = MessageBox.Show("Do you want to make the payment now?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Open the BillingPaymentForm
                Dim paymentControl As New BillingPaymentForm()

                ' Set the necessary values
                paymentControl.txtAmount.Text = newEvent.ReservationFee.ToString("F2")
                paymentControl.txtSubTotal.Text = newEvent.ReservationFee.ToString("F2")
                paymentControl.isMembership = False
                paymentControl.memberID = newEvent.MemberID

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
                                                                                      $"VALUES ({newEvent.MemberID}, {newEvent.ReservationFee}, '{paymentMethod}', '{paymentDate:yyyy-MM-dd}', {subTotal}, '{invoiceNumber}', '{receiptNumber}', {discountApplied}, {taxAmount}, {totalAmount}, '{paymentNotes}', 'Paid', '{newEvent.MemberID}')"
                                                             ExecuteQuery(queryPayment)

                                                             ' Update status in the relevant table
                                                             Dim queryReservation As String = $"UPDATE reservation SET PaymentStatus = 'Paid' WHERE MemberID = {newEvent.MemberID}"
                                                             ExecuteQuery(queryReservation)

                                                             ' Notify user of successful save
                                                             MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                             paymentControl.Hide()
                                                         End Sub


            Else
                ' Set payment status to Unpaid and set default values for other fields
                Dim defaultPaymentDate As DateTime = DateTime.MinValue
                Dim queryPayment As String = $"INSERT INTO payment (MemberID, ReservationFee, PaymentStatus, PaymentDate, Amount, PaymentMethod, InvoiceNumber, DiscountApplied, TaxAmount, TotalAmount, ReceiptNumber, PaymentNotes, MembershipID) " &
                                         $"VALUES ({newEvent.MemberID}, {newEvent.ReservationFee}, 'Unpaid', '{defaultPaymentDate:yyyy-MM-dd}', 0, 'N/A', 'N/A', 0, 0, 0, 'N/A', 'N/A', '{newEvent.MemberID}')"
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
End Class


Public Class CalendarEvent
    Public Property EventDate As DateTime
    Public Property StartTime As DateTime
    Public Property EndTime As DateTime
    Public Property Title As String
    Public Property EquipmentType As String
    Public Property Instructor As String
    Public Property Notes As String
    Public Property MemberID As Integer
    Public Property EquipmentID As Integer
    Public Property StaffID As Integer
    Public Property ReservationFee As Decimal
End Class

