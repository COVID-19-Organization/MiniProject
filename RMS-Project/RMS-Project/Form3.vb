Public Class b
    Sub showdata(ByVal show As String)



    End Sub

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