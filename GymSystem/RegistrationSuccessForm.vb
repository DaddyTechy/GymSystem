Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class RegistrationSuccessForm
    Private memberId As Integer

    Public Sub New(memberId As Integer)
        InitializeComponent()
        Me.memberId = memberId
        lblMemberID.Text = memberId.ToString()
        Me.ControlBox = False

        ' Update form text for final confirmation
        Me.Text = "Registration & Payment Successful"
        ' Assuming a label exists to show a success message, find its name in the designer file and update it.
        ' For now, we prepare the logic.

        AddHandler Me.Resize, AddressOf Form_Resize
        AddHandler Me.Load, AddressOf Form_Load
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs)
        CenterPanel()
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        pnlMain.Location = New Point((Me.ClientSize.Width - pnlMain.Width) \ 2, (Me.ClientSize.Height - pnlMain.Height) \ 2)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
