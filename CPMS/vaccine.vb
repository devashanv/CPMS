Public Class frmVaccine
    Dim vacc As New VaccineClass()

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmVaccine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 1

        'add items for cmb box
        cmbField.Items.Add("NIC")
        cmbField.Items.Add("MOH Area")
        cmbField.Items.Add("Vaccine")
        cmbField.Items.Add("Dose")
        cmbField.Items.Add("Date")

        'get all vaccinations
        vacc.getAllVaccine()

        'check exists
        If (vacc.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                  i,
                    vacc.dataReader.Item("fname").ToString(),
                    vacc.dataReader.Item("nic").ToString(),
                    vacc.dataReader.Item("moh_divi").ToString() & " / " & vacc.dataReader.Item("gn_divi").ToString(),
                    vacc.dataReader.Item("vacc_name").ToString(),
                    vacc.dataReader.Item("dose").ToString(),
                    vacc.dataReader.Item("date").ToString().Substring(0, 10),
                    vacc.dataReader.Item("place").ToString()
                )

                i += 1

            Loop While vacc.dataReader.Read

        Else
            MessageBox.Show("Not Exists Vaccine Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtSrchValue_TextChanged(sender As Object, e As EventArgs) Handles txtSrchValue.TextChanged
        'check seacr empty
        If (txtSrchValue.Text = "") Then

            lblError.Text = "* Required"
            lblError.Visible = True
            lblError.Enabled = True
            btnVacFind.Enabled = False

        ElseIf (txtSrchValue.Text <> "") Then
            lblError.Visible = False
            btnVacFind.Enabled = True
        End If
    End Sub

    Private Sub cmbField_TextChanged(sender As Object, e As EventArgs) Handles cmbField.TextChanged
        'check seacr empty
        If (cmbField.Text = "") Then

            lblslErro.Text = "* Required"
            lblslErro.Visible = True
            lblslErro.Enabled = True
            btnVacFind.Enabled = False

        ElseIf (cmbField.Text <> "") Then
            lblslErro.Visible = False
            btnVacFind.Enabled = True
            txtSrchValue.Enabled = True
        End If

        'validate field value

        'check and set fields
        If (cmbField.Text = "NIC") Then
            lbldate.Text = "Last Letter Capital(V,X)"
            lbldate.Visible = True

        ElseIf (cmbField.Text = "MOH Area") Then
            lbldate.Text = "Enter Correctly MOH Area"
            lbldate.Visible = True

        ElseIf (cmbField.Text = "Vaccine") Then
            lbldate.Text = "Use First Letter Capital"
            lbldate.Visible = True

        ElseIf (cmbField.Text = "Dose") Then
            lbldate.Text = "Enter 1 2 Or 3"
            lbldate.Visible = True

        ElseIf (cmbField.Text = "Date") Then
            lbldate.Text = "Use Date Type(YYYY-MM-DD)"
            lbldate.Visible = True


        End If


    End Sub

    Private Sub btnVacFind_Click(sender As Object, e As EventArgs) Handles btnVacFind.Click
        Dim i As Integer = 1
        Dim userField As String = ""
        Dim userInput As String = txtSrchValue.Text

        'check and set fields
        If (cmbField.Text = "NIC") Then
            userField = "nic"

        ElseIf (cmbField.Text = "MOH Area") Then
            userField = "moh_divi"

        ElseIf (cmbField.Text = "Vaccine") Then
            userField = "vacc_name"

        ElseIf (cmbField.Text = "Dose") Then
            userField = "dose"

        ElseIf (cmbField.Text = "Date") Then
            userField = "date"


        End If

        'pass srch details
        vacc.getSrchVaccine(userField, userInput)

        'check exists
        If (vacc.dataReader.Read = True) Then

            DataGridView1.Rows.Clear()

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                    i,
                    vacc.dataReader.Item("fname").ToString(),
                    vacc.dataReader.Item("nic").ToString(),
                    vacc.dataReader.Item("moh_divi").ToString() & " / " & vacc.dataReader.Item("gn_divi").ToString(),
                    vacc.dataReader.Item("vacc_name").ToString(),
                    vacc.dataReader.Item("dose").ToString(),
                    vacc.dataReader.Item("date").ToString().Substring(0, 10),
                    vacc.dataReader.Item("place").ToString()
                )

                i += 1

            Loop While vacc.dataReader.Read

        Else
            MessageBox.Show("Not Exists Vaccine Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnReFresh_Click(sender As Object, e As EventArgs) Handles btnReFresh.Click
        Dim i As Integer = 1

        DataGridView1.Rows.Clear()


        'get all vaccinations
        vacc.getAllVaccine()

        'check exists
        If (vacc.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                  i,
                    vacc.dataReader.Item("fname").ToString(),
                    vacc.dataReader.Item("nic").ToString(),
                    vacc.dataReader.Item("moh_divi").ToString() & " / " & vacc.dataReader.Item("gn_divi").ToString(),
                    vacc.dataReader.Item("vacc_name").ToString(),
                    vacc.dataReader.Item("dose").ToString(),
                    vacc.dataReader.Item("date").ToString().Substring(0, 10),
                    vacc.dataReader.Item("place").ToString()
                )

                i += 1

            Loop While vacc.dataReader.Read

        Else
            MessageBox.Show("Not Exists Vaccine Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

   
   
  
End Class