<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreen
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
        Me.txtfld_NomUtil = New System.Windows.Forms.TextBox()
        Me.txtfld_MDPass = New System.Windows.Forms.TextBox()
        Me.btn_Connection = New System.Windows.Forms.Button()
        Me.pnl_Connexion = New System.Windows.Forms.Panel()
        Me.link_Oubli = New System.Windows.Forms.LinkLabel()
        Me.lbl_MDPass = New System.Windows.Forms.Label()
        Me.lbl_Utilisateur = New System.Windows.Forms.Label()
        Me.pnl_NvUtil = New System.Windows.Forms.Panel()
        Me.link_Contact = New System.Windows.Forms.LinkLabel()
        Me.link_Avantages = New System.Windows.Forms.LinkLabel()
        Me.btn_Creation = New System.Windows.Forms.Button()
        Me.lbl_NouvUtil = New System.Windows.Forms.Label()
        Me.Lbl_Abonnet = New System.Windows.Forms.Label()
        Me.Pnl_Inscription = New System.Windows.Forms.Panel()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.btn_SInscrire = New System.Windows.Forms.Button()
        Me.lbl_NvMDPassCnf = New System.Windows.Forms.Label()
        Me.txtfld_NvMDPassCnf = New System.Windows.Forms.TextBox()
        Me.txtfld_NvMDPass = New System.Windows.Forms.TextBox()
        Me.lbl_NvMDPass = New System.Windows.Forms.Label()
        Me.txtfld_NvUtil = New System.Windows.Forms.TextBox()
        Me.lbl_NvUtil = New System.Windows.Forms.Label()
        Me.pnl_Connexion.SuspendLayout()
        Me.pnl_NvUtil.SuspendLayout()
        Me.Pnl_Inscription.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfld_NomUtil
        '
        Me.txtfld_NomUtil.Location = New System.Drawing.Point(138, 44)
        Me.txtfld_NomUtil.Name = "txtfld_NomUtil"
        Me.txtfld_NomUtil.Size = New System.Drawing.Size(168, 20)
        Me.txtfld_NomUtil.TabIndex = 0
        '
        'txtfld_MDPass
        '
        Me.txtfld_MDPass.Location = New System.Drawing.Point(138, 111)
        Me.txtfld_MDPass.Name = "txtfld_MDPass"
        Me.txtfld_MDPass.Size = New System.Drawing.Size(168, 20)
        Me.txtfld_MDPass.TabIndex = 1
        '
        'btn_Connection
        '
        Me.btn_Connection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Connection.Location = New System.Drawing.Point(113, 211)
        Me.btn_Connection.Name = "btn_Connection"
        Me.btn_Connection.Size = New System.Drawing.Size(117, 35)
        Me.btn_Connection.TabIndex = 2
        Me.btn_Connection.Text = "Connexion"
        Me.btn_Connection.UseVisualStyleBackColor = True
        '
        'Pnl_Connexion
        '
        Me.pnl_Connexion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_Connexion.Controls.Add(Me.link_Oubli)
        Me.pnl_Connexion.Controls.Add(Me.lbl_MDPass)
        Me.pnl_Connexion.Controls.Add(Me.lbl_Utilisateur)
        Me.pnl_Connexion.Controls.Add(Me.txtfld_NomUtil)
        Me.pnl_Connexion.Controls.Add(Me.btn_Connection)
        Me.pnl_Connexion.Controls.Add(Me.txtfld_MDPass)
        Me.pnl_Connexion.Location = New System.Drawing.Point(31, 96)
        Me.pnl_Connexion.Name = "Pnl_Connexion"
        Me.pnl_Connexion.Size = New System.Drawing.Size(358, 281)
        Me.pnl_Connexion.TabIndex = 3
        '
        'link_Oubli
        '
        Me.link_Oubli.AutoSize = True
        Me.link_Oubli.Location = New System.Drawing.Point(187, 134)
        Me.link_Oubli.Name = "link_Oubli"
        Me.link_Oubli.Size = New System.Drawing.Size(120, 13)
        Me.link_Oubli.TabIndex = 5
        Me.link_Oubli.TabStop = True
        Me.link_Oubli.Text = "Identifications oubliées?"
        '
        'lbl_MDPass
        '
        Me.lbl_MDPass.AutoSize = True
        Me.lbl_MDPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MDPass.Location = New System.Drawing.Point(42, 115)
        Me.lbl_MDPass.Name = "lbl_MDPass"
        Me.lbl_MDPass.Size = New System.Drawing.Size(90, 16)
        Me.lbl_MDPass.TabIndex = 4
        Me.lbl_MDPass.Text = "Mot de passe"
        '
        'lbl_Utilisateur
        '
        Me.lbl_Utilisateur.AutoSize = True
        Me.lbl_Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Utilisateur.Location = New System.Drawing.Point(25, 44)
        Me.lbl_Utilisateur.Name = "lbl_Utilisateur"
        Me.lbl_Utilisateur.Size = New System.Drawing.Size(107, 16)
        Me.lbl_Utilisateur.TabIndex = 3
        Me.lbl_Utilisateur.Text = "Nom d'utilisateur"
        '
        'pnl_NvUtil
        '
        Me.pnl_NvUtil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_NvUtil.Controls.Add(Me.link_Contact)
        Me.pnl_NvUtil.Controls.Add(Me.link_Avantages)
        Me.pnl_NvUtil.Controls.Add(Me.btn_Creation)
        Me.pnl_NvUtil.Controls.Add(Me.lbl_NouvUtil)
        Me.pnl_NvUtil.Location = New System.Drawing.Point(408, 29)
        Me.pnl_NvUtil.Name = "pnl_NvUtil"
        Me.pnl_NvUtil.Size = New System.Drawing.Size(358, 182)
        Me.pnl_NvUtil.TabIndex = 4
        '
        'link_Contact
        '
        Me.link_Contact.AutoSize = True
        Me.link_Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_Contact.Location = New System.Drawing.Point(28, 90)
        Me.link_Contact.Name = "link_Contact"
        Me.link_Contact.Size = New System.Drawing.Size(98, 16)
        Me.link_Contact.TabIndex = 3
        Me.link_Contact.TabStop = True
        Me.link_Contact.Text = "Nous contacter"
        '
        'link_Avantages
        '
        Me.link_Avantages.AutoSize = True
        Me.link_Avantages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_Avantages.Location = New System.Drawing.Point(28, 48)
        Me.link_Avantages.Name = "link_Avantages"
        Me.link_Avantages.Size = New System.Drawing.Size(126, 16)
        Me.link_Avantages.TabIndex = 2
        Me.link_Avantages.TabStop = True
        Me.link_Avantages.Text = "Avantages Abonnet"
        '
        'btn_Creation
        '
        Me.btn_Creation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Creation.Location = New System.Drawing.Point(225, 126)
        Me.btn_Creation.Name = "btn_Creation"
        Me.btn_Creation.Size = New System.Drawing.Size(90, 32)
        Me.btn_Creation.TabIndex = 1
        Me.btn_Creation.Text = "S'inscrire"
        Me.btn_Creation.UseVisualStyleBackColor = True
        '
        'lbl_NouvUtil
        '
        Me.lbl_NouvUtil.AutoSize = True
        Me.lbl_NouvUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NouvUtil.Location = New System.Drawing.Point(27, 134)
        Me.lbl_NouvUtil.Name = "lbl_NouvUtil"
        Me.lbl_NouvUtil.Size = New System.Drawing.Size(165, 24)
        Me.lbl_NouvUtil.TabIndex = 0
        Me.lbl_NouvUtil.Text = "Nouvel Utilisateur?"
        '
        'Lbl_Abonnet
        '
        Me.Lbl_Abonnet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Abonnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Abonnet.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Abonnet.Location = New System.Drawing.Point(31, 29)
        Me.Lbl_Abonnet.Name = "Lbl_Abonnet"
        Me.Lbl_Abonnet.Size = New System.Drawing.Size(358, 64)
        Me.Lbl_Abonnet.TabIndex = 5
        Me.Lbl_Abonnet.Text = "ABONNET"
        Me.Lbl_Abonnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_Inscription
        '
        Me.Pnl_Inscription.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pnl_Inscription.Controls.Add(Me.btn_Annuler)
        Me.Pnl_Inscription.Controls.Add(Me.btn_SInscrire)
        Me.Pnl_Inscription.Controls.Add(Me.lbl_NvMDPassCnf)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NvMDPassCnf)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NvMDPass)
        Me.Pnl_Inscription.Controls.Add(Me.lbl_NvMDPass)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NvUtil)
        Me.Pnl_Inscription.Controls.Add(Me.lbl_NvUtil)
        Me.Pnl_Inscription.Location = New System.Drawing.Point(408, 29)
        Me.Pnl_Inscription.Name = "Pnl_Inscription"
        Me.Pnl_Inscription.Size = New System.Drawing.Size(358, 348)
        Me.Pnl_Inscription.TabIndex = 6
        Me.Pnl_Inscription.Visible = False
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annuler.Location = New System.Drawing.Point(37, 278)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(117, 35)
        Me.btn_Annuler.TabIndex = 12
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'btn_SInscrire
        '
        Me.btn_SInscrire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SInscrire.Location = New System.Drawing.Point(198, 278)
        Me.btn_SInscrire.Name = "btn_SInscrire"
        Me.btn_SInscrire.Size = New System.Drawing.Size(117, 35)
        Me.btn_SInscrire.TabIndex = 11
        Me.btn_SInscrire.Text = "S'inscrire!"
        Me.btn_SInscrire.UseVisualStyleBackColor = True
        '
        'lbl_NvMDPassCnf
        '
        Me.lbl_NvMDPassCnf.AutoSize = True
        Me.lbl_NvMDPassCnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NvMDPassCnf.Location = New System.Drawing.Point(28, 118)
        Me.lbl_NvMDPassCnf.Name = "lbl_NvMDPassCnf"
        Me.lbl_NvMDPassCnf.Size = New System.Drawing.Size(114, 16)
        Me.lbl_NvMDPassCnf.TabIndex = 10
        Me.lbl_NvMDPassCnf.Text = "(saisir à nouveau)"
        '
        'txtfld_NvMDPassCnf
        '
        Me.txtfld_NvMDPassCnf.Location = New System.Drawing.Point(160, 114)
        Me.txtfld_NvMDPassCnf.Name = "txtfld_NvMDPassCnf"
        Me.txtfld_NvMDPassCnf.Size = New System.Drawing.Size(168, 20)
        Me.txtfld_NvMDPassCnf.TabIndex = 9
        '
        'txtfld_NvMDPass
        '
        Me.txtfld_NvMDPass.Location = New System.Drawing.Point(160, 70)
        Me.txtfld_NvMDPass.Name = "txtfld_NvMDPass"
        Me.txtfld_NvMDPass.Size = New System.Drawing.Size(168, 20)
        Me.txtfld_NvMDPass.TabIndex = 8
        '
        'lbl_NvMDPass
        '
        Me.lbl_NvMDPass.AutoSize = True
        Me.lbl_NvMDPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NvMDPass.Location = New System.Drawing.Point(28, 74)
        Me.lbl_NvMDPass.Name = "lbl_NvMDPass"
        Me.lbl_NvMDPass.Size = New System.Drawing.Size(90, 16)
        Me.lbl_NvMDPass.TabIndex = 6
        Me.lbl_NvMDPass.Text = "Mot de passe"
        '
        'txtfld_NvUtil
        '
        Me.txtfld_NvUtil.Location = New System.Drawing.Point(160, 28)
        Me.txtfld_NvUtil.Name = "txtfld_NvUtil"
        Me.txtfld_NvUtil.Size = New System.Drawing.Size(168, 20)
        Me.txtfld_NvUtil.TabIndex = 7
        '
        'lbl_NvUtil
        '
        Me.lbl_NvUtil.AutoSize = True
        Me.lbl_NvUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NvUtil.Location = New System.Drawing.Point(28, 32)
        Me.lbl_NvUtil.Name = "lbl_NvUtil"
        Me.lbl_NvUtil.Size = New System.Drawing.Size(107, 16)
        Me.lbl_NvUtil.TabIndex = 6
        Me.lbl_NvUtil.Text = "Nom d'utilisateur"
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Abonnet)
        Me.Controls.Add(Me.pnl_NvUtil)
        Me.Controls.Add(Me.pnl_Connexion)
        Me.Controls.Add(Me.Pnl_Inscription)
        Me.Name = "LoginScreen"
        Me.Text = "LoginScreen"
        Me.pnl_Connexion.ResumeLayout(False)
        Me.pnl_Connexion.PerformLayout()
        Me.pnl_NvUtil.ResumeLayout(False)
        Me.pnl_NvUtil.PerformLayout()
        Me.Pnl_Inscription.ResumeLayout(False)
        Me.Pnl_Inscription.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtfld_NomUtil As TextBox
    Friend WithEvents txtfld_MDPass As TextBox
    Friend WithEvents btn_Connection As Button
    Friend WithEvents pnl_Connexion As Panel
    Friend WithEvents lbl_MDPass As Label
    Friend WithEvents lbl_Utilisateur As Label
    Friend WithEvents pnl_NvUtil As Panel
    Friend WithEvents link_Oubli As LinkLabel
    Friend WithEvents Lbl_Abonnet As Label
    Friend WithEvents btn_Creation As Button
    Friend WithEvents lbl_NouvUtil As Label
    Friend WithEvents link_Contact As LinkLabel
    Friend WithEvents link_Avantages As LinkLabel
    Friend WithEvents Pnl_Inscription As Panel
    Friend WithEvents lbl_NvMDPassCnf As Label
    Friend WithEvents txtfld_NvMDPassCnf As TextBox
    Friend WithEvents txtfld_NvMDPass As TextBox
    Friend WithEvents lbl_NvMDPass As Label
    Friend WithEvents txtfld_NvUtil As TextBox
    Friend WithEvents lbl_NvUtil As Label
    Friend WithEvents btn_SInscrire As Button
    Friend WithEvents btn_Annuler As Button
End Class
