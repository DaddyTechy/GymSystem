Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class EditMemberPanel
    Inherits UserControl

    Public Event MemberUpdated As EventHandler
    Public Event EditCancelled As EventHandler

    Private memberData As MemberData

    ' UI Controls for editing
    Private txtFirstName As TextBox
    Private txtMiddleName As TextBox
    Private txtLastName As TextBox
    Private txtUsername As TextBox
    Private txtPhoneNumber As TextBox
    Private txtProvince As TextBox
    Private txtCity As TextBox
    Private txtStreet As TextBox
    Private txtZipCode As TextBox
    Private btnSave As Button
    Private btnCancel As Button

    ' UI Controls for displaying current data
    Private lblCurrentFirstName As Label
    Private lblCurrentMiddleName As Label
    Private lblCurrentLastName As Label
    Private lblCurrentUsername As Label
    Private lblCurrentPhoneNumber As Label
    Private lblCurrentProvince As Label
    Private lblCurrentCity As Label
    Private lblCurrentStreet As Label
    Private lblCurrentZipCode As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Size = New Size(750, 400) ' Increased size
        Me.BackColor = Color.FromArgb(50, 50, 50)

        ' Headers
        Dim lblCurrentHeader As New Label() With {.Text = "Current Details", .ForeColor = Color.Gold, .Font = New Font(Me.Font, FontStyle.Bold), .Location = New Point(220, 10), .AutoSize = True}
        Dim lblNewHeader As New Label() With {.Text = "New Details", .ForeColor = Color.Gold, .Font = New Font(Me.Font, FontStyle.Bold), .Location = New Point(470, 10), .AutoSize = True}
        Me.Controls.Add(lblCurrentHeader)
        Me.Controls.Add(lblNewHeader)

        ' --- Fields ---
        Dim yPos As Integer = 50
        Dim spacing As Integer = 30

        ' First Name
        CreateRow("First Name:", yPos, lblCurrentFirstName, txtFirstName)
        yPos += spacing

        ' Middle Name
        CreateRow("Middle Name:", yPos, lblCurrentMiddleName, txtMiddleName)
        yPos += spacing

        ' Last Name
        CreateRow("Last Name:", yPos, lblCurrentLastName, txtLastName)
        yPos += spacing

        ' Username
        CreateRow("Username:", yPos, lblCurrentUsername, txtUsername)
        yPos += spacing

        ' Phone Number
        CreateRow("Phone Number:", yPos, lblCurrentPhoneNumber, txtPhoneNumber)
        yPos += spacing

        ' Street
        CreateRow("Street:", yPos, lblCurrentStreet, txtStreet)
        yPos += spacing

        ' City
        CreateRow("City:", yPos, lblCurrentCity, txtCity)
        yPos += spacing

        ' Province
        CreateRow("Province:", yPos, lblCurrentProvince, txtProvince)
        yPos += spacing

        ' Zip Code
        CreateRow("Zip Code:", yPos, lblCurrentZipCode, txtZipCode)

        ' --- Buttons ---
        yPos += 50 ' Adjusted spacing for buttons
        btnSave = New Button() With {.Text = "Save", .Location = New Point(470, yPos), .Size = New Size(100, 30), .BackColor = Color.Gold, .ForeColor = Color.Black}
        btnCancel = New Button() With {.Text = "Cancel", .Location = New Point(580, yPos), .Size = New Size(100, 30), .BackColor = Color.Gray, .ForeColor = Color.White}
        Me.Controls.Add(btnSave)
        Me.Controls.Add(btnCancel)

        AddHandler btnSave.Click, AddressOf btnSave_Click
        AddHandler btnCancel.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub CreateRow(labelText As String, yPos As Integer, ByRef currentLabel As Label, ByRef newTextBox As TextBox)
        ' Field Label
        Dim fieldLabel As New Label() With {.Text = labelText, .ForeColor = Color.White, .Location = New Point(20, yPos), .AutoSize = True}
        Me.Controls.Add(fieldLabel)

        ' Current Value Label
        currentLabel = New Label() With {.Text = "", .ForeColor = Color.LightGray, .Location = New Point(220, yPos), .Size = New Size(200, 20), .BorderStyle = BorderStyle.FixedSingle, .Padding = New Padding(2)}
        Me.Controls.Add(currentLabel)

        ' New Value TextBox
        newTextBox = New TextBox() With {.Location = New Point(470, yPos), .Size = New Size(200, 20)}
        Me.Controls.Add(newTextBox)
    End Sub

    Public Sub LoadMemberData(data As MemberData)
        memberData = data

        ' Populate current value labels
        lblCurrentFirstName.Text = memberData.FirstName
        lblCurrentMiddleName.Text = memberData.MiddleName
        lblCurrentLastName.Text = memberData.LastName
        lblCurrentUsername.Text = memberData.Username
        lblCurrentPhoneNumber.Text = memberData.PhoneNumber
        lblCurrentStreet.Text = memberData.Street
        lblCurrentCity.Text = memberData.City
        lblCurrentProvince.Text = memberData.Province
        lblCurrentZipCode.Text = memberData.ZipCode

        ' Populate textboxes for editing with the same data
        txtFirstName.Text = memberData.FirstName
        txtMiddleName.Text = memberData.MiddleName
        txtLastName.Text = memberData.LastName
        txtUsername.Text = memberData.Username
        txtPhoneNumber.Text = memberData.PhoneNumber
        txtStreet.Text = memberData.Street
        txtCity.Text = memberData.City
        txtProvince.Text = memberData.Province
        txtZipCode.Text = memberData.ZipCode
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ' --- Validation ---
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("First Name, Last Name, and Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Regex.IsMatch(txtPhoneNumber.Text, "^\d{10,15}$") Then
            MessageBox.Show("Please enter a valid phone number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txtZipCode.Text) AndAlso Not IsNumeric(txtZipCode.Text) Then
            MessageBox.Show("Zip Code must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- Confirmation ---
        Dim result = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        ' --- Save to Database ---
        UpdateConnectionString()
        Try
            Using conn As New MySqlConnection(modDB.strConnection)
                conn.Open()
                Dim query As String = "UPDATE members SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, PhoneNumber = @PhoneNumber, Province = @Province, City = @City, Street = @Street, ZipCode = @ZipCode WHERE MemberID = @MemberID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@Province", txtProvince.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@Street", txtStreet.Text)
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text)
                    cmd.Parameters.AddWithValue("@MemberID", memberData.MemberID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Also update the username in the memberlogin table
                Dim loginQuery As String = "UPDATE memberlogin SET Username = @Username WHERE MemberID = @MemberID"
                Using loginCmd As New MySqlCommand(loginQuery, conn)
                    loginCmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    loginCmd.Parameters.AddWithValue("@MemberID", memberData.MemberID)
                    loginCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RaiseEvent MemberUpdated(Me, EventArgs.Empty)

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        RaiseEvent EditCancelled(Me, EventArgs.Empty)
    End Sub

End Class
