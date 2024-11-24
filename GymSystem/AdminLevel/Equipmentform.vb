Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class Gym_Equipment

    Private Function RetrieveValues() As Dictionary(Of String, Object)
        Dim values As New Dictionary(Of String, Object) From {
            {"Equipmentname", If(equipmentnametxtbox.Text, String.Empty)}
        }
        Return values
    End Function

    Private Sub InsertIntoEquipment(values As Dictionary(Of String, Object))
        Try
            Using conn As New MySqlConnection("server=127.0.0.1;userid=root;password='';database=gym_infosys;")
                conn.Open()
                Dim query As String = "INSERT INTO equipment (Name) VALUES (@Name)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", values("Equipmentname"))
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ErrorHandler.HandleError(ex)
        End Try
    End Sub

    Public Sub AddnewEquipment()
        Dim values = RetrieveValues()

        ' Validate input

        ' Insert into admin table
        InsertIntoEquipment(values)

        MessageBox.Show("New created successfully.")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            AddnewEquipment()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Gym_Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set colors for controls
        Label1.ForeColor = System.Drawing.Color.Gold
        Label2.ForeColor = System.Drawing.Color.Gold
        Label3.ForeColor = System.Drawing.Color.Gold
        Label4.ForeColor = System.Drawing.Color.Gold
        Label5.ForeColor = System.Drawing.Color.Gold
        Label6.ForeColor = System.Drawing.Color.Gold

        equipmentnametxtbox.BackColor = System.Drawing.Color.Gold
        TextBox2.BackColor = System.Drawing.Color.Gold
        TextBox3.BackColor = System.Drawing.Color.Gold
        TextBox4.BackColor = System.Drawing.Color.Gold
        TextBox5.BackColor = System.Drawing.Color.Gold
        TextBox6.BackColor = System.Drawing.Color.Gold

        Button1.BackColor = System.Drawing.Color.Gold
        Button1.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Details Submitted!")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


End Class
