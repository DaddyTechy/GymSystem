<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAttendanceControl
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
        Label6 = New Label()
        cmbStatus = New ComboBox()
        Label5 = New Label()
        cmbSessionType = New ComboBox()
        Label4 = New Label()
        Label2 = New Label()
        dtpCheckInTime = New DateTimePicker()
        Label1 = New Label()
        Button1 = New Button()
        btnSave = New Button()
        Label3 = New Label()
        dtpDate = New DateTimePicker()
        Label8 = New Label()
        lblMemberStatus = New Label()
        dtpCheckOutTime = New DateTimePicker()
        cmbMemberID = New TextBox()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(99, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 45
        Label6.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Present", "Absent"})
        cmbStatus.Location = New Point(101, 377)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(99, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 43
        Label5.Text = "Training Type"
        ' 
        ' cmbSessionType
        ' 
        cmbSessionType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSessionType.FormattingEnabled = True
        cmbSessionType.Items.AddRange(New Object() {"Strength", "Endurance", "Flexibility"})
        cmbSessionType.Location = New Point(101, 317)
        cmbSessionType.Name = "cmbSessionType"
        cmbSessionType.Size = New Size(121, 23)
        cmbSessionType.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(225, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 41
        Label4.Text = "Check-Out"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(98, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 39
        Label2.Text = "Check-In"
        ' 
        ' dtpCheckInTime
        ' 
        dtpCheckInTime.CustomFormat = "HH:mm"
        dtpCheckInTime.Format = DateTimePickerFormat.Time
        dtpCheckInTime.Location = New Point(101, 245)
        dtpCheckInTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpCheckInTime.Name = "dtpCheckInTime"
        dtpCheckInTime.ShowUpDown = True
        dtpCheckInTime.Size = New Size(96, 23)
        dtpCheckInTime.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(125, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 37
        Label1.Text = "Add Attendance"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(14, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 36
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Gold
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(101, 424)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 35
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(101, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 34
        Label3.Text = "Date"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(101, 183)
        dtpDate.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 23)
        dtpDate.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(101, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 48
        Label8.Text = "Member ID"
        ' 
        ' lblMemberStatus
        ' 
        lblMemberStatus.AutoSize = True
        lblMemberStatus.ForeColor = SystemColors.Control
        lblMemberStatus.Location = New Point(228, 125)
        lblMemberStatus.Name = "lblMemberStatus"
        lblMemberStatus.Size = New Size(0, 15)
        lblMemberStatus.TabIndex = 49
        ' 
        ' dtpCheckOutTime
        ' 
        dtpCheckOutTime.CustomFormat = "HH:mm"
        dtpCheckOutTime.Format = DateTimePickerFormat.Time
        dtpCheckOutTime.Location = New Point(225, 245)
        dtpCheckOutTime.MinDate = New Date(2024, 11, 28, 0, 0, 0, 0)
        dtpCheckOutTime.Name = "dtpCheckOutTime"
        dtpCheckOutTime.ShowUpDown = True
        dtpCheckOutTime.Size = New Size(96, 23)
        dtpCheckOutTime.TabIndex = 50
        ' 
        ' cmbMemberID
        ' 
        cmbMemberID.Location = New Point(101, 122)
        cmbMemberID.Name = "cmbMemberID"
        cmbMemberID.PlaceholderText = "eg. 1, 2, 3 ..."
        cmbMemberID.Size = New Size(100, 23)
        cmbMemberID.TabIndex = 51
        ' 
        ' AddAttendanceControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Controls.Add(cmbMemberID)
        Controls.Add(dtpCheckOutTime)
        Controls.Add(lblMemberStatus)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(cmbStatus)
        Controls.Add(Label5)
        Controls.Add(cmbSessionType)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(dtpCheckInTime)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnSave)
        Controls.Add(Label3)
        Controls.Add(dtpDate)
        MinimumSize = New Size(405, 486)
        Name = "AddAttendanceControl"
        Size = New Size(405, 486)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSessionType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCheckInTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMemberStatus As Label
    Friend WithEvents dtpCheckOutTime As DateTimePicker
    Friend WithEvents cmbMemberID As TextBox

End Class
