Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form5.Show()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Form4.Show()
    End Sub
End Class
