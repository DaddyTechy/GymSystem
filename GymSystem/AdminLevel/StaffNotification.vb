Imports MySql.Data.MySqlClient

Public Class StaffNotification
    Inherits UserControl

    Public Event NotificationsUpdated As EventHandler

    Private Sub StaffNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotifications()
    End Sub

    Private Sub LoadNotifications()
        Try
            ' Create new connection and command objects
            Using newConn As New MySqlConnection(modDB.strConnection)
                Using cmd As New MySqlCommand()
                    cmd.Connection = newConn
                    cmd.CommandText = "SELECT r.*, m.FirstName, m.LastName FROM reservation r " &
                                      "JOIN members m ON r.MemberID = m.MemberID " &
                                      "WHERE r.StaffID = @StaffID " &
                                      "AND r.ReservationStatus = 'Ongoing' " &
                                      "AND r.ReservationDate >= CURDATE() " &
                                      "ORDER BY r.ReservationDate ASC"
                    cmd.Parameters.AddWithValue("@StaffID", CurrentLoggedUser.id)

                    newConn.Open()

                    Dim dt As New DataTable()
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    ' Clear existing controls
                    Me.Controls.Clear()

                    ' Create main layout panel
                    Dim mainLayout As New TableLayoutPanel()
                    mainLayout.Dock = DockStyle.Fill
                    mainLayout.ColumnCount = 1
                    mainLayout.RowCount = 2
                    mainLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 60)) ' Header row
                    mainLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F)) ' Content row
                    Me.Controls.Add(mainLayout)

                    ' Create and add header
                    Dim headerPanel As New Panel()
                    headerPanel.Dock = DockStyle.Fill
                    headerPanel.BackColor = Color.FromArgb(33, 33, 33) ' Dark header
                    headerPanel.Padding = New Padding(20, 10, 20, 10)

                    Dim headerLabel As New Label()
                    headerLabel.Text = "Notifications"
                    headerLabel.Font = New Font("Segoe UI", 18, FontStyle.Bold)
                    headerLabel.ForeColor = Color.White
                    headerLabel.Dock = DockStyle.Fill
                    headerLabel.TextAlign = ContentAlignment.MiddleLeft

                    headerPanel.Controls.Add(headerLabel)
                    mainLayout.Controls.Add(headerPanel, 0, 0)

                    ' Create container for cards
                    Dim cardsContainerPanel As New Panel()
                    cardsContainerPanel.Dock = DockStyle.Fill
                    cardsContainerPanel.AutoScroll = True
                    cardsContainerPanel.Padding = New Padding(20)
                    cardsContainerPanel.BackColor = Color.FromArgb(240, 240, 240) ' Light gray background
                    mainLayout.Controls.Add(cardsContainerPanel, 0, 1)

                    If dt.Rows.Count > 0 Then
                        ' Add notification items
                        For Each row As DataRow In dt.Rows
                            ' Create main notification panel (card)
                            Dim cardPanel As New Panel()
                            cardPanel.Dock = DockStyle.Top
                            cardPanel.Height = 100
                            cardPanel.Margin = New Padding(0, 0, 0, 15) ' Space between cards
                            cardPanel.BackColor = Color.White
                            cardPanel.BorderStyle = BorderStyle.None ' Use padding and margin for separation
                            cardPanel.Padding = New Padding(20)

                            ' Create content layout
                            Dim layoutPanel As New TableLayoutPanel()
                            layoutPanel.Dock = DockStyle.Fill
                            layoutPanel.ColumnCount = 2
                            layoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75.0F))
                            layoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
                            layoutPanel.RowCount = 2
                            layoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
                            layoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))

                            ' Add member name
                            Dim nameLabel As New Label()
                            nameLabel.Text = row("FirstName") & " " & row("LastName")
                            nameLabel.Font = New Font("Segoe UI", 14, FontStyle.Bold)
                            nameLabel.ForeColor = Color.FromArgb(33, 33, 33)
                            nameLabel.Dock = DockStyle.Fill
                            nameLabel.TextAlign = ContentAlignment.MiddleLeft

                            ' Add date and time
                            Dim dateLabel As New Label()
                            dateLabel.Text = String.Format("{0:MMMM dd, yyyy} at {1} to {2}", row("ReservationDate"), row("StartTime"), row("EndTime"))
                            dateLabel.Font = New Font("Segoe UI", 10)
                            dateLabel.ForeColor = Color.FromArgb(102, 102, 102)
                            dateLabel.Dock = DockStyle.Fill
                            dateLabel.TextAlign = ContentAlignment.MiddleLeft

                            ' Add confirm button
                            Dim confirmBtn As New Button()
                            confirmBtn.Text = "Confirm"
                            confirmBtn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                            confirmBtn.Tag = row("ReservationID")
                            confirmBtn.BackColor = Color.FromArgb(255, 204, 0) ' Gold
                            confirmBtn.ForeColor = Color.White
                            confirmBtn.FlatStyle = FlatStyle.Flat
                            confirmBtn.FlatAppearance.BorderSize = 0
                            confirmBtn.Size = New Size(100, 30)
                            confirmBtn.Cursor = Cursors.Hand
                            confirmBtn.Anchor = AnchorStyles.Right
                            AddHandler confirmBtn.Click, AddressOf MarkAsRead_Click

                            ' Add hover effect for the button
                            AddHandler confirmBtn.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                                  confirmBtn.BackColor = Color.FromArgb(255, 193, 7) ' Darker Gold
                                                              End Sub
                            AddHandler confirmBtn.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                                  confirmBtn.BackColor = Color.FromArgb(255, 204, 0) ' Gold
                                                              End Sub

                            ' Add controls to layout
                            layoutPanel.Controls.Add(nameLabel, 0, 0)
                            layoutPanel.Controls.Add(dateLabel, 0, 1)
                            layoutPanel.Controls.Add(confirmBtn, 1, 0)
                            layoutPanel.SetRowSpan(confirmBtn, 2) ' Make button span two rows

                            ' Add layout to card panel
                            cardPanel.Controls.Add(layoutPanel)

                            ' Add card panel to container
                            cardsContainerPanel.Controls.Add(cardPanel)
                        Next
                    Else
                        ' Display a message when there are no notifications
                        Dim noNotificationsLabel As New Label()
                        noNotificationsLabel.Text = "You have no new notifications."
                        noNotificationsLabel.Font = New Font("Segoe UI", 14)
                        noNotificationsLabel.ForeColor = Color.Gray
                        noNotificationsLabel.Dock = DockStyle.Fill
                        noNotificationsLabel.TextAlign = ContentAlignment.MiddleCenter
                        cardsContainerPanel.Controls.Add(noNotificationsLabel)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading notifications: " & ex.Message)
        End Try
    End Sub

    Private Sub MarkAsRead_Click(sender As Object, e As EventArgs)
        Try
            Dim reservationId As Integer = CType(CType(sender, Button).Tag, Integer)

            Using newConn As New MySqlConnection(modDB.strConnection)
                Using cmd As New MySqlCommand()
                    cmd.Connection = newConn
                    cmd.CommandText = "UPDATE reservation SET ReservationStatus = 'Confirmed' WHERE ReservationID = @ReservationID"
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId)

                    newConn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Reservation confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadNotifications() ' Refresh the list

            ' Raise the event to notify the parent form that the count has changed
            RaiseEvent NotificationsUpdated(Me, EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("Error confirming reservation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
