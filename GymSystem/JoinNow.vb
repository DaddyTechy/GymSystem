Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class JoinNow
    Inherits Form
    Private caretHandler As New CaretHandler()

    Private data As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String))) From {
        {"Camarines Norte", New Dictionary(Of String, Dictionary(Of String, String)) From {
            {"Basud", New Dictionary(Of String, String) From {
                {"San Felipe", "4608"},
                {"Angas", "4608"},
                {"Bactas", "4608"},
                {"Binatagan", "4608"},
                {"Caayunan", "4608"}
            }},
            {"Capalonga", New Dictionary(Of String, String) From {
                {"Villa Belen", "4607"},
                {"Alayao", "4607"},
                {"Binawangan", "4607"},
                {"Calabaca", "4607"},
                {"Camagsaan", "4607"}
            }},
            {"Daet", New Dictionary(Of String, String) From {
                {"Barangay I", "4600"},
                {"Alawihao", "4600"},
                {"Awitan", "4600"},
                {"Bagasbas", "4600"},
                {"Barangay II", "4600"}
            }},
            {"Jose Panganiban", New Dictionary(Of String, String) From {
                {"Santa Rosa Norte", "4606"},
                {"Bagong Bayan", "4606"},
                {"Calero", "4606"},
                {"Dahican", "4606"},
                {"Dayhagan", "4606"}
            }},
            {"Labo", New Dictionary(Of String, String) From {
                {"Bagong Silang I", "4604"},
                {"Anahaw", "4604"},
                {"Anameam", "4604"},
                {"Awitan", "4604"},
                {"Baay", "4604"}
            }},
            {"Mercedes", New Dictionary(Of String, String) From {
                {"Barangay I", "4601"},
                {"Apuao", "4601"},
                {"Barangay II", "4601"},
                {"Barangay III", "4601"},
                {"Barangay IV", "4601"}
            }},
            {"Paracale", New Dictionary(Of String, String) From {
                {"Bagumbayan", "4605"},
                {"Awitan", "4605"},
                {"Bakal", "4605"},
                {"Batobalani", "4605"},
                {"Calaburnay", "4605"}
            }},
            {"San Lorenzo Ruiz", New Dictionary(Of String, String) From {
                {"San Isidro", "4610"},
                {"Daculang Bolo", "4610"},
                {"Dagotdotan", "4610"},
                {"Langga", "4610"},
                {"Laniton", "4610"}
            }},
            {"San Vicente", New Dictionary(Of String, String) From {
                {"Man-Ogob", "4609"},
                {"Asdum", "4609"},
                {"Cabanbanan", "4609"},
                {"Calabagas", "4609"},
                {"Fabrica", "4609"}
            }},
            {"Santa Elena", New Dictionary(Of String, String) From {
                {"San Lorenzo", "4611"},
                {"Basiad", "4611"},
                {"Bulala", "4611"},
                {"Don Tomas", "4611"},
                {"Guitol", "4611"}
            }},
            {"Talisay", New Dictionary(Of String, String) From {
                {"Del Carmen", "4602"},
                {"Binanuaan", "4602"},
                {"Caawigan", "4602"},
                {"Cahabaan", "4602"},
                {"Calintaan", "4602"}
            }},
            {"Vinzons", New Dictionary(Of String, String) From {
                {"Sabang", "4603"},
                {"Aguit-it", "4603"},
                {"Banocboc", "4603"},
                {"Barangay I", "4603"},
                {"Barangay II", "4603"}
            }}
        }}
    }

    Private Sub JoinNow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        ' Set the location of the form to be in the center of the screen
        Me.Location = New Point((screenWidth - formWidth) / 2, (screenHeight - formHeight) / 2)

        Dim FirstName As New CustomBorder(FirstTxt)
        Me.Controls.Add(FirstName)

        Dim MiddleName As New CustomBorder(MiddleTxt)
        Me.Controls.Add(MiddleName)

        Dim LastName As New CustomBorder(LastTxt)
        Me.Controls.Add(LastName)

        Dim ContactNumber As New CustomBorder(ContactTxt)
        Me.Controls.Add(ContactNumber)

        Dim Email As New CustomBorder(EmailTxt)
        Me.Controls.Add(Email)

        Dim Sex As New CustomBorder(SexTxt)
        Me.Controls.Add(Sex)

        Dim Height As New CustomBorder(HeightTxt)
        Me.Controls.Add(Height)

        Dim Pass As New CustomBorder(PassTxt)
        Me.Controls.Add(Pass)

        Dim CPass As New CustomBorder(CPassTxt)
        Me.Controls.Add(CPass)

        Dim Kg As New CustomBorder(KgTxt)
        Me.Controls.Add(Kg)

        ' Populate provinces (ComboBox1)
        Dim provinces As New List(Of String)(data.Keys)
        CustomComboProvince.SetItems(provinces)

        ' Add the plans to the ComboBox during form load
        PlansCB.Items.Add("Bronze (3 months)")
        PlansCB.Items.Add("Silver (6 months)")
        PlansCB.Items.Add("Gold (9 months)")
        PlansCB.Items.Add("Diamond (12 months)")

        ServiceCB.Items.Clear()
    End Sub

    ' Handle province selection change (ComboBox1)
    Private Sub customComboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomComboProvince.SelectedIndexChanged
        ' Enable city combo and clear previous selections
        CustomComboCity.Enabled = True
        CustomComboStreet.Enabled = True
        CustomComboZip.Enabled = True
        CustomComboCity.Items.Clear()
        CustomComboStreet.Items.Clear()
        CustomComboZip.Items.Clear()

        ' Populate cities based on selected province
        Dim selectedProvince = CustomComboProvince.SelectedItem.ToString()
        Dim cities As New List(Of String)(data(selectedProvince).Keys)
        CustomComboCity.SetItems(cities)
    End Sub

    ' Handle city selection change (ComboBox2)
    Private Sub customComboCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomComboCity.SelectedIndexChanged
        ' Enable street combo and zip code combo and clear previous selections
        CustomComboStreet.Enabled = True
        CustomComboZip.Enabled = True

        CustomComboStreet.Items.Clear()
        CustomComboZip.Items.Clear()

        ' Populate streets based on selected city
        Dim selectedProvince = CustomComboProvince.SelectedItem.ToString()
        Dim selectedCity = CustomComboCity.SelectedItem.ToString()
        Dim streets As New List(Of String)(data(selectedProvince)(selectedCity).Keys)
        CustomComboStreet.SetItems(streets)

        ' Populate zip code based on selected city (if you want it to show right away)
        Dim zipCode = data(selectedProvince)(selectedCity).Values.FirstOrDefault()
        If zipCode IsNot Nothing Then
            CustomComboZip.SetItems(New List(Of String) From {zipCode})
        End If
    End Sub

    ' Handle street selection change (ComboBox3)
    Private Sub customComboStreet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomComboStreet.SelectedIndexChanged
        ' Enable zip code combo and clear previous selections
        CustomComboZip.Enabled = True
        CustomComboZip.Items.Clear()

        ' Populate zip code based on selected street
        Dim selectedProvince = CustomComboProvince.SelectedItem.ToString()
        Dim selectedCity = CustomComboCity.SelectedItem.ToString()
        Dim selectedStreet = CustomComboStreet.SelectedItem.ToString()
        Dim zipCode = data(selectedProvince)(selectedCity)(selectedStreet)

        ' Add the zip code to the zip code combo box
        CustomComboZip.SetItems(New List(Of String) From {zipCode})
    End Sub


    Private Sub FirstName_GotFocus(sender As Object, e As EventArgs) Handles FirstTxt.GotFocus
        caretHandler.InitializeCaret(FirstTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub FirstName_LostFocus(sender As Object, e As EventArgs) Handles FirstTxt.LostFocus
        caretHandler.HideCaret(FirstTxt)
    End Sub

    Private Sub MiddleName_GotFocus(sender As Object, e As EventArgs) Handles MiddleTxt.GotFocus
        caretHandler.InitializeCaret(MiddleTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub MiddleName_LostFocus(sender As Object, e As EventArgs) Handles MiddleTxt.LostFocus
        caretHandler.HideCaret(MiddleTxt)
    End Sub
    Private Sub LastName_GotFocus(sender As Object, e As EventArgs) Handles LastTxt.GotFocus
        caretHandler.InitializeCaret(LastTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub LastName_LostFocus(sender As Object, e As EventArgs) Handles LastTxt.LostFocus
        caretHandler.HideCaret(LastTxt)
    End Sub

    Private Sub Number_GotFocus(sender As Object, e As EventArgs) Handles ContactTxt.GotFocus
        caretHandler.InitializeCaret(ContactTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Number_LostFocus(sender As Object, e As EventArgs) Handles ContactTxt.LostFocus
        caretHandler.HideCaret(ContactTxt)
    End Sub

    Private Sub Email_GotFocus(sender As Object, e As EventArgs) Handles EmailTxt.GotFocus
        caretHandler.InitializeCaret(EmailTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Email_LostFocus(sender As Object, e As EventArgs) Handles EmailTxt.LostFocus
        caretHandler.HideCaret(EmailTxt)
    End Sub

    Private Sub Sex_GotFocus(sender As Object, e As EventArgs) Handles SexTxt.GotFocus
        caretHandler.InitializeCaret(SexTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Sex_LostFocus(sender As Object, e As EventArgs) Handles SexTxt.LostFocus
        caretHandler.HideCaret(SexTxt)
    End Sub

    Private Sub Height_GotFocus(sender As Object, e As EventArgs) Handles HeightTxt.GotFocus
        caretHandler.InitializeCaret(HeightTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Height_LostFocus(sender As Object, e As EventArgs) Handles HeightTxt.LostFocus
        caretHandler.HideCaret(HeightTxt)
    End Sub

    Private Sub Kg_GotFocus(sender As Object, e As EventArgs) Handles KgTxt.GotFocus
        caretHandler.InitializeCaret(KgTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Kg_LostFocus(sender As Object, e As EventArgs) Handles KgTxt.LostFocus
        caretHandler.HideCaret(KgTxt)
    End Sub

    Private Sub CPass_GotFocus(sender As Object, e As EventArgs) Handles CPassTxt.GotFocus
        caretHandler.InitializeCaret(CPassTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub CPass_LostFocus(sender As Object, e As EventArgs) Handles CPassTxt.LostFocus
        caretHandler.HideCaret(CPassTxt)
    End Sub

    Private Sub Pass_GotFocus(sender As Object, e As EventArgs) Handles PassTxt.GotFocus
        caretHandler.InitializeCaret(PassTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Pass_LostFocus(sender As Object, e As EventArgs) Handles PassTxt.LostFocus
        caretHandler.HideCaret(PassTxt)
    End Sub

    Private Sub PlansCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlansCB.SelectedIndexChanged
        ' Clear any previous items in the services ComboBox
        ServiceCB.Items.Clear()

        ' Get the selected plan
        Dim selectedPlan As String = PlansCB.SelectedItem.ToString()

        ' Based on the selected plan, populate the Services ComboBox
        Select Case selectedPlan
            Case "Bronze (3 months)"
                ' Add services for Bronze plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")

            Case "Silver (6 months)"
                ' Add services for Silver plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")

            Case "Gold (9 months)"
                ' Add services for Gold plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")
                ServiceCB.Items.Add("Personal Training")

            Case "Diamond (12 months)"
                ' Add all services for Diamond plan
                ServiceCB.Items.Add("Fitness")
                ServiceCB.Items.Add("Cardio")
                ServiceCB.Items.Add("Sauna")
                ServiceCB.Items.Add("Personal Training")
                ServiceCB.Items.Add("All Services")

            Case Else
                ' If no valid plan is selected
                MessageBox.Show("Please select a valid plan.")
        End Select
    End Sub

    Private Sub HeightTxt_TextChanged(sender As Object, e As EventArgs) Handles HeightTxt.TextChanged
        Try
            ' Check if the input is numeric
            If IsNumeric(HeightTxt.Text) Then
                ' Additional code for height processing can be added here if needed
            ElseIf HeightTxt.Text <> "" Then
                ' If the input is not a number and not empty, show a message
                MessageBox.Show("Please enter a valid number for Height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PassTxt_TextChanged(sender As Object, e As EventArgs) Handles PassTxt.TextChanged
        ' Set the PasswordChar property to hide the password
        PassTxt.PasswordChar = "*"c  ' You can change this character to anything you prefer, like '*' or a space
    End Sub

    Private Sub CPassTxt_TextChanged(sender As Object, e As EventArgs) Handles CPassTxt.TextChanged
        CPassTxt.PasswordChar = "*"c
    End Sub

    Private Sub TogglePasswordLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ShowLL.LinkClicked
        ' Toggle the PasswordChar property between showing and hiding the password for both textboxes
        If PassTxt.PasswordChar = "*"c Then
            PassTxt.PasswordChar = "" ' Show the password
            CPassTxt.PasswordChar = "" ' Show the confirm password
            ShowLL.Text = "Hide" ' Change LinkLabel text to "Hide"
        Else
            PassTxt.PasswordChar = "*"c ' Hide the password
            CPassTxt.PasswordChar = "*"c ' Hide the confirm password
            ShowLL.Text = "Show" ' Change LinkLabel text to "Show"
        End If
    End Sub

    Private Sub SexTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SexTxt.KeyPress
        ' Allow only letters and control keys (like backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press if it's not a letter or control key
            MessageBox.Show("Only letters are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Enforce a maximum length of 4 characters
        If SexTxt.Text.Length >= 6 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press if the length is 4 or more
            MessageBox.Show("The input must be 4 characters or less.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set LinkLabel behavior to remove the underline
        ShowLL.LinkBehavior = LinkBehavior.NeverUnderline
        UpdateConnectionString()
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        UpdateConnectionString()
        ' Call the validation function before proceeding
        If Not ValidateForm() Then
            MessageBox.Show("Please fill up all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the event if any field is not filled
        End If

        ' Check if the passwords match when submitting
        If PassTxt.Text <> CPassTxt.Text Then
            MessageBox.Show("Passwords do not match! Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Optionally highlight the confirm password textbox
            CPassTxt.BackColor = Color.Gray
        Else
            MessageBox.Show("Passwords match. You can proceed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Clear any previous highlights
            CPassTxt.BackColor = Color.Gray
        End If

        InsertData()
    End Sub

    ' Function to validate if all required fields are filled
    Private Function ValidateForm() As Boolean
        ' Check if required TextBox fields are empty
        If String.IsNullOrWhiteSpace(FirstTxt.Text) Then
            MessageBox.Show("First name is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(MiddleTxt.Text) Then
            MessageBox.Show("Middle name is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(LastTxt.Text) Then
            MessageBox.Show("Last name is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(ContactTxt.Text) Then
            MessageBox.Show("Contact number is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(EmailTxt.Text) Then
            MessageBox.Show("Email is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(SexTxt.Text) Then
            MessageBox.Show("Sex is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(HeightTxt.Text) Then
            MessageBox.Show("Height is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(PassTxt.Text) Then
            MessageBox.Show("Password is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(CPassTxt.Text) Then
            MessageBox.Show("Confirm password is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(KgTxt.Text) Then
            MessageBox.Show("Weight is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if ComboBox fields are not selected
        If CustomComboProvince.SelectedItem Is Nothing Then
            MessageBox.Show("Province is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If CustomComboCity.SelectedItem Is Nothing Then
            MessageBox.Show("City is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If CustomComboStreet.SelectedItem Is Nothing Then
            MessageBox.Show("Street is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If CustomComboZip.SelectedItem Is Nothing Then
            MessageBox.Show("Zip code is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If PlansCB.SelectedItem Is Nothing Then
            MessageBox.Show("Plan is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If ServiceCB.SelectedItem Is Nothing Then
            MessageBox.Show("Service is not selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' If all required fields are filled and selected, return True
        MessageBox.Show("All required fields are filled and selected.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    Private Sub InsertData()
        UpdateConnectionString()
        If ValidateForm() Then
            Try
                Debug.WriteLine("Validation passed.")
                conn.Open()
                Debug.WriteLine("Connection opened successfully.")

                ' Insert into members table
                Dim insertMembersQuery As String = "INSERT INTO `members`(`FirstName`, `MiddleName`, `LastName`, `Sex`, `DOB`, `Weight`, `Height`, `Province`, `City`, `Street`, `ZipCode`, `PhoneNumber`, `DTCreated`, `Status`, `Email`) VALUES ('" & FirstTxt.Text & "', '" & MiddleTxt.Text & "', '" & LastTxt.Text & "', '" & SexTxt.Text & "', '" & CustomCalendar1.Value.ToString("yyyy-MM-dd") & "', '" & KgTxt.Text & "', '" & HeightTxt.Text & "', '" & CustomComboProvince.SelectedItem.ToString() & "', '" & CustomComboCity.SelectedItem.ToString() & "', '" & CustomComboStreet.SelectedItem.ToString() & "', '" & CustomComboZip.SelectedItem.ToString() & "', '" & ContactTxt.Text & "', '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', 'Active', '" & EmailTxt.Text & "')"
                Debug.WriteLine($"Executing query: {insertMembersQuery}")
                readQuery(insertMembersQuery)

                ' Insert into memberlogin table
                Dim insertMemberLoginQuery As String = "INSERT INTO `memberlogin`(`MemberID`,`Username`, `Password`, `Email`, `PhoneNumber`, `IsEncrypted`, `EncryptedPassword`) VALUES ('" & EmailTxt.Text & "', '" & PassTxt.Text & "', '" & EmailTxt.Text & "', '" & ContactTxt.Text & "', TRUE, 'hashed_password')" ' Replace with actual hashed password
                Debug.WriteLine($"Executing query: {insertMemberLoginQuery}")
                readQuery(insertMemberLoginQuery)

                ' Determine membership details based on membership name
                Dim membershipName As String = PlansCB.SelectedItem.ToString()
                Dim duration As String
                Dim cost As Double
                Dim benefits As String
                Dim startDate As DateTime = DateTime.Now
                Dim endDate As DateTime
                Dim discountAvailable As String
                Dim cancelationPolicy As String
                Dim renewalPolicy As String
                Dim trainingSession As Integer
                Dim lockerAccess As String

                Select Case membershipName
                    Case "Diamond"
                        duration = "1 yr"
                        cost = 1000.0
                        benefits = "Full benefits"
                        endDate = startDate.AddYears(1)
                        discountAvailable = "Yes"
                        cancelationPolicy = "Standard"
                        renewalPolicy = "Auto-renew"
                        trainingSession = 1
                        lockerAccess = "Yes"
                    Case "Gold"
                        duration = "6 months"
                        cost = 600.0
                        benefits = "Standard benefits"
                        endDate = startDate.AddMonths(6)
                        discountAvailable = "Yes"
                        cancelationPolicy = "Standard"
                        renewalPolicy = "Manual-renew"
                        trainingSession = 1
                        lockerAccess = "No"
                    Case "Silver"
                        duration = "3 months"
                        cost = 300.0
                        benefits = "Limited benefits"
                        endDate = startDate.AddMonths(3)
                        discountAvailable = "No"
                        cancelationPolicy = "Standard"
                        renewalPolicy = "Manual-renew"
                        trainingSession = 0
                        lockerAccess = "No"
                    Case Else
                        duration = "1 month"
                        cost = 100.0
                        benefits = "Basic benefits"
                        endDate = startDate.AddMonths(1)
                        discountAvailable = "No"
                        cancelationPolicy = "Flexible"
                        renewalPolicy = "Manual-renew"
                        trainingSession = 0
                        lockerAccess = "No"
                End Select

                Debug.WriteLine($"Membership details - Name: {membershipName}, Duration: {duration}, Cost: {cost}, Benefits: {benefits}, StartDate: {startDate}, EndDate: {endDate}, DiscountAvailable: {discountAvailable}, CancelationPolicy: {cancelationPolicy}, RenewalPolicy: {renewalPolicy}, TrainingSession: {trainingSession}, LockerAccess: {lockerAccess}")

                ' Insert into membership table
                Dim insertMembershipQuery As String = "INSERT INTO `membership`(`MemberID`, `MemberShipName`, `Duration`, `Cost`, `Benefits`, `StartDate`, `EndDate`, `DiscountAvailable`, `CancelationPolicy`, `RenewalPolicy`, `TrainingSession`, `LockerAccess`, `MembershipType`) VALUES ('" & membershipName & "', '" & duration & "', " & cost & ", '" & benefits & "', '" & startDate.ToString("yyyy-MM-dd") & "', '" & endDate.ToString("yyyy-MM-dd") & "', '" & discountAvailable & "', '" & cancelationPolicy & "', '" & renewalPolicy & "', " & trainingSession & ", '" & lockerAccess & "', '" & ServiceCB.SelectedItem.ToString() & "')"
                Debug.WriteLine($"Executing query: {insertMembershipQuery}")
                readQuery(insertMembershipQuery)

                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Debug.WriteLine($"Error: {ex.Message}")
            Finally
                conn.Close()
                Debug.WriteLine("Connection closed.")
            End Try
        Else
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Debug.WriteLine("Validation failed.")
        End If
    End Sub


    Private Sub ContactTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTxt.KeyPress
        ' Allow only digits, the '+' sign, and control keys like backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press if it's not allowed
            MessageBox.Show("Only numbers and '+' are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Allow only one '+' at the beginning of the text
        If e.KeyChar = "+"c AndAlso (ContactTxt.Text.Length > 0 OrElse ContactTxt.Text.Contains("+")) Then
            e.Handled = True ' Suppress the key press if '+' is not at the start or already exists
            MessageBox.Show("The '+' sign can only be at the beginning.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BLoginBtn_Click(sender As Object, e As EventArgs) Handles BLoginBtn.Click
        ' Navigate to the MemberForm
        Dim memberForm As New Member() ' Create an instance of MemberForm
        memberForm.Show() ' Show the MemberForm
        Me.Close() ' Close the current form
    End Sub

    Private Sub SexLbl_Click(sender As Object, e As EventArgs)

    End Sub


End Class