Imports MySql.Data.MySqlClient

Public Class ContentAnnouncement
    Private Sub LoadNotesForMember(memberID As Integer)
        UpdateConnectionString()
        LoadToDGV($"SELECT `AnnouncementID`, `Title`, `Content`, `DatePosted`, `PostedBy` FROM `announcement`", notesDGV)

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

        notesDGV.Columns("AnnouncementID").HeaderText = "Announcement #"
        notesDGV.Columns("Title").HeaderText = "Title"
        notesDGV.Columns("Content").HeaderText = "Content"
        notesDGV.Columns("DatePosted").HeaderText = "Date Added"
        notesDGV.Columns("PostedBy").HeaderText = "Author"
    End Sub

    Private Sub AddDeleteButtonColumn()
        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "Delete"
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        notesDGV.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub notesDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles notesDGV.CellContentClick
        If e.ColumnIndex = notesDGV.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Announcement?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim AnnouncementID As Integer = Convert.ToInt32(notesDGV.Rows(e.RowIndex).Cells("AnnouncementID").Value)
                ' Delete the row from the DataGridView
                notesDGV.Rows.RemoveAt(e.RowIndex)


                DeleteNoteFromDatabase(AnnouncementID)
            End If
        End If
    End Sub

    Private Sub DeleteNoteFromDatabase(AnnouncementID As Integer)
        Dim query As String = $"DELETE FROM announcement WHERE AnnouncementID = {AnnouncementID}"
        readQuery(query)
    End Sub

    Private Sub AnnAdded(annTitle As String, annDetails As String, author As String, dateAdded As DateTime)
        UpdateConnectionString()
        Try
            ' Insert the new note into the notes table
            Dim query As String = $"INSERT INTO `announcement`(`Title`, `Content`, `DatePosted`, `PostedBy`) VALUES ('{annTitle}', '{annDetails}', '{dateAdded.ToString("yyyy-MM-dd")}', '{author}-ID: {CurrentLoggedUser.id}')"
            readQuery(query)

            ' Refresh the DataGridView
            LoadNotesForMember(CurrentLoggedUser.id)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ContentAnnouncement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotesForMember(CurrentLoggedUser.id)
        AddDeleteButtonColumn()
    End Sub

    Private Sub btnAddNotes_Click_1(sender As Object, e As EventArgs) Handles btnAddNotes.Click
        Dim addNotesControl As New AddAnnouncement
        AddHandler addNotesControl.AnnAdded, AddressOf AnnAdded

        ' Calculate the center point
        Dim centerX As Integer = (ClientSize.Width - addNotesControl.Width) / 2
        Dim centerY As Integer = (ClientSize.Height - addNotesControl.Height) / 2

        ' Set the location of the AddNotesControl to the center
        addNotesControl.Location = New Point(centerX, centerY)

        ' Set the size of the AddNotesControl
        addNotesControl.Size = New Size(400, 400) ' Set the desired size

        ' Add the AddNotesControl to the form
        Controls.Add(addNotesControl)
        addNotesControl.BringToFront()
    End Sub

End Class
