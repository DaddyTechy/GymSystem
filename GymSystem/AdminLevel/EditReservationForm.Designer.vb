<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditReservationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblEquipment = New Label()
        cmbEquipment = New ComboBox()
        lblStaff = New Label()
        cmbStaff = New ComboBox()
        lblReservationDate = New Label()
        dtpReservationDate = New DateTimePicker()
        lblStartTime = New Label()
        dtpStartTime = New DateTimePicker()
        lblEndTime = New Label()
        dtpEndTime = New DateTimePicker()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        lblPurpose = New Label()
        txtPurpose = New TextBox()
        lblNotes = New Label()
        txtNotes = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblEquipment
        ' 
        lblEquipment.AutoSize = True
        lblEquipment.ForeColor = SystemColors.ButtonHighlight
        lblEquipment.Location = New Point(14, 17)
        lblEquipment.Margin = New Padding(4, 0, 4, 0)
        lblEquipment.Name = "lblEquipment"
        lblEquipment.Size = New Size(68, 15)
        lblEquipment.TabIndex = 0
        lblEquipment.Text = "Equipment:"
        ' 
        ' cmbEquipment
        ' 
        cmbEquipment.FormattingEnabled = True
        cmbEquipment.Location = New Point(144, 14)
        cmbEquipment.Margin = New Padding(4, 3, 4, 3)
        cmbEquipment.Name = "cmbEquipment"
        cmbEquipment.Size = New Size(290, 23)
        cmbEquipment.TabIndex = 1
        ' 
        ' lblStaff
        ' 
        lblStaff.AutoSize = True
        lblStaff.ForeColor = SystemColors.ButtonHighlight
        lblStaff.Location = New Point(14, 48)
        lblStaff.Margin = New Padding(4, 0, 4, 0)
        lblStaff.Name = "lblStaff"
        lblStaff.Size = New Size(34, 15)
        lblStaff.TabIndex = 2
        lblStaff.Text = "Staff:"
        ' 
        ' cmbStaff
        ' 
        cmbStaff.FormattingEnabled = True
        cmbStaff.Location = New Point(144, 45)
        cmbStaff.Margin = New Padding(4, 3, 4, 3)
        cmbStaff.Name = "cmbStaff"
        cmbStaff.Size = New Size(290, 23)
        cmbStaff.TabIndex = 3
        ' 
        ' lblReservationDate
        ' 
        lblReservationDate.AutoSize = True
        lblReservationDate.ForeColor = SystemColors.ButtonHighlight
        lblReservationDate.Location = New Point(14, 83)
        lblReservationDate.Margin = New Padding(4, 0, 4, 0)
        lblReservationDate.Name = "lblReservationDate"
        lblReservationDate.Size = New Size(98, 15)
        lblReservationDate.TabIndex = 4
        lblReservationDate.Text = "Reservation Date:"
        ' 
        ' dtpReservationDate
        ' 
        dtpReservationDate.Location = New Point(144, 76)
        dtpReservationDate.Margin = New Padding(4, 3, 4, 3)
        dtpReservationDate.Name = "dtpReservationDate"
        dtpReservationDate.Size = New Size(290, 23)
        dtpReservationDate.TabIndex = 5
        ' 
        ' lblStartTime
        ' 
        lblStartTime.AutoSize = True
        lblStartTime.ForeColor = SystemColors.ButtonHighlight
        lblStartTime.Location = New Point(14, 113)
        lblStartTime.Margin = New Padding(4, 0, 4, 0)
        lblStartTime.Name = "lblStartTime"
        lblStartTime.Size = New Size(64, 15)
        lblStartTime.TabIndex = 6
        lblStartTime.Text = "Start Time:"
        ' 
        ' dtpStartTime
        ' 
        dtpStartTime.Format = DateTimePickerFormat.Time
        dtpStartTime.Location = New Point(144, 106)
        dtpStartTime.Margin = New Padding(4, 3, 4, 3)
        dtpStartTime.Name = "dtpStartTime"
        dtpStartTime.ShowUpDown = True
        dtpStartTime.Size = New Size(290, 23)
        dtpStartTime.TabIndex = 7
        ' 
        ' lblEndTime
        ' 
        lblEndTime.AutoSize = True
        lblEndTime.ForeColor = SystemColors.ButtonHighlight
        lblEndTime.Location = New Point(14, 143)
        lblEndTime.Margin = New Padding(4, 0, 4, 0)
        lblEndTime.Name = "lblEndTime"
        lblEndTime.Size = New Size(60, 15)
        lblEndTime.TabIndex = 8
        lblEndTime.Text = "End Time:"
        ' 
        ' dtpEndTime
        ' 
        dtpEndTime.Format = DateTimePickerFormat.Time
        dtpEndTime.Location = New Point(144, 136)
        dtpEndTime.Margin = New Padding(4, 3, 4, 3)
        dtpEndTime.Name = "dtpEndTime"
        dtpEndTime.ShowUpDown = True
        dtpEndTime.Size = New Size(290, 23)
        dtpEndTime.TabIndex = 9
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.ForeColor = SystemColors.ButtonHighlight
        lblStatus.Location = New Point(14, 174)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(42, 15)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status:"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Ongoing", "Completed", "Cancelled"})
        cmbStatus.Location = New Point(144, 171)
        cmbStatus.Margin = New Padding(4, 3, 4, 3)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(290, 23)
        cmbStatus.TabIndex = 11
        ' 
        ' lblPurpose
        ' 
        lblPurpose.AutoSize = True
        lblPurpose.ForeColor = SystemColors.ButtonHighlight
        lblPurpose.Location = New Point(14, 205)
        lblPurpose.Margin = New Padding(4, 0, 4, 0)
        lblPurpose.Name = "lblPurpose"
        lblPurpose.Size = New Size(81, 15)
        lblPurpose.TabIndex = 12
        lblPurpose.Text = "Training Type:"
        ' 
        ' txtPurpose
        ' 
        txtPurpose.Location = New Point(144, 202)
        txtPurpose.Margin = New Padding(4, 3, 4, 3)
        txtPurpose.Name = "txtPurpose"
        txtPurpose.Size = New Size(290, 23)
        txtPurpose.TabIndex = 13
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.ForeColor = SystemColors.ButtonHighlight
        lblNotes.Location = New Point(14, 235)
        lblNotes.Margin = New Padding(4, 0, 4, 0)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(41, 15)
        lblNotes.TabIndex = 14
        lblNotes.Text = "Notes:"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(144, 232)
        txtNotes.Margin = New Padding(4, 3, 4, 3)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(290, 69)
        txtNotes.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Gold
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(252, 308)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 27)
        btnSave.TabIndex = 16
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gold
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(346, 308)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(88, 27)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditReservationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(448, 348)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtNotes)
        Controls.Add(lblNotes)
        Controls.Add(txtPurpose)
        Controls.Add(lblPurpose)
        Controls.Add(cmbStatus)
        Controls.Add(lblStatus)
        Controls.Add(dtpEndTime)
        Controls.Add(lblEndTime)
        Controls.Add(dtpStartTime)
        Controls.Add(lblStartTime)
        Controls.Add(dtpReservationDate)
        Controls.Add(lblReservationDate)
        Controls.Add(cmbStaff)
        Controls.Add(lblStaff)
        Controls.Add(cmbEquipment)
        Controls.Add(lblEquipment)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditReservationForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Reservation"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblEquipment As Label
    Friend WithEvents cmbEquipment As ComboBox
    Friend WithEvents lblStaff As Label
    Friend WithEvents cmbStaff As ComboBox
    Friend WithEvents lblReservationDate As Label
    Friend WithEvents dtpReservationDate As DateTimePicker
    Friend WithEvents lblStartTime As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblEndTime As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblPurpose As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
