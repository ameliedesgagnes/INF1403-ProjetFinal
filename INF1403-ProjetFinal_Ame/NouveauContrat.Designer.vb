<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouveauContrat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxForfait = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLocation = New System.Windows.Forms.ComboBox()
        Me.Btn_ajouter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDurée = New System.Windows.Forms.ComboBox()
        Me.CheckBoxAnnuel = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMensuel = New System.Windows.Forms.CheckBox()
        Me.ComboBoxPaiement = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCodeClient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextboxID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelTotalMois = New System.Windows.Forms.Label()
        Me.LabelTotalAnnée = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forfait de ligne internet*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location d'équipement"
        '
        'ComboBoxForfait
        '
        Me.ComboBoxForfait.FormattingEnabled = True
        Me.ComboBoxForfait.Location = New System.Drawing.Point(191, 112)
        Me.ComboBoxForfait.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxForfait.Name = "ComboBoxForfait"
        Me.ComboBoxForfait.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxForfait.TabIndex = 3
        '
        'ComboBoxLocation
        '
        Me.ComboBoxLocation.FormattingEnabled = True
        Me.ComboBoxLocation.Location = New System.Drawing.Point(191, 166)
        Me.ComboBoxLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxLocation.Name = "ComboBoxLocation"
        Me.ComboBoxLocation.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxLocation.TabIndex = 4
        '
        'Btn_ajouter
        '
        Me.Btn_ajouter.Location = New System.Drawing.Point(68, 487)
        Me.Btn_ajouter.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_ajouter.Name = "Btn_ajouter"
        Me.Btn_ajouter.Size = New System.Drawing.Size(224, 36)
        Me.Btn_ajouter.TabIndex = 5
        Me.Btn_ajouter.Text = "Ajouter le contrat"
        Me.Btn_ajouter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Durée de location"
        '
        'ComboBoxDurée
        '
        Me.ComboBoxDurée.FormattingEnabled = True
        Me.ComboBoxDurée.Location = New System.Drawing.Point(191, 215)
        Me.ComboBoxDurée.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDurée.Name = "ComboBoxDurée"
        Me.ComboBoxDurée.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxDurée.TabIndex = 7
        '
        'CheckBoxAnnuel
        '
        Me.CheckBoxAnnuel.AutoSize = True
        Me.CheckBoxAnnuel.Location = New System.Drawing.Point(191, 336)
        Me.CheckBoxAnnuel.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxAnnuel.Name = "CheckBoxAnnuel"
        Me.CheckBoxAnnuel.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxAnnuel.TabIndex = 19
        Me.CheckBoxAnnuel.Text = "Annuel"
        Me.CheckBoxAnnuel.UseVisualStyleBackColor = True
        '
        'CheckBoxMensuel
        '
        Me.CheckBoxMensuel.AutoSize = True
        Me.CheckBoxMensuel.Location = New System.Drawing.Point(65, 336)
        Me.CheckBoxMensuel.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxMensuel.Name = "CheckBoxMensuel"
        Me.CheckBoxMensuel.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxMensuel.TabIndex = 18
        Me.CheckBoxMensuel.Text = "Mensuel"
        Me.CheckBoxMensuel.UseVisualStyleBackColor = True
        '
        'ComboBoxPaiement
        '
        Me.ComboBoxPaiement.FormattingEnabled = True
        Me.ComboBoxPaiement.Location = New System.Drawing.Point(191, 274)
        Me.ComboBoxPaiement.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxPaiement.Name = "ComboBoxPaiement"
        Me.ComboBoxPaiement.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxPaiement.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mode de paiement"
        '
        'TextBoxCodeClient
        '
        Me.TextBoxCodeClient.Location = New System.Drawing.Point(191, 57)
        Me.TextBoxCodeClient.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCodeClient.Name = "TextBoxCodeClient"
        Me.TextBoxCodeClient.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxCodeClient.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Code client"
        '
        'TextboxID
        '
        Me.TextboxID.CausesValidation = False
        Me.TextboxID.Location = New System.Drawing.Point(191, 29)
        Me.TextboxID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextboxID.Name = "TextboxID"
        Me.TextboxID.Size = New System.Drawing.Size(92, 20)
        Me.TextboxID.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.CausesValidation = False
        Me.Label8.Location = New System.Drawing.Point(65, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ID contrat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(311, 100)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 24
        '
        'LabelTotalMois
        '
        Me.LabelTotalMois.AutoSize = True
        Me.LabelTotalMois.Location = New System.Drawing.Point(62, 394)
        Me.LabelTotalMois.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalMois.Name = "LabelTotalMois"
        Me.LabelTotalMois.Size = New System.Drawing.Size(73, 13)
        Me.LabelTotalMois.TabIndex = 25
        Me.LabelTotalMois.Text = "Total par mois"
        '
        'LabelTotalAnnée
        '
        Me.LabelTotalAnnée.AutoSize = True
        Me.LabelTotalAnnée.Location = New System.Drawing.Point(62, 441)
        Me.LabelTotalAnnée.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalAnnée.Name = "LabelTotalAnnée"
        Me.LabelTotalAnnée.Size = New System.Drawing.Size(82, 13)
        Me.LabelTotalAnnée.TabIndex = 26
        Me.LabelTotalAnnée.Text = "Total par année"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(179, 441)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "truc pour afficher "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(188, 394)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "truc pur afficher"
        '
        'NouveauContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 548)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelTotalAnnée)
        Me.Controls.Add(Me.LabelTotalMois)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextboxID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBoxAnnuel)
        Me.Controls.Add(Me.CheckBoxMensuel)
        Me.Controls.Add(Me.ComboBoxPaiement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCodeClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxDurée)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_ajouter)
        Me.Controls.Add(Me.ComboBoxLocation)
        Me.Controls.Add(Me.ComboBoxForfait)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NouveauContrat"
        Me.Text = "Info contrat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxForfait As ComboBox
    Friend WithEvents ComboBoxLocation As ComboBox
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxDurée As ComboBox
    Friend WithEvents CheckBoxAnnuel As CheckBox
    Friend WithEvents CheckBoxMensuel As CheckBox
    Friend WithEvents ComboBoxPaiement As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCodeClient As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextboxID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelTotalMois As Label
    Friend WithEvents LabelTotalAnnée As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
