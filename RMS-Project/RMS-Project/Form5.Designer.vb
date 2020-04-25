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
        Me.components = New System.ComponentModel.Container()
        Me.inID = New System.Windows.Forms.TextBox()
        Me.inname = New System.Windows.Forms.TextBox()
        Me.save1 = New System.Windows.Forms.Button()
        Me.inprice = New System.Windows.Forms.TextBox()
        Me.DateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IncomeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopDataSet = New RMS_Project.ShopDataSet()
        Me.edit1 = New System.Windows.Forms.Button()
        Me.del1 = New System.Windows.Forms.Button()
        Me.IncomeTableAdapter = New RMS_Project.ShopDataSetTableAdapters.incomeTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inID
        '
        Me.inID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inID.Location = New System.Drawing.Point(130, 40)
        Me.inID.MaxLength = 5
        Me.inID.Name = "inID"
        Me.inID.Size = New System.Drawing.Size(257, 30)
        Me.inID.TabIndex = 2
        '
        'inname
        '
        Me.inname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inname.Location = New System.Drawing.Point(130, 76)
        Me.inname.Name = "inname"
        Me.inname.Size = New System.Drawing.Size(257, 30)
        Me.inname.TabIndex = 3
        '
        'save1
        '
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save1.Location = New System.Drawing.Point(61, 184)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(103, 37)
        Me.save1.TabIndex = 4
        Me.save1.Text = "บันทึก"
        Me.save1.UseVisualStyleBackColor = True
        '
        'inprice
        '
        Me.inprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inprice.Location = New System.Drawing.Point(130, 112)
        Me.inprice.Name = "inprice"
        Me.inprice.Size = New System.Drawing.Size(257, 30)
        Me.inprice.TabIndex = 5
        '
        'DateTimeIncome
        '
        Me.DateTimeIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeIncome.Location = New System.Drawing.Point(130, 148)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(257, 30)
        Me.DateTimeIncome.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัสรายรับ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "รายละเอียด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "จำนวน(บาท)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "วันที่"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncomeIDDataGridViewTextBoxColumn, Me.IncomeNameDataGridViewTextBoxColumn, Me.IncomePriceDataGridViewTextBoxColumn, Me.IncomeDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IncomeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(435, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(550, 184)
        Me.DataGridView1.TabIndex = 11
        '
        'IncomeIDDataGridViewTextBoxColumn
        '
        Me.IncomeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IncomeIDDataGridViewTextBoxColumn.DataPropertyName = "incomeID"
        Me.IncomeIDDataGridViewTextBoxColumn.HeaderText = "รหัสรายรับ"
        Me.IncomeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomeIDDataGridViewTextBoxColumn.Name = "IncomeIDDataGridViewTextBoxColumn"
        Me.IncomeIDDataGridViewTextBoxColumn.Width = 74
        '
        'IncomeNameDataGridViewTextBoxColumn
        '
        Me.IncomeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IncomeNameDataGridViewTextBoxColumn.DataPropertyName = "incomeName"
        Me.IncomeNameDataGridViewTextBoxColumn.HeaderText = "รายละเอียดรายรับ"
        Me.IncomeNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomeNameDataGridViewTextBoxColumn.Name = "IncomeNameDataGridViewTextBoxColumn"
        Me.IncomeNameDataGridViewTextBoxColumn.Width = 107
        '
        'IncomePriceDataGridViewTextBoxColumn
        '
        Me.IncomePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IncomePriceDataGridViewTextBoxColumn.DataPropertyName = "IncomePrice"
        Me.IncomePriceDataGridViewTextBoxColumn.HeaderText = "จำนวนเงิน"
        Me.IncomePriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomePriceDataGridViewTextBoxColumn.Name = "IncomePriceDataGridViewTextBoxColumn"
        Me.IncomePriceDataGridViewTextBoxColumn.Width = 87
        '
        'IncomeDateDataGridViewTextBoxColumn
        '
        Me.IncomeDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IncomeDateDataGridViewTextBoxColumn.DataPropertyName = "IncomeDate"
        Me.IncomeDateDataGridViewTextBoxColumn.HeaderText = "วันที่และเวลา"
        Me.IncomeDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomeDateDataGridViewTextBoxColumn.Name = "IncomeDateDataGridViewTextBoxColumn"
        Me.IncomeDateDataGridViewTextBoxColumn.Width = 125
        '
        'IncomeBindingSource
        '
        Me.IncomeBindingSource.DataMember = "income"
        Me.IncomeBindingSource.DataSource = Me.ShopDataSet
        '
        'ShopDataSet
        '
        Me.ShopDataSet.DataSetName = "ShopDataSet"
        Me.ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'edit1
        '
        Me.edit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit1.Location = New System.Drawing.Point(170, 184)
        Me.edit1.Name = "edit1"
        Me.edit1.Size = New System.Drawing.Size(103, 37)
        Me.edit1.TabIndex = 12
        Me.edit1.Text = "แก้ไข"
        Me.edit1.UseVisualStyleBackColor = True
        '
        'del1
        '
        Me.del1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del1.Location = New System.Drawing.Point(279, 184)
        Me.del1.Name = "del1"
        Me.del1.Size = New System.Drawing.Size(103, 37)
        Me.del1.TabIndex = 13
        Me.del1.Text = "ลบ"
        Me.del1.UseVisualStyleBackColor = True
        '
        'IncomeTableAdapter
        '
        Me.IncomeTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(279, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "ลบ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(170, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 37)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "แก้ไข"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "วันที่"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "จำนวน(บาท)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "รายละเอียด"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "รหัสรายรับ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 414)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(257, 30)
        Me.DateTimePicker1.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(88, 334)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 30)
        Me.TextBox1.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(61, 450)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 37)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "บันทึก"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(130, 342)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(257, 30)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(130, 306)
        Me.TextBox3.MaxLength = 5
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(257, 30)
        Me.TextBox3.TabIndex = 14
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.del1)
        Me.Controls.Add(Me.edit1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimeIncome)
        Me.Controls.Add(Me.inprice)
        Me.Controls.Add(Me.save1)
        Me.Controls.Add(Me.inname)
        Me.Controls.Add(Me.inID)
        Me.Name = "Form5"
        Me.Text = "รายรับรายจ่าย"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inID As TextBox
    Friend WithEvents inname As TextBox
    Friend WithEvents save1 As Button
    Friend WithEvents inprice As TextBox
    Friend WithEvents DateTimeIncome As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents edit1 As Button
    Friend WithEvents del1 As Button
    Friend WithEvents ShopDataSet As ShopDataSet
    Friend WithEvents IncomeBindingSource As BindingSource
    Friend WithEvents IncomeTableAdapter As ShopDataSetTableAdapters.incomeTableAdapter
    Friend WithEvents IncomeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
