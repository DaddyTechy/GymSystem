Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class addReservationControl
    Public Event ReservationAdded(memberID As Integer, equipmentID As Integer, staffID As Integer, reservationDate As DateTime, startTime As DateTime, endTime As DateTime, reservationFee As Decimal, reservationNotes As String, purpose As String)

    Public Property MemberID As Integer

    ' Other properties and methods


    ' Initialize components
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

    Private Sub dtpReservationDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReservationDate.ValueChanged
        ' Ensure the reservation date is not in the past
        If dtpReservationDate.Value.Date < DateTime.Now.Date Then
            dtpReservationDate.Value = DateTime.Now.Date
        End If
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
        UpdateConnectionString()
        Debug.WriteLine($"Loading equipment for training type: {trainingType}")
        ' Implement logic to load equipment based on the selected training type
        Dim query As String = $"SELECT EquipmentID, Name FROM equipment WHERE Type = '{trainingType}' AND Status = 'Operational'"
        ' Execute the query and populate cmbEquipmentType with the results
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        cmbEquipmentType.DataSource = dt
        cmbEquipmentType.DisplayMember = "Name"
        cmbEquipmentType.ValueMember = "EquipmentID"
        Debug.WriteLine($"Loaded {dt.Rows.Count} equipment items.")
        LoadCertifiedTrainers()
    End Sub

    Private Sub cmbTrainer_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbTrainer.SelectedIndexChanged

    End Sub

    Private Sub LoadCertifiedTrainers()
        UpdateConnectionString()
        Debug.WriteLine("Loading certified trainers...")
        ' Implement logic to load trainers with the "Certified Trainer" certification
        Dim query As String = "SELECT StaffID, FirstName, LastName, Position FROM staff WHERE Position IN ('Receptionist', 'Trainer')"
        ' Execute the query and populate cmbTrainer with the results
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Create a new column for the full name and position
        dt.Columns.Add("FullNamePosition", GetType(String), "FirstName + ' ' + LastName")

        cmbTrainer.DataSource = Nothing ' Clear existing data source
        cmbTrainer.DataSource = dt
        cmbTrainer.DisplayMember = "FullNamePosition"
        cmbTrainer.ValueMember = "StaffID"
        Debug.WriteLine($"Loaded {dt.Rows.Count} certified trainers.")
    End Sub
    Private Sub btnSaveReservation_Click(sender As Object, e As EventArgs) Handles btnSaveReservation.Click
        Dim memberID As Integer = Me.MemberID

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

        ' Your existing logic here
        ' ...

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

        ' Retrieve MembershipID for the member
        ' Implement logic to add reservation
        Dim equipmentID As Integer = Convert.ToInt32(cmbEquipmentType.SelectedValue)
        Dim staffID As Integer = Convert.ToInt32(cmbTrainer.SelectedValue)
        Dim reservationDate As DateTime = dtpReservationDate.Value
        Dim reservationNotes As String = "Sample notes" ' Replace with actual notes
        Dim purpose As String = cmbTrainingType.SelectedItem.ToString()

        ' Calculate the total fee
        Dim totalFee As Decimal = CalculateTotalFee(memberID, startTime, endTime)
        lblTotalFee.Text = $"Php {totalFee:C}"


        ' Raise the ReservationAdded event
        RaiseEvent ReservationAdded(memberID, equipmentID, staffID, reservationDate, startTime, endTime, totalFee, reservationNotes, purpose)
        Me.Hide()
    End Sub


    Private Function IsDiamondMember(memberID As Integer) As Boolean
        UpdateConnectionString()
        Dim query As String = $"SELECT MemberShipName FROM membership WHERE MemberID = {memberID}"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        If dt.Rows.Count > 0 AndAlso dt.Rows(0)("MemberShipName").ToString() = "Diamond" Then
            Return True
        End If
        Return False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if there are unsaved inputs
        Dim initialReservationDate As DateTime = dtpReservationDate.Value.AddSeconds(45)
        Dim initialStartTime As DateTime = dtpStartTime.Value.AddSeconds(45)
        Dim initialEndTime As DateTime = dtpEndTime.Value.AddSeconds(45)

        If (cmbEquipmentType.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmbEquipmentType.SelectedValue.ToString())) OrElse
           (cmbTrainer.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmbTrainer.SelectedValue.ToString())) OrElse
           (dtpReservationDate.Value.Date <> initialReservationDate.Date OrElse dtpReservationDate.Value.TimeOfDay <> initialReservationDate.TimeOfDay) OrElse
           (dtpStartTime.Value.Date <> initialStartTime.Date OrElse dtpStartTime.Value.TimeOfDay <> initialStartTime.TimeOfDay) OrElse
           (dtpEndTime.Value.Date <> initialEndTime.Date OrElse dtpEndTime.Value.TimeOfDay <> initialEndTime.TimeOfDay) OrElse
           Not String.IsNullOrEmpty(txtReservationNotes.Text) OrElse
           (cmbTrainingType.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmbTrainingType.SelectedItem.ToString())) Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If

        Me.Hide()
    End Sub
End Class

