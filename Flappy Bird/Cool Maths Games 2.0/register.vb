Imports System.Xml

Public Class register
    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        txtName.Clear()
        txtPassword.Clear()
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim ReaderControl As XmlReader = XmlReader.Create("userData.xml")
        Dim UserID As String = txtName.Text 'stores username in txtname
        Dim FoundID As Boolean = False 'used to identify if information is correct
        Dim StoredID As String 'used to compare names found within the xml
        Dim Document As XDocument
        Document = XDocument.Load("userData.xml") 'loads Data.xml

        Using ReaderControl
            Do While ReaderControl.Read()
                If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "name" Then 'searches for nodes with name
                    StoredID = ReaderControl.ReadElementString 'stores searches
                    If txtPassword.Text.Length < 4 Then 'if password is to short
                        MsgBox("Password to short")
                        Return
                    End If
                    If StoredID = UserID Then 'compares with input
                        FoundID = True ' if input matches node
                        ReaderControl.Read()
                    End If


                End If

            Loop
            If FoundID = True Then 'if data does not match
                MsgBox("Username is taken")
                Return
            End If

        End Using

        Dim xelement As XElement = XElement.Load("userData.xml") 'sets varibles to load xml
        Dim data As IEnumerable(Of XElement) = xelement.Elements()

        Home.intUserName = txtName.Text
        Dim strName As String = txtName.Text 'stores text in variable
        Dim strCredits As String = "0" 'sets up nodes for information
        Dim strGold As String = "0"
        Dim strDiamond As String = "0"
        Dim strDark As String = "0"
        Dim strHigh As String = "0"
        Dim strS As String = "0"
        Dim strP As String = "0"
        Dim strPass As String = txtPassword.Text 'stores text in variable

        Dim root = New XElement("user") 'sets node as Name
        Dim NameElement = New XElement("name", strName) 'puts rest of info into the node
        Dim PassElement = New XElement("passcode", strPass) 'text in red is used as the title of the information for its section
        Dim CreditsElement = New XElement("Credits", strCredits)
        Dim goldElement = New XElement("gold", strGold)
        Dim diamondElement = New XElement("diamond", strDiamond)
        Dim darkElement = New XElement("dark", strDark)
        Dim highElement = New XElement("HS", strHigh)
        Dim pElement = New XElement("P", strP)
        Dim sElement = New XElement("S", strS)




        root.Add(NameElement, PassElement, CreditsElement, goldElement, diamondElement, darkElement, highElement, pElement, sElement) 'information inputed into the node are in this sequance 
        Document.Root.Add(root) 'adds closing root
        Document.Save("userData.xml") 'closes document
        Me.Hide()
        Home.Show()





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FlappyBird.Show()
    End Sub


End Class