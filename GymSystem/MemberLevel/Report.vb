Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Report

    Private Sub FetchMembershipData()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = $"SELECT MembershipID, MembershipType, Duration, Cost, StartDate FROM membership WHERE MemberID = {CurrentLoggedUser.id}"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblMembershipID.Text = reader("MembershipID").ToString()
                            lblServiceTaken.Text = reader("MembershipType").ToString()
                            lblPlanDuration.Text = reader("Duration").ToString()
                            lblPlanCost.Text = reader("Cost").ToString()
                            lblMemberSince.Text = "Member Since: " & Convert.ToDateTime(reader("StartDate")).ToString("yyyy-MM-dd")
                        lblLastPaymentDone.Text = $"Last Payment Done: Php {reader("Cost").ToString()}"
                    End If
                    End Using
                End Using
            End Using
        End Sub

        ' Fetch attendance count from the attendance table and update label
        Private Sub FetchAttendanceCount()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = $"SELECT COUNT(*) AS AttendanceCount FROM attendance WHERE MemberID = {CurrentLoggedUser.id}"
                Using cmd As New MySqlCommand(query, conn)
                lblAttendanceCount.Text = cmd.ExecuteScalar().ToString() & " day/s"
            End Using
            End Using
        End Sub

        ' Fetch membership status from the members table and update label
        Private Sub FetchMembershipStatus()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = $"SELECT Status FROM members WHERE MemberID = {CurrentLoggedUser.id}"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim status As Integer = Convert.ToInt32(reader("Status"))
                            lblMembershipStatus.Text = If(status = 1, "Active", "Inactive")
                        End If
                    End Using
                End Using
            End Using
        End Sub


    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchMembershipData()
        FetchAttendanceCount()
    End Sub


    Private PrintDialog1 As New PrintDialog()
    ' Add a PrintPreviewDialog control to your form
    Private PrintPreviewDialog1 As New PrintPreviewDialog()

    ' Button click event to print the panel
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Set the page settings
        Dim pageSettings As New PageSettings()
        pageSettings.Landscape = True ' Set to landscape orientation
        pageSettings.Margins = New Margins(50, 50, 50, 50) ' Set margins (left, right, top, bottom)

        PrintDocument1.DefaultPageSettings = pageSettings

        ' Show the PrintPreviewDialog
        PrintPreviewDialog1.Document = PrintDocument1
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            ' Show the PrintDialog
            PrintDialog1.Document = PrintDocument1
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    ' Panel1 Paint event handler
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Custom painting code for the panel (if any)
    End Sub

    ' PrintDocument1 PrintPage event handler
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create a bitmap of the panel
        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))

        ' Calculate the scaling factor to fit the panel within the printable area
        Dim scaleFactor As Single = Math.Min(e.MarginBounds.Width / bmp.Width, e.MarginBounds.Height / bmp.Height)

        ' Calculate the scaled width and height
        Dim scaledWidth As Integer = CInt(bmp.Width * scaleFactor)
        Dim scaledHeight As Integer = CInt(bmp.Height * scaleFactor)

        ' Draw the bitmap on the PrintPage event, scaled to fit within the margins
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top, scaledWidth, scaledHeight)
    End Sub

End Class
