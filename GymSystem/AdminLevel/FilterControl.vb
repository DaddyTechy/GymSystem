Imports MySql.Data.MySqlClient

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


    Public Sub SetupCheckBoxes()
        ' Set checkbox properties
        For Each cb As CheckBox In New CheckBox() {IdCheck, FirstNameCheck, LastNameCheck, AddressCheck}
            cb.AutoCheck = True ' Enable normal checkbox behavior
            cb.Checked = True ' Check all checkboxes by default
            Debug.WriteLine($"{cb.Name} Checked: {cb.Checked}") ' Debugging line
        Next

        MaleCheck.AutoCheck = True
        FemaleCheck.AutoCheck = True
        MaleCheck.Checked = False ' Uncheck Male checkbox by default
        FemaleCheck.Checked = False ' Uncheck Female checkbox by default
        Debug.WriteLine($"MaleCheck Checked: {MaleCheck.Checked}") ' Debugging line
        Debug.WriteLine($"FemaleCheck Checked: {FemaleCheck.Checked}") ' Debugging line
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

    Public Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Debug.WriteLine("SaveBtn_Click: Method called")
        ApplyFiltersAndConnect()
    End Sub


    Public Sub ApplyFiltersAndConnect()
        ' Clear the selected filters
        _selectedFilters.Clear()

        ' Add the selected filters
        If IdCheck.Checked Then _selectedFilters.Add("ID")
        If FirstNameCheck.Checked Then _selectedFilters.Add("FirstName")
        If LastNameCheck.Checked Then _selectedFilters.Add("LastName")
        If AddressCheck.Checked Then _selectedFilters.Add("Address")

        ' Set the selected gender
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Sub SetCheckBoxStates()
        ' Explicitly set the checkbox states
        IdCheck.Checked = True
        FirstNameCheck.Checked = True
        LastNameCheck.Checked = True
        AddressCheck.Checked = True
        MaleCheck.Checked = False
        FemaleCheck.Checked = False

        ' Check the state of the checkboxes
        Debug.WriteLine($"IdCheck Checked: {IdCheck.Checked}")
        Debug.WriteLine($"FirstNameCheck Checked: {FirstNameCheck.Checked}")
        Debug.WriteLine($"LastNameCheck Checked: {LastNameCheck.Checked}")
        Debug.WriteLine($"AddressCheck Checked: {AddressCheck.Checked}")
        Debug.WriteLine($"MaleCheck Checked: {MaleCheck.Checked}")
        Debug.WriteLine($"FemaleCheck Checked: {FemaleCheck.Checked}")
    End Sub

    Private Sub FilterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the function to set the checkbox states

    End Sub


End Class
