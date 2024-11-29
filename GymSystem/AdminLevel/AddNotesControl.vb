Public Class AddNotesControl
    Public Event NoteAdded(noteDetails As String, author As String, dateAdded As DateTime)

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        Try
            Dim noteDetails As String = txtNoteDetails.Text
            Dim author As String = txtAuthor.Text
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

            ' Raise the NoteAdded event
            RaiseEvent NoteAdded(noteDetails, author, dateAdded)
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the note: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class


