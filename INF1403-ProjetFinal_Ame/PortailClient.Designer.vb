<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PortailClient
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
        Me.Btn_ClientNouvelleLocation = New System.Windows.Forms.Button()
        Me.Btn_ClientMesContrats = New System.Windows.Forms.Button()
        Me.Btn_RecuImpot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_ClientNouvelleLocation
        '
        Me.Btn_ClientNouvelleLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientNouvelleLocation.Location = New System.Drawing.Point(227, 189)
        Me.Btn_ClientNouvelleLocation.Name = "Btn_ClientNouvelleLocation"
        Me.Btn_ClientNouvelleLocation.Size = New System.Drawing.Size(218, 92)
        Me.Btn_ClientNouvelleLocation.TabIndex = 0
        Me.Btn_ClientNouvelleLocation.Text = "Nouvelle Location"
        Me.Btn_ClientNouvelleLocation.UseVisualStyleBackColor = True
        '
        'Btn_ClientMesContrats
        '
        Me.Btn_ClientMesContrats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientMesContrats.Location = New System.Drawing.Point(536, 189)
        Me.Btn_ClientMesContrats.Name = "Btn_ClientMesContrats"
        Me.Btn_ClientMesContrats.Size = New System.Drawing.Size(218, 92)
        Me.Btn_ClientMesContrats.TabIndex = 1
        Me.Btn_ClientMesContrats.Text = "Mes contrats"
        Me.Btn_ClientMesContrats.UseVisualStyleBackColor = True
        '
        'Btn_RecuImpot
        '
        Me.Btn_RecuImpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RecuImpot.Location = New System.Drawing.Point(849, 189)
        Me.Btn_RecuImpot.Name = "Btn_RecuImpot"
        Me.Btn_RecuImpot.Size = New System.Drawing.Size(218, 92)
        Me.Btn_RecuImpot.TabIndex = 2
        Me.Btn_RecuImpot.Text = "Mes reçus d'impôt"
        Me.Btn_RecuImpot.UseVisualStyleBackColor = True
        '
        'PortailClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 553)
        Me.Controls.Add(Me.Btn_RecuImpot)
        Me.Controls.Add(Me.Btn_ClientMesContrats)
        Me.Controls.Add(Me.Btn_ClientNouvelleLocation)
        Me.Name = "PortailClient"
        Me.Text = "PortailClient"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_ClientNouvelleLocation As Button
    Friend WithEvents Btn_ClientMesContrats As Button
    Friend WithEvents Btn_RecuImpot As Button
End Class
