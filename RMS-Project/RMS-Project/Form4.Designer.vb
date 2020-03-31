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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New RMS_Project.DataSet1()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New RMS_Project.DataSet1TableAdapters.TableTableAdapter()
        Me.TableidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablestatusidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableidDataGridViewTextBoxColumn, Me.TablenumberDataGridViewTextBoxColumn, Me.TablestatusidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(269, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(442, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.DataSet1
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableidDataGridViewTextBoxColumn
        '
        Me.TableidDataGridViewTextBoxColumn.DataPropertyName = "table_id"
        Me.TableidDataGridViewTextBoxColumn.HeaderText = "table_id"
        Me.TableidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableidDataGridViewTextBoxColumn.Name = "TableidDataGridViewTextBoxColumn"
        Me.TableidDataGridViewTextBoxColumn.Width = 125
        '
        'TablenumberDataGridViewTextBoxColumn
        '
        Me.TablenumberDataGridViewTextBoxColumn.DataPropertyName = "table_number"
        Me.TablenumberDataGridViewTextBoxColumn.HeaderText = "table_number"
        Me.TablenumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TablenumberDataGridViewTextBoxColumn.Name = "TablenumberDataGridViewTextBoxColumn"
        Me.TablenumberDataGridViewTextBoxColumn.Width = 125
        '
        'TablestatusidDataGridViewTextBoxColumn
        '
        Me.TablestatusidDataGridViewTextBoxColumn.DataPropertyName = "table_status_id"
        Me.TablestatusidDataGridViewTextBoxColumn.HeaderText = "table_status_id"
        Me.TablestatusidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TablestatusidDataGridViewTextBoxColumn.Name = "TablestatusidDataGridViewTextBoxColumn"
        Me.TablestatusidDataGridViewTextBoxColumn.Width = 125
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 490)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "ใบเสร็จ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As DataSet1TableAdapters.TableTableAdapter
    Friend WithEvents TableidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TablenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TablestatusidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
