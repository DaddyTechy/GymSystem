Public Class ContentStaffManage
    Private Sub addnewStaffBtn_Click(sender As Object, e As EventArgs) Handles addnewStaffBtn.Click
        Dim newstaffform As New ContentStaffManageForm
        newstaffform.ShowDialog()
    End Sub

    Private Sub LoadstaffData()
        Dim query As String = "SELECT * FROM staff"
        LoadToDGV(query, dgvStafflist)
        SetDGVPropertiesForStaff(dgvStafflist)

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


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStafflist.CellContentClick

    End Sub
End Class

