Imports MySql.Data.MySqlClient

Public Class AddPaymentForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            Try
                conn.Open()
                Dim query As String = "SELECT MemberID, CONCAT(MemberID, ' - ', FirstName, ' ', LastName) AS MemberName FROM members"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim memberList As New List(Of KeyValuePair(Of Integer, String))
                While reader.Read()
                    memberList.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32("MemberID"), reader.GetString("MemberName")))
                End While

                cmbMember.DataSource = memberList
                cmbMember.DisplayMember = "Value"
                cmbMember.ValueMember = "Key"

            Catch ex As Exception
                MessageBox.Show("An error occurred while loading members: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInput() Then
            SaveChanges()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If cmbMember.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a member.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbPaymentType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a payment type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAmount.Text) OrElse Not IsNumeric(txtAmount.Text) Then
            MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub SaveChanges()
        UpdateConnectionString()
        Using conn As New MySqlConnection(strConnection)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO payment (MemberID, Amount, PaymentDescription, PaymentDate, PaymentStatus, PaymentMethod, ReservationFee, MembershipCost) VALUES (@MemberID, @Amount, @PaymentDescription, @PaymentDate, 'Unpaid', 'N/A', @ReservationFee, @MembershipCost)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@MemberID", CType(cmbMember.SelectedValue, Integer))
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text))
                cmd.Parameters.AddWithValue("@PaymentDescription", txtDescription.Text)
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now)

                If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                    cmd.Parameters.AddWithValue("@ReservationFee", Convert.ToDecimal(txtAmount.Text))
                    cmd.Parameters.AddWithValue("@MembershipCost", 0)
                Else
                    cmd.Parameters.AddWithValue("@ReservationFee", 0)
                    cmd.Parameters.AddWithValue("@MembershipCost", Convert.ToDecimal(txtAmount.Text))
                End If

                cmd.ExecuteNonQuery()
                MessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An error occurred while saving the payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
