<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inID = New System.Windows.Forms.TextBox()
        Me.inname = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.inprice = New System.Windows.Forms.TextBox()
        Me.DateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'inID
        '
        Me.inID.Location = New System.Drawing.Point(67, 58)
        Me.inID.Name = "inID"
        Me.inID.Size = New System.Drawing.Size(100, 22)
        Me.inID.TabIndex = 2
        '
        'inname
        '
        Me.inname.Location = New System.Drawing.Point(67, 95)
        Me.inname.Name = "inname"
        Me.inname.Size = New System.Drawing.Size(100, 22)
        Me.inname.TabIndex = 3
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(67, 205)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'inprice
        '
        Me.inprice.Location = New System.Drawing.Point(67, 133)
        Me.inprice.Name = "inprice"
        Me.inprice.Size = New System.Drawing.Size(100, 22)
        Me.inprice.TabIndex = 5
        '
        'DateTimeIncome
        '
        Me.DateTimeIncome.Location = New System.Drawing.Point(67, 162)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(203, 22)
        Me.DateTimeIncome.TabIndex = 6
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 450)
        Me.Controls.Add(Me.DateTimeIncome)
        Me.Controls.Add(Me.inprice)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.inname)
        Me.Controls.Add(Me.inID)
        Me.Name = "Form5"
        Me.Text = "รายรับรายจ่าย"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inID As TextBox
    Friend WithEvents inname As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents inprice As TextBox
    Friend WithEvents DateTimeIncome As DateTimePicker
End Class
