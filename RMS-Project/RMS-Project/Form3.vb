Imports System.Data.SqlClient
Public Class b

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

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
        disp_data()

    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles submit.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into income values('" & id.Text & "','" & DateTimeIncome.Value & "','" & cbbTable.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & Num1.Text & "')"
        cmd.ExecuteNonQuery()
        disp_data()

        MessageBox.Show("เพิ่มข้อมูลสำเร็จ")


    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from order"
        cmd.ExecuteNonQuery()


        Dim colsum As Decimal

        For Each R As DataGridViewRow In DataGridView1.Rows

            colsum += R.Cells(2).Value

        Next
        sum1.Text = colsum

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value


    End Sub

End Class