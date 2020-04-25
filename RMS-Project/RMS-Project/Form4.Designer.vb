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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReportViewer1.Location = New System.Drawing.Point(536, 152)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(514, 243)
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 490)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form4"
        Me.Text = "ใบเสร็จ"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents incomeBindingSource As BindingSource
    Friend WithEvents ShopDataSet1 As ShopDataSet1
    Friend WithEvents incomeTableAdapter As ShopDataSet1TableAdapters.incomeTableAdapter
End Class
