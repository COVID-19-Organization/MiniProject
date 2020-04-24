Public Class Form5
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COVID-19-Organization\MiniProject\RMS-Project\RMS-Project\RMS_db1.mdf;Integrated Security=True;Connect Timeout=30")
    End Sub

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
End Class