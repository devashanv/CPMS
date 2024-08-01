Imports CPMS.frmScreen
Public Class frmOffiicerRegiDash

    Private Sub btnOffiRegi_Click(sender As Object, e As EventArgs) Handles btnOffiRegi.Click
        Me.Hide()
        'frmOfficerRegi.Show()
        frmScreen.loadPanel(frmOfficerRegi)


    End Sub

    Private Sub btnPeoRegi_Click(sender As Object, e As EventArgs) Handles btnPeoRegi.Click
        Me.Hide()
        'frmRegiDash.Show()
        frmScreen.loadPanel(frmRegiDash)



    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class