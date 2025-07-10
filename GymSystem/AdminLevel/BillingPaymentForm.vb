Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq

Public Structure ReservationDetails
    Public MemberID As Integer
    Public EquipmentID As Integer
    Public StaffID As Integer
    Public ReservationDate As DateTime
    Public StartTime As DateTime
    Public EndTime As DateTime
    Public ReservationFee As Decimal
    Public ReservationNotes As String
    Public Purpose As String
End Structure

Public Class BillingPaymentForm
    Public Event PaymentAttemptCompleted As Action(Of DialogResult)
    Public Property isMembership As Boolean
    Public Property paymentID As Integer
    Public Property memberID As Integer
    Private _conn As MySqlConnection
    Private _transaction As MySqlTransaction
    Private _reservationDetails As ReservationDetails?

    ' Constructor that accepts necessary data
    Public Sub New(fee As Decimal, isMembership As Boolean, paymentID As Integer, memberID As Integer)
        InitializeComponent()
        txtAmount.Text = fee.ToString("F2")
        txtSubTotal.Text = fee.ToString("F2")
        Me.isMembership = isMembership
        Me.paymentID = paymentID
        Me.memberID = memberID
    End Sub

    ' New constructor for transactional registration
    Public Sub New(conn As MySqlConnection, transaction As MySqlTransaction, fee As Decimal, isMembership As Boolean, paymentID As Integer, memberID As Integer)
        Me.New(fee, isMembership, paymentID, memberID) ' Call the original constructor
        _conn = conn
        _transaction = transaction
    End Sub

    ' New constructor for transactional reservation
    Public Sub New(conn As MySqlConnection, transaction As MySqlTransaction, details As ReservationDetails)
        Me.New(details.ReservationFee, False, 0, details.MemberID) ' Call the original constructor
        _conn = conn
        _transaction = transaction
        _reservationDetails = details
    End Sub

    Private Sub BillingPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Auto-generate InvoiceNumber
        txtInvoiceNumber.Text = GenerateInvoiceNumber()
        txtReceiptNumber.Text = ""
        txtReceiptNumber.ReadOnly = True

        ' Auto-generate PaymentDate and make it read-only
        dtpPaymentDate.Value = DateTime.Now
        dtpPaymentDate.Enabled = False

        ' Calculate Tax Amount
        CalculateTaxAmount()

        ' Add items to cmbPaymentMethod
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("E-Wallet")

    End Sub

    Private Sub CalculateTaxAmount()
        Dim subTotal As Decimal = Decimal.Parse(txtSubTotal.Text)
        Dim taxRate As Decimal = 0.12 ' Example VAT rate of 12%
        txtTaxAmount.Text = (subTotal * taxRate).ToString("F2")
        CalculateTotalAmount()
    End Sub

    Private Sub CalculateTotalAmount()
        Dim subTotal As Decimal = Decimal.Parse(txtSubTotal.Text)
        Dim discountApplied As Decimal = If(String.IsNullOrEmpty(txtDiscountAmount.Text), 0, Decimal.Parse(txtDiscountAmount.Text))
        Dim taxAmount As Decimal = Decimal.Parse(txtTaxAmount.Text)
        Dim totalAmount As Decimal = subTotal - discountApplied + taxAmount
        txtTotalAmount.Text = totalAmount.ToString("F2")
    End Sub

    Private Sub chkDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscount.CheckedChanged
        txtDiscountAmount.Enabled = chkDiscount.Checked
        If Not chkDiscount.Checked Then
            txtDiscountAmount.Text = "0.00"
            txtDiscountTotal.Text = "0.00"
        End If
        CalculateTotalAmount()
    End Sub

    Private Sub txtDiscountAmount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountAmount.TextChanged
        ' Validate the discount amount
        Dim discountAmount As Decimal
        Dim totalAmount As Decimal

        If Decimal.TryParse(txtDiscountAmount.Text, discountAmount) AndAlso Decimal.TryParse(txtTotalAmount.Text, totalAmount) Then
            Dim maxDiscount As Decimal = totalAmount * 0.3D
            If discountAmount > maxDiscount Then
                MessageBox.Show($"Discount amount cannot exceed 30% of the total amount. Maximum allowed discount is {maxDiscount:C}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDiscountAmount.Text = maxDiscount.ToString("F2")
            End If
        End If

        CalculateTotalAmount()
    End Sub


    Private Sub txtDiscountAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountAmount.KeyPress
        ' Allow only digits, the decimal point, and control characters
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso txtDiscountAmount.Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiscountAmount_Leave(sender As Object, e As EventArgs) Handles txtDiscountAmount.Leave
        ' Format the text to a valid number
        Dim value As Decimal
        If Decimal.TryParse(txtDiscountAmount.Text, value) Then
            txtDiscountAmount.Text = value.ToString("F2")
            txtDiscountTotal.Text = value.ToString("F2")
        ElseIf txtDiscountAmount.Text <> String.Empty Then
            txtDiscountAmount.Text = "0.00"
            txtDiscountTotal.Text = "0.00"
        End If

        ' Call the CalculateTotalAmount method
        CalculateTotalAmount()
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validate input
            If cmbPaymentMethod.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(cmbPaymentMethod.SelectedItem.ToString()) Then
                MessageBox.Show("Please select a payment method.")
                Return
            End If

            ' Confirm before saving
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this payment?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If

            ' Insert payment data into the payment table
            Dim paymentMethod As String = cmbPaymentMethod.SelectedItem.ToString()
            Dim paymentDate As DateTime = dtpPaymentDate.Value
            Dim subTotal As Decimal = Convert.ToDecimal(txtSubTotal.Text)
            Dim invoiceNumber As String = txtInvoiceNumber.Text
            Dim discountApplied As Decimal = If(String.IsNullOrEmpty(txtDiscountAmount.Text), 0, Convert.ToDecimal(txtDiscountAmount.Text))
            Dim taxAmount As Decimal = Convert.ToDecimal(txtTaxAmount.Text)
            Dim totalAmount As Decimal = Convert.ToDecimal(txtTotalAmount.Text)
            Dim paymentNotes As String = txtPaymentNotes.Text

            Dim isPayMongoPayment As Boolean = (paymentMethod = "E-Wallet" OrElse paymentMethod = "Credit Card")
            Dim paymentSuccessful As Boolean = True ' Default to true for non-PayMongo payments

            If isPayMongoPayment Then
                Dim description As String = $"Payment for {invoiceNumber}"
                Dim payMongoMethod As String = If(paymentMethod = "E-Wallet", "gcash", "card")
                Dim paymentIntentId As String = Await InitiatePayment(totalAmount, "PHP", description, payMongoMethod)

                ' Retrieve member details for billing
                Dim billingDetails As Dictionary(Of String, Object) = GetMemberDetails(memberID)

                ' Create payment method
                Dim paymentMethodId As String = Await CreatePaymentMethod(payMongoMethod, billingDetails)

                ' Attach payment method to payment intent
                Dim checkoutUrl As String = Await AttachPaymentMethod(paymentIntentId, paymentMethodId)

                ' Open the URL in the default web browser
                Process.Start(New ProcessStartInfo(checkoutUrl) With {.UseShellExecute = True})

                ' Wait for payment confirmation
                paymentSuccessful = Await CheckPaymentStatus(paymentIntentId)
            End If

            If Not paymentSuccessful Then
                MessageBox.Show("Payment was not completed successfully. The transaction will be rolled back.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RaiseEvent PaymentAttemptCompleted(DialogResult.Cancel)
                Return
            End If

            If _transaction IsNot Nothing Then
                ' Use the existing transaction from registration
                ExecutePaymentLogic(_conn, _transaction, paymentMethod, paymentDate, subTotal, invoiceNumber, discountApplied, taxAmount, totalAmount, paymentNotes)
                ' DO NOT COMMIT. Let JoinNow handle it.
            Else
                ' Create a new transaction for standalone payments
                Using conn As New MySqlConnection(strConnection)
                    conn.Open()
                    Using transaction As MySqlTransaction = conn.BeginTransaction()
                        Try
                            ExecutePaymentLogic(conn, transaction, paymentMethod, paymentDate, subTotal, invoiceNumber, discountApplied, taxAmount, totalAmount, paymentNotes)
                            transaction.Commit()
                            Debug.WriteLine("Transaction committed.")
                        Catch ex As Exception
                            transaction.Rollback()
                            Debug.WriteLine("Transaction rolled back due to an error.")
                            Throw ' Re-throw to be caught by the outer catch
                        End Try
                    End Using
                End Using
            End If

            ' This logic runs after the database operations are successfully queued or committed.
            ' Retrieve member name
            Dim memberName As String = GetMemberName(memberID)

            ' Notify user of successful save
            MessageBox.Show("Payment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Show the receipt form
            Dim itemType As String = If(isMembership, "Membership", "Reservation")
            Dim receiptForm As New PaymentReceipt(paymentMethod, paymentDate, subTotal, invoiceNumber, txtReceiptNumber.Text, discountApplied, taxAmount, totalAmount, paymentNotes, memberID, memberName, itemType)
            receiptForm.ShowDialog()

            RaiseEvent PaymentAttemptCompleted(DialogResult.OK)
            OnPaymentCompleted()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ExecutePaymentLogic(conn As MySqlConnection, transaction As MySqlTransaction, paymentMethod As String, paymentDate As DateTime, subTotal As Decimal, invoiceNumber As String, discountApplied As Decimal, taxAmount As Decimal, totalAmount As Decimal, paymentNotes As String)
        ' Generate the receipt number just before saving
        Dim receiptNumber As String = GenerateReceiptNumber()
        txtReceiptNumber.Text = receiptNumber

        If _reservationDetails.HasValue Then
            ' --- LOGIC FOR NEW RESERVATION ---
            Dim details = _reservationDetails.Value

            ' 1. Insert into reservation table and get the new ID
            Dim reservationQuery As String = "INSERT INTO reservation (MemberID, EquipmentID, StaffID, ReservationDate, StartTime, EndTime, ReservationFee, ReservationNotes, ReservationStatus, Cancellation, Reschedule, PaymentStatus, Feedback, Purpose) " &
                                             "VALUES (@MemberID, @EquipmentID, @StaffID, @ReservationDate, @StartTime, @EndTime, @ReservationFee, @ReservationNotes, 'Pending', False, False, 'Paid', '', @Purpose); " &
                                             "SELECT LAST_INSERT_ID();"
            Dim newReservationID As Integer
            Using cmdReservation As New MySqlCommand(reservationQuery, conn, transaction)
                cmdReservation.Parameters.AddWithValue("@MemberID", details.MemberID)
                cmdReservation.Parameters.AddWithValue("@EquipmentID", details.EquipmentID)
                cmdReservation.Parameters.AddWithValue("@StaffID", details.StaffID)
                cmdReservation.Parameters.AddWithValue("@ReservationDate", details.ReservationDate.Date)
                cmdReservation.Parameters.AddWithValue("@StartTime", details.StartTime.ToString("HH:mm:ss"))
                cmdReservation.Parameters.AddWithValue("@EndTime", details.EndTime.ToString("HH:mm:ss"))
                cmdReservation.Parameters.AddWithValue("@ReservationFee", details.ReservationFee)
                cmdReservation.Parameters.AddWithValue("@ReservationNotes", details.ReservationNotes)
                cmdReservation.Parameters.AddWithValue("@Purpose", details.Purpose)
                newReservationID = Convert.ToInt32(cmdReservation.ExecuteScalar())
            End Using

            ' 2. Fetch the latest MembershipID for the member to satisfy the foreign key constraint
            Dim latestMembershipID As Integer = 0
            Dim fetchMembershipIDQuery As String = "SELECT MembershipID FROM membership WHERE MemberID = @MemberID ORDER BY MembershipID DESC LIMIT 1"
            Using cmdFetch As New MySqlCommand(fetchMembershipIDQuery, conn, transaction)
                cmdFetch.Parameters.AddWithValue("@MemberID", details.MemberID)
                Dim result = cmdFetch.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    latestMembershipID = Convert.ToInt32(result)
                Else
                    ' This case should ideally not be reached if a member is making a reservation, but as a safeguard:
                    Throw New Exception("Cannot create a reservation payment for a member with no active membership record.")
                End If
            End Using

            ' 3. Insert into payment table for the new reservation
            Dim paymentQuery As String = "INSERT INTO payment (MemberID, MembershipID, ReservationFee, PaymentMethod, PaymentDate, Amount, InvoiceNumber, ReceiptNumber, DiscountApplied, TaxAmount, TotalAmount, PaymentNotes, PaymentStatus) " &
                                         "VALUES (@MemberID, @MembershipID, @ReservationFee, @PaymentMethod, @PaymentDate, @Amount, @InvoiceNumber, @ReceiptNumber, @DiscountApplied, @TaxAmount, @TotalAmount, @PaymentNotes, 'Paid'); " &
                                         "SELECT LAST_INSERT_ID();"
            Using cmdPayment As New MySqlCommand(paymentQuery, conn, transaction)
                cmdPayment.Parameters.AddWithValue("@MemberID", details.MemberID)
                cmdPayment.Parameters.AddWithValue("@MembershipID", latestMembershipID)
                cmdPayment.Parameters.AddWithValue("@ReservationFee", details.ReservationFee) ' Correctly use the base reservation fee
                cmdPayment.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                cmdPayment.Parameters.AddWithValue("@PaymentDate", paymentDate)
                cmdPayment.Parameters.AddWithValue("@Amount", subTotal)
                cmdPayment.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber)
                cmdPayment.Parameters.AddWithValue("@ReceiptNumber", receiptNumber)
                cmdPayment.Parameters.AddWithValue("@DiscountApplied", discountApplied)
                cmdPayment.Parameters.AddWithValue("@TaxAmount", taxAmount)
                cmdPayment.Parameters.AddWithValue("@TotalAmount", totalAmount)
                cmdPayment.Parameters.AddWithValue("@PaymentNotes", paymentNotes)
                Me.paymentID = Convert.ToInt32(cmdPayment.ExecuteScalar()) ' Update the paymentID for the receipt
            End Using
        Else
            ' --- LOGIC FOR EXISTING PAYMENT (MEMBERSHIP OR EXISTING RESERVATION) ---
            ' Update payment table using parameterized queries
            Dim queryPayment As String = "UPDATE payment SET PaymentMethod = @PaymentMethod, PaymentDate = @PaymentDate, Amount = @Amount, InvoiceNumber = @InvoiceNumber, ReceiptNumber = @ReceiptNumber, DiscountApplied = @DiscountApplied, TaxAmount = @TaxAmount, TotalAmount = @TotalAmount, PaymentNotes = @PaymentNotes, PaymentStatus = 'Paid' WHERE PaymentID = @PaymentID"
            Using cmdPayment As New MySqlCommand(queryPayment, conn, transaction)
                cmdPayment.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                cmdPayment.Parameters.AddWithValue("@PaymentDate", paymentDate)
                cmdPayment.Parameters.AddWithValue("@Amount", subTotal)
                cmdPayment.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber)
                cmdPayment.Parameters.AddWithValue("@ReceiptNumber", receiptNumber)
                cmdPayment.Parameters.AddWithValue("@DiscountApplied", discountApplied)
                cmdPayment.Parameters.AddWithValue("@TaxAmount", taxAmount)
                cmdPayment.Parameters.AddWithValue("@TotalAmount", totalAmount)
                cmdPayment.Parameters.AddWithValue("@PaymentNotes", paymentNotes)
                cmdPayment.Parameters.AddWithValue("@PaymentID", paymentID)
                cmdPayment.ExecuteNonQuery()
            End Using

            If isMembership Then
                ' Update the status in the members table
                Dim queryMembers As String = "UPDATE members SET Status = 'Active' WHERE MemberID = @MemberID"
                Using cmdMembers As New MySqlCommand(queryMembers, conn, transaction)
                    cmdMembers.Parameters.AddWithValue("@MemberID", memberID)
                    cmdMembers.ExecuteNonQuery()
                End Using

                ' Update membership status
                Dim queryMembership As String = "UPDATE membership SET Status = 'Active' WHERE MemberID = @MemberID"
                Using cmdMembership As New MySqlCommand(queryMembership, conn, transaction)
                    cmdMembership.Parameters.AddWithValue("@MemberID", memberID)
                    cmdMembership.ExecuteNonQuery()
                End Using

                ' Fetch the latest MembershipID
                Dim latestMembershipID As Integer = 0
                Dim queryFetchLatestMembershipID As String = "SELECT MembershipID FROM membership WHERE MemberID = @MemberID ORDER BY MembershipID DESC LIMIT 1"
                Using cmdFetchLatestMembershipID As New MySqlCommand(queryFetchLatestMembershipID, conn, transaction)
                    cmdFetchLatestMembershipID.Parameters.AddWithValue("@MemberID", memberID)
                    Dim result = cmdFetchLatestMembershipID.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        latestMembershipID = Convert.ToInt32(result)
                    End If
                End Using

                ' Update the MembershipCost in the payment table
                Dim queryUpdateMembershipCost As String = "UPDATE payment SET MembershipCost = @MembershipCost, MembershipID = @MembershipID WHERE PaymentID = @PaymentID"
                Using cmdUpdateMembershipCost As New MySqlCommand(queryUpdateMembershipCost, conn, transaction)
                    cmdUpdateMembershipCost.Parameters.AddWithValue("@MembershipCost", subTotal)
                    cmdUpdateMembershipCost.Parameters.AddWithValue("@MembershipID", latestMembershipID)
                    cmdUpdateMembershipCost.Parameters.AddWithValue("@PaymentID", paymentID)
                    cmdUpdateMembershipCost.ExecuteNonQuery()
                End Using
            Else
                ' Update the payment status in the reservation table
                Dim reservationIdQuery As String = "SELECT ReservationID FROM payment WHERE PaymentID = @PaymentID"
                Dim reservationId As Object = Nothing
                Using cmd As New MySqlCommand(reservationIdQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID)
                    reservationId = cmd.ExecuteScalar()
                End Using

                If reservationId IsNot Nothing AndAlso Not IsDBNull(reservationId) Then
                    Dim queryReservation As String = "UPDATE reservation SET PaymentStatus = 'Paid' WHERE ReservationID = @ReservationID"
                    Using cmdReservation As New MySqlCommand(queryReservation, conn, transaction)
                        cmdReservation.Parameters.AddWithValue("@ReservationID", Convert.ToInt32(reservationId))
                        cmdReservation.ExecuteNonQuery()
                    End Using
                End If
            End If
        End If
    End Sub

    Private Function GetMemberName(memberID As Integer) As String
        Dim memberName As String = ""
        Dim query As String = "SELECT CONCAT(FirstName, ' ', LastName) FROM members WHERE MemberID = @MemberID"

        ' Use the existing connection and transaction if they are part of a larger operation (like JoinNow),
        ' otherwise, create a new connection.
        Dim connToUse As MySqlConnection = If(_conn IsNot Nothing, _conn, New MySqlConnection(modDB.strConnection))
        Dim closeConnectionAfter As Boolean = (_conn Is Nothing) ' Only close the connection if we created it here.

        Try
            If closeConnectionAfter Then
                connToUse.Open()
            End If

            Using cmd As New MySqlCommand(query, connToUse)
                cmd.Parameters.AddWithValue("@MemberID", memberID)

                ' If a transaction is active, use it.
                If _transaction IsNot Nothing Then
                    cmd.Transaction = _transaction
                End If

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    memberName = result.ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to retrieve member name: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If closeConnectionAfter AndAlso connToUse.State = ConnectionState.Open Then
                connToUse.Close()
            End If
        End Try

        Return memberName
    End Function

    Private Function GenerateInvoiceNumber() As String
        ' Logic to generate a new InvoiceNumber
        Return "INV" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Function GenerateReceiptNumber() As String
        ' Logic to generate a new ReceiptNumber
        Return "REC" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub btnbck_Click(sender As Object, e As EventArgs) Handles btnbck.Click
        ' Ask for confirmation before going back if there are inputs in the form
        If Not String.IsNullOrEmpty(txtSubTotal.Text) OrElse Not String.IsNullOrEmpty(txtDiscountAmount.Text) OrElse Not String.IsNullOrEmpty(txtPaymentNotes.Text) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If
        Me.FindForm()?.Close()
    End Sub




    Public Event PaymentCompleted As EventHandler

    ' Assume this method is called when payment is completed
    Private Sub OnPaymentCompleted()
        ' Raise the PaymentCompleted event
        RaiseEvent PaymentCompleted(Me, EventArgs.Empty)
        Me.Hide()
    End Sub

    Public Async Function InitiatePayment(amount As Decimal, currency As String, description As String, paymentMethod As String) As Task(Of String)
        Dim apiKey As String = "sk_test_orK6MTNaBig29mb3WoQh2TQU" ' Replace with your actual secret key
        Dim url As String = "https://api.paymongo.com/v1/payment_intents"
        Dim postData As New Dictionary(Of String, Object) From {
        {"data", New Dictionary(Of String, Object) From {
            {"attributes", New Dictionary(Of String, Object) From {
                {"amount", CInt(amount * 100)}, ' Amount in centavos
                {"currency", currency},
                {"payment_method_allowed", New String() {paymentMethod}},
                {"description", description}
            }}
        }}
    }

        Dim json As String = JsonConvert.SerializeObject(postData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(json)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey & ":")))
            Dim content As New ByteArrayContent(byteArray)
            content.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
            Dim responseFromServer As String = Await response.Content.ReadAsStringAsync()

            ' Debug: Log the response
            Debug.WriteLine("Response from PayMongo: " & responseFromServer)

            ' Parse the response to get the payment_intent_id
            Dim responseData As JObject = JObject.Parse(responseFromServer)
            Dim paymentIntentId As String = responseData("data")("id").ToString()
            Return paymentIntentId
        End Using
    End Function

    Public Async Function CreatePaymentMethod(paymentMethodType As String, billingDetails As Dictionary(Of String, Object)) As Task(Of String)
        Dim apiKey As String = "sk_test_orK6MTNaBig29mb3WoQh2TQU" ' Replace with your actual secret key
        Dim url As String = "https://api.paymongo.com/v1/payment_methods"
        Dim postData As New Dictionary(Of String, Object) From {
        {"data", New Dictionary(Of String, Object) From {
            {"attributes", New Dictionary(Of String, Object) From {
                {"type", paymentMethodType},
                {"billing", billingDetails}
            }}
        }}
    }

        Dim json As String = JsonConvert.SerializeObject(postData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(json)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey & ":")))
            Dim content As New ByteArrayContent(byteArray)
            content.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
            Dim responseFromServer As String = Await response.Content.ReadAsStringAsync()

            ' Debug: Log the response
            Debug.WriteLine("Response from PayMongo (Create Payment Method): " & responseFromServer)

            ' Parse the response to get the payment_method_id
            Dim responseData As JObject = JObject.Parse(responseFromServer)
            Dim paymentMethodId As String = responseData("data")("id").ToString()
            Return paymentMethodId
        End Using
    End Function

    Public Async Function AttachPaymentMethod(paymentIntentId As String, paymentMethodId As String) As Task(Of String)
        Dim apiKey As String = "sk_test_orK6MTNaBig29mb3WoQh2TQU" ' Replace with your actual secret key
        Dim url As String = $"https://api.paymongo.com/v1/payment_intents/{paymentIntentId}/attach"
        Dim postData As New Dictionary(Of String, Object) From {
            {"data", New Dictionary(Of String, Object) From {
                {"attributes", New Dictionary(Of String, Object) From {
                    {"payment_method", paymentMethodId},
                    {"return_url", "https://ochna001.github.io/VPHSwebsiteforIT105/return_url.html"} ' Replace with your actual return URL
                }}
            }}
        }

        Dim json As String = JsonConvert.SerializeObject(postData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(json)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey & ":")))
            Dim content As New ByteArrayContent(byteArray)
            content.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
            Dim responseFromServer As String = Await response.Content.ReadAsStringAsync()

            ' Debug: Log the response
            Debug.WriteLine("Response from PayMongo (Attach Payment Method): " & responseFromServer)

            ' Parse the response to get the checkout_url
            Dim responseData As JObject = JObject.Parse(responseFromServer)
            Dim nextAction As JObject = CType(responseData("data")("attributes")("next_action"), JObject)
            Dim redirect As JObject = CType(nextAction("redirect"), JObject)
            Dim checkoutUrl As String = redirect("url")?.ToString()

            If checkoutUrl Is Nothing Then
                Throw New Exception("The checkout_url is not present in the response.")
            End If

            Return checkoutUrl
        End Using
    End Function


    Public Function GetMemberDetails(memberID As Integer) As Dictionary(Of String, Object)
        Dim query As String = $"SELECT `FirstName`, `LastName`, `Email`, `PhoneNumber`, `Street`, `City`, `Province`, `ZipCode` FROM `members` WHERE `MemberID` = {memberID}"
        Dim memberDetails As New Dictionary(Of String, Object)

        Using conn As New MySqlConnection(strConnection)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        memberDetails("name") = $"{reader("FirstName")} {reader("LastName")}"
                        memberDetails("email") = reader("Email").ToString()
                        memberDetails("phone") = reader("PhoneNumber").ToString()

                        ' Create a nested dictionary for the address
                        Dim addressDetails As New Dictionary(Of String, String) From {
                            {"line1", reader("Street").ToString()},
                            {"city", reader("City").ToString()},
                            {"state", reader("Province").ToString()},
                            {"postal_code", reader("ZipCode").ToString()},
                            {"country", "PH"} ' Hardcode country to PH
                        }

                        memberDetails("address") = addressDetails
                    End If
                End Using
            End Using
        End Using

        Return memberDetails
    End Function

    Public Async Function GetPaymentIntentStatus(paymentIntentId As String) As Task(Of String)
        Dim apiKey As String = "sk_test_orK6MTNaBig29mb3WoQh2TQU" ' Replace with your actual secret key
        Dim url As String = $"https://api.paymongo.com/v1/payment_intents/{paymentIntentId}"

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey & ":")))

            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            Dim responseFromServer As String = Await response.Content.ReadAsStringAsync()

            ' Debug: Log the response
            Debug.WriteLine("Response from PayMongo (Get Payment Intent): " & responseFromServer)

            ' Parse the response to get the status
            Dim responseData As JObject = JObject.Parse(responseFromServer)
            Dim status As String = responseData("data")("attributes")("status").ToString()
            Return status
        End Using
    End Function

    Private Async Function CheckPaymentStatus(paymentIntentId As String) As Task(Of Boolean)
        ' Show a waiting message to the user
        Dim waitingForm As New Form() With {
            .Text = "Awaiting Payment",
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .ControlBox = False,
            .Size = New System.Drawing.Size(300, 100)
        }
        Dim waitingLabel As New Label() With {
            .Text = "Awaiting payment confirmation...",
            .Dock = DockStyle.Fill,
            .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        }
        waitingForm.Controls.Add(waitingLabel)
        waitingForm.Show(Me)

        Try
            Dim timeout As Integer = 300 ' 5 minutes timeout (300 seconds)
            Dim startTime As DateTime = DateTime.Now

            While (DateTime.Now - startTime).TotalSeconds < timeout
                Dim status As String = Await GetPaymentIntentStatus(paymentIntentId)

                If status = "succeeded" Then
                    Return True ' Payment is successful
                ElseIf status = "failed" OrElse status = "canceled" Then
                    Return False ' Payment failed or was canceled
                End If

                ' Wait for 5 seconds before checking again
                Await Task.Delay(5000)
            End While

            ' If loop finishes, it's a timeout
            MessageBox.Show("Payment confirmation timed out.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            waitingForm.Close()
        End Try
    End Function
End Class
