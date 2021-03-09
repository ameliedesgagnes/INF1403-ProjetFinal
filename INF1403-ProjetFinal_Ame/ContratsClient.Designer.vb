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
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_Resilier = New System.Windows.Forms.Button()
        Me.LbIdContrat = New System.Windows.Forms.Label()
        Me.LbDateFin = New System.Windows.Forms.Label()
        Me.LbDateDebut = New System.Windows.Forms.Label()
        Me.LbCodeClient = New System.Windows.Forms.Label()
        Me.TxtBoxIdContrat = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodeClient = New System.Windows.Forms.TextBox()
        Me.TxtBoxDateDebut = New System.Windows.Forms.TextBox()
        Me.TxtBoxDateFin = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mn_navig.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Mn_navig.Size = New System.Drawing.Size(995, 40)
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
        Me.Btn_NouveauContrat.Location = New System.Drawing.Point(470, 140)
        Me.Btn_NouveauContrat.Name = "Btn_NouveauContrat"
        Me.Btn_NouveauContrat.Size = New System.Drawing.Size(132, 40)
        Me.Btn_NouveauContrat.TabIndex = 3
        Me.Btn_NouveauContrat.Text = "Nouveau"
        Me.Btn_NouveauContrat.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.Location = New System.Drawing.Point(636, 140)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(129, 40)
        Me.Btn_Modifier.TabIndex = 6
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = True
        '
        'Btn_Resilier
        '
        Me.Btn_Resilier.Location = New System.Drawing.Point(798, 140)
        Me.Btn_Resilier.Name = "Btn_Resilier"
        Me.Btn_Resilier.Size = New System.Drawing.Size(127, 40)
        Me.Btn_Resilier.TabIndex = 7
        Me.Btn_Resilier.Text = "Résilier"
        Me.Btn_Resilier.UseVisualStyleBackColor = True
        '
        'LbIdContrat
        '
        Me.LbIdContrat.AutoSize = True
        Me.LbIdContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdContrat.Location = New System.Drawing.Point(59, 149)
        Me.LbIdContrat.Name = "LbIdContrat"
        Me.LbIdContrat.Size = New System.Drawing.Size(83, 20)
        Me.LbIdContrat.TabIndex = 9
        Me.LbIdContrat.Text = "ID Contrat"
        '
        'LbDateFin
        '
        Me.LbDateFin.AutoSize = True
        Me.LbDateFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateFin.Location = New System.Drawing.Point(59, 373)
        Me.LbDateFin.Name = "LbDateFin"
        Me.LbDateFin.Size = New System.Drawing.Size(70, 20)
        Me.LbDateFin.TabIndex = 10
        Me.LbDateFin.Text = "Date Fin"
        '
        'LbDateDebut
        '
        Me.LbDateDebut.AutoSize = True
        Me.LbDateDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateDebut.Location = New System.Drawing.Point(59, 294)
        Me.LbDateDebut.Name = "LbDateDebut"
        Me.LbDateDebut.Size = New System.Drawing.Size(92, 20)
        Me.LbDateDebut.TabIndex = 11
        Me.LbDateDebut.Text = "Date Début"
        '
        'LbCodeClient
        '
        Me.LbCodeClient.AutoSize = True
        Me.LbCodeClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodeClient.Location = New System.Drawing.Point(59, 221)
        Me.LbCodeClient.Name = "LbCodeClient"
        Me.LbCodeClient.Size = New System.Drawing.Size(91, 20)
        Me.LbCodeClient.TabIndex = 12
        Me.LbCodeClient.Text = "Code Client"
        '
        'TxtBoxIdContrat
        '
        Me.TxtBoxIdContrat.Location = New System.Drawing.Point(175, 151)
        Me.TxtBoxIdContrat.Name = "TxtBoxIdContrat"
        Me.TxtBoxIdContrat.Size = New System.Drawing.Size(191, 20)
        Me.TxtBoxIdContrat.TabIndex = 13
        '
        'TxtBoxCodeClient
        '
        Me.TxtBoxCodeClient.Location = New System.Drawing.Point(175, 223)
        Me.TxtBoxCodeClient.Name = "TxtBoxCodeClient"
        Me.TxtBoxCodeClient.Size = New System.Drawing.Size(191, 20)
        Me.TxtBoxCodeClient.TabIndex = 14
        '
        'TxtBoxDateDebut
        '
        Me.TxtBoxDateDebut.Location = New System.Drawing.Point(175, 294)
        Me.TxtBoxDateDebut.Name = "TxtBoxDateDebut"
        Me.TxtBoxDateDebut.Size = New System.Drawing.Size(191, 20)
        Me.TxtBoxDateDebut.TabIndex = 15
        '
        'TxtBoxDateFin
        '
        Me.TxtBoxDateFin.Location = New System.Drawing.Point(175, 373)
        Me.TxtBoxDateFin.Name = "TxtBoxDateFin"
        Me.TxtBoxDateFin.Size = New System.Drawing.Size(191, 20)
        Me.TxtBoxDateFin.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(461, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(475, 209)
        Me.DataGridView1.TabIndex = 17
        '
        'ContratsClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtBoxDateFin)
        Me.Controls.Add(Me.TxtBoxDateDebut)
        Me.Controls.Add(Me.TxtBoxCodeClient)
        Me.Controls.Add(Me.TxtBoxIdContrat)
        Me.Controls.Add(Me.LbCodeClient)
        Me.Controls.Add(Me.LbDateDebut)
        Me.Controls.Add(Me.LbDateFin)
        Me.Controls.Add(Me.LbIdContrat)
        Me.Controls.Add(Me.Btn_Resilier)
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Controls.Add(Me.Btn_NouveauContrat)
        Me.Controls.Add(Me.Lb_Contrats)
        Me.Controls.Add(Me.Mn_navig)
        Me.MainMenuStrip = Me.Mn_navig
        Me.Name = "ContratsClient"
        Me.Text = "Form1"
        Me.Mn_navig.ResumeLayout(False)
        Me.Mn_navig.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Btn_Modifier As Button
    Friend WithEvents Btn_Resilier As Button
    Friend WithEvents LbIdContrat As Label
    Friend WithEvents LbDateFin As Label
    Friend WithEvents LbDateDebut As Label
    Friend WithEvents LbCodeClient As Label
    Friend WithEvents TxtBoxIdContrat As TextBox
    Friend WithEvents TxtBoxCodeClient As TextBox
    Friend WithEvents TxtBoxDateDebut As TextBox
    Friend WithEvents TxtBoxDateFin As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
