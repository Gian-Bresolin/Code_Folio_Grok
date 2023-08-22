Imports System.Xml

Public Class skins
    Public loginInfo As New XmlDocument
    Public intGold 'sets varibles for ownership
    Public intDiamond
    Public intBlack
    Public intSkin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPurchaseGold.Click
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        If intGold = 0 Then 'if they user owns the skin
            If Home.intCredits > 500 Then 'if rich enough

                For Each node In LoginNodes 'checks node

                    If node.ChildNodes(0).InnerText = Home.intUserName Then 'checks if bought it into menu
                        If node.ChildNodes(3).InnerText = 1 Then
                            MsgBox("You  allready own this")
                            Exit Sub
                        Else
                            If node.ChildNodes(6).InnerText > 100 Then 'if the users highscore is good enough
                                Home.intCredits -= 500 'minius the cerdits from account
                                node.ChildNodes(2).InnerText = Home.intCredits 'sets the new credits
                                node.ChildNodes(3).InnerText = 1 'sets variable for owning skin
                                intGold = 1 'sets it while it runs
                                MsgBox("Purchase Done")
                                btnPurchaseGold.Text = "equip" 'changes button to suit purchase
                                btnPurchaseGold.BackColor = Color.Red

                            Else
                                MsgBox("get good")
                            End If
                        End If

                    End If
                Next


                loginInfo.Save("userData.xml")
            Else
                MsgBox("your to poor")
            End If
        Else
            intSkin = 1 'code to show which skin selected
            btnPurchaseGold.BackColor = Color.Green

            If intBlack = 1 Then
                btnDark.BackColor = Color.Red
            End If
            If intDiamond = 1 Then
                btnDiamond.BackColor = Color.Red
            End If
            MsgBox("Gold Gooda Equiped")

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDark.Click '^ same as prevoius
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        If intBlack = 0 Then
            If Home.intCredits > 1250 Then

                For Each node In LoginNodes

                    If node.ChildNodes(0).InnerText = Home.intUserName Then
                        If node.ChildNodes(5).InnerText = 1 Then
                            MsgBox("you all ready own this")
                            Exit Sub
                        Else
                            If node.ChildNodes(6).InnerText > 300 Then
                                Home.intCredits -= 1250
                                node.ChildNodes(2).InnerText = Home.intCredits
                                node.ChildNodes(5).InnerText = 1
                                intBlack = 1
                                MsgBox("Purchase Done")
                                btnDark.Text = "equip"
                                btnDark.BackColor = Color.Red

                            Else
                                MsgBox("Get good")
                            End If

                        End If
                    End If
                Next

                loginInfo.Save("userData.xml")
            Else
                MsgBox("You're to poor.")
            End If

        Else
            intSkin = 2
            btnDark.BackColor = Color.Green
            If intDiamond = 1 Then
                btnDiamond.BackColor = Color.Red
            End If
            If intGold = 1 Then
                btnPurchaseGold.BackColor = Color.Red
            End If
            MsgBox("Dark Matter Equiped")
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        shop.Show()
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click '^ same as previous
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        If intDiamond = 0 Then
            If Home.intCredits > 750 Then

                For Each node In LoginNodes

                    If node.ChildNodes(0).InnerText = Home.intUserName Then
                        If node.ChildNodes(4).InnerText = 1 Then
                            MsgBox("you all ready own this")
                            Exit Sub
                        Else
                            If node.ChildNodes(6).InnerText > 200 Then
                                Home.intCredits -= 750
                                node.ChildNodes(2).InnerText = Home.intCredits
                                node.ChildNodes(4).InnerText = 1
                                MsgBox("Purchase Done")
                                intDiamond = 1
                                btnDiamond.Text = "equip"
                                btnDiamond.BackColor = Color.Red


                            Else
                                MsgBox("get good")
                            End If

                        End If
                    End If
                Next

                loginInfo.Save("userData.xml")
            Else
                MsgBox("your to poor")
            End If

        Else
            intSkin = 3
            btnDiamond.BackColor = Color.Green
            If intGold = 1 Then
                btnPurchaseGold.BackColor = Color.Red
            End If
            If intBlack = 1 Then
                btnDark.BackColor = Color.Red
            End If
            MsgBox("Diamond Doogle Equiped")
        End If
    End Sub

    Private Sub skins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginInfo.Load("userData.xml")
        Dim LoginNodes As XmlNodeList = loginInfo.SelectNodes("/Client/user")
        For Each node In LoginNodes 'checks each node
            If node.ChildNodes(0).InnerText = Home.intUserName Then 'checks users data if they own the skins
                If node.ChildNodes(3).InnerText = 1 Then 'checks node
                    btnPurchaseGold.Text = "equip" 'sets up button and variable
                    intGold = 1
                    btnPurchaseGold.BackColor = Color.Green

                End If
                If node.ChildNodes(4).InnerText = 1 Then '^
                    btnDiamond.Text = "equip"
                    intDiamond = 1
                    btnDiamond.BackColor = Color.Green

                End If
                If node.ChildNodes(5).InnerText = 1 Then '^
                    btnDark.Text = "equip"
                    intBlack = 1
                    btnDark.BackColor = Color.Green
                End If

            End If
        Next
        loginInfo.Save("userData.xml") 'saves data

    End Sub
End Class