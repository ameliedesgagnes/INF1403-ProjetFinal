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
        Me.txtfld_Username = New System.Windows.Forms.TextBox()
        Me.txtfld_Password = New System.Windows.Forms.TextBox()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.pnl_NewUser = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btn_SignUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pnl_Inscription = New System.Windows.Forms.Panel()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfld_NewPassCnf = New System.Windows.Forms.TextBox()
        Me.txtfld_NewPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfld_NewUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_NewUser.SuspendLayout()
        Me.Pnl_Inscription.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfld_Username
        '
        Me.txtfld_Username.Location = New System.Drawing.Point(184, 54)
        Me.txtfld_Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfld_Username.Name = "txtfld_Username"
        Me.txtfld_Username.Size = New System.Drawing.Size(223, 22)
        Me.txtfld_Username.TabIndex = 0
        '
        'txtfld_Password
        '
        Me.txtfld_Password.Location = New System.Drawing.Point(184, 137)
        Me.txtfld_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfld_Password.Name = "txtfld_Password"
        Me.txtfld_Password.Size = New System.Drawing.Size(223, 22)
        Me.txtfld_Password.TabIndex = 1
        '
        'btn_Connect
        '
        Me.btn_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Connect.Location = New System.Drawing.Point(151, 260)
        Me.btn_Connect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(156, 43)
        Me.btn_Connect.TabIndex = 2
        Me.btn_Connect.Text = "Connexion"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.lbl_Password)
        Me.Panel1.Controls.Add(Me.lbl_Username)
        Me.Panel1.Controls.Add(Me.txtfld_Username)
        Me.Panel1.Controls.Add(Me.btn_Connect)
        Me.Panel1.Controls.Add(Me.txtfld_Password)
        Me.Panel1.Location = New System.Drawing.Point(41, 118)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 346)
        Me.Panel1.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(249, 165)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 17)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Identifications oubliées?"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(56, 142)
        Me.lbl_Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(110, 20)
        Me.lbl_Password.TabIndex = 4
        Me.lbl_Password.Text = "Mot de passe"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(33, 54)
        Me.lbl_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(135, 20)
        Me.lbl_Username.TabIndex = 3
        Me.lbl_Username.Text = "Nom d'utilisateur"
        '
        'pnl_NewUser
        '
        Me.pnl_NewUser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnl_NewUser.Controls.Add(Me.LinkLabel3)
        Me.pnl_NewUser.Controls.Add(Me.LinkLabel2)
        Me.pnl_NewUser.Controls.Add(Me.btn_SignUp)
        Me.pnl_NewUser.Controls.Add(Me.Label2)
        Me.pnl_NewUser.Location = New System.Drawing.Point(544, 36)
        Me.pnl_NewUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_NewUser.Name = "pnl_NewUser"
        Me.pnl_NewUser.Size = New System.Drawing.Size(477, 224)
        Me.pnl_NewUser.TabIndex = 4
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(37, 111)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(123, 20)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Nous contacter"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(37, 59)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(153, 20)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Avantages Abonnet"
        '
        'btn_SignUp
        '
        Me.btn_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUp.Location = New System.Drawing.Point(300, 155)
        Me.btn_SignUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_SignUp.Name = "btn_SignUp"
        Me.btn_SignUp.Size = New System.Drawing.Size(120, 39)
        Me.btn_SignUp.TabIndex = 1
        Me.btn_SignUp.Text = "S'inscrire"
        Me.btn_SignUp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nouvel Utilisateur?"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 78)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ABONNET"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_Inscription
        '
        Me.Pnl_Inscription.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pnl_Inscription.Controls.Add(Me.btn_Annuler)
        Me.Pnl_Inscription.Controls.Add(Me.Button2)
        Me.Pnl_Inscription.Controls.Add(Me.Label5)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NewPassCnf)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NewPass)
        Me.Pnl_Inscription.Controls.Add(Me.Label4)
        Me.Pnl_Inscription.Controls.Add(Me.txtfld_NewUser)
        Me.Pnl_Inscription.Controls.Add(Me.Label3)
        Me.Pnl_Inscription.Location = New System.Drawing.Point(544, 36)
        Me.Pnl_Inscription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pnl_Inscription.Name = "Pnl_Inscription"
        Me.Pnl_Inscription.Size = New System.Drawing.Size(477, 428)
        Me.Pnl_Inscription.TabIndex = 6
        Me.Pnl_Inscription.Visible = False
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annuler.Location = New System.Drawing.Point(49, 342)
        Me.btn_Annuler.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(156, 43)
        Me.btn_Annuler.TabIndex = 12
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(264, 342)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "S'inscrire!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "(saisir à nouveau)"
        '
        'txtfld_NewPassCnf
        '
        Me.txtfld_NewPassCnf.Location = New System.Drawing.Point(213, 140)
        Me.txtfld_NewPassCnf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfld_NewPassCnf.Name = "txtfld_NewPassCnf"
        Me.txtfld_NewPassCnf.Size = New System.Drawing.Size(223, 22)
        Me.txtfld_NewPassCnf.TabIndex = 9
        '
        'txtfld_NewPass
        '
        Me.txtfld_NewPass.Location = New System.Drawing.Point(213, 86)
        Me.txtfld_NewPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfld_NewPass.Name = "txtfld_NewPass"
        Me.txtfld_NewPass.Size = New System.Drawing.Size(223, 22)
        Me.txtfld_NewPass.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mot de passe"
        '
        'txtfld_NewUser
        '
        Me.txtfld_NewUser.Location = New System.Drawing.Point(213, 34)
        Me.txtfld_NewUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfld_NewUser.Name = "txtfld_NewUser"
        Me.txtfld_NewUser.Size = New System.Drawing.Size(223, 22)
        Me.txtfld_NewUser.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nom d'utilisateur"
        '
        'LoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnl_NewUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pnl_Inscription)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LoginScreen"
        Me.Text = "LoginScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_NewUser.ResumeLayout(False)
        Me.pnl_NewUser.PerformLayout()
        Me.Pnl_Inscription.ResumeLayout(False)
        Me.Pnl_Inscription.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtfld_Username As TextBox
    Friend WithEvents txtfld_Password As TextBox
    Friend WithEvents btn_Connect As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents pnl_NewUser As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_SignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Pnl_Inscription As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfld_NewPassCnf As TextBox
    Friend WithEvents txtfld_NewPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfld_NewUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_Annuler As Button
End Class
