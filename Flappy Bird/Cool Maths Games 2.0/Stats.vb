Imports System.Xml

Public Class Stats
    Public loginInfo As New XmlDocument
    Public intPlayer
    Public intAmount
    Public highS(99, 1) As Integer
    Public intAv
    Public intBest
    Public intUser
    Public intScore

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'back button
        Home.Show()
        Me.Close()
    End Sub



    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        Dim ReaderControl As XmlReader = XmlReader.Create("userData.xml") 'starts reading Prices.xml 
        Do While ReaderControl.Read() 'reads each line of the xml
            If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "HS" Then 'if "item" is in the node it adds it to it's relevent array
                intPlayer += 1 'changes the number within the aray to create different data
                highS(intPlayer, 1) = (ReaderControl.ReadElementString) 'adds the line to the array
            Else
                ReaderControl.Read() 'keeps reading 
            End If
        Loop
        If intPlayer = Nothing Then 'if there is no user data for highscore
            intPlayer = 0
        End If
        For i = 0 To intPlayer 'gets all scores from array
            intAmount += 1
            intAv += highS(intAmount, 1)

        Next
        intAv /= intPlayer 'divides by amount of scores to get Average
        lblAve.Text = Math.Round(intAv) 'rounds the number so it looks nice
        intAmount = 0 'resets zero
        ReaderControl.Close()
        For i = 0 To intPlayer 'checks to find intBest score
            intAmount += 1

            If intBest < highS(intAmount, 1) Then 'if score is higher then variable
                intBest = highS(intAmount, 1) 'sets new highest score

                loginInfo.Load("userData.xml")

                For Each node In LoginNodes 'links username to highest score
                    If node.ChildNodes(6).InnerText = intBest Then
                        intUser = node.ChildNodes(0).InnerText
                        btnBest.Text = intUser & ": " & intBest
                    End If

                Next
            End If
        Next

        For Each node In LoginNodes 'finds users Average Score
            If node.ChildNodes(0).InnerText = Home.intUserName Then
                intScore = node.ChildNodes(6).InnerText
                lblYou.Text = Home.intUserName & ": " & intScore
            End If

        Next

        loginInfo.Save("userData.xml") 'saves data
    End Sub
End Class