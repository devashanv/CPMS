<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVaccine
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbField = New System.Windows.Forms.ComboBox()
        Me.btnVacFind = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSrchValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblslErro = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnReFresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select Field"
        '
        'cmbField
        '
        Me.cmbField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Location = New System.Drawing.Point(47, 94)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(148, 29)
        Me.cmbField.TabIndex = 1
        '
        'btnVacFind
        '
        Me.btnVacFind.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVacFind.Enabled = False
        Me.btnVacFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVacFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVacFind.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVacFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVacFind.Location = New System.Drawing.Point(512, 92)
        Me.btnVacFind.Name = "btnVacFind"
        Me.btnVacFind.Size = New System.Drawing.Size(116, 31)
        Me.btnVacFind.TabIndex = 8
        Me.btnVacFind.Text = "Find"
        Me.btnVacFind.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label17.Location = New System.Drawing.Point(34, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(258, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Select your filetrs and find the details."
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(8, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(881, 531)
        Me.DataGridView1.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "NIC"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "MOH / GN"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 230
        '
        'Column5
        '
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "Vaccine"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 110
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Dose"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "Place"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 220
        '
        'txtSrchValue
        '
        Me.txtSrchValue.Enabled = False
        Me.txtSrchValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrchValue.Location = New System.Drawing.Point(214, 94)
        Me.txtSrchValue.Name = "txtSrchValue"
        Me.txtSrchValue.Size = New System.Drawing.Size(280, 29)
        Me.txtSrchValue.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(210, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type Search Value"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Enabled = False
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Crimson
        Me.lblError.Location = New System.Drawing.Point(213, 126)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(55, 15)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "* Reuired"
        '
        'lblslErro
        '
        Me.lblslErro.AutoSize = True
        Me.lblslErro.Enabled = False
        Me.lblslErro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslErro.ForeColor = System.Drawing.Color.Crimson
        Me.lblslErro.Location = New System.Drawing.Point(44, 126)
        Me.lblslErro.Name = "lblslErro"
        Me.lblslErro.Size = New System.Drawing.Size(55, 15)
        Me.lblslErro.TabIndex = 0
        Me.lblslErro.Text = "* Reuired"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Enabled = False
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbldate.Location = New System.Drawing.Point(358, 126)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(136, 15)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Date type YYYY-MM-DD"
        Me.lbldate.Visible = False
        '
        'btnReFresh
        '
        Me.btnReFresh.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnReFresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnReFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReFresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReFresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReFresh.Location = New System.Drawing.Point(804, 126)
        Me.btnReFresh.Name = "btnReFresh"
        Me.btnReFresh.Size = New System.Drawing.Size(85, 31)
        Me.btnReFresh.TabIndex = 8
        Me.btnReFresh.Text = "Refresh"
        Me.btnReFresh.UseVisualStyleBackColor = False
        '
        'frmVaccine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(897, 705)
        Me.Controls.Add(Me.txtSrchValue)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReFresh)
        Me.Controls.Add(Me.btnVacFind)
        Me.Controls.Add(Me.cmbField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblslErro)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVaccine"
        Me.Text = "vaccine"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbField As System.Windows.Forms.ComboBox
    Friend WithEvents btnVacFind As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSrchValue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblslErro As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnReFresh As System.Windows.Forms.Button
End Class
