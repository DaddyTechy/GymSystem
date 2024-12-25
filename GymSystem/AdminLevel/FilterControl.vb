Public Class FilterControl
    Public Event FilterApplied(selectedFilters As List(Of String), genderFilter As String)
    Public Event FilterCancelled()

    ' Add properties to store the state
    Private _selectedFilters As New List(Of String)
    Private _selectedGender As String = ""

    Public Sub New()
        InitializeComponent()
        ' Initialize checkboxes with default state
        SetupCheckBoxes()
    End Sub

    Private Sub SetupCheckBoxes()
        ' Set checkbox properties
        For Each cb As CheckBox In New CheckBox() {IdCheck, FirstNameCheck, LastNameCheck, AddressCheck}
            cb.AutoCheck = True ' Enable normal checkbox behavior
        Next
        
        MaleCheck.AutoCheck = True
        FemaleCheck.AutoCheck = True
    End Sub

    ' Add property to set initial state
    Public Sub SetInitialState(selectedFilters As List(Of String), genderFilter As String)
        _selectedFilters = New List(Of String)(selectedFilters) ' Create new list to avoid reference issues
        _selectedGender = genderFilter
        
        ' Update checkboxes based on stored state
        IdCheck.Checked = _selectedFilters.Contains("ID")
        FirstNameCheck.Checked = _selectedFilters.Contains("FirstName")
        LastNameCheck.Checked = _selectedFilters.Contains("LastName")
        AddressCheck.Checked = _selectedFilters.Contains("Address")
        
        ' Update gender checkboxes
        MaleCheck.Checked = (_selectedGender = "Male")
        FemaleCheck.Checked = (_selectedGender = "Female")
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        _selectedFilters.Clear()
        
        If IdCheck.Checked Then _selectedFilters.Add("ID")
        If FirstNameCheck.Checked Then _selectedFilters.Add("FirstName")
        If LastNameCheck.Checked Then _selectedFilters.Add("LastName")
        If AddressCheck.Checked Then _selectedFilters.Add("Address")

        _selectedGender = ""
        If MaleCheck.Checked Then _selectedGender = "Male"
        If FemaleCheck.Checked Then _selectedGender = "Female"
        
        RaiseEvent FilterApplied(_selectedFilters, _selectedGender)
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        RaiseEvent FilterCancelled()
    End Sub

    Private Sub GenderCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MaleCheck.CheckedChanged, FemaleCheck.CheckedChanged
        Dim cb As CheckBox = DirectCast(sender, CheckBox)
        If cb.Checked Then
            If cb Is MaleCheck Then
                FemaleCheck.Checked = False
            Else
                MaleCheck.Checked = False
            End If
        End If
    End Sub
End Class 