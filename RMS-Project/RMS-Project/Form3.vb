Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Table1._Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Table1._Table)
        'TODO: This line of code loads data into the 'Table._Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Table._Table)
        'TODO: This line of code loads data into the 'Menu.food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.Menu.food)
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)

    End Sub
End Class