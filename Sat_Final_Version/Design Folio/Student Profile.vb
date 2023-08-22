Imports System.Xml

Public Class Student_Profile

    Public teacherNode As XmlElement
    Public userData As XmlDocument
    Public strStudentName As String
    Public studentCount
    Private Sub Student_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads average and sets profile name
        loadClassAverage()
        lblStudentName.Text = strStudentName & "'s Profile"


    End Sub


    Private Sub loadClassAverage()
        Dim teacherIndex As Integer                                                                                 ' used as an index to go through classes
        Dim teacherNodes As XmlNodeList = userData.SelectNodes("/teachers/teacher")                                 'select node
        Dim intTotalClasses As Integer = teacherNodes.Count                                                         'used to get number of classes
        Dim intFinalGrade As Double = 0                                                                             'used to store final grade
        studentCount = 0                                                                                            'used to average out with correct number

        For teacherIndex = 0 To intTotalClasses - 1                                                                 'runs through classes

            Dim intTotalScore As Integer = 0
            Dim strClassName = teacherNodes(teacherIndex).ChildNodes(4).InnerText                                   'gets class name
            Dim booStudentIsInClass As Boolean = False                                                              'sets up and resets boolean
            Dim totalWeight As Double = 0

            For Each assignNode In teacherNodes(teacherIndex).ChildNodes(3).ChildNodes                              'Runs through assessments
                For Each resultNode In assignNode.childnodes(2).Childnodes                                          'runs through results
                    If resultNode.childnodes(0).innertext = strStudentName Then                                     'finds matching name
                        intTotalScore += (resultNode.childnodes(1).innertext * assignNode.childnodes(1).innertext)  'adds score times weight

                        totalWeight += assignNode.childnodes(1).innertext                                           'adds weight

                        booStudentIsInClass = True                                                                  'activaes boolean

                    End If
                Next
            Next
            If booStudentIsInClass = True Then                                                                      'when boolean is true
                studentCount += 1                                                                                   'adds student count for array


                Dim intAverage As Integer = (intTotalScore / 100)                                                   'used to divide average

                If 100 - totalWeight > 0 Then                                                                       'used to calculate missing weight
                    intAverage += ((100 - totalWeight) * intAverage) / 100
                End If

                intFinalGrade += intAverage

                dgvClassAverages.Rows.Add(strClassName, intAverage)                                                 'adds to data grid view

                cbxSelectedClass.Items.Add(strClassName)                                                            'adds class to the combo box

            End If

        Next
        intFinalGrade = intFinalGrade / studentCount

        If intFinalGrade >= 85 Then                                                                                 'finds right grade for the result
            lblClassGrade.Text = "A"
        ElseIf intFinalGrade >= 75 And intFinalGrade < 85 Then
            lblClassGrade.Text = "B"
        ElseIf intFinalGrade >= 55 And intFinalGrade < 75 Then
            lblClassGrade.Text = "C"
        ElseIf intFinalGrade >= 45 And intFinalGrade < 55 Then
            lblClassGrade.Text = "D"
        ElseIf intFinalGrade >= 30 And intFinalGrade < 45 Then
            lblClassGrade.Text = "D"
        Else lblClassGrade.Text = "F"
        End If
    End Sub

    Private Sub loadSelectedClass()
        dgvStudentGrade.Rows.Clear()
        Dim teacherIndex As Integer
        Dim teacherNodes As XmlNodeList = userData.SelectNodes("/teachers/teacher")                                 'select node
        Dim intTotalClasses As Integer = teacherNodes.Count
        Dim intGrade As Double = 0
        Dim totalWeight As Double
        Dim intFinalGrade As Double
        Dim intUnweighted As Integer
        Dim intRuns As Integer

        For teacherIndex = 0 To intTotalClasses - 1

            Dim strClassName = teacherNodes(teacherIndex).ChildNodes(4).InnerText
            If teacherNodes(teacherIndex).ChildNodes(4).InnerText = cbxSelectedClass.SelectedItem Then
                For Each assignNode In teacherNodes(teacherIndex).ChildNodes(3).ChildNodes                           'finds assessment node
                    For Each resultNode In assignNode.ChildNodes(2).ChildNodes                                      'finds result node
                        If resultNode.childNodes(0).InnerText = strStudentName Then                                 'finds corresponding result to the current aryKIds

                            dgvStudentGrade.Rows.Add(assignNode.childnodes(0).innertext, resultNode.childNodes(1).innertext, assignNode.childnodes(1).innertext)
                            intGrade += (resultNode.childnodes(1).innertext * assignNode.childnodes(1).innertext) 'adds grade
                            totalWeight += assignNode.childnodes(1).innertext                                       'used to find weight
                            intUnweighted += resultNode.childnodes(1).innertext
                            intRuns += 1

                        End If
                    Next
                Next
            End If
        Next

        intGrade /= 100

        If 100 - totalWeight > 0 Then                                                                           'calcuates mssing weight
            intFinalGrade += (((100 - totalWeight) * (intUnweighted / intRuns))) / 100                                      'calculates grades with varibles

        End If



        intFinalGrade += intGrade





        If intFinalGrade >= 85 Then                                                 'finds necceray result
            lblSelectedClassGrade.Text = "A"
        ElseIf intFinalGrade >= 75 And intFinalGrade < 85 Then
            lblSelectedClassGrade.Text = "B"
        ElseIf intFinalGrade >= 55 And intFinalGrade < 75 Then
            lblSelectedClassGrade.Text = "C"
        ElseIf intFinalGrade >= 45 And intFinalGrade < 55 Then
            lblSelectedClassGrade.Text = "D"
        ElseIf intFinalGrade >= 30 And intFinalGrade < 45 Then
            lblSelectedClassGrade.Text = "D"
        Else lblSelectedClassGrade.Text = "F"
        End If
    End Sub

    Private Sub cbxSelectedClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelectedClass.SelectedIndexChanged
        loadSelectedClass()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Display_Classes.Show()
        Me.Close()
    End Sub


End Class