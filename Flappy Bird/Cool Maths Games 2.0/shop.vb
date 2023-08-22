Public Class shop
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSkins.Click 'buttons to acces part of the shop
        skins.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPowerups.Click '^
        powerups.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'back button
        Home.Show()
        Me.Hide()
    End Sub
End Class