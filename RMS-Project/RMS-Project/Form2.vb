Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As New Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
        display_data()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into food values('" & txt_Add_Id.Text & "','" & txt_Add_Name.Text & "','" & txt_Add_Price.Text & "')"
        cmd.ExecuteNonQuery()


        display_data()
        MessageBox.Show("Record Inserted Successfully")

    End Sub

    Public Sub display_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select *from food"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        DataGrid_Showmenu.DataSource = dt
        txt_Add_Id.Text = ""
        txt_Add_Name.Text = ""
        txt_Add_Price.Text = ""



    End Sub

    Private Sub DataGrid_Showmenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Showmenu.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            i = Convert.ToInt32(DataGrid_Showmenu.SelectedCells.Item(0).Value.ToString())
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select *from food where food_id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                txt_Up_Id.Text = dr.GetInt32(0).ToString()
                txt_Up_Name.Text = dr.GetString(1).ToString()
                txt_Up_Price.Text = dr.GetInt32(2).ToString()
                txt_De_Id.Text = dr.GetInt32(0).ToString()
                txt_De_Name.Text = dr.GetString(1).ToString()
                txt_De_Price.Text = dr.GetInt32(2).ToString()

            End While
            txt_Up_Name.Enabled = True
            txt_Up_Price.Enabled = True
        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update food set food_name='" & txt_Up_Name.Text & "', food_price='" & txt_Up_Price.Text & "' where food_id=" & i & ""
        cmd.ExecuteNonQuery()
        display_data()
        MessageBox.Show("Record Update Successfully")
    End Sub

    Private Sub DataGrid_Showmenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Showmenu.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from food where food_id='" & txt_De_Id.Text & "'"
        cmd.ExecuteNonQuery()
        display_data()
        MessageBox.Show("Record Delete Successfully")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_Add_Id.Enabled = True
        txt_Add_Name.Enabled = True
        txt_Add_Price.Enabled = True

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_Add_Id.Text = ""
        txt_Add_Name.Text = ""
        txt_Add_Price.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_Up_Id.Text = ""
        txt_Up_Name.Text = ""
        txt_Up_Price.Text = ""



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_De_Id.Text = ""
        txt_De_Name.Text = ""
        txt_De_Price.Text = ""
    End Sub

    Private Sub txt_Add_Id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Add_Id.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาป้อนข้อมูลเป็นตัวเลข")
        End Select

    End Sub

    Private Sub txt_Add_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Add_Price.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาป้อนข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txt_Up_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Up_Price.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาป้อนข้อมูลเป็นตัวเลข")
        End Select
    End Sub
End Class
