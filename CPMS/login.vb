Public Class frmLogin
    Dim user As New userClass()
    Dim peo As New peopleClass()
    Public loginUser As String
    Public loginDesig As String


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userName As String = txtUserName.Text
        Dim Passsword As String = txtPassword.Text


        'pass value to user
        user.getNICUser(userName)

        'check user exists
        If (user.peo_user = 0) Then
            MessageBox.Show("Not Found User Account,Check NIC and Password and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            'check username & password
            If (userName = user.dataSet.Tables("user").Rows(0)(1)) Then

                If (Passsword = user.dataSet.Tables("user").Rows(0)(2)) Then
                    'store user id
                    loginUser = userName
                    loginDesig = user.dataSet.Tables("user").Rows(0)(3)

                    Me.Hide()
                    frmScreen.Show()

                Else
                    MessageBox.Show("Password Incorrect,Check Password And Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Focus()


                End If

            Else

            End If

        End If

    End Sub

    Private Sub btnRegisterL_Click(sender As Object, e As EventArgs) Handles btnQuRgistr.Click
        Me.Hide()
        frmRegister.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If (txtUserName.Text = "") Then
            lblUName.Enabled = True
            txtPassword.Enabled = False

        ElseIf (txtUserName.Text <> "") Then
            lblUName.Enabled = False
            txtPassword.Enabled = True

        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If (txtPassword.Text = "") Then
            lblPsswd.Enabled = True
            btnLogin.Enabled = False

        ElseIf (txtPassword.Text <> "") Then
            lblPsswd.Enabled = False
            btnLogin.Enabled = True

        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (txtUserName.Text <> "") Then
            txtUserName.Clear()
            txtPassword.Clear()
        Else
        End If

    End Sub
End Class
