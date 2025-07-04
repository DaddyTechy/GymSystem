Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class RegistrationSuccessForm
    Private memberId As Integer
    Private cost As Decimal

    Public Sub New(memberId As Integer, cost As Decimal)
        InitializeComponent()
        Me.memberId = memberId
        Me.cost = cost
        lblMemberID.Text = memberId.ToString()
        AddHandler Me.Resize, AddressOf Form_Resize
        AddHandler Me.Load, AddressOf Form_Load
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs)
        CenterPanel()
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        pnlMain.Location = New Point((Me.ClientSize.Width - pnlMain.Width) \ 2, (Me.ClientSize.Height - pnlMain.Height) \ 2)
    End Sub

    Private Sub btnProceedToPayment_Click(sender As Object, e As EventArgs) Handles btnProceedToPayment.Click
        Dim newPaymentID As Integer = CreateNewPayment(memberId, cost)
        If newPaymentID > 0 Then
            btnProceedToPayment.Enabled = False
            btnPayLater.Enabled = False

            Using paymentHost As New PaymentFormHost(cost, True, newPaymentID, memberId)
                AddHandler paymentHost.PaymentCompleted, AddressOf OnPaymentCompleted
                paymentHost.ShowDialog(Me)
            End Using

            ' Re-enable buttons after the dialog is closed, regardless of the outcome
            btnProceedToPayment.Enabled = True
            btnPayLater.Enabled = True
        Else
            MessageBox.Show("Failed to create a new payment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub OnPaymentCompleted(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnPayLater_Click(sender As Object, e As EventArgs) Handles btnPayLater.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function CreateNewPayment(ByVal memberID As Integer, ByVal fee As Decimal) As Integer
        modDB.UpdateConnectionString()
        Dim newPaymentID As Integer = 0
        Dim latestMembershipID As Integer = 0

        Try
            Using conn As New MySqlConnection(modDB.strConnection)
                conn.Open()

                Dim query As String = "SELECT MembershipID FROM membership WHERE MemberID = @MemberID ORDER BY StartDate DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        latestMembershipID = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("No active membership found for this member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return 0
                    End If
                End Using

                Dim insertQuery As String = "INSERT INTO payment (MemberID, MembershipID, Amount, PaymentDate, PaymentStatus, PaymentMethod, PaymentNotes) VALUES (@MemberID, @MembershipID, @Amount, @PaymentDate, @PaymentStatus, @PaymentMethod, @PaymentNotes); SELECT LAST_INSERT_ID();"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    cmd.Parameters.AddWithValue("@MembershipID", latestMembershipID)
                    cmd.Parameters.AddWithValue("@Amount", fee)
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@PaymentStatus", "Pending")
                    cmd.Parameters.AddWithValue("@PaymentMethod", "N/A")
                    cmd.Parameters.AddWithValue("@PaymentNotes", "Initial payment for new membership")
                    newPaymentID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while creating the payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return newPaymentID
    End Function
End Class
