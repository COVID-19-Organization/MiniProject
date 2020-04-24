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
        Me.Table1 = New RMS_Project.table()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New RMS_Project.tableTableAdapters.DataTable1TableAdapter()
        Me.Table2 = New RMS_Project.table()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Menu = New RMS_Project.menu()
        Me.FoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodTableAdapter = New RMS_Project.menuTableAdapters.foodTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTableB5 = New System.Windows.Forms.Button()
        Me.btnTableB4 = New System.Windows.Forms.Button()
        Me.btnTableB3 = New System.Windows.Forms.Button()
        Me.btnTableB2 = New System.Windows.Forms.Button()
        Me.btnTableB1 = New System.Windows.Forms.Button()
        Me.btnTableA5 = New System.Windows.Forms.Button()
        Me.btnTableA4 = New System.Windows.Forms.Button()
        Me.btnTableA3 = New System.Windows.Forms.Button()
        Me.btnTableA2 = New System.Windows.Forms.Button()
        Me.btnTableA1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table1
        '
        Me.Table1.DataSetName = "table"
        Me.Table1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Table1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Table2
        '
        Me.Table2.DataSetName = "table"
        Me.Table2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.Table2
        '
        'DataTable1BindingSource2
        '
        Me.DataTable1BindingSource2.DataMember = "DataTable1"
        Me.DataTable1BindingSource2.DataSource = Me.Table2
        '
        'Menu
        '
        Me.Menu.DataSetName = "menu"
        Me.Menu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTableB5)
        Me.GroupBox1.Controls.Add(Me.btnTableB4)
        Me.GroupBox1.Controls.Add(Me.btnTableB3)
        Me.GroupBox1.Controls.Add(Me.btnTableB2)
        Me.GroupBox1.Controls.Add(Me.btnTableB1)
        Me.GroupBox1.Controls.Add(Me.btnTableA5)
        Me.GroupBox1.Controls.Add(Me.btnTableA4)
        Me.GroupBox1.Controls.Add(Me.btnTableA3)
        Me.GroupBox1.Controls.Add(Me.btnTableA2)
        Me.GroupBox1.Controls.Add(Me.btnTableA1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(616, 188)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกโต๊ะอาหาร"
        '
        'btnTableB5
        '
        Me.btnTableB5.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableB5.Location = New System.Drawing.Point(493, 117)
        Me.btnTableB5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableB5.Name = "btnTableB5"
        Me.btnTableB5.Size = New System.Drawing.Size(113, 59)
        Me.btnTableB5.TabIndex = 9
        Me.btnTableB5.Text = "B5"
        Me.btnTableB5.UseVisualStyleBackColor = False
        '
        'btnTableB4
        '
        Me.btnTableB4.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableB4.Location = New System.Drawing.Point(372, 117)
        Me.btnTableB4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableB4.Name = "btnTableB4"
        Me.btnTableB4.Size = New System.Drawing.Size(113, 59)
        Me.btnTableB4.TabIndex = 8
        Me.btnTableB4.Text = "B4"
        Me.btnTableB4.UseVisualStyleBackColor = False
        '
        'btnTableB3
        '
        Me.btnTableB3.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableB3.Location = New System.Drawing.Point(251, 117)
        Me.btnTableB3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableB3.Name = "btnTableB3"
        Me.btnTableB3.Size = New System.Drawing.Size(113, 59)
        Me.btnTableB3.TabIndex = 7
        Me.btnTableB3.Text = "B3"
        Me.btnTableB3.UseVisualStyleBackColor = False
        '
        'btnTableB2
        '
        Me.btnTableB2.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableB2.Location = New System.Drawing.Point(129, 117)
        Me.btnTableB2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableB2.Name = "btnTableB2"
        Me.btnTableB2.Size = New System.Drawing.Size(113, 59)
        Me.btnTableB2.TabIndex = 6
        Me.btnTableB2.Text = "B2"
        Me.btnTableB2.UseVisualStyleBackColor = False
        '
        'btnTableB1
        '
        Me.btnTableB1.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableB1.Location = New System.Drawing.Point(8, 117)
        Me.btnTableB1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableB1.Name = "btnTableB1"
        Me.btnTableB1.Size = New System.Drawing.Size(113, 59)
        Me.btnTableB1.TabIndex = 5
        Me.btnTableB1.Text = "B1"
        Me.btnTableB1.UseVisualStyleBackColor = False
        '
        'btnTableA5
        '
        Me.btnTableA5.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableA5.Location = New System.Drawing.Point(493, 50)
        Me.btnTableA5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableA5.Name = "btnTableA5"
        Me.btnTableA5.Size = New System.Drawing.Size(113, 59)
        Me.btnTableA5.TabIndex = 4
        Me.btnTableA5.Text = "A5"
        Me.btnTableA5.UseVisualStyleBackColor = False
        '
        'btnTableA4
        '
        Me.btnTableA4.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableA4.Location = New System.Drawing.Point(372, 50)
        Me.btnTableA4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableA4.Name = "btnTableA4"
        Me.btnTableA4.Size = New System.Drawing.Size(113, 59)
        Me.btnTableA4.TabIndex = 3
        Me.btnTableA4.Text = "A4"
        Me.btnTableA4.UseVisualStyleBackColor = False
        '
        'btnTableA3
        '
        Me.btnTableA3.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableA3.Location = New System.Drawing.Point(251, 50)
        Me.btnTableA3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableA3.Name = "btnTableA3"
        Me.btnTableA3.Size = New System.Drawing.Size(113, 59)
        Me.btnTableA3.TabIndex = 2
        Me.btnTableA3.Text = "A3"
        Me.btnTableA3.UseVisualStyleBackColor = False
        '
        'btnTableA2
        '
        Me.btnTableA2.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableA2.Location = New System.Drawing.Point(129, 50)
        Me.btnTableA2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableA2.Name = "btnTableA2"
        Me.btnTableA2.Size = New System.Drawing.Size(113, 59)
        Me.btnTableA2.TabIndex = 1
        Me.btnTableA2.Text = "A2"
        Me.btnTableA2.UseVisualStyleBackColor = False
        '
        'btnTableA1
        '
        Me.btnTableA1.BackColor = System.Drawing.Color.LightGreen
        Me.btnTableA1.Location = New System.Drawing.Point(8, 50)
        Me.btnTableA1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTableA1.Name = "btnTableA1"
        Me.btnTableA1.Size = New System.Drawing.Size(113, 59)
        Me.btnTableA1.TabIndex = 0
        Me.btnTableA1.Text = "A1"
        Me.btnTableA1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 228)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(616, 233)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เลือกเมนูอาหารที่จะสั่ง"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightGreen
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(8, 50)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(174, 42)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "ข้าวขาหมูตุ๋น"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(190, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ข้าวต้มกุ้ง"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(332, 50)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ข้าวผัด"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(443, 50)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ข้าวไก่อบ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 100)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 42)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "ข้าวหน้าเป็ด"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(176, 100)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 42)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "ข้าวผัดหมู"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGreen
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(129, 150)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(187, 42)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "หมูทอดกรอบ"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGreen
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(8, 150)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(113, 42)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "เป็ดนึ่ง"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightGreen
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(324, 150)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(113, 42)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "ไก่ทอด"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightGreen
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(324, 100)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(175, 42)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "ข้าวหมูกรอบ"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(917, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table1 As table
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As tableTableAdapters.DataTable1TableAdapter
    Friend WithEvents Table2 As table
    Friend WithEvents DataTable1BindingSource1 As BindingSource
    Friend WithEvents DataTable1BindingSource2 As BindingSource
    Friend WithEvents Menu As menu
    Friend WithEvents FoodBindingSource As BindingSource
    Friend WithEvents FoodTableAdapter As menuTableAdapters.foodTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTableB5 As Button
    Friend WithEvents btnTableB4 As Button
    Friend WithEvents btnTableB3 As Button
    Friend WithEvents btnTableB2 As Button
    Friend WithEvents btnTableB1 As Button
    Friend WithEvents btnTableA5 As Button
    Friend WithEvents btnTableA4 As Button
    Friend WithEvents btnTableA3 As Button
    Friend WithEvents btnTableA2 As Button
    Friend WithEvents btnTableA1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
