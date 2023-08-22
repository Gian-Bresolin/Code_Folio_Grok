<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gradeSetting
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEditGrade = New System.Windows.Forms.Button()
        Me.btnDeleteGrade = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.gpOptionsEditA = New System.Windows.Forms.GroupBox()
        Me.rdoAddToAll = New System.Windows.Forms.RadioButton()
        Me.rdoAddToOne = New System.Windows.Forms.RadioButton()
        Me.btnCreatGrade = New System.Windows.Forms.Button()
        Me.gpOptionsEditA.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(264, 542)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 40)
        Me.btnBack.TabIndex = 44
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEditGrade
        '
        Me.btnEditGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditGrade.Location = New System.Drawing.Point(118, 148)
        Me.btnEditGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditGrade.Name = "btnEditGrade"
        Me.btnEditGrade.Size = New System.Drawing.Size(420, 58)
        Me.btnEditGrade.TabIndex = 40
        Me.btnEditGrade.Text = "Change Grade"
        Me.btnEditGrade.UseVisualStyleBackColor = False
        '
        'btnDeleteGrade
        '
        Me.btnDeleteGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeleteGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteGrade.Location = New System.Drawing.Point(118, 441)
        Me.btnDeleteGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteGrade.Name = "btnDeleteGrade"
        Me.btnDeleteGrade.Size = New System.Drawing.Size(420, 58)
        Me.btnDeleteGrade.TabIndex = 39
        Me.btnDeleteGrade.Text = "Delete Grade"
        Me.btnDeleteGrade.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 40)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Grade Options"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(-78, -2)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1016, 104)
        Me.ListBox1.TabIndex = 38
        '
        'gpOptionsEditA
        '
        Me.gpOptionsEditA.Controls.Add(Me.rdoAddToAll)
        Me.gpOptionsEditA.Controls.Add(Me.rdoAddToOne)
        Me.gpOptionsEditA.Location = New System.Drawing.Point(100, 330)
        Me.gpOptionsEditA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Name = "gpOptionsEditA"
        Me.gpOptionsEditA.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gpOptionsEditA.Size = New System.Drawing.Size(458, 58)
        Me.gpOptionsEditA.TabIndex = 45
        Me.gpOptionsEditA.TabStop = False
        Me.gpOptionsEditA.Text = "Options"
        '
        'rdoAddToAll
        '
        Me.rdoAddToAll.AutoSize = True
        Me.rdoAddToAll.Location = New System.Drawing.Point(234, 22)
        Me.rdoAddToAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoAddToAll.Name = "rdoAddToAll"
        Me.rdoAddToAll.Size = New System.Drawing.Size(215, 24)
        Me.rdoAddToAll.TabIndex = 26
        Me.rdoAddToAll.TabStop = True
        Me.rdoAddToAll.Text = "Add Grade to all students"
        Me.rdoAddToAll.UseVisualStyleBackColor = True
        '
        'rdoAddToOne
        '
        Me.rdoAddToOne.AutoSize = True
        Me.rdoAddToOne.Location = New System.Drawing.Point(0, 22)
        Me.rdoAddToOne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoAddToOne.Name = "rdoAddToOne"
        Me.rdoAddToOne.Size = New System.Drawing.Size(222, 24)
        Me.rdoAddToOne.TabIndex = 24
        Me.rdoAddToOne.TabStop = True
        Me.rdoAddToOne.Text = "Add Grade to one Student"
        Me.rdoAddToOne.UseVisualStyleBackColor = True
        '
        'btnCreatGrade
        '
        Me.btnCreatGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCreatGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatGrade.Location = New System.Drawing.Point(118, 249)
        Me.btnCreatGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreatGrade.Name = "btnCreatGrade"
        Me.btnCreatGrade.Size = New System.Drawing.Size(420, 58)
        Me.btnCreatGrade.TabIndex = 41
        Me.btnCreatGrade.Text = "Create Grade "
        Me.btnCreatGrade.UseVisualStyleBackColor = False
        '
        'gradeSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(654, 634)
        Me.Controls.Add(Me.gpOptionsEditA)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCreatGrade)
        Me.Controls.Add(Me.btnEditGrade)
        Me.Controls.Add(Me.btnDeleteGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "gradeSetting"
        Me.Text = "gradeSetting"
        Me.gpOptionsEditA.ResumeLayout(False)
        Me.gpOptionsEditA.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEditGrade As Button
    Friend WithEvents btnDeleteGrade As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents gpOptionsEditA As GroupBox
    Friend WithEvents rdoAddToAll As RadioButton
    Friend WithEvents rdoAddToOne As RadioButton
    Friend WithEvents btnCreatGrade As Button
End Class
