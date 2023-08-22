Imports System.Xml
Public Class powerups
    Public loginInfo As New XmlDocument 'sets up variables
    Public intPhoneix
    Public intSlowD

    Private Sub btnPurchaseGold_Click(sender As Object, e As EventArgs) Handles btnPurchaseP.Click 'when gold skin selected
        loginInfo.Load("userData.xml") 'loads up
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        If intPhoneix = 0 Then 'if the user allready own it
            If Home.intCredits > 500 Then 'if user rich enough
                For Each node In LoginNodes 'checks each node
                    If node.ChildNodes(0).InnerText = Home.intUserName Then 'adds variable for purchase
                        Home.intCredits -= 500
                        node.ChildNodes(2).InnerText = Home.intCredits 'fixes redits for account
                        node.ChildNodes(7).InnerText = 1 'sets the vairble for the user
                        MsgBox("Purchase Done")
                        intPhoneix = 1
                        btnPurchaseP.Text = "Purchased" 'sets colour to purchased mode
                        btnPurchaseP.BackColor = Color.Green
                    End If
                Next
                loginInfo.Save("userData.xml") 'saves changes
            Else
                MsgBox("your to poor")
            End If
        ElseIf intPhoneix = 1 Then '''''''''''''''''''''if they already have it
            btnPurchaseP.Text = "Purchased" 'sets up button 
            btnPurchaseP.BackColor = Color.Green
            MsgBox("You all ready bought this")
        End If
    End Sub

    Private Sub btnSlow_Click(sender As Object, e As EventArgs) Handles btnSlow.Click 'same as before just changed
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        If intSlowD = 0 Then
            If Home.intCredits > 750 Then
                For Each node In LoginNodes
                    If node.ChildNodes(0).InnerText = Home.intUserName Then
                        Home.intCredits -= 750
                        node.ChildNodes(2).InnerText = Home.intCredits
                        node.ChildNodes(8).InnerText = 1
                        MsgBox("Purchase Done")
                        intSlowD = 1
                        btnSlow.Text = "Purchased"
                        btnSlow.BackColor = Color.Green
                    End If
                Next
                loginInfo.Save("userData.xml")
            Else
                MsgBox("your to poor")
            End If
        ElseIf intSlowD = 1 Then
            btnSlow.Text = "Purchased"
            btnSlow.BackColor = Color.Green
            MsgBox("You all ready bought this")
        End If
    End Sub

    Private Sub powerups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        For Each node In LoginNodes
            If node.ChildNodes(0).InnerText = Home.intUserName Then 'loads up users stats and links them to variables
                If node.ChildNodes(7).InnerText = 1 Then 'checks if users has required variable
                    btnPurchaseP.Text = "Purchased"
                    intPhoneix = 1
                    btnPurchaseP.BackColor = Color.Green


                End If
                If node.ChildNodes(8).InnerText = 1 Then '^
                    btnSlow.Text = "Purchased"
                    intSlowD = 1
                    btnSlow.BackColor = Color.Green


                End If
            End If
        Next
        loginInfo.Save("userData.xml")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() 'back button
        shop.Show()
    End Sub


End Class