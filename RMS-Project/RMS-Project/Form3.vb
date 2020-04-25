Public Class b

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub b_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food._food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.Food._food)

    End Sub
End Class