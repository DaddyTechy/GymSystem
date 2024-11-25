Public Class AddNotesControl
    Public Event NoteAdded(noteDetails As String, author As String, dateAdded As DateTime)

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        Dim noteDetails = txtNoteDetails.Text
        Dim author = txtAuthor.Text
        Dim dateAdded = dtpDateAdded.Value

        ' Raise the NoteAdded event
        RaiseEvent NoteAdded(noteDetails, author, dateAdded)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class

