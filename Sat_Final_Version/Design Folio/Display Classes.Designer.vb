<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Classes
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvGridStorage = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMissingWeight = New System.Windows.Forms.Label()
        Me.btnResultSetting = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpOptionsEditA = New System.Windows.Forms.GroupBox()
        Me.rdoAveraged = New System.Windows.Forms.RadioButton()
        Me.rdoWeighted = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAssessmentSettings = New System.Windows.Forms.Button()
        Me.cbxSearchResults = New System.Windows.Forms.ComboBox()
        Me.txtStudentProfile = New System.Windows.Forms.TextBox()
        Me.btnFindProfile = New System.Windows.Forms.Button()
        Me.btnTutorial = New System.Windows.Forms.Button()
        CType(Me.dgvGridStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOptionsEditA.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Classes"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(827, 18)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(155, 36)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "UserName"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(-73, -7)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1148, 84)
        Me.ListBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Search All"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Results"
        '
        'dgvGridStorage
        '
        Me.dgvGridStorage.AllowUserToAddRows = False
        Me.dgvGridStorage.AllowUserToDeleteRows = False
        Me.dgvGridStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridStorage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5})
        Me.dgvGridStorage.Location = New System.Drawing.Point(11, 126)
        Me.dgvGridStorage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGridStorage.Name = "dgvGridStorage"
        Me.dgvGridStorage.ReadOnly = True
        Me.dgvGridStorage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvGridStorage.RowTemplate.Height = 24
        Me.dgvGridStorage.Size = New System.Drawing.Size(755, 638)
        Me.dgvGridStorage.TabIndex = 24
        '
        'Column5
        '
        Me.Column5.HeaderText = "Name"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'lblMissingWeight
        '
        Me.lblMissingWeight.AutoSize = True
        Me.lblMissingWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissingWeight.Location = New System.Drawing.Point(12, 104)
        Me.lblMissingWeight.Name = "lblMissingWeight"
        Me.lblMissingWeight.Size = New System.Drawing.Size(124, 20)
        Me.lblMissingWeight.TabIndex = 41
        Me.lblMissingWeight.Text = "Missing Weight"
        '
        'btnResultSetting
        '
        Me.btnResultSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResultSetting.ForeColor = System.Drawing.Color.Black
        Me.btnResultSetting.Location = New System.Drawing.Point(803, 387)
        Me.btnResultSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResultSetting.Name = "btnResultSetting"
        Me.btnResultSetting.Size = New System.Drawing.Size(199, 58)
        Me.btnResultSetting.TabIndex = 51
        Me.btnResultSetting.Text = "Student Grades"
        Me.btnResultSetting.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(829, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Search Student"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(787, 486)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Access To Assessment Setting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(799, 344)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Access Student Grades"
        '
        'gpOptionsEditA
        '
        Me.gpOptionsEditA.Controls.Add(Me.rdoAveraged)
        Me.gpOptionsEditA.Controls.Add(Me.rdoWeighted)
        Me.gpOptionsEditA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpOptionsEditA.Location = New System.Drawing.Point(772, 603)
        Me.gpOptionsEditA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Name = "gpOptionsEditA"
        Me.gpOptionsEditA.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Size = New System.Drawing.Size(273, 60)
        Me.gpOptionsEditA.TabIndex = 47
        Me.gpOptionsEditA.TabStop = False
        Me.gpOptionsEditA.Text = "Options to calculate results"
        '
        'rdoAveraged
        '
        Me.rdoAveraged.AutoSize = True
        Me.rdoAveraged.Location = New System.Drawing.Point(168, 28)
        Me.rdoAveraged.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoAveraged.Name = "rdoAveraged"
        Me.rdoAveraged.Size = New System.Drawing.Size(90, 22)
        Me.rdoAveraged.TabIndex = 26
        Me.rdoAveraged.TabStop = True
        Me.rdoAveraged.Text = "Averaged"
        Me.rdoAveraged.UseVisualStyleBackColor = True
        '
        'rdoWeighted
        '
        Me.rdoWeighted.AutoSize = True
        Me.rdoWeighted.Location = New System.Drawing.Point(1, 28)
        Me.rdoWeighted.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoWeighted.Name = "rdoWeighted"
        Me.rdoWeighted.Size = New System.Drawing.Size(145, 22)
        Me.rdoWeighted.TabIndex = 24
        Me.rdoWeighted.TabStop = True
        Me.rdoWeighted.Text = "Weighted Results"
        Me.rdoWeighted.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(804, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Results from student search"
        '
        'btnAssessmentSettings
        '
        Me.btnAssessmentSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAssessmentSettings.Location = New System.Drawing.Point(807, 524)
        Me.btnAssessmentSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssessmentSettings.Name = "btnAssessmentSettings"
        Me.btnAssessmentSettings.Size = New System.Drawing.Size(199, 57)
        Me.btnAssessmentSettings.TabIndex = 45
        Me.btnAssessmentSettings.Text = "Assessments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAssessmentSettings.UseVisualStyleBackColor = False
        '
        'cbxSearchResults
        '
        Me.cbxSearchResults.FormattingEnabled = True
        Me.cbxSearchResults.Location = New System.Drawing.Point(827, 238)
        Me.cbxSearchResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxSearchResults.Name = "cbxSearchResults"
        Me.cbxSearchResults.Size = New System.Drawing.Size(136, 24)
        Me.cbxSearchResults.TabIndex = 44
        '
        'txtStudentProfile
        '
        Me.txtStudentProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentProfile.Location = New System.Drawing.Point(827, 170)
        Me.txtStudentProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentProfile.Name = "txtStudentProfile"
        Me.txtStudentProfile.Size = New System.Drawing.Size(136, 24)
        Me.txtStudentProfile.TabIndex = 43
        '
        'btnFindProfile
        '
        Me.btnFindProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFindProfile.Location = New System.Drawing.Point(827, 285)
        Me.btnFindProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFindProfile.Name = "btnFindProfile"
        Me.btnFindProfile.Size = New System.Drawing.Size(136, 34)
        Me.btnFindProfile.TabIndex = 42
        Me.btnFindProfile.Text = "Find Profile"
        Me.btnFindProfile.UseVisualStyleBackColor = False
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTutorial.Location = New System.Drawing.Point(834, 716)
        Me.btnTutorial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(148, 37)
        Me.btnTutorial.TabIndex = 52
        Me.btnTutorial.Text = "Manual"
        Me.btnTutorial.UseVisualStyleBackColor = False
        '
        'Display_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 775)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnResultSetting)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gpOptionsEditA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAssessmentSettings)
        Me.Controls.Add(Me.cbxSearchResults)
        Me.Controls.Add(Me.txtStudentProfile)
        Me.Controls.Add(Me.btnFindProfile)
        Me.Controls.Add(Me.lblMissingWeight)
        Me.Controls.Add(Me.dgvGridStorage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Display_Classes"
        Me.Text = "Display_Classes"
        CType(Me.dgvGridStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOptionsEditA.ResumeLayout(False)
        Me.gpOptionsEditA.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvGridStorage As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblMissingWeight As Label
    Friend WithEvents btnResultSetting As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gpOptionsEditA As GroupBox
    Friend WithEvents rdoAveraged As RadioButton
    Friend WithEvents rdoWeighted As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAssessmentSettings As Button
    Friend WithEvents cbxSearchResults As ComboBox
    Friend WithEvents txtStudentProfile As TextBox
    Friend WithEvents btnFindProfile As Button
    Friend WithEvents btnTutorial As Button
End Class
