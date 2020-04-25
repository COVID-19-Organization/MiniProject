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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food = New RMS_Project.food()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.FoodTableAdapter = New RMS_Project.foodTableAdapters.foodTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbTable = New System.Windows.Forms.ComboBox()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1 = New RMS_Project.table()
        Me.Table = New RMS_Project.table()
        Me.ShoptableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShoptableTableAdapter = New RMS_Project.tableTableAdapters.shoptableTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShoptableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(354, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 418)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เลือกเมนูอาหารที่จะสั่ง"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodnameDataGridViewTextBoxColumn, Me.FoodpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(5, 44)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(390, 346)
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
        Me.GroupBox1.Controls.Add(Me.cbbTable)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimeIncome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.submit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 418)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สั่งอาหาร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-2, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "1."
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown8.Location = New System.Drawing.Point(233, 329)
        Me.NumericUpDown8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown8.TabIndex = 26
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(13, 329)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(162, 24)
        Me.TextBox9.TabIndex = 25
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown7.Location = New System.Drawing.Point(233, 301)
        Me.NumericUpDown7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown7.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(13, 301)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(162, 24)
        Me.TextBox8.TabIndex = 23
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown6.Location = New System.Drawing.Point(233, 274)
        Me.NumericUpDown6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown6.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(13, 274)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(162, 24)
        Me.TextBox7.TabIndex = 21
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown5.Location = New System.Drawing.Point(233, 246)
        Me.NumericUpDown5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown5.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(13, 246)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(162, 24)
        Me.TextBox6.TabIndex = 19
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(233, 219)
        Me.NumericUpDown4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown4.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(13, 219)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(162, 24)
        Me.TextBox5.TabIndex = 17
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(233, 191)
        Me.NumericUpDown3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(13, 191)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(162, 24)
        Me.TextBox4.TabIndex = 15
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(233, 163)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(13, 163)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(162, 24)
        Me.TextBox3.TabIndex = 13
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(233, 138)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(55, 23)
        Me.NumericUpDown1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(14, 136)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(162, 24)
        Me.TextBox2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 103)
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
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รายการอาหารที่สั่ง"
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
        Me.DateTimeIncome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(218, 23)
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(171, 364)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ยกเลิก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(22, 364)
        Me.submit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(105, 33)
        Me.submit.TabIndex = 0
        Me.submit.Text = "สั่งอาหาร"
        Me.submit.UseVisualStyleBackColor = True
        '
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "1."
        '
        'cbbTable
        '
        Me.cbbTable.DataSource = Me.ShoptableBindingSource
        Me.cbbTable.DisplayMember = "table_num"
        Me.cbbTable.FormattingEnabled = True
        Me.cbbTable.Location = New System.Drawing.Point(76, 65)
        Me.cbbTable.Name = "cbbTable"
        Me.cbbTable.Size = New System.Drawing.Size(122, 30)
        Me.cbbTable.TabIndex = 29
        Me.cbbTable.ValueMember = "table_id"
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
        'Table
        '
        Me.Table.DataSetName = "table"
        Me.Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShoptableBindingSource
        '
        Me.ShoptableBindingSource.DataMember = "shoptable"
        Me.ShoptableBindingSource.DataSource = Me.Table
        '
        'ShoptableTableAdapter
        '
        Me.ShoptableTableAdapter.ClearBeforeFill = True
        '
        'b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(764, 432)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "b"
        Me.Text = "Form3"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShoptableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents Table1 As table
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
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
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbTable As ComboBox
    Friend WithEvents Table As table
    Friend WithEvents ShoptableBindingSource As BindingSource
    Friend WithEvents ShoptableTableAdapter As tableTableAdapters.shoptableTableAdapter
End Class
