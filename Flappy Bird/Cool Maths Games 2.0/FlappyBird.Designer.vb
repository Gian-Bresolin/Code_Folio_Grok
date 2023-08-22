<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FlappyBird
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlappyBird))
        Me.ptcPipeBottom = New System.Windows.Forms.PictureBox()
        Me.flappy = New System.Windows.Forms.PictureBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.Tdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.ptcScore = New System.Windows.Forms.PictureBox()
        Me.ptcPipeTop = New System.Windows.Forms.PictureBox()
        Me.ptcGrass = New System.Windows.Forms.PictureBox()
        Me.ptcPipeTop2 = New System.Windows.Forms.PictureBox()
        Me.ptcScore2 = New System.Windows.Forms.PictureBox()
        Me.ptcPipeBottom2 = New System.Windows.Forms.PictureBox()
        Me.ptcPipeTop3 = New System.Windows.Forms.PictureBox()
        Me.ptcPipeBottom3 = New System.Windows.Forms.PictureBox()
        Me.ptcScore3 = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.ptcEnd = New System.Windows.Forms.PictureBox()
        Me.lblEndGame = New System.Windows.Forms.PictureBox()
        Me.lblFScore = New System.Windows.Forms.Label()
        Me.egg = New System.Windows.Forms.Timer(Me.components)
        Me.btnSlow = New System.Windows.Forms.Button()
        Me.slow = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ptcPipeBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcPipeTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcGrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcPipeTop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcScore2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcPipeBottom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcPipeTop3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcPipeBottom3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcScore3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptcEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptcPipeBottom
        '
        Me.ptcPipeBottom.BackColor = System.Drawing.Color.Transparent
        Me.ptcPipeBottom.BackgroundImage = CType(resources.GetObject("ptcPipeBottom.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeBottom.Location = New System.Drawing.Point(873, 352)
        Me.ptcPipeBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ptcPipeBottom.Name = "ptcPipeBottom"
        Me.ptcPipeBottom.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeBottom.TabIndex = 6
        Me.ptcPipeBottom.TabStop = False
        '
        'flappy
        '
        Me.flappy.BackColor = System.Drawing.Color.Transparent
        Me.flappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flappy.Location = New System.Drawing.Point(343, 198)
        Me.flappy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.flappy.Name = "flappy"
        Me.flappy.Size = New System.Drawing.Size(51, 33)
        Me.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flappy.TabIndex = 5
        Me.flappy.TabStop = False
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove.Location = New System.Drawing.Point(488, 446)
        Me.btnMove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(112, 94)
        Me.btnMove.TabIndex = 4
        Me.btnMove.Text = "Up"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'Tdown
        '
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(487, 41)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(121, 42)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Score"
        '
        'ptcScore
        '
        Me.ptcScore.BackColor = System.Drawing.Color.Transparent
        Me.ptcScore.Location = New System.Drawing.Point(951, 0)
        Me.ptcScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcScore.Name = "ptcScore"
        Me.ptcScore.Size = New System.Drawing.Size(1, 514)
        Me.ptcScore.TabIndex = 8
        Me.ptcScore.TabStop = False
        '
        'ptcPipeTop
        '
        Me.ptcPipeTop.BackgroundImage = CType(resources.GetObject("ptcPipeTop.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeTop.Location = New System.Drawing.Point(873, -187)
        Me.ptcPipeTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcPipeTop.Name = "ptcPipeTop"
        Me.ptcPipeTop.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeTop.TabIndex = 9
        Me.ptcPipeTop.TabStop = False
        '
        'ptcGrass
        '
        Me.ptcGrass.BackgroundImage = CType(resources.GetObject("ptcGrass.BackgroundImage"), System.Drawing.Image)
        Me.ptcGrass.Location = New System.Drawing.Point(-1, 518)
        Me.ptcGrass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcGrass.Name = "ptcGrass"
        Me.ptcGrass.Size = New System.Drawing.Size(2488, 50)
        Me.ptcGrass.TabIndex = 10
        Me.ptcGrass.TabStop = False
        '
        'ptcPipeTop2
        '
        Me.ptcPipeTop2.BackgroundImage = CType(resources.GetObject("ptcPipeTop2.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeTop2.Location = New System.Drawing.Point(509, -187)
        Me.ptcPipeTop2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcPipeTop2.Name = "ptcPipeTop2"
        Me.ptcPipeTop2.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeTop2.TabIndex = 13
        Me.ptcPipeTop2.TabStop = False
        '
        'ptcScore2
        '
        Me.ptcScore2.BackColor = System.Drawing.Color.Transparent
        Me.ptcScore2.Location = New System.Drawing.Point(587, 0)
        Me.ptcScore2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcScore2.Name = "ptcScore2"
        Me.ptcScore2.Size = New System.Drawing.Size(1, 512)
        Me.ptcScore2.TabIndex = 12
        Me.ptcScore2.TabStop = False
        '
        'ptcPipeBottom2
        '
        Me.ptcPipeBottom2.BackColor = System.Drawing.Color.Transparent
        Me.ptcPipeBottom2.BackgroundImage = CType(resources.GetObject("ptcPipeBottom2.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeBottom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeBottom2.Location = New System.Drawing.Point(509, 352)
        Me.ptcPipeBottom2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ptcPipeBottom2.Name = "ptcPipeBottom2"
        Me.ptcPipeBottom2.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeBottom2.TabIndex = 11
        Me.ptcPipeBottom2.TabStop = False
        '
        'ptcPipeTop3
        '
        Me.ptcPipeTop3.BackgroundImage = CType(resources.GetObject("ptcPipeTop3.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeTop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeTop3.Location = New System.Drawing.Point(91, -187)
        Me.ptcPipeTop3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcPipeTop3.Name = "ptcPipeTop3"
        Me.ptcPipeTop3.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeTop3.TabIndex = 16
        Me.ptcPipeTop3.TabStop = False
        '
        'ptcPipeBottom3
        '
        Me.ptcPipeBottom3.BackColor = System.Drawing.Color.Transparent
        Me.ptcPipeBottom3.BackgroundImage = CType(resources.GetObject("ptcPipeBottom3.BackgroundImage"), System.Drawing.Image)
        Me.ptcPipeBottom3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcPipeBottom3.Location = New System.Drawing.Point(91, 352)
        Me.ptcPipeBottom3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ptcPipeBottom3.Name = "ptcPipeBottom3"
        Me.ptcPipeBottom3.Size = New System.Drawing.Size(79, 395)
        Me.ptcPipeBottom3.TabIndex = 14
        Me.ptcPipeBottom3.TabStop = False
        '
        'ptcScore3
        '
        Me.ptcScore3.BackColor = System.Drawing.Color.Transparent
        Me.ptcScore3.Location = New System.Drawing.Point(168, -12)
        Me.ptcScore3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcScore3.Name = "ptcScore3"
        Me.ptcScore3.Size = New System.Drawing.Size(1, 512)
        Me.ptcScore3.TabIndex = 15
        Me.ptcScore3.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.Location = New System.Drawing.Point(488, 302)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(120, 43)
        Me.btnPlay.TabIndex = 18
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(488, 372)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(120, 43)
        Me.btnHome.TabIndex = 19
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'ptcEnd
        '
        Me.ptcEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ptcEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptcEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptcEnd.Location = New System.Drawing.Point(419, 114)
        Me.ptcEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptcEnd.Name = "ptcEnd"
        Me.ptcEnd.Size = New System.Drawing.Size(273, 360)
        Me.ptcEnd.TabIndex = 20
        Me.ptcEnd.TabStop = False
        '
        'lblEndGame
        '
        Me.lblEndGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEndGame.BackgroundImage = CType(resources.GetObject("lblEndGame.BackgroundImage"), System.Drawing.Image)
        Me.lblEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblEndGame.Location = New System.Drawing.Point(459, 135)
        Me.lblEndGame.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblEndGame.Name = "lblEndGame"
        Me.lblEndGame.Size = New System.Drawing.Size(184, 46)
        Me.lblEndGame.TabIndex = 21
        Me.lblEndGame.TabStop = False
        '
        'lblFScore
        '
        Me.lblFScore.AutoSize = True
        Me.lblFScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFScore.Location = New System.Drawing.Point(470, 210)
        Me.lblFScore.Name = "lblFScore"
        Me.lblFScore.Size = New System.Drawing.Size(118, 38)
        Me.lblFScore.TabIndex = 22
        Me.lblFScore.Text = "Score:"
        Me.lblFScore.Visible = False
        '
        'egg
        '
        '
        'btnSlow
        '
        Me.btnSlow.BackColor = System.Drawing.Color.Yellow
        Me.btnSlow.BackgroundImage = CType(resources.GetObject("btnSlow.BackgroundImage"), System.Drawing.Image)
        Me.btnSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSlow.Location = New System.Drawing.Point(607, 480)
        Me.btnSlow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSlow.Name = "btnSlow"
        Me.btnSlow.Size = New System.Drawing.Size(51, 46)
        Me.btnSlow.TabIndex = 23
        Me.btnSlow.UseVisualStyleBackColor = False
        Me.btnSlow.Visible = False
        '
        'slow
        '
        '
        'FlappyBird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnSlow)
        Me.Controls.Add(Me.lblFScore)
        Me.Controls.Add(Me.lblEndGame)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.ptcEnd)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.ptcPipeTop3)
        Me.Controls.Add(Me.ptcPipeTop2)
        Me.Controls.Add(Me.ptcGrass)
        Me.Controls.Add(Me.ptcPipeTop)
        Me.Controls.Add(Me.ptcPipeBottom)
        Me.Controls.Add(Me.flappy)
        Me.Controls.Add(Me.ptcPipeBottom2)
        Me.Controls.Add(Me.ptcScore)
        Me.Controls.Add(Me.ptcScore2)
        Me.Controls.Add(Me.ptcPipeBottom3)
        Me.Controls.Add(Me.ptcScore3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FlappyBird"
        Me.Text = "FlappyBird"
        CType(Me.ptcPipeBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcPipeTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcGrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcPipeTop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcScore2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcPipeBottom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcPipeTop3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcPipeBottom3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcScore3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptcEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptcPipeBottom As PictureBox
    Friend WithEvents flappy As PictureBox
    Friend WithEvents btnMove As Button
    Friend WithEvents Tdown As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents ptcScore As PictureBox
    Friend WithEvents ptcPipeTop As PictureBox
    Friend WithEvents ptcGrass As PictureBox
    Friend WithEvents ptcPipeTop2 As PictureBox
    Friend WithEvents ptcScore2 As PictureBox
    Friend WithEvents ptcPipeBottom2 As PictureBox
    Friend WithEvents ptcPipeTop3 As PictureBox
    Friend WithEvents ptcPipeBottom3 As PictureBox
    Friend WithEvents ptcScore3 As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents ptcEnd As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents lblEndGame As PictureBox
    Friend WithEvents lblFScore As Label
    Friend WithEvents egg As Timer
    Friend WithEvents btnSlow As Button
    Friend WithEvents slow As Timer
End Class
