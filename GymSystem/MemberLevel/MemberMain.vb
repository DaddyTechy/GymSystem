Imports MySql.Data.MySqlClient

Public Class MemberMain
    Private Sub SchedBtn_Click(sender As Object, e As EventArgs) Handles SchedBtn.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim sched As New Sched With {.Top = False, .AutoSize = True}
        sched.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(sched)
        sched.Show()

    End Sub

    Private Sub Reminder_Click(sender As Object, e As EventArgs) Handles Reminder.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim Remind As New Reminder With {.Top = False, .AutoSize = True}
        Remind.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(Remind)
        Remind.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim reports As New Report With {.Top = False, .AutoSize = True}
        reports.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(reports)
        reports.Show()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While

        Dim memberId As Integer = CurrentLoggedUser.id ' Replace with your method to get the current logged user ID
        Debug.WriteLine("Current logged user ID: " & memberId)
        Dim memberData As MemberData = GetMemberData(memberId)

        Dim reports As New memberProfileControl With {.Top = False, .AutoSize = True}
        reports.Dock = DockStyle.Fill
        reports.LoadMemberData(memberData) ' Load the fetched data into the control
        Me.ContentPanel.Controls.Add(reports)
        reports.Label1.Text = "Member: "
        reports.Show()
        Debug.WriteLine("Member profile control loaded with data.")
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the parent form to ensure AdminMain UserControl is closed
            Dim parentForm = FindForm()

            If parentForm IsNot Nothing Then
                parentForm.Close()
            End If

            ' Navigate back to Admin login form
            Dim backtoAdminLogin As New Member
            backtoAdminLogin.Show()
        End If
    End Sub

    Private Function GetMemberData(memberId As Integer) As MemberData
        UpdateConnectionString()
        Dim conn As New MySqlConnection(strConnection)
        Dim memberData As New MemberData()
        Try
            conn.Open()
            Debug.WriteLine("Connection opened successfully.")

            ' Retrieve data from members table
            Dim queryMembers As String = "SELECT MemberID, FirstName, MiddleName, LastName, Sex, PhoneNumber, DTCreated, Status, Weight, Height, Email, DOB FROM members WHERE MemberID = @MemberID"
            Dim cmdMembers As New MySqlCommand(queryMembers, conn)
            cmdMembers.Parameters.AddWithValue("@MemberID", memberId)
            Dim readerMembers As MySqlDataReader = cmdMembers.ExecuteReader()
            If readerMembers.Read() Then
                memberData.MemberID = CInt(readerMembers("MemberID"))
                memberData.FirstName = readerMembers("FirstName").ToString()
                memberData.MiddleName = readerMembers("MiddleName").ToString()
                memberData.LastName = readerMembers("LastName").ToString()
                memberData.Sex = readerMembers("Sex").ToString()
                memberData.PhoneNumber = readerMembers("PhoneNumber").ToString()
                memberData.DTCreated = DateTime.Parse(readerMembers("DTCreated").ToString())
                memberData.Status = readerMembers("Status").ToString()
                memberData.Weight = Decimal.Parse(readerMembers("Weight").ToString())
                memberData.Height = Decimal.Parse(readerMembers("Height").ToString())
                memberData.Email = readerMembers("Email").ToString()
                memberData.DOB = DateTime.Parse(readerMembers("DOB").ToString())
                Debug.WriteLine("Member data fetched successfully from members table.")
            Else
                Debug.WriteLine("No data found in members table for MemberID: " & memberId)
            End If
            readerMembers.Close()

            ' Retrieve data from memberlogin table
            Dim queryLogin As String = "SELECT Username FROM memberlogin WHERE MemberID = @MemberID"
            Dim cmdLogin As New MySqlCommand(queryLogin, conn)
            cmdLogin.Parameters.AddWithValue("@MemberID", memberId)
            Dim readerLogin As MySqlDataReader = cmdLogin.ExecuteReader()
            If readerLogin.Read() Then
                memberData.Username = readerLogin("Username").ToString()
                Debug.WriteLine("Member data fetched successfully from memberlogin table.")
            Else
                Debug.WriteLine("No data found in memberlogin table for MemberID: " & memberId)
            End If
            readerLogin.Close()

            ' Retrieve data from membership table
            Dim queryMembership As String = "SELECT Cost, MembershipType, Duration, StartDate, EndDate, RenewalPolicy, Benefits, MemberShipName FROM membership WHERE MemberID = @MemberID"
            Dim cmdMembership As New MySqlCommand(queryMembership, conn)
            cmdMembership.Parameters.AddWithValue("@MemberID", memberId)
            Dim readerMembership As MySqlDataReader = cmdMembership.ExecuteReader()
            If readerMembership.Read() Then
                memberData.Cost = Decimal.Parse(readerMembership("Cost").ToString())
                memberData.MembershipType = readerMembership("MembershipType").ToString()
                memberData.Duration = readerMembership("Duration").ToString()
                memberData.StartDate = DateTime.Parse(readerMembership("StartDate").ToString())
                memberData.EndDate = DateTime.Parse(readerMembership("EndDate").ToString())
                memberData.RenewalPolicy = readerMembership("RenewalPolicy").ToString()
                memberData.Benefits = readerMembership("Benefits").ToString()
                memberData.MemberShipName = readerMembership("MemberShipName").ToString()
                Debug.WriteLine("Member data fetched successfully from membership table.")
            Else
                Debug.WriteLine("No data found in membership table for MemberID: " & memberId)
            End If
            readerMembership.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Debug.WriteLine("Error: " & ex.Message)
        Finally
            conn.Close()
            Debug.WriteLine("Connection closed.")
        End Try

        Return memberData
    End Function

    Private Sub btnAnnouncement_Click(sender As Object, e As EventArgs) Handles btnAnnouncement.Click
        While Me.ContentPanel.Controls.Count > 0
            Me.ContentPanel.Controls(0).Dispose()
        End While


        Dim Remind As New Announcements With {.Top = False, .AutoSize = True}
        Remind.Dock = DockStyle.Fill
        Me.ContentPanel.Controls.Add(Remind)
        Remind.Show()
    End Sub
End Class

