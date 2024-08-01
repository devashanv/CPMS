Public Class frmProfile
    Dim peo As New peopleClass()
    Dim vacc As New VaccineClass()

    Dim peopleId As Integer
    Dim msgResult As Integer

    Private Sub clrFields()
        'cler text
        txtProFNme.Text = ""
        txtProDOB.Text = ""
        txtProNIC.Text = ""
        txtProGndr.Text = ""
        txtProAddrss.Text = ""
        txtProDisct.Text = ""
        txtProMOH.Text = ""
        txtProGN.Text = ""
        txtEmail.Text = ""
        txtProTele.Text = ""

        dtpProVacDte1.Refresh()
        dtpProVacDte2.Refresh()
        dtpProVacDte3.Refresh()

        cmbProVacNme1.ResetText()
        cmbProVacNme2.ResetText()
        cmbProVacNme3.ResetText()

        txtProVacPlce1.Text = ""
        txtProVacPlce2.Text = ""
        txtProVacPlce3.Text = ""

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add items for vaccine
        cmbProVacNme1.Items.Add("Sinopharm")
        cmbProVacNme1.Items.Add("Moderna")
        cmbProVacNme1.Items.Add("Sputnik V")
        cmbProVacNme1.Items.Add("Astra Cenica")
        cmbProVacNme1.Items.Add("Fizer")

        cmbProVacNme2.Items.Add("Sinopharm")
        cmbProVacNme2.Items.Add("Moderna")
        cmbProVacNme2.Items.Add("Sputnik V")
        cmbProVacNme2.Items.Add("Astra Cenica")
        cmbProVacNme2.Items.Add("Fizer")

        cmbProVacNme3.Items.Add("Sinopharm")
        cmbProVacNme3.Items.Add("Moderna")
        cmbProVacNme3.Items.Add("Sputnik V")
        cmbProVacNme3.Items.Add("Astra Cenica")
        cmbProVacNme3.Items.Add("Fizer")

        'Nic validate
        lblError.Text = "* NIC Required"
        lblError.Visible = True


    End Sub

    Private Sub txtProNme_TextChanged(sender As Object, e As EventArgs) Handles txtProTele.TextChanged, txtProFNme.TextChanged, txtProNIC.TextChanged, txtProMOH.TextChanged, txtProGndr.TextChanged, txtProGN.TextChanged, txtProDOB.TextChanged, txtProDisct.TextChanged, txtProAddrss.TextChanged, txtEmail.TextChanged, txtProLNme.TextChanged, txtProCity.TextChanged
        btnUpdate.Enabled = True
        btnUpdate.Visible = True

        btnDelete.Enabled = True
        btnDelete.Visible = True

    End Sub

    Private Sub btnProSearch_Click(sender As Object, e As EventArgs) Handles btnProSearch.Click

        peo.getPeople(txtSearchNic.Text)
        'check nic valid
        If (peo.x = 0) Then
            MessageBox.Show("Not People exist,Check NIC and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearchNic.Focus()

        Else
            clrFields()

            'pass value
            peopleId = peo.dataSet.Tables("people").Rows(0)(0)
            txtProFNme.Text = peo.dataSet.Tables("people").Rows(0)(1)
            txtProLNme.Text = peo.dataSet.Tables("people").Rows(0)(2)
            txtProDOB.Text = peo.dataSet.Tables("people").Rows(0)(3)
            txtProNIC.Text = peo.dataSet.Tables("people").Rows(0)(4)
            txtProGndr.Text = peo.dataSet.Tables("people").Rows(0)(5)
            txtProAddrss.Text = peo.dataSet.Tables("people").Rows(0)(6)
            txtProDisct.Text = peo.dataSet.Tables("people").Rows(0)(8)
            txtProCity.Text = peo.dataSet.Tables("people").Rows(0)(7)
            txtProMOH.Text = peo.dataSet.Tables("people").Rows(0)(9)
            txtProGN.Text = peo.dataSet.Tables("people").Rows(0)(10)
            txtEmail.Text = peo.dataSet.Tables("people").Rows(0)(11)
            txtProTele.Text = peo.dataSet.Tables("people").Rows(0)(12)


            vacc.getVaccine(peopleId)
            'check peo vaccination
            If (vacc.peo_vacc = 3) Then
                '1st
                dtpProVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                cmbProVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                txtProVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                dtpProVacDte2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(3)
                cmbProVacNme2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(2)
                txtProVacPlce2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(4)

                '3rd
                dtpProVacDte3.Text = vacc.dataSet.Tables("vaccine").Rows(2)(3)
                cmbProVacNme3.Text = vacc.dataSet.Tables("vaccine").Rows(2)(2)
                txtProVacPlce3.Text = vacc.dataSet.Tables("vaccine").Rows(2)(4)

            ElseIf (vacc.peo_vacc = 2) Then
                '1st
                dtpProVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                cmbProVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                txtProVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                dtpProVacDte2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(3)
                cmbProVacNme2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(2)
                txtProVacPlce2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(4)

            ElseIf (vacc.peo_vacc = 1) Then
                '1st
                dtpProVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                cmbProVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                txtProVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)


            Else
                MessageBox.Show("Please Add Vaccination Details For " & peo.dataSet.Tables("people").Rows(0)(1), "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        msgResult = MessageBox.Show("Are Your Sure Delete " & txtProFNme.Text & " Details", "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (msgResult = 6) Then

            peo.delePeople(peopleId)
            vacc.deleVaccine(peopleId)

            clrFields()
            txtSearchNic.Text = ""
            txtSearchNic.Focus()

        Else

        End If
    End Sub

    Private Sub btnProSave_Click(sender As Object, e As EventArgs) Handles btnProSave.Click
        Dim vacc As New VaccineClass()

        msgResult = MessageBox.Show("Are Your Sure To Add Vaccination", "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (msgResult = 6) Then
            'check vaccine times and add
            If (cmbProVacNme2.Text = "" And txtProVacPlce2.Text = "" And cmbProVacNme3.Text = "" And txtProVacPlce3.Text = "") Then

                vacc.Dose = 1
                vacc.VaccDate = dtpProVacDte1.Text
                vacc.VaccName = cmbProVacNme1.Text
                vacc.VaccPlace = txtProVacPlce1.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()

                MessageBox.Show("Successfully Vaccination Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf (cmbProVacNme3.Text = "" And txtProVacPlce3.Text = "") Then

                vacc.Dose = 1
                vacc.VaccDate = dtpProVacDte1.Text
                vacc.VaccName = cmbProVacNme1.Text
                vacc.VaccPlace = txtProVacPlce1.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()


                vacc.Dose = 2
                vacc.VaccDate = dtpProVacDte2.Text
                vacc.VaccName = cmbProVacNme2.Text
                vacc.VaccPlace = txtProVacPlce2.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()

                MessageBox.Show("Successfully Vaccination Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                vacc.Dose = 1
                vacc.VaccDate = dtpProVacDte1.Text
                vacc.VaccName = cmbProVacNme1.Text
                vacc.VaccPlace = txtProVacPlce1.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()


                vacc.Dose = 2
                vacc.VaccDate = dtpProVacDte2.Text
                vacc.VaccName = cmbProVacNme2.Text
                vacc.VaccPlace = txtProVacPlce2.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()


                vacc.Dose = 3
                vacc.VaccDate = dtpProVacDte3.Text
                vacc.VaccName = cmbProVacNme3.Text
                vacc.VaccPlace = txtProVacPlce3.Text
                vacc.PeoId = peopleId
                vacc.addVaccine()

                MessageBox.Show("Successfully Vaccination Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

        Else

        End If

    End Sub

    Private Sub cmbProVacNme1_TextChanged(sender As Object, e As EventArgs) Handles cmbProVacNme1.TextChanged
        txtProVacPlce1.Enabled = True
    End Sub

    Private Sub txtProVacPlce1_TextChanged(sender As Object, e As EventArgs) Handles txtProVacPlce1.TextChanged
        cmbProVacNme2.Enabled = True

        'btn update
        btnProSave.Enabled = True
    End Sub

    Private Sub cmbProVacNme2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProVacNme2.SelectedIndexChanged
        txtProVacPlce2.Enabled = True
    End Sub

    Private Sub txtProVacPlce2_TextChanged(sender As Object, e As EventArgs) Handles txtProVacPlce2.TextChanged
        cmbProVacNme3.Enabled = True
    End Sub

    Private Sub cmbProVacNme3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProVacNme3.SelectedIndexChanged
        txtProVacPlce3.Enabled = True
    End Sub


    Private Sub txtSearchNic_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNic.TextChanged
        'check seacr empty
        If (txtSearchNic.Text = "") Then

            lblError.Text = "* NIC Required"
            lblError.Visible = True
            btnProSearch.Enabled = False

        ElseIf (txtSearchNic.Text <> "") Then
            lblError.Visible = False
            btnProSearch.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'set values
        peo.FirstName = txtProFNme.Text
        peo.LastName = txtProLNme.Text
        peo.DOB = txtProDOB.Text
        peo.NIC = txtProNIC.Text
        peo.Gender = txtProGndr.Text
        peo.Address = txtProAddrss.Text
        peo.District = txtProDisct.Text
        peo.City = txtProCity.Text
        peo.MOHDivi = txtProMOH.Text
        peo.GNDivi = txtProGN.Text
        peo.Telephone = txtProTele.Text
        peo.Email = txtEmail.Text

        msgResult = MessageBox.Show("Are Your Sure Update " & txtProFNme.Text & " Details", "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If (msgResult = 6) Then

            'call update
            peo.updatePeople(peopleId)
        Else

        End If
    End Sub
End Class