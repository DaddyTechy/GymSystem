Imports MySql.Data.MySqlClient

Public Class StaffNotification
    Inherits UserControl

    Private Sub StaffNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotifications()
    End Sub

    Private Sub LoadNotifications()
        Try
            ' Create new connection and command objects
            Using newConn As New MySqlConnection(modDB.strConnection)
                Using cmd As New MySqlCommand()
                    cmd.Connection = newConn
                    cmd.CommandText = "SELECT r.*, m.FirstName, m.LastName FROM reservation r 
                                      JOIN members m ON r.MemberID = m.MemberID 
                                      WHERE r.StaffID = @StaffID 
                                      AND r.ReservationStatus = 'Ongoing'
                                      AND r.ReservationDate >= CURDATE()
                                      ORDER BY r.ReservationDate ASC"
                    cmd.Parameters.AddWithValue("@StaffID", CurrentLoggedUser.id)

                    newConn.Open()

                    Dim dt As New DataTable()
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    ' Clear existing controls
                    Me.Controls.Clear()

                    ' Add header
                    Dim headerPanel As New Panel()
                    headerPanel.Dock = DockStyle.Top
                    headerPanel.Height = 50
                    headerPanel.BackColor = Color.Black

                    Dim headerLabel As New Label()
                    headerLabel.Text = "Notifications"
                    headerLabel.Font = New Font("Segoe UI", 16, FontStyle.Bold)
                    headerLabel.ForeColor = Color.White
                    headerLabel.Dock = DockStyle.Fill
                    headerLabel.TextAlign = ContentAlignment.MiddleCenter

                    headerPanel.Controls.Add(headerLabel)
                    Me.Controls.Add(headerPanel)

                    ' Add table headers
                    Dim headerRow As New Panel()
                    headerRow.Dock = DockStyle.Top
                    headerRow.Height = 30
                    headerRow.BackColor = Color.FromArgb(240, 240, 240)

                    Dim headerName As New Label()
                    headerName.Text = "Member Name"
                    headerName.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    headerName.Dock = DockStyle.Left
                    headerName.Width = 200
                    headerName.TextAlign = ContentAlignment.MiddleCenter
                    headerName.Padding = New Padding(10, 0, 0, 0)

                    Dim headerDate As New Label()
                    headerDate.Text = "Date & Time"
                    headerDate.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    headerDate.Dock = DockStyle.Left
                    headerDate.Width = 200
                    headerDate.TextAlign = ContentAlignment.MiddleCenter
                    headerDate.Padding = New Padding(10, 0, 0, 0)

                    headerRow.Controls.Add(headerName)
                    headerRow.Controls.Add(headerDate)
                    Me.Controls.Add(headerRow)

                    ' Add notification items
                    Dim rowCounter As Integer = 0
                    For Each row As DataRow In dt.Rows
                        Dim notificationPanel As New Panel()
                        notificationPanel.Dock = DockStyle.Top
                        notificationPanel.Height = 40
                        notificationPanel.Margin = New Padding(0, 5, 0, 0)
                        notificationPanel.BackColor = If(rowCounter Mod 2 = 0, Color.White, Color.FromArgb(245, 245, 245))

                        Dim nameLabel As New Label()
                        nameLabel.Text = row("FirstName") & " " & row("LastName")
                        nameLabel.Font = New Font("Segoe UI", 11)
                        nameLabel.Dock = DockStyle.Left
                        nameLabel.Width = 200
                        nameLabel.TextAlign = ContentAlignment.MiddleLeft
                        nameLabel.Padding = New Padding(10, 0, 0, 0)

                        Dim dateLabel As New Label()
                        dateLabel.Text = String.Format("{0:yyyy-MM-dd} - {1} to {2}", row("ReservationDate"), row("StartTime"), row("EndTime"))
                        dateLabel.Font = New Font("Segoe UI", 11)
                        dateLabel.Dock = DockStyle.Left
                        dateLabel.Width = 200
                        dateLabel.TextAlign = ContentAlignment.MiddleLeft
                        dateLabel.Padding = New Padding(10, 0, 0, 0)

                        Dim markAsReadBtn As New Button()
                        markAsReadBtn.Text = "Mark as Read"
                        markAsReadBtn.Dock = DockStyle.Right
                        markAsReadBtn.Width = 120
                        markAsReadBtn.Height = 30
                        markAsReadBtn.Font = New Font("Segoe UI", 9)
                        markAsReadBtn.Tag = row("ReservationID")
                        AddHandler markAsReadBtn.Click, AddressOf MarkAsRead_Click

                        notificationPanel.Controls.Add(nameLabel)
                        notificationPanel.Controls.Add(dateLabel)
                        notificationPanel.Controls.Add(markAsReadBtn)
                        Me.Controls.Add(notificationPanel)
                        rowCounter += 1
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading notifications: " & ex.Message)
        End Try
    End Sub

    Private Sub MarkAsRead_Click(sender As Object, e As EventArgs)
        Try
            Using newConn As New MySqlConnection(modDB.strConnection)
                Using cmd As New MySqlCommand()
                    cmd.Connection = newConn
                    cmd.CommandText = "UPDATE reservation 
                                      SET ReservationStatus = 'Read' 
                                      WHERE ReservationID = @ReservationID"
                    cmd.Parameters.AddWithValue("@ReservationID", CType(sender, Button).Tag)

                    newConn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadNotifications() ' Refresh the list
        Catch ex As Exception
            MessageBox.Show("Error marking as read: " & ex.Message)
        End Try
    End Sub
End Class
