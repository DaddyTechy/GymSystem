Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class JoinNow

    Inherits Form

    Private Sub LogError(ByVal message As String)
        Dim logFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registration_log.txt")
        Try
            Using writer As New StreamWriter(logFilePath, True)
                writer.WriteLine(Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - " & message)
            End Using
        Catch ex As Exception
            ' If logging fails, write to debug output so we don't crash the app
            Debug.WriteLine("Failed to write to log file: " & ex.ToString())
        End Try
    End Sub
    Public IsAdminContext As Boolean = False
    Private caretHandler As New CaretHandler()


    Private data As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String))) From {
        {"Camarines Norte", New Dictionary(Of String, Dictionary(Of String, String)) From {
            {"Basud", New Dictionary(Of String, String) From {
                {"Angas", "4608"},
                {"Bactas", "4608"},
                {"Binatagan", "4608"},
                {"Caayunan", "4608"},
                {"Guinatungan", "4608"},
                {"Hinampacan", "4608"},
                {"Langa", "4608"},
                {"Laniton", "4608"},
                {"Lidong", "4608"},
                {"Mampili", "4608"},
                {"Mandazo", "4608"},
                {"Mangcamagong", "4608"},
                {"Manmuntay", "4608"},
                {"Mantugawe", "4608"},
                {"Matnog", "4608"},
                {"Mocong", "4608"},
                {"Oliva", "4608"},
                {"Pagsangahan", "4608"},
                {"Pinagwarasan", "4608"},
                {"Plaridel", "4608"},
                {"Poblacion 1", "4608"},
                {"Poblacion 2", "4608"},
                {"San Felipe", "4608"},
                {"San Jose", "4608"},
                {"San Pascual", "4608"},
                {"Taba-taba", "4608"},
                {"Tacad", "4608"},
                {"Taisan", "4608"},
                {"Tuaca", "4608"}
            }},
            {"Capalonga", New Dictionary(Of String, String) From {
                {"Alayao", "4607"},
                {"Binawangan", "4607"},
                {"Calabaca", "4607"},
                {"Camagsaan", "4607"},
                {"Catabaguangan", "4607"},
                {"Catioan", "4607"},
                {"Del Pilar", "4607"},
                {"Itok", "4607"},
                {"Lucbanan", "4607"},
                {"Mabini", "4607"},
                {"Mactang", "4607"},
                {"Magsaysay", "4607"},
                {"Mataque", "4607"},
                {"Old Camp", "4607"},
                {"Poblacion", "4607"},
                {"San Antonio", "4607"},
                {"San Isidro", "4607"},
                {"San Roque", "4607"},
                {"Tanawan", "4607"},
                {"Ubang", "4607"},
                {"Villa Aurora", "4607"},
                {"Villa Belen", "4607"}
            }},
            {"Daet", New Dictionary(Of String, String) From {
                {"Alawihao", "4600"},
                {"Awitan", "4600"},
                {"Bagasbas", "4600"},
                {"Barangay I", "4600"},
                {"Barangay II", "4600"},
                {"Barangay III", "4600"},
                {"Barangay IV", "4600"},
                {"Barangay V", "4600"},
                {"Barangay VI", "4600"},
                {"Barangay VII", "4600"},
                {"Barangay VIII", "4600"},
                {"Bibirao", "4600"},
                {"Borabod", "4600"},
                {"Calasgasan", "4600"},
                {"Camambugan", "4600"},
                {"Cobangbang", "4600"},
                {"Dogongan", "4600"},
                {"Gahonon", "4600"},
                {"Gubat", "4600"},
                {"Lag-on", "4600"},
                {"Magang", "4600"},
                {"Mambalite", "4600"},
                {"Mancruz", "4600"},
                {"Pamorangon", "4600"},
                {"San Isidro", "4600"}
            }},
            {"Jose Panganiban", New Dictionary(Of String, String) From {
                {"Bagong Bayan", "4606"},
                {"Calero", "4606"},
                {"Dahican", "4606"},
                {"Dayhagan", "4606"},
                {"Larap", "4606"},
                {"Luklukan Norte", "4606"},
                {"Luklukan Sur", "4606"},
                {"Motherlode", "4606"},
                {"Nakalaya", "4606"},
                {"North Poblacion", "4606"},
                {"Osmeña", "4606"},
                {"Pag-asa", "4606"},
                {"Parang", "4606"},
                {"Plaridel", "4606"},
                {"Salvacion", "4606"},
                {"San Isidro", "4606"},
                {"San Jose", "4606"},
                {"San Martin", "4606"},
                {"San Pedro", "4606"},
                {"San Rafael", "4606"},
                {"Santa Cruz", "4606"},
                {"Santa Elena", "4606"},
                {"Santa Milagrosa", "4606"},
                {"Santa Rosa Norte", "4606"},
                {"Santa Rosa Sur", "4606"},
                {"South Poblacion", "4606"},
                {"Tamisan", "4606"}
            }},
            {"Labo", New Dictionary(Of String, String) From {
                {"Anahaw", "4604"},
                {"Anameam", "4604"},
                {"Awitan", "4604"},
                {"Baay", "4604"},
                {"Bagacay", "4604"},
                {"Bagong Silang I", "4604"},
                {"Bagong Silang II", "4604"},
                {"Bagong Silang III", "4604"},
                {"Bakiad", "4604"},
                {"Bautista", "4604"},
                {"Bayabas", "4604"},
                {"Bayan-bayan", "4604"},
                {"Benit", "4604"},
                {"Bulhao", "4604"},
                {"Cabatuhan", "4604"},
                {"Cabusay", "4604"},
                {"Calabasa", "4604"},
                {"Canapawan", "4604"},
                {"Daguit", "4604"},
                {"Dalas", "4604"},
                {"Dumagmang", "4604"},
                {"Exciban", "4604"},
                {"Fundado", "4604"},
                {"Guinacutan", "4604"},
                {"Guisican", "4604"},
                {"Gumamela", "4604"},
                {"Iberica", "4604"},
                {"Kalamunding", "4604"},
                {"Lugui", "4604"},
                {"Mabilo I", "4604"},
                {"Mabilo II", "4604"},
                {"Macogon", "4604"},
                {"Mahawan-hawan", "4604"},
                {"Malangcao-Basud", "4604"},
                {"Malasugui", "4604"},
                {"Malatap", "4604"},
                {"Malaya", "4604"},
                {"Malibago", "4604"},
                {"Maot", "4604"},
                {"Masalong", "4604"},
                {"Matanlang", "4604"},
                {"Napaod", "4604"},
                {"Pag-asa", "4604"},
                {"Pangpang", "4604"},
                {"Pinya", "4604"},
                {"San Antonio", "4604"},
                {"San Francisco", "4604"},
                {"Santa Cruz", "4604"},
                {"Submakin", "4604"},
                {"Talobatib", "4604"},
                {"Tigbinan", "4604"},
                {"Tulay na Lupa", "4604"}
            }},
            {"Mercedes", New Dictionary(Of String, String) From {
                {"Apuao", "4601"},
                {"Barangay I", "4601"},
                {"Barangay II", "4601"},
                {"Barangay III", "4601"},
                {"Barangay IV", "4601"},
                {"Barangay V", "4601"},
                {"Barangay VI", "4601"},
                {"Barangay VII", "4601"},
                {"Caringo", "4601"},
                {"Catandunganon", "4601"},
                {"Cayucyucan", "4601"},
                {"Colasi", "4601"},
                {"Del Rosario", "4601"},
                {"Gaboc", "4601"},
                {"Hamoraon", "4601"},
                {"Hinipaan", "4601"},
                {"Lalawigan", "4601"},
                {"Lanot", "4601"},
                {"Mambungalon", "4601"},
                {"Manguisoc", "4601"},
                {"Masalongsalong", "4601"},
                {"Matoogtoog", "4601"},
                {"Pambuhan", "4601"},
                {"Quinapaguian", "4601"},
                {"San Roque", "4601"},
                {"Tarum", "4601"}
            }},
            {"Paracale", New Dictionary(Of String, String) From {
                {"Awitan", "4605"},
                {"Bagumbayan", "4605"},
                {"Bakal", "4605"},
                {"Batobalani", "4605"},
                {"Calaburnay", "4605"},
                {"Capacuan", "4605"},
                {"Casalugan", "4605"},
                {"Dagang", "4605"},
                {"Dalnac", "4605"},
                {"Dancalan", "4605"},
                {"Gumaus", "4605"},
                {"Labnig", "4605"},
                {"Macolabo Island", "4605"},
                {"Malacbang", "4605"},
                {"Malaguit", "4605"},
                {"Mampungo", "4605"},
                {"Mangkasay", "4605"},
                {"Maybato", "4605"},
                {"Palanas", "4605"},
                {"Pinagbirayan Malaki", "4605"},
                {"Pinagbirayan Munti", "4605"},
                {"Poblacion Norte", "4605"},
                {"Poblacion Sur", "4605"},
                {"Tabas", "4605"},
                {"Talusan", "4605"},
                {"Tawig", "4605"},
                {"Tugos", "4605"}
            }},
            {"San Lorenzo Ruiz", New Dictionary(Of String, String) From {
                {"Daculang Bolo", "4610"},
                {"Dagotdotan", "4610"},
                {"Langga", "4610"},
                {"Laniton", "4610"},
                {"Maisog", "4610"},
                {"Mampurog", "4610"},
                {"Manlimonsito", "4610"},
                {"Matacong", "4610"},
                {"Salvacion", "4610"},
                {"San Antonio", "4610"},
                {"San Isidro", "4610"},
                {"San Ramon", "4610"}
            }},
            {"San Vicente", New Dictionary(Of String, String) From {
                {"Asdum", "4609"},
                {"Cabanbanan", "4609"},
                {"Calabagas", "4609"},
                {"Fabrica", "4609"},
                {"Iraya Sur", "4609"},
                {"Man-ogob", "4609"},
                {"Poblacion District I", "4609"},
                {"Poblacion District II", "4609"},
                {"San Jose", "4609"}
            }},
            {"Santa Elena", New Dictionary(Of String, String) From {
                {"Basiad", "4611"},
                {"Bulala", "4611"},
                {"Don Tomas", "4611"},
                {"Guitol", "4611"},
                {"Kabuluan", "4611"},
                {"Kagtalaba", "4611"},
                {"Maulawin", "4611"},
                {"Patag Ibaba", "4611"},
                {"Patag Iraya", "4611"},
                {"Plaridel", "4611"},
                {"Polungguitguit", "4611"},
                {"Rizal", "4611"},
                {"Salvacion", "4611"},
                {"San Lorenzo", "4611"},
                {"San Pedro", "4611"},
                {"San Vicente", "4611"},
                {"Santa Elena", "4611"},
                {"Tabugon", "4611"},
                {"Villa San Isidro", "4611"}
            }},
            {"Talisay", New Dictionary(Of String, String) From {
                {"Binanuaan", "4602"},
                {"Caawigan", "4602"},
                {"Cahabaan", "4602"},
                {"Calintaan", "4602"},
                {"Del Carmen", "4602"},
                {"Gabon", "4602"},
                {"Itomang", "4602"},
                {"Poblacion", "4602"},
                {"San Francisco", "4602"},
                {"San Isidro", "4602"},
                {"San Jose", "4602"},
                {"San Nicolas", "4602"},
                {"Santa Cruz", "4602"},
                {"Santa Elena", "4602"},
                {"Santo Niño", "4602"}
            }},
            {"Vinzons", New Dictionary(Of String, String) From {
                {"Aguit-it", "4603"},
                {"Banocboc", "4603"},
                {"Barangay I", "4603"},
                {"Barangay II", "4603"},
                {"Barangay III", "4603"},
                {"Cagbalogo", "4603"},
                {"Calangcawan Norte", "4603"},
                {"Calangcawan Sur", "4603"},
                {"Guinacutan", "4603"},
                {"Mangcawayan", "4603"},
                {"Mangcayo", "4603"},
                {"Manlucugan", "4603"},
                {"Matango", "4603"},
                {"Napilihan", "4603"},
                {"Pinagtigasan", "4603"},
                {"Sabang", "4603"},
                {"Santo Domingo", "4603"},
                {"Singi", "4603"},
                {"Sula", "4603"}
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

        Dim DateOfBirth As New CustomBorder(CustomCalendar1)
        Me.Controls.Add(DateOfBirth)
        DateOfBirth.BringToFront()


        ' Remove the old Sex TextBox border
        ' Dim Sex As New CustomBorder(SexTxt)
        ' Me.Controls.Add(Sex)

        ' Add items to Sex ComboBox
        SexTxt.Items.Clear()
        SexTxt.Items.Add("Male")
        SexTxt.Items.Add("Female")

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
        PlansCB.DropDownStyle = ComboBoxStyle.DropDownList
        PlansCB.Items.Add("Bronze (3 months)")
        PlansCB.Items.Add("Silver (6 months)")
        PlansCB.Items.Add("Gold (9 months)")
        PlansCB.Items.Add("Diamond (12 months)")

        BLoginBtn.Visible = True

        ' Set LinkLabel behavior to remove the underline
        ShowLL.LinkBehavior = LinkBehavior.NeverUnderline
        UpdateConnectionString()

        ' Set focus to the First Name field for a better user experience
        FirstTxt.Select()

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

    Private Sub Sex_GotFocus(sender As Object, e As EventArgs)
        caretHandler.InitializeCaret(SexTxt, Color.FromArgb(245, 203, 92))
    End Sub

    Private Sub Sex_LostFocus(sender As Object, e As EventArgs)
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
        Dim selectedPlan As String = ""
        If PlansCB.SelectedItem IsNot Nothing Then
            selectedPlan = PlansCB.SelectedItem.ToString()
        Else
            servicesLBL.Text = "Please select a plan to see the benefits."
            Return
        End If

        Dim cost As Decimal = GetPlanCost(selectedPlan)
        Dim benefits As String = ""

        ' Based on the selected plan, update the servicesLBL
        Select Case selectedPlan
            Case "Bronze (3 months)"
                benefits = "Included: Fitness & Cardio"
            Case "Silver (6 months)"
                benefits = "Included: Fitness, Cardio & Sauna"
            Case "Gold (9 months)"
                benefits = "Included: Fitness, Cardio, Sauna & Personal Training"
            Case "Diamond (12 months)"
                benefits = "Included: All Services (Fitness, Cardio, Sauna, Personal Training, Group Classes, Pool Access)"
            Case Else
                benefits = ""
        End Select

        servicesLBL.Text = $"Price: {cost:C2}" & vbCrLf & benefits
    End Sub

    Private Sub HeightTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles HeightTxt.Validating
        ' Validate the height input
        Dim height As Decimal

        If Decimal.TryParse(HeightTxt.Text, height) Then
            ' Additional code for height processing can be added here if needed
        ElseIf HeightTxt.Text <> "" Then
            ' If the input is not a valid number and not empty, show a message
            MessageBox.Show("Please enter a valid number for Height in feet (e.g., 5.9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancel the event to keep the focus on the control
            e.Cancel = True
        End If
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

    Private Sub SexTxt_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow only letters and control keys (like backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press if it's not a letter or control key
            MessageBox.Show("Only letters are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        ' Ask for confirmation before proceeding
        Dim confirmResult = MessageBox.Show("Are you sure you want to submit your details?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then
            Return ' Exit if user clicks No
        End If

        UpdateConnectionString()
        ' Call the validation function before proceeding

        ' Check if the email has been used or if the information is 70% similar
        Dim emailExists As Boolean = CEmailExists(EmailTxt.Text)
        Dim similarInfoExists As Boolean = CSimilarInfoExists(FirstTxt.Text, LastTxt.Text, ContactTxt.Text)

        If emailExists Then
            MessageBox.Show("The email has already been used. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the event if email exists
        ElseIf similarInfoExists Then
            MessageBox.Show("The information provided is too similar to an existing member. Please check your details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the event if similar info exists
        End If

        If Not ValidateForm() Then
            Return ' Exit the event if any field is not filled
        End If

        ' Check if the passwords match when submitting
        If PassTxt.Text <> CPassTxt.Text Then
            MessageBox.Show("Passwords do not match! Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Optionally highlight the confirm password textbox
            CPassTxt.BackColor = Color.Gray
            Return ' Exit the event if passwords do not match
        Else
            ' Clear any previous highlights
            CPassTxt.BackColor = Color.Gray
        End If

        InsertMemberAndLogin()
    End Sub
    Private Function CSimilarInfoExists(firstName As String, lastName As String, phoneNumber As String) As Boolean
        Dim exists As Boolean = False
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM members WHERE (FirstName = @FirstName AND LastName = @LastName) OR PhoneNumber = @PhoneNumber", conn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    exists = True
                End If
            End Using
        Catch ex As Exception
            ErrorHandler.HandleError(ex)
        End Try
        Return exists
    End Function
    Private Function CEmailExists(email As String) As Boolean
        Dim exists As Boolean = False
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM members WHERE Email = @Email", conn)
                cmd.Parameters.AddWithValue("@Email", email)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    exists = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking the email: " & ex.Message)
        End Try
        Return exists
    End Function
    Private Function ValidateInputs() As Boolean
        ' Validate First Name
        If String.IsNullOrWhiteSpace(FirstTxt.Text) Then
            MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FirstTxt.Focus()
            Return False
        End If
        If Regex.IsMatch(FirstTxt.Text, "\d") Then
            MessageBox.Show("First Name cannot contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FirstTxt.Focus()
            Return False
        End If

        ' Validate Last Name
        If String.IsNullOrWhiteSpace(LastTxt.Text) Then
            MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LastTxt.Focus()
            Return False
        End If
        If Regex.IsMatch(LastTxt.Text, "\d") Then
            MessageBox.Show("Last Name cannot contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LastTxt.Focus()
            Return False
        End If

        ' Validate Middle Name (optional, but no numbers if present)
        If Not String.IsNullOrWhiteSpace(MiddleTxt.Text) AndAlso Regex.IsMatch(MiddleTxt.Text, "\d") Then
            MessageBox.Show("Middle Name cannot contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MiddleTxt.Focus()
            Return False
        End If

        ' Validate Phone Number
        If Not Regex.IsMatch(ContactTxt.Text, "^09\d{9}$") Then
            MessageBox.Show("Contact number must be 11 digits and start with 09.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ContactTxt.Focus()
            Return False
        End If

        ' Validate Email
        If String.IsNullOrWhiteSpace(EmailTxt.Text) Then
            MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmailTxt.Focus()
            Return False
        End If
        Try
            Dim addr = New System.Net.Mail.MailAddress(EmailTxt.Text)
            If addr.Address <> EmailTxt.Text Then
                Throw New FormatException()
            End If
        Catch
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmailTxt.Focus()
            Return False
        End Try

        ' Check if email already exists
        If CEmailExists(EmailTxt.Text) Then
            MessageBox.Show("This email address is already registered.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmailTxt.Focus()
            Return False
        End If

        ' Check if a province is selected
        If CustomComboProvince.SelectedIndex = -1 Then
            MessageBox.Show("Please select a province.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if a city/municipality is selected
        If CustomComboCity.SelectedIndex = -1 Then
            MessageBox.Show("Please select a city/municipality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if a barangay is selected
        If CustomComboStreet.SelectedIndex = -1 Then
            MessageBox.Show("Please select a barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if a plan is selected
        If PlansCB.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a membership plan.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if password is not empty
        If String.IsNullOrWhiteSpace(PassTxt.Text) Then
            MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if passwords match
        If PassTxt.Text <> CPassTxt.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function ValidateForm() As Boolean
        ' Check if required TextBox fields are empty
        If String.IsNullOrWhiteSpace(FirstTxt.Text) Then
            MessageBox.Show("First name is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        ' If all required fields are filled and selected, return True
        Return True
    End Function

    Private Sub InsertMemberAndLogin()
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Debug.WriteLine("Connection opened successfully.")

                LogError("Starting registration transaction.")
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Update the members insert query to use the selected Sex value
                        Dim insertMembersQuery As String = "INSERT INTO `members`(`FirstName`, `MiddleName`, `LastName`, `Sex`, `DOB`, `Weight`, `Height`, `Province`, `City`, `Street`, `ZipCode`, `PhoneNumber`, `DTCreated`, `Status`, `Email`) " &
                                                       "VALUES (@FirstName, @MiddleName, @LastName, @Sex, @DOB, @Weight, @Height, @Province, @City, @Street, @ZipCode, @PhoneNumber, @DTCreated, 'Active', @Email)"
                        Using insertMembersCommand As New MySqlCommand(insertMembersQuery, conn, transaction)
                            insertMembersCommand.Parameters.AddWithValue("@FirstName", FirstTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@MiddleName", MiddleTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@LastName", LastTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@Sex", SexTxt.SelectedItem.ToString())
                            insertMembersCommand.Parameters.AddWithValue("@DOB", CustomCalendar1.Value.ToString("yyyy-MM-dd"))
                            insertMembersCommand.Parameters.AddWithValue("@Weight", KgTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@Height", HeightTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@Province", CustomComboProvince.SelectedItem.ToString())
                            insertMembersCommand.Parameters.AddWithValue("@City", CustomComboCity.SelectedItem.ToString())
                            insertMembersCommand.Parameters.AddWithValue("@Street", CustomComboStreet.SelectedItem.ToString())
                            insertMembersCommand.Parameters.AddWithValue("@ZipCode", CustomComboZip.Text)
                            insertMembersCommand.Parameters.AddWithValue("@PhoneNumber", ContactTxt.Text)
                            insertMembersCommand.Parameters.AddWithValue("@DTCreated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            insertMembersCommand.Parameters.AddWithValue("@Email", EmailTxt.Text)
                            insertMembersCommand.ExecuteNonQuery()
                        End Using

                        ' Retrieve the MemberID of the newly inserted member
                        Dim memberIdQuery As String = "SELECT LAST_INSERT_ID()"
                        Dim cmd As New MySqlCommand(memberIdQuery, conn, transaction)
                        Dim memberId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                        Debug.WriteLine($"New MemberID: {memberId}")

                        ' Insert into memberlogin table
                        Dim insertMemberLoginQuery As String = "INSERT INTO `memberlogin`(`MemberID`, `Username`, `Password`, `Email`, `PhoneNumber`, `IsEncrypted`, `EncryptedPassword`) " &
                                                          "VALUES (@MemberID, @Username, @Password, @Email, @PhoneNumber, TRUE, @EncryptedPassword)"
                        Using insertMemberLoginCommand As New MySqlCommand(insertMemberLoginQuery, conn, transaction)
                            insertMemberLoginCommand.Parameters.AddWithValue("@MemberID", memberId)
                            insertMemberLoginCommand.Parameters.AddWithValue("@Username", FirstTxt.Text)
                            insertMemberLoginCommand.Parameters.AddWithValue("@Password", PassTxt.Text)
                            insertMemberLoginCommand.Parameters.AddWithValue("@Email", EmailTxt.Text)
                            insertMemberLoginCommand.Parameters.AddWithValue("@PhoneNumber", ContactTxt.Text)
                            insertMemberLoginCommand.Parameters.AddWithValue("@EncryptedPassword", Encrypt(PassTxt.Text))
                            insertMemberLoginCommand.ExecuteNonQuery()
                        End Using

                        ' Determine membership details based on membership name
                        Dim membershipName As String = PlansCB.SelectedItem.ToString()
                        Dim cost As Decimal = GetPlanCost(membershipName)
                        Dim duration As String
                        Dim benefits As String
                        Dim startDate As DateTime = DateTime.Now
                        Dim endDate As DateTime
                        Dim discountAvailable As String
                        Dim cancelationPolicy As String
                        Dim renewalPolicy As String
                        Dim trainingSession As Integer
                        Dim lockerAccess As String
                        Dim membershipType As String

                        Select Case membershipName
                            Case "Diamond (12 months)"
                                duration = "1 yr"
                                benefits = "Full benefits"
                                endDate = startDate.AddYears(1)
                                discountAvailable = "Yes"
                                cancelationPolicy = "Standard"
                                renewalPolicy = "Auto-renew"
                                trainingSession = 1
                                lockerAccess = "Yes"
                                membershipType = "All"
                            Case "Gold (9 months)"
                                duration = "9 months"
                                benefits = "Standard benefits"
                                endDate = startDate.AddMonths(9)
                                discountAvailable = "Yes"
                                cancelationPolicy = "Standard"
                                renewalPolicy = "Manual-renew"
                                trainingSession = 1
                                lockerAccess = "No"
                                membershipType = "Sauna, Training"
                            Case "Silver (6 months)"
                                duration = "6 months"
                                benefits = "Limited benefits"
                                endDate = startDate.AddMonths(6)
                                discountAvailable = "No"
                                cancelationPolicy = "Standard"
                                renewalPolicy = "Manual-renew"
                                trainingSession = 0
                                lockerAccess = "No"
                                membershipType = "Sauna"
                            Case Else ' Bronze
                                duration = "3 month"
                                benefits = "Basic benefits"
                                endDate = startDate.AddMonths(3)
                                discountAvailable = "No"
                                cancelationPolicy = "Flexible"
                                renewalPolicy = "Manual-renew"
                                trainingSession = 0
                                lockerAccess = "No"
                                membershipType = "Fitness"
                        End Select

                        Debug.WriteLine($"Membership details - Name: {membershipName}, Duration: {duration}, Cost: {cost}, Benefits: {benefits}, StartDate: {startDate}, EndDate: {endDate}, DiscountAvailable: {discountAvailable}, CancelationPolicy: {cancelationPolicy}, RenewalPolicy: {renewalPolicy}, TrainingSession: {trainingSession}, LockerAccess: {lockerAccess}")

                        ' Insert into membership table
                        Dim insertMembershipQuery As String = "INSERT INTO `membership`(`MemberID`, `MemberShipName`, `Duration`, `Cost`, `Benefits`, `StartDate`, `EndDate`, `DiscountAvailable`, `CancelationPolicy`, `RenewalPolicy`, `TrainingSession`, `LockerAccess`, `MembershipType`, `Status`) " &
                                                      "VALUES (@MemberID, @MemberShipName, @Duration, @Cost, @Benefits, @StartDate, @EndDate, @DiscountAvailable, @CancelationPolicy, @RenewalPolicy, @TrainingSession, @LockerAccess, @MembershipType, 'Active')"
                        Using insertMembershipCommand As New MySqlCommand(insertMembershipQuery, conn, transaction)
                            insertMembershipCommand.Parameters.AddWithValue("@MemberID", memberId)
                            insertMembershipCommand.Parameters.AddWithValue("@MemberShipName", membershipName)
                            insertMembershipCommand.Parameters.AddWithValue("@Duration", duration)
                            insertMembershipCommand.Parameters.AddWithValue("@Cost", cost)
                            insertMembershipCommand.Parameters.AddWithValue("@Benefits", benefits)
                            insertMembershipCommand.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd"))
                            insertMembershipCommand.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd"))
                            insertMembershipCommand.Parameters.AddWithValue("@DiscountAvailable", discountAvailable)
                            insertMembershipCommand.Parameters.AddWithValue("@CancelationPolicy", cancelationPolicy)
                            insertMembershipCommand.Parameters.AddWithValue("@RenewalPolicy", renewalPolicy)
                            insertMembershipCommand.Parameters.AddWithValue("@TrainingSession", trainingSession)
                            insertMembershipCommand.Parameters.AddWithValue("@LockerAccess", lockerAccess)
                            insertMembershipCommand.Parameters.AddWithValue("@MembershipType", membershipType)
                            insertMembershipCommand.ExecuteNonQuery()
                        End Using

                        ' Create a pending payment record to be updated by the payment form
                        Dim insertPaymentQuery As String = "INSERT INTO `payment` (`MemberID`, `MembershipID`, `MembershipCost`, `PaymentStatus`, `PaymentDate`) VALUES (@MemberID, @MembershipID, @Cost, 'Pending', @PaymentDate); SELECT LAST_INSERT_ID();"
                        Dim membershipId As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction).ExecuteScalar())

                        Dim paymentId As Integer
                        Using insertPaymentCommand As New MySqlCommand(insertPaymentQuery, conn, transaction)
                            insertPaymentCommand.Parameters.AddWithValue("@MemberID", memberId)
                            insertPaymentCommand.Parameters.AddWithValue("@MembershipID", membershipId)
                            insertPaymentCommand.Parameters.AddWithValue("@Cost", cost)
                            insertPaymentCommand.Parameters.AddWithValue("@PaymentDate", DateTime.Now)
                            paymentId = Convert.ToInt32(insertPaymentCommand.ExecuteScalar())
                        End Using

                        ' After inserting records, proceed to payment by hosting the BillingPaymentForm in a dialog.
                        Me.Hide()

                        Dim paymentCompleted As Boolean = False
                        Try
                            ' 1. Create the user control with the transaction and other details.
                            Dim billingControl As New BillingPaymentForm(conn, transaction, cost, True, paymentId, memberId)

                            ' 2. Create the host form and pass the control to it.
                            Using hostForm As New PaymentHostForm(billingControl)
                                ' 3. Show the host form as a dialog.
                                Dim paymentResult As DialogResult = hostForm.ShowDialog(Me)

                                ' 4. Check the result after the dialog is closed.
                                If paymentResult = DialogResult.OK Then
                                    paymentCompleted = True
                                End If
                            End Using
                        Catch paymentEx As Exception
                            ' Catch exceptions during payment form processing
                            LogError("Error during payment form: " & paymentEx.ToString())
                            MessageBox.Show("An error occurred during the payment process: " & paymentEx.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ' paymentCompleted remains false, so transaction will be rolled back
                        End Try

                        If paymentCompleted Then
                            ' Commit the transaction only if payment was successful
                            LogError("Attempting to commit transaction.")
                            transaction.Commit()
                            LogError("Transaction committed successfully.")

                            Dim finalSuccessForm As New RegistrationSuccessForm(memberId)
                            finalSuccessForm.ShowDialog()

                            Dim loginForm As New Member()
                            loginForm.Show()
                            Me.Close()
                        Else
                            ' Rollback the transaction if payment was not completed
                            LogError("Payment not completed. Rolling back transaction.")
                            transaction.Rollback()
                            MessageBox.Show("Payment was not completed and your registration has been cancelled. Please try again.", "Registration Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Show()
                        End If

                    Catch ex As Exception
                        ' Rollback the transaction in case of an error during the main registration part
                        LogError("Transaction failed. Rolling back. Error: " & ex.ToString())
                        transaction.Rollback()
                        MessageBox.Show("An error occurred during registration: " & ex.Message)
                        Debug.WriteLine($"Transaction rolled back due to error: {ex.Message}")
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("A database connection error occurred: " & ex.Message)
            Debug.WriteLine($"Connection error: {ex.Message}")
        End Try
    End Sub



    Private Sub ContactTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTxt.KeyPress
        ' Allow only numbers and the backspace key
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstTxt.KeyPress, MiddleTxt.KeyPress, LastTxt.KeyPress
        ' Allow only letters, backspace, and space. Prevents numbers.
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
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

    Private Sub HeightTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HeightTxt.KeyPress
        ' Allow only digits, decimal point, and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers and decimal point are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso HeightTxt.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub HeightTxt_Leave(sender As Object, e As EventArgs) Handles HeightTxt.Leave
        ' Check if the input is numeric and does not contain a decimal point
        Dim height As Decimal
        If Decimal.TryParse(HeightTxt.Text, height) AndAlso Not HeightTxt.Text.Contains(".") Then
            ' Add a decimal point and a zero
            HeightTxt.Text &= ".0"
        End If
    End Sub


    Private Sub KgTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KgTxt.KeyPress
        ' Allow only digits, decimal point, and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers and decimal point are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso KgTxt.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Function GetPlanCost(planName As String) As Decimal
        Select Case planName
            Case "Bronze (3 months)"
                Return 100D
            Case "Silver (6 months)"
                Return 300D
            Case "Gold (9 months)"
                Return 600D
            Case "Diamond (12 months)"
                Return 1000D
            Case Else
                Return 0D
        End Select
    End Function


End Class