<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpPtiDate = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.dtpCoroSDte = New System.Windows.Forms.DateTimePicker()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtpCoroEDate = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtPtiCoroPlce = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbPtiRecStus = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPtiGN = New System.Windows.Forms.Label()
        Me.lblPtiMOH = New System.Windows.Forms.Label()
        Me.lblPtiEmail = New System.Windows.Forms.Label()
        Me.lblPtiDistrict = New System.Windows.Forms.Label()
        Me.lblPtiTele = New System.Windows.Forms.Label()
        Me.lblPtiAddrss = New System.Windows.Forms.Label()
        Me.lblPtiNIC = New System.Windows.Forms.Label()
        Me.lblPtiGendr = New System.Windows.Forms.Label()
        Me.lblPtiVacDte3 = New System.Windows.Forms.Label()
        Me.lblPtiVacDte2 = New System.Windows.Forms.Label()
        Me.lblPtiVacNme3 = New System.Windows.Forms.Label()
        Me.lblPtiVacNme2 = New System.Windows.Forms.Label()
        Me.lblPtiVacPlce3 = New System.Windows.Forms.Label()
        Me.lblPtiVacPlce2 = New System.Windows.Forms.Label()
        Me.lblPtiVacPlce1 = New System.Windows.Forms.Label()
        Me.lblPtiVacNme1 = New System.Windows.Forms.Label()
        Me.lblPtiVacDte1 = New System.Windows.Forms.Label()
        Me.lblPtiDOB = New System.Windows.Forms.Label()
        Me.lblPtiName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblrs = New System.Windows.Forms.Label()
        Me.lblin = New System.Windows.Forms.Label()
        Me.lblsd = New System.Windows.Forms.Label()
        Me.lbled = New System.Windows.Forms.Label()
        Me.lblcs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpPtiDate
        '
        Me.dtpPtiDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtpPtiDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPtiDate.Location = New System.Drawing.Point(45, 557)
        Me.dtpPtiDate.Name = "dtpPtiDate"
        Me.dtpPtiDate.Size = New System.Drawing.Size(198, 23)
        Me.dtpPtiDate.TabIndex = 51
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label45.Location = New System.Drawing.Point(41, 501)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(104, 20)
        Me.Label45.TabIndex = 42
        Me.Label45.Text = "Patient Details"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Maroon
        Me.Label39.Location = New System.Drawing.Point(42, 533)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(85, 17)
        Me.Label39.TabIndex = 32
        Me.Label39.Text = "Infected Date"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Maroon
        Me.Label40.Location = New System.Drawing.Point(261, 533)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 17)
        Me.Label40.TabIndex = 32
        Me.Label40.Text = "Corontine start date"
        '
        'dtpCoroSDte
        '
        Me.dtpCoroSDte.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtpCoroSDte.Enabled = False
        Me.dtpCoroSDte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCoroSDte.Location = New System.Drawing.Point(264, 557)
        Me.dtpCoroSDte.Name = "dtpCoroSDte"
        Me.dtpCoroSDte.Size = New System.Drawing.Size(198, 23)
        Me.dtpCoroSDte.TabIndex = 51
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Maroon
        Me.Label41.Location = New System.Drawing.Point(473, 533)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(121, 17)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Corontine end date"
        '
        'dtpCoroEDate
        '
        Me.dtpCoroEDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtpCoroEDate.Enabled = False
        Me.dtpCoroEDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCoroEDate.Location = New System.Drawing.Point(476, 557)
        Me.dtpCoroEDate.Name = "dtpCoroEDate"
        Me.dtpCoroEDate.Size = New System.Drawing.Size(198, 23)
        Me.dtpCoroEDate.TabIndex = 51
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Maroon
        Me.Label42.Location = New System.Drawing.Point(684, 533)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(99, 17)
        Me.Label42.TabIndex = 32
        Me.Label42.Text = "Corontine Place"
        '
        'txtPtiCoroPlce
        '
        Me.txtPtiCoroPlce.Enabled = False
        Me.txtPtiCoroPlce.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtiCoroPlce.Location = New System.Drawing.Point(687, 557)
        Me.txtPtiCoroPlce.Name = "txtPtiCoroPlce"
        Me.txtPtiCoroPlce.Size = New System.Drawing.Size(381, 23)
        Me.txtPtiCoroPlce.TabIndex = 52
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label43.Location = New System.Drawing.Point(455, 18)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(155, 37)
        Me.Label43.TabIndex = 53
        Me.Label43.Text = "Add Patient"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCancel.Location = New System.Drawing.Point(919, 662)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 35)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Location = New System.Drawing.Point(786, 662)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 35)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "Add Patient"
        Me.btnAdd.UseCompatibleTextRendering = True
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbPtiRecStus
        '
        Me.cmbPtiRecStus.Enabled = False
        Me.cmbPtiRecStus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPtiRecStus.FormattingEnabled = True
        Me.cmbPtiRecStus.Location = New System.Drawing.Point(44, 637)
        Me.cmbPtiRecStus.Name = "cmbPtiRecStus"
        Me.cmbPtiRecStus.Size = New System.Drawing.Size(199, 25)
        Me.cmbPtiRecStus.TabIndex = 22
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Maroon
        Me.Label44.Location = New System.Drawing.Point(42, 617)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(100, 17)
        Me.Label44.TabIndex = 32
        Me.Label44.Text = "Recovery Status"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.Location = New System.Drawing.Point(476, 99)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 33)
        Me.btnSearch.TabIndex = 152
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(171, 99)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(384, 33)
        Me.txtSearch.TabIndex = 151
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(859, 199)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(107, 17)
        Me.Label25.TabIndex = 149
        Me.Label25.Text = "Vaccination Place"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(736, 199)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 17)
        Me.Label24.TabIndex = 148
        Me.Label24.Text = "Vaccine Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(611, 199)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 17)
        Me.Label23.TabIndex = 147
        Me.Label23.Text = "VaccinationDate"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label28.Location = New System.Drawing.Point(551, 291)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 17)
        Me.Label28.TabIndex = 146
        Me.Label28.Text = "3rd"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label27.Location = New System.Drawing.Point(550, 261)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 17)
        Me.Label27.TabIndex = 145
        Me.Label27.Text = "2nd"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label26.Location = New System.Drawing.Point(553, 230)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 17)
        Me.Label26.TabIndex = 144
        Me.Label26.Text = "1st"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(546, 199)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 17)
        Me.Label22.TabIndex = 150
        Me.Label22.Text = "Dose"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label30.Location = New System.Drawing.Point(538, 172)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 20)
        Me.Label30.TabIndex = 143
        Me.Label30.Text = "Vaccination Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(57, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 17)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "G/N Area"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(57, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 17)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "MOH Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(57, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 17)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(57, 361)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "District/City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(57, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Mobile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(57, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(57, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "NIC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(57, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(57, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "DOB"
        '
        'lblPtiGN
        '
        Me.lblPtiGN.AutoSize = True
        Me.lblPtiGN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiGN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiGN.Location = New System.Drawing.Point(159, 442)
        Me.lblPtiGN.Name = "lblPtiGN"
        Me.lblPtiGN.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiGN.TabIndex = 140
        '
        'lblPtiMOH
        '
        Me.lblPtiMOH.AutoSize = True
        Me.lblPtiMOH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiMOH.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiMOH.Location = New System.Drawing.Point(159, 415)
        Me.lblPtiMOH.Name = "lblPtiMOH"
        Me.lblPtiMOH.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiMOH.TabIndex = 136
        '
        'lblPtiEmail
        '
        Me.lblPtiEmail.AutoSize = True
        Me.lblPtiEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiEmail.Location = New System.Drawing.Point(159, 388)
        Me.lblPtiEmail.Name = "lblPtiEmail"
        Me.lblPtiEmail.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiEmail.TabIndex = 139
        '
        'lblPtiDistrict
        '
        Me.lblPtiDistrict.AutoSize = True
        Me.lblPtiDistrict.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiDistrict.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiDistrict.Location = New System.Drawing.Point(159, 361)
        Me.lblPtiDistrict.Name = "lblPtiDistrict"
        Me.lblPtiDistrict.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiDistrict.TabIndex = 138
        '
        'lblPtiTele
        '
        Me.lblPtiTele.AutoSize = True
        Me.lblPtiTele.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiTele.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiTele.Location = New System.Drawing.Point(159, 334)
        Me.lblPtiTele.Name = "lblPtiTele"
        Me.lblPtiTele.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiTele.TabIndex = 137
        '
        'lblPtiAddrss
        '
        Me.lblPtiAddrss.AutoSize = True
        Me.lblPtiAddrss.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiAddrss.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiAddrss.Location = New System.Drawing.Point(159, 307)
        Me.lblPtiAddrss.Name = "lblPtiAddrss"
        Me.lblPtiAddrss.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiAddrss.TabIndex = 141
        '
        'lblPtiNIC
        '
        Me.lblPtiNIC.AutoSize = True
        Me.lblPtiNIC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiNIC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiNIC.Location = New System.Drawing.Point(159, 280)
        Me.lblPtiNIC.Name = "lblPtiNIC"
        Me.lblPtiNIC.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiNIC.TabIndex = 135
        '
        'lblPtiGendr
        '
        Me.lblPtiGendr.AutoSize = True
        Me.lblPtiGendr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiGendr.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiGendr.Location = New System.Drawing.Point(159, 253)
        Me.lblPtiGendr.Name = "lblPtiGendr"
        Me.lblPtiGendr.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiGendr.TabIndex = 126
        '
        'lblPtiVacDte3
        '
        Me.lblPtiVacDte3.AutoSize = True
        Me.lblPtiVacDte3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacDte3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacDte3.Location = New System.Drawing.Point(624, 291)
        Me.lblPtiVacDte3.Name = "lblPtiVacDte3"
        Me.lblPtiVacDte3.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacDte3.TabIndex = 122
        '
        'lblPtiVacDte2
        '
        Me.lblPtiVacDte2.AutoSize = True
        Me.lblPtiVacDte2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacDte2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacDte2.Location = New System.Drawing.Point(624, 261)
        Me.lblPtiVacDte2.Name = "lblPtiVacDte2"
        Me.lblPtiVacDte2.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacDte2.TabIndex = 123
        '
        'lblPtiVacNme3
        '
        Me.lblPtiVacNme3.AutoSize = True
        Me.lblPtiVacNme3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacNme3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacNme3.Location = New System.Drawing.Point(746, 291)
        Me.lblPtiVacNme3.Name = "lblPtiVacNme3"
        Me.lblPtiVacNme3.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacNme3.TabIndex = 124
        '
        'lblPtiVacNme2
        '
        Me.lblPtiVacNme2.AutoSize = True
        Me.lblPtiVacNme2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacNme2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacNme2.Location = New System.Drawing.Point(746, 261)
        Me.lblPtiVacNme2.Name = "lblPtiVacNme2"
        Me.lblPtiVacNme2.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacNme2.TabIndex = 134
        '
        'lblPtiVacPlce3
        '
        Me.lblPtiVacPlce3.AutoSize = True
        Me.lblPtiVacPlce3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacPlce3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacPlce3.Location = New System.Drawing.Point(870, 291)
        Me.lblPtiVacPlce3.Name = "lblPtiVacPlce3"
        Me.lblPtiVacPlce3.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacPlce3.TabIndex = 125
        '
        'lblPtiVacPlce2
        '
        Me.lblPtiVacPlce2.AutoSize = True
        Me.lblPtiVacPlce2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacPlce2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacPlce2.Location = New System.Drawing.Point(870, 261)
        Me.lblPtiVacPlce2.Name = "lblPtiVacPlce2"
        Me.lblPtiVacPlce2.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacPlce2.TabIndex = 127
        '
        'lblPtiVacPlce1
        '
        Me.lblPtiVacPlce1.AutoSize = True
        Me.lblPtiVacPlce1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacPlce1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacPlce1.Location = New System.Drawing.Point(870, 226)
        Me.lblPtiVacPlce1.Name = "lblPtiVacPlce1"
        Me.lblPtiVacPlce1.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacPlce1.TabIndex = 128
        '
        'lblPtiVacNme1
        '
        Me.lblPtiVacNme1.AutoSize = True
        Me.lblPtiVacNme1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacNme1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacNme1.Location = New System.Drawing.Point(746, 230)
        Me.lblPtiVacNme1.Name = "lblPtiVacNme1"
        Me.lblPtiVacNme1.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacNme1.TabIndex = 129
        '
        'lblPtiVacDte1
        '
        Me.lblPtiVacDte1.AutoSize = True
        Me.lblPtiVacDte1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiVacDte1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiVacDte1.Location = New System.Drawing.Point(624, 230)
        Me.lblPtiVacDte1.Name = "lblPtiVacDte1"
        Me.lblPtiVacDte1.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiVacDte1.TabIndex = 130
        '
        'lblPtiDOB
        '
        Me.lblPtiDOB.AutoSize = True
        Me.lblPtiDOB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiDOB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiDOB.Location = New System.Drawing.Point(159, 226)
        Me.lblPtiDOB.Name = "lblPtiDOB"
        Me.lblPtiDOB.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiDOB.TabIndex = 131
        '
        'lblPtiName
        '
        Me.lblPtiName.AutoSize = True
        Me.lblPtiName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtiName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPtiName.Location = New System.Drawing.Point(159, 199)
        Me.lblPtiName.Name = "lblPtiName"
        Me.lblPtiName.Size = New System.Drawing.Size(0, 17)
        Me.lblPtiName.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(57, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label29.Location = New System.Drawing.Point(58, 172)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 20)
        Me.Label29.TabIndex = 113
        Me.Label29.Text = "Personal Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(56, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Search by NIC"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Crimson
        Me.lblError.Location = New System.Drawing.Point(168, 135)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(85, 15)
        Me.lblError.TabIndex = 129
        Me.lblError.Text = "* NIC Required"
        '
        'lblrs
        '
        Me.lblrs.AutoSize = True
        Me.lblrs.Enabled = False
        Me.lblrs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrs.ForeColor = System.Drawing.Color.Crimson
        Me.lblrs.Location = New System.Drawing.Point(47, 665)
        Me.lblrs.Name = "lblrs"
        Me.lblrs.Size = New System.Drawing.Size(62, 15)
        Me.lblrs.TabIndex = 142
        Me.lblrs.Text = "* Required"
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.Enabled = False
        Me.lblin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblin.ForeColor = System.Drawing.Color.Crimson
        Me.lblin.Location = New System.Drawing.Point(48, 583)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(62, 15)
        Me.lblin.TabIndex = 142
        Me.lblin.Text = "* Required"
        '
        'lblsd
        '
        Me.lblsd.AutoSize = True
        Me.lblsd.Enabled = False
        Me.lblsd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsd.ForeColor = System.Drawing.Color.Crimson
        Me.lblsd.Location = New System.Drawing.Point(267, 583)
        Me.lblsd.Name = "lblsd"
        Me.lblsd.Size = New System.Drawing.Size(62, 15)
        Me.lblsd.TabIndex = 142
        Me.lblsd.Text = "* Required"
        '
        'lbled
        '
        Me.lbled.AutoSize = True
        Me.lbled.Enabled = False
        Me.lbled.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbled.ForeColor = System.Drawing.Color.Crimson
        Me.lbled.Location = New System.Drawing.Point(479, 583)
        Me.lbled.Name = "lbled"
        Me.lbled.Size = New System.Drawing.Size(62, 15)
        Me.lbled.TabIndex = 142
        Me.lbled.Text = "* Required"
        '
        'lblcs
        '
        Me.lblcs.AutoSize = True
        Me.lblcs.Enabled = False
        Me.lblcs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcs.ForeColor = System.Drawing.Color.Crimson
        Me.lblcs.Location = New System.Drawing.Point(690, 583)
        Me.lblcs.Name = "lblcs"
        Me.lblcs.Size = New System.Drawing.Size(62, 15)
        Me.lblcs.TabIndex = 142
        Me.lblcs.Text = "* Required"
        '
        'frmPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1080, 744)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblin)
        Me.Controls.Add(Me.lblcs)
        Me.Controls.Add(Me.lbled)
        Me.Controls.Add(Me.lblsd)
        Me.Controls.Add(Me.lblrs)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPtiGN)
        Me.Controls.Add(Me.lblPtiMOH)
        Me.Controls.Add(Me.lblPtiEmail)
        Me.Controls.Add(Me.lblPtiDistrict)
        Me.Controls.Add(Me.lblPtiTele)
        Me.Controls.Add(Me.lblPtiAddrss)
        Me.Controls.Add(Me.lblPtiNIC)
        Me.Controls.Add(Me.lblPtiGendr)
        Me.Controls.Add(Me.lblPtiVacDte3)
        Me.Controls.Add(Me.lblPtiVacDte2)
        Me.Controls.Add(Me.lblPtiVacNme3)
        Me.Controls.Add(Me.lblPtiVacNme2)
        Me.Controls.Add(Me.lblPtiVacPlce3)
        Me.Controls.Add(Me.lblPtiVacPlce2)
        Me.Controls.Add(Me.lblPtiVacPlce1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblPtiVacNme1)
        Me.Controls.Add(Me.lblPtiVacDte1)
        Me.Controls.Add(Me.lblPtiDOB)
        Me.Controls.Add(Me.lblPtiName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.txtPtiCoroPlce)
        Me.Controls.Add(Me.dtpCoroEDate)
        Me.Controls.Add(Me.dtpCoroSDte)
        Me.Controls.Add(Me.dtpPtiDate)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cmbPtiRecStus)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpPtiDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dtpCoroSDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents dtpCoroEDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtPtiCoroPlce As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cmbPtiRecStus As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPtiGN As System.Windows.Forms.Label
    Friend WithEvents lblPtiMOH As System.Windows.Forms.Label
    Friend WithEvents lblPtiEmail As System.Windows.Forms.Label
    Friend WithEvents lblPtiDistrict As System.Windows.Forms.Label
    Friend WithEvents lblPtiTele As System.Windows.Forms.Label
    Friend WithEvents lblPtiAddrss As System.Windows.Forms.Label
    Friend WithEvents lblPtiNIC As System.Windows.Forms.Label
    Friend WithEvents lblPtiGendr As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacDte3 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacDte2 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacNme3 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacNme2 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacPlce3 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacPlce2 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacPlce1 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacNme1 As System.Windows.Forms.Label
    Friend WithEvents lblPtiVacDte1 As System.Windows.Forms.Label
    Friend WithEvents lblPtiDOB As System.Windows.Forms.Label
    Friend WithEvents lblPtiName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblrs As System.Windows.Forms.Label
    Friend WithEvents lblin As System.Windows.Forms.Label
    Friend WithEvents lblsd As System.Windows.Forms.Label
    Friend WithEvents lbled As System.Windows.Forms.Label
    Friend WithEvents lblcs As System.Windows.Forms.Label
End Class
