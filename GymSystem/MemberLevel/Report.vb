Public Class Report
    ' Set up the DataGridView for displaying reports
    Private Sub SetupMemberReportGrid()
        ' Clear existing columns and rows
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        ' Define column headers
        DataGridView1.ColumnCount = 6
        DataGridView1.Columns(0).Name = "Member ID"
        DataGridView1.Columns(1).Name = "Service Taken"
        DataGridView1.Columns(2).Name = "My Plans (Up To)"
        DataGridView1.Columns(3).Name = "Address"
        DataGridView1.Columns(4).Name = "Charge"
        DataGridView1.Columns(5).Name = "Attendance Count"

        ' Style the DataGridView
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .RowTemplate.Height = 60
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

End Class
