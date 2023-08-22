<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Profile
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSelectedClassGrade = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStudentGrade = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSelectedClass = New System.Windows.Forms.ComboBox()
        Me.dgvClassAverages = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClassGrade = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClassAverages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(141, 25)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(240, 26)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Student Name Profile"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-50, -3)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(571, 69)
        Me.ListBox1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "All Classess"
        '
        'lblSelectedClassGrade
        '
        Me.lblSelectedClassGrade.AutoSize = True
        Me.lblSelectedClassGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedClassGrade.Location = New System.Drawing.Point(421, 388)
        Me.lblSelectedClassGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedClassGrade.Name = "lblSelectedClassGrade"
        Me.lblSelectedClassGrade.Size = New System.Drawing.Size(58, 36)
        Me.lblSelectedClassGrade.TabIndex = 27
        Me.lblSelectedClassGrade.Text = "NA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 366)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Weighted Grade"
        '
        'dgvStudentGrade
        '
        Me.dgvStudentGrade.AllowUserToAddRows = False
        Me.dgvStudentGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvStudentGrade.Location = New System.Drawing.Point(233, 102)
        Me.dgvStudentGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvStudentGrade.Name = "dgvStudentGrade"
        Me.dgvStudentGrade.RowHeadersWidth = 51
        Me.dgvStudentGrade.RowTemplate.Height = 24
        Me.dgvStudentGrade.Size = New System.Drawing.Size(272, 257)
        Me.dgvStudentGrade.TabIndex = 25
        '
        'Column5
        '
        Me.Column5.HeaderText = "Name"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Percentage"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Class"
        '
        'cbxSelectedClass
        '
        Me.cbxSelectedClass.FormattingEnabled = True
        Me.cbxSelectedClass.Location = New System.Drawing.Point(274, 80)
        Me.cbxSelectedClass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxSelectedClass.Name = "cbxSelectedClass"
        Me.cbxSelectedClass.Size = New System.Drawing.Size(92, 21)
        Me.cbxSelectedClass.TabIndex = 23
        '
        'dgvClassAverages
        '
        Me.dgvClassAverages.AllowUserToAddRows = False
        Me.dgvClassAverages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClassAverages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvClassAverages.Location = New System.Drawing.Point(9, 102)
        Me.dgvClassAverages.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvClassAverages.Name = "dgvClassAverages"
        Me.dgvClassAverages.RowHeadersWidth = 51
        Me.dgvClassAverages.RowTemplate.Height = 24
        Me.dgvClassAverages.Size = New System.Drawing.Size(203, 257)
        Me.dgvClassAverages.TabIndex = 22
        '
        'Column1
        '
        Me.Column1.HeaderText = "Class"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Average Percentage"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(128, 370)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Average Grade"
        '
        'lblClassGrade
        '
        Me.lblClassGrade.AutoSize = True
        Me.lblClassGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassGrade.Location = New System.Drawing.Point(154, 391)
        Me.lblClassGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassGrade.Name = "lblClassGrade"
        Me.lblClassGrade.Size = New System.Drawing.Size(52, 31)
        Me.lblClassGrade.TabIndex = 36
        Me.lblClassGrade.Text = "NA"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(455, 70)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 25)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Student_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 432)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblClassGrade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSelectedClassGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvStudentGrade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxSelectedClass)
        Me.Controls.Add(Me.dgvClassAverages)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Student_Profile"
        Me.Text = "Student_Profile"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClassAverages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblStudentName As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSelectedClassGrade As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvStudentGrade As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSelectedClass As ComboBox
    Friend WithEvents dgvClassAverages As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lblClassGrade As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
