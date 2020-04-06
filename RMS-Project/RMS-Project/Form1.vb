Public Class Form1

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Form3.Show()
    End Sub

    Private Sub btnTableA1_Click(sender As Object, e As EventArgs) Handles btnTableA1.Click
        If btnTableA1.BackColor = Color.LightGreen Then
            If MessageBox.Show("คุณต้องการจะเปิดโต๊ะ A1 ใช่หรือไม่ ?", "เปิดโต๊ะ", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                btnTableA1.BackColor = Color.LightCoral
            End If
        Else
            If MessageBox.Show("คุณต้องการจะเช็คบิลโต๊ะ A1 ใช่หรือไม่ ?", "เช็คบิลโต๊ะ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnTableA1.BackColor = Color.LightGreen
            End If
        End If
    End Sub

End Class
