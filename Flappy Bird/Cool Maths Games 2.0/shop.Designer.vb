<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shop
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPowerups = New System.Windows.Forms.Button()
        Me.btnSkins = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(335, 322)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(152, 77)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPowerups
        '
        Me.btnPowerups.Location = New System.Drawing.Point(494, 136)
        Me.btnPowerups.Name = "btnPowerups"
        Me.btnPowerups.Size = New System.Drawing.Size(163, 113)
        Me.btnPowerups.TabIndex = 1
        Me.btnPowerups.Text = "PowerUps"
        Me.btnPowerups.UseVisualStyleBackColor = True
        '
        'btnSkins
        '
        Me.btnSkins.Location = New System.Drawing.Point(163, 137)
        Me.btnSkins.Name = "btnSkins"
        Me.btnSkins.Size = New System.Drawing.Size(163, 112)
        Me.btnSkins.TabIndex = 2
        Me.btnSkins.Text = "Skins"
        Me.btnSkins.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 64)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Shop"
        '
        'shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSkins)
        Me.Controls.Add(Me.btnPowerups)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "shop"
        Me.Text = "shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnPowerups As Button
    Friend WithEvents btnSkins As Button
    Friend WithEvents Label1 As Label
End Class
