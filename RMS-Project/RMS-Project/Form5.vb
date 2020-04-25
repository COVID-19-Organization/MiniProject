Imports System.Data.SqlClient
Public Class Form5

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As New Integer
    Dim i2 As New Integer


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopDataSet1.income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter1.Fill(Me.ShopDataSet1.income)
        'TODO: This line of code loads data into the 'ShopDataSet1.expen' table. You can move, or remove it, as needed.
        Me.ExpenTableAdapter.Fill(Me.ShopDataSet1.expen)
        'TODO: This line of code loads data into the 'ShopDataSet.income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter.Fill(Me.ShopDataSet.income)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()
        disp_data2()
        Me.ReportViewer1.RefreshReport
        Me.ReportViewer2.RefreshReport
        Me.ReportViewer2.RefreshReport
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles save1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into income values('" & inID.Text & "','" & inname.Text & "','" & inprice.Text & "','" & DateTimeIncome.Value & "')"
        cmd.ExecuteNonQuery()
        disp_data()
        disp_data2()

        MessageBox.Show("เพิ่มข้อมูลสำเร็จ")


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
        inID.Text = ""
        inname.Text = ""
        inprice.Text = ""

        Dim colsum As Decimal

        For Each R As DataGridViewRow In DataGridView1.Rows

            colsum += R.Cells(2).Value

        Next
        sum1.Text = colsum

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

    Private Sub del1_Click(sender As Object, e As EventArgs) Handles del1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from income where incomeID='" & inID.Text & "'"
        cmd.ExecuteNonQuery()
        disp_data()
        disp_data2()
        MessageBox.Show("ลบข้อมูลสำเร็จ")

    End Sub

    Private Sub edit1_Click(sender As Object, e As EventArgs) Handles edit1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update income set incomeName='" & inname.Text & "', IncomePrice='" & inprice.Text & "', IncomeDate='" & DateTimeIncome.Value & "', incomeId='" & inID.Text & "' where incomeID=" & i & ""
        cmd.ExecuteNonQuery()
        disp_data()
        disp_data2()
        MessageBox.Show("แก้ไขข้อมูลสำเร็จ")
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        i2 = Convert.ToInt64(DataGridView2.SelectedCells.Item(0).Value.ToString())


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from expen where exId=" & i2 & ""
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            exId.Text = dr.GetString(0).ToString()
            exName.Text = dr.GetString(1).ToString()
            exPrice.Text = dr.GetInt32(2).ToString()
            exDate.Value = dr.GetDateTime(3).ToString()

        End While

    End Sub

    Private Sub add2_Click(sender As Object, e As EventArgs) Handles add2.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into expen values('" & exId.Text & "','" & exName.Text & "','" & exPrice.Text & "','" & exDate.Value & "')"
        cmd.ExecuteNonQuery()

        disp_data()
        disp_data2()
        MessageBox.Show("เพิ่มข้อมูลสำเร็จ")

    End Sub
    Public Sub disp_data2()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from expen"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        DataGridView2.DataSource = dt
        exId.Text = ""
        exName.Text = ""
        exPrice.Text = ""

        Dim colsum As Decimal

        For Each R As DataGridViewRow In DataGridView2.Rows

            colsum += R.Cells(2).Value

        Next
        sum2.Text = colsum
        sum3.Text = Int(sum1.Text) - Int(sum2.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles del2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from expen where exId='" & exId.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data()
        disp_data2()
        MessageBox.Show("ลบข้อมูลสำเร็จ")
    End Sub

    Private Sub edit2_Click(sender As Object, e As EventArgs) Handles edit2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update expen set exName='" & exName.Text & "', exPrice='" & exPrice.Text & "', exDate='" & exDate.Value & "', exId='" & exId.Text & "' where exId=" & i2 & ""
        cmd.ExecuteNonQuery()
        disp_data()
        disp_data2()
        MessageBox.Show("แก้ไขข้อมูลสำเร็จ")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class