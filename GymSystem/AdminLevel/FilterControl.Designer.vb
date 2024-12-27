<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilterControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        SaveBtn = New Button()
        CancelBtn = New Button()
        GenderGroup = New GroupBox()
        FemaleCheck = New CheckBox()
        MaleCheck = New CheckBox()
        FilterGroup = New GroupBox()
        AddressCheck = New CheckBox()
        LastNameCheck = New CheckBox()
        FirstNameCheck = New CheckBox()
        IdCheck = New CheckBox()
        Panel1.SuspendLayout()
        GenderGroup.SuspendLayout()
        FilterGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Panel1.Controls.Add(SaveBtn)
        Panel1.Controls.Add(CancelBtn)
        Panel1.Controls.Add(GenderGroup)
        Panel1.Controls.Add(FilterGroup)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 400)
        Panel1.TabIndex = 0
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(245), CByte(203), CByte(92))
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Location = New Point(160, 350)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(100, 30)
        SaveBtn.TabIndex = 0
        SaveBtn.Text = "Apply Filter"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.Gray
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.Location = New Point(40, 350)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(100, 30)
        CancelBtn.TabIndex = 1
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' GenderGroup
        ' 
        GenderGroup.Controls.Add(FemaleCheck)
        GenderGroup.Controls.Add(MaleCheck)
        GenderGroup.ForeColor = Color.White
        GenderGroup.Location = New Point(20, 200)
        GenderGroup.Name = "GenderGroup"
        GenderGroup.Size = New Size(260, 100)
        GenderGroup.TabIndex = 2
        GenderGroup.TabStop = False
        GenderGroup.Text = "Gender Filter"
        ' 
        ' FemaleCheck
        ' 
        FemaleCheck.ForeColor = Color.White
        FemaleCheck.Location = New Point(20, 60)
        FemaleCheck.Name = "FemaleCheck"
        FemaleCheck.Size = New Size(104, 24)
        FemaleCheck.TabIndex = 0
        FemaleCheck.Text = "Female"
        ' 
        ' MaleCheck
        ' 
        MaleCheck.ForeColor = Color.White
        MaleCheck.Location = New Point(20, 30)
        MaleCheck.Name = "MaleCheck"
        MaleCheck.Size = New Size(104, 24)
        MaleCheck.TabIndex = 1
        MaleCheck.Text = "Male"
        ' 
        ' FilterGroup
        ' 
        FilterGroup.Controls.Add(AddressCheck)
        FilterGroup.Controls.Add(LastNameCheck)
        FilterGroup.Controls.Add(FirstNameCheck)
        FilterGroup.Controls.Add(IdCheck)
        FilterGroup.ForeColor = Color.White
        FilterGroup.Location = New Point(20, 20)
        FilterGroup.Name = "FilterGroup"
        FilterGroup.Size = New Size(260, 160)
        FilterGroup.TabIndex = 3
        FilterGroup.TabStop = False
        FilterGroup.Text = "Search Filters"
        ' 
        ' AddressCheck
        ' 
        AddressCheck.Checked = True
        AddressCheck.CheckState = CheckState.Checked
        AddressCheck.ForeColor = Color.White
        AddressCheck.Location = New Point(20, 120)
        AddressCheck.Name = "AddressCheck"
        AddressCheck.Size = New Size(104, 24)
        AddressCheck.TabIndex = 0
        AddressCheck.Text = "Address"
        ' 
        ' LastNameCheck
        ' 
        LastNameCheck.Checked = True
        LastNameCheck.CheckState = CheckState.Checked
        LastNameCheck.ForeColor = Color.White
        LastNameCheck.Location = New Point(20, 90)
        LastNameCheck.Name = "LastNameCheck"
        LastNameCheck.Size = New Size(104, 24)
        LastNameCheck.TabIndex = 1
        LastNameCheck.Text = "Last Name"
        ' 
        ' FirstNameCheck
        ' 
        FirstNameCheck.Checked = True
        FirstNameCheck.CheckState = CheckState.Checked
        FirstNameCheck.ForeColor = Color.White
        FirstNameCheck.Location = New Point(20, 60)
        FirstNameCheck.Name = "FirstNameCheck"
        FirstNameCheck.Size = New Size(104, 24)
        FirstNameCheck.TabIndex = 2
        FirstNameCheck.Text = "First Name"
        ' 
        ' IdCheck
        ' 
        IdCheck.Checked = True
        IdCheck.CheckState = CheckState.Checked
        IdCheck.ForeColor = Color.White
        IdCheck.Location = New Point(20, 30)
        IdCheck.Name = "IdCheck"
        IdCheck.Size = New Size(104, 24)
        IdCheck.TabIndex = 3
        IdCheck.Text = "ID Number"
        ' 
        ' FilterControl
        ' 
        BackColor = Color.Transparent
        Controls.Add(Panel1)
        Name = "FilterControl"
        Size = New Size(300, 400)
        Panel1.ResumeLayout(False)
        GenderGroup.ResumeLayout(False)
        FilterGroup.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private Panel1 As Panel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents GenderGroup As GroupBox
    Friend WithEvents FemaleCheck As CheckBox
    Friend WithEvents MaleCheck As CheckBox
    Friend WithEvents FilterGroup As GroupBox
    Friend WithEvents AddressCheck As CheckBox
    Friend WithEvents LastNameCheck As CheckBox
    Friend WithEvents FirstNameCheck As CheckBox
    Friend WithEvents IdCheck As CheckBox
End Class 