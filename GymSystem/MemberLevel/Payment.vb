Public Class Payment



    ' Assuming you have a member object to represent the logged-in member
    ' Example: This should ideally be fetched from a database or data source
    Private members As New Member With {
        .Service = "Premium Membership",
        .ExpiryDate = New DateTime(2024, 12, 30) ' Example expiry date
    }
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fetch and update the member details
        UpdateMemberDetails()
    End Sub

    Private Sub UpdateMemberDetails()
        ' Update the service label
        lblService.Text = $"Service: {members.Service}"

        ' Calculate and update the status (days remaining)
        Dim currentStatus As String = CalculateDaysRemaining(members.ExpiryDate)
        lblStatus.Text = $"Status: {currentStatus} days remaining"
    End Sub

    ' Calculate the days remaining until membership expires
    Private Function CalculateDaysRemaining(expiryDate As DateTime) As String
        ' Calculate the number of days remaining
        Dim daysRemaining As Integer = (expiryDate - DateTime.Today).Days

        ' Ensure that days remaining doesn't go negative
        If daysRemaining < 0 Then
            daysRemaining = 0
        End If

        ' Return the number of days remaining
        Return daysRemaining.ToString()
    End Function

    ' Example member class to represent the member's details
    Public Class Member
        Public Property Service As String
        Public Property ExpiryDate As DateTime
    End Class

    Private Sub UpdateCurrentPlan()
        ' Sample logic to get the current plan duration in months
        Dim planDuration As Integer = 2 ' Example value for the plan duration (2 months)

        ' Update the label text
        lblCurrentP.Text = $"Current Plan: {planDuration} months"
    End Sub

End Class
