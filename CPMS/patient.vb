Public Class frmPatient
    Dim peo As New peopleClass()
    Dim vacc As New VaccineClass()
    Dim pati As New patientClass()


    Dim peopleId As Integer
    Dim msgResult As Integer



    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

   

    Private Sub frmPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPtiRecStus.Items.Add("Recovered")
        cmbPtiRecStus.Items.Add("Corontine")
        cmbPtiRecStus.Items.Add("Dead")
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

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        'get nic
        peo.getPeople(txtSearch.Text)

        'check nic valid
        If (peo.x = 0) Then
            MessageBox.Show("Not People exist,Check NIC and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearch.Focus()

        Else

            'pass values
            peopleId = peo.dataSet.Tables("people").Rows(0)(0)
            lblPtiName.Text = peo.dataSet.Tables("people").Rows(0)(1) & " " & peo.dataSet.Tables("people").Rows(0)(2)
            lblPtiDOB.Text = peo.dataSet.Tables("people").Rows(0)(3)
            lblPtiNIC.Text = peo.dataSet.Tables("people").Rows(0)(4)
            lblPtiGendr.Text = peo.dataSet.Tables("people").Rows(0)(5)
            lblPtiAddrss.Text = peo.dataSet.Tables("people").Rows(0)(6)
            lblPtiDistrict.Text = peo.dataSet.Tables("people").Rows(0)(8) & " / " & peo.dataSet.Tables("people").Rows(0)(7)
            lblPtiMOH.Text = peo.dataSet.Tables("people").Rows(0)(9)
            lblPtiGN.Text = peo.dataSet.Tables("people").Rows(0)(10)
            lblPtiEmail.Text = peo.dataSet.Tables("people").Rows(0)(11)
            lblPtiTele.Text = peo.dataSet.Tables("people").Rows(0)(12)

            vacc.getVaccine(peopleId)
            'check peo vaccination
            If (vacc.peo_vacc = 3) Then
                '1st
                lblPtiVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblPtiVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblPtiVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblPtiVacDte2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(3)
                lblPtiVacNme2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(2)
                lblPtiVacPlce2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(4)

                '3rd
                lblPtiVacDte3.Text = vacc.dataSet.Tables("vaccine").Rows(1)(3)
                lblPtiVacNme3.Text = vacc.dataSet.Tables("vaccine").Rows(1)(2)
                lblPtiVacPlce3.Text = vacc.dataSet.Tables("vaccine").Rows(1)(4)

            ElseIf (vacc.peo_vacc = 2) Then
                '1st
                lblPtiVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblPtiVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblPtiVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblPtiVacDte2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(3)
                lblPtiVacNme2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(2)
                lblPtiVacPlce2.Text = vacc.dataSet.Tables("vaccine").Rows(1)(4)

                '3rd
                lblPtiVacDte3.Text = "-"
                lblPtiVacNme3.Text = "-"
                lblPtiVacPlce3.Text = "-"

            ElseIf (vacc.peo_vacc = 1) Then
                '1st
                lblPtiVacDte1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblPtiVacNme1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblPtiVacPlce1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblPtiVacDte2.Text = "-"
                lblPtiVacNme2.Text = "-"
                lblPtiVacPlce2.Text = "-"

                '3rd
                lblPtiVacDte3.Text = "-"
                lblPtiVacNme3.Text = "-"
                lblPtiVacPlce3.Text = "-"


            Else
                'clear lbls
                '1st
                lblPtiVacDte1.Text = "-"
                lblPtiVacNme1.Text = "-"
                lblPtiVacPlce1.Text = "-"

                '2nd
                lblPtiVacDte2.Text = "-"
                lblPtiVacNme2.Text = "-"
                lblPtiVacPlce2.Text = "-"

                '3rd
                lblPtiVacDte3.Text = "-"
                lblPtiVacNme3.Text = "-"
                lblPtiVacPlce3.Text = "-"

                MessageBox.Show("Not Vaccination Details For " & peo.dataSet.Tables("people").Rows(0)(4), "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ''check empty fields
        If (dtpPtiDate.Text = String.Empty) Then
            lblin.Enabled = True

        ElseIf (dtpCoroSDte.Text = String.Empty) Then
            lblsd.Enabled = True

        ElseIf (dtpCoroEDate.Text = String.Empty) Then
            lbled.Enabled = True

        ElseIf (txtPtiCoroPlce.Text = String.Empty) Then
            lblcs.Enabled = True

        ElseIf (cmbPtiRecStus.Text = String.Empty) Then
            lblrs.Enabled = True


        Else
            lblin.Enabled = False
            lblsd.Enabled = False
            lbled.Enabled = False
            lblcs.Enabled = False
            lblrs.Enabled = False

            'set values
            pati.PeopleId = peopleId
            pati.InfDate = dtpPtiDate.Text
            pati.CoSDate = dtpCoroSDte.Text
            pati.CoEDate = dtpCoroSDte.Text
            pati.CoPlace = txtPtiCoroPlce.Text
            pati.Status = cmbPtiRecStus.Text


            msgResult = MessageBox.Show("Are Your Sure To Add Patient " & lblPtiName.Text, "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If (msgResult = 6) Then

                'pass add patient
                pati.addPatient()
            Else

            End If

        End If

    End Sub

    Private Sub dtpPtiDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPtiDate.ValueChanged
        dtpCoroSDte.Enabled = True
    End Sub

    Private Sub dtpCoroSDte_ValueChanged(sender As Object, e As EventArgs) Handles dtpCoroSDte.ValueChanged
        dtpCoroEDate.Enabled = True

    End Sub

    Private Sub dtpCoroEDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpCoroEDate.ValueChanged
        txtPtiCoroPlce.Enabled = True
    End Sub

    Private Sub txtPtiCoroPlce_TextChanged(sender As Object, e As EventArgs) Handles txtPtiCoroPlce.TextChanged
        cmbPtiRecStus.Enabled = True
    End Sub

    Private Sub cmbPtiRecStus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPtiRecStus.SelectedIndexChanged
        btnAdd.Enabled = True
    End Sub

End Class