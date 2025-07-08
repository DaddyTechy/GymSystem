Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class EditReservationForm
    Private _reservationID As Integer
    Private strConnection As String
    Private _shouldClose As Boolean = False
    Private _userRole As String
    Private _originalEquipmentID As Integer
    Private _originalStaffID As Integer
    Private _reservationPurpose As String

    Public Sub New(ByVal reservationID As Integer, ByVal connectionString As String, ByVal userRole As String)
        InitializeComponent()
        _reservationID = reservationID
        strConnection = connectionString
        _userRole = userRole

        ' Populate training type dropdown
        cmbPurpose.Items.AddRange(New String() {"Strength", "Endurance", "Flexibility"})

        ' Populate status dropdown
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Confirmed")
        cmbStatus.Items.Add("Ongoing")
        cmbStatus.Items.Add("Completed")
        cmbStatus.Items.Add("Cancelled")

        If String.IsNullOrEmpty(strConnection) Then
            MessageBox.Show("Database connection string is not provided.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _shouldClose = True
            Return
        End If

        Try
            ' Load reservation data first to get the purpose
            LoadReservationData()
            ' Load dropdowns based on the purpose
            LoadFilteredEquipment(_reservationPurpose)
            LoadCertifiedTrainers()
            ' Now set the selected values
            cmbEquipment.SelectedValue = _originalEquipmentID
            cmbStaff.SelectedValue = _originalStaffID
        Catch ex As Exception
            MessageBox.Show("Failed to load reservation data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _shouldClose = True
        End Try
    End Sub

    Private Sub EditReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _shouldClose Then
            Me.Close()
            Return
        End If

        ' Disable status editing for non-staff/admin roles
        If _userRole <> "Super Admin" AndAlso _userRole <> "Admin" AndAlso _userRole <> "Staff" Then
            cmbStatus.Enabled = False
        End If

        ' The purpose field should be editable
        cmbPurpose.Enabled = True
    End Sub

    Private Sub LoadFilteredEquipment(ByVal trainingType As String)
        Dim query As String = "SELECT EquipmentID, Name FROM equipment WHERE Type = @Type AND Status = 'Operational'"
        Using conn As New MySqlConnection(strConnection)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Type", trainingType)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbEquipment.DataSource = dt
                cmbEquipment.DisplayMember = "Name"
                cmbEquipment.ValueMember = "EquipmentID"
            End Using
        End Using
    End Sub

    Private Sub LoadCertifiedTrainers()
        Dim query As String = "SELECT StaffID, FirstName FROM staff WHERE Position = 'Trainer'"
        Using conn As New MySqlConnection(strConnection)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbStaff.DataSource = dt
                cmbStaff.DisplayMember = "FirstName"
                cmbStaff.ValueMember = "StaffID"
            End Using
        End Using
    End Sub

    Private Sub LoadReservationData()
        Using conn As New MySqlConnection(strConnection)
            Dim query As String = "SELECT * FROM reservation WHERE ReservationID = @ReservationID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ReservationID", _reservationID)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        _originalEquipmentID = Convert.ToInt32(reader("EquipmentID"))
                        _originalStaffID = Convert.ToInt32(reader("StaffID"))
                        _reservationPurpose = reader("Purpose").ToString()

                        dtpReservationDate.Value = Convert.ToDateTime(reader("ReservationDate"))
                        dtpStartTime.Value = DateTime.Today.Add(CType(reader("StartTime"), TimeSpan))
                        dtpEndTime.Value = DateTime.Today.Add(CType(reader("EndTime"), TimeSpan))
                        cmbStatus.SelectedItem = reader("ReservationStatus").ToString()
                        cmbPurpose.SelectedItem = _reservationPurpose
                        txtNotes.Text = reader("ReservationNotes").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using conn As New MySqlConnection(strConnection)
                Dim query As String = "UPDATE reservation SET EquipmentID = @EquipmentID, StaffID = @StaffID, ReservationDate = @ReservationDate, " &
                                    "StartTime = @StartTime, EndTime = @EndTime, ReservationStatus = @Status, Purpose = @Purpose, ReservationNotes = @Notes " &
                                    "WHERE ReservationID = @ReservationID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EquipmentID", cmbEquipment.SelectedValue)
                    cmd.Parameters.AddWithValue("@StaffID", cmbStaff.SelectedValue)
                    cmd.Parameters.AddWithValue("@ReservationDate", dtpReservationDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Purpose", cmbPurpose.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text)
                    cmd.Parameters.AddWithValue("@ReservationID", _reservationID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error saving reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurpose.SelectedIndexChanged
        If cmbPurpose.SelectedItem Is Nothing Then Return

        Dim selectedTrainingType As String = cmbPurpose.SelectedItem.ToString()
        LoadFilteredEquipment(selectedTrainingType)
    End Sub
End Class
