Public Class b
    Sub showdata(ByVal show As String)
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\6110210305_LAB5\6110210305_LAB5\Database1.mdf;Integrated Security=True")
        Dim query As String = "SELECT Student.StudentId , student.FirstName ,Student.LastName , Faculty.FacultyName,Student.GPA FROM Student JOIN Faculty ON Student.FacultyId=Faculty.FacultyId;"
        cmd = New SqlCommand(query, con)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt



        Dim stablefull As Int64 = 0
        Dim stableempty As Int64 = 10
    Private Sub b_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busytable.Text = stablefull.ToString
        emptytable.Text = stableempty.ToString
    End Sub
    Private Sub btnTableA1_Click(sender As Object, e As EventArgs) Handles btnTableA1.Click
        If btnTableA1.BackColor = Color.LightGreen Then

            If MessageBox.Show("คุณต้องการจองโต๊ะ A1 ใช่หรือไม่ ?", "จองโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA1.BackColor = Color.LightCoral

                busytable.Text = stablefull.ToString
                emptytable.Text = stableempty.ToString
            End If
        Else
            If MessageBox.Show("โต๊ะนี้ไม่ว่างกรุณาเลือกโต๊ะอื่น", "โต๊ะไม่ว่าง", MessageBoxButtons.OK) = DialogResult.OK Then
                btnTableA1.BackColor = Color.LightCoral

                busytable.Text = stablefull.ToString
                emptytable.Text = stableempty.ToString
            End If
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class