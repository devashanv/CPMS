Public Class frmAccociate
    Dim peo As New peopleClass()
    Dim vacc As New VaccineClass()
    Dim assoc As New AssocClass()

    Dim msgResult As Integer
    Dim peopleId As Integer


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnAsCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'get nic
        peo.getPeople(txtSearch.Text)

        'check nic valid
        If (peo.x = 0) Then
            MessageBox.Show("Not People exist,Check NIC and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearch.Focus()

        Else

            'pass values
            peopleId = peo.dataSet.Tables("people").Rows(0)(0)
            lblAsName.Text = peo.dataSet.Tables("people").Rows(0)(1) & " " & peo.dataSet.Tables("people").Rows(0)(2)
            lblAsDOB.Text = peo.dataSet.Tables("people").Rows(0)(3)
            lblAsNIC.Text = peo.dataSet.Tables("people").Rows(0)(4)
            lblAsGender.Text = peo.dataSet.Tables("people").Rows(0)(5)
            lblAsAddress.Text = peo.dataSet.Tables("people").Rows(0)(6)
            lblAsDistrict.Text = peo.dataSet.Tables("people").Rows(0)(8) & " / " & peo.dataSet.Tables("people").Rows(0)(7)
            lblAsMOH.Text = peo.dataSet.Tables("people").Rows(0)(9)
            lblAsGN.Text = peo.dataSet.Tables("people").Rows(0)(10)
            lblAsEmail.Text = peo.dataSet.Tables("people").Rows(0)(11)
            lblAsTele.Text = peo.dataSet.Tables("people").Rows(0)(12)

            vacc.getVaccine(peopleId)
            'check peo vaccination
            If (vacc.peo_vacc = 3) Then
                '1st
                lblAsVacDate1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblAsVacDate2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '3rd
                lblAsVacDate3.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName3.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace3.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

            ElseIf (vacc.peo_vacc = 2) Then
                '1st
                lblAsVacDate1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblAsVacDate2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace2.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '3rd
                lblAsVacDate3.Text = "-"
                lblAsVacName3.Text = "-"
                lblAsVacPlace3.Text = "-"

            ElseIf (vacc.peo_vacc = 1) Then
                '1st
                lblAsVacDate1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(3)
                lblAsVacName1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(2)
                lblAsVacPlace1.Text = vacc.dataSet.Tables("vaccine").Rows(0)(4)

                '2nd
                lblAsVacDate2.Text = "-"
                lblAsVacName2.Text = "-"
                lblAsVacPlace2.Text = "-"

                '3rd
                lblAsVacDate3.Text = "-"
                lblAsVacName3.Text = "-"
                lblAsVacPlace3.Text = "-"


            Else
                'clear lbls
                '1st
                lblAsVacDate1.Text = "-"
                lblAsVacName1.Text = "-"
                lblAsVacPlace1.Text = "-"

                '2nd
                lblAsVacDate2.Text = "-"
                lblAsVacName2.Text = "-"
                lblAsVacPlace2.Text = "-"

                '3rd
                lblAsVacDate3.Text = "-"
                lblAsVacName3.Text = "-"
                lblAsVacPlace3.Text = "-"

                MessageBox.Show("Not Vaccination Details For " & peo.dataSet.Tables("people").Rows(0)(4), "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub frmAccociate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.Add("Recovered")
        cmbStatus.Items.Add("Corontine")
        cmbStatus.Items.Add("Dead")

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

    Private Sub dtpAsDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAsDate.ValueChanged
        dtpAsCoroSDate.Enabled = True

    End Sub

    Private Sub dtpAsCoroSDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAsCoroSDate.ValueChanged
        dtpAsCoroEDate.Enabled = True
    End Sub

    Private Sub dtpAsCoroEDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAsCoroEDate.ValueChanged
        txtAsCoroPlce.Enabled = True
    End Sub

    Private Sub txtAsCoroPlce_TextChanged(sender As Object, e As EventArgs) Handles txtAsCoroPlce.TextChanged
        txtAsPatNIC.Enabled = True
    End Sub

    Private Sub txtAsPatNIC_TextChanged(sender As Object, e As EventArgs) Handles txtAsPatNIC.TextChanged
        cmbStatus.Enabled = True
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        btnAsAdd.Enabled = True
    End Sub

    Private Sub btnAsAdd_Click(sender As Object, e As EventArgs) Handles btnAsAdd.Click
        ''check empty fields
        If (dtpAsDate.Text = String.Empty) Then
            lblad.Enabled = True

        ElseIf (dtpAsCoroSDate.Text = String.Empty) Then
            lblcs.Enabled = True

        ElseIf (dtpAsCoroEDate.Text = String.Empty) Then
            lblce.Enabled = True

        ElseIf (txtAsCoroPlce.Text = String.Empty) Then
            lblcp.Enabled = True

        ElseIf (txtAsPatNIC.Text = String.Empty) Then
            lblan.Enabled = True

        ElseIf (cmbStatus.Text = String.Empty) Then
            lblrs.Enabled = True


        Else
            lblad.Enabled = False
            lblcs.Enabled = False
            lblce.Enabled = False
            lblcp.Enabled = False
            lblan.Enabled = False
            lblrs.Enabled = False

            'set values
            assoc.PeopleId = peopleId
            assoc.AssociateDate = dtpAsDate.Text
            assoc.CoSDate = dtpAsCoroSDate.Text
            assoc.CoEDate = dtpAsCoroEDate.Text
            assoc.CoPlace = txtAsCoroPlce.Text
            assoc.PatientNIC = txtAsPatNIC.Text
            assoc.Status = cmbStatus.Text


            msgResult = MessageBox.Show("Are Your Sure To Add Associate " & lblAsName.Text, "CPMS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If (msgResult = 6) Then

                'pass add associate
                assoc.addAssoc()
            Else

            End If

        End If

    End Sub
End Class