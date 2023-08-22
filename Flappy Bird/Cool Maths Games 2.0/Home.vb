
Imports System.Xml



    Public Class Home
    Public intUserName As String 'sets up variables
    Public intCredits As Integer
    Public intPassword As String
    Public loginInfo As New XmlDocument
    Public intHs
    Dim intGuess
    Dim intLeak


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userDisplay.Text = intUserName & ": " & intCredits & " credits" 'sets text up
        ptxGuessGame.Image = Image.FromFile("questionMark1.png") 'sets image for back
        btnPlay.Text = "Pick a game" 'sets text
        btnPlay.Visible = True
        FlappyBird.intCredits = 0
    End Sub



    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If intLeak = 1 Then 'used to add a selctor for more option to add 
            If intGuess = 1 Then
                FlappyBird.Show()
                Me.Hide()
            ElseIf intGuess = 2 Then
                FlappyBird.Show()
                Me.Hide()
            End If
        End If
    End Sub



    Private Sub btnFlappySelect_Click(sender As Object, e As EventArgs) Handles btnFlappySelect.Click 'sets up image
        ptxGuessGame.Image = Image.FromFile("flappyBirdDisplay.jpg")
        intGuess = 2
        intLeak = 1
        btnPlay.Text = "Play"
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click 'used to open shop
        Me.Hide()
        shop.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'open stats
        Me.Hide()
        Stats.Show()
    End Sub
End Class
