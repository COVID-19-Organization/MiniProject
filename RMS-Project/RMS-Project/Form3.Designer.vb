<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class b
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food = New RMS_Project.food()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sum = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbbTable = New System.Windows.Forms.ComboBox()
        Me.ShoptableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table = New RMS_Project.table()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.FoodTableAdapter = New RMS_Project.foodTableAdapters.foodTableAdapter()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1 = New RMS_Project.table()
        Me.ShoptableTableAdapter = New RMS_Project.tableTableAdapters.shoptableTableAdapter()
        Me.sub2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShoptableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodnameDataGridViewTextBoxColumn, Me.FoodpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(491, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(265, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'FoodnameDataGridViewTextBoxColumn
        '
        Me.FoodnameDataGridViewTextBoxColumn.DataPropertyName = "food_name"
        Me.FoodnameDataGridViewTextBoxColumn.HeaderText = "food_name"
        Me.FoodnameDataGridViewTextBoxColumn.Name = "FoodnameDataGridViewTextBoxColumn"
        '
        'FoodpriceDataGridViewTextBoxColumn
        '
        Me.FoodpriceDataGridViewTextBoxColumn.DataPropertyName = "food_price"
        Me.FoodpriceDataGridViewTextBoxColumn.HeaderText = "food_price"
        Me.FoodpriceDataGridViewTextBoxColumn.Name = "FoodpriceDataGridViewTextBoxColumn"
        '
        'FoodBindingSource
        '
        Me.FoodBindingSource.DataMember = "food"
        Me.FoodBindingSource.DataSource = Me.Food
        '
        'Food
        '
        Me.Food.DataSetName = "food"
        Me.Food.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.sum)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Num1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cbbTable)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimeIncome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.submit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 418)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สั่งอาหาร"
        '
        'sum
        '
        Me.sum.AutoSize = True
        Me.sum.Location = New System.Drawing.Point(59, 365)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(31, 18)
        Me.sum.TabIndex = 37
        Me.sum.Text = "รวม"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 208)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(318, 150)
        Me.DataGridView2.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "ราคา"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(217, 129)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(62, 26)
        Me.TextBox3.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 29)
        Me.TextBox2.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "รหัสออเดอร์"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(286, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 26)
        Me.TextBox1.TabIndex = 30
        '
        'cbbTable
        '
        Me.cbbTable.DataSource = Me.ShoptableBindingSource
        Me.cbbTable.DisplayMember = "table_num"
        Me.cbbTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbTable.FormattingEnabled = True
        Me.cbbTable.Location = New System.Drawing.Point(76, 65)
        Me.cbbTable.Name = "cbbTable"
        Me.cbbTable.Size = New System.Drawing.Size(122, 28)
        Me.cbbTable.TabIndex = 29
        Me.cbbTable.ValueMember = "table_id"
        '
        'ShoptableBindingSource
        '
        Me.ShoptableBindingSource.DataMember = "shoptable"
        Me.ShoptableBindingSource.DataSource = Me.Table
        '
        'Table
        '
        Me.Table.DataSetName = "table"
        Me.Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "จำนวน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "อาหารที่สั่ง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "วันที่"
        '
        'DateTimeIncome
        '
        Me.DateTimeIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeIncome.Location = New System.Drawing.Point(76, 37)
        Me.DateTimeIncome.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(177, 23)
        Me.DateTimeIncome.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "โต๊ะ"
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(125, 160)
        Me.submit.Margin = New System.Windows.Forms.Padding(2)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(73, 33)
        Me.submit.TabIndex = 0
        Me.submit.Text = "ยืนยัน"
        Me.submit.UseVisualStyleBackColor = True
        '
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Table1
        '
        'Table1
        '
        Me.Table1.DataSetName = "table"
        Me.Table1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShoptableTableAdapter
        '
        Me.ShoptableTableAdapter.ClearBeforeFill = True
        '
        'sub2
        '
        Me.sub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub2.Location = New System.Drawing.Point(557, 328)
        Me.sub2.Margin = New System.Windows.Forms.Padding(2)
        Me.sub2.Name = "sub2"
        Me.sub2.Size = New System.Drawing.Size(108, 33)
        Me.sub2.TabIndex = 37
        Me.sub2.Text = "สั่งอาหาร"
        Me.sub2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(344, 128)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(62, 26)
        Me.TextBox4.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ทั้งหมด"
        '
        'Num1
        '
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(286, 126)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(42, 29)
        Me.Num1.TabIndex = 33
        '
        'b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(764, 432)
        Me.Controls.Add(Me.sub2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "b"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShoptableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents Table1 As table
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents submit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeIncome As DateTimePicker
    Friend WithEvents Food As food
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodTableAdapter As foodTableAdapters.foodTableAdapter
    Friend WithEvents FoodnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbTable As ComboBox
    Friend WithEvents Table As table
    Friend WithEvents ShoptableBindingSource As BindingSource
    Friend WithEvents ShoptableTableAdapter As tableTableAdapters.shoptableTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents sub2 As Button
    Friend WithEvents sum As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Num1 As NumericUpDown
End Class
