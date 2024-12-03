Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Imports System.Data.SqlClient

Public Class Gym_Equipment

    Private Sub nametxtbox_TextChanged(sender As Object, e As EventArgs) Handles nametxtbox.TextChanged

    End Sub

    Private Sub Brandtxtbox_TextChanged(sender As Object, e As EventArgs) Handles Brandtxtbox.TextChanged

    End Sub

    Private Sub Typetxtbox_TextChanged(sender As Object, e As EventArgs) Handles Typetxtbox.TextChanged

    End Sub

    Private Sub dtpDateofaPurchase_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateofaPurchase.ValueChanged

    End Sub

    Private Sub MainetenanceCosttxtbox_TextChanged(sender As Object, e As EventArgs) Handles MainetenanceCosttxtbox.TextChanged

    End Sub

    Private Sub PurchasePlacetxtbox_TextChanged(sender As Object, e As EventArgs) Handles PurchasePlacetxtbox.TextChanged

    End Sub

    Private Sub SubmitDetailstxtbox_Click(sender As Object, e As EventArgs) Handles SubmitDetailstxtbox.Click
        Try
            ' Step 2: Retrieve input values from text boxes
            Dim Name As String = nametxtbox.Text
            Dim brand As String = Brandtxtbox.Text
            Dim Type As String = Typetxtbox.Text
            Dim dateOfPurchase As Date = dtpDateofaPurchase.Value
            Dim maintenanceCost As Decimal = 0
            Dim purchasePlace As String = PurchasePlacetxtbox.Text
            Dim maintenanceSchedule As String = MaintenanceScheduletxtbox.Text
            Dim status As String = Statustxtbox.Text

            ' Check if any required text boxes are empty
            If String.IsNullOrWhiteSpace(Name) OrElse String.IsNullOrWhiteSpace(brand) OrElse String.IsNullOrWhiteSpace(Type) OrElse String.IsNullOrWhiteSpace(MainetenanceCosttxtbox.Text) OrElse String.IsNullOrWhiteSpace(purchasePlace) OrElse String.IsNullOrWhiteSpace(maintenanceSchedule) OrElse String.IsNullOrWhiteSpace(status) Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Parse maintenance cost
            maintenanceCost = Decimal.Parse(MainetenanceCosttxtbox.Text)

            ' Step 3: Create SQL INSERT statement
            Dim query As String = $"INSERT INTO equipment (Name, Brand, Type, PurchaseDate, MaintenanceSchedule, Status, MaintenanceCost, PurchasePlace) " &
                                  $"VALUES ('{Name}', '{brand}', '{Type}', '{dateOfPurchase:yyyy-MM-dd}', '{maintenanceSchedule}', '{status}', {maintenanceCost}, '{purchasePlace}')"

            ' Step 4: Execute the SQL statement using readQuery
            readQuery(query)

            ' Show success message
            MessageBox.Show("Equipment details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the equipment details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Hide()


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Statustxtbox_TextChanged(sender As Object, e As EventArgs) Handles Statustxtbox.TextChanged

    End Sub

    Private Sub MaintenanceScheduletxtbox_TextChanged(sender As Object, e As EventArgs) Handles MaintenanceScheduletxtbox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ' Define the readQuery method

End Class
