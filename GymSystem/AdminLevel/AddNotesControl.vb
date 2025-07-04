Public Class AddNotesControl
    Public Event NoteAdded(noteDetails As String, author As String, dateAdded As DateTime)
    Public Event NoteUpdated(noteID As Integer, noteDetails As String, dateAdded As DateTime)

    Public Property NoteID As Integer
    Public Property IsEditMode As Boolean = False

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        Try
            Dim noteDetails As String = txtNoteDetails.Text
            Dim author As String = CurrentLoggedUser.position & ": " & CurrentLoggedUser.name
            Dim dateAdded As DateTime = dtpDateAdded.Value

            ' Validate inputs
            If String.IsNullOrWhiteSpace(noteDetails) Then
                MessageBox.Show("Note details cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrWhiteSpace(author) Then
                MessageBox.Show("Author cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsEditMode Then
                RaiseEvent NoteUpdated(NoteID, noteDetails, dateAdded)
            Else
                RaiseEvent NoteAdded(noteDetails, author, dateAdded)
            End If
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetNoteData(noteID As Integer, noteDetails As String, dateAdded As DateTime)
        Me.NoteID = noteID
        Me.IsEditMode = True
        txtNoteDetails.Text = noteDetails
        dtpDateAdded.Value = dateAdded
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class


