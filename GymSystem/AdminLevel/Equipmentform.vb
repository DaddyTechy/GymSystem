Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Imports System.Data.SqlClient

Public Class Gym_Equipment

    Public Event BackClicked As EventHandler
    Private isEditMode As Boolean = False
    Private currentEquipmentId As Integer = 0

    Public Sub New()
        InitializeComponent()
        isEditMode = False
        SubmitDetailstxtbox.Text = "Submit"
    End Sub



    Public Sub New(ByVal equipmentId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        Me.isEditMode = True
        Me.currentEquipmentId = equipmentId
        SubmitDetailstxtbox.Text = "Update"
        LoadEquipmentDetails()
    End Sub

    Private Sub LoadEquipmentDetails()
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT * FROM equipment WHERE EquipmentID = @EquipmentID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EquipmentID", currentEquipmentId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            nametxtbox.Text = reader("Name").ToString()
                            Brandtxtbox.Text = reader("Brand").ToString()
                            Typetxtbox.Text = reader("Type").ToString()
                            dtpDateofaPurchase.Value = Convert.ToDateTime(reader("PurchaseDate"))
                            MainetenanceCosttxtbox.Text = reader("MaintenanceCost").ToString()
                            PurchasePlacetxtbox.Text = reader("PurchasePlace").ToString()
                            MaintenanceScheduletxtbox.Text = reader("MaintenanceSchedule").ToString()
                            Statustxtbox.Text = reader("Status").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading equipment details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SubmitDetailstxtbox_Click(sender As Object, e As EventArgs) Handles SubmitDetailstxtbox.Click
        Try
            If String.IsNullOrWhiteSpace(nametxtbox.Text) OrElse String.IsNullOrWhiteSpace(Brandtxtbox.Text) OrElse String.IsNullOrWhiteSpace(Typetxtbox.Text) OrElse String.IsNullOrWhiteSpace(MainetenanceCosttxtbox.Text) OrElse String.IsNullOrWhiteSpace(PurchasePlacetxtbox.Text) OrElse String.IsNullOrWhiteSpace(MaintenanceScheduletxtbox.Text) OrElse String.IsNullOrWhiteSpace(Statustxtbox.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String
                If isEditMode Then
                    query = "UPDATE equipment SET Name = @Name, Brand = @Brand, Type = @Type, PurchaseDate = @PurchaseDate, MaintenanceSchedule = @MaintenanceSchedule, Status = @Status, MaintenanceCost = @MaintenanceCost, PurchasePlace = @PurchasePlace WHERE EquipmentID = @EquipmentID"
                Else
                    query = "INSERT INTO equipment (Name, Brand, Type, PurchaseDate, MaintenanceSchedule, Status, MaintenanceCost, PurchasePlace) VALUES (@Name, @Brand, @Type, @PurchaseDate, @MaintenanceSchedule, @Status, @MaintenanceCost, @PurchasePlace)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", nametxtbox.Text)
                    cmd.Parameters.AddWithValue("@Brand", Brandtxtbox.Text)
                    cmd.Parameters.AddWithValue("@Type", Typetxtbox.Text)
                    cmd.Parameters.AddWithValue("@PurchaseDate", dtpDateofaPurchase.Value)
                    cmd.Parameters.AddWithValue("@MaintenanceSchedule", MaintenanceScheduletxtbox.Text)
                    cmd.Parameters.AddWithValue("@Status", Statustxtbox.Text)
                    cmd.Parameters.AddWithValue("@MaintenanceCost", Decimal.Parse(MainetenanceCosttxtbox.Text))
                    cmd.Parameters.AddWithValue("@PurchasePlace", PurchasePlacetxtbox.Text)
                    If isEditMode Then
                        cmd.Parameters.AddWithValue("@EquipmentID", currentEquipmentId)
                    End If
                    cmd.ExecuteNonQuery()
                End Using

                Dim successMessage As String = If(isEditMode, "Equipment details updated successfully.", "Equipment details added successfully.")
                MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Me.ParentForm IsNot Nothing Then
                    Me.ParentForm.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent BackClicked(Me, EventArgs.Empty)
    End Sub


End Class
