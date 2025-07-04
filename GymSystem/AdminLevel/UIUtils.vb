Imports System.Drawing
Imports System.Windows.Forms

Public Module UIUtils
    Public Sub FormatAndStyleDGV(ByVal dgv As DataGridView)
        ' Set properties to make the table look fuller and more modern
        Dim parentBackgroundColor As Color = Color.FromArgb(40, 40, 40)
        dgv.BackgroundColor = Color.FromArgb(20, 20, 20)
        dgv.DefaultCellStyle.ForeColor = Color.White
        dgv.DefaultCellStyle.BackColor = parentBackgroundColor
        dgv.ColumnHeadersDefaultCellStyle.BackColor = parentBackgroundColor
        dgv.RowHeadersDefaultCellStyle.BackColor = parentBackgroundColor
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.BorderStyle = BorderStyle.None
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        ' Set fonts for a fuller look
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        columnHeaderStyle.BackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        columnHeaderStyle.ForeColor = Color.White
        columnHeaderStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        columnHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        columnHeaderStyle.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle

        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        cellStyle.BackColor = Color.FromArgb(40, 40, 40)
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10.0F)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = SystemColors.Highlight
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.WrapMode = DataGridViewTriState.False
        dgv.DefaultCellStyle = cellStyle

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.Dock = DockStyle.Fill
        dgv.EnableHeadersVisualStyles = False
        dgv.GridColor = Color.FromArgb(60, 60, 60)
        dgv.MultiSelect = False
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Apply color formatting for status columns if they exist
        If dgv.Columns.Contains("Status") Then
            AddHandler dgv.CellFormatting, Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)
                                                If e.ColumnIndex = dgv.Columns("Status").Index AndAlso e.Value IsNot Nothing Then
                                                    Dim status As String = e.Value.ToString()
                                                    Select Case status
                                                        Case "Operational", "Paid"
                                                            e.CellStyle.ForeColor = Color.LightGreen
                                                        Case "Out of Order", "Unpaid"
                                                            e.CellStyle.ForeColor = Color.Salmon
                                                        Case "Under Maintenance"
                                                            e.CellStyle.ForeColor = Color.Khaki
                                                    End Select
                                                End If
                                            End Sub
        End If

        If dgv.Columns.Contains("PaymentStatus") Then
            AddHandler dgv.CellFormatting, Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)
                                                If e.ColumnIndex = dgv.Columns("PaymentStatus").Index AndAlso e.Value IsNot Nothing Then
                                                    Dim status As String = e.Value.ToString()
                                                    Select Case status
                                                        Case "Paid"
                                                            e.CellStyle.ForeColor = Color.LightGreen
                                                        Case "Unpaid"
                                                            e.CellStyle.ForeColor = Color.Salmon
                                                    End Select
                                                End If
                                            End Sub
        End If
    End Sub
End Module
