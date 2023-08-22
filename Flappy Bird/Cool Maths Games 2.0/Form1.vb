Imports System.Xml
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Visible = False 'hides the labels
        lblPass.Visible = False
    End Sub

    Private Sub lblregister_Click_1(sender As Object, e As EventArgs) Handles lblregister.Click
        txtPassword.Clear() 'clears text and shows register screen
        txtUserName.Clear()
        Me.Hide()
        register.Show()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not String.IsNullOrEmpty(txtUserName.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then 'checks if any are empty

            Dim ReaderControl As XmlReader = XmlReader.Create("userData.xml") 'sets up xml
            Dim xelement As XElement = XElement.Load("userData.xml")
            Dim data As IEnumerable(Of XElement) = xelement.Elements() 'loads data.xml


            Dim UserID As String = txtUserName.Text 'stores username in txtname
            Dim Passcode As String = txtPassword.Text 'stores password
            Dim FoundID As Boolean = False 'used to identify if information is correct
            Dim FoundPC As Boolean = False '^
            Dim StoredID As String 'used to compare names found within the xml
            Dim StoredCode As String 'used to compare passwords found within the xml

            Using ReaderControl
                Do While ReaderControl.Read()
                    If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "name" Then 'searches for nodes with name
                        StoredID = ReaderControl.ReadElementString 'stores searches
                        If StoredID = UserID Then 'compares with input
                            FoundID = True ' if input matches node
                            Do While ReaderControl.Read() 'reads document looking for nodes with passcode
                                If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "passcode" Then
                                    StoredCode = ReaderControl.ReadElementString 'stores finding
                                    If StoredCode = Passcode Then 'compares result to see if they match
                                        FoundPC = True 'if they match
                                        Home.intCredits = ReaderControl.ReadElementString
                                        Home.intPassword = txtPassword.Text
                                        MsgBox("Welcome123, " & UserID)
                                        Home.intUserName = txtUserName.Text
                                        Me.Hide()
                                        Home.Show()

                                    End If
                                    Exit Sub
                                End If


                            Loop


                        End If
                        ReaderControl.Read()

                    End If

                Loop
                If FoundID = False Then 'if data does not match
                    MsgBox("Incorrect Login Details")
                ElseIf FoundPC = False Then 'if login details are wrong
                    MsgBox("Incorrect Login Details")
                    lblName.Visible = True
                    lblPass.Visible = True
                End If
            End Using

        Else
            MsgBox("Please enter details") 'if details are empty
        End If


    End Sub
End Class