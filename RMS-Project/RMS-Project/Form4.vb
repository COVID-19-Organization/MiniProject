Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.DataSet1.Table)


    End Sub
End Class