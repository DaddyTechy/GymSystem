Imports MySql.Data.MySqlClient
Public Class AddAnnouncement
    Public Event AnnouncementSaved()
    Private isEditMode As Boolean = False
    Private announcementID As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Add Announcement"
        btnSaveAnn.Text = "Save"
    End Sub

    Public Sub New(announcementID As Integer)
        MyBase.New()
        InitializeComponent()
        Me.Text = "Edit Announcement"
        btnSaveAnn.Text = "Update"
        isEditMode = True
        Me.announcementID = announcementID
        LoadAnnouncementDetails()
    End Sub

    Private Sub LoadAnnouncementDetails()
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT Title, Content, DatePosted, PostedBy FROM announcement WHERE AnnouncementID = @AnnouncementID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@AnnouncementID", announcementID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtAnnTitle.Text = reader("Title").ToString()
                            txtAnnDetails.Text = reader("Content").ToString()
                            dtpDateAdded.Value = Convert.ToDateTime(reader("DatePosted"))
                            txtAuthor.Text = reader("PostedBy").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the announcement: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveAnn.Click
        Dim annTitle As String = txtAnnTitle.Text
        Dim annDetails As String = txtAnnDetails.Text
        Dim author As String = $"{CurrentLoggedUser.position} {CurrentLoggedUser.name}"
        Dim dateAdded As DateTime = dtpDateAdded.Value

        If String.IsNullOrWhiteSpace(annTitle) OrElse String.IsNullOrWhiteSpace(annDetails) Then
            MessageBox.Show("Title and details cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String
                If isEditMode Then
                    query = "UPDATE announcement SET Title = @Title, Content = @Content, DatePosted = @DatePosted WHERE AnnouncementID = @AnnouncementID"
                Else
                    query = "INSERT INTO announcement (Title, Content, DatePosted, PostedBy) VALUES (@Title, @Content, @DatePosted, @PostedBy)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Title", annTitle)
                    cmd.Parameters.AddWithValue("@Content", annDetails)
                    cmd.Parameters.AddWithValue("@DatePosted", dateAdded)
                    If isEditMode Then
                        cmd.Parameters.AddWithValue("@AnnouncementID", announcementID)
                    Else
                        cmd.Parameters.AddWithValue("@PostedBy", author)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            RaiseEvent AnnouncementSaved()
            MessageBox.Show(If(isEditMode, "Announcement updated successfully.", "Announcement added successfully."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ParentForm.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ParentForm.Close()
    End Sub

    Private Sub AddAnnouncement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.ParentForm IsNot Nothing Then
            Me.ParentForm.Size = New Size(309, 385)
        End If

        dtpDateAdded.Enabled = False
        txtAuthor.ReadOnly = True

        If Not isEditMode Then
            dtpDateAdded.Value = DateTime.Now
            txtAuthor.Text = $"{CurrentLoggedUser.position} {CurrentLoggedUser.name}"
        End If
    End Sub
End Class
