<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New RMS_Project.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New RMS_Project.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.Menu = New RMS_Project.menu()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodTableAdapter = New RMS_Project.menuTableAdapters.foodTableAdapter()
        Me.FoodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table = New RMS_Project.table()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New RMS_Project.tableTableAdapters.TableTableAdapter()
        Me.Table1 = New RMS_Project.table()
        Me.TableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการอาหาร"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodidDataGridViewTextBoxColumn, Me.FoodnameDataGridViewTextBoxColumn, Me.FoodpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(321, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(345, 342)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(746, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รายการที่สั่ง/ราคา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เลือกโต๊ะอาหาร"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(781, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "สั่งอาหาร"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Menu
        '
        Me.Menu.DataSetName = "menu"
        Me.Menu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataSource = Me.Menu
        Me.MenuBindingSource.Position = 0
        '
        'MenuBindingSource1
        '
        Me.MenuBindingSource1.DataSource = Me.Menu
        Me.MenuBindingSource1.Position = 0
        '
        'FoodBindingSource
        '
        Me.FoodBindingSource.DataMember = "food"
        Me.FoodBindingSource.DataSource = Me.Menu
        '
        'FoodTableAdapter
        '
        Me.FoodTableAdapter.ClearBeforeFill = True
        '
        'FoodidDataGridViewTextBoxColumn
        '
        Me.FoodidDataGridViewTextBoxColumn.DataPropertyName = "food_id"
        Me.FoodidDataGridViewTextBoxColumn.HeaderText = "food_id"
        Me.FoodidDataGridViewTextBoxColumn.Name = "FoodidDataGridViewTextBoxColumn"
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
        'Table
        '
        Me.Table.DataSetName = "table"
        Me.Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Table
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Table1
        '
        Me.Table1.DataSetName = "table"
        Me.Table1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource1
        '
        Me.TableBindingSource1.DataMember = "Table"
        Me.TableBindingSource1.DataSource = Me.Table1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TableBindingSource, "table_number", True))
        Me.ComboBox1.DataSource = Me.TableBindingSource1
        Me.ComboBox1.DisplayMember = "table_number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(48, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "table_number"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1181, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents MenuBindingSource1 As BindingSource
    Friend WithEvents Menu As menu
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodTableAdapter As menuTableAdapters.foodTableAdapter
    Friend WithEvents FoodidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Table As table
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As tableTableAdapters.TableTableAdapter
    Friend WithEvents Table1 As table
    Friend WithEvents TableBindingSource1 As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
End Class
