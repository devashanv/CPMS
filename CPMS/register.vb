Public Class frmRegister
    Dim msgResult As Integer

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add items for gender
        cmRgGndr.Items.Add("Male")
        cmRgGndr.Items.Add("Female")


    End Sub


    Private Sub lblLog_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnRgBack.Click
        Me.Hide()
        frmLogin.Show()

        'clear field
        txtRgFName.Text = ""
        txtRgLName.Text = ""
        txtDOB.Text = ""
        txtRgNIC.Text = ""
        txtRgEmail.Text = ""
        txtRgTele.Text = ""
        txtRgAddrss.Text = ""
        txtCity.Text = ""
        txtRgGN.Text = ""
        txtRgMOH.Text = ""
        cmRgGndr.ResetText()

        'disable lbls
        btnRgRegi.Enabled = False
        lblF.Enabled = False
        lblL.Enabled = False
        lblD.Enabled = False
        lblN.Enabled = False
        lblG.Enabled = False
        lblAd.Enabled = False
        lblC.Enabled = False
        lblMH.Enabled = False
        lblGN.Enabled = False
        lblT.Enabled = False
        lblE.Enabled = False

    End Sub

    Private Sub btnRgRegi_Click(sender As Object, e As EventArgs) Handles btnRgRegi.Click
        Dim peo As New peopleClass()

        ''check empty fields
        If (txtRgFName.Text = String.Empty) Then
            lblF.Enabled = True

        ElseIf (txtRgLName.Text = String.Empty) Then
            lblL.Enabled = True

        ElseIf (txtDOB.Text = String.Empty) Then
            lblD.Enabled = True

        ElseIf (txtRgNIC.Text = String.Empty) Then
            lblN.Enabled = True

        ElseIf (cmRgGndr.Text = String.Empty) Then
            lblG.Enabled = True

        ElseIf (txtRgAddrss.Text = String.Empty) Then
            lblAd.Enabled = True

        ElseIf (txtCity.Text = String.Empty) Then
            lblC.Enabled = True

        ElseIf (txtRgMOH.Text = String.Empty) Then
            lblMH.Enabled = True

        ElseIf (txtRgGN.Text = String.Empty) Then
            lblGN.Enabled = True

        ElseIf (txtRgTele.Text = String.Empty) Then
            lblT.Enabled = True

        ElseIf (txtRgEmail.Text = String.Empty) Then
            lblE.Enabled = True

        Else
            lblF.Enabled = False
            lblL.Enabled = False
            lblD.Enabled = False
            lblN.Enabled = False
            lblG.Enabled = False
            lblAd.Enabled = False
            lblC.Enabled = False
            lblMH.Enabled = False
            lblGN.Enabled = False
            lblT.Enabled = False
            lblE.Enabled = False

            'set values
            peo.FirstName = txtRgFName.Text
            peo.LastName = txtRgLName.Text
            peo.DOB = txtDOB.Text
            peo.NIC = txtRgNIC.Text
            peo.Gender = cmRgGndr.Text
            peo.Address = txtRgAddrss.Text
            peo.District = txtDistrict.Text
            peo.City = txtCity.Text
            peo.MOHDivi = txtRgMOH.Text
            peo.GNDivi = txtRgGN.Text
            peo.Telephone = txtRgTele.Text
            peo.Email = txtRgEmail.Text


            msgResult = MessageBox.Show("Are Your Sure To Register", "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If (msgResult = 6) Then

                'pass add people
                peo.addStudent()
            Else

            End If

            'clear field
            txtRgFName.Text = ""
            txtRgLName.Text = ""
            txtDOB.Text = ""
            txtRgNIC.Text = ""
            txtRgEmail.Text = ""
            txtRgTele.Text = ""
            txtRgAddrss.Text = ""
            txtCity.Text = ""
            txtRgGN.Text = ""
            txtRgMOH.Text = ""
            cmRgGndr.ResetText()
            btnRgRegi.Enabled = False
            

        End If

       
    End Sub

    Private Sub txtRgFName_TextChanged(sender As Object, e As EventArgs) Handles txtRgFName.TextChanged
        txtRgLName.Enabled = True
    End Sub

    Private Sub txtRgLName_TextChanged(sender As Object, e As EventArgs) Handles txtRgLName.TextChanged
        txtDOB.Enabled = True
    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged
        txtRgNIC.Enabled = True
    End Sub

    Private Sub txtRgNIC_TextChanged(sender As Object, e As EventArgs) Handles txtRgNIC.TextChanged
        txtRgEmail.Enabled = True
    End Sub

    Private Sub txtRgTele_TextChanged(sender As Object, e As EventArgs) Handles txtRgTele.TextChanged
        cmRgGndr.Enabled = True
    End Sub

    Private Sub txtRgEmail_TextChanged(sender As Object, e As EventArgs) Handles txtRgEmail.TextChanged
        txtRgTele.Enabled = True
    End Sub

    Private Sub cmRgGndr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmRgGndr.SelectedIndexChanged
        txtRgAddrss.Enabled = True
    End Sub

    Private Sub txtRgAddrss_TextChanged(sender As Object, e As EventArgs) Handles txtRgAddrss.TextChanged
        txtCity.Enabled = True
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        txtRgGN.Enabled = True
    End Sub

    Private Sub txtRgMOH_TextChanged(sender As Object, e As EventArgs) Handles txtRgMOH.TextChanged
        btnRgRegi.Enabled = True
    End Sub

    Private Sub txtRgGN_TextChanged(sender As Object, e As EventArgs) Handles txtRgGN.TextChanged
        txtRgMOH.Enabled = True
    End Sub
End Class