Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class ContentPayment
    Private currentOffset As Integer = 0
    Private Const batchSize As Integer = 25

    Private Sub LoadPaymentData(Optional memberId As Integer = 0)
        Dim whereClause As String = "1=1"
        If memberId > 0 Then
            whereClause = $"p.MemberID = {memberId}"
        End If

        ' Corrected query with proper LIMIT and OFFSET placement
        Dim query As String = $"SELECT p.PaymentID, p.MemberID, CONCAT(m.FirstName, ' ', m.LastName) AS MemberName, " &
              "IF(p.MembershipCost > 0, IF(p.PaymentDescription IS NULL OR p.PaymentDescription = '', 'Membership Fee', p.PaymentDescription), 'Reservation Fee') AS Description, " &
              "p.ReservationFee, p.MembershipCost, p.PaymentDate, p.Amount, p.PaymentMethod, p.PaymentStatus, p.InvoiceNumber, p.PaymentDescription, p.DiscountApplied, p.TaxAmount, p.TotalAmount, p.ReceiptNumber, p.PaymentNotes " &
              "FROM payment p " &
              "JOIN members m ON p.MemberID = m.MemberID " &
              $"WHERE {whereClause} " &
              $"LIMIT {batchSize} OFFSET {currentOffset}"

        dgvPayment.SuspendLayout()
        Try
            ' Load data to DataGridView
            LoadToDGV(query, dgvPayment)
            ' Set DataGridView properties and formatting
            UIUtils.FormatAndStyleDGV(dgvPayment)
        Finally
            dgvPayment.ResumeLayout()
        End Try
    End Sub


    Private Sub dgvPayment_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPayment.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = dgvPayment.HitTest(e.X, e.Y)
            If hti.RowIndex >= 0 Then
                dgvPayment.ClearSelection()
                dgvPayment.Rows(hti.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub ViewReceipt_Click(sender As Object, e As EventArgs)
        If dgvPayment.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPayment.SelectedRows(0)
            Dim paymentStatus As String = selectedRow.Cells("PaymentStatus").Value.ToString()

            ' Check if the payment status is "Paid"
            If paymentStatus = "Paid" Then
                Dim paymentMethod As String = selectedRow.Cells("PaymentMethod").Value.ToString()
                Dim paymentDate As DateTime = Convert.ToDateTime(selectedRow.Cells("PaymentDate").Value)
                Dim subTotal As Decimal = Convert.ToDecimal(selectedRow.Cells("Amount").Value)
                Dim invoiceNumber As String = selectedRow.Cells("InvoiceNumber").Value.ToString()
                Dim receiptNumber As String = selectedRow.Cells("ReceiptNumber").Value.ToString()
                Dim discountApplied As Decimal = Convert.ToDecimal(selectedRow.Cells("DiscountApplied").Value)
                Dim taxAmount As Decimal = Convert.ToDecimal(selectedRow.Cells("TaxAmount").Value)
                Dim totalAmount As Decimal = Convert.ToDecimal(selectedRow.Cells("TotalAmount").Value)
                Dim paymentNotes As String = selectedRow.Cells("PaymentNotes").Value.ToString()
                Dim memberID As Integer = Convert.ToInt32(selectedRow.Cells("MemberID").Value)
                Dim memberName As String = selectedRow.Cells("MemberName").Value.ToString()

                ' Get member credentials
        

                ' Show the receipt form
                Dim membershipCost As Decimal = If(Not IsDBNull(selectedRow.Cells("MembershipCost").Value), Convert.ToDecimal(selectedRow.Cells("MembershipCost").Value), 0D)

                Dim itemType As String
                If membershipCost > 0 Then
                    itemType = "Membership"
                Else
                    itemType = "Reservation"
                End If

                Dim receiptForm As New PaymentReceipt(paymentMethod, paymentDate, subTotal, invoiceNumber, receiptNumber, discountApplied, taxAmount, totalAmount, paymentNotes, memberID, memberName, itemType)
                receiptForm.ShowDialog()
            Else
                MessageBox.Show("Receipt is only available for completed payments.", "Receipt Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub MarkAsPaid_Click(sender As Object, e As EventArgs)
        If dgvPayment.SelectedRows.Count > 0 Then
            Dim paymentID As Integer = Convert.ToInt32(dgvPayment.SelectedRows(0).Cells("PaymentID").Value)
            Dim paymentStatus As String = dgvPayment.SelectedRows(0).Cells("PaymentStatus").Value.ToString()

            If paymentStatus <> "Paid" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to mark this payment as paid?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    UpdateConnectionString()
                    conn = New MySqlConnection(strConnection)
                    Try
                        conn.Open()
                        Dim query As String = "UPDATE payment SET PaymentStatus = 'Paid' WHERE PaymentID = @PaymentID"
                        Dim cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@PaymentID", paymentID)
                        cmd.ExecuteNonQuery()
                        LoadPaymentData() ' Refresh data
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while updating the payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        conn.Close()
                    End Try
                End If
            Else
                MessageBox.Show("This payment is already marked as paid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub DeletePayment_Click(sender As Object, e As EventArgs)
        If dgvPayment.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPayment.SelectedRows(0)
            Dim paymentID As Integer = Convert.ToInt32(selectedRow.Cells("PaymentID").Value)

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this payment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Delete the payment from the database
                DeletePayment(paymentID)
                ' Remove the row from the DataGridView
                dgvPayment.Rows.Remove(selectedRow)
            End If
        End If
    End Sub

    Private Sub RenameColumns(dgv As DataGridView)
        ' Rename columns for clarity
        If dgv.Columns.Contains("MemberName") Then dgv.Columns("MemberName").HeaderText = "Member Name"
        If dgv.Columns.Contains("PaymentDate") Then dgv.Columns("PaymentDate").HeaderText = "Date"
        If dgv.Columns.Contains("TotalAmount") Then dgv.Columns("TotalAmount").HeaderText = "Total Amount"
        If dgv.Columns.Contains("PaymentStatus") Then dgv.Columns("PaymentStatus").HeaderText = "Status"
        If dgv.Columns.Contains("PaymentMethod") Then dgv.Columns("PaymentMethod").HeaderText = "Method"
        If dgv.Columns.Contains("ReservationFee") Then dgv.Columns("ReservationFee").HeaderText = "Reservation Fee"
        If dgv.Columns.Contains("MembershipCost") Then dgv.Columns("MembershipCost").HeaderText = "Membership Cost"

        ' Hide columns that are not needed for the main view
        Dim columnsToHide As New List(Of String) From {"PaymentID", "MemberID", "Amount", "InvoiceNumber", "PaymentDescription", "DiscountApplied", "TaxAmount", "ReceiptNumber", "PaymentNotes"}
        For Each colName As String In columnsToHide
            If dgv.Columns.Contains(colName) Then
                dgv.Columns(colName).Visible = False
            End If
        Next
    End Sub
    Private Sub ApplyConditionalDisplay(dgv As DataGridView)
        If cmbPaymentType IsNot Nothing AndAlso cmbPaymentType.SelectedItem IsNot Nothing Then
            If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                dgv.Columns("ReservationFee").Visible = True
                dgv.Columns("MembershipCost").Visible = False
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Paid")
                cmbStatus.Items.Add("Unpaid")
            ElseIf cmbPaymentType.SelectedItem.ToString() = "Membership" Then
                dgv.Columns("ReservationFee").Visible = False
                dgv.Columns("MembershipCost").Visible = True
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Active")
                cmbStatus.Items.Add("Inactive")
            ElseIf cmbPaymentType.SelectedItem.ToString() = "All" Then
                dgv.Columns("ReservationFee").Visible = True
                dgv.Columns("MembershipCost").Visible = True
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Paid")
                cmbStatus.Items.Add("Unpaid")
                cmbStatus.Items.Add("Active")
                cmbStatus.Items.Add("Inactive")
            End If
        End If
    End Sub


    Private Sub dgvPayment_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPayment.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvPayment.Columns("PaymentStatus").Index Then
            If e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString()
                Select Case status
                    Case "Paid", "Active"
                        e.CellStyle.BackColor = Color.FromArgb(20, 80, 40) ' Dark Green
                        e.CellStyle.ForeColor = Color.White
                    Case "Unpaid", "Inactive"
                        e.CellStyle.BackColor = Color.FromArgb(100, 20, 20) ' Dark Red
                        e.CellStyle.ForeColor = Color.White
                    Case Else
                        e.CellStyle.BackColor = dgvPayment.DefaultCellStyle.BackColor
                        e.CellStyle.ForeColor = dgvPayment.DefaultCellStyle.ForeColor
                End Select
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim contextMenu = CType(sender, ContextMenuStrip)
        Dim dgv = CType(contextMenu.SourceControl, DataGridView)

        If dgv.SelectedRows.Count = 0 Then
            e.Cancel = True
            Return
        End If

        Dim selectedRow = dgv.SelectedRows(0)
        Dim paymentStatus = selectedRow.Cells("PaymentStatus").Value.ToString()
        Dim paymentMethod = selectedRow.Cells("PaymentMethod").Value

        Dim markAsPaidItem = contextMenu.Items.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Text = "Mark as Paid")
        Dim markAsUnpaidItem = contextMenu.Items.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Text = "Mark as Unpaid")
        Dim makePaymentItem = contextMenu.Items.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Text = "Make Payment")

        If markAsPaidItem IsNot Nothing Then markAsPaidItem.Enabled = (paymentStatus = "Unpaid")
        If makePaymentItem IsNot Nothing Then makePaymentItem.Enabled = (paymentStatus = "Unpaid")
        If markAsUnpaidItem IsNot Nothing Then
            markAsUnpaidItem.Enabled = (paymentStatus = "Paid" AndAlso (paymentMethod Is DBNull.Value OrElse String.IsNullOrEmpty(paymentMethod.ToString())))
        End If
    End Sub

    Private Sub MarkAsUnpaid_Click(sender As Object, e As EventArgs)
        If dgvPayment.SelectedRows.Count > 0 Then
            Dim paymentID As Integer = Convert.ToInt32(dgvPayment.SelectedRows(0).Cells("PaymentID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to mark this payment as unpaid?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                UpdateConnectionString()
                conn = New MySqlConnection(strConnection)
                Try
                    conn.Open()
                    Dim query As String = "UPDATE payment SET PaymentStatus = 'Unpaid' WHERE PaymentID = @PaymentID"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID)
                    cmd.ExecuteNonQuery()
                    LoadPaymentData() ' Refresh data
                Catch ex As Exception
                    MessageBox.Show("An error occurred while updating the payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub MakePayment_Click(sender As Object, e As EventArgs)
        If dgvPayment.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPayment.SelectedRows(0)
            Dim paymentStatus As String = selectedRow.Cells("PaymentStatus").Value.ToString()

            If paymentStatus = "Unpaid" Then
                Dim paymentID As Integer = Convert.ToInt32(selectedRow.Cells("PaymentID").Value)
                Dim memberID As Integer = Convert.ToInt32(selectedRow.Cells("MemberID").Value)
                Dim membershipCost As Decimal = If(Not IsDBNull(selectedRow.Cells("MembershipCost").Value), Convert.ToDecimal(selectedRow.Cells("MembershipCost").Value), 0D)
                Dim reservationFee As Decimal = If(Not IsDBNull(selectedRow.Cells("ReservationFee").Value), Convert.ToDecimal(selectedRow.Cells("ReservationFee").Value), 0D)

                Dim fee As Decimal = 0
                Dim isMembership As Boolean = False

                If membershipCost > 0 Then
                    fee = membershipCost
                    isMembership = True
                Else
                    fee = reservationFee
                    isMembership = False
                End If

                ' Create a new form to host the BillingPaymentForm
                Dim paymentHostForm As New Form With {
                    .Text = "Make Payment",
                    .StartPosition = FormStartPosition.CenterScreen,
                    .ClientSize = New Size(500, 600) ' Adjust size as needed
                }

                ' Create the payment control
                Dim paymentControl As New BillingPaymentForm(fee, isMembership, paymentID, memberID)
                paymentControl.Dock = DockStyle.Fill

                ' Add the control to the form
                paymentHostForm.Controls.Add(paymentControl)

                ' Handle the PaymentCompleted event to refresh data
                AddHandler paymentControl.PaymentCompleted, Sub(s, args)
                                                                paymentHostForm.Close()
                                                                LoadPaymentData()
                                                            End Sub

                ' Show the form modally
                paymentHostForm.ShowDialog()
            Else
                MessageBox.Show("This payment has already been paid.", "Payment Processed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub FilterPayments()
        Dim filter As String = ""

        ' Filter by PaymentType
        If cmbPaymentType.SelectedItem IsNot Nothing Then
            If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                filter = "ReservationFee >= 0 "
            ElseIf cmbPaymentType.SelectedItem.ToString() = "Membership" Then
                filter = "MembershipCost >= 0"
            End If
        End If

        ' Filter by Status
        If cmbStatus.SelectedItem IsNot Nothing Then
            If filter <> "" Then
                filter &= " AND "
            End If
            If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                filter &= $"PaymentStatus = '{cmbStatus.SelectedItem.ToString()}'"
            ElseIf cmbPaymentType.SelectedItem.ToString() = "Membership" Then
                If cmbStatus.SelectedItem.ToString() = "Active" Then
                    filter &= "MembershipCost > 0"
                ElseIf cmbStatus.SelectedItem.ToString() = "Inactive" Then
                    filter &= "MembershipCost = 0"
                End If
            End If
        End If

        ' Apply the filter to the DataGridView
        Dim dv As DataView = CType(dgvPayment.DataSource, DataTable).DefaultView
        dv.RowFilter = filter
    End Sub

    Private Sub cmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentType.SelectedIndexChanged
        ApplyConditionalDisplay(dgvPayment)
        FilterPayments()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        FilterPayments()
    End Sub




    Private Sub InitializeDGV()
        LoadPaymentData() ' Load all data initially
        ' Additional initialization code if needed
    End Sub

    Private Sub ContentPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeContextMenu()
        LoadMembers()
        InitializeDGV()
        ApplyConditionalDisplay(dgvPayment)
        cmbPaymentType.SelectedItem = "All"
        cmbStatus.SelectedItem = "Paid"
        MemberFiltercmb.SelectedIndex = -1 ' Clear initial selection
    End Sub

    Private Sub InitializeContextMenu()
        Dim paymentContextMenu As New ContextMenuStrip()

        ' Create menu items
        Dim viewReceiptItem As New ToolStripMenuItem("View Receipt")
        Dim makePaymentItem As New ToolStripMenuItem("Make Payment")
        Dim markAsPaidItem As New ToolStripMenuItem("Mark as Paid")
        Dim markAsUnpaidItem As New ToolStripMenuItem("Mark as Unpaid")
        Dim deletePaymentItem As New ToolStripMenuItem("Delete")

        ' Add items to the context menu
        paymentContextMenu.Items.Add(viewReceiptItem)
        paymentContextMenu.Items.Add(makePaymentItem)
        paymentContextMenu.Items.Add(New ToolStripSeparator())
        paymentContextMenu.Items.Add(markAsPaidItem)
        paymentContextMenu.Items.Add(markAsUnpaidItem)
        paymentContextMenu.Items.Add(New ToolStripSeparator())
        paymentContextMenu.Items.Add(deletePaymentItem)

        ' Add event handlers for the menu items
        AddHandler viewReceiptItem.Click, AddressOf ViewReceipt_Click
        AddHandler makePaymentItem.Click, AddressOf MakePayment_Click
        AddHandler markAsPaidItem.Click, AddressOf MarkAsPaid_Click
        AddHandler markAsUnpaidItem.Click, AddressOf MarkAsUnpaid_Click
        AddHandler deletePaymentItem.Click, AddressOf DeletePayment_Click
        AddHandler paymentContextMenu.Opening, AddressOf ContextMenuStrip_Opening

        ' Assign the context menu to the DataGridView
        dgvPayment.ContextMenuStrip = paymentContextMenu
    End Sub

    Private Sub LoadMembers()
        Try
            UpdateConnectionString()
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim query As String = "SELECT MIN(MemberID) as MemberID, CONCAT(FirstName, ' ', LastName) AS MemberName FROM members GROUP BY MemberName ORDER BY MemberName"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Add a 'Show All' row
                Dim allRow As DataRow = dt.NewRow()
                allRow("MemberID") = 0 ' Or -1, a value that won't exist as a real MemberID
                allRow("MemberName") = "Show All"
                dt.Rows.InsertAt(allRow, 0)

                MemberFiltercmb.DataSource = dt
                MemberFiltercmb.DropDownStyle = ComboBoxStyle.DropDown ' Allow typing for AutoComplete
                MemberFiltercmb.DisplayMember = "MemberName"
                MemberFiltercmb.ValueMember = "MemberID"

                ' Configure AutoComplete
                MemberFiltercmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                MemberFiltercmb.AutoCompleteSource = AutoCompleteSource.ListItems
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading members: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayment.CellContentClick
        ' This event handler is deprecated as button columns have been replaced by a context menu.
    End Sub




    Private Sub DeletePayment(paymentID As Integer)
        ' Implement logic to delete the payment
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete payment with ID: {paymentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = $"DELETE FROM payment WHERE PaymentID = {paymentID}"
            readQuery(query)
            ' Refresh the DataGridView
            InitializeDGV()
        End If
    End Sub


    Private Sub OnBillingPaymentFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Handle any actions needed after the BillingPaymentForm is closed
        Debug.WriteLine("Debug: BillingPaymentForm closed.")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentOffset += batchSize
        Dim selectedMemberId As Integer = 0
        If MemberFiltercmb.SelectedValue IsNot Nothing AndAlso Integer.TryParse(MemberFiltercmb.SelectedValue.ToString(), selectedMemberId) Then
            ' A member is selected, use their ID
        End If
        LoadPaymentData(selectedMemberId)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentOffset >= batchSize Then
            currentOffset -= batchSize
        Else
            currentOffset = 0
        End If
        Dim selectedMemberId As Integer = 0
        If MemberFiltercmb.SelectedValue IsNot Nothing AndAlso Integer.TryParse(MemberFiltercmb.SelectedValue.ToString(), selectedMemberId) Then
            ' A member is selected, use their ID
        End If
        LoadPaymentData(selectedMemberId)
    End Sub

    Private Sub dgvPayment_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvPayment.SortCompare
        ' Check if we are sorting a numeric column that should be treated as such.
        If e.Column.Name = "ReservationFee" Or e.Column.Name = "MembershipCost" Or e.Column.Name = "TotalAmount" Then
            Dim val1 As Decimal
            Dim val2 As Decimal

            ' Safely parse the values to decimals for comparison.
            Decimal.TryParse(If(e.CellValue1 IsNot Nothing, e.CellValue1.ToString(), "0"), val1)
            Decimal.TryParse(If(e.CellValue2 IsNot Nothing, e.CellValue2.ToString(), "0"), val2)

            ' Compare the numeric values.
            e.SortResult = val1.CompareTo(val2)

            ' Indicate that the sorting for this column has been handled.
            e.Handled = True
        End If
    End Sub

    Private Sub MemberFiltercmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MemberFiltercmb.SelectedIndexChanged
        Dim selectedMemberId As Integer = 0
        If MemberFiltercmb.SelectedValue IsNot Nothing AndAlso Integer.TryParse(MemberFiltercmb.SelectedValue.ToString(), selectedMemberId) Then
            currentOffset = 0 ' Reset pagination
            LoadPaymentData(selectedMemberId)
        End If
    End Sub


End Class

Public Class DataGridViewDisableButtonColumn
    Inherits DataGridViewButtonColumn

    Public Sub New()
        MyBase.New()
        Me.CellTemplate = New DataGridViewDisableButtonCell()
    End Sub
End Class

Public Class DataGridViewDisableButtonCell
    Inherits DataGridViewButtonCell

    Private enabledValue As Boolean

    Public Property Enabled As Boolean
        Get
            Return enabledValue
        End Get
        Set(value As Boolean)
            If enabledValue = value Then Return
            enabledValue = value
            ' Force the cell to be re-painted
            If DataGridView IsNot Nothing Then DataGridView.InvalidateCell(Me)
        End Set
    End Property

    ' Override the Clone method so that the Enabled property is copied.
    Public Overrides Function Clone() As Object
        Dim cell As DataGridViewDisableButtonCell = CType(MyBase.Clone(), DataGridViewDisableButtonCell)
        cell.Enabled = Me.Enabled
        Return cell
    End Function

    ' By default, enable the button cell.
    Public Sub New()
        MyBase.New()
        enabledValue = True
    End Sub

    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, elementState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        ' The button cell is disabled, so paint the border, background, and disabled button for the cell.
        If Not enabledValue Then
            ' Draw the cell background, if specified.
            If (paintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
                Using cellBackground As New SolidBrush(cellStyle.BackColor)
                    graphics.FillRectangle(cellBackground, cellBounds)
                End Using
            End If

            ' Draw the cell borders, if specified.
            If (paintParts And DataGridViewPaintParts.Border) = DataGridViewPaintParts.Border Then
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
            End If

            ' Calculate the area in which to draw the button.
            Dim buttonArea As Rectangle = cellBounds
            Dim buttonAdjustment As Rectangle = BorderWidths(advancedBorderStyle)
            buttonArea.X += buttonAdjustment.X
            buttonArea.Y += buttonAdjustment.Y
            buttonArea.Height -= buttonAdjustment.Height
            buttonArea.Width -= buttonAdjustment.Width

            ' Draw the disabled button.
            ButtonRenderer.DrawButton(graphics, buttonArea, PushButtonState.Disabled)

            ' Draw the disabled button text.
            Dim formattedValueString As String = TryCast(formattedValue, String)
            If formattedValueString IsNot Nothing Then
                TextRenderer.DrawText(graphics, formattedValueString, DataGridView.Font, buttonArea, SystemColors.GrayText, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            End If
        Else
            ' The button cell is enabled, so let the base class handle the painting.
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        End If
    End Sub
End Class


