Imports MySql.Data.MySqlClient

Public Class Equipmentlist
    Private currentOffset As Integer = 0
    Private Const batchSize As Integer = 25

    Private Sub Equipmentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeContextMenu()
        InitializeDGV()
        LoadEquipmentData()
    End Sub

    Private Sub LoadEquipmentData()
        Dim query As String = $"SELECT * FROM equipment LIMIT {batchSize} OFFSET {currentOffset}"
        LoadToDGV(query, dgvEquipmentlist)
        UIUtils.FormatAndStyleDGV(dgvEquipmentlist)
        RenameColumns(dgvEquipmentlist)
    End Sub

    Private Sub RenameColumns(dgv As DataGridView)
        dgv.Columns("EquipmentID").HeaderText = "Equipment ID"
        dgv.Columns("Name").HeaderText = "Name"
        dgv.Columns("Type").HeaderText = "Type"
        dgv.Columns("Brand").HeaderText = "Brand"
        dgv.Columns("PurchaseDate").HeaderText = "Purchase Date"
        dgv.Columns("MaintenanceSchedule").HeaderText = "Maintenance Schedule"
        dgv.Columns("Status").HeaderText = "Status"
        dgv.Columns("PurchasePlace").HeaderText = "Supplier"
        dgv.Columns("MaintenanceCost").HeaderText = "Maintenance Cost"
    End Sub

    Private Function FindSimilarEquipmentID(EquipmentID As Integer) As Integer
        Dim query As String = $"SELECT EquipmentID FROM equipment WHERE Name = (SELECT Name FROM equipment WHERE EquipmentID = {EquipmentID}) AND EquipmentID <> {EquipmentID} AND EquipmentID NOT IN (SELECT EquipmentID FROM reservation)"
        Dim result As Object = executeSelectQuery(query)
        If result IsNot Nothing Then
            Return Convert.ToInt32(result)
        End If
        Return -1
    End Function

    Private Sub UpdateEquipmentReferences(oldEquipmentID As Integer, newEquipmentID As Integer)
        Dim query As String = $"UPDATE reservation SET EquipmentID = {newEquipmentID} WHERE EquipmentID = {oldEquipmentID}"
        readQuery(query)
    End Sub

    Private Sub DeleteEquipmentFromDatabase(EquipmentID As Integer)
        Try
            Dim query As String = $"DELETE FROM equipment WHERE EquipmentID = {EquipmentID}"
            readQuery(query)
        Catch ex As Exception
            ' Log the error details
            Debug.WriteLine($"Error deleting equipment with ID {EquipmentID}: {ex.Message}")
            MessageBox.Show($"Error deleting equipment with ID {EquipmentID}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializeDGV()
        LoadEquipmentData()
        ' Additional initialization code if needed
    End Sub

    Private Sub InitializeContextMenu()
        Dim contextMenu As New ContextMenuStrip()

        Dim editItem As New ToolStripMenuItem("Edit")
        Dim deleteItem As New ToolStripMenuItem("Delete")
        Dim setStatusItem As New ToolStripMenuItem("Set Status")
        Dim operationalItem As New ToolStripMenuItem("Operational")
        Dim outOfOrderItem As New ToolStripMenuItem("Out of Order")

        setStatusItem.DropDownItems.Add(operationalItem)
        setStatusItem.DropDownItems.Add(outOfOrderItem)

        contextMenu.Items.Add(editItem)
        contextMenu.Items.Add(deleteItem)
        contextMenu.Items.Add(New ToolStripSeparator())
        contextMenu.Items.Add(setStatusItem)

        AddHandler editItem.Click, AddressOf EditMenuItem_Click
        AddHandler deleteItem.Click, AddressOf DeleteMenuItem_Click
        AddHandler operationalItem.Click, AddressOf SetStatus_Click
        AddHandler outOfOrderItem.Click, AddressOf SetStatus_Click

        dgvEquipmentList.ContextMenuStrip = contextMenu
    End Sub

    Private Sub dgvEquipmentList_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvEquipmentList.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = dgvEquipmentList.HitTest(e.X, e.Y)
            If hti.RowIndex >= 0 Then
                dgvEquipmentList.ClearSelection()
                dgvEquipmentList.Rows(hti.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs)
        If dgvEquipmentList.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEquipmentList.SelectedRows(0)
            Dim equipmentId As Integer = Convert.ToInt32(selectedRow.Cells("EquipmentID").Value)

            Using hostForm As New Form()
                hostForm.Text = "Edit Equipment"
                hostForm.StartPosition = FormStartPosition.CenterParent
                hostForm.Size = New Size(420, 520) ' Adjust size to fit control

                Dim editControl As New Gym_Equipment(equipmentId)
                AddHandler editControl.BackClicked, Sub(s, ev) hostForm.Close()
                editControl.Dock = DockStyle.Fill

                hostForm.Controls.Add(editControl)
                hostForm.ShowDialog()
            End Using

            LoadEquipmentData() ' Refresh the data to show any changes
        End If
    End Sub

    Private Function IsEquipmentReferenced(EquipmentID As Integer) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM reservation WHERE EquipmentID = {EquipmentID}"
        Dim count As Integer = Convert.ToInt32(executeSelectQuery(query))
        Return count > 0
    End Function

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs)
        If dgvEquipmentList.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEquipmentList.SelectedRows(0)
            Dim equipmentID As Integer = Convert.ToInt32(selectedRow.Cells("EquipmentID").Value)

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this equipment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmResult = DialogResult.No Then
                Return
            End If

            If IsEquipmentReferenced(equipmentID) Then
                MessageBox.Show("This equipment is currently reserved and cannot be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            DeleteEquipmentFromDatabase(equipmentID)
            LoadEquipmentData() ' Refresh the grid
        End If
    End Sub

    Private Sub SetStatus_Click(sender As Object, e As EventArgs)
        If dgvEquipmentList.SelectedRows.Count > 0 Then
            Dim status As String = CType(sender, ToolStripMenuItem).Text
            Dim equipmentID As Integer = Convert.ToInt32(dgvEquipmentList.SelectedRows(0).Cells("EquipmentID").Value)

            Try
                UpdateConnectionString()
                Using conn As New MySqlConnection(strConnection)
                    conn.Open()
                    Dim query As String = "UPDATE equipment SET Status = @Status WHERE EquipmentID = @EquipmentID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Status", status)
                        cmd.Parameters.AddWithValue("@EquipmentID", equipmentID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadEquipmentData() ' Refresh data
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private gymEquipmentControl As Gym_Equipment
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the Gym_Equipment control instead of AddAttendanceControl
        gymEquipmentControl = New Gym_Equipment()
        AddHandler gymEquipmentControl.BackClicked, AddressOf GymEquipmentControl_BackClicked

        ' Add the Gym_Equipment control to the form
        Me.Controls.Add(gymEquipmentControl)
        gymEquipmentControl.Visible = False

        ' Add any initialization after the InitializeComponent() call.
        ' (If you need any specific initialization for gymEquipmentControl, add it here)
    End Sub

    ' Button click event to show the Gym_Equipment control

    Private Sub GymEquipmentControl_BackClicked(sender As Object, e As EventArgs)
        gymEquipmentControl.Visible = False
    End Sub

    Private Sub AddEquipment_Click(sender As Object, e As EventArgs) Handles AddEquipment.Click
        gymEquipmentControl.Location = New Point(100, 200)

        ' Set the size of the Gym_Equipment control
        gymEquipmentControl.Size = New Size(405, 486) ' Set the desired size

        ' Add the Gym_Equipment control to the form if not already added
        If Not Controls.Contains(gymEquipmentControl) Then
            Controls.Add(gymEquipmentControl)
            Debug.WriteLine("Gym_Equipment control added to the form.")
        Else
            Debug.WriteLine("Gym_Equipment control already exists on the form.")
        End If

        gymEquipmentControl.BringToFront()
        gymEquipmentControl.Visible = True
        Debug.WriteLine("Gym_Equipment control is now visible.")
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentOffset += batchSize
        LoadEquipmentData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentOffset >= batchSize Then
            currentOffset -= batchSize
        Else
            currentOffset = 0
        End If
        LoadEquipmentData()
    End Sub
End Class
