Imports MySql.Data.MySqlClient
Imports System.Linq

Public Class MembershipHistoryForm

    Private Structure MembershipInfo
        Public Property MembershipType As String
        Public Property Duration As String
        Public Property Benefits As String
        Public Property PurchaseDate As Date
    End Structure

    Private memberId As Integer

    Public Sub New(ByVal memberId As Integer)
        InitializeComponent()
        Me.memberId = memberId
    End Sub

    Private Sub MembershipHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembershipHistory()
    End Sub

    Private Sub LoadMembershipHistory()
        Dim memberships As New List(Of MembershipInfo)

        Using conn As New MySqlConnection(modDB.strConnection)
            Try
                conn.Open()
                Dim query As String = "SELECT MembershipType, Duration, Benefits, StartDate FROM membership WHERE MemberID = @MemberID ORDER BY StartDate DESC"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MemberID", memberId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        memberships.Add(New MembershipInfo With {
                            .MembershipType = reader.GetString("MembershipType"),
                            .Duration = reader.GetString("Duration"),
                            .Benefits = reader.GetString("Benefits"),
                            .PurchaseDate = reader.GetDateTime("StartDate")
                        })
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading membership history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        flpMembershipHistory.Controls.Clear()

        If memberships.Any() Then
            ' Calculate and display summary
            Dim totalMonths = memberships.Sum(Function(m) ParseDurationToMonths(m.Duration))
            Dim totalDurationStr = FormatDuration(totalMonths)
            CreateSummaryPanel(totalDurationStr)

            ' Display individual membership list
            For Each membershipItem In memberships
                CreateIndividualMembershipPanel(membershipItem)
            Next
        Else
            Dim noHistoryLabel As New Label With {
                .Text = "No membership history found.",
                .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                .ForeColor = Color.White,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Dock = DockStyle.Fill
            }
            flpMembershipHistory.Controls.Add(noHistoryLabel)
        End If
    End Sub

    Private Sub CreateSummaryPanel(totalDuration As String)
        Dim summaryPanel As New Panel With {
            .Width = flpMembershipHistory.ClientSize.Width - 25,
            .Height = 80, ' Adjusted height for summary
            .BackColor = Color.FromArgb(35, 35, 35), ' Slightly different color for distinction
            .Margin = New Padding(5)
        }

        Dim titleLabel As New Label With {
            .Text = "Membership Summary",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.Gold,
            .Dock = DockStyle.Top,
            .Padding = New Padding(10)
        }

        Dim durationLabel As New Label With {
            .Text = $"Total Combined Duration: {totalDuration}",
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .ForeColor = Color.White,
            .Dock = DockStyle.Fill,
            .Padding = New Padding(10, 0, 10, 10)
        }

        summaryPanel.Controls.Add(durationLabel)
        summaryPanel.Controls.Add(titleLabel)
        flpMembershipHistory.Controls.Add(summaryPanel)
    End Sub

    Private Sub CreateIndividualMembershipPanel(membership As MembershipInfo)
        Dim itemPanel As New Panel With {
            .Width = flpMembershipHistory.ClientSize.Width - 25,
            .Height = 120,
            .BackColor = Color.FromArgb(45, 45, 45),
            .Margin = New Padding(5)
        }

        Dim titleLabel As New Label With {
            .Text = $"{membership.MembershipType} Plan",
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.Gold,
            .Dock = DockStyle.Top,
            .Padding = New Padding(10)
        }

        Dim purchaseDateLabel As New Label With {
            .Text = $"Purchased On: {membership.PurchaseDate:dd/MM/yyyy}",
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .ForeColor = Color.White,
            .Dock = DockStyle.Top,
            .Padding = New Padding(10, 0, 10, 5)
        }

        Dim durationLabel As New Label With {
            .Text = $"Duration: {membership.Duration}",
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .ForeColor = Color.White,
            .Dock = DockStyle.Top,
            .Padding = New Padding(10, 0, 10, 5)
        }

        Dim benefitsLabel As New Label With {
            .Text = $"Benefits: {membership.Benefits}",
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .ForeColor = Color.White,
            .Dock = DockStyle.Fill,
            .Padding = New Padding(10, 0, 10, 10)
        }

        itemPanel.Controls.Add(benefitsLabel)
        itemPanel.Controls.Add(durationLabel)
        itemPanel.Controls.Add(purchaseDateLabel)
        itemPanel.Controls.Add(titleLabel)

        flpMembershipHistory.Controls.Add(itemPanel)
    End Sub

    Private Function ParseDurationToMonths(duration As String) As Integer
        Dim parts = duration.Split(" "c)
        If parts.Length <> 2 Then Return 0

        Dim value As Integer
        If Not Integer.TryParse(parts(0), value) Then Return 0

        Select Case parts(1).ToLower()
            Case "month", "months"
                Return value
            Case "year", "years", "yr"
                Return value * 12
            Case Else
                Return 0
        End Select
    End Function

    Private Function FormatDuration(totalMonths As Integer) As String
        If totalMonths = 0 Then Return "N/A"

        Dim years = totalMonths \ 12
        Dim months = totalMonths Mod 12

        Dim parts As New List(Of String)
        If years > 0 Then
            parts.Add($"{years} year{(If(years > 1, "s", ""))}")
        End If
        If months > 0 Then
            parts.Add($"{months} month{(If(months > 1, "s", ""))}")
        End If

        Return String.Join(" and ", parts)
    End Function
End Class
