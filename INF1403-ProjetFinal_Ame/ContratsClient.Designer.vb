<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratsClient
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnItem_MonProfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mn_navig = New System.Windows.Forms.MenuStrip()
        Me.MnItem_Aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lb_Contrats = New System.Windows.Forms.Label()
        Me.Btn_NouveauContrat = New System.Windows.Forms.Button()
        Me.Tb_Contrats = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckB2 = New System.Windows.Forms.CheckBox()
        Me.CheckB1 = New System.Windows.Forms.CheckBox()
        Me.CheckB3 = New System.Windows.Forms.CheckBox()
        Me.Btn_Consulter = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_Resilier = New System.Windows.Forms.Button()
        Me.Mn_navig.SuspendLayout()
        Me.Tb_Contrats.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.OwnerItem = Me.MnItem_MonProfil
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MnItem_MonProfil
        '
        Me.MnItem_MonProfil.DropDown = Me.ContextMenuStrip1
        Me.MnItem_MonProfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.MnItem_MonProfil.ForeColor = System.Drawing.Color.Snow
        Me.MnItem_MonProfil.Name = "MnItem_MonProfil"
        Me.MnItem_MonProfil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MnItem_MonProfil.RightToLeftAutoMirrorImage = True
        Me.MnItem_MonProfil.Size = New System.Drawing.Size(95, 24)
        Me.MnItem_MonProfil.Text = "Mon Profil"
        '
        'Mn_navig
        '
        Me.Mn_navig.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Mn_navig.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Mn_navig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnItem_MonProfil, Me.MnItem_Aide})
        Me.Mn_navig.Location = New System.Drawing.Point(0, 0)
        Me.Mn_navig.Name = "Mn_navig"
        Me.Mn_navig.Padding = New System.Windows.Forms.Padding(9, 7, 9, 9)
        Me.Mn_navig.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mn_navig.Size = New System.Drawing.Size(638, 40)
        Me.Mn_navig.TabIndex = 1
        Me.Mn_navig.Text = "MenuStrip1"
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
        'Lb_Contrats
        '
        Me.Lb_Contrats.AutoSize = True
        Me.Lb_Contrats.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Lb_Contrats.Location = New System.Drawing.Point(35, 63)
        Me.Lb_Contrats.Name = "Lb_Contrats"
        Me.Lb_Contrats.Size = New System.Drawing.Size(96, 30)
        Me.Lb_Contrats.TabIndex = 2
        Me.Lb_Contrats.Text = "Contrats"
        '
        'Btn_NouveauContrat
        '
        Me.Btn_NouveauContrat.Location = New System.Drawing.Point(54, 120)
        Me.Btn_NouveauContrat.Name = "Btn_NouveauContrat"
        Me.Btn_NouveauContrat.Size = New System.Drawing.Size(81, 29)
        Me.Btn_NouveauContrat.TabIndex = 3
        Me.Btn_NouveauContrat.Text = "Nouveau"
        Me.Btn_NouveauContrat.UseVisualStyleBackColor = True
        '
        'Tb_Contrats
        '
        Me.Tb_Contrats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb_Contrats.ColumnCount = 2
        Me.Tb_Contrats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.287356!))
        Me.Tb_Contrats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.71265!))
        Me.Tb_Contrats.Controls.Add(Me.CheckB2, 0, 1)
        Me.Tb_Contrats.Controls.Add(Me.CheckB1, 0, 0)
        Me.Tb_Contrats.Controls.Add(Me.CheckB3, 0, 2)
        Me.Tb_Contrats.Location = New System.Drawing.Point(54, 177)
        Me.Tb_Contrats.Name = "Tb_Contrats"
        Me.Tb_Contrats.RowCount = 3
        Me.Tb_Contrats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Tb_Contrats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Tb_Contrats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.Tb_Contrats.Size = New System.Drawing.Size(435, 82)
        Me.Tb_Contrats.TabIndex = 4
        '
        'CheckB2
        '
        Me.CheckB2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckB2.AutoSize = True
        Me.CheckB2.Location = New System.Drawing.Point(3, 29)
        Me.CheckB2.Name = "CheckB2"
        Me.CheckB2.Size = New System.Drawing.Size(17, 20)
        Me.CheckB2.TabIndex = 2
        Me.CheckB2.UseVisualStyleBackColor = True
        '
        'CheckB1
        '
        Me.CheckB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckB1.AutoSize = True
        Me.CheckB1.Location = New System.Drawing.Point(3, 3)
        Me.CheckB1.Name = "CheckB1"
        Me.CheckB1.Size = New System.Drawing.Size(17, 20)
        Me.CheckB1.TabIndex = 0
        Me.CheckB1.UseVisualStyleBackColor = True
        '
        'CheckB3
        '
        Me.CheckB3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckB3.AutoSize = True
        Me.CheckB3.Location = New System.Drawing.Point(3, 55)
        Me.CheckB3.Name = "CheckB3"
        Me.CheckB3.Size = New System.Drawing.Size(17, 24)
        Me.CheckB3.TabIndex = 1
        Me.CheckB3.UseVisualStyleBackColor = True
        '
        'Btn_Consulter
        '
        Me.Btn_Consulter.Location = New System.Drawing.Point(165, 120)
        Me.Btn_Consulter.Name = "Btn_Consulter"
        Me.Btn_Consulter.Size = New System.Drawing.Size(81, 29)
        Me.Btn_Consulter.TabIndex = 5
        Me.Btn_Consulter.Text = "Consulter"
        Me.Btn_Consulter.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.Location = New System.Drawing.Point(279, 120)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(81, 29)
        Me.Btn_Modifier.TabIndex = 6
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = True
        '
        'Btn_Resilier
        '
        Me.Btn_Resilier.Location = New System.Drawing.Point(395, 120)
        Me.Btn_Resilier.Name = "Btn_Resilier"
        Me.Btn_Resilier.Size = New System.Drawing.Size(81, 29)
        Me.Btn_Resilier.TabIndex = 7
        Me.Btn_Resilier.Text = "Résilier"
        Me.Btn_Resilier.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 389)
        Me.Controls.Add(Me.Btn_Resilier)
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Controls.Add(Me.Btn_Consulter)
        Me.Controls.Add(Me.Tb_Contrats)
        Me.Controls.Add(Me.Btn_NouveauContrat)
        Me.Controls.Add(Me.Lb_Contrats)
        Me.Controls.Add(Me.Mn_navig)
        Me.MainMenuStrip = Me.Mn_navig
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Mn_navig.ResumeLayout(False)
        Me.Mn_navig.PerformLayout()
        Me.Tb_Contrats.ResumeLayout(False)
        Me.Tb_Contrats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Mn_navig As MenuStrip
    Friend WithEvents MnItem_Aide As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnItem_MonProfil As ToolStripMenuItem
    Friend WithEvents Lb_Contrats As Label
    Friend WithEvents Btn_NouveauContrat As Button
    Friend WithEvents Tb_Contrats As TableLayoutPanel
    Friend WithEvents Btn_Consulter As Button
    Friend WithEvents Btn_Modifier As Button
    Friend WithEvents Btn_Resilier As Button
    Friend WithEvents CheckB1 As CheckBox
    Friend WithEvents CheckB2 As CheckBox
    Friend WithEvents CheckB3 As CheckBox
End Class
