Imports System.Xml

Public Class FlappyBird
    Public intScore As Double 'user to store teh score
    Public intCounter = 0
    Public intSpeed = 0 'how fast the pipe move over time
    Public intDiff = 0
    Public intUsername 'stores username
    Public intCredits 'stores credits
    Public loginInfo As New XmlDocument
    Public intPhenoix 'stores value of phenoix skill
    Public intSurvial ' atiavtes for phenoix
    Public intDuring = 1
    Public intSlowD = 0 'used to slow down pipes
    Public intSlowT = 0 'used for slow abiility timer 

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''make bird move on click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        For i = 0 To 3
            Dim FlappyBirdPosY As Integer = flappy.Top 'sets it value
            flappy.Top = FlappyBirdPosY - 10 'moves bird up
        Next

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''when game opens
    Private Sub flappy_bird_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flappy.Image = Image.FromFile("goldS.png") 'sets flappy to the image
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        For Each node In LoginNodes 'activates for each node
            If node.ChildNodes(0).InnerText = Home.intUserName Then 'if the inner text is the username
                If node.ChildNodes(7).InnerText = 1 Then 'checks if they own phenoix ability
                    intPhenoix = 1 'sets value
                Else
                    intPhenoix = 0
                End If
            End If

            If node.ChildNodes(0).InnerText = Home.intUserName Then
                If node.ChildNodes(8).InnerText = 1 Then 'checks if you own slow abillity
                    btnSlow.Visible = True 'makes button visable
                Else
                    btnSlow.Visible = False
                End If

            End If
        Next
        Tdown.Start() 'starts game timer
        dud.Close() 'close dud
        btnMove.Visible = True 'sets buttons and picture to visable and invisable 
        ptcEnd.Visible = False
        btnHome.Visible = False
        btnPlay.Visible = False
        lblEndGame.Visible = False
        intSpeed = 0 'sets the starting speed

        If skins.intSkin = 1 Then 'sets the skin of the bird to the one equiped
            flappy.Image = Image.FromFile("goldSSSSS.png")
        End If
        If skins.intSkin = 3 Then
            flappy.Image = Image.FromFile("Diamond.png")
        End If
        If skins.intSkin = 2 Then
            flappy.Image = Image.FromFile("darkMatter.png")
        End If
        If skins.intSkin = 0 Then
            flappy.Image = Image.FromFile("basicFlappppy.png")
        End If





        loginInfo.Save("userData.xml")
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Making images move
    Private Sub Tdown_Tick(sender As Object, e As EventArgs) Handles Tdown.Tick

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''making bird and grass move

        Dim location 'used for random movement
        Dim ptcGrassX As Integer = ptcGrass.Left 'declares locaiton of grass
        Dim FlappyBirdPosY As Integer = flappy.Top '^ for flappy
        ptcGrass.Left = ptcGrass.Left - 10 - intSpeed + intSlowD 'moves grass
        flappy.Top = FlappyBirdPosY + 17 'brings bird down

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''making pipes move

        Dim ptcPipeBottomPosX As Integer = ptcPipeBottom.Left 'sets the locations
        Dim ptcPipeTopPosX As Integer = ptcPipeTop.Left
        Dim ptcScoreX As Integer = ptcScore.Left

        ptcPipeBottom.Left = ptcPipeBottomPosX - 10 - intSpeed + intSlowD '- 10 for base speed then difficulty speed minused make faster
        ptcScore.Left = ptcScoreX - 10 - intSpeed + intSlowD 'slowD for when abillity activates
        ptcPipeTop.Left = ptcPipeTopPosX - 10 - intSpeed + intSlowD

        Dim ptcPipeBottomPosX2 As Integer = ptcPipeBottom2.Left 'sets the locations
        Dim ptcPipeTopPosX2 As Integer = ptcPipeTop2.Left
        Dim ptcScoreX2 As Integer = ptcScore2.Left

        ptcPipeBottom2.Left = ptcPipeBottomPosX2 - 10 - intSpeed + intSlowD
        ptcScore2.Left = ptcScoreX2 - 10 - intSpeed + intSlowD
        ptcPipeTop2.Left = ptcPipeTopPosX2 - 10 - intSpeed + intSlowD

        Dim ptcPipeBottomPosX3 As Integer = ptcPipeBottom3.Left 'sets the locations
        Dim ptcPipeTopPosX3 As Integer = ptcPipeTop3.Left
        Dim ptcScoreX3 As Integer = ptcScore3.Left

        ptcPipeBottom3.Left = ptcPipeBottomPosX3 - 10 - intSpeed + intSlowD
        ptcScore3.Left = ptcScoreX3 - 10 - intSpeed + intSlowD
        ptcPipeTop3.Left = ptcPipeTopPosX3 - 10 - intSpeed + intSlowD

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 'checks if bird collides

        If FlappyBirdPosY > 486 Or FlappyBirdPosY < -18 Or pipeB1() = True Or pipeT1() = True Or pipeB2() = True Or pipeT2() = True Or pipeT3() = True Or pipeB3() = True Or ground() = True Then
            If intPhenoix = 0 Then 'if the user owns the phenoix
                Tdown.Stop()

                btnSlow.Visible = False 'sets buttons to visable to True and false depending on need
                lblScore.Visible = False
                ptcEnd.Visible = True
                btnHome.Visible = True
                btnPlay.Visible = True
                lblEndGame.Visible = True
                btnMove.Visible = False
                lblFScore.Text = "Score: " & intScore 'shows scrore
                lblFScore.Visible = True
                Home.intCredits += intCredits + intScore * 1.75 'adds credits to the users account

                loginInfo.Load("userData.xml")

                Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
                For Each node In LoginNodes
                    If node.ChildNodes(0).InnerText = Home.intUserName Then 'edits the xml to save
                        node.ChildNodes(2).InnerText = Home.intCredits
                    End If
                Next

                For Each node In LoginNodes
                    If node.ChildNodes(0).InnerText = Home.intUserName Then 'checks for high score
                        If node.ChildNodes(6).InnerText < intScore Then
                            MsgBox("You got a new high score of " & intScore)
                            node.ChildNodes(6).InnerText = intScore 'sets new highscore in xml
                        End If
                    End If
                Next


                loginInfo.Save("userData.xml")


            ElseIf intPhenoix = 1 Then 'activates phenoix ability
                If intDuring = 1 Then 'sets up the ability
                    FlappyBirdPosY = flappy.Top
                    flappy.Top = 400
                    flappy.Left = 200
                    intDuring = 0
                End If
                Tdown.Stop() 'stops timer
                egg.Start() 'starts timer
            End If

        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''checks if pipes are off screen
        If ptcPipeBottomPosX < -93 Then 'if pipe goes off screen
            Dim random As New Random
            location = random.Next(175, 400) 'gets random lcoation
            Dim ptcPipeBottomPosY As Integer = ptcPipeBottom.Top 'sets location
            Dim ptcPipeTopPosy As Integer = ptcPipeTop.Top
            Dim ptcScorey As Integer = ptcScore.Top

            ptcPipeBottom.Top = location 'sets the first pipe location
            ptcPipeTop.Top = location - 100 - 341 + intDiff 'adds gap then distance of pipe then the difficulty

            ptcPipeBottom.Left = 1069 'sets the location for pictures to move again
            ptcPipeTop.Left = 1069
            ptcScore.Left = 1069
            ptcGrass.Left = -1
        End If

        If ptcPipeBottomPosX2 < -93 Then 'same as before
            Dim random As New Random
            location = random.Next(175, 400)
            Dim ptcPipeBottomPosY2 As Integer = ptcPipeBottom2.Top
            Dim ptcPipeTopPosy2 As Integer = ptcPipeTop2.Top
            Dim ptcScorey2 As Integer = ptcScore2.Top

            ptcPipeBottom2.Top = location
            ptcPipeTop2.Top = location - 100 - 341 + intDiff

            ptcPipeBottom2.Left = 1069
            ptcPipeTop2.Left = 1069
            ptcScore2.Left = 1069
            ptcGrass.Left = -1
        End If

        If ptcPipeBottomPosX3 < -93 Then 'same as before
            Dim random As New Random
            location = random.Next(175, 400)
            Dim ptcPipeBottomPosY3 As Integer = ptcPipeBottom3.Top
            Dim ptcPipeTopPosy3 As Integer = ptcPipeTop3.Top
            Dim ptcScorey3 As Integer = ptcScore3.Top

            ptcPipeBottom3.Top = location
            ptcPipeTop3.Top = location - 100 - 341 + intDiff

            ptcPipeBottom3.Left = 1069
            ptcPipeTop3.Left = 1069
            ptcScore3.Left = 1069
            ptcGrass.Left = -1
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''if bird hit a score image
        If score1() = True Or score2() = True Or score3() = True Then 'checks for bird colloision on score
            intCounter += 1 'adds to counter
            intScore += 1 * intSpeed / 2 'score amount increases over time
            lblScore.Text = intScore 'displays score
            If intCounter = 3 Then 'games gets hard over time
                intCounter = 0
                intSpeed += 2
                If intDiff < 24 Then 'caps out diffiiclty
                    intDiff += 2
                End If
            End If
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''collosion
    Private Function pipeB1() As Boolean 'function used for collosion
        Dim bird As New Rectangle() 'creats new rectangle
        bird.Location = flappy.PointToScreen(New Point(0D, 0D)) 'sets location of the rectangle
        bird.Size = New Size(flappy.Width, flappy.Height) 'sets the size of teh rectangle

        Dim pipeBo As New Rectangle() 'creats new rectangle
        pipeBo.Location = ptcPipeBottom.PointToScreen(New Point(0D, 0D)) 'sets location of the rectangle
        pipeBo.Size = New Size(ptcPipeBottom.Width, ptcPipeBottom.Height) 'sets the size of teh rectangle

        Dim doesIntersect As Boolean = bird.IntersectsWith(pipeBo) 'checks to see if they intersected

        Return doesIntersect 'returns value
    End Function

    Private Function pipeT1() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcPipeTop.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcPipeTop.Width, ptcPipeTop.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function score1() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim score As New Rectangle()
        score.Location = ptcScore.PointToScreen(New Point(0D, 0D))
        score.Size = New Size(ptcScore.Width, ptcScore.Height)

        Dim scoreH As Boolean = bird.IntersectsWith(score)

        Return scoreH
    End Function

    Private Function pipeT2() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcPipeTop2.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcPipeTop2.Width, ptcPipeTop2.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function pipeB2() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcPipeBottom2.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcPipeBottom2.Width, ptcPipeBottom2.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function score2() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcScore2.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcScore2.Width, ptcScore2.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function pipeT3() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcPipeTop3.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcPipeTop3.Width, ptcPipeTop3.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function pipeB3() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcPipeBottom3.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcPipeBottom3.Width, ptcPipeBottom3.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function score3() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcScore3.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcScore3.Width, ptcScore3.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    Private Function ground() As Boolean '^
        Dim bird As New Rectangle()
        bird.Location = flappy.PointToScreen(New Point(0D, 0D))
        bird.Size = New Size(flappy.Width, flappy.Height)

        Dim pipeTo As New Rectangle()
        pipeTo.Location = ptcGrass.PointToScreen(New Point(0D, 0D))
        pipeTo.Size = New Size(ptcGrass.Width, ptcGrass.Height)

        Dim hit As Boolean = bird.IntersectsWith(pipeTo)

        Return hit
    End Function

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''home button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Home.userDisplay.Text = Home.intUserName & ": " & Home.intCredits & " credits" 'sets text for home screen
        Home.Show()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''restart button
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Tdown.Start() 'starts timer
        Me.Close() 'closes to reset location
        dud.Show() 'opens to then reopen flappy bird
        ptcEnd.Visible = False 'hides ptc
        btnHome.Visible = False
        btnPlay.Visible = False
        lblEndGame.Visible = False
        lblScore.Visible = True 'shows score
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles egg.Tick 'sets skin for phenoix
        intSurvial += 1 'timer for lengh in egg
        flappy.Image = Image.FromFile("eggTrue.png")
        If intSurvial = 20 Then
            Tdown.Start() 'starts normal timer and resets values
            intSurvial = 0
            intPhenoix = 0
            egg.Stop() 'stops timer
            If skins.intSkin = 1 Then 'gets value of skin selected
                flappy.Image = Image.FromFile("goldSSSSS.png")
            End If
            If skins.intSkin = 3 Then
                flappy.Image = Image.FromFile("Diamond.png")
            End If
            If skins.intSkin = 2 Then
                flappy.Image = Image.FromFile("darkMatter.png")
            End If
            If skins.intSkin = 0 Then
                flappy.Image = Image.FromFile("basicFlappppy.png")
            End If
        End If
    End Sub

    Private Sub btnSlow_Click(sender As Object, e As EventArgs) Handles btnSlow.Click 'slow ability
        intSlowD = 7 + intSpeed 'sets value for slow down ability
        btnSlow.Visible = False 'gets rid of button
        slow.Start() 'starts slow timer
    End Sub

    Private Sub slow_Tick(sender As Object, e As EventArgs) Handles slow.Tick
        intSlowT += 1 'time for whiel it is activated
        If intSlowT = 40 Then
            slow.Stop() 'stops timer
            intSlowD = 0 'removes slow
        End If
    End Sub
End Class