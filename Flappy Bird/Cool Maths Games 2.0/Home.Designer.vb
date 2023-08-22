<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnFlappySelect = New System.Windows.Forms.Button()
        Me.ptxGuessGame = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ptxGuessGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlay.Location = New System.Drawing.Point(615, 495)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(139, 49)
        Me.btnPlay.TabIndex = 18
        Me.btnPlay.Text = "Play "
        Me.btnPlay.UseVisualStyleBackColor = False
        Me.btnPlay.Visible = False
        '
        'btnFlappySelect
        '
        Me.btnFlappySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlappySelect.Location = New System.Drawing.Point(151, 199)
        Me.btnFlappySelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFlappySelect.Name = "btnFlappySelect"
        Me.btnFlappySelect.Size = New System.Drawing.Size(307, 110)
        Me.btnFlappySelect.TabIndex = 17
        Me.btnFlappySelect.Text = "Flappy Bird"
        Me.btnFlappySelect.UseVisualStyleBackColor = False
        '
        'ptxGuessGame
        '
        Me.ptxGuessGame.Location = New System.Drawing.Point(499, 160)
        Me.ptxGuessGame.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptxGuessGame.Name = "ptxGuessGame"
        Me.ptxGuessGame.Size = New System.Drawing.Size(389, 329)
        Me.ptxGuessGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptxGuessGame.TabIndex = 16
        Me.ptxGuessGame.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 32)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Game Options"
        '
        'userDisplay
        '
        Me.userDisplay.AutoSize = True
        Me.userDisplay.Font = New System.Drawing.Font("MS Mincho", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userDisplay.Location = New System.Drawing.Point(12, 30)
        Me.userDisplay.Name = "userDisplay"
        Me.userDisplay.Size = New System.Drawing.Size(93, 37)
        Me.userDisplay.TabIndex = 14
        Me.userDisplay.Text = "user"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 64)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Home"
        '
        'btnShop
        '
        Me.btnShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShop.Location = New System.Drawing.Point(151, 338)
        Me.btnShop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(307, 110)
        Me.btnShop.TabIndex = 20
        Me.btnShop.Text = "Shop"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(923, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 80)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(931, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 29)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Stats"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnFlappySelect)
        Me.Controls.Add(Me.ptxGuessGame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.ptxGuessGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnFlappySelect As Button
    Friend WithEvents ptxGuessGame As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userDisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShop As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
