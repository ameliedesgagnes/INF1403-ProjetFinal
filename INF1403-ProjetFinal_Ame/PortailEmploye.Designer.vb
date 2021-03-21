<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PortailEmploye
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
        Me.Btn_RapportStats = New System.Windows.Forms.Button()
        Me.Btn_Formation = New System.Windows.Forms.Button()
        Me.Btn_GestionContrat = New System.Windows.Forms.Button()
        Me.Btn_HistoriqueContrat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_RapportStats
        '
        Me.Btn_RapportStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RapportStats.Location = New System.Drawing.Point(678, 188)
        Me.Btn_RapportStats.Name = "Btn_RapportStats"
        Me.Btn_RapportStats.Size = New System.Drawing.Size(218, 92)
        Me.Btn_RapportStats.TabIndex = 5
        Me.Btn_RapportStats.Text = "Rapports et statistiques"
        Me.Btn_RapportStats.UseVisualStyleBackColor = True
        '
        'Btn_Formation
        '
        Me.Btn_Formation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Formation.Location = New System.Drawing.Point(402, 188)
        Me.Btn_Formation.Name = "Btn_Formation"
        Me.Btn_Formation.Size = New System.Drawing.Size(218, 92)
        Me.Btn_Formation.TabIndex = 4
        Me.Btn_Formation.Text = "Formations"
        Me.Btn_Formation.UseVisualStyleBackColor = True
        '
        'Btn_GestionContrat
        '
        Me.Btn_GestionContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GestionContrat.Location = New System.Drawing.Point(116, 188)
        Me.Btn_GestionContrat.Name = "Btn_GestionContrat"
        Me.Btn_GestionContrat.Size = New System.Drawing.Size(218, 92)
        Me.Btn_GestionContrat.TabIndex = 3
        Me.Btn_GestionContrat.Text = "Gestion des contrats actifs"
        Me.Btn_GestionContrat.UseVisualStyleBackColor = True
        '
        'Btn_HistoriqueContrat
        '
        Me.Btn_HistoriqueContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_HistoriqueContrat.Location = New System.Drawing.Point(958, 188)
        Me.Btn_HistoriqueContrat.Name = "Btn_HistoriqueContrat"
        Me.Btn_HistoriqueContrat.Size = New System.Drawing.Size(218, 92)
        Me.Btn_HistoriqueContrat.TabIndex = 6
        Me.Btn_HistoriqueContrat.Text = "Historique des contrats"
        Me.Btn_HistoriqueContrat.UseVisualStyleBackColor = True
        '
        'PortailEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 553)
        Me.Controls.Add(Me.Btn_HistoriqueContrat)
        Me.Controls.Add(Me.Btn_RapportStats)
        Me.Controls.Add(Me.Btn_Formation)
        Me.Controls.Add(Me.Btn_GestionContrat)
        Me.Name = "PortailEmploye"
        Me.Text = "PortailClient"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_RapportStats As Button
    Friend WithEvents Btn_Formation As Button
    Friend WithEvents Btn_GestionContrat As Button
    Friend WithEvents Btn_HistoriqueContrat As Button
End Class
