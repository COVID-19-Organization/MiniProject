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
        Me.incomeID = New System.Windows.Forms.TextBox()
        Me.incomeName = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'incomeID
        '
        Me.incomeID.Location = New System.Drawing.Point(67, 83)
        Me.incomeID.Name = "incomeID"
        Me.incomeID.Size = New System.Drawing.Size(100, 22)
        Me.incomeID.TabIndex = 2
        '
        'incomeName
        '
        Me.incomeName.Location = New System.Drawing.Point(67, 135)
        Me.incomeName.Name = "incomeName"
        Me.incomeName.Size = New System.Drawing.Size(100, 22)
        Me.incomeName.TabIndex = 3
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
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 450)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.incomeName)
        Me.Controls.Add(Me.incomeID)
        Me.Name = "Form5"
        Me.Text = "รายรับรายจ่าย"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents incomeID As TextBox
    Friend WithEvents incomeName As TextBox
    Friend WithEvents btn1 As Button
End Class
