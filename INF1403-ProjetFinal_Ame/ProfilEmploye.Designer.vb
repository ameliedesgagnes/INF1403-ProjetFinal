<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfilEmploye
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
        Me.Lb_CellEmploye = New System.Windows.Forms.Label()
        Me.Lb_NomEmploye = New System.Windows.Forms.Label()
        Me.Lb_TitleCell = New System.Windows.Forms.Label()
        Me.Lb_TitleNom = New System.Windows.Forms.Label()
        Me.Lb_MonProfilEmploye = New System.Windows.Forms.Label()
        Me.Btn_ChangerInfoEmploye = New System.Windows.Forms.Button()
        Me.Btn_ChangerMDPEmploye = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_CellEmploye
        '
        Me.Lb_CellEmploye.AutoSize = True
        Me.Lb_CellEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CellEmploye.Location = New System.Drawing.Point(152, 210)
        Me.Lb_CellEmploye.Name = "Lb_CellEmploye"
        Me.Lb_CellEmploye.Size = New System.Drawing.Size(19, 25)
        Me.Lb_CellEmploye.TabIndex = 15
        Me.Lb_CellEmploye.Text = "-"
        '
        'Lb_NomEmploye
        '
        Me.Lb_NomEmploye.AutoSize = True
        Me.Lb_NomEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NomEmploye.Location = New System.Drawing.Point(152, 163)
        Me.Lb_NomEmploye.Name = "Lb_NomEmploye"
        Me.Lb_NomEmploye.Size = New System.Drawing.Size(19, 25)
        Me.Lb_NomEmploye.TabIndex = 14
        Me.Lb_NomEmploye.Text = "-"
        '
        'Lb_TitleCell
        '
        Me.Lb_TitleCell.AutoSize = True
        Me.Lb_TitleCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleCell.Location = New System.Drawing.Point(74, 210)
        Me.Lb_TitleCell.Name = "Lb_TitleCell"
        Me.Lb_TitleCell.Size = New System.Drawing.Size(57, 25)
        Me.Lb_TitleCell.TabIndex = 13
        Me.Lb_TitleCell.Text = "Cell :"
        '
        'Lb_TitleNom
        '
        Me.Lb_TitleNom.AutoSize = True
        Me.Lb_TitleNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitleNom.Location = New System.Drawing.Point(74, 163)
        Me.Lb_TitleNom.Name = "Lb_TitleNom"
        Me.Lb_TitleNom.Size = New System.Drawing.Size(64, 25)
        Me.Lb_TitleNom.TabIndex = 12
        Me.Lb_TitleNom.Text = "Nom :"
        '
        'Lb_MonProfilEmploye
        '
        Me.Lb_MonProfilEmploye.AutoSize = True
        Me.Lb_MonProfilEmploye.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_MonProfilEmploye.Location = New System.Drawing.Point(47, 78)
        Me.Lb_MonProfilEmploye.Name = "Lb_MonProfilEmploye"
        Me.Lb_MonProfilEmploye.Size = New System.Drawing.Size(158, 38)
        Me.Lb_MonProfilEmploye.TabIndex = 11
        Me.Lb_MonProfilEmploye.Text = "Mon Profil"
        '
        'Btn_ChangerInfoEmploye
        '
        Me.Btn_ChangerInfoEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ChangerInfoEmploye.Location = New System.Drawing.Point(12, 462)
        Me.Btn_ChangerInfoEmploye.Name = "Btn_ChangerInfoEmploye"
        Me.Btn_ChangerInfoEmploye.Size = New System.Drawing.Size(362, 50)
        Me.Btn_ChangerInfoEmploye.TabIndex = 10
        Me.Btn_ChangerInfoEmploye.Text = "Changer les informations personnelles"
        Me.Btn_ChangerInfoEmploye.UseVisualStyleBackColor = True
        '
        'Btn_ChangerMDPEmploye
        '
        Me.Btn_ChangerMDPEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ChangerMDPEmploye.Location = New System.Drawing.Point(12, 396)
        Me.Btn_ChangerMDPEmploye.Name = "Btn_ChangerMDPEmploye"
        Me.Btn_ChangerMDPEmploye.Size = New System.Drawing.Size(362, 50)
        Me.Btn_ChangerMDPEmploye.TabIndex = 16
        Me.Btn_ChangerMDPEmploye.Text = "Changer le mot de passe"
        Me.Btn_ChangerMDPEmploye.UseVisualStyleBackColor = True
        '
        'ProfilEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 553)
        Me.Controls.Add(Me.Btn_ChangerMDPEmploye)
        Me.Controls.Add(Me.Lb_CellEmploye)
        Me.Controls.Add(Me.Lb_NomEmploye)
        Me.Controls.Add(Me.Lb_TitleCell)
        Me.Controls.Add(Me.Lb_TitleNom)
        Me.Controls.Add(Me.Lb_MonProfilEmploye)
        Me.Controls.Add(Me.Btn_ChangerInfoEmploye)
        Me.Name = "ProfilEmploye"
        Me.Text = "ProfilEmploye"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_CellEmploye As Label
    Friend WithEvents Lb_NomEmploye As Label
    Friend WithEvents Lb_TitleCell As Label
    Friend WithEvents Lb_TitleNom As Label
    Friend WithEvents Lb_MonProfilEmploye As Label
    Friend WithEvents Btn_ChangerInfoEmploye As Button
    Friend WithEvents Btn_ChangerMDPEmploye As Button
End Class
