Imports System.Data.SqlClient
Public Class Form5

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As New Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopDataSet.income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter.Fill(Me.ShopDataSet.income)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles save1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into income values('" & inID.Text & "','" & inname.Text & "','" & inprice.Text & "','" & DateTimeIncome.Value & "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("Yess")
    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from income"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        i = Convert.ToInt64(DataGridView1.SelectedCells.Item(0).Value.ToString())

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from income where incomeID=" & i & ""
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            inID.Text = dr.GetString(0).ToString()
            inname.Text = dr.GetString(1).ToString()
            inprice.Text = dr.GetInt32(2).ToString()
            DateTimeIncome.Value = dr.GetDateTime(3).ToString()

        End While

    End Sub
End Class