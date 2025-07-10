Imports MySql.Data.MySqlClient

Public Class NewMembershipForm
    Private memberID As Integer

    ' Add a property to store the selected plan
    Public Property SelectedPlan As String

    Public Sub New(memberID As Integer)
        InitializeComponent()
        Me.memberID = memberID
    End Sub

    Private Sub NewMembershipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the Plans ComboBox with membership plans
        PlansCB.Items.Add("Bronze (3 months)")
        PlansCB.Items.Add("Silver (6 months)")
        PlansCB.Items.Add("Gold (9 months)")
        PlansCB.Items.Add("Diamond (12 months)")
    End Sub


    Private Function ValidateInput() As Boolean
        ' Check if a plan is selected
        If PlansCB.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a membership plan.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Check if a service is selected
        If ServiceCB.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Additional validation checks can be added here

        ' If all checks pass, return True
        Return True
    End Function


    Private paymentCompleted As Boolean = False

    Private Sub AskPaymentOption(memberID As Integer, fee As Decimal, isMembership As Boolean)
        Dim result As DialogResult = MessageBox.Show("Would you like to pay for the membership now?", "Payment Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Handle immediate payment
            HandleImmediatePayment(memberID, fee, isMembership)

            Dim accountDetails As String = $"Details added successfully.{Environment.NewLine}Username: {memberID}{Environment.NewLine}Use this as Your UserName/UserID for login."
            Dim accountDetailsForm As New AccountDetailsForm(accountDetails)
            accountDetailsForm.ShowDialog()
        Else
            ' Handle later payment
            HandleLaterPayment(memberID)
            CloseForm() ' Separate method to close and return to admin login
        End If

        ' Check the payment status and close the form if the payment is completed
        If paymentCompleted Then
            CloseForm() ' Separate method to close and return to admin login
        End If
    End Sub

    Private Sub CloseForm()
        Me.Close()
        Dim backtoAdminLogin As New Member
        backtoAdminLogin.Show()
    End Sub

    Private Function CheckPaymentStatus(memberID As Integer) As Boolean
        Dim paymentExists As Boolean = False

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim query As String = $"SELECT COUNT(*) FROM payment WHERE MemberID = {memberID} AND PaymentStatus = 'Paid'"
            Using cmd As New MySqlCommand(query, conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    paymentExists = True
                End If
            End Using
        End Using

        MessageBox.Show($"Payment Made:{paymentExists}")
        Return paymentExists
    End Function

    Private Sub HandleImmediatePayment(memberID As Integer, fee As Decimal, isMembership As Boolean)
        ' Create a new payment record if it's a new payment
        Dim newPaymentID As Integer = CreateNewPayment(memberID)
        Debug.WriteLine("Latest MembershipID11: " & newPaymentID)

        ' Create a new instance of the BillingPaymentForm with the necessary data
        Dim paymentForm As New BillingPaymentForm(fee, isMembership, newPaymentID, memberID)

        ' Subscribe to the PaymentCompleted event
        AddHandler paymentForm.PaymentCompleted, AddressOf OnPaymentCompleted

        ' Calculate the center point
        Dim centerX As Integer = (ClientSize.Width - paymentForm.Width) / 2
        Dim centerY As Integer = (ClientSize.Height - paymentForm.Height) / 2

        ' Set the location of the BillingPaymentForm to the center
        paymentForm.Location = New Point(centerX, centerY)

        ' Add the BillingPaymentForm to the form
        Controls.Add(paymentForm)
        paymentForm.BringToFront()

        Debug.WriteLine("Debug: BillingPaymentForm user control added.")
        Debug.WriteLine($"Debug: Form Amount = {paymentForm.txtAmount.Text}, SubTotal = {paymentForm.txtSubTotal.Text}")
    End Sub

    Private Sub OnPaymentCompleted(sender As Object, e As EventArgs)
        ' Set the paymentCompleted flag to True
        paymentCompleted = True
        ' Close the form and return to admin login
        CloseForm()
    End Sub

    Private Function CreateNewPayment(memberID As Integer) As Integer
        Dim newPaymentID As Integer = 0
        Dim fee As Decimal = 0
        Dim latestMembershipID As Integer = 0

        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            ' Fetch the Cost and latest MembershipID from the membership table
            Dim query As String = $"SELECT Cost, MembershipID FROM membership WHERE MemberID = {memberID} ORDER BY MembershipID DESC LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    fee = Convert.ToDecimal(reader("Cost"))
                    latestMembershipID = Convert.ToInt32(reader("MembershipID"))
                    Debug.WriteLine("Cost: " & fee)
                    Debug.WriteLine("Latest MembershipID: " & latestMembershipID)
                End If
                reader.Close()
            End Using

            ' Insert a new payment record
            Dim insertQuery As String = $"INSERT INTO payment (MemberID, MembershipCost, Amount, PaymentStatus, PaymentMethod, PaymentDate, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, MembershipID) " &
                                    $"VALUES ({memberID}, {fee}, {fee}, 'Unpaid', 'N/A', '{DateTime.MinValue:yyyy-MM-dd}', 'N/A', 'N/A', 0, 0, 0, 'N/A', {latestMembershipID})"
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.ExecuteNonQuery()
            End Using

            ' Retrieve the last inserted PaymentID
            Dim queryLastInsertID As String = "SELECT LAST_INSERT_ID()"
            Using cmdLastInsertID As New MySqlCommand(queryLastInsertID, conn)
                newPaymentID = Convert.ToInt32(cmdLastInsertID.ExecuteScalar())
                Debug.WriteLine("New PaymentID: " & newPaymentID)
            End Using
        End Using

        Return newPaymentID
    End Function



    Private Sub HandleLaterPayment(memberID As Integer)
        ' Custom logic for handling later payment
        CreateNewPayment(memberID)
        MessageBox.Show("You can pay later. Remember to complete your payment before the due date.", "Payment Deferred", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetNewPaymentID() As Integer
        ' Implement the logic to get the new payment ID
        ' Example:
        Using conn As New MySqlConnection(strConnection)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT MAX(PaymentID) + 1 FROM payment", conn)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub SubmitBtn_Click_1(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If Not ValidateInput() Then
            Return
        End If

        ' Determine membership details based on membership name
        Dim membershipName = PlansCB.SelectedItem.ToString
        Dim duration As String
        Dim cost As Double
        Dim benefits As String
        Dim startDate = Date.Now
        Dim endDate As Date
        Dim discountAvailable As String
        Dim cancelationPolicy As String
        Dim renewalPolicy As String
        Dim trainingSession As Integer
        Dim lockerAccess As String

        Select Case membershipName
            Case "Diamond (12 months)"
                duration = "1 yr"
                cost = 1000.0
                benefits = "Full benefits"
                endDate = startDate.AddYears(1)
                discountAvailable = "Yes"
                cancelationPolicy = "Standard"
                renewalPolicy = "Auto-renew"
                trainingSession = 1
                lockerAccess = "Yes"
            Case "Gold (9 months)"
                duration = "9 months"
                cost = 600.0
                benefits = "Standard benefits"
                endDate = startDate.AddMonths(9)
                discountAvailable = "Yes"
                cancelationPolicy = "Standard"
                renewalPolicy = "Manual-renew"
                trainingSession = 1
                lockerAccess = "No"
            Case "Silver (6 months)"
                duration = "6 months"
                cost = 300.0
                benefits = "Limited benefits"
                endDate = startDate.AddMonths(6)
                discountAvailable = "No"
                cancelationPolicy = "Standard"
                renewalPolicy = "Manual-renew"
                trainingSession = 0
                lockerAccess = "No"
            Case Else
                duration = "3 month"
                cost = 100.0
                benefits = "Basic benefits"
                endDate = startDate.AddMonths(3)
                discountAvailable = "No"
                cancelationPolicy = "Flexible"
                renewalPolicy = "Manual-renew"
                trainingSession = 0
                lockerAccess = "No"
        End Select

        Debug.WriteLine($"Membership details - Name: {membershipName}, Duration: {duration}, Cost: {cost}, Benefits: {benefits}, StartDate: {startDate}, EndDate: {endDate}, DiscountAvailable: {discountAvailable}, CancelationPolicy: {cancelationPolicy}, RenewalPolicy: {renewalPolicy}, TrainingSession: {trainingSession}, LockerAccess: {lockerAccess}")

        ' Insert into membership table
        Using conn As New MySqlConnection(strConnection)
            conn.Open()

            Using transaction = conn.BeginTransaction
                Try
                    ' Update members table
                    Dim updateMembersQuery As String = "UPDATE members SET Status = 'Active' WHERE MemberID = @MemberID AND Status = 'Inactive'"
                    Dim cmdMembers As New MySqlCommand(updateMembersQuery, conn, transaction)
                    cmdMembers.Parameters.AddWithValue("@MemberID", memberID)
                    cmdMembers.ExecuteNonQuery()

                    ' Insert new membership record with Status
                    Dim insertMembershipQuery = "INSERT INTO `membership`(`MemberID`, `MemberShipName`, `Duration`, `Cost`, `Benefits`, `StartDate`, `EndDate`, `DiscountAvailable`, `CancelationPolicy`, `RenewalPolicy`, `TrainingSession`, `LockerAccess`, `MembershipType`, `Status`) " &
                                            "VALUES (" & memberID & ", '" & membershipName & "', '" & duration & "', " & cost & ", '" & benefits & "', '" & startDate.ToString("yyyy-MM-dd") & "', '" & endDate.ToString("yyyy-MM-dd") & "', '" & discountAvailable & "', '" & cancelationPolicy & "', '" & renewalPolicy & "', " & trainingSession & ", '" & lockerAccess & "', '" & ServiceCB.SelectedItem.ToString & "', 'Active')"
                    Debug.WriteLine($"Executing query: {insertMembershipQuery}")
                    Using insertMembershipCommand As New MySqlCommand(insertMembershipQuery, conn, transaction)
                        insertMembershipCommand.ExecuteNonQuery()
                    End Using

                    ' Commit the transaction
                    transaction.Commit()

                    ' Trigger the payment process
                    AskPaymentOption(memberID, cost, True)
                Catch ex As Exception
                    ' Rollback the transaction in case of an error
                    transaction.Rollback()
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub PlansCB_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles PlansCB.SelectedIndexChanged
        ' Clear any previous items in the services ComboBox
        ServiceCB.Items.Clear()

        ' Get the selected plan
        Dim selectedPlan = PlansCB.SelectedItem.ToString
        selectedPlan = selectedPlan ' Store the selected plan in the property

        ' Based on the selected plan, populate the Services ComboBox
        Select Case selectedPlan
            Case "Bronze (3 months)"
                ' Add services for Bronze plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")

            Case "Silver (6 months)"
                ' Add services for Silver plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")

            Case "Gold (9 months)"
                ' Add services for Gold plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")
                ServiceCB.Items.Add("Personal Training")

            Case "Diamond (12 months)"
                ' Add all services for Diamond plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")
                ServiceCB.Items.Add("Personal Training")
                ServiceCB.Items.Add("All Services")

            Case Else
                ' If no valid plan is selected
                MessageBox.Show("Please select a valid plan.")
        End Select
    End Sub
End Class
