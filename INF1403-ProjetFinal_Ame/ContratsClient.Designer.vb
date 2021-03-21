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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Mn_navig.Size = New System.Drawing.Size(595, 40)
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
        Me.Btn_NouveauContrat.Location = New System.Drawing.Point(40, 140)
        Me.Btn_NouveauContrat.Name = "Btn_NouveauContrat"
        Me.Btn_NouveauContrat.Size = New System.Drawing.Size(132, 40)
        Me.Btn_NouveauContrat.TabIndex = 3
        Me.Btn_NouveauContrat.Text = "Nouveau"
        Me.Btn_NouveauContrat.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.Location = New System.Drawing.Point(218, 140)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(129, 40)
        Me.Btn_Modifier.TabIndex = 6
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = True
        '
        'Btn_Resilier
        '
        Me.Btn_Resilier.Location = New System.Drawing.Point(388, 140)
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
        Me.LbIdContrat.Size = New System.Drawing.Size(0, 20)
        Me.LbIdContrat.TabIndex = 9
        '
        'LbDateFin
        '
        Me.LbDateFin.AutoSize = True
        Me.LbDateFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateFin.Location = New System.Drawing.Point(59, 373)
        Me.LbDateFin.Name = "LbDateFin"
        Me.LbDateFin.Size = New System.Drawing.Size(0, 20)
        Me.LbDateFin.TabIndex = 10
        '
        'LbDateDebut
        '
        Me.LbDateDebut.AutoSize = True
        Me.LbDateDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDateDebut.Location = New System.Drawing.Point(59, 294)
        Me.LbDateDebut.Name = "LbDateDebut"
        Me.LbDateDebut.Size = New System.Drawing.Size(0, 20)
        Me.LbDateDebut.TabIndex = 11
        '
        'LbCodeClient
        '
        Me.LbCodeClient.AutoSize = True
        Me.LbCodeClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodeClient.Location = New System.Drawing.Point(59, 221)
        Me.LbCodeClient.Name = "LbCodeClient"
        Me.LbCodeClient.Size = New System.Drawing.Size(0, 20)
        Me.LbCodeClient.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdContrat, Me.CodeClient})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(40, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(475, 209)
        Me.DataGridView1.TabIndex = 17
        '
        'IdContrat
        '
        Me.IdContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdContrat.HeaderText = "Id Contrat"
        Me.IdContrat.Name = "IdContrat"
        '
        'CodeClient
        '
        Me.CodeClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodeClient.HeaderText = "Code Client"
        Me.CodeClient.Name = "CodeClient"
        '
        'ContratsClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 478)
        Me.Controls.Add(Me.DataGridView1)
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdContrat As DataGridViewTextBoxColumn
    Friend WithEvents CodeClient As DataGridViewTextBoxColumn
End Class
