Imports CPMS.frmScreen


Public Class frmOfficerRegi
    Dim peo As New peopleClass()
    Dim user As New userClass()

    Dim peopleId As Integer
    Dim msgResult As String



    Private Sub btnRgBack_Click(sender As Object, e As EventArgs) Handles btnRgBack.Click
        Me.Hide()
        'frmOffiicerRegiDash.Show()
        frmScreen.loadPanel(frmOffiicerRegiDash)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub


    Private Sub frmOfficerRegi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbOfiType.Items.Add("MOH Officer")
        cmbOfiType.Items.Add("PHI Officer")

        lblError.Visible = True
        lblError.Text = "* NIC Required"

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'check seacr empty
        If (txtSearch.Text = "") Then

            lblError.Text = "* NIC Required"
            lblError.Visible = True
            btnSearch.Enabled = False

        ElseIf (txtSearch.Text <> "") Then
            lblError.Visible = False
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'get nic
        peo.getPeople(txtSearch.Text)

        'check nic valid
        If (peo.x = 0) Then
            MessageBox.Show("Not People exist,Check NIC and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearch.Focus()

        Else

            'pass value
            peopleId = peo.dataSet.Tables("people").Rows(0)(0)
            lblOfiName.Text = peo.dataSet.Tables("people").Rows(0)(1) & " " & peo.dataSet.Tables("people").Rows(0)(2)
            lblOfiDOB.Text = peo.dataSet.Tables("people").Rows(0)(3)
            lblOfiNIC.Text = peo.dataSet.Tables("people").Rows(0)(4)
            lblOfiGendr.Text = peo.dataSet.Tables("people").Rows(0)(5)
            lblOfiAddrss.Text = peo.dataSet.Tables("people").Rows(0)(6)
            lblOfiDistrict.Text = peo.dataSet.Tables("people").Rows(0)(8) & " / " & peo.dataSet.Tables("people").Rows(0)(7)
            lblOfiMOH.Text = peo.dataSet.Tables("people").Rows(0)(9)
            lblOfiGN.Text = peo.dataSet.Tables("people").Rows(0)(10)
            lblOfiEmail.Text = peo.dataSet.Tables("people").Rows(0)(11)
            lblOfiTele.Text = peo.dataSet.Tables("people").Rows(0)(12)

            user.getUser(peopleId)
            'check peo User
            If (user.peo_user = 1) Then
                txtOfiNIC.Text = "**********"
                txtOfiPswd.Text = "*********"
                txtOfiDesignation.Text = user.dataSet.Tables("user").Rows(0)(3)
                cmbOfiType.Text = user.dataSet.Tables("user").Rows(0)(4)

                btnDele.Visible = True

            Else
                txtOfiNIC.Text = ""
                txtOfiPswd.Text = ""
                txtOfiDesignation.Text = ""
                cmbOfiType.ResetText()

                MessageBox.Show("Have Not User account for", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

    End Sub

    Private Sub btnOfiRegi_Click(sender As Object, e As EventArgs) Handles btnOfiRegi.Click
        ''check empty fields
        If (txtOfiNIC.Text = String.Empty) Then
            lblNIC.Enabled = True

        ElseIf (txtOfiPswd.Text = String.Empty) Then
            lblPsd.Enabled = True

        ElseIf (txtOfiDesignation.Text = String.Empty) Then
            lblDesi.Enabled = True

        ElseIf (cmbOfiType.Text = String.Empty) Then
            lblOffT.Enabled = True


        Else
            lblNIC.Enabled = False
            lblPsd.Enabled = False
            lblDesi.Enabled = False
            lblOffT.Enabled = False

            'set values
            user.PeoId = peopleId
            user.NIC = txtOfiNIC.Text
            user.Password = txtOfiPswd.Text
            user.Designation = txtOfiDesignation.Text
            user.UType = cmbOfiType.Text


            msgResult = MessageBox.Show("Are Your Sure To Register User " & user.NIC, "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If (msgResult = 6) Then

                'pass add user
                user.addUser()
            Else

            End If

        End If

        'clear field
        txtOfiNIC.Text = ""
        txtOfiPswd.Text = ""
        txtOfiDesignation.Text = ""
        cmbOfiType.Text = ""


    End Sub

    Private Sub btnDele_Click(sender As Object, e As EventArgs) Handles btnDele.Click

        msgResult = MessageBox.Show("Are Your Sure To Delete User " & lblOfiNIC.Text, "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If (msgResult = 6) Then

            'pass dele user
            user.deleUser(peopleId)

            'clear field
            txtOfiNIC.Text = ""
            txtOfiPswd.Text = ""
            txtOfiDesignation.Text = ""
            cmbOfiType.Text = ""

        Else

        End If

    End Sub
End Class