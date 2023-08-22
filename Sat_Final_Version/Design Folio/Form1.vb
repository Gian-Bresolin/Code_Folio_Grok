Imports System.Xml
Imports System.IO
Public Class Form1



    Private Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click


        If Not String.IsNullOrEmpty(txtUserName.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then

            Dim ReaderControl As XmlReader = XmlReader.Create("userData.xml")
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
                                If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "password" Then
                                    StoredCode = ReaderControl.ReadElementString 'stores finding
                                    If VerifyPassword(Passcode, StoredCode) Then 'compares result to see if they match
                                        FoundPC = True 'if they match
                                        Display_Classes.lblUserName.Text = UserID
                                        Me.Hide()
                                        Display_Classes.Show()

                                    Else
                                        MsgBox("Incorrect Login Details")
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
                ElseIf FoundPC = False Then
                    MsgBox("Incorrect Login Details")
                End If
            End Using

        Else
            MsgBox("Please enter details")
        End If


    End Sub




    'All code pass this point is used to setup 
    Private Function HashPassword(password As String) As String 'used to create hash passwords
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function
End Class
