<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addReservationControl
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
        Button1 = New Button()
        btnSaveReservation = New Button()
        Label3 = New Label()
        dtpReservationDate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        dtpStartTime = New DateTimePicker()
        Label4 = New Label()
        dtpEndTime = New DateTimePicker()
        cmbTrainingType = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        cmbEquipmentType = New ComboBox()
        Label7 = New Label()
        txtReservationNotes = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        lblTotalFee = New Label()
        cmbTrainer = New ComboBox()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(19, 23)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 15
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSaveReservation
        ' 
        btnSaveReservation.BackColor = Color.Gold
        btnSaveReservation.FlatStyle = FlatStyle.Flat
        btnSaveReservation.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveReservation.Location = New Point(70, 580)
        btnSaveReservation.Margin = New Padding(3, 4, 3, 4)
        btnSaveReservation.Name = "btnSaveReservation"
        btnSaveReservation.Size = New Size(86, 31)
        btnSaveReservation.TabIndex = 14
        btnSaveReservation.Text = "Save"
        btnSaveReservation.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(70, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 13
        Label3.Text = "Date"
        ' 
        ' dtpReservationDate
        ' 
        dtpReservationDate.Location = New Point(70, 143)
        dtpReservationDate.Margin = New Padding(3, 4, 3, 4)
        dtpReservationDate.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpReservationDate.Name = "dtpReservationDate"
        dtpReservationDate.Size = New Size(228, 27)
        dtpReservationDate.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(227, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 32)
        Label1.TabIndex = 16
        Label1.Text = "Add Reservation"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(339, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 18
        Label2.Text = "Start Time"
        ' 
        ' dtpStartTime
        ' 
        dtpStartTime.Checked = False
        dtpStartTime.CustomFormat = ""
        dtpStartTime.Format = DateTimePickerFormat.Time
        dtpStartTime.Location = New Point(339, 143)
        dtpStartTime.Margin = New Padding(3, 4, 3, 4)
        dtpStartTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpStartTime.Name = "dtpStartTime"
        dtpStartTime.ShowUpDown = True
        dtpStartTime.Size = New Size(109, 27)
        dtpStartTime.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(485, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 20
        Label4.Text = "End Time"
        ' 
        ' dtpEndTime
        ' 
        dtpEndTime.Checked = False
        dtpEndTime.CustomFormat = ""
        dtpEndTime.Format = DateTimePickerFormat.Time
        dtpEndTime.Location = New Point(485, 143)
        dtpEndTime.Margin = New Padding(3, 4, 3, 4)
        dtpEndTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpEndTime.Name = "dtpEndTime"
        dtpEndTime.ShowUpDown = True
        dtpEndTime.Size = New Size(109, 27)
        dtpEndTime.TabIndex = 19
        dtpEndTime.Value = New Date(2024, 12, 2, 0, 0, 0, 0)
        ' 
        ' cmbTrainingType
        ' 
        cmbTrainingType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrainingType.FormattingEnabled = True
        cmbTrainingType.Items.AddRange(New Object() {"Strength", "Endurance", "Flexibility"})
        cmbTrainingType.Location = New Point(70, 240)
        cmbTrainingType.Margin = New Padding(3, 4, 3, 4)
        cmbTrainingType.Name = "cmbTrainingType"
        cmbTrainingType.Size = New Size(138, 28)
        cmbTrainingType.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(70, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 22
        Label5.Text = "Training Type*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(248, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 20)
        Label6.TabIndex = 24
        Label6.Text = "Equipment Type*"
        ' 
        ' cmbEquipmentType
        ' 
        cmbEquipmentType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEquipmentType.FormattingEnabled = True
        cmbEquipmentType.Location = New Point(248, 240)
        cmbEquipmentType.Margin = New Padding(3, 4, 3, 4)
        cmbEquipmentType.Name = "cmbEquipmentType"
        cmbEquipmentType.Size = New Size(138, 28)
        cmbEquipmentType.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(456, 216)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 26
        ' 
        ' txtReservationNotes
        ' 
        txtReservationNotes.Location = New Point(70, 341)
        txtReservationNotes.Margin = New Padding(3, 4, 3, 4)
        txtReservationNotes.Multiline = True
        txtReservationNotes.Name = "txtReservationNotes"
        txtReservationNotes.Size = New Size(333, 103)
        txtReservationNotes.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(70, 317)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 20)
        Label8.TabIndex = 28
        Label8.Text = "Notes"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(70, 461)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 20)
        Label9.TabIndex = 29
        Label9.Text = "Total Fee:"
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.AutoSize = True
        lblTotalFee.BackColor = Color.White
        lblTotalFee.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFee.ForeColor = Color.Black
        lblTotalFee.Location = New Point(70, 495)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(0, 32)
        lblTotalFee.TabIndex = 30
        ' 
        ' cmbTrainer
        ' 
        cmbTrainer.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrainer.FormattingEnabled = True
        cmbTrainer.Location = New Point(425, 240)
        cmbTrainer.Margin = New Padding(3, 4, 3, 4)
        cmbTrainer.Name = "cmbTrainer"
        cmbTrainer.Size = New Size(169, 28)
        cmbTrainer.TabIndex = 31
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(425, 216)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 20)
        Label10.TabIndex = 32
        Label10.Text = "Trainer*"
        ' 
        ' addReservationControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "addReservationControl"
        Size = New Size(658, 672)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveReservation As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpReservationDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents cmbTrainingType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbEquipmentType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReservationNotes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents cmbTrainer As ComboBox
    Friend WithEvents Label10 As Label

End Class
