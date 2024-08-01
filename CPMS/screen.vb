Imports CPMS.frmDashboard

Public Class frmScreen
    Dim peo As New peopleClass()
    Dim pati As New patientClass()

    Dim btnStatus As Boolean = False

    Public Sub loadPanel(panel As Form)
        pnlLoad.Controls.Clear()
        panel.TopLevel = False
        pnlLoad.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        btnStatus = True
        loadPanel(frmDashboard)

        'Total case
        pati.getTotalPati()
        frmDashboard.lblTotCase.Text = pati.allReader.Item("COUNT(pat_id)").ToString()


        'current ase
        pati.getCurrCase()
        frmDashboard.lblCrntCase.Text = pati.currReader.Item("COUNT(pat_id)").ToString()

        'recover case
        pati.getTotRecover()
        frmDashboard.lblTotRecovr.Text = pati.recoReader.Item("COUNT(pat_id)").ToString()

        'dead case
        pati.getTotDead()
        frmDashboard.lblTotDeth.Text = pati.deadReader.Item("COUNT(pat_id)").ToString()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        loadPanel(frmProfile)
    End Sub

    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        loadPanel(frmDatabase)
    End Sub

    Private Sub btnVaccine_Click(sender As Object, e As EventArgs) Handles btnVaccine.Click
        loadPanel(frmVaccine)

    End Sub

    Private Sub frmScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPanel(frmDashboard)

        'get current user
        peo.getPeople(frmLogin.loginUser)
        lblCurrUser.Text = peo.dataSet.Tables("people").Rows(0)(1) & " " & peo.dataSet.Tables("people").Rows(0)(2)

    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        loadPanel(frmOffiicerRegiDash)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        loadPanel(frmSetting)
    End Sub
End Class