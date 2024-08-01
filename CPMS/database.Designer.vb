<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabPatient = New System.Windows.Forms.TabControl()
        Me.Patient = New System.Windows.Forms.TabPage()
        Me.txtPatSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblSrchErro = New System.Windows.Forms.Label()
        Me.cmbPatField = New System.Windows.Forms.ComboBox()
        Me.lblPatError = New System.Windows.Forms.Label()
        Me.btnPatSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.Associate = New System.Windows.Forms.TabPage()
        Me.txtSearchAs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHintAs = New System.Windows.Forms.Label()
        Me.lblSearchAs = New System.Windows.Forms.Label()
        Me.cmbAsField = New System.Windows.Forms.ComboBox()
        Me.lblErrorAs = New System.Windows.Forms.Label()
        Me.DataGridViewAssoc = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAssoc = New System.Windows.Forms.Button()
        Me.Label204 = New System.Windows.Forms.Label()
        Me.btnAsSearch = New System.Windows.Forms.Button()
        Me.btnAddAsso = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.tabPatient.SuspendLayout()
        Me.Patient.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Associate.SuspendLayout()
        CType(Me.DataGridViewAssoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPatient
        '
        Me.tabPatient.Controls.Add(Me.Patient)
        Me.tabPatient.Controls.Add(Me.Associate)
        Me.tabPatient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPatient.Location = New System.Drawing.Point(9, 45)
        Me.tabPatient.Margin = New System.Windows.Forms.Padding(5)
        Me.tabPatient.Name = "tabPatient"
        Me.tabPatient.SelectedIndex = 0
        Me.tabPatient.Size = New System.Drawing.Size(878, 659)
        Me.tabPatient.TabIndex = 11
        '
        'Patient
        '
        Me.Patient.Controls.Add(Me.txtPatSearch)
        Me.Patient.Controls.Add(Me.Label1)
        Me.Patient.Controls.Add(Me.lblHint)
        Me.Patient.Controls.Add(Me.lblSrchErro)
        Me.Patient.Controls.Add(Me.cmbPatField)
        Me.Patient.Controls.Add(Me.lblPatError)
        Me.Patient.Controls.Add(Me.btnPatSearch)
        Me.Patient.Controls.Add(Me.Label2)
        Me.Patient.Controls.Add(Me.DataGridView1)
        Me.Patient.Controls.Add(Me.btnLoad)
        Me.Patient.Controls.Add(Me.btnAddPatient)
        Me.Patient.Location = New System.Drawing.Point(4, 26)
        Me.Patient.Name = "Patient"
        Me.Patient.Padding = New System.Windows.Forms.Padding(3)
        Me.Patient.Size = New System.Drawing.Size(870, 629)
        Me.Patient.TabIndex = 0
        Me.Patient.Text = "Patient"
        Me.Patient.UseVisualStyleBackColor = True
        '
        'txtPatSearch
        '
        Me.txtPatSearch.Enabled = False
        Me.txtPatSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatSearch.Location = New System.Drawing.Point(181, 106)
        Me.txtPatSearch.Name = "txtPatSearch"
        Me.txtPatSearch.Size = New System.Drawing.Size(280, 29)
        Me.txtPatSearch.TabIndex = 309
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(177, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 306
        Me.Label1.Text = "Type Search Value"
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Enabled = False
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHint.Location = New System.Drawing.Point(325, 138)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(136, 15)
        Me.lblHint.TabIndex = 307
        Me.lblHint.Text = "Date type YYYY-MM-DD"
        Me.lblHint.Visible = False
        '
        'lblSrchErro
        '
        Me.lblSrchErro.AutoSize = True
        Me.lblSrchErro.Enabled = False
        Me.lblSrchErro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrchErro.ForeColor = System.Drawing.Color.Crimson
        Me.lblSrchErro.Location = New System.Drawing.Point(180, 138)
        Me.lblSrchErro.Name = "lblSrchErro"
        Me.lblSrchErro.Size = New System.Drawing.Size(55, 15)
        Me.lblSrchErro.TabIndex = 308
        Me.lblSrchErro.Text = "* Reuired"
        '
        'cmbPatField
        '
        Me.cmbPatField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatField.FormattingEnabled = True
        Me.cmbPatField.Location = New System.Drawing.Point(14, 106)
        Me.cmbPatField.Name = "cmbPatField"
        Me.cmbPatField.Size = New System.Drawing.Size(148, 29)
        Me.cmbPatField.TabIndex = 303
        '
        'lblPatError
        '
        Me.lblPatError.AutoSize = True
        Me.lblPatError.Enabled = False
        Me.lblPatError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatError.ForeColor = System.Drawing.Color.Crimson
        Me.lblPatError.Location = New System.Drawing.Point(11, 138)
        Me.lblPatError.Name = "lblPatError"
        Me.lblPatError.Size = New System.Drawing.Size(55, 15)
        Me.lblPatError.TabIndex = 302
        Me.lblPatError.Text = "* Reuired"
        '
        'btnPatSearch
        '
        Me.btnPatSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPatSearch.Enabled = False
        Me.btnPatSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPatSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPatSearch.Location = New System.Drawing.Point(467, 104)
        Me.btnPatSearch.Name = "btnPatSearch"
        Me.btnPatSearch.Size = New System.Drawing.Size(79, 33)
        Me.btnPatSearch.TabIndex = 305
        Me.btnPatSearch.Text = "Search"
        Me.btnPatSearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(10, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Select field and Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8, Me.Column6, Me.Column10})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(883, 459)
        Me.DataGridView1.TabIndex = 205
        '
        'Column7
        '
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 25
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = "Date"
        Me.Column9.Name = "Column9"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 85
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "NIC"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "DOB"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Gender"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "Telephone"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "District"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 120
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "G/N "
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column10.HeaderText = "Status"
        Me.Column10.Name = "Column10"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLoad.Location = New System.Drawing.Point(780, 118)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(79, 33)
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "Refresh"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddPatient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddPatient.Location = New System.Drawing.Point(160, 21)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(540, 45)
        Me.btnAddPatient.TabIndex = 8
        Me.btnAddPatient.Text = "Add New Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'Associate
        '
        Me.Associate.Controls.Add(Me.txtSearchAs)
        Me.Associate.Controls.Add(Me.Label3)
        Me.Associate.Controls.Add(Me.lblHintAs)
        Me.Associate.Controls.Add(Me.lblSearchAs)
        Me.Associate.Controls.Add(Me.cmbAsField)
        Me.Associate.Controls.Add(Me.lblErrorAs)
        Me.Associate.Controls.Add(Me.DataGridViewAssoc)
        Me.Associate.Controls.Add(Me.btnAssoc)
        Me.Associate.Controls.Add(Me.Label204)
        Me.Associate.Controls.Add(Me.btnAsSearch)
        Me.Associate.Controls.Add(Me.btnAddAsso)
        Me.Associate.Location = New System.Drawing.Point(4, 26)
        Me.Associate.Margin = New System.Windows.Forms.Padding(5)
        Me.Associate.Name = "Associate"
        Me.Associate.Padding = New System.Windows.Forms.Padding(3)
        Me.Associate.Size = New System.Drawing.Size(870, 629)
        Me.Associate.TabIndex = 1
        Me.Associate.Text = "Associate"
        Me.Associate.UseVisualStyleBackColor = True
        '
        'txtSearchAs
        '
        Me.txtSearchAs.Enabled = False
        Me.txtSearchAs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAs.Location = New System.Drawing.Point(181, 106)
        Me.txtSearchAs.Name = "txtSearchAs"
        Me.txtSearchAs.Size = New System.Drawing.Size(280, 29)
        Me.txtSearchAs.TabIndex = 313
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(177, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 21)
        Me.Label3.TabIndex = 310
        Me.Label3.Text = "Type Search Value"
        '
        'lblHintAs
        '
        Me.lblHintAs.AutoSize = True
        Me.lblHintAs.Enabled = False
        Me.lblHintAs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHintAs.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHintAs.Location = New System.Drawing.Point(325, 138)
        Me.lblHintAs.Name = "lblHintAs"
        Me.lblHintAs.Size = New System.Drawing.Size(136, 15)
        Me.lblHintAs.TabIndex = 311
        Me.lblHintAs.Text = "Date type YYYY-MM-DD"
        Me.lblHintAs.Visible = False
        '
        'lblSearchAs
        '
        Me.lblSearchAs.AutoSize = True
        Me.lblSearchAs.Enabled = False
        Me.lblSearchAs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchAs.ForeColor = System.Drawing.Color.Crimson
        Me.lblSearchAs.Location = New System.Drawing.Point(180, 138)
        Me.lblSearchAs.Name = "lblSearchAs"
        Me.lblSearchAs.Size = New System.Drawing.Size(55, 15)
        Me.lblSearchAs.TabIndex = 312
        Me.lblSearchAs.Text = "* Reuired"
        '
        'cmbAsField
        '
        Me.cmbAsField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAsField.FormattingEnabled = True
        Me.cmbAsField.Location = New System.Drawing.Point(14, 106)
        Me.cmbAsField.Name = "cmbAsField"
        Me.cmbAsField.Size = New System.Drawing.Size(148, 29)
        Me.cmbAsField.TabIndex = 300
        '
        'lblErrorAs
        '
        Me.lblErrorAs.AutoSize = True
        Me.lblErrorAs.Enabled = False
        Me.lblErrorAs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorAs.ForeColor = System.Drawing.Color.Crimson
        Me.lblErrorAs.Location = New System.Drawing.Point(11, 138)
        Me.lblErrorAs.Name = "lblErrorAs"
        Me.lblErrorAs.Size = New System.Drawing.Size(55, 15)
        Me.lblErrorAs.TabIndex = 299
        Me.lblErrorAs.Text = "* Reuired"
        '
        'DataGridViewAssoc
        '
        Me.DataGridViewAssoc.AllowUserToAddRows = False
        Me.DataGridViewAssoc.AllowUserToDeleteRows = False
        Me.DataGridViewAssoc.AllowUserToResizeColumns = False
        Me.DataGridViewAssoc.AllowUserToResizeRows = False
        Me.DataGridViewAssoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewAssoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAssoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewAssoc.ColumnHeadersHeight = 35
        Me.DataGridViewAssoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewAssoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.Column11})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAssoc.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewAssoc.EnableHeadersVisualStyles = False
        Me.DataGridViewAssoc.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewAssoc.Location = New System.Drawing.Point(-4, 167)
        Me.DataGridViewAssoc.Name = "DataGridViewAssoc"
        Me.DataGridViewAssoc.RowHeadersVisible = False
        Me.DataGridViewAssoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAssoc.Size = New System.Drawing.Size(887, 462)
        Me.DataGridViewAssoc.TabIndex = 298
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "NIC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.HeaderText = "District"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.HeaderText = "G/N "
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Corontine Place"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 200
        '
        'btnAssoc
        '
        Me.btnAssoc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAssoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAssoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssoc.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssoc.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAssoc.Location = New System.Drawing.Point(780, 118)
        Me.btnAssoc.Name = "btnAssoc"
        Me.btnAssoc.Size = New System.Drawing.Size(79, 33)
        Me.btnAssoc.TabIndex = 297
        Me.btnAssoc.Text = "Refresh"
        Me.btnAssoc.UseVisualStyleBackColor = False
        '
        'Label204
        '
        Me.Label204.AutoSize = True
        Me.Label204.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label204.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label204.Location = New System.Drawing.Point(10, 83)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(160, 20)
        Me.Label204.TabIndex = 296
        Me.Label204.Text = "Select field and Search"
        '
        'btnAsSearch
        '
        Me.btnAsSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAsSearch.Enabled = False
        Me.btnAsSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAsSearch.Location = New System.Drawing.Point(467, 104)
        Me.btnAsSearch.Name = "btnAsSearch"
        Me.btnAsSearch.Size = New System.Drawing.Size(79, 33)
        Me.btnAsSearch.TabIndex = 24
        Me.btnAsSearch.Text = "Search"
        Me.btnAsSearch.UseVisualStyleBackColor = False
        '
        'btnAddAsso
        '
        Me.btnAddAsso.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddAsso.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddAsso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAsso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAsso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddAsso.Location = New System.Drawing.Point(160, 21)
        Me.btnAddAsso.Name = "btnAddAsso"
        Me.btnAddAsso.Size = New System.Drawing.Size(540, 45)
        Me.btnAddAsso.TabIndex = 20
        Me.btnAddAsso.Text = "Add New Accociate"
        Me.btnAddAsso.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.Location = New System.Drawing.Point(785, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(87, 29)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(897, 705)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabPatient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabase"
        Me.Text = "database"
        Me.tabPatient.ResumeLayout(False)
        Me.Patient.ResumeLayout(False)
        Me.Patient.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Associate.ResumeLayout(False)
        Me.Associate.PerformLayout()
        CType(Me.DataGridViewAssoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPatient As System.Windows.Forms.TabControl
    Friend WithEvents Associate As System.Windows.Forms.TabPage
    Friend WithEvents btnAsSearch As System.Windows.Forms.Button
    Friend WithEvents btnAddAsso As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label204 As System.Windows.Forms.Label
    Friend WithEvents Patient As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnAddPatient As System.Windows.Forms.Button
    Friend WithEvents btnAssoc As System.Windows.Forms.Button
    Friend WithEvents DataGridViewAssoc As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPatSearch As System.Windows.Forms.Button
    Friend WithEvents cmbPatField As System.Windows.Forms.ComboBox
    Friend WithEvents lblPatError As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAsField As System.Windows.Forms.ComboBox
    Friend WithEvents lblErrorAs As System.Windows.Forms.Label
    Friend WithEvents txtPatSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblSrchErro As System.Windows.Forms.Label
    Friend WithEvents txtSearchAs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHintAs As System.Windows.Forms.Label
    Friend WithEvents lblSearchAs As System.Windows.Forms.Label
End Class
