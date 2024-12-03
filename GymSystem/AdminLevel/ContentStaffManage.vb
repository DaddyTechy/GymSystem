' ContentStaffManage.vb
Public Class ContentStaffManage
    Private Sub LoadstaffData()
        Dim query As String = "SELECT * FROM staff"
        LoadToDGV(query, dgvStafflist)
        SetDGVPropertiesForStaff(dgvStafflist)
        RenameColumns(dgvStafflist)
    End Sub

    Private Sub SetDGVPropertiesForStaff(dgv As DataGridView)
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
        dgv.Columns("StaffID").HeaderText = "Staff ID"
        dgv.Columns("FirstName").HeaderText = "First Name"
        dgv.Columns("MiddleName").HeaderText = "Middle Name"
        dgv.Columns("LastName").HeaderText = "Last Name"
        dgv.Columns("Position").HeaderText = "Position"
        dgv.Columns("Email").HeaderText = "Email"
        dgv.Columns("PhoneNumber").HeaderText = "Phone Number"
        dgv.Columns("HireDate").HeaderText = "Hire Date"
        dgv.Columns("Salary").HeaderText = "Salary"
        dgv.Columns("ShiftSchedule").HeaderText = "Shift Schedule"
        dgv.Columns("Certification").HeaderText = "Certification"
        dgv.Columns("PerformanceRating").HeaderText = "Performance Rating"
        dgv.Columns("Specialization").HeaderText = "Specialization"
        dgv.Columns("Experience").HeaderText = "Experience"
        dgv.Columns("DTCreated").HeaderText = "DT Created"
    End Sub

    Private Sub dgvStafflist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStafflist.CellContentClick

    End Sub

    Private Sub ContentStaffManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeDGV()
    End Sub

    Private Sub InitializeDGV()
        LoadstaffData()
        ' Additional initialization code if needed
    End Sub

    Private gymStaffControl As ContentStaffManageForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the Form
        gymStaffControl = New ContentStaffManageForm()

        ' Set properties to treat the form like a control
        gymStaffControl.TopLevel = False
        gymStaffControl.FormBorderStyle = FormBorderStyle.None
        gymStaffControl.Dock = DockStyle.Fill

        ' Add the form to a panel (or other container) in the main form
        Me.Controls.Add(gymStaffControl)
        gymStaffControl.Visible = False
    End Sub

    ' Button click event to show the form
    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaff.Click
        gymStaffControl.Location = New Point(100, 200)

        ' Set the size of the form
        gymStaffControl.Size = New Size(405, 486)

        gymStaffControl.BringToFront()
        gymStaffControl.Visible = True
        Debug.WriteLine("Gym_Staff control is now visible.")
    End Sub
End Class
