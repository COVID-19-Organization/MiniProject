Imports System.Data.SqlClient
Public Class b

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub b_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Table.shoptable' table. You can move, or remove it, as needed.
        Me.ShoptableTableAdapter.Fill(Me.Table.shoptable)
        'TODO: This line of code loads data into the 'Food._food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.Food._food)


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox2.Text = DataGridView1.Item(0, i).Value
        TextBox3.Text = DataGridView1.Item(1, i).Value

        


    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into order values ('" & order_id.Text & "', '" & DateTimeIncome.Value & "', '" + TextBox2.Text + "', '" + cbbTable.Text + "', '" + TextBox4.Text + "', '" & Num1.Value & "');"
        cmd.ExecuteNonQuery()

        MessageBox.Show("ยืนยันแล้ว")
    End Sub

    Private Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from order"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bu1.Click
        Dim sumorder As Int64
        sumorder = TextBox3.Text * Num1.Text
        TextBox4.Text = sumorder.ToString
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class