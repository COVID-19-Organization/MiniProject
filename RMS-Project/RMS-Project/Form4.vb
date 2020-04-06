Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet1.Table' table. You can move, or remove it, as needed.



        Me.ReportViewer1.RefreshReport
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class