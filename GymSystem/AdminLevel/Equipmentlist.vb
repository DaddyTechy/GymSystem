Public Class Equipmentlist
    Private currentOffset As Integer = 0
    Private Const batchSize As Integer = 25

    Private Sub Equipmentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeDGV()
        LoadEquipmentData()
    End Sub

    Private Sub LoadEquipmentData()
        Dim query As String = $"SELECT * FROM equipment LIMIT {batchSize} OFFSET {currentOffset}"
        LoadToDGV(query, dgvEquipmentlist)
        SetDGVPropertiesForEquipment(dgvEquipmentlist)
        RenameColumns(dgvEquipmentlist)
    End Sub

    Private Sub SetDGVPropertiesForEquipment(dgv As DataGridView)
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40)
        dgv.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgv.DefaultCellStyle.ForeColor = Color.White
        dgv.DefaultCellStyle.BackColor = parentBackgroundColor
        dgv.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor
        dgv.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor

        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.BorderStyle = BorderStyle.None
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 10.0F)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        cellStyle.Font = New Font("Segoe UI", 9.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.True
        dgv.DefaultCellStyle = cellStyle

        dgv.Dock = DockStyle.Fill
        dgv.EditMode = DataGridViewEditMode.EditOnEnter
        dgv.EnableHeadersVisualStyles = False
        dgv.GridColor = Color.White
        dgv.MultiSelect = False
        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        Dim rowHeaderStyle As New DataGridViewCellStyle()
        rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        rowHeaderStyle.BackColor = SystemColors.WindowFrame
        rowHeaderStyle.Font = New Font("Segoe UI", 9.75F)
        rowHeaderStyle.ForeColor = Color.White
        rowHeaderStyle.SelectionBackColor = SystemColors.Highlight
        rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        rowHeaderStyle.WrapMode = DataGridViewTriState.True
        dgv.RowHeadersDefaultCellStyle = rowHeaderStyle

        dgv.RowHeadersVisible = False
        dgv.RowHeadersWidth = 51

        Dim rowsStyle As New DataGridViewCellStyle()
        rowsStyle.BackColor = Color.FromArgb(40, 40, 40)
        rowsStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rowsStyle.ForeColor = Color.White
        dgv.RowsDefaultCellStyle = rowsStyle

        dgv.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgv.RowTemplate.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.0F)
        dgv.RowTemplate.DefaultCellStyle.ForeColor = Color.White
        dgv.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ShowCellErrors = False
        dgv.ShowRowErrors = False

        RenameColumns(dgv)
    End Sub

    Private Sub RenameColumns(dgv As DataGridView)
        dgv.Columns("EquipmentID").HeaderText = "Equipment ID"
        dgv.Columns("Name").HeaderText = "Name"
        dgv.Columns("Type").HeaderText = "Type"
        dgv.Columns("Brand").HeaderText = "Brand"
        dgv.Columns("PurchaseDate").HeaderText = "Purchase Date"
        dgv.Columns("MaintenanceSchedule").HeaderText = "MaintenanceSchedule"
        dgv.Columns("Status").HeaderText = "Status"
        dgv.Columns("PurchasePlace").HeaderText = "PurchasePlace"
        dgv.Columns("MaintenanceCost").HeaderText = "MaintenanceCost"
    End Sub


    Private Sub dgvEquipmentlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub InitializeDGV()
        LoadEquipmentData()
        ' Additional initialization code if needed
    End Sub

    Private gymEquipmentControl As Gym_Equipment
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the Gym_Equipment control instead of AddAttendanceControl
        gymEquipmentControl = New Gym_Equipment()

        ' Add the Gym_Equipment control to the form
        Me.Controls.Add(gymEquipmentControl)
        gymEquipmentControl.Visible = False

        ' Add any initialization after the InitializeComponent() call.
        ' (If you need any specific initialization for gymEquipmentControl, add it here)
    End Sub

    ' Button click event to show the Gym_Equipment control

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

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentOffset >= batchSize Then
            currentOffset -= batchSize
        Else
            currentOffset = 0
        End If
        LoadEquipmentData()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        currentOffset += batchSize
        LoadEquipmentData()
    End Sub
End Class
