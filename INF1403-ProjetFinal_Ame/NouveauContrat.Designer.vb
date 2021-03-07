<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouveauContrat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbCodeClient = New System.Windows.Forms.Label()
        Me.LbNouveauContrat = New System.Windows.Forms.Label()
        Me.LbDateDebut = New System.Windows.Forms.Label()
        Me.LbDateFin = New System.Windows.Forms.Label()
        Me.TxtBoxCodeClient = New System.Windows.Forms.TextBox()
        Me.TxtBoxDateDebut = New System.Windows.Forms.TextBox()
        Me.TxtBoxDateFin = New System.Windows.Forms.TextBox()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.LbIdContrat = New System.Windows.Forms.Label()
        Me.TxtBoxIdContrat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LbCodeClient
        '
        Me.LbCodeClient.AutoSize = True
        Me.LbCodeClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodeClient.Location = New System.Drawing.Point(48, 128)
        Me.LbCodeClient.Name = "LbCodeClient"
        Me.LbCodeClient.Size = New System.Drawing.Size(91, 20)
        Me.LbCodeClient.TabIndex = 0
        Me.LbCodeClient.Text = "Code Client"
        '
        'LbNouveauContrat
        '
        Me.LbNouveauContrat.AutoSize = True
        Me.LbNouveauContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNouveauContrat.Location = New System.Drawing.Point(50, 30)
        Me.LbNouveauContrat.Name = "LbNouveauContrat"
        Me.LbNouveauContrat.Size = New System.Drawing.Size(151, 24)
        Me.LbNouveauContrat.TabIndex = 1
        Me.LbNouveauContrat.Text = "Nouveau Contrat"
        '
        'LbDateDebut
        '
        Me.LbDateDebut.AutoSize = True
        Me.LbDateDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateDebut.Location = New System.Drawing.Point(50, 173)
        Me.LbDateDebut.Name = "LbDateDebut"
        Me.LbDateDebut.Size = New System.Drawing.Size(92, 20)
        Me.LbDateDebut.TabIndex = 2
        Me.LbDateDebut.Text = "Date Début"
        '
        'LbDateFin
        '
        Me.LbDateFin.AutoSize = True
        Me.LbDateFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateFin.Location = New System.Drawing.Point(50, 223)
        Me.LbDateFin.Name = "LbDateFin"
        Me.LbDateFin.Size = New System.Drawing.Size(70, 20)
        Me.LbDateFin.TabIndex = 3
        Me.LbDateFin.Text = "Date Fin"
        '
        'TxtBoxCodeClient
        '
        Me.TxtBoxCodeClient.Location = New System.Drawing.Point(175, 128)
        Me.TxtBoxCodeClient.Name = "TxtBoxCodeClient"
        Me.TxtBoxCodeClient.Size = New System.Drawing.Size(204, 20)
        Me.TxtBoxCodeClient.TabIndex = 4
        '
        'TxtBoxDateDebut
        '
        Me.TxtBoxDateDebut.Location = New System.Drawing.Point(175, 175)
        Me.TxtBoxDateDebut.Name = "TxtBoxDateDebut"
        Me.TxtBoxDateDebut.Size = New System.Drawing.Size(204, 20)
        Me.TxtBoxDateDebut.TabIndex = 5
        '
        'TxtBoxDateFin
        '
        Me.TxtBoxDateFin.Location = New System.Drawing.Point(175, 223)
        Me.TxtBoxDateFin.Name = "TxtBoxDateFin"
        Me.TxtBoxDateFin.Size = New System.Drawing.Size(204, 20)
        Me.TxtBoxDateFin.TabIndex = 6
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjouter.Location = New System.Drawing.Point(54, 286)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(325, 44)
        Me.BtnAjouter.TabIndex = 7
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'LbIdContrat
        '
        Me.LbIdContrat.AutoSize = True
        Me.LbIdContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdContrat.Location = New System.Drawing.Point(48, 85)
        Me.LbIdContrat.Name = "LbIdContrat"
        Me.LbIdContrat.Size = New System.Drawing.Size(83, 20)
        Me.LbIdContrat.TabIndex = 8
        Me.LbIdContrat.Text = "ID Contrat"
        '
        'TxtBoxIdContrat
        '
        Me.TxtBoxIdContrat.Location = New System.Drawing.Point(175, 85)
        Me.TxtBoxIdContrat.Name = "TxtBoxIdContrat"
        Me.TxtBoxIdContrat.Size = New System.Drawing.Size(204, 20)
        Me.TxtBoxIdContrat.TabIndex = 9
        '
        'Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 382)
        Me.Controls.Add(Me.TxtBoxIdContrat)
        Me.Controls.Add(Me.LbIdContrat)
        Me.Controls.Add(Me.BtnAjouter)
        Me.Controls.Add(Me.TxtBoxDateFin)
        Me.Controls.Add(Me.TxtBoxDateDebut)
        Me.Controls.Add(Me.TxtBoxCodeClient)
        Me.Controls.Add(Me.LbDateFin)
        Me.Controls.Add(Me.LbDateDebut)
        Me.Controls.Add(Me.LbNouveauContrat)
        Me.Controls.Add(Me.LbCodeClient)
        Me.Name = "Contrat"
        Me.Text = "ContractInstance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCodeClient As Label
    Friend WithEvents LbNouveauContrat As Label
    Friend WithEvents LbDateDebut As Label
    Friend WithEvents LbDateFin As Label
    Friend WithEvents TxtBoxCodeClient As TextBox
    Friend WithEvents TxtBoxDateDebut As TextBox
    Friend WithEvents TxtBoxDateFin As TextBox
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents LbIdContrat As Label
    Friend WithEvents TxtBoxIdContrat As TextBox
End Class
