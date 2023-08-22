Public Class gradeSetting

    Private Sub btnCreatGrade_Click(sender As Object, e As EventArgs) Handles btnCreatGrade.Click
        If rdoAddToAll.Checked Then
            Display_Classes.addGradeToAll()                                                                                             'acitvates addGradeToAll function
        ElseIf rdoAddToOne.Checked Then
            Display_Classes.addGradeToStudent()
        Else

            MsgBox("Please select an option")
        End If
    End Sub

    Private Sub rdoAddToOne_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddToOne.CheckedChanged  'Alll radio buttons switch eachother off and run their related function
        If rdoAddToOne.Checked Then
            rdoAddToAll.Checked = False

        End If
    End Sub

    Private Sub rdoAddToAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddToAll.CheckedChanged 'Add to all 
        If rdoAddToAll.Checked Then
            rdoAddToOne.Checked = False
        End If

    End Sub

    Private Sub btnEditGrade_Click(sender As Object, e As EventArgs) Handles btnEditGrade.Click 'edit student grade
        Display_Classes.addGradeToStudent()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'back button
        Me.Hide()
        Display_Classes.Show()
    End Sub

    Private Sub btnDeleteGrade_Click(sender As Object, e As EventArgs) Handles btnDeleteGrade.Click 'delete Grade
        Display_Classes.deleteGrade()
    End Sub
End Class