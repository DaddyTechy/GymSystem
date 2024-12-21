Public Class AddAnnouncement
    Public Event AnnAdded(annTitle As String, annDetails As String, author As String, dateAdded As DateTime)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveAnn.Click
        Try
            Dim annTitle As String = txtAnnTitle.Text
            Dim annDetails As String = txtAnnDetails.Text
            Dim author As String = CurrentLoggedUser.position & ": " & CurrentLoggedUser.name
            Dim dateAdded As DateTime = dtpDateAdded.Value

            If String.IsNullOrWhiteSpace(annTitle) Then
                MessageBox.Show("Title cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Validate inputs
            If String.IsNullOrWhiteSpace(annDetails) Then
                MessageBox.Show("Details cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Raise the NoteAdded event
            RaiseEvent AnnAdded(annTitle, annDetails, author, dateAdded)
            MessageBox.Show("Announcement Saved", "Announcement")
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
