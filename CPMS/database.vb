Public Class frmDatabase
    Dim pati As New patientClass()
    Dim assoc As New AssocClass()


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmScreen.Hide()
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        frmPatient.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddAsso.Click
        frmAccociate.Show()

    End Sub


    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        Dim a As Integer = 1

        'add items for cmb box
        cmbPatField.Items.Add("NIC")
        cmbPatField.Items.Add("GN Area")
        cmbPatField.Items.Add("Date")

        cmbAsField.Items.Add("NIC")
        cmbAsField.Items.Add("GN Area")
        cmbAsField.Items.Add("Date")
   

        'get all patient
        pati.getAllPatient()


        'check exists
        If (pati.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                   i,
                    pati.dataReader.Item("infact_date").ToString().Substring(0, 10),
                    pati.dataReader.Item("fname").ToString(),
                    pati.dataReader.Item("nic").ToString(),
                    pati.dataReader.Item("dob").ToString().Substring(0, 10),
                    pati.dataReader.Item("gender").ToString(),
                    pati.dataReader.Item("telephone").ToString(),
                    pati.dataReader.Item("district").ToString(),
                    pati.dataReader.Item("gn_divi").ToString(),
                    pati.dataReader.Item("status").ToString())



                i += 1

            Loop While pati.dataReader.Read

        Else
            MessageBox.Show("Not Exists Patient Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------

        'get all associate
        assoc.getAllAssoc()


        'check exists
        If (assoc.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridViewAssoc.Rows.Add(
                  a,
                    assoc.dataReader.Item("assoc_date").ToString().Substring(0, 10),
                    assoc.dataReader.Item("fname").ToString(),
                    assoc.dataReader.Item("nic").ToString(),
                    assoc.dataReader.Item("dob").ToString().Substring(0, 10),
                    assoc.dataReader.Item("gender").ToString(),
                    assoc.dataReader.Item("telephone").ToString(),
                    assoc.dataReader.Item("district").ToString(),
                    assoc.dataReader.Item("gn_divi").ToString(),
                    assoc.dataReader.Item("status").ToString(),
                    assoc.dataReader.Item("coro_place").ToString())

                a += 1

            Loop While assoc.dataReader.Read

        Else
            MessageBox.Show("Not Exists Associate Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim i As Integer = 1

        'clear fields
        txtPatSearch.Clear()
        cmbPatField.ResetText()
        DataGridView1.Rows.Clear()

        'get all patient
        pati.getAllPatient()


        'check exists
        If (pati.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                  i,
                    pati.dataReader.Item("infact_date").ToString().Substring(0, 10),
                    pati.dataReader.Item("fname").ToString(),
                    pati.dataReader.Item("nic").ToString(),
                    pati.dataReader.Item("dob").ToString().Substring(0, 10),
                    pati.dataReader.Item("gender").ToString(),
                    pati.dataReader.Item("telephone").ToString(),
                    pati.dataReader.Item("district").ToString(),
                    pati.dataReader.Item("gn_divi").ToString(),
                    pati.dataReader.Item("status").ToString())

                i += 1

            Loop While pati.dataReader.Read

        Else
            MessageBox.Show("Not Exists Patient Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnAssoc_Click(sender As Object, e As EventArgs) Handles btnAssoc.Click
        Dim a As Integer = 1

        'clear fields
        txtSearchAs.Clear()
        cmbAsField.ResetText()
        DataGridViewAssoc.Rows.Clear()

        'get all associate
        assoc.getAllAssoc()


        'check exists
        If (assoc.dataReader.Read = True) Then

            Do
                'pass value to colunms
                DataGridViewAssoc.Rows.Add(
                  a,
                    assoc.dataReader.Item("assoc_date").ToString().Substring(0, 10),
                    assoc.dataReader.Item("fname").ToString(),
                    assoc.dataReader.Item("nic").ToString(),
                    assoc.dataReader.Item("dob").ToString().Substring(0, 10),
                    assoc.dataReader.Item("gender").ToString(),
                    assoc.dataReader.Item("telephone").ToString(),
                    assoc.dataReader.Item("district").ToString(),
                    assoc.dataReader.Item("gn_divi").ToString(),
                    assoc.dataReader.Item("status").ToString(),
                    assoc.dataReader.Item("coro_place").ToString())

                a += 1

            Loop While assoc.dataReader.Read

        Else
            MessageBox.Show("Not Exists Associate Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub cmbPatField_TextChanged(sender As Object, e As EventArgs) Handles cmbPatField.TextChanged
        'check seacr empty
        If (cmbPatField.Text = "") Then
            txtPatSearch.Enabled = False
            lblPatError.Enabled = True

        Else
            txtPatSearch.Enabled = True
            lblPatError.Enabled = False

        End If

        'validate field value
        'check and set fields
        If (cmbPatField.Text = "NIC") Then
            lblHint.Text = "Last Letter Capital(V,X)"
            lblHint.Visible = True

        ElseIf (cmbPatField.Text = "GN Area") Then
            lblHint.Text = "Enter Correctly GN Area"
            lblHint.Visible = True

        ElseIf (cmbPatField.Text = "Date") Then
            lblHint.Text = "Use Date Type(YYYY-MM-DD)"
            lblHint.Visible = True


        End If
    End Sub

    Private Sub txtPatSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPatSearch.TextChanged
        If (txtPatSearch.Text = "") Then
            btnPatSearch.Enabled = False
            lblSrchErro.Enabled = True
        Else
            btnPatSearch.Enabled = True
            lblSrchErro.Enabled = False
        End If

    End Sub

    Private Sub btnPatSearch_Click(sender As Object, e As EventArgs) Handles btnPatSearch.Click
        Dim i As Integer = 1
        Dim userField As String = ""
        Dim userInput As String = txtPatSearch.Text

        'check and set fields
        If (cmbPatField.Text = "NIC") Then
            userField = "nic"

        ElseIf (cmbPatField.Text = "GN Area") Then
            userField = "gn_divi"

        ElseIf (cmbPatField.Text = "Date") Then
            userField = "date"

        End If

        'pass srch details
        pati.getPatPeople(userField, userInput)

        'check exists
        If (pati.dataReader.Read = True) Then

            DataGridView1.Rows.Clear()

            Do
                'pass value to colunms
                DataGridView1.Rows.Add(
                    i,
                    pati.dataReader.Item("infact_date").ToString().Substring(0, 10),
                    pati.dataReader.Item("fname").ToString(),
                    pati.dataReader.Item("nic").ToString(),
                    pati.dataReader.Item("dob").ToString().Substring(0, 10),
                    pati.dataReader.Item("gender").ToString(),
                    pati.dataReader.Item("telephone").ToString(),
                    pati.dataReader.Item("district").ToString(),
                    pati.dataReader.Item("gn_divi").ToString(),
                    pati.dataReader.Item("status").ToString())

                i += 1

            Loop While pati.dataReader.Read



        Else
            MessageBox.Show("Not Exists Patient Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    

    Private Sub txtSearchAs_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAs.TextChanged
        If (txtSearchAs.Text = "") Then
            lblSearchAs.Enabled = True
            btnAsSearch.Enabled = False

        Else
            lblSearchAs.Enabled = False
            btnAsSearch.Enabled = True
        End If
    End Sub

    Private Sub cmbAsField_TextChanged(sender As Object, e As EventArgs) Handles cmbAsField.TextChanged
        'check seacr empty
        If (cmbAsField.Text = "") Then
            lblErrorAs.Enabled = True
            txtSearchAs.Enabled = False

        Else
            lblErrorAs.Enabled = False
            txtSearchAs.Enabled = True

        End If

        'validate field value
        'check and set fields
        If (cmbAsField.Text = "NIC") Then
            lblHintAs.Text = "Last Letter Capital(V,X)"
            lblHintAs.Visible = True

        ElseIf (cmbAsField.Text = "GN Area") Then
            lblHintAs.Text = "Enter Correctly GN Area"
            lblHintAs.Visible = True

        ElseIf (cmbAsField.Text = "Date") Then
            lblHintAs.Text = "Use Date Type(YYYY-MM-DD)"
            lblHintAs.Visible = True


        End If
    End Sub

    Private Sub btnAsSearch_Click(sender As Object, e As EventArgs) Handles btnAsSearch.Click
        Dim i As Integer = 1
        Dim userField As String = ""
        Dim userInput As String = txtSearchAs.Text

        'check and set fields
        If (cmbAsField.Text = "NIC") Then
            userField = "nic"

        ElseIf (cmbAsField.Text = "GN Area") Then
            userField = "gn_divi"

        ElseIf (cmbAsField.Text = "Date") Then
            userField = "date"

        End If

        'pass srch details
        assoc.getAssocPeople(userField, userInput)

        'check exists
        If (assoc.dataReader.Read = True) Then

            DataGridViewAssoc.Rows.Clear()

            Do
                'pass value to colunms
                DataGridViewAssoc.Rows.Add(
                    i,
                    assoc.dataReader.Item("assoc_date").ToString().Substring(0, 10),
                    assoc.dataReader.Item("fname").ToString(),
                    assoc.dataReader.Item("nic").ToString(),
                    assoc.dataReader.Item("dob").ToString().Substring(0, 10),
                    assoc.dataReader.Item("gender").ToString(),
                    assoc.dataReader.Item("telephone").ToString(),
                    assoc.dataReader.Item("district").ToString(),
                    assoc.dataReader.Item("gn_divi").ToString(),
                    assoc.dataReader.Item("status").ToString(),
                    assoc.dataReader.Item("coro_place").ToString()
                )

                i += 1

            Loop While assoc.dataReader.Read



        Else
            MessageBox.Show("Not Exists Associate Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class