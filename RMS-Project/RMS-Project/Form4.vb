Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopDataSet2.order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.ShopDataSet2.order)
        'TODO: This line of code loads data into the 'ShopDataSet1.income' table. You can move, or remove it, as needed.
        Me.incomeTableAdapter.Fill(Me.ShopDataSet1.income)
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet1.Table' table. You can move, or remove it, as needed.




        Me.ReportViewer1.RefreshReport
    End Sub
End Class