
Public Class Announcements
    Public Property Title As String
    Public Property Message As String
    Public Property DatePosted As DateTime

    ' Create a list to hold announcements
    Private announcement As New List(Of Announcements)

    Private Sub LoadAnnouncements()
        ' Populate with sample data
        announcement = New List(Of Announcements) From {
        New Announcements With {.Title = "Holiday Notice", .Message = "The gym will be closed on Christmas Day.", .DatePosted = New Date(2024, 12, 25)},
        New Announcements With {.Title = "New Yoga Class", .Message = "A new yoga class will begin every Monday at 6:00 PM.", .DatePosted = New Date(2024, 12, 10)},
        New Announcements With {.Title = "Equipment Maintenance", .Message = "Treadmills will be unavailable for maintenance on Dec 15.", .DatePosted = New Date(2024, 12, 15)}
    }
    End Sub

    Private Sub SetupAnnouncementGrid()
        ' Set up the DataGridView properties
        With DataGridView1
            .AutoGenerateColumns = False
            .Columns.Clear()

            ' Add a Title column
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Title",
            .DataPropertyName = "Title",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })

            ' Add a Message column
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Message",
            .DataPropertyName = "Message",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })

            ' Add a Date Posted column
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Date Posted",
            .DataPropertyName = "DatePosted",
            .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "MM/dd/yyyy"},
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        })

            ' Additional styling
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = True
            .RowHeadersVisible = False
        End With
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load announcements
        LoadAnnouncements()

        ' Set up DataGridView for announcements
        SetupAnnouncementGrid()

        ' Bind the announcements to the DataGridView
        DataGridView1.DataSource = announcement
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView1.DefaultCellStyle.BackColor = Color.Gray
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

    End Sub

    Private Sub AddAnnouncement(newAnnouncement As Announcements)
        announcement.Add(newAnnouncement)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = announcement
    End Sub



End Class

