﻿Imports System.Data.SqlClient

Public Class Form1

    Dim stablefull As Int64 = 0
    Dim stableempty As Int64 = 10

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        b.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        disTableFull.Text = stablefull.ToString
        disTableEmpty.Text = stableempty.ToString

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\Shop.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from shoptable where table_status = 'Full'"
        cmd.ExecuteNonQuery()

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        b.cbbTable.DataSource = table
        b.cbbTable.DisplayMember = "table_num"
        b.cbbTable.ValueMember = "table_id"


    End Sub


    Private Sub btnTableA1_Click(sender As Object, e As EventArgs) Handles btnTableA1.Click
        If btnTableA1.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A1 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA1.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='1'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A1 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA1.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='1'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableA2_Click(sender As Object, e As EventArgs) Handles btnTableA2.Click
        If btnTableA2.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A2 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA2.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='2'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A2 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA2.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='2'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableA3_Click(sender As Object, e As EventArgs) Handles btnTableA3.Click
        If btnTableA3.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A3 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA3.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='3'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A3 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA3.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='3'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableA4_Click(sender As Object, e As EventArgs) Handles btnTableA4.Click
        If btnTableA4.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A4 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA4.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='4'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A4 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA4.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='4'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableA5_Click(sender As Object, e As EventArgs) Handles btnTableA5.Click
        If btnTableA5.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A5 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA5.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='5'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A5 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA5.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='5'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableB1_Click(sender As Object, e As EventArgs) Handles btnTableB1.Click
        If btnTableB1.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ B1 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableB1.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='6'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ B1 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableB1.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='6'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableB2_Click(sender As Object, e As EventArgs) Handles btnTableB2.Click
        If btnTableB2.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ B2 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableB2.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='7'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ B1 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableB2.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='7'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableB3_Click(sender As Object, e As EventArgs) Handles btnTableB3.Click
        If btnTableB3.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ B3 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableB3.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='8'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ B3 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableB3.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='8'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableB4_Click(sender As Object, e As EventArgs) Handles btnTableB4.Click
        If btnTableB4.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ B4 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableB4.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='9'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ B4 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableB4.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='9'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub btnTableB5_Click(sender As Object, e As EventArgs) Handles btnTableB5.Click
        If btnTableB5.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ B5 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableB5.BackColor = Color.LightCoral
                stablefull = stablefull + 1
                stableempty = stableempty - 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Full' where table_id='10'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ B5 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableB5.BackColor = Color.LightGreen
                stablefull = stablefull - 1
                stableempty = stableempty + 1
                disTableFull.Text = stablefull.ToString
                disTableEmpty.Text = stableempty.ToString

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update shoptable set table_status ='Empty' where table_id='10'"
                cmd.ExecuteNonQuery()
                disp_data()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
