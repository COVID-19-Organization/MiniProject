<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid_Showmenu = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Add_Id = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txt_Add_Price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Add_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Up_Price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Up_Name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Up_Id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_De_Price = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_De_Name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_De_Id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGrid_Showmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("TH Sarabun New", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(0, -5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1072, 57)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "จัดการข้อมูลรายการอาหาร"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGrid_Showmenu
        '
        Me.DataGrid_Showmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Showmenu.Location = New System.Drawing.Point(27, 114)
        Me.DataGrid_Showmenu.Name = "DataGrid_Showmenu"
        Me.DataGrid_Showmenu.RowHeadersWidth = 51
        Me.DataGrid_Showmenu.RowTemplate.Height = 24
        Me.DataGrid_Showmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid_Showmenu.Size = New System.Drawing.Size(432, 560)
        Me.DataGrid_Showmenu.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("TH Sarabun New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(465, 114)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(484, 414)
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_Add_Id)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.txt_Add_Price)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_Add_Name)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Font = New System.Drawing.Font("TH Sarabun New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(476, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มรายการอาหาร"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(342, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 45)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "ยกเลิก"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 45)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "ต้องการเพิ่มข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "รหัสอาหาร"
        '
        'txt_Add_Id
        '
        Me.txt_Add_Id.Enabled = False
        Me.txt_Add_Id.Location = New System.Drawing.Point(155, 52)
        Me.txt_Add_Id.Name = "txt_Add_Id"
        Me.txt_Add_Id.Size = New System.Drawing.Size(183, 34)
        Me.txt_Add_Id.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(216, 267)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 45)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txt_Add_Price
        '
        Me.txt_Add_Price.Enabled = False
        Me.txt_Add_Price.Location = New System.Drawing.Point(155, 174)
        Me.txt_Add_Price.Name = "txt_Add_Price"
        Me.txt_Add_Price.Size = New System.Drawing.Size(183, 34)
        Me.txt_Add_Price.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ราคาอาหาร"
        '
        'txt_Add_Name
        '
        Me.txt_Add_Name.Enabled = False
        Me.txt_Add_Name.Location = New System.Drawing.Point(155, 114)
        Me.txt_Add_Name.Name = "txt_Add_Name"
        Me.txt_Add_Name.Size = New System.Drawing.Size(183, 34)
        Me.txt_Add_Name.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ชื่ออาหาร"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txt_Up_Price)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_Up_Name)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_Up_Id)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(476, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขรายการอาหาร"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(224, 277)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 45)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "ยกเลิก"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 45)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "แก้ไข"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Up_Price
        '
        Me.txt_Up_Price.Enabled = False
        Me.txt_Up_Price.Location = New System.Drawing.Point(165, 176)
        Me.txt_Up_Price.Name = "txt_Up_Price"
        Me.txt_Up_Price.Size = New System.Drawing.Size(183, 30)
        Me.txt_Up_Price.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ราคาอาหาร"
        '
        'txt_Up_Name
        '
        Me.txt_Up_Name.Enabled = False
        Me.txt_Up_Name.Location = New System.Drawing.Point(165, 108)
        Me.txt_Up_Name.Name = "txt_Up_Name"
        Me.txt_Up_Name.Size = New System.Drawing.Size(183, 30)
        Me.txt_Up_Name.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ชื่ออาหาร"
        '
        'txt_Up_Id
        '
        Me.txt_Up_Id.Enabled = False
        Me.txt_Up_Id.Location = New System.Drawing.Point(166, 37)
        Me.txt_Up_Id.Name = "txt_Up_Id"
        Me.txt_Up_Id.Size = New System.Drawing.Size(183, 30)
        Me.txt_Up_Id.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "รหัส"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.txt_De_Price)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txt_De_Name)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txt_De_Id)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(476, 378)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบรายการอาหาร"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(232, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 45)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "ยกเลิก"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(86, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 45)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "ลบข้อมูล"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_De_Price
        '
        Me.txt_De_Price.Enabled = False
        Me.txt_De_Price.Location = New System.Drawing.Point(178, 179)
        Me.txt_De_Price.Name = "txt_De_Price"
        Me.txt_De_Price.Size = New System.Drawing.Size(183, 30)
        Me.txt_De_Price.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "ราคาอาหาร"
        '
        'txt_De_Name
        '
        Me.txt_De_Name.Enabled = False
        Me.txt_De_Name.Location = New System.Drawing.Point(178, 111)
        Me.txt_De_Name.Name = "txt_De_Name"
        Me.txt_De_Name.Size = New System.Drawing.Size(183, 30)
        Me.txt_De_Name.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ชื่ออาหาร"
        '
        'txt_De_Id
        '
        Me.txt_De_Id.Enabled = False
        Me.txt_De_Id.Location = New System.Drawing.Point(179, 40)
        Me.txt_De_Id.Name = "txt_De_Id"
        Me.txt_De_Id.Size = New System.Drawing.Size(183, 30)
        Me.txt_De_Id.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "รหัส"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1021, 651)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGrid_Showmenu)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGrid_Showmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGrid_Showmenu As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Add_Id As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txt_Add_Price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Add_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_Up_Price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Up_Name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Up_Id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_De_Price As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_De_Name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_De_Id As TextBox
    Friend WithEvents Label11 As Label
End Class
