Imports System.Windows.Forms.VisualStyles
Imports Org.BouncyCastle.Asn1.Cmp

Public Class ContentPayment
    Private Sub LoadPaymentData()
        Dim query As String = "SELECT p.PaymentID, p.MemberID, p.ReservationFee, p.MembershipCost, p.PaymentDate, p.Amount, p.PaymentMethod, p.PaymentStatus, p.InvoiceNumber, p.PaymentDescription, p.DiscountApplied, p.TaxAmount, p.TotalAmount, p.ReceiptNumber, p.PaymentNotes, p.MembershipID " &
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
            Dim makePaymentButtonColumn As New DataGridViewDisableButtonColumn()
            makePaymentButtonColumn.Name = "MakePayment"
            makePaymentButtonColumn.HeaderText = "Make Payment"
            makePaymentButtonColumn.Text = "Make Payment"
            makePaymentButtonColumn.UseColumnTextForButtonValue = True
            makePaymentButtonColumn.FlatStyle = FlatStyle.Standard
            makePaymentButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            dgv.Columns.Insert(0, makePaymentButtonColumn)
        End If

        ' Add Delete button
        If dgv.Columns("Delete") Is Nothing Then
            Dim deleteButtonColumn As New DataGridViewDisableButtonColumn()
            deleteButtonColumn.Name = "Delete"
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            deleteButtonColumn.FlatStyle = FlatStyle.Standard
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Gold
            dgv.Columns.Insert(1, deleteButtonColumn)
        End If
    End Sub


    Private Sub dgvPayment_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPayment.CellFormatting
        Try
            ' Format MakePayment button
            If dgvPayment.Columns.Contains("MakePayment") Then
                If e.ColumnIndex = dgvPayment.Columns("MakePayment").Index Then
                    Dim paymentStatus As String = dgvPayment.Rows(e.RowIndex).Cells("PaymentStatus").Value.ToString()
                    Dim membershipCost As String = dgvPayment.Rows(e.RowIndex).Cells("MembershipCost").Value.ToString()
                    Dim buttonCell As DataGridViewDisableButtonCell = TryCast(dgvPayment.Rows(e.RowIndex).Cells("MakePayment"), DataGridViewDisableButtonCell)

                    If buttonCell IsNot Nothing Then
                        If paymentStatus = "Unpaid" OrElse membershipCost > "0" Then
                            buttonCell.Enabled = True ' Enable the button
                        Else
                            buttonCell.Enabled = False ' Disable the button
                        End If
                        e.FormattingApplied = True
                    End If
                End If
            Else
                Debug.WriteLine("Debug: MakePayment column does not exist.")
            End If
        Catch ex As Exception
            Debug.WriteLine("An error occurred in dgvPayment_CellFormatting: " & ex.Message)
        End Try
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
            ElseIf cmbPaymentType.SelectedItem.ToString() = "All" Then
                dgv.Columns("ReservationFee").Visible = True
                dgv.Columns("MembershipCost").Visible = True
                dgv.Columns("MembershipID").Visible = True
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("Paid")
                cmbStatus.Items.Add("Unpaid")
                cmbStatus.Items.Add("Active")
                cmbStatus.Items.Add("Inactive")
            End If
        End If
    End Sub


    Private Sub dgvPayment_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvPayment.CellPainting

    End Sub


    Private Sub FilterPayments()
        Dim filter As String = ""

        ' Filter by PaymentType
        If cmbPaymentType.SelectedItem IsNot Nothing Then
            If cmbPaymentType.SelectedItem.ToString() = "Reservation" Then
                filter = "Amount >= 0 "
            ElseIf cmbPaymentType.SelectedItem.ToString() = "Membership" Then
                filter = "MembershipCost > 0"
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
        LoadPaymentData()
        ' Additional initialization code if needed
    End Sub

    Private Sub ContentPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        InitializeDGV()
        ApplyConditionalDisplay(dgvPayment)
        cmbPaymentType.SelectedItem = "All"
        FilterPayments()
    End Sub

    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayment.CellContentClick
        Try
            Debug.WriteLine("Debug: CellContentClick event triggered.")
            If e.ColumnIndex = dgvPayment.Columns("MakePayment").Index AndAlso e.RowIndex >= 0 Then
                Debug.WriteLine("Debug: MakePayment button clicked.")
                Dim selectedRow As DataGridViewRow = dgvPayment.Rows(e.RowIndex)
                Dim paymentID As Integer = Convert.ToInt32(selectedRow.Cells("PaymentID").Value)
                Dim memberID As Integer = Convert.ToInt32(selectedRow.Cells("MemberID").Value)
                Dim paymentStatus As String = selectedRow.Cells("PaymentStatus").Value.ToString()

                ' Check if MembershipCost is greater than 0
                Dim isMembership As Boolean = False
                Dim fee As Decimal = 0
                If Not IsDBNull(selectedRow.Cells("MembershipCost").Value) AndAlso Convert.ToDecimal(selectedRow.Cells("MembershipCost").Value) > 0 Then
                    isMembership = True
                    fee = Convert.ToDecimal(selectedRow.Cells("MembershipCost").Value)
                ElseIf Not IsDBNull(selectedRow.Cells("ReservationFee").Value) Then
                    fee = Convert.ToDecimal(selectedRow.Cells("ReservationFee").Value)
                End If

                Debug.WriteLine($"Debug: PaymentID = {paymentID}, MemberID = {memberID}, Fee = {fee}, IsMembership = {isMembership}, PaymentStatus = {paymentStatus}")

                ' Check if the fee is greater than zero and payment status is not "Paid" before opening the BillingPaymentForm
                If fee > 0 AndAlso paymentStatus <> "Paid" Then
                    ' Create a new instance of the BillingPaymentForm with the necessary data
                    Dim paymentForm As New BillingPaymentForm(fee, isMembership, paymentID, memberID)

                    ' Calculate the center point
                    Dim centerX As Integer = (ClientSize.Width - paymentForm.Width) / 2
                    Dim centerY As Integer = (ClientSize.Height - paymentForm.Height) / 2

                    ' Set the location of the BillingPaymentForm to the center
                    paymentForm.Location = New Point(centerX, centerY)

                    ' Add the BillingPaymentForm to the form
                    Controls.Add(paymentForm)
                    paymentForm.BringToFront()
                    InitializeDGV()
                    Debug.WriteLine("Debug: BillingPaymentForm user control added.")
                    Debug.WriteLine($"Debug: Form Amount = {paymentForm.txtAmount.Text}, SubTotal = {paymentForm.txtSubTotal.Text}")
                Else
                    Debug.WriteLine("Debug: Fee is zero or PaymentStatus is Paid, BillingPaymentForm not added.")
                    MessageBox.Show("This payment cannot be made.", "Payment Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf e.ColumnIndex = dgvPayment.Columns("DeletePayment").Index AndAlso e.RowIndex >= 0 Then
                Debug.WriteLine("Debug: DeletePayment button clicked.")
                Dim selectedRow As DataGridViewRow = dgvPayment.Rows(e.RowIndex)
                Dim paymentID As Integer = Convert.ToInt32(selectedRow.Cells("PaymentID").Value)

                ' Confirm deletion
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this payment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' Delete the payment from the database
                    DeletePayment(paymentID)
                    ' Remove the row from the DataGridView
                    dgvPayment.Rows.Remove(selectedRow)
                    Debug.WriteLine("Debug: Payment deleted.")
                Else
                    Debug.WriteLine("Debug: Deletion cancelled.")
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("An error occurred in dgvPayment_CellContentClick: " & ex.Message)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DeletePayment(paymentID As Integer)
        ' Implement logic to delete the payment
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete payment with ID: {paymentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = $"DELETE FROM Payments WHERE PaymentID = {paymentID}"
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
            Dim currentContext As BufferedGraphicsContext = BufferedGraphicsManager.Current

            Using myBuffer As BufferedGraphics = currentContext.Allocate(graphics, cellBounds)
                ' Draw the cell background, if specified.
                If (paintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
                    Using cellBackground As New SolidBrush(cellStyle.BackColor)
                        myBuffer.Graphics.FillRectangle(cellBackground, cellBounds)
                    End Using
                End If

                ' Draw the cell borders, if specified.
                If (paintParts And DataGridViewPaintParts.Border) = DataGridViewPaintParts.Border Then
                    PaintBorder(myBuffer.Graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
                End If

                ' Calculate the area in which to draw the button.
                Dim buttonArea As Rectangle = cellBounds
                Dim buttonAdjustment As Rectangle = BorderWidths(advancedBorderStyle)
                buttonArea.X += buttonAdjustment.X
                buttonArea.Y += buttonAdjustment.Y
                buttonArea.Height -= buttonAdjustment.Height
                buttonArea.Width -= buttonAdjustment.Width

                ' Draw the disabled button.
                ButtonRenderer.DrawButton(myBuffer.Graphics, buttonArea, PushButtonState.Disabled)

                ' Draw the disabled button text.
                Dim formattedValueString As String = TryCast(formattedValue, String)
                If formattedValueString IsNot Nothing Then
                    TextRenderer.DrawText(myBuffer.Graphics, formattedValueString, DataGridView.Font, buttonArea, SystemColors.GrayText, TextFormatFlags.PreserveGraphicsTranslateTransform Or TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                End If

                myBuffer.Render()
            End Using
        Else
            ' The button cell is enabled, so let the base class handle the painting.
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        End If
    End Sub
End Class

