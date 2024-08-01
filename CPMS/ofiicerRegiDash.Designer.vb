<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffiicerRegiDash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffiicerRegiDash))
        Me.btnOffiRegi = New System.Windows.Forms.Button()
        Me.btnPeoRegi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOffiRegi
        '
        Me.btnOffiRegi.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnOffiRegi.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnOffiRegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOffiRegi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffiRegi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOffiRegi.Location = New System.Drawing.Point(70, 102)
        Me.btnOffiRegi.Name = "btnOffiRegi"
        Me.btnOffiRegi.Size = New System.Drawing.Size(258, 179)
        Me.btnOffiRegi.TabIndex = 72
        Me.btnOffiRegi.Text = "Officer Registration"
        Me.btnOffiRegi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOffiRegi.UseVisualStyleBackColor = False
        '
        'btnPeoRegi
        '
        Me.btnPeoRegi.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPeoRegi.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPeoRegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeoRegi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeoRegi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPeoRegi.Location = New System.Drawing.Point(503, 102)
        Me.btnPeoRegi.Name = "btnPeoRegi"
        Me.btnPeoRegi.Size = New System.Drawing.Size(258, 179)
        Me.btnPeoRegi.TabIndex = 72
        Me.btnPeoRegi.Text = "People Registration"
        Me.btnPeoRegi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPeoRegi.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(558, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label20.Location = New System.Drawing.Point(23, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(269, 20)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Select the type of registration you want"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.Location = New System.Drawing.Point(787, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(87, 29)
        Me.btnLogout.TabIndex = 185
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmOffiicerRegiDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(897, 705)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPeoRegi)
        Me.Controls.Add(Me.btnOffiRegi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOffiicerRegiDash"
        Me.Text = "ofiicerRegiDash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOffiRegi As System.Windows.Forms.Button
    Friend WithEvents btnPeoRegi As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
