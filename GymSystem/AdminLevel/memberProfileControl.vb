Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class memberProfileControl
    Private selectedMember As MemberData

    Private Sub memberProfileControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This method can be left empty or used for other initialization tasks
    End Sub

    ' Define the LoadMemberData method
    Public Sub LoadMemberData(memberData As MemberData)
        ' Use the memberData object to populate the controls in the user control
        lblMemberName.Text = memberData.FirstName & " " & memberData.LastName
        lblContactNo.Text = memberData.PhoneNumber
        lbldob.Text = memberData.DOB & "  |  Age: " & CalculateAge(memberData.DOB)
        lblEmail.Text = memberData.Email
        lblUserName.Text = memberData.FirstName & "@" & memberData.Username
        lblWeightHeight.Text = memberData.Weight & "kg  |  " & memberData.Height & "ft"
        lbldtcreated.Text = "Member Since: " & memberData.DTCreated
        lblStatus.Text = memberData.Status
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
        Dim rect As New Rectangle(0, 0, Panel2.Width * 5, Panel2.Height)

        ' Create the linear gradient brush
        Using gradientBrush As New Drawing2D.LinearGradientBrush(rect, color2, color1, 100.0F)
            ' Fill the panel background with the gradient
            e.Graphics.FillRectangle(gradientBrush, rect)
        End Using
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
End Class
