Imports System.Windows.Forms

Public Class Gym_Equipment
    Private Sub Gym_Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set colors for controls
        Label1.ForeColor = System.Drawing.Color.Gold
        Label2.ForeColor = System.Drawing.Color.Gold
        Label3.ForeColor = System.Drawing.Color.Gold
        Label4.ForeColor = System.Drawing.Color.Gold
        Label5.ForeColor = System.Drawing.Color.Gold
        Label6.ForeColor = System.Drawing.Color.Gold

        TextBox1.BackColor = System.Drawing.Color.Gold
        TextBox2.BackColor = System.Drawing.Color.Gold
        TextBox3.BackColor = System.Drawing.Color.Gold
        TextBox4.BackColor = System.Drawing.Color.Gold
        TextBox5.BackColor = System.Drawing.Color.Gold
        TextBox6.BackColor = System.Drawing.Color.Gold

        Button1.BackColor = System.Drawing.Color.Gold
        Button1.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Details Submitted!")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
