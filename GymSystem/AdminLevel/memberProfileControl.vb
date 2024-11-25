Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class memberProfileControl
    Private selectedMember As MemberData

    Private Sub memberProfileControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This method can be left empty or used for other initialization tasks
        If lblStatus.Text = "Inactive" Then
            lblStatus.ForeColor = Color.Red
        Else
            lblStatus.ForeColor = Color.Gold
        End If
    End Sub

    ' Define the LoadMemberData method
    Public Sub LoadMemberData(memberData As MemberData)
        ' Use the memberData object to populate the controls in the user control
        lblMemberName.Text = memberData.FirstName & " " & memberData.LastName
        lblContactNo.Text = memberData.PhoneNumber
        lbldob.Text = memberData.DOB & "  |  Age: " & CalculateAge(memberData.DOB)
        lblEmail.Text = memberData.Email
        lblUserName.Text = memberData.FirstName & " " & memberData.LastName
        lblUserHandle.Text = "@" & memberData.Username
        lblWeightHeight.Text = memberData.Weight & "kg  |  " & memberData.Height & "ft"
        lbldtcreated.Text = "Member Since: " & memberData.DTCreated
        lblStatus.Text = memberData.Status

        lblPlanCost.Text = "Php " & memberData.Cost
        lblPlanAccess.Text = memberData.Benefits & ":" & Environment.NewLine & memberData.MembershipType
        lblPlanStartDate.Text = memberData.StartDate
        lblEndDate.Text = memberData.EndDate
        lblPlanType.Text = "JJ Fitness GYM: " & memberData.MemberShipName & " - " & memberData.Duration
        lblRenewalPolicy.Text = memberData.RenewalPolicy
        ' Populate other controls as needed
    End Sub
    Private Function CalculateAge(dob As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year
        If (dob > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim color1 = Color.Gold
        Dim color2 = Color.White
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, Panel2.Width, Panel2.Height - 1)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color2, color1, 45.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim color1 = Color.Gold
        Dim color2 = Color.White
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, Panel3.Width, Panel3.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 45.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint
        Dim color1 = Color.FromArgb(20, 20, 20)
        Dim color2 = Color.FromArgb(70, 70, 70)
        ' Define the rectangle for the gradient
        Dim rect As New Rectangle(0, 0, TableLayoutPanel2.Width, TableLayoutPanel2.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color1, color2, 90.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
    End Sub

    Private Sub btnAddNotes_Click(sender As Object, e As EventArgs) Handles btnAddNotes.Click
        Dim addNotesControl As New AddNotesControl()
        AddHandler addNotesControl.NoteAdded, AddressOf OnNoteAdded

        ' Set the location and size of the AddNotesControl
        addNotesControl.Location = New Point(50, 50) ' Set the desired location
        addNotesControl.Size = New Size(470, 328) ' Set the desired size

        ' Add the AddNotesControl to the form
        Me.Controls.Add(addNotesControl)
        addNotesControl.BringToFront()
    End Sub

    Private Sub OnNoteAdded(noteDetails As String, author As String, dateAdded As DateTime)
        ' Update the textBoxForNotes with the new note
        textBoxForNotes.Text &= $"{noteDetails}               Author: {author}               Date Added: {dateAdded.ToShortDateString()}{Environment.NewLine}{Environment.NewLine}"
    End Sub

End Class
Public Class MemberData
        Public Property MemberID As Integer
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property LastName As String
        Public Property Username As String
        Public Property Sex As String
        Public Property PhoneNumber As String
        Public Property DTCreated As DateTime
        Public Property Address As String
        Public Property Cost As Decimal
        Public Property MembershipType As String
        Public Property Duration As String
        Public Property Status As String
        Public Property Weight As Decimal
        Public Property Height As Decimal
        Public Property Email As String
        Public Property DOB As DateTime
        Public Property StartDate As DateTime
        Public Property EndDate As DateTime
        Public Property RenewalPolicy As String
        Public Property Benefits As String
        Public Property MemberShipName As String
    End Class
