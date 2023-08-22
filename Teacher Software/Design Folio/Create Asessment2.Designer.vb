<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Asessment2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnDeleteAssessment = New System.Windows.Forms.Button()
        Me.btnEditAssessment = New System.Windows.Forms.Button()
        Me.btnCreatAssessment = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gpOptionsEditA = New System.Windows.Forms.GroupBox()
        Me.rdoMarks = New System.Windows.Forms.RadioButton()
        Me.rdoWeight = New System.Windows.Forms.RadioButton()
        Me.rdoName = New System.Windows.Forms.RadioButton()
        Me.dgvAssessmentStats = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpOptionsEditA.SuspendLayout()
        CType(Me.dgvAssessmentStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 36)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Assessment Options"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(-61, -7)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(904, 84)
        Me.ListBox1.TabIndex = 27
        '
        'btnDeleteAssessment
        '
        Me.btnDeleteAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAssessment.Location = New System.Drawing.Point(22, 325)
        Me.btnDeleteAssessment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteAssessment.Name = "btnDeleteAssessment"
        Me.btnDeleteAssessment.Size = New System.Drawing.Size(307, 46)
        Me.btnDeleteAssessment.TabIndex = 28
        Me.btnDeleteAssessment.Text = "Delete Assessment"
        Me.btnDeleteAssessment.UseVisualStyleBackColor = True
        '
        'btnEditAssessment
        '
        Me.btnEditAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAssessment.Location = New System.Drawing.Point(24, 106)
        Me.btnEditAssessment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditAssessment.Name = "btnEditAssessment"
        Me.btnEditAssessment.Size = New System.Drawing.Size(305, 46)
        Me.btnEditAssessment.TabIndex = 29
        Me.btnEditAssessment.Text = "Edit Assessment"
        Me.btnEditAssessment.UseVisualStyleBackColor = True
        '
        'btnCreatAssessment
        '
        Me.btnCreatAssessment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatAssessment.Location = New System.Drawing.Point(22, 247)
        Me.btnCreatAssessment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreatAssessment.Name = "btnCreatAssessment"
        Me.btnCreatAssessment.Size = New System.Drawing.Size(307, 46)
        Me.btnCreatAssessment.TabIndex = 30
        Me.btnCreatAssessment.Text = "Create Assessement"
        Me.btnCreatAssessment.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(13, 415)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 32)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gpOptionsEditA
        '
        Me.gpOptionsEditA.Controls.Add(Me.rdoMarks)
        Me.gpOptionsEditA.Controls.Add(Me.rdoWeight)
        Me.gpOptionsEditA.Controls.Add(Me.rdoName)
        Me.gpOptionsEditA.Location = New System.Drawing.Point(24, 169)
        Me.gpOptionsEditA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Name = "gpOptionsEditA"
        Me.gpOptionsEditA.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Size = New System.Drawing.Size(305, 46)
        Me.gpOptionsEditA.TabIndex = 35
        Me.gpOptionsEditA.TabStop = False
        Me.gpOptionsEditA.Text = "Options"
        '
        'rdoMarks
        '
        Me.rdoMarks.AutoSize = True
        Me.rdoMarks.Location = New System.Drawing.Point(221, 22)
        Me.rdoMarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoMarks.Name = "rdoMarks"
        Me.rdoMarks.Size = New System.Drawing.Size(65, 20)
        Me.rdoMarks.TabIndex = 26
        Me.rdoMarks.TabStop = True
        Me.rdoMarks.Text = "Marks"
        Me.rdoMarks.UseVisualStyleBackColor = True
        '
        'rdoWeight
        '
        Me.rdoWeight.AutoSize = True
        Me.rdoWeight.Location = New System.Drawing.Point(1, 18)
        Me.rdoWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoWeight.Name = "rdoWeight"
        Me.rdoWeight.Size = New System.Drawing.Size(70, 20)
        Me.rdoWeight.TabIndex = 24
        Me.rdoWeight.TabStop = True
        Me.rdoWeight.Text = "Weight"
        Me.rdoWeight.UseVisualStyleBackColor = True
        '
        'rdoName
        '
        Me.rdoName.AutoSize = True
        Me.rdoName.Location = New System.Drawing.Point(116, 19)
        Me.rdoName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoName.Name = "rdoName"
        Me.rdoName.Size = New System.Drawing.Size(65, 20)
        Me.rdoName.TabIndex = 25
        Me.rdoName.TabStop = True
        Me.rdoName.Text = "Name"
        Me.rdoName.UseVisualStyleBackColor = True
        '
        'dgvAssessmentStats
        '
        Me.dgvAssessmentStats.AllowUserToAddRows = False
        Me.dgvAssessmentStats.AllowUserToDeleteRows = False
        Me.dgvAssessmentStats.ColumnHeadersHeight = 30
        Me.dgvAssessmentStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvAssessmentStats.EnableHeadersVisualStyles = False
        Me.dgvAssessmentStats.Location = New System.Drawing.Point(366, 106)
        Me.dgvAssessmentStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAssessmentStats.Name = "dgvAssessmentStats"
        Me.dgvAssessmentStats.RowHeadersWidth = 51
        Me.dgvAssessmentStats.RowTemplate.Height = 24
        Me.dgvAssessmentStats.Size = New System.Drawing.Size(404, 265)
        Me.dgvAssessmentStats.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Weight"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mark"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Average Percentage"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Create_Asessment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvAssessmentStats)
        Me.Controls.Add(Me.gpOptionsEditA)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCreatAssessment)
        Me.Controls.Add(Me.btnEditAssessment)
        Me.Controls.Add(Me.btnDeleteAssessment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Create_Asessment2"
        Me.Text = "Create_Asessment2"
        Me.gpOptionsEditA.ResumeLayout(False)
        Me.gpOptionsEditA.PerformLayout()
        CType(Me.dgvAssessmentStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnDeleteAssessment As Button
    Friend WithEvents btnEditAssessment As Button
    Friend WithEvents btnCreatAssessment As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents gpOptionsEditA As GroupBox
    Friend WithEvents rdoWeight As RadioButton
    Friend WithEvents rdoName As RadioButton
    Friend WithEvents rdoMarks As RadioButton
    Friend WithEvents dgvAssessmentStats As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
