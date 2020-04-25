<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet1 = New RMS_Project.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New RMS_Project.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ShopDataSet1 = New RMS_Project.ShopDataSet1()
        Me.incomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.incomeTableAdapter = New RMS_Project.ShopDataSet1TableAdapters.incomeTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ShopDataSet2 = New RMS_Project.ShopDataSet2()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New RMS_Project.ShopDataSet2TableAdapters.orderTableAdapter()
        Me.OrderidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.incomeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RMS_Project.ReportIncome.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(50, 330)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(813, 243)
        Me.ReportViewer1.TabIndex = 2
        '
        'ShopDataSet1
        '
        Me.ShopDataSet1.DataSetName = "ShopDataSet1"
        Me.ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'incomeBindingSource
        '
        Me.incomeBindingSource.DataMember = "income"
        Me.incomeBindingSource.DataSource = Me.ShopDataSet1
        '
        'incomeTableAdapter
        '
        Me.incomeTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderidDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.TableidDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(121, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(689, 179)
        Me.DataGridView1.TabIndex = 3
        '
        'ShopDataSet2
        '
        Me.ShopDataSet2.DataSetName = "ShopDataSet2"
        Me.ShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.ShopDataSet2
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'OrderidDataGridViewTextBoxColumn
        '
        Me.OrderidDataGridViewTextBoxColumn.DataPropertyName = "order_id"
        Me.OrderidDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.OrderidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn"
        Me.OrderidDataGridViewTextBoxColumn.Width = 125
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "วันที่"
        Me.OrderdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.Width = 125
        '
        'TableidDataGridViewTextBoxColumn
        '
        Me.TableidDataGridViewTextBoxColumn.DataPropertyName = "table_id"
        Me.TableidDataGridViewTextBoxColumn.HeaderText = "โต๊ะที่"
        Me.TableidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableidDataGridViewTextBoxColumn.Name = "TableidDataGridViewTextBoxColumn"
        Me.TableidDataGridViewTextBoxColumn.Width = 125
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "ราคารวม"
        Me.TotalpriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        Me.TotalpriceDataGridViewTextBoxColumn.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "บิล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "รายงานรายรับ"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 585)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form4"
        Me.Text = "ใบเสร็จ"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents incomeBindingSource As BindingSource
    Friend WithEvents ShopDataSet1 As ShopDataSet1
    Friend WithEvents incomeTableAdapter As ShopDataSet1TableAdapters.incomeTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ShopDataSet2 As ShopDataSet2
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As ShopDataSet2TableAdapters.orderTableAdapter
    Friend WithEvents OrderidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
