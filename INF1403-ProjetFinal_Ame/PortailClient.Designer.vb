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
        Me.Lb_Titre = New System.Windows.Forms.Label()
        Me.MenuStripPortailClient = New System.Windows.Forms.MenuStrip()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnItem_MonProfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnItem_Aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPortailClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_ClientNouvelleLocation
        '
        Me.Btn_ClientNouvelleLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientNouvelleLocation.Location = New System.Drawing.Point(132, 203)
        Me.Btn_ClientNouvelleLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ClientNouvelleLocation.Name = "Btn_ClientNouvelleLocation"
        Me.Btn_ClientNouvelleLocation.Size = New System.Drawing.Size(219, 92)
        Me.Btn_ClientNouvelleLocation.TabIndex = 0
        Me.Btn_ClientNouvelleLocation.Text = "Nouvelle Location"
        Me.Btn_ClientNouvelleLocation.UseVisualStyleBackColor = True
        '
        'Btn_ClientMesContrats
        '
        Me.Btn_ClientMesContrats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientMesContrats.Location = New System.Drawing.Point(408, 203)
        Me.Btn_ClientMesContrats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ClientMesContrats.Name = "Btn_ClientMesContrats"
        Me.Btn_ClientMesContrats.Size = New System.Drawing.Size(219, 92)
        Me.Btn_ClientMesContrats.TabIndex = 1
        Me.Btn_ClientMesContrats.Text = "Mes contrats"
        Me.Btn_ClientMesContrats.UseVisualStyleBackColor = True
        '
        'Btn_RecuImpot
        '
        Me.Btn_RecuImpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RecuImpot.Location = New System.Drawing.Point(684, 203)
        Me.Btn_RecuImpot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_RecuImpot.Name = "Btn_RecuImpot"
        Me.Btn_RecuImpot.Size = New System.Drawing.Size(219, 92)
        Me.Btn_RecuImpot.TabIndex = 2
        Me.Btn_RecuImpot.Text = "Mes reçus d'impôt"
        Me.Btn_RecuImpot.UseVisualStyleBackColor = True
        '
        'Lb_Titre
        '
        Me.Lb_Titre.AutoSize = True
        Me.Lb_Titre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Lb_Titre.Location = New System.Drawing.Point(125, 91)
        Me.Lb_Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Titre.Name = "Lb_Titre"
        Me.Lb_Titre.Size = New System.Drawing.Size(186, 37)
        Me.Lb_Titre.TabIndex = 3
        Me.Lb_Titre.Text = "Portail Client"
        '
        'MenuStripPortailClient
        '
        Me.MenuStripPortailClient.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStripPortailClient.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.MenuStripPortailClient.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripPortailClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DéconnexionToolStripMenuItem, Me.MnItem_MonProfil, Me.MnItem_Aide})
        Me.MenuStripPortailClient.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPortailClient.Name = "MenuStripPortailClient"
        Me.MenuStripPortailClient.Padding = New System.Windows.Forms.Padding(12, 9, 12, 11)
        Me.MenuStripPortailClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStripPortailClient.Size = New System.Drawing.Size(1059, 49)
        Me.MenuStripPortailClient.TabIndex = 4
        Me.MenuStripPortailClient.Text = "MenuStripPortailClient"
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
        'PortailClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 436)
        Me.Controls.Add(Me.MenuStripPortailClient)
        Me.Controls.Add(Me.Lb_Titre)
        Me.Controls.Add(Me.Btn_RecuImpot)
        Me.Controls.Add(Me.Btn_ClientMesContrats)
        Me.Controls.Add(Me.Btn_ClientNouvelleLocation)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PortailClient"
        Me.Text = "PortailClient"
        Me.MenuStripPortailClient.ResumeLayout(False)
        Me.MenuStripPortailClient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_ClientNouvelleLocation As Button
    Friend WithEvents Btn_ClientMesContrats As Button
    Friend WithEvents Btn_RecuImpot As Button
    Friend WithEvents Lb_Titre As Label
    Friend WithEvents MenuStripPortailClient As MenuStrip
    Friend WithEvents MnItem_MonProfil As ToolStripMenuItem
    Friend WithEvents MnItem_Aide As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DéconnexionToolStripMenuItem As ToolStripMenuItem
End Class
