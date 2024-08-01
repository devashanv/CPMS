Public Class frmDashboard
    Dim pati As New patientClass()

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Total case
        pati.getTotalPati()
        lblTotCase.Text = pati.allReader.Item("COUNT(pat_id)").ToString()


        'current ase
        pati.getCurrCase()
        lblCrntCase.Text = pati.currReader.Item("COUNT(pat_id)").ToString()

        'recover case
        pati.getTotRecover()
        lblTotRecovr.Text = pati.recoReader.Item("COUNT(pat_id)").ToString()

        'dead case
        pati.getTotDead()
        lblTotDeth.Text = pati.deadReader.Item("COUNT(pat_id)").ToString()

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub

End Class