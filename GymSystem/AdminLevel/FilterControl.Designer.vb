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

        ' Panel1
        Panel1.BackColor = Color.FromArgb(40, 40, 40)
        Panel1.Controls.Add(SaveBtn)
        Panel1.Controls.Add(CancelBtn)
        Panel1.Controls.Add(GenderGroup)
        Panel1.Controls.Add(FilterGroup)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Size = New Size(300, 400)

        ' SaveBtn
        SaveBtn.BackColor = Color.FromArgb(245, 203, 92)
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Location = New Point(160, 350)
        SaveBtn.Size = New Size(100, 30)
        SaveBtn.Text = "Apply Filter"

        ' CancelBtn
        CancelBtn.BackColor = Color.Gray
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.Location = New Point(40, 350)
        CancelBtn.Size = New Size(100, 30)
        CancelBtn.Text = "Cancel"

        ' GenderGroup
        GenderGroup.ForeColor = Color.White
        GenderGroup.Location = New Point(20, 200)
        GenderGroup.Size = New Size(260, 100)
        GenderGroup.Text = "Gender Filter"
        GenderGroup.Controls.Add(FemaleCheck)
        GenderGroup.Controls.Add(MaleCheck)

        ' Gender CheckBoxes
        MaleCheck.ForeColor = Color.White
        MaleCheck.Location = New Point(20, 30)
        MaleCheck.Text = "Male"
        
        FemaleCheck.ForeColor = Color.White
        FemaleCheck.Location = New Point(20, 60)
        FemaleCheck.Text = "Female"

        ' FilterGroup
        FilterGroup.ForeColor = Color.White
        FilterGroup.Location = New Point(20, 20)
        FilterGroup.Size = New Size(260, 160)
        FilterGroup.Text = "Search Filters"
        FilterGroup.Controls.Add(AddressCheck)
        FilterGroup.Controls.Add(LastNameCheck)
        FilterGroup.Controls.Add(FirstNameCheck)
        FilterGroup.Controls.Add(IdCheck)

        ' Filter CheckBoxes
        IdCheck.ForeColor = Color.White
        IdCheck.Location = New Point(20, 30)
        IdCheck.Text = "ID Number"

        FirstNameCheck.ForeColor = Color.White
        FirstNameCheck.Location = New Point(20, 60)
        FirstNameCheck.Text = "First Name"

        LastNameCheck.ForeColor = Color.White
        LastNameCheck.Location = New Point(20, 90)
        LastNameCheck.Text = "Last Name"

        AddressCheck.ForeColor = Color.White
        AddressCheck.Location = New Point(20, 120)
        AddressCheck.Text = "Address"

        Me.Controls.Add(Panel1)
        Me.Size = New Size(300, 400)
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