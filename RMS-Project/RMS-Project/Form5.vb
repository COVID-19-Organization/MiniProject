Imports System.Data.SqlClient
Public Class Form5

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into income values('" & inID.Text & "','" & inname.Text & "','" & inprice.Text & "','" & DateTimeIncome.Value & "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("Yess")
    End Sub


End Class