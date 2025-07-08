Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports GymSystem.Payment
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports Org.BouncyCastle.Crypto

Public Class memberProfileControl
    Public selectedMember As MemberData
    Private reservationsContextMenu As ContextMenuStrip
    Private editItem As ToolStripMenuItem
    Private deleteItem As ToolStripMenuItem
    Private cancelItem As ToolStripMenuItem

    Private notesContextMenu As ContextMenuStrip
    Private editNoteItem As ToolStripMenuItem
    Private deleteNoteItem As ToolStripMenuItem
    Private addNotesControl As AddNotesControl

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Enable double buffering to smooth out UI rendering and reduce flicker.
        Me.DoubleBuffered = True
    End Sub

    Private Sub memberProfileControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
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
            InitializeReservationsContextMenu()

            LoadNotesForMember(selectedMember.MemberID)
            InitializeNotesContextMenu()
            AddHandler notesDGV.CellMouseClick, AddressOf notesDGV_CellMouseClick

            Dim dtAttendance As DataTable = FetchAttendanceData(selectedMember.MemberID)

            LoadAttendanceChartData(selectedMember.MemberID, dtAttendance)
        Else
            MessageBox.Show("Member data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lblPaymentStatus.Text = selectedMember.PaymentStatus
        Me.ResumeLayout(True)
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        If selectedMember IsNot Nothing Then
            Using editForm As New EditMemberProfileForm(selectedMember.MemberID, selectedMember.PhoneNumber, selectedMember.Email, selectedMember.Weight, selectedMember.Height)
                If editForm.ShowDialog() = DialogResult.OK Then
                    ' Refresh data if changes were saved
                    ReloadMemberData()
                End If
            End Using
        Else
            MessageBox.Show("No member selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnViewMemberships_Click(sender As Object, e As EventArgs) Handles btnViewMemberships.Click
        If selectedMember IsNot Nothing Then
            Using historyForm As New MembershipHistoryForm(selectedMember.MemberID)
                historyForm.ShowDialog()
            End Using
        Else
            MessageBox.Show("No member selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ReloadMemberData()
        ' Re-fetch and reload the member's data
        Dim memberData As MemberData = GetMemberData(selectedMember.MemberID)
        LoadMemberData(memberData)
    End Sub

    Private Function GetMemberData(memberId As Integer) As MemberData
        UpdateConnectionString()
        Dim conn As New MySqlConnection(strConnection)
        Dim memberData As New MemberData()
        Try
            conn.Open()
            Dim queryMembers As String = "SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, DTCreated, Status, Weight, Height, Email, DOB FROM members WHERE MemberID = @MemberID"
            Dim cmdMembers As New MySqlCommand(queryMembers, conn)
            cmdMembers.Parameters.AddWithValue("@MemberID", memberId)
            Dim readerMembers As MySqlDataReader = cmdMembers.ExecuteReader()
            If readerMembers.Read() Then
                memberData.MemberID = CInt(readerMembers("MemberID"))
                memberData.FirstName = readerMembers("FirstName").ToString()
                memberData.MiddleName = readerMembers("MiddleName").ToString()
                memberData.LastName = readerMembers("LastName").ToString()
                memberData.Sex = readerMembers("Sex").ToString()
                memberData.PhoneNumber = readerMembers("PhoneNumber").ToString()
                memberData.DTCreated = DateTime.Parse(readerMembers("DTCreated").ToString())
                memberData.Status = readerMembers("Status").ToString()
                memberData.Weight = Decimal.Parse(readerMembers("Weight").ToString())
                memberData.Height = Decimal.Parse(readerMembers("Height").ToString())
                memberData.Email = readerMembers("Email").ToString()
                memberData.DOB = DateTime.Parse(readerMembers("DOB").ToString())
            End If
            readerMembers.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        Return memberData
    End Function

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



    Private Sub notesDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            ' Select the row that was right-clicked
            notesDGV.ClearSelection()
            notesDGV.Rows(e.RowIndex).Selected = True
            ' Display the context menu at the mouse pointer's location
            notesContextMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub InitializeNotesContextMenu()
        notesContextMenu = New ContextMenuStrip()
        editNoteItem = New ToolStripMenuItem("Edit")
        deleteNoteItem = New ToolStripMenuItem("Delete")

        notesContextMenu.Items.Add(editNoteItem)
        notesContextMenu.Items.Add(deleteNoteItem)

        AddHandler editNoteItem.Click, AddressOf EditNote_Click
        AddHandler deleteNoteItem.Click, AddressOf DeleteNote_Click
    End Sub

    Private Sub EditNote_Click(sender As Object, e As EventArgs)
        Try
            If notesDGV.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = notesDGV.SelectedRows(0)
                Dim noteID As Integer = Convert.ToInt32(selectedRow.Cells("NoteID").Value)
                Dim noteDetails As String = selectedRow.Cells("NoteDetails").Value.ToString()
                Dim dateAdded As DateTime = Convert.ToDateTime(selectedRow.Cells("DateAdded").Value)

                If addNotesControl Is Nothing Then
                    addNotesControl = New AddNotesControl()
                    Me.Controls.Add(addNotesControl)
                    addNotesControl.Location = New Point((Me.Width - addNotesControl.Width) / 2, (Me.Height - addNotesControl.Height) / 2)
                    addNotesControl.BringToFront()
                    AddHandler addNotesControl.NoteUpdated, AddressOf Me.NoteUpdated_Handler
                End If

                addNotesControl.SetNoteData(noteID, noteDetails, dateAdded)
                addNotesControl.Show()
                addNotesControl.BringToFront()
            Else
                MessageBox.Show("Please select a note to edit.", "No Note Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while preparing to edit the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NoteUpdated_Handler(noteID As Integer, noteDetails As String, dateAdded As DateTime)
        Try
            UpdateNoteInDatabase(noteID, noteDetails, dateAdded)
            LoadNotesForMember(selectedMember.MemberID)
            MessageBox.Show("Note updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateNoteInDatabase(noteID As Integer, noteDetails As String, dateAdded As DateTime)
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim query As String = "UPDATE notes SET NoteDetails = @NoteDetails, DateAdded = @DateAdded WHERE NoteID = @NoteID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NoteDetails", noteDetails)
                cmd.Parameters.AddWithValue("@DateAdded", dateAdded)
                cmd.Parameters.AddWithValue("@NoteID", noteID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub DeleteNote_Click(sender As Object, e As EventArgs)
        Try
            If notesDGV.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = notesDGV.SelectedRows(0)
                Dim noteID As Integer = Convert.ToInt32(selectedRow.Cells("NoteID").Value)

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this note?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    DeleteNoteFromDatabase(noteID)
                    LoadNotesForMember(selectedMember.MemberID)
                    MessageBox.Show("Note deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select a note to delete.", "No Note Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteNoteFromDatabase(noteID As Integer)
        ' Implement the logic to delete the note from the database
        ' Example:
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM notes WHERE NoteID = @NoteID", conn)
            cmd.Parameters.AddWithValue("@NoteID", noteID)
            cmd.ExecuteNonQuery()
        End Using
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
        lblWeightAndHeight.Text = memberData.Weight & "kg  |  " & memberData.Height & "ft"
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
        Debug.WriteLine("3status: " & paymentStatus)
        Return paymentStatus
    End Function

    Private Sub UpdatePaymentStatusLabel(paymentID As Integer)
        Dim paymentStatus As String = GetPaymentStatus(paymentID)
        lblPaymentStatus.Text = paymentStatus
        Debug.WriteLine("2status: " & paymentStatus)
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
        addNotesControl.BringToFront()
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
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' 1. Package reservation details
                    Dim details As New ReservationDetails With {
                        .MemberID = memberID,
                        .EquipmentID = equipmentID,
                        .StaffID = staffID,
                        .ReservationDate = reservationDate,
                        .StartTime = startTime,
                        .EndTime = endTime,
                        .ReservationFee = reservationFee,
                        .ReservationNotes = reservationNotes,
                        .Purpose = purpose
                    }

                    ' 2. Create and show the transactional payment form using the host
                    Using paymentHostForm As New BillingPaymentHostForm(conn, transaction, details)
                        Dim result As DialogResult = paymentHostForm.ShowDialog()

                        If result = DialogResult.OK Then
                            ' The payment form's logic has already run inside the transaction.
                            ' Now we commit the transaction.
                            transaction.Commit()
                            MessageBox.Show("Reservation and payment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' The user cancelled or an error occurred in the payment form.
                            ' The transaction will be rolled back.
                            transaction.Rollback()
                            MessageBox.Show("Payment was cancelled. The reservation has not been saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using

                    ' Refresh the reservations DataGridView regardless to show new state
                    LoadReservationsForMember(memberID)

                Catch ex As Exception
                    ' If anything goes wrong, roll back
                    transaction.Rollback()
                    MessageBox.Show("An error occurred during the reservation process: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' The connection and transaction are handled by the Using blocks
                End Try
            End Using
        End Using
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
        Dim query As String = $"SELECT r.ReservationID, r.MemberID, e.Name AS Name, CONCAT(s.FirstName, ' ', s.LastName) AS StaffName, r.ReservationDate, r.StartTime, r.EndTime, r.ReservationStatus, r.Purpose, r.ReservationNotes, r.Cancellation, r.Reschedule, r.PaymentStatus, r.Feedback, r.ReservationFee " &
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
        reservationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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



        ' Add columns to the DataGridView
        reservationsDGV.Columns("ReservationID").HeaderText = "Reservation #"
        reservationsDGV.Columns("MemberID").HeaderText = "Member ID"
        reservationsDGV.Columns("Name").HeaderText = "Equipment Name"
        reservationsDGV.Columns("StaffName").HeaderText = "Staff Name"
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

        ' Reorder columns for better readability
        reservationsDGV.Columns("ReservationID").DisplayIndex = 0
        reservationsDGV.Columns("Purpose").DisplayIndex = 1
        reservationsDGV.Columns("ReservationDate").DisplayIndex = 2
        reservationsDGV.Columns("StartTime").DisplayIndex = 3
        reservationsDGV.Columns("EndTime").DisplayIndex = 4
        reservationsDGV.Columns("ReservationStatus").DisplayIndex = 5
        reservationsDGV.Columns("Name").DisplayIndex = 6 ' Equipment Name
        reservationsDGV.Columns("StaffName").DisplayIndex = 7 ' Staff Name
        reservationsDGV.Columns("ReservationFee").DisplayIndex = 8
        reservationsDGV.Columns("PaymentStatus").DisplayIndex = 9

        ' Hide non-essential columns for a cleaner UI
        reservationsDGV.Columns("MemberID").Visible = False
        reservationsDGV.Columns("ReservationNotes").Visible = False
        reservationsDGV.Columns("Cancellation").Visible = False
        reservationsDGV.Columns("Reschedule").Visible = False
        reservationsDGV.Columns("Feedback").Visible = False
    End Sub

    Private Sub reservationsDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles reservationsDGV.CellFormatting
        If reservationsDGV.Columns(e.ColumnIndex).Name = "ReservationStatus" Then
            Dim status As String = e.Value.ToString()
            If status = "Cancelled" Then
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub


    Private Sub reservationsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles reservationsDGV.CellClick
        ' This event handler is intentionally left blank.
        ' The functionality was moved to the context menu's EditMenuItem_Click event handler
        ' to provide a better user experience and avoid accidental edits on left-click.
    End Sub

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

    Private Sub InitializeReservationsContextMenu()
        reservationsContextMenu = New ContextMenuStrip()
        editItem = New ToolStripMenuItem("Edit")
        deleteItem = New ToolStripMenuItem("Delete")
        cancelItem = New ToolStripMenuItem("Cancel")

        reservationsContextMenu.Items.Add(editItem)
        reservationsContextMenu.Items.Add(deleteItem)
        reservationsContextMenu.Items.Add(cancelItem)

        AddHandler editItem.Click, AddressOf EditMenuItem_Click
        AddHandler deleteItem.Click, AddressOf DeleteMenuItem_Click
        AddHandler cancelItem.Click, AddressOf CancelMenuItem_Click

        reservationsDGV.ContextMenuStrip = reservationsContextMenu
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        If reservationsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = reservationsDGV.SelectedRows(0)
            Dim reservationID As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)
            Dim status As String = selectedRow.Cells("ReservationStatus").Value.ToString()

            If (status = "Confirmed" OrElse status = "Ongoing" OrElse status = "Cancelled" OrElse status = "Completed") AndAlso CurrentLoggedUser.position = "Member" Then
                MessageBox.Show("Confirmed, Ongoing, Cancelled, or Completed reservations cannot be edited.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                UpdateConnectionString()
                Dim connectionString As String = strConnection
                Using editForm As New EditReservationForm(reservationID, connectionString, CurrentLoggedUser.position)
                    If editForm.ShowDialog() = DialogResult.OK Then
                        LoadReservationsForMember(selectedMember.MemberID)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error opening edit form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        If reservationsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = reservationsDGV.SelectedRows(0)
            Dim reservationID As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)
            Dim status As String = selectedRow.Cells("ReservationStatus").Value.ToString()

            If (status = "Confirmed" OrElse status = "Ongoing" OrElse status = "Cancelled") AndAlso CurrentLoggedUser.position = "Member" Then
                MessageBox.Show("Confirmed, Ongoing, or Cancelled reservations cannot be deleted.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteReservation(reservationID)
                LoadReservationsForMember(selectedMember.MemberID)
            End If
        End If
    End Sub

    Private Sub CancelMenuItem_Click(sender As Object, e As EventArgs)
        If reservationsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = reservationsDGV.SelectedRows(0)
            Dim reservationID As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)
            Dim memberID As Integer = Convert.ToInt32(selectedRow.Cells("MemberID").Value)
            Dim status As String = selectedRow.Cells("ReservationStatus").Value.ToString()

            If (status = "Confirmed" OrElse status = "Ongoing" OrElse status = "Cancelled") AndAlso CurrentLoggedUser.position = "Member" Then
                MessageBox.Show("Confirmed, Ongoing, or Cancelled reservations cannot be cancelled.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim resultCancel As DialogResult = MessageBox.Show("Do you want to cancel this reservation? There will be NO REFUND!", "Cancel Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultCancel = DialogResult.Yes Then
                Dim query As String = $"UPDATE reservation SET ReservationStatus = 'Cancelled', Cancellation = 'Yes' WHERE ReservationID = {reservationID}"
                readQuery(query)
                LoadReservationsForMember(memberID)
                MessageBox.Show("Reservation cancelled successfully for ReservationID: " & reservationID)
            End If
        End If
    End Sub

    Private Sub reservationsDGV_MouseClick(sender As Object, e As MouseEventArgs) Handles reservationsDGV.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim hitTestInfo As DataGridView.HitTestInfo = reservationsDGV.HitTest(e.X, e.Y)
            If hitTestInfo.RowIndex >= 0 AndAlso hitTestInfo.RowIndex < reservationsDGV.Rows.Count Then
                reservationsDGV.ClearSelection()
                Dim selectedRow As DataGridViewRow = reservationsDGV.Rows(hitTestInfo.RowIndex)
                selectedRow.Selected = True

                Dim status As String = selectedRow.Cells("ReservationStatus").Value.ToString()
                Dim isMember As Boolean = (CurrentLoggedUser.position = "Member")


                ' Disable menu items for members if reservation is Confirmed, Ongoing, or Cancelled
                Dim isActionable As Boolean = Not (isMember AndAlso (status = "Confirmed" OrElse status = "Ongoing" OrElse status = "Cancelled"))

                editItem.Enabled = isActionable
                deleteItem.Enabled = isActionable
                cancelItem.Enabled = isActionable

                reservationsContextMenu.Show(reservationsDGV, e.Location)
            End If
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
    Public Property Province As String
    Public Property City As String
    Public Property Street As String
    Public Property ZipCode As String
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
