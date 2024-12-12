<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label10 = New Label()
        cmbTrainer = New ComboBox()
        lblTotalFee = New Label()
        Label9 = New Label()
        Label8 = New Label()
        txtReservationNotes = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        cmbEquipmentType = New ComboBox()
        Label5 = New Label()
        cmbTrainingType = New ComboBox()
        Label4 = New Label()
        dtpEndTime = New DateTimePicker()
        Label2 = New Label()
        dtpStartTime = New DateTimePicker()
        Label1 = New Label()
        Button1 = New Button()
        btnSaveReservation = New Button()
        Label3 = New Label()
        dtpReservationDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(401, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 15)
        Label10.TabIndex = 52
        Label10.Text = "Trainer*"
        ' 
        ' cmbTrainer
        ' 
        cmbTrainer.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrainer.FormattingEnabled = True
        cmbTrainer.Location = New Point(401, 198)
        cmbTrainer.Name = "cmbTrainer"
        cmbTrainer.Size = New Size(148, 23)
        cmbTrainer.TabIndex = 51
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.AutoSize = True
        lblTotalFee.BackColor = Color.White
        lblTotalFee.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFee.ForeColor = Color.Black
        lblTotalFee.Location = New Point(90, 389)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(0, 25)
        lblTotalFee.TabIndex = 50
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(90, 364)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 15)
        Label9.TabIndex = 49
        Label9.Text = "Total Fee:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(90, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 48
        Label8.Text = "Notes"
        ' 
        ' txtReservationNotes
        ' 
        txtReservationNotes.Location = New Point(90, 274)
        txtReservationNotes.Multiline = True
        txtReservationNotes.Name = "txtReservationNotes"
        txtReservationNotes.Size = New Size(292, 78)
        txtReservationNotes.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(428, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 46
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(246, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 15)
        Label6.TabIndex = 45
        Label6.Text = "Equipment Type*"
        ' 
        ' cmbEquipmentType
        ' 
        cmbEquipmentType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEquipmentType.FormattingEnabled = True
        cmbEquipmentType.Location = New Point(246, 198)
        cmbEquipmentType.Name = "cmbEquipmentType"
        cmbEquipmentType.Size = New Size(121, 23)
        cmbEquipmentType.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(90, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 43
        Label5.Text = "Training Type*"
        ' 
        ' cmbTrainingType
        ' 
        cmbTrainingType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrainingType.FormattingEnabled = True
        cmbTrainingType.Items.AddRange(New Object() {"Strength", "Endurance", "Flexibility"})
        cmbTrainingType.Location = New Point(90, 198)
        cmbTrainingType.Name = "cmbTrainingType"
        cmbTrainingType.Size = New Size(121, 23)
        cmbTrainingType.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(446, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 41
        Label4.Text = "End Time"
        ' 
        ' dtpEndTime
        ' 
        dtpEndTime.Checked = False
        dtpEndTime.CustomFormat = ""
        dtpEndTime.Format = DateTimePickerFormat.Time
        dtpEndTime.Location = New Point(446, 125)
        dtpEndTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpEndTime.Name = "dtpEndTime"
        dtpEndTime.ShowUpDown = True
        dtpEndTime.Size = New Size(96, 23)
        dtpEndTime.TabIndex = 40
        dtpEndTime.Value = New Date(2024, 12, 2, 0, 0, 0, 0)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(319, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 39
        Label2.Text = "Start Time"
        ' 
        ' dtpStartTime
        ' 
        dtpStartTime.Checked = False
        dtpStartTime.CustomFormat = ""
        dtpStartTime.Format = DateTimePickerFormat.Time
        dtpStartTime.Location = New Point(319, 125)
        dtpStartTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpStartTime.Name = "dtpStartTime"
        dtpStartTime.ShowUpDown = True
        dtpStartTime.Size = New Size(96, 23)
        dtpStartTime.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(228, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 37
        Label1.Text = "Add Reservation"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(46, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 36
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSaveReservation
        ' 
        btnSaveReservation.BackColor = Color.Gold
        btnSaveReservation.FlatStyle = FlatStyle.Flat
        btnSaveReservation.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveReservation.Location = New Point(90, 453)
        btnSaveReservation.Name = "btnSaveReservation"
        btnSaveReservation.Size = New Size(75, 23)
        btnSaveReservation.TabIndex = 35
        btnSaveReservation.Text = "Save"
        btnSaveReservation.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(90, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 34
        Label3.Text = "Date"
        ' 
        ' dtpReservationDate
        ' 
        dtpReservationDate.Enabled = False
        dtpReservationDate.Location = New Point(90, 125)
        dtpReservationDate.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpReservationDate.Name = "dtpReservationDate"
        dtpReservationDate.Size = New Size(205, 23)
        dtpReservationDate.TabIndex = 33
        ' 
        ' EventForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Label10)
        Controls.Add(cmbTrainer)
        Controls.Add(lblTotalFee)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtReservationNotes)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(cmbEquipmentType)
        Controls.Add(Label5)
        Controls.Add(cmbTrainingType)
        Controls.Add(Label4)
        Controls.Add(dtpEndTime)
        Controls.Add(Label2)
        Controls.Add(dtpStartTime)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnSaveReservation)
        Controls.Add(Label3)
        Controls.Add(dtpReservationDate)
        Margin = New Padding(3, 2, 3, 2)
        Name = "EventForm"
        Size = New Size(594, 508)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents cmbTrainer As ComboBox
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReservationNotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbEquipmentType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTrainingType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveReservation As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpReservationDate As DateTimePicker

End Class
