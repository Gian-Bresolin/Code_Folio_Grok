Imports System.Xml

Public Class Create_Asessment2

    Public teacherNode As XmlElement
    Public userData As XmlDocument
    Public intAssignmentcount As Integer
    Public aryAssignment(0)
    Public totalWeight As Integer

    Private Sub btnCreatAssessment_Click(sender As Object, e As EventArgs) Handles btnCreatAssessment.Click
        Dim strNameAssignment As String = InputBox("Please add name of new assignment") 'stores text in variable


        If strNameAssignment = Nothing Then                                             'checks to see if data is blank
            MsgBox("The name can't be blank")
            Exit Sub
        End If


        For Each assignmentCheck In teacherNode.ChildNodes(3).ChildNodes                                                    'searches assignments
            If assignmentCheck.ChildNodes(0).innerText = strNameAssignment Then                                             'finds assignment names and checks if they match
                MsgBox("An assignment with this name already exsits. Please try again with a different name")               'informs user
                Exit Sub
                userData.Save("userData.xml")
            End If

        Next

        Dim strWeight As String = InputBox("Please add weight for Assignment it can't be greater then " & 100 - totalWeight & " and less then 0") 'Informs user of current weight left for assessments


        If strWeight = Nothing Then                                                                                           'Checks if there is something within the text box
            MsgBox("Insert a weight")
            Exit Sub
        End If
        If typeCheckInteger(strWeight) = False Then                                                                            'Checks to see if it is a number
            MsgBox("Weight must be a number")
            Exit Sub


        ElseIf strWeight < 0 Or strWeight > 100 - totalWeight Then                                                              ' Checks to ensure total weight does not go over 100
            MsgBox("Weight must be between 0 And " & 100 - totalWeight)
            Exit Sub
        End If

        Dim totalMarks As String = InputBox("Please add the total marks to the assessment")                                     'Used to input marks

        If totalMarks = Nothing Then                                                                                            'Used to check if there is something
            MsgBox("Insert a mark")
            Exit Sub
        End If
        If typeCheckInteger(totalMarks) = False Then                                                                            'Used to check if it is a number
            MsgBox("marks must be a number")
            Exit Sub


        ElseIf totalMarks <= 0 Then                                                                                             'makes sure to limit marks
            MsgBox("marks must be greater then 0")
            Exit Sub
        End If


        Dim assignmentNode As XmlElement = userData.CreateElement(“assignment”) 'creates empty shell of node
        Dim assigNameNode As XmlElement = userData.CreateElement(“name”)
        Dim weightNode As XmlElement = userData.CreateElement(“weight”)
        Dim result As XmlElement = userData.CreateElement(“results”)
        Dim marks As XmlElement = userData.CreateElement(“marks”)

        assignmentNode.AppendChild(assigNameNode)                                                                               'Used to append xml node to
        assigNameNode.InnerText = strNameAssignment                                                                             'Appends to xml node
        assignmentNode.AppendChild(weightNode)
        weightNode.InnerText = strWeight
        assignmentNode.AppendChild(result)
        assignmentNode.AppendChild(marks)
        marks.InnerText = totalMarks


        teacherNode.ChildNodes(3).AppendChild(assignmentNode)                                                                   'adds node to teachers assessments

        userData.Save("userData.xml")
        Me.Controls.Clear()                                                  'removes the ok button
        InitializeComponent()                                                'load all the controls again
        Create_Asessment2_Load(e, e)
    End Sub


    Function typeCheckInteger(ByVal intGuess As String) As Boolean 'peforms a task to check if intguess is a number then returns answer to the node typeCheckInteger
        Try
            Convert.ToInt32(intGuess)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Display_Classes.Show()
        Me.Close()

    End Sub

    Private Sub btnDeleteAssessment_Click(sender As Object, e As EventArgs) Handles btnDeleteAssessment.Click 'runs delete function
        deleteAssessment()
    End Sub

    Private Sub deleteAssessment()
        Dim messageForm As New Form()                                                                               'creates a new Form
        messageForm.Text = "Select Assessment to Delete"

        Dim comboBox As New ComboBox()                                                                              'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                       'sets location
        comboBox.Width = 200                                                                                        'sets width

        For i = 0 To intAssignmentcount - 1                                                                        'Add items to the combo box 
            comboBox.Items.Add(aryAssignment(i))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                      'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim selectedItem As String = comboBox.SelectedItem?.ToString()               'Retrieve the selected item from the combo box

                                       If selectedItem = Nothing Then
                                           MsgBox("No assigment Selected")
                                           Exit Sub
                                       End If

                                       For Each assignment In teacherNode.ChildNodes(3).ChildNodes
                                           If assignment.ChildNodes(0).innerText = selectedItem Then
                                               totalWeight -= assignment.childnodes(1).innertext
                                               teacherNode.ChildNodes(3).RemoveChild(assignment)

                                               userData.Save("userData.xml")

                                               messageForm.Close()                                                  'closes combo box
                                               Me.Controls.Clear()                                                  'removes the ok button
                                               InitializeComponent()                                                'load all the controls again
                                               Create_Asessment2_Load(e, e)
                                           End If

                                       Next
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                  'adds ok button

        messageForm.ShowDialog()                                                                            'displays form

    End Sub

    Private Sub Create_Asessment2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intAssignmentcount = teacherNode.ChildNodes(3).ChildNodes.Count                                             'sets assignment count to the number of assignemnts that the teacher has

        ReDim aryAssignment(intAssignmentcount)                                                                     'changes the array to fit the intAssignmentcount
        Dim i As Integer

        For Each assignNode In teacherNode.ChildNodes(3).ChildNodes                                                 'finds assessment nodes
            aryAssignment(i) = assignNode.Childnodes(0).innertext                                                   'fills the aryAssignment for later usage
            i += 1                                                                                                  'sets the column to one as name is already created
        Next
        setUpAssessmentList()

    End Sub

    Private Sub setUpAssessmentList()
        totalWeight = 0
        For assessmentIndex = 0 To intAssignmentcount - 1                                                          'used to run through number of assessments
            Dim intScore As Integer = 0                                                                             'sets up varibles and place in spot to reset on loop
            Dim intAmountOfScore As Integer = 0
            Dim intWeight As Integer
            Dim intMarks As Integer
            For Each assementNode In teacherNode.ChildNodes(3).ChildNodes                                           'Runs the the assessments

                If assementNode.childnodes(0).innertext = aryAssignment(assessmentIndex) Then                       'Find correspoing assessment
                    intWeight = assementNode.childnodes(1).innertext                                                'Adds values to the varibles
                    intMarks = assementNode.childnodes(3).innertext
                    For Each ResultsNode In assementNode.childnodes(2).childnodes                                   'Loops through results of students to find average
                        intScore += ResultsNode.childnodes(1).innertext                                             'adds score of student
                        intAmountOfScore += 1                                                                       'finds the amount of students with results


                    Next
                End If
            Next
            Dim intFinalScore = intScore / intAmountOfScore


            totalWeight += intWeight
            dgvAssessmentStats.Rows.Add(aryAssignment(assessmentIndex), intWeight, intMarks, Math.Round(intFinalScore)) 'adds to data grid view
        Next


    End Sub

    Private Sub btnEditAssessment_Click(sender As Object, e As EventArgs) Handles btnEditAssessment.Click
        editAssessment()
    End Sub

    Private Sub editAssessment()
        If rdoName.Checked Or rdoWeight.Checked Or rdoMarks.Checked Then
        Else
            MsgBox("Please select an option")
            Exit Sub
        End If
        Dim messageForm As New Form()                                                                               'creates a new Form
        messageForm.Text = "Select Assessment to Change"

        Dim comboBox As New ComboBox()                                                                              'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                       'sets location
        comboBox.Width = 200                                                                                        'sets width

        For i = 0 To intAssignmentcount - 1                                                                        'Add items to the combo box 
            comboBox.Items.Add(aryAssignment(i))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                      'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim selectedItem As String = comboBox.SelectedItem?.ToString()               'Retrieve the selected item from the combo box

                                       If selectedItem = Nothing Then                                               'Checks if there was an input
                                           MsgBox("No assigment Selected")
                                           Exit Sub
                                       End If



                                       For Each assignment In teacherNode.ChildNodes(3).ChildNodes                   'runs through assessment
                                           If assignment.ChildNodes(0).innerText = selectedItem Then                 'checks if there is amatching 
                                               If rdoWeight.Checked Then
                                                   Dim intWeight = InputBox("Please put in New weight it must be between " & 100 - totalWeight + assignment.Childnodes(1).innertext & " and 0") 'gets weight value
                                                   If intWeight = Nothing Then                                                                             'Checks for an input
                                                       MsgBox("The Weight can't be blank")
                                                       Exit Sub
                                                   End If
                                                   If typeCheckInteger(intWeight) = False Then                                                              'Checks for weight
                                                       MsgBox("Weight must be a number")
                                                       Exit Sub
                                                   ElseIf intWeight < 0 Or intWeight > 100 - totalWeight + assignment.childnodes(1).innertext Then                                               'Checks for weight range
                                                       MsgBox("Weight must be between 1 and " & 100 - totalWeight)
                                                       Exit Sub
                                                   End If
                                                   assignment.ChildNodes(1).InnerText = intWeight                                                           'changes value

                                               ElseIf rdoName.Checked Then
                                                   Dim intAssignmentName = InputBox("Please put in new Name")                                               'gets value from input
                                                   If intAssignmentName = Nothing Then                                                                      'checks if there was an input
                                                       MsgBox("The name can not be blank")
                                                       Exit Sub


                                                   End If

                                                   For Each assignmentCheck In teacherNode.ChildNodes(3).ChildNodes                                          'checks to make sure there is no repeat names
                                                       If assignmentCheck.ChildNodes(0).innerText = intAssignmentName Then
                                                           MsgBox("An assignment with this name already exsits. Please try again with a different name")
                                                           Exit Sub
                                                       End If

                                                   Next

                                                   assignment.ChildNodes(0).InnerText = intAssignmentName                                                   'changes name
                                               Else

                                                   Dim intMarks = InputBox("Please input marks")                                                            'gets value from input
                                                   If intMarks = Nothing Then                                                                               'checks if there was an input
                                                       MsgBox("The Marks can't be blank")
                                                       Exit Sub
                                                   End If
                                                   If typeCheckInteger(intMarks) = False Then                                                               'makes sure it is a number
                                                       MsgBox("Marks must be a number")
                                                       Exit Sub
                                                   ElseIf intMarks <= 0 Then                                                                                 'ensures marks can't be less or = to 0
                                                       MsgBox("Marks must be above 0")
                                                       Exit Sub
                                                   End If
                                                   assignment.ChildNodes(3).InnerText = intMarks                                                             'changes value

                                               End If
                                               userData.Save("userData.xml")
                                           End If

                                       Next
                                       userData.Save("userData.xml")

                                       messageForm.Close()                                                  'closes combo box
                                       Me.Controls.Clear()                                                  'removes the ok button
                                       InitializeComponent()                                                'load all the controls again
                                       Create_Asessment2_Load(e, e)
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                  'adds ok button

        messageForm.ShowDialog()                                                                            'displays form

    End Sub
End Class