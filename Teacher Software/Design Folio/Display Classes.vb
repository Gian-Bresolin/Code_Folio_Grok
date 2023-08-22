Imports System.Xml
Imports System.Windows.Forms

Public Class Display_Classes

    Public userData As New XmlDocument                                                                              'used to open the userData as an XmlDocument
    Public teacherNode As XmlElement                                                                                'used to store the teachers userName place in xml
    Public aryKids(0, 1)                                                                                            'used to store kids names and grades
    Public aryAssignment(0)                                                                                         'used to store assessment names
    Public intStudentCount As Integer                                                                               'used to store the number of students
    Public intAssignmentcount As Integer                                                                            'used to number of assessments
    Public messageForm As Form
    Public booResultMethod As Boolean                                                                               'used to activate different results sorting


    Private Sub Display_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load                          'runs on load
        userData.Load("userData.xml")                                                                               'loads data from xml
        booResultMethod = True
        lblUserName.Text = Form1.txtUserName.Text
        Dim teacherNodes As XmlNodeList = userData.SelectNodes("/teachers/teacher")                                 'select node
        For Each node In teacherNodes                                                                               'searchers all users


            If node.ChildNodes(0).InnerText = Form1.txtUserName.Text Then                                           'searches for the user
                teacherNode = node                                                                                  'sets the node of the teacher to easily call it up
                loadKids()                                                                                          'activates the load kids function
                loadAssignments()                                                                                   'activates the load Assignment function
                loadAssessmentIn(intStudentCount)                                                                   'activates the load AssessnmentIn function
                loadAvergesWeighted()
            End If

        Next
        rdoWeighted.Checked = True

    End Sub

    Private Sub loadKids()
        intStudentCount = teacherNode.ChildNodes(2).ChildNodes.Count                                                'sets student count to the number of students in the xml
        intAssignmentcount = teacherNode.ChildNodes(3).ChildNodes.Count                                             'sets assignment count to the number of assignemnts that the teacher has
        ReDim aryKids(intStudentCount, intAssignmentcount)                                                          'changes the array size to perfectly meet the required size for the user
        ReDim aryAssignment(intAssignmentcount)                                                                     'changes the array to fit the intAssignmentcount

        Dim i As Integer                                                                                            'used to change the array number
        For Each studentNode In teacherNode.ChildNodes(2).ChildNodes                                                'searches for student within their node
            aryKids(i, 0) = studentNode.innertext                                                                   'sets the aryKids(i, 0) to the student names

            dgvGridStorage.Rows.Add(aryKids(i, 0))                                                                  'adds the kids names to the rows 
            i += 1

        Next

    End Sub


    Private Sub loadAssignments()                                                                                   'sets size of grid and names 
        Dim i As Integer
        Dim intWeightMissing As Integer = 100
        For Each assignNode In teacherNode.ChildNodes(3).ChildNodes                                                 'finds assessment nodes
            aryAssignment(i) = assignNode.Childnodes(0).innertext                                                   'fills the aryAssignment for later usage
            i += 1                                                                                                  'sets the column to one as name is already created
            dgvGridStorage.ColumnCount += 1                                                                         'increases the column to be edited
            Dim name As String = "Name: " + assignNode.Childnodes(0).innertext
            Dim Weight As String = " Weight: " + assignNode.childnodes(1).innertext
            intWeightMissing -= assignNode.childnodes(1).innertext
            Dim Marks As String = " Marks: " + assignNode.childnodes(3).innertext
            dgvGridStorage.Columns(i).HeaderText = (name & Weight & Marks)                              'adds the assessment names to the column names
        Next

        i += 1                                                                                                      'adds to add to the next column as average is always present
        dgvGridStorage.ColumnCount += 2                                                                             'adds the average column
        dgvGridStorage.Columns(i).HeaderText = "Average"                                                            'adds the name to the column
        i += 1                                                                                                      'adds to add to the next column as average is always present
        dgvGridStorage.Columns(i).HeaderText = "Letter Grade"                                                        'adds the name to the column
        lblMissingWeight.Text = ("The missing weight is " & intWeightMissing)

    End Sub

    Private Sub loadAssessmentIn(ByVal intStudentCount As Integer)                                                  'adds the grades to the assessments
        Dim x As Integer = 1
        For studentIndex = 0 To intStudentCount
            Dim assignIndex As Integer = 1                                                                          'Index starts at 1 because column 0 is the name column
            For Each assignNode In teacherNode.ChildNodes(3).ChildNodes                                             'finds assessment node
                For Each resultNode In assignNode.ChildNodes(2).ChildNodes                                          'finds result node
                    If resultNode.childNodes(0).InnerText = aryKids(studentIndex, 0) Then                           'finds corresponding result to the current aryKIds
                        dgvGridStorage.Rows(studentIndex).Cells(assignIndex).Value = resultNode.childNodes(1).InnerText 'used (x,y) method to allocate grades in the collumns
                        aryKids(studentIndex, x) = dgvGridStorage.Rows(studentIndex).Cells(assignIndex).Value       'puts the results into the corresponding kids array 
                        x += 1
                    End If
                Next

                assignIndex += 1                                                                                    'Increment by 1 because you loop the next assignment
                If x > intAssignmentcount Then                                                                      'resets the to enure it doesn't go over the assignment count
                    x = 1

                End If
            Next
        Next
    End Sub


    Private Sub loadAverage()                                                                                       ''''loads the averages
        Dim intAverage As Integer                                                                                   'used to add all numbers in
        Dim intFinalAverage As Integer                                                                              'used to store final average
        Dim intTotalAssignment As Integer = intAssignmentcount                                                      'done to be able edit intTotalAssignment without editing intAssignmentcount

        For y = 0 To intStudentCount - 1                                                                            'intStudentCount starts at 0 but the aryKids starts at 0 so the -1 makes sure the count is correct
            intTotalAssignment = intAssignmentcount                                                                 'used to reset intTotalAssignment
            For i = 1 To intAssignmentcount                                                                         'Ignores results that are nothing tp ensure average stays correct
                If aryKids(y, i) = Nothing Then
                    intTotalAssignment -= 1
                End If
                intAverage += aryKids(y, i)                                                                         'adds the students grades
            Next
            If Not intTotalAssignment = 0 Then
                intFinalAverage = intAverage / intTotalAssignment                                                       'divides intAverage by the total Assessments added
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 1).Value = intFinalAverage                            'adds the averages to their respective column


                If intFinalAverage >= 85 Then                                                                       'Runs an if staments to find the corresponding grade
                    dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "A"                                'addes grades to dgv
                ElseIf intFinalAverage > 75 And intFinalAverage < 85 Then
                    dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "B"
                ElseIf intFinalAverage > 55 And intFinalAverage < 75 Then
                    dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "C"
                ElseIf intFinalAverage > 45 And intFinalAverage < 55 Then
                    dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "D"
                ElseIf intFinalAverage > 30 And intFinalAverage < 45 Then
                    dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "D"
                Else dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "F"
                End If

                intFinalAverage = 0
                intAverage = 0
            End If
        Next

    End Sub

    Private Sub loadAvergesWeighted()
        Dim intFinalAverage As Integer = 0                                                                          'Used to store the final average

        For y = 0 To intStudentCount - 1                                                              'used to loop through all students


            Dim intTotalScore As Integer = 0                                                                        'used to store total score
            Dim booStudentIsInClass As Boolean = False                                                              'used to crate boolean
            Dim totalWeightStudent As Integer = 0                                                                          'stores total weight


            For Each assignNode In teacherNode.ChildNodes(3).ChildNodes                                             'runs through assessments

                For Each resultNode In assignNode.childnodes(2).Childnodes                                          'runs through results

                    If resultNode.childnodes(0).innertext = aryKids(y, 0) Then                                      'checks for student name

                        intTotalScore += (resultNode.childnodes(1).innertext * assignNode.childnodes(1).innertext)  'adds weighted grade

                        totalWeightStudent += assignNode.childnodes(1).innertext                                           'Adds the weight from the assessment

                        booStudentIsInClass = True                                                                  'activates the boolean 

                    End If
                Next
            Next
            If booStudentIsInClass = True Then                                                                      'when student is found

                Dim intAverage As Integer = (intTotalScore / 100)                                                   'finds average score



                If booResultMethod = False Then                                                                   'used to caluate weighted average and weighted average with missing weight fill
                    intFinalAverage += intAverage / (totalWeightStudent / 100)


                Else
                    intFinalAverage += intAverage




                End If




            End If


            dgvGridStorage.Rows(y).Cells(intAssignmentcount + 1).Value = intFinalAverage                            'adds the averages to their respective column



            If intFinalAverage >= 85 Then                                                                            'Runs an if staments to find the corresponding grade and adds it to dgv
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "A"
            ElseIf intFinalAverage > 75 And intFinalAverage < 85 Then
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "B"
            ElseIf intFinalAverage > 55 And intFinalAverage < 75 Then
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "C"
            ElseIf intFinalAverage > 45 And intFinalAverage < 55 Then
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "D"
            ElseIf intFinalAverage > 30 And intFinalAverage < 45 Then
                dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "D"
            Else dgvGridStorage.Rows(y).Cells(intAssignmentcount + 2).Value = "F"
            End If

            intFinalAverage = 0
        Next







    End Sub
    Private Sub btnAssessmentSettings_Click(sender As Object, e As EventArgs) Handles btnAssessmentSettings.Click                  '''''used to go to AssessmentSettings
        Create_Asessment2.teacherNode = teacherNode                                                                 'transfers important varibles that are needed
        Create_Asessment2.userData = userData
        Create_Asessment2.Show()                                                                                    'shows assessmentSettings
        Me.Close()                                                                                                  'cloes this to be able to update when coming back
    End Sub



    Private Sub btnEditGrade_Click(sender As Object, e As EventArgs)                      'allows the user to add a grade to all students in a selected assessment
        addGradeToAll()                                                                                             'acitvates addGradeToAll function
    End Sub
    Public Sub addGradeToAll()
        Dim messageForm As New Form()                                                                               'creates a new Form
        messageForm.Text = "Select Assessment to add grades to"

        Dim comboBox As New ComboBox()                                                                              'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                       'sets location
        comboBox.Width = 200                                                                                        'sets width

        For i = 0 To intAssignmentcount - 1                                                                         'Add items to the combo box 
            comboBox.Items.Add(aryAssignment(i))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                       'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)

                                       Dim selectedItem As String = comboBox.SelectedItem?.ToString()               'retives the combobox data
                                       Dim strScore                                                         'used to store the selected grade

                                       If selectedItem = "" Or selectedItem = Nothing Then                                               'checks to see if an item is selected
                                           MsgBox("No assignment Selected")                                         'displays a message box when nothing selected
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub                                                                 'leaves the sub
                                       End If


                                       For Each assigmentCheckAdd In teacherNode.ChildNodes(3).ChildNodes       'searches for the assessment node in the xml
                                           If assigmentCheckAdd.ChildNodes(0).innerText = selectedItem Then     'finds the correct asssessment node in xml
                                               For studentIndex = 0 To intStudentCount - 1                                             'used to run through all the students in the class
                                                   Dim boeStudentExists As Boolean = False
                                                   For Each resultNode In assigmentCheckAdd.childnodes(2).childnodes


                                                       If resultNode.childNodes(0).InnerText = aryKids(studentIndex, 0) Then 'checks to see if a student has a result already created
                                                           boeStudentExists = True

                                                           strScore = InputBox(aryKids(studentIndex, 0) & " has the grade " & resultNode.childNodes(1).innerText & " for the selected assessment leave blank if wanting to leave the grade the same otherwise add new mark ") 'used for the user to input data into
                                                           If strScore = Nothing Or strScore = "" Then                           'validates the user input
                                                               MsgBox("Mark has not been changed")
                                                               Exit For
                                                           End If

                                                           If typeCheckInteger(strScore) = False Then
                                                               MsgBox("Mark must be a number")
                                                               Exit For
                                                           End If
                                                           Dim intScore As Integer = strScore

                                                           If intScore > assigmentCheckAdd.childnodes(3).innertext Or intScore < 0 Then                                   'exsistance checking
                                                               MsgBox("must be between 0 and " & assigmentCheckAdd.childnodes(3).innertext)                       'msgbox to inform user
                                                               Exit For                                                 'exits the for loop
                                                           End If

                                                           changeGrade(selectedItem, studentIndex, strScore)               'activates the change grade function
                                                       End If
                                                   Next
                                                   If boeStudentExists = False Then                              'runs if the student does not have a result
                                                       Dim booError As Boolean = False                              'can't exit the for loop so a boolean is used to ignore the create grade
                                                       strScore = InputBox("Add Mark for student " & aryKids(studentIndex, 0)) 'the user can add a grade
                                                       If strScore = Nothing Or strScore = "" Then                           'validates exsetiance 
                                                           MsgBox("Mark can not be nothing")
                                                           booError = True
                                                       End If
                                                       If booError = False Then                                 'the boo must constanly be checked to make sure multiple valification do not go off

                                                           If typeCheckInteger(strScore) = False Then
                                                               MsgBox("Mark must be a number")
                                                               booError = True
                                                           End If

                                                           If booError = False Then
                                                               Dim intScore As Integer = strScore

                                                               If intScore < 0 Or intScore > assigmentCheckAdd.childnodes(3).innertext Then                                   'exsistance checking
                                                                   MsgBox("must be between 0 and " & assigmentCheckAdd.childnodes(3).innertext)                       'msgbox to inform user
                                                                   booError = True

                                                               End If
                                                               If booError = False Then
                                                                   createGrade(selectedItem, studentIndex, strScore)               'activats the create garde function
                                                               End If
                                                           End If

                                                       End If
                                                   End If

                                               Next


                                           End If

                                       Next











                                       userData.Save("userData.xml")                                        'saves xml

                                       messageForm.Close()                                                  'closes combo box
                                       Me.Controls.Clear()                                                  'removes the ok button
                                       InitializeComponent()                                                'load all the controls again
                                       Display_Classes_Load(e, e)                                           'loads form again
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                  'adds ok button

        messageForm.ShowDialog()                                                                            'displays form

    End Sub

    Function typeCheckInteger(ByVal check As String) As Boolean                                             'peforms a task to check if intguess is a number then returns answer to the node typeCheckInteger
        Try                                                                                                 'falls back to try if failed
            Convert.ToInt32(check)                                                                          'attempts to convert check to number
            Return True                                                                                     'if possible returns true
        Catch ex As Exception                                                                               'else it will will throw an exception and return false
            Return False
        End Try
    End Function

    Private Sub createGrade(ByVal selecteditem As String, ByVal i As Integer, ByVal strScore As Integer)
        Dim resultNode As XmlElement = userData.CreateElement(“result”)                                     'creates empty shell of node
        Dim nameNode As XmlElement = userData.CreateElement("Name")
        Dim scoreNode As XmlElement = userData.CreateElement(“score”)
        Dim store As Double
        For Each assigmentAdd In teacherNode.ChildNodes(3).ChildNodes                                       'finds assessment node 

            If assigmentAdd.ChildNodes(0).innerText = selecteditem Then                                     'searches for the assessment name
                assigmentAdd.ChildNodes(2).AppendChild(resultNode)                                          'used to add to xml
                resultNode.AppendChild(nameNode)                                                            'used to add to empty shell
                nameNode.InnerText = aryKids(i, 0)
                resultNode.AppendChild(scoreNode)

                store = (strScore / assigmentAdd.childnodes(3).innertext) * 100
                scoreNode.InnerText = Math.Round(store, 2)
            End If



        Next
        userData.Save("userData.xml")                                        'saves xml

    End Sub

    Private Sub changeGrade(ByVal selectedItem As String, ByVal i As Integer, ByVal strScore As Integer)
        For Each assignment In teacherNode.ChildNodes(3).ChildNodes                                        'used to find assessment node


            If assignment.childnodes(0).innerText = selectedItem Then                                       'used to find the correct assessment

                Dim boeStudentFound As Boolean = False

                For Each assessmentChild In assignment.childNodes(2).childNodes 'used to sort through all nodes


                    If assessmentChild.ChildNodes(0).innertext = aryKids(i, 0) Then                         'seaches for the result node that has the students name
                        assessmentChild.ChildNodes(1).innerText = Math.Round((strScore / assignment.childnodes(3).innertext) * 100, 2)                          'changes the node
                        userData.Save("userData.xml")                                        'saves xml
                        boeStudentFound = True
                    End If
                Next
                If boeStudentFound = False Then
                    createGrade(selectedItem, i, strScore)
                End If
            End If

        Next


    End Sub

    Private Sub btnStudentGrade_Click(sender As Object, e As EventArgs)
        addGradeToStudent()
    End Sub

    Public Sub addGradeToStudent()
        Dim messageForm As New Form()                                                                       'creates a new Form
        messageForm.Text = "Select Student to add mark to"

        Dim comboBox As New ComboBox()                                                                       'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                'sets location
        comboBox.Width = 200                                                                                 'sets width

        For i = 0 To intStudentCount - 1                                                                         'Add items to the combo box 
            comboBox.Items.Add(aryKids(i, 0))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                      'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim chosenStudent As Integer
                                       If comboBox.SelectedItem?.ToString() = Nothing Or comboBox.SelectedItem?.ToString() = "" Then
                                           MsgBox("No student selected")
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If
                                       For c = 0 To intStudentCount - 1
                                           If aryKids(c, 0) = comboBox.SelectedItem?.ToString() Then
                                               chosenStudent = c
                                           End If
                                       Next
                                       addGradeToStudent2(chosenStudent, messageForm)
                                       messageForm.Close()                                             'closes combo box
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                  'adds ok button

        messageForm.ShowDialog()                                                                            'displays form

    End Sub

    Public Sub addGradeToStudent2(ByVal chosenStudent As Integer, ByVal prevMessageForm As Form)
        prevMessageForm.Close()                                                      'cloes the combo box
        Dim messageForm As New Form()                                                                               'creates a new Form
        messageForm.Text = "Select Assessment to add marks to"

        Dim comboBox As New ComboBox()                                                                              'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                       'sets location
        comboBox.Width = 200                                                                                        'sets width

        For i = 0 To intAssignmentcount - 1                                                                         'Add items to the combo box 
            comboBox.Items.Add(aryAssignment(i))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                       'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim chosenAssessment As String = comboBox.SelectedItem?.ToString()
                                       Dim intMark As Integer
                                       If chosenAssessment = Nothing Or chosenAssessment = "" Then
                                           MsgBox("No Assessment selected")
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If

                                       Dim strScore = InputBox("Add mark for student ")

                                       If strScore = Nothing Or strScore = "" Then                           'validates exsetiance 
                                           MsgBox("mark can not be nothing")
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If

                                       If typeCheckInteger(strScore) = False Then
                                           MsgBox("Mark must be a number")
                                           messageForm.Close()                                                      'cloes the combo box

                                           Exit Sub
                                       End If
                                       Dim intScore As Integer = strScore
                                       For Each assigmentCheckAdd In teacherNode.ChildNodes(3).ChildNodes       'searches for the assessment node in the xml
                                           If assigmentCheckAdd.ChildNodes(0).innerText = chosenAssessment Then

                                               intMark = assigmentCheckAdd.childnodes(3).innertext
                                           End If
                                       Next
                                       If intScore > intMark Or intScore < 0 Then                                   'exsistance checking
                                           MsgBox("must be between 0 and " & intMark)                       'msgbox to inform user
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If

                                       changeGrade(chosenAssessment, chosenStudent, strScore)

                                       messageForm.Close()                                             'closes combo box
                                       Me.Controls.Clear()                                                  'removes the ok button
                                       InitializeComponent()                                                'load all the controls again
                                       Display_Classes_Load(e, e)                                           'loads form again

                                   End Sub
        messageForm.Controls.Add(okButton)                                                                           'adds ok button

        messageForm.ShowDialog()
    End Sub

    Private Sub txtStudentProfileChanged(sender As Object, e As EventArgs) Handles txtStudentProfile.TextChanged
        Dim studentSearch As XmlNodeList = userData.SelectNodes("/teachers/teacher/students")           'runs through all students and doesn't use teachnode to gain acces to ones outside class
        cbxSearchResults.Items.Clear()                                                                  'clears text box

        If txtStudentProfile.TextLength > 0 Then                                                        'checks for the text within the text box
            Dim lastChar As Char = txtStudentProfile.Text(txtStudentProfile.TextLength - 1)             'finds recent character

            If Char.IsLetter(lastChar) Then                                                             'checks for a letter
                Dim uniqueNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)              'creates a new HashSet to store unique names

                For Each students In studentSearch                                                       'loops through st
                    For Each student As XmlNode In students.ChildNodes                                  'loops through students node
                        Dim studentName As String = student.InnerText                                   'stores student's name as string

                        If studentName.Length >= txtStudentProfile.TextLength AndAlso studentName.Substring(0, txtStudentProfile.TextLength).Equals(txtStudentProfile.Text, StringComparison.OrdinalIgnoreCase) Then
                            ' Check if the length of 'studentName' is greater than or equal to the length of the text in 'txtStudentProfile'
                            ' and if the first characters of 'studentName' match the text in 'txtStudentProfile' 

                            uniqueNames.Add(studentName)                                                'adds to th ehasset to keep track of names that match requirments
                        End If
                    Next
                Next

                cbxSearchResults.Items.AddRange(uniqueNames.ToArray()) 'adds all unqiue names to the combo box
            End If
        End If


    End Sub

    Private Sub btnFindProfile_Click(sender As Object, e As EventArgs) Handles btnFindProfile.Click
        If Not cbxSearchResults.SelectedItem = Nothing Then
            Student_Profile.strStudentName = cbxSearchResults.SelectedItem
            Student_Profile.teacherNode = teacherNode                                                                 'transfers important varibles that are needed
            Student_Profile.userData = userData
            Student_Profile.Show()
            Me.Close()
        Else
            MsgBox("Please select a student")
        End If
    End Sub


    Private Sub btnResultSetting_Click(sender As Object, e As EventArgs) Handles btnResultSetting.Click
        Me.Hide()
        gradeSetting.Show()
    End Sub

    Public Sub deleteGrade()
        Dim messageForm As New Form()                                                                       'creates a new Form
        messageForm.Text = "Select Student to remove Grade from"

        Dim comboBox As New ComboBox()                                                                       'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                'sets location
        comboBox.Width = 200                                                                                 'sets width

        For i = 0 To intStudentCount - 1                                                                         'Add items to the combo box 
            comboBox.Items.Add(aryKids(i, 0))                                                                    'used for to loop through all assignment names
        Next

        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                      'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim chosenStudent As Integer
                                       If comboBox.SelectedItem?.ToString() = Nothing Or comboBox.SelectedItem?.ToString() = "" Then
                                           MsgBox("No student selected")
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If
                                       For c = 0 To intStudentCount - 1
                                           If aryKids(c, 0) = comboBox.SelectedItem?.ToString() Then
                                               chosenStudent = c
                                           End If
                                       Next
                                       deleteGrade2(chosenStudent, messageForm)
                                       messageForm.Close()                                             'closes combo box
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                  'adds ok button

        messageForm.ShowDialog()                                                                            'displays form

    End Sub

    Public Sub deleteGrade2(ByVal chosenStudent As Integer, ByVal prevMessageForm As Form)
        prevMessageForm.Close()                                                      'cloes the combo box
        Dim messageForm As New Form()                                                                               'creates a new Form
        messageForm.Text = "Select Assessment to remove mark From"

        Dim comboBox As New ComboBox()                                                                              'creates a combo box varible
        comboBox.Location = New Point(10, 10)                                                                       'sets location
        comboBox.Width = 200                                                                                        'sets widt

        Dim booStudentHasResult As Boolean = False
        For Each assignment In teacherNode.ChildNodes(3).ChildNodes
            For Each Result In assignment.ChildNodes(2).ChildNodes
                If Result.ChildNodes(0).InnerText = aryKids(chosenStudent, 0) Then
                    comboBox.Items.Add(assignment.childnodes(0).innertext)
                    booStudentHasResult = True
                End If
            Next
        Next
        If booStudentHasResult = False Then
            MsgBox("Student has no results")
            messageForm.Close()                                                  'closes combo box
            Exit Sub
        End If


        messageForm.Controls.Add(comboBox)                                                                          'Displays combo box

        Dim okButton As New Button()                                                                                'creates the ok button
        okButton.Text = "Ok"                                                                                        'sets text
        okButton.Location = New Point(10, 40)                                                                       'overlays button onto combo box

        AddHandler okButton.Click, Sub(sender As Object, e As EventArgs)
                                       Dim chosenAssessment As String = comboBox.SelectedItem?.ToString()
                                       If chosenAssessment = Nothing Or chosenAssessment = "" Then
                                           MsgBox("No Assessment selected")
                                           messageForm.Close()                                                      'cloes the combo box
                                           Exit Sub
                                       End If
                                       Dim booFound As Boolean = False
                                       For Each assignment In teacherNode.ChildNodes(3).ChildNodes
                                           If assignment.ChildNodes(0).InnerText = chosenAssessment Then
                                               For Each Result In assignment.ChildNodes(2).ChildNodes
                                                   If Result.ChildNodes(0).InnerText = aryKids(chosenStudent, 0) Then
                                                       booFound = True
                                                       assignment.ChildNodes(2).RemoveChild(Result)

                                                   End If
                                               Next
                                               'loads form again (if needed)
                                           End If
                                       Next
                                       If booFound = False Then
                                           MsgBox("The student selected does not have a mark for this subject")
                                       End If
                                       userData.Save("userData.xml")

                                       messageForm.Close()                                                  'closes combo box
                                       Me.Controls.Clear()                                                  'removes the ok button
                                       InitializeComponent()                                                'load all the controls again
                                       Display_Classes_Load(e, e)
                                   End Sub
        messageForm.Controls.Add(okButton)                                                                           'adds ok button

        messageForm.ShowDialog()
    End Sub

    Private Sub rdoWeighted_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdoWeighted.CheckedChanged
        booResultMethod = True
        If rdoWeighted.Checked Then
            rdoAveraged.Checked = False
        End If
        loadAvergesWeighted()
    End Sub

    Private Sub rdoAveraged_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdoAveraged.CheckedChanged
        booResultMethod = False
        If rdoAveraged.Checked Then
            rdoWeighted.Checked = False
        End If
        loadAvergesWeighted()
    End Sub


    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click

        Dim fileName As String = "Tutorial.pdf"                                                                 ' Set the desired file name


        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, fileName)                      ' Combine the file name with the application's startup path to get the complete file path


        If System.IO.File.Exists(filePath) Then                                                                    ' Check if the file exists at the specified path

            Dim saveDialog As New SaveFileDialog()                                                              ' Create a SaveFileDialog to prompt the user to select a download location
            saveDialog.FileName = fileName
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"


            If saveDialog.ShowDialog() = DialogResult.OK Then                                                   ' Display the SaveFileDialog and proceed if the user selects a location

                Dim savePath As String = saveDialog.FileName                                                    ' Get the chosen save path

                Try

                    System.IO.File.Copy(filePath, savePath, True)                                               ' Copy the file from the application's path to the selected save path

                    MsgBox("File downloaded")                                                                   ' Display a success message
                Catch ex As Exception

                    MsgBox("Error downloading file: " & ex.Message)                                              ' Display an error message if there's an issue 
                End Try
            End If
        Else
            MsgBox("File could not be found")                                                                       ' Display a message if the file could not be found
        End If
    End Sub

End Class
