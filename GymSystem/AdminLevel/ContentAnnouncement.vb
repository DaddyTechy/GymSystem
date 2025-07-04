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

    Private Sub notesDGV_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles notesDGV.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            notesDGV.ClearSelection()
            notesDGV.Rows(e.RowIndex).Selected = True
            Dim pt = e.Location
            rowContextMenuStrip.Show(notesDGV, pt.X, pt.Y)
        End If
    End Sub

    Private Sub editToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles editToolStripMenuItem.Click
        If notesDGV.SelectedRows.Count > 0 Then
            Dim selectedRow = notesDGV.SelectedRows(0)
            Dim announcementID = Convert.ToInt32(selectedRow.Cells("AnnouncementID").Value)

            Dim editAnnouncementControl As New AddAnnouncement(announcementID)
            AddHandler editAnnouncementControl.AnnouncementSaved, AddressOf OnAnnouncementSaved

            Dim hostForm As New Form With {
                .Text = "Edit Announcement",
                .StartPosition = FormStartPosition.CenterParent,
                .Size = New System.Drawing.Size(292, 344),
                .FormBorderStyle = FormBorderStyle.FixedDialog,
                .MaximizeBox = False,
                .MinimizeBox = False
            }

            hostForm.Controls.Add(editAnnouncementControl)
            editAnnouncementControl.Dock = DockStyle.Fill
            hostForm.ShowDialog()
        End If
    End Sub

    Private Sub deleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deleteToolStripMenuItem.Click
        If notesDGV.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this announcement?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim announcementID = Convert.ToInt32(notesDGV.SelectedRows(0).Cells("AnnouncementID").Value)
                DeleteNoteFromDatabase(announcementID)
                LoadNotesForMember(CurrentLoggedUser.id) ' Refresh list
            End If
        End If
    End Sub

    Private Sub DeleteNoteFromDatabase(AnnouncementID As Integer)
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "DELETE FROM announcement WHERE AnnouncementID = @AnnouncementID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AnnouncementID", AnnouncementID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the announcement: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnAnnouncementSaved()
        LoadNotesForMember(CurrentLoggedUser.id)
    End Sub

    Private Sub ContentAnnouncement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotesForMember(CurrentLoggedUser.id)
    End Sub

    Private Sub btnAddNotes_Click_1(sender As Object, e As EventArgs) Handles btnAddNotes.Click
        Dim addAnnouncementControl As New AddAnnouncement()
        AddHandler addAnnouncementControl.AnnouncementSaved, AddressOf OnAnnouncementSaved

        Dim hostForm As New Form With {
            .Text = "Add Announcement",
            .StartPosition = FormStartPosition.CenterParent,
            .Size = New System.Drawing.Size(292, 344),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .MaximizeBox = False,
            .MinimizeBox = False
        }

        hostForm.Controls.Add(addAnnouncementControl)
        addAnnouncementControl.Dock = DockStyle.Fill
        hostForm.ShowDialog()
    End Sub

End Class
