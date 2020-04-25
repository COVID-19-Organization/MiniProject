Imports System.Data.SqlClient
Public Class b

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into income values('" & inID.Text & "','" & inname.Text & "','" & inprice.Text & "','" & DateTimeIncome.Value & "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("สั่งอาหารเรียบร้อย")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.listfood.Text = DataGridView1.Item(0, i).Value
        Me.listfood.Text = DataGridView1.Item(1, i).Value
        Me.listfood.Text = DataGridView1.Item(2, i).Value
        Me.listfood.Text = DataGridView1.Item(3, i).Value
        Me.listfood.Text = DataGridView1.Item(4, i).Value
    End Sub
End Class