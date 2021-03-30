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
        Me.Mn_navig = New System.Windows.Forms.MenuStrip()
        Me.MnItem_MonProfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnItem_Aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mn_navig.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_ClientNouvelleLocation
        '
        Me.Btn_ClientNouvelleLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientNouvelleLocation.Location = New System.Drawing.Point(99, 165)
        Me.Btn_ClientNouvelleLocation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_ClientNouvelleLocation.Name = "Btn_ClientNouvelleLocation"
        Me.Btn_ClientNouvelleLocation.Size = New System.Drawing.Size(164, 75)
        Me.Btn_ClientNouvelleLocation.TabIndex = 0
        Me.Btn_ClientNouvelleLocation.Text = "Nouvelle Location"
        Me.Btn_ClientNouvelleLocation.UseVisualStyleBackColor = True
        '
        'Btn_ClientMesContrats
        '
        Me.Btn_ClientMesContrats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ClientMesContrats.Location = New System.Drawing.Point(306, 165)
        Me.Btn_ClientMesContrats.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_ClientMesContrats.Name = "Btn_ClientMesContrats"
        Me.Btn_ClientMesContrats.Size = New System.Drawing.Size(164, 75)
        Me.Btn_ClientMesContrats.TabIndex = 1
        Me.Btn_ClientMesContrats.Text = "Mes contrats"
        Me.Btn_ClientMesContrats.UseVisualStyleBackColor = True
        '
        'Btn_RecuImpot
        '
        Me.Btn_RecuImpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RecuImpot.Location = New System.Drawing.Point(513, 165)
        Me.Btn_RecuImpot.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_RecuImpot.Name = "Btn_RecuImpot"
        Me.Btn_RecuImpot.Size = New System.Drawing.Size(164, 75)
        Me.Btn_RecuImpot.TabIndex = 2
        Me.Btn_RecuImpot.Text = "Mes reçus d'impôt"
        Me.Btn_RecuImpot.UseVisualStyleBackColor = True
        '
        'Lb_Titre
        '
        Me.Lb_Titre.AutoSize = True
        Me.Lb_Titre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Lb_Titre.Location = New System.Drawing.Point(94, 74)
        Me.Lb_Titre.Name = "Lb_Titre"
        Me.Lb_Titre.Size = New System.Drawing.Size(141, 30)
        Me.Lb_Titre.TabIndex = 3
        Me.Lb_Titre.Text = "Portail Client"
        '
        'Mn_navig
        '
        Me.Mn_navig.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Mn_navig.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Mn_navig.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Mn_navig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnItem_MonProfil, Me.MnItem_Aide})
        Me.Mn_navig.Location = New System.Drawing.Point(0, 0)
        Me.Mn_navig.Name = "Mn_navig"
        Me.Mn_navig.Padding = New System.Windows.Forms.Padding(9, 7, 9, 9)
        Me.Mn_navig.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mn_navig.Size = New System.Drawing.Size(794, 40)
        Me.Mn_navig.TabIndex = 4
        Me.Mn_navig.Text = "MenuStrip1"
        '
        'MnItem_MonProfil
        '
        Me.MnItem_MonProfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MnItem_MonProfil.ForeColor = System.Drawing.Color.Snow
        Me.MnItem_MonProfil.Name = "MnItem_MonProfil"
        Me.MnItem_MonProfil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MnItem_MonProfil.RightToLeftAutoMirrorImage = True
        Me.MnItem_MonProfil.Size = New System.Drawing.Size(95, 24)
        Me.MnItem_MonProfil.Text = "Mon Profil"
        '
        'MnItem_Aide
        '
        Me.MnItem_Aide.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.MnItem_Aide.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MnItem_Aide.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MnItem_Aide.Name = "MnItem_Aide"
        Me.MnItem_Aide.Size = New System.Drawing.Size(53, 24)
        Me.MnItem_Aide.Text = "&Aide"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(138, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'PortailClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 354)
        Me.Controls.Add(Me.Mn_navig)
        Me.Controls.Add(Me.Lb_Titre)
        Me.Controls.Add(Me.Btn_RecuImpot)
        Me.Controls.Add(Me.Btn_ClientMesContrats)
        Me.Controls.Add(Me.Btn_ClientNouvelleLocation)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PortailClient"
        Me.Text = "PortailClient"
        Me.Mn_navig.ResumeLayout(False)
        Me.Mn_navig.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_ClientNouvelleLocation As Button
    Friend WithEvents Btn_ClientMesContrats As Button
    Friend WithEvents Btn_RecuImpot As Button
    Friend WithEvents Lb_Titre As Label
    Friend WithEvents Mn_navig As MenuStrip
    Friend WithEvents MnItem_MonProfil As ToolStripMenuItem
    Friend WithEvents MnItem_Aide As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
