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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inID
        '
        Me.inID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inID.Location = New System.Drawing.Point(136, 65)
        Me.inID.MaxLength = 5
        Me.inID.Name = "inID"
        Me.inID.Size = New System.Drawing.Size(257, 30)
        Me.inID.TabIndex = 2
        '
        'inname
        '
        Me.inname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inname.Location = New System.Drawing.Point(136, 101)
        Me.inname.Name = "inname"
        Me.inname.Size = New System.Drawing.Size(257, 30)
        Me.inname.TabIndex = 3
        '
        'save1
        '
        Me.save1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save1.Location = New System.Drawing.Point(67, 209)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(103, 37)
        Me.save1.TabIndex = 4
        Me.save1.Text = "บันทึก"
        Me.save1.UseVisualStyleBackColor = True
        '
        'inprice
        '
        Me.inprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inprice.Location = New System.Drawing.Point(136, 137)
        Me.inprice.Name = "inprice"
        Me.inprice.Size = New System.Drawing.Size(257, 30)
        Me.inprice.TabIndex = 5
        '
        'DateTimeIncome
        '
        Me.DateTimeIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeIncome.Location = New System.Drawing.Point(136, 173)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(257, 30)
        Me.DateTimeIncome.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัสรายรับ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "รายละเอียด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "จำนวน(บาท)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 173)
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
        Me.DataGridView1.Location = New System.Drawing.Point(399, 65)
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
        Me.edit1.Location = New System.Drawing.Point(176, 209)
        Me.edit1.Name = "edit1"
        Me.edit1.Size = New System.Drawing.Size(103, 37)
        Me.edit1.TabIndex = 12
        Me.edit1.Text = "แก้ไข"
        Me.edit1.UseVisualStyleBackColor = True
        '
        'del1
        '
        Me.del1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del1.Location = New System.Drawing.Point(285, 209)
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
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 450)
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
End Class
