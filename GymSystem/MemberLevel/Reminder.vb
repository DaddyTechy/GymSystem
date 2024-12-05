Public Class Reminder
    Public Property Title As String
    Public Property Message As String
    Public Property DueDate As DateTime
    Public Property IsAcknowledged As Boolean = False ' Track if the reminder is acknowledged

    ' List to store reminders
    Private reminders As New List(Of Reminder)

    Private Sub SetupReminderGrid()
        ' Configure the DataGridView columns
        With DataGridView1
            .ColumnCount = 4
            .Columns(0).Name = "Title"
            .Columns(1).Name = "Message"
            .Columns(2).Name = "Due Date"
            .Columns(3).Name = "Acknowledged"

            ' Style settings for better readability
            .Columns(2).DefaultCellStyle.Format = "dd MMM yyyy"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
    End Sub

    Private Sub LoadRemindersToGrid()
        ' Clear the DataGridView rows
        DataGridView1.Rows.Clear()

        ' Populate reminders into the DataGridView
        For Each reminder In reminders
            DataGridView1.Rows.Add(reminder.Title, reminder.Message, reminder.DueDate.ToShortDateString(), If(reminder.IsAcknowledged, "Yes", "No"))
        Next
    End Sub

    Private Sub AddReminder(title As String, message As String, dueDate As DateTime)
        Dim newReminder As New Reminder With {
        .Title = title,
        .Message = message,
        .DueDate = dueDate
    }

        ' Add the reminder to the list
        reminders.Add(newReminder)

        ' Reload the reminders into the DataGridView
        LoadRemindersToGrid()
    End Sub

    Private Sub CheckMembershipExpiry(membershipEndDate As DateTime)
        ' Check if the membership is expiring soon (e.g., within 7 days)
        Dim daysLeft As Integer = (membershipEndDate - Date.Today).Days

        If daysLeft <= 7 AndAlso daysLeft > 0 Then
            Dim reminderTitle As String = "Membership Expiry"
            Dim reminderMessage As String = $"Your membership will expire in {daysLeft} days."

            ' Add the reminder
            AddReminder(reminderTitle, reminderMessage, membershipEndDate)
        ElseIf daysLeft = 0 Then
            Dim reminderTitle As String = "Membership Expired"
            Dim reminderMessage As String = "Your membership expires today. Please renew."

            ' Add the reminder
            AddReminder(reminderTitle, reminderMessage, membershipEndDate)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' Get the selected reminder
            Dim selectedReminder = reminders(e.RowIndex)

            ' Mark the reminder as acknowledged
            selectedReminder.IsAcknowledged = True

            ' Reload the grid to reflect changes
            LoadRemindersToGrid()
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the DataGridView
        SetupReminderGrid()

        ' Test: Add a static reminder
        AddReminder("Gym Membership", "Your membership will expire soon.", Date.Today.AddDays(5))

        ' Test: Check membership expiry dynamically
        Dim membershipEndDate As DateTime = Date.Today.AddDays(3) ' Example end date
        CheckMembershipExpiry(membershipEndDate)

        ' Automatically resize columns based on content
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Resize based on header size
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells




    End Sub


End Class
