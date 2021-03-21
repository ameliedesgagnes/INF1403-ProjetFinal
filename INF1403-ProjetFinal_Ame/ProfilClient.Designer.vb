<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfilClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_ChangerMDPClient = New System.Windows.Forms.Button()
        Me.Lb_MonProfilClient = New System.Windows.Forms.Label()
        Me.Lb_TitleNom = New System.Windows.Forms.Label()
        Me.Lb_TitleCell = New System.Windows.Forms.Label()
        Me.Lb_NomClient = New System.Windows.Forms.Label()
        Me.Lb_CellClient = New System.Windows.Forms.Label()
        Me.Lb_TitleAdresse = New System.Windows.Forms.Label()
        Me.Lb_TitleTypeDeCompte = New System.Windows.Forms.Label()
        Me.Lb_AdresseClient = New System.Windows.Forms.Label()
        Me.Lb_TypeCompteClient = New System.Windows.Forms.Label()
        Me.Btn_ChangerInfoCLient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_ChangerMDPClient
        '
        Me.Btn_ChangerMDPClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ChangerMDPClient.Location = New System.Drawing.Point(12, 396)
        Me.Btn_ChangerMDPClient.Name = "Btn_ChangerMDPClient"
        Me.Btn_ChangerMDPClient.Size = New System.Drawing.Size(362, 50)
        Me.Btn_ChangerMDPClient.TabIndex = 0
        Me.Btn_ChangerMDPClient.Text = "Changer le mot de passe"
        Me.Btn_ChangerMDPClient.UseVisualStyleBackColor = True
        '
        'Lb_MonProfilClient
        '
        Me.Lb_MonProfilClient.AutoSize = True
        Me.Lb_MonProfilClient.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_MonProfilClient.Location = New System.Drawing.Point(47, 78)
        Me.Lb_MonProfilClient.Name = "Lb_MonProfilClient"
        Me.Lb_MonProfilClient.Size = New System.Drawing.Size(158, 38)
        Me.Lb_MonProfilClient.TabIndex = 1
        Me.Lb_MonProfilClient.Text = "Mon Profil"
        '
        'Lb_TitleNom
        '
        Me.Lb_TitleNom.AutoSize = True
        Me.Lb_TitleNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleNom.Location = New System.Drawing.Point(74, 163)
        Me.Lb_TitleNom.Name = "Lb_TitleNom"
        Me.Lb_TitleNom.Size = New System.Drawing.Size(64, 25)
        Me.Lb_TitleNom.TabIndex = 2
        Me.Lb_TitleNom.Text = "Nom :"
        '
        'Lb_TitleCell
        '
        Me.Lb_TitleCell.AutoSize = True
        Me.Lb_TitleCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleCell.Location = New System.Drawing.Point(74, 210)
        Me.Lb_TitleCell.Name = "Lb_TitleCell"
        Me.Lb_TitleCell.Size = New System.Drawing.Size(57, 25)
        Me.Lb_TitleCell.TabIndex = 3
        Me.Lb_TitleCell.Text = "Cell :"
        '
        'Lb_NomClient
        '
        Me.Lb_NomClient.AutoSize = True
        Me.Lb_NomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NomClient.Location = New System.Drawing.Point(152, 163)
        Me.Lb_NomClient.Name = "Lb_NomClient"
        Me.Lb_NomClient.Size = New System.Drawing.Size(19, 25)
        Me.Lb_NomClient.TabIndex = 4
        Me.Lb_NomClient.Text = "-"
        '
        'Lb_CellClient
        '
        Me.Lb_CellClient.AutoSize = True
        Me.Lb_CellClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CellClient.Location = New System.Drawing.Point(152, 210)
        Me.Lb_CellClient.Name = "Lb_CellClient"
        Me.Lb_CellClient.Size = New System.Drawing.Size(19, 25)
        Me.Lb_CellClient.TabIndex = 5
        Me.Lb_CellClient.Text = "-"
        '
        'Lb_TitleAdresse
        '
        Me.Lb_TitleAdresse.AutoSize = True
        Me.Lb_TitleAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleAdresse.Location = New System.Drawing.Point(74, 255)
        Me.Lb_TitleAdresse.Name = "Lb_TitleAdresse"
        Me.Lb_TitleAdresse.Size = New System.Drawing.Size(96, 25)
        Me.Lb_TitleAdresse.TabIndex = 6
        Me.Lb_TitleAdresse.Text = "Adresse :"
        '
        'Lb_TitleTypeDeCompte
        '
        Me.Lb_TitleTypeDeCompte.AutoSize = True
        Me.Lb_TitleTypeDeCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleTypeDeCompte.Location = New System.Drawing.Point(74, 302)
        Me.Lb_TitleTypeDeCompte.Name = "Lb_TitleTypeDeCompte"
        Me.Lb_TitleTypeDeCompte.Size = New System.Drawing.Size(169, 25)
        Me.Lb_TitleTypeDeCompte.TabIndex = 7
        Me.Lb_TitleTypeDeCompte.Text = "Type de Compte :"
        '
        'Lb_AdresseClient
        '
        Me.Lb_AdresseClient.AutoSize = True
        Me.Lb_AdresseClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_AdresseClient.Location = New System.Drawing.Point(186, 255)
        Me.Lb_AdresseClient.Name = "Lb_AdresseClient"
        Me.Lb_AdresseClient.Size = New System.Drawing.Size(19, 25)
        Me.Lb_AdresseClient.TabIndex = 8
        Me.Lb_AdresseClient.Text = "-"
        '
        'Lb_TypeCompteClient
        '
        Me.Lb_TypeCompteClient.AutoSize = True
        Me.Lb_TypeCompteClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TypeCompteClient.Location = New System.Drawing.Point(249, 302)
        Me.Lb_TypeCompteClient.Name = "Lb_TypeCompteClient"
        Me.Lb_TypeCompteClient.Size = New System.Drawing.Size(19, 25)
        Me.Lb_TypeCompteClient.TabIndex = 9
        Me.Lb_TypeCompteClient.Text = "-"
        '
        'Btn_ChangerInfoCLient
        '
        Me.Btn_ChangerInfoCLient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ChangerInfoCLient.Location = New System.Drawing.Point(12, 462)
        Me.Btn_ChangerInfoCLient.Name = "Btn_ChangerInfoCLient"
        Me.Btn_ChangerInfoCLient.Size = New System.Drawing.Size(362, 50)
        Me.Btn_ChangerInfoCLient.TabIndex = 11
        Me.Btn_ChangerInfoCLient.Text = "Changer les informations personnelles"
        Me.Btn_ChangerInfoCLient.UseVisualStyleBackColor = True
        '
        'ProfilClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 553)
        Me.Controls.Add(Me.Btn_ChangerInfoCLient)
        Me.Controls.Add(Me.Lb_TypeCompteClient)
        Me.Controls.Add(Me.Lb_AdresseClient)
        Me.Controls.Add(Me.Lb_TitleTypeDeCompte)
        Me.Controls.Add(Me.Lb_TitleAdresse)
        Me.Controls.Add(Me.Lb_CellClient)
        Me.Controls.Add(Me.Lb_NomClient)
        Me.Controls.Add(Me.Lb_TitleCell)
        Me.Controls.Add(Me.Lb_TitleNom)
        Me.Controls.Add(Me.Lb_MonProfilClient)
        Me.Controls.Add(Me.Btn_ChangerMDPClient)
        Me.Name = "ProfilClient"
        Me.Text = "ProfilClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_ChangerMDPClient As Button
    Friend WithEvents Lb_MonProfilClient As Label
    Friend WithEvents Lb_TitleNom As Label
    Friend WithEvents Lb_TitleCell As Label
    Friend WithEvents Lb_NomClient As Label
    Friend WithEvents Lb_CellClient As Label
    Friend WithEvents Lb_TitleAdresse As Label
    Friend WithEvents Lb_TitleTypeDeCompte As Label
    Friend WithEvents Lb_AdresseClient As Label
    Friend WithEvents Lb_TypeCompteClient As Label
    Friend WithEvents Btn_ChangerInfoCLient As Button
End Class
