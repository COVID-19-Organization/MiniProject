Public Class Form6
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        rs.Open("select * from income", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs(0).Value = incomeID.Text
        rs(1).Value = incomeName.Text
        rs.Update()
        rs.Close()
        MsgBox("success")
        incomeID.Text = ""
        incomeName.Text = ""
    End Sub

    Private Sub incomeName_TextChanged(sender As Object, e As EventArgs) Handles incomeName.TextChanged

    End Sub

    Private Sub incomeID_TextChanged(sender As Object, e As EventArgs) Handles incomeID.TextChanged

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\RMS_db1.mdf;Integrated Security=True;Connect Timeout=30")
    End Sub
End Class