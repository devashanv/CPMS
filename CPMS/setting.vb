Public Class frmSetting
    Dim peo As New peopleClass()
    Dim user As New userClass()

    Dim peopleId As Integer
    Dim userNIC As String
    Dim msgResult As Integer


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current user
        peo.getPeople(frmLogin.loginUser)

        'setvalues
        peopleId = peo.dataSet.Tables("people").Rows(0)(0)
        lblName.Text = peo.dataSet.Tables("people").Rows(0)(1) & " " & peo.dataSet.Tables("people").Rows(0)(2)
        lblDesig.Text = frmLogin.loginDesig
        lblDOB.Text = peo.dataSet.Tables("people").Rows(0)(3)
        lblNic.Text = peo.dataSet.Tables("people").Rows(0)(4)
        lblGndr.Text = peo.dataSet.Tables("people").Rows(0)(5)
        lblAddress.Text = peo.dataSet.Tables("people").Rows(0)(6)
        lblCity.Text = peo.dataSet.Tables("people").Rows(0)(8) & " / " & peo.dataSet.Tables("people").Rows(0)(7)
        lblmoharea.Text = peo.dataSet.Tables("people").Rows(0)(9)
        lblGN.Text = peo.dataSet.Tables("people").Rows(0)(10)
        lblEmail.Text = peo.dataSet.Tables("people").Rows(0)(11)
        lblMobi.Text = peo.dataSet.Tables("people").Rows(0)(12)

        userNIC = peo.dataSet.Tables("people").Rows(0)(4)

    End Sub

    Private Sub btnSetSave_Click(sender As Object, e As EventArgs) Handles btnSetSave.Click

        Dim currPass As String = txtSetCurPsswd.Text
        Dim newPass As String = txtSetNwPsswd.Text
        Dim conPass As String = txtSetConPsswd.Text

        Dim userId As Integer
        Dim userPass As String


        msgResult = MessageBox.Show("Are Your Sure to Reset your password", "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (msgResult = 6) Then

            'get user
            user.getNICUser(userNIC)

            userId = user.dataSet.Tables("user").Rows(0)(0)
            userPass = user.dataSet.Tables("user").Rows(0)(2)

            'check password exists
            If (currPass = userPass) Then

                'check same password
                If (newPass = conPass) Then
                    'call reset
                    user.resetPassword(userId, newPass)

                Else
                    MessageBox.Show("Your New Password Not Match With Confimation,Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Else
                MessageBox.Show("Your Current Password is Incorrect,Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else

        End If

    End Sub

    Private Sub txtSetCurPsswd_TextChanged(sender As Object, e As EventArgs) Handles txtSetCurPsswd.TextChanged
        txtSetNwPsswd.Enabled = True
    End Sub

    Private Sub txtSetNwPsswd_TextChanged(sender As Object, e As EventArgs) Handles txtSetNwPsswd.TextChanged
        txtSetConPsswd.Enabled = True
    End Sub
End Class