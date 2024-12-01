Imports Org.BouncyCastle.Asn1.Cmp

Public Class ContentPayment
    Private Sub LoadPaymentData()
        Dim query As String = "SELECT p.PaymentID, p.MemberID, p.ReservationFee, p.MembershipCost, p.PaymentDate, p.Amount, p.PaymentMethod, p.PaymentStatus, p.InvoiceNumber, p.PaymentDescription, p.DiscountApplied, p.TaxAmount, p.TotalAmount, p.ReceiptNumber, p.PaymentNotes, p.MembershipID, m.Status AS MemberStatus " &
                          "FROM payment p " &
                          "JOIN members m ON p.MemberID = m.MemberID"
        LoadToDGV(query, dgvPayment)
        SetDGVProperties(dgvPayment)
    End Sub

    Private Sub SetDGVProperties(dgv As DataGridView)
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

        AddEditAndDeleteButtons(dgv)
        RenameColumns(dgv)
        ApplyConditionalDisplay(dgv)
    End Sub


    Private Sub AddEditAndDeleteButtons(dgv As DataGridView)
        ' Add Make Payment button
        If dgv.Columns("MakePayment") Is Nothing Then
            Dim makePaymentButtonColumn As New DataGridViewButtonColumn()
            makePaymentButtonColumn.Name = "MakePayment"
            makePaymentButtonColumn.HeaderText = "Make Payment"
            makePaymentButtonColumn.Text = "Make Payment"
            makePaymentButtonColumn.UseColumnTextForButtonValue = True
            makePaymentButtonColumn.FlatStyle = FlatStyle.Flat
            makePaymentButtonColumn.DefaultCellStyle.BackColor = Color.Transparent
            dgv.Columns.Insert(0, makePaymentButtonColumn)
        End If

        ' Add Delete button
        If dgv.Columns("Delete") Is Nothing Then
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            deleteButtonColumn.FlatStyle = FlatStyle.Flat
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Transparent
            dgv.Columns.Insert(1, deleteButtonColumn)
        End If
    End Sub


    Private Sub RenameColumns(dgv As DataGridView)
        dgv.Columns("PaymentID").HeaderText = "Payment #"
        dgv.Columns("MemberID").HeaderText = "Member ID"
        dgv.Columns("ReservationFee").HeaderText = "Reservation Fee"
        dgv.Columns("MembershipCost").HeaderText = "Membership Cost"
        dgv.Columns("PaymentDate").HeaderText = "Payment Date"
        dgv.Columns("Amount").HeaderText = "Amount"
        dgv.Columns("PaymentMethod").HeaderText = "Payment Method"
        dgv.Columns("PaymentStatus").HeaderText = "Payment Status"
        dgv.Columns("InvoiceNumber").HeaderText = "Invoice #"
        dgv.Columns("PaymentDescription").HeaderText = "Description"
        dgv.Columns("DiscountApplied").HeaderText = "Discount"
        dgv.Columns("TaxAmount").HeaderText = "Tax"
        dgv.Columns("TotalAmount").HeaderText = "Total"
        dgv.Columns("ReceiptNumber").HeaderText = "Receipt #"
        dgv.Columns("PaymentNotes").HeaderText = "Notes"
        dgv.Columns("MembershipID").HeaderText = "Membership ID"
    End Sub
    Private Sub ApplyConditionalDisplay(dgv As DataGridView)
        If cmbPaymentType IsNot Nothing AndAlso cmbPaymentType.SelectedItem IsNot Nothing Then
            If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                dgv.Columns("ReservationFee").Visible = True
                dgv.Columns("MembershipCost").Visible = False
                dgv.Columns("MembershipID").Visible = False
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Paid")
                cmbStatus.Items.Add("Unpaid")
            ElseIf cmbPaymentType.SelectedItem.ToString() = "Membership" Then
                dgv.Columns("ReservationFee").Visible = False
                dgv.Columns("MembershipCost").Visible = True
                dgv.Columns("MembershipID").Visible = True
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Active")
                cmbStatus.Items.Add("Inactive")
            End If
        End If
    End Sub

    Private Sub dgvPayment_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPayment.CellFormatting
        If e.ColumnIndex = dgvPayment.Columns("MakePayment").Index Then
            Dim memberStatus As String = dgvPayment.Rows(e.RowIndex).Cells("MemberStatus").Value.ToString()
            Dim paymentStatus As String = dgvPayment.Rows(e.RowIndex).Cells("PaymentStatus").Value.ToString()
            If memberStatus <> "0" AndAlso paymentStatus <> "Unpaid" Then
                e.Value = "" ' Hide the button by setting its value to an empty string
                e.FormattingApplied = True
            End If
        End If
    End Sub


    Private Sub cmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentType.SelectedIndexChanged
        ApplyConditionalDisplay(dgvPayment)
    End Sub


    Private Sub InitializeDGV()
        LoadPaymentData()
        ' Additional initialization code if needed
    End Sub

    Private Sub ContentPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeDGV()
        ApplyConditionalDisplay(dgvPayment)
    End Sub
End Class
