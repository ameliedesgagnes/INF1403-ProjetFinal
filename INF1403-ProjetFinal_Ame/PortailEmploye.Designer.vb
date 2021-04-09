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
        Me.MenuStripPortailEmploye = New System.Windows.Forms.MenuStrip()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnItem_MonProfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnItem_Aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lb_Titre = New System.Windows.Forms.Label()
        Me.MenuStripPortailEmploye.SuspendLayout()
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
        'MenuStripPortailEmploye
        '
        Me.MenuStripPortailEmploye.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStripPortailEmploye.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.MenuStripPortailEmploye.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripPortailEmploye.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DéconnexionToolStripMenuItem, Me.MnItem_MonProfil, Me.MnItem_Aide})
        Me.MenuStripPortailEmploye.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPortailEmploye.Name = "MenuStripPortailEmploye"
        Me.MenuStripPortailEmploye.Padding = New System.Windows.Forms.Padding(12, 9, 12, 11)
        Me.MenuStripPortailEmploye.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStripPortailEmploye.Size = New System.Drawing.Size(1327, 49)
        Me.MenuStripPortailEmploye.TabIndex = 7
        Me.MenuStripPortailEmploye.Text = "MenuStripPortailEmployer"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(137, 29)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'MnItem_MonProfil
        '
        Me.MnItem_MonProfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MnItem_MonProfil.ForeColor = System.Drawing.Color.Snow
        Me.MnItem_MonProfil.Name = "MnItem_MonProfil"
        Me.MnItem_MonProfil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MnItem_MonProfil.RightToLeftAutoMirrorImage = True
        Me.MnItem_MonProfil.Size = New System.Drawing.Size(122, 29)
        Me.MnItem_MonProfil.Text = "Mon Profil"
        '
        'MnItem_Aide
        '
        Me.MnItem_Aide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.MnItem_Aide.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MnItem_Aide.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MnItem_Aide.Name = "MnItem_Aide"
        Me.MnItem_Aide.Size = New System.Drawing.Size(66, 29)
        Me.MnItem_Aide.Text = "&Aide"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(175, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(178, 30)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'Lb_Titre
        '
        Me.Lb_Titre.AutoSize = True
        Me.Lb_Titre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Lb_Titre.Location = New System.Drawing.Point(118, 91)
        Me.Lb_Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Titre.Name = "Lb_Titre"
        Me.Lb_Titre.Size = New System.Drawing.Size(222, 37)
        Me.Lb_Titre.TabIndex = 8
        Me.Lb_Titre.Text = "Portail Employe"
        '
        'PortailEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 553)
        Me.Controls.Add(Me.Lb_Titre)
        Me.Controls.Add(Me.MenuStripPortailEmploye)
        Me.Controls.Add(Me.Btn_HistoriqueContrat)
        Me.Controls.Add(Me.Btn_RapportStats)
        Me.Controls.Add(Me.Btn_Formation)
        Me.Controls.Add(Me.Btn_GestionContrat)
        Me.Name = "PortailEmploye"
        Me.Text = "PortailEmploye"
        Me.MenuStripPortailEmploye.ResumeLayout(False)
        Me.MenuStripPortailEmploye.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_RapportStats As Button
    Friend WithEvents Btn_Formation As Button
    Friend WithEvents Btn_GestionContrat As Button
    Friend WithEvents Btn_HistoriqueContrat As Button
    Friend WithEvents MenuStripPortailEmploye As MenuStrip
    Friend WithEvents DéconnexionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnItem_MonProfil As ToolStripMenuItem
    Friend WithEvents MnItem_Aide As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lb_Titre As Label
End Class
