﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopDataSet = New RMS_Project.ShopDataSet()
        Me.ExpenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopDataSet1 = New RMS_Project.ShopDataSet1()
        Me.inID = New System.Windows.Forms.TextBox()
        Me.inname = New System.Windows.Forms.TextBox()
        Me.save1 = New System.Windows.Forms.Button()
        Me.inprice = New System.Windows.Forms.TextBox()
        Me.DateTimeIncome = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IncomeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.edit1 = New System.Windows.Forms.Button()
        Me.del1 = New System.Windows.Forms.Button()
        Me.IncomeTableAdapter = New RMS_Project.ShopDataSetTableAdapters.incomeTableAdapter()
        Me.del2 = New System.Windows.Forms.Button()
        Me.edit2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.exDate = New System.Windows.Forms.DateTimePicker()
        Me.exPrice = New System.Windows.Forms.TextBox()
        Me.add2 = New System.Windows.Forms.Button()
        Me.exName = New System.Windows.Forms.TextBox()
        Me.exId = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ExIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpenTableAdapter = New RMS_Project.ShopDataSet1TableAdapters.expenTableAdapter()
        Me.sum1 = New System.Windows.Forms.Label()
        Me.sum2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IncomeTableAdapter1 = New RMS_Project.ShopDataSet1TableAdapters.incomeTableAdapter()
        Me.sum3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        'ExpenBindingSource
        '
        Me.ExpenBindingSource.DataMember = "expen"
        Me.ExpenBindingSource.DataSource = Me.ShopDataSet1
        '
        'ShopDataSet1
        '
        Me.ShopDataSet1.DataSetName = "ShopDataSet1"
        Me.ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.save1.Text = "เพิ่ม"
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
        Me.DateTimeIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeIncome.Location = New System.Drawing.Point(130, 148)
        Me.DateTimeIncome.Name = "DateTimeIncome"
        Me.DateTimeIncome.Size = New System.Drawing.Size(257, 22)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncomeIDDataGridViewTextBoxColumn, Me.IncomeNameDataGridViewTextBoxColumn, Me.IncomePriceDataGridViewTextBoxColumn, Me.IncomeDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IncomeBindingSource1
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
        'IncomeBindingSource1
        '
        Me.IncomeBindingSource1.DataMember = "income"
        Me.IncomeBindingSource1.DataSource = Me.ShopDataSet1
        '
        'edit1
        '
        Me.edit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit1.Location = New System.Drawing.Point(279, 184)
        Me.edit1.Name = "edit1"
        Me.edit1.Size = New System.Drawing.Size(103, 37)
        Me.edit1.TabIndex = 12
        Me.edit1.Text = "แก้ไข"
        Me.edit1.UseVisualStyleBackColor = True
        '
        'del1
        '
        Me.del1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del1.Location = New System.Drawing.Point(170, 184)
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
        'del2
        '
        Me.del2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del2.Location = New System.Drawing.Point(170, 448)
        Me.del2.Name = "del2"
        Me.del2.Size = New System.Drawing.Size(103, 37)
        Me.del2.TabIndex = 24
        Me.del2.Text = "ลบ"
        Me.del2.UseVisualStyleBackColor = True
        '
        'edit2
        '
        Me.edit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit2.Location = New System.Drawing.Point(279, 448)
        Me.edit2.Name = "edit2"
        Me.edit2.Size = New System.Drawing.Size(103, 37)
        Me.edit2.TabIndex = 23
        Me.edit2.Text = "แก้ไข"
        Me.edit2.UseVisualStyleBackColor = True
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
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "รหัสรายจ่าย"
        '
        'exDate
        '
        Me.exDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exDate.Location = New System.Drawing.Point(130, 414)
        Me.exDate.Name = "exDate"
        Me.exDate.Size = New System.Drawing.Size(257, 22)
        Me.exDate.TabIndex = 18
        '
        'exPrice
        '
        Me.exPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exPrice.Location = New System.Drawing.Point(130, 378)
        Me.exPrice.Name = "exPrice"
        Me.exPrice.Size = New System.Drawing.Size(257, 30)
        Me.exPrice.TabIndex = 17
        '
        'add2
        '
        Me.add2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add2.Location = New System.Drawing.Point(61, 448)
        Me.add2.Name = "add2"
        Me.add2.Size = New System.Drawing.Size(103, 37)
        Me.add2.TabIndex = 16
        Me.add2.Text = "เพิ่ม"
        Me.add2.UseVisualStyleBackColor = True
        '
        'exName
        '
        Me.exName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exName.Location = New System.Drawing.Point(130, 342)
        Me.exName.Name = "exName"
        Me.exName.Size = New System.Drawing.Size(257, 30)
        Me.exName.TabIndex = 15
        '
        'exId
        '
        Me.exId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exId.Location = New System.Drawing.Point(130, 306)
        Me.exId.MaxLength = 5
        Me.exId.Name = "exId"
        Me.exId.Size = New System.Drawing.Size(257, 30)
        Me.exId.TabIndex = 14
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExIdDataGridViewTextBoxColumn, Me.ExNameDataGridViewTextBoxColumn, Me.ExPriceDataGridViewTextBoxColumn, Me.ExDateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ExpenBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(435, 306)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(550, 179)
        Me.DataGridView2.TabIndex = 25
        '
        'ExIdDataGridViewTextBoxColumn
        '
        Me.ExIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ExIdDataGridViewTextBoxColumn.DataPropertyName = "exId"
        Me.ExIdDataGridViewTextBoxColumn.HeaderText = "รหัสรายจ่าย"
        Me.ExIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExIdDataGridViewTextBoxColumn.Name = "ExIdDataGridViewTextBoxColumn"
        '
        'ExNameDataGridViewTextBoxColumn
        '
        Me.ExNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ExNameDataGridViewTextBoxColumn.DataPropertyName = "exName"
        Me.ExNameDataGridViewTextBoxColumn.HeaderText = "รหัสรายรับ"
        Me.ExNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExNameDataGridViewTextBoxColumn.Name = "ExNameDataGridViewTextBoxColumn"
        Me.ExNameDataGridViewTextBoxColumn.Width = 95
        '
        'ExPriceDataGridViewTextBoxColumn
        '
        Me.ExPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ExPriceDataGridViewTextBoxColumn.DataPropertyName = "exPrice"
        Me.ExPriceDataGridViewTextBoxColumn.HeaderText = "จำนวนเงิน"
        Me.ExPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExPriceDataGridViewTextBoxColumn.Name = "ExPriceDataGridViewTextBoxColumn"
        Me.ExPriceDataGridViewTextBoxColumn.Width = 94
        '
        'ExDateDataGridViewTextBoxColumn
        '
        Me.ExDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ExDateDataGridViewTextBoxColumn.DataPropertyName = "exDate"
        Me.ExDateDataGridViewTextBoxColumn.HeaderText = "วันที่และเวลา"
        Me.ExDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExDateDataGridViewTextBoxColumn.Name = "ExDateDataGridViewTextBoxColumn"
        Me.ExDateDataGridViewTextBoxColumn.Width = 106
        '
        'ExpenTableAdapter
        '
        Me.ExpenTableAdapter.ClearBeforeFill = True
        '
        'sum1
        '
        Me.sum1.AutoSize = True
        Me.sum1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.sum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum1.ForeColor = System.Drawing.Color.Red
        Me.sum1.Location = New System.Drawing.Point(892, 227)
        Me.sum1.Name = "sum1"
        Me.sum1.Size = New System.Drawing.Size(24, 25)
        Me.sum1.TabIndex = 26
        Me.sum1.Text = "0"
        '
        'sum2
        '
        Me.sum2.AutoSize = True
        Me.sum2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.sum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum2.ForeColor = System.Drawing.Color.Red
        Me.sum2.Location = New System.Drawing.Point(892, 488)
        Me.sum2.Name = "sum2"
        Me.sum2.Size = New System.Drawing.Size(24, 25)
        Me.sum2.TabIndex = 27
        Me.sum2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(774, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "รวมรายรับ :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(774, 488)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "รวมรายจ่าย :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(938, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "บาท"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(938, 488)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 25)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "บาท"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(28, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(454, 17)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "*หากต้องการเพิ่ม ลบ หรือแก้ไขข้อมูล กรุณาเลือกข้อมูลจากช่องรหัสเท่านั้น"
        '
        'IncomeTableAdapter1
        '
        Me.IncomeTableAdapter1.ClearBeforeFill = True
        '
        'sum3
        '
        Me.sum3.AutoSize = True
        Me.sum3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.sum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum3.ForeColor = System.Drawing.Color.Red
        Me.sum3.Location = New System.Drawing.Point(889, 530)
        Me.sum3.Name = "sum3"
        Me.sum3.Size = New System.Drawing.Size(24, 25)
        Me.sum3.TabIndex = 34
        Me.sum3.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(737, 530)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 25)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "ยอดเงินคงเหลือ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(945, 530)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 25)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "บาท"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(124, 257)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 32)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "รายจ่าย"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(124, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 32)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "รายรับ"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(885, -3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "ปิดหน้าต่าง"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(31, 577)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(935, 301)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(927, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายงานรายรับ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.IncomeBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "RMS_Project.ReportIncome.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(6, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(918, 246)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(927, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "รายงานรายจ่าย"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ExpenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RMS_Project.Reportexpen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(921, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(36, 536)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 25)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "รายงาน"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(32, 488)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(454, 17)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "*หากต้องการเพิ่ม ลบ หรือแก้ไขข้อมูล กรุณาเลือกข้อมูลจากช่องรหัสเท่านั้น"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 1055)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.sum3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sum2)
        Me.Controls.Add(Me.sum1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.del2)
        Me.Controls.Add(Me.edit2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.exDate)
        Me.Controls.Add(Me.exPrice)
        Me.Controls.Add(Me.add2)
        Me.Controls.Add(Me.exName)
        Me.Controls.Add(Me.exId)
        Me.Controls.Add(Me.del1)
        Me.Controls.Add(Me.edit1)
        Me.Controls.Add(Me.DataGridView1)
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
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
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
    Friend WithEvents del2 As Button
    Friend WithEvents edit2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents exDate As DateTimePicker
    Friend WithEvents exPrice As TextBox
    Friend WithEvents add2 As Button
    Friend WithEvents exName As TextBox
    Friend WithEvents exId As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ShopDataSet1 As ShopDataSet1
    Friend WithEvents ExpenBindingSource As BindingSource
    Friend WithEvents ExpenTableAdapter As ShopDataSet1TableAdapters.expenTableAdapter
    Friend WithEvents sum1 As Label
    Friend WithEvents sum2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ExIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents IncomeBindingSource1 As BindingSource
    Friend WithEvents IncomeTableAdapter1 As ShopDataSet1TableAdapters.incomeTableAdapter
    Friend WithEvents sum3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
