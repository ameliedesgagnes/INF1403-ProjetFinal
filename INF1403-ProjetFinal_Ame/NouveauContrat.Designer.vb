<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ComboBoxDuree = New System.Windows.Forms.ComboBox()
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
        Me.RadioButtonAnnuel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMensuel = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerDateDébut = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDateFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forfait de ligne internet*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location d'équipement"
        '
        'ComboBoxForfait
        '
        Me.ComboBoxForfait.FormattingEnabled = True
        Me.ComboBoxForfait.Location = New System.Drawing.Point(285, 172)
        Me.ComboBoxForfait.Name = "ComboBoxForfait"
        Me.ComboBoxForfait.Size = New System.Drawing.Size(247, 28)
        Me.ComboBoxForfait.TabIndex = 3
        '
        'ComboBoxLocation
        '
        Me.ComboBoxLocation.FormattingEnabled = True
        Me.ComboBoxLocation.Location = New System.Drawing.Point(284, 372)
        Me.ComboBoxLocation.Name = "ComboBoxLocation"
        Me.ComboBoxLocation.Size = New System.Drawing.Size(248, 28)
        Me.ComboBoxLocation.TabIndex = 4
        '
        'Btn_ajouter
        '
        Me.Btn_ajouter.Location = New System.Drawing.Point(31, 789)
        Me.Btn_ajouter.Name = "Btn_ajouter"
        Me.Btn_ajouter.Size = New System.Drawing.Size(203, 55)
        Me.Btn_ajouter.TabIndex = 5
        Me.Btn_ajouter.Text = "Ajouter le contrat"
        Me.Btn_ajouter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Durée de location"
        '
        'ComboBoxDuree
        '
        Me.ComboBoxDuree.FormattingEnabled = True
        Me.ComboBoxDuree.Location = New System.Drawing.Point(284, 421)
        Me.ComboBoxDuree.Name = "ComboBoxDuree"
        Me.ComboBoxDuree.Size = New System.Drawing.Size(248, 28)
        Me.ComboBoxDuree.TabIndex = 7
        '
        'ComboBoxPaiement
        '
        Me.ComboBoxPaiement.FormattingEnabled = True
        Me.ComboBoxPaiement.Location = New System.Drawing.Point(286, 495)
        Me.ComboBoxPaiement.Name = "ComboBoxPaiement"
        Me.ComboBoxPaiement.Size = New System.Drawing.Size(246, 28)
        Me.ComboBoxPaiement.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mode de paiement"
        '
        'TextBoxCodeClient
        '
        Me.TextBoxCodeClient.Location = New System.Drawing.Point(281, 88)
        Me.TextBoxCodeClient.Name = "TextBoxCodeClient"
        Me.TextBoxCodeClient.Size = New System.Drawing.Size(251, 26)
        Me.TextBoxCodeClient.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Code client"
        '
        'TextboxID
        '
        Me.TexboxID.CausesValidation = False
        Me.TexboxID.Location = New System.Drawing.Point(281, 45)
        Me.TexboxID.Name = "TexboxID"
        Me.TexboxID.Size = New System.Drawing.Size(251, 26)
        Me.TexboxID.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.CausesValidation = False
        Me.Label8.Location = New System.Drawing.Point(93, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ID contrat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 24
        '
        'LabelTotalMois
        '
        Me.LabelTotalMois.AutoSize = True
        Me.LabelTotalMois.Location = New System.Drawing.Point(91, 652)
        Me.LabelTotalMois.Name = "LabelTotalMois"
        Me.LabelTotalMois.Size = New System.Drawing.Size(108, 20)
        Me.LabelTotalMois.TabIndex = 25
        Me.LabelTotalMois.Text = "Total par mois"
        '
        'LabelTotalAnnée
        '
        Me.LabelTotalAnnée.AutoSize = True
        Me.LabelTotalAnnée.Location = New System.Drawing.Point(92, 696)
        Me.LabelTotalAnnée.Name = "LabelTotalAnnée"
        Me.LabelTotalAnnée.Size = New System.Drawing.Size(120, 20)
        Me.LabelTotalAnnée.TabIndex = 26
        Me.LabelTotalAnnée.Text = "Total par année"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(267, 696)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(217, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "veuillez sélectionner un forfait"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(267, 652)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(217, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "veuillez sélectionner un forfait"
        '
        'RadioButtonAnnuel
        '
        Me.RadioButtonAnnuel.AutoSize = True
        Me.RadioButtonAnnuel.Location = New System.Drawing.Point(318, 578)
        Me.RadioButtonAnnuel.Name = "RadioButtonAnnuel"
        Me.RadioButtonAnnuel.Size = New System.Drawing.Size(84, 24)
        Me.RadioButtonAnnuel.TabIndex = 29
        Me.RadioButtonAnnuel.TabStop = True
        Me.RadioButtonAnnuel.Text = "Annuel"
        Me.RadioButtonAnnuel.UseVisualStyleBackColor = True
        '
        'RadioButtonMensuel
        '
        Me.RadioButtonMensuel.AutoSize = True
        Me.RadioButtonMensuel.Location = New System.Drawing.Point(126, 578)
        Me.RadioButtonMensuel.Name = "RadioButtonMensuel"
        Me.RadioButtonMensuel.Size = New System.Drawing.Size(94, 24)
        Me.RadioButtonMensuel.TabIndex = 30
        Me.RadioButtonMensuel.TabStop = True
        Me.RadioButtonMensuel.Text = "Mensuel"
        Me.RadioButtonMensuel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 542)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fréquence des paiements"
        '
        'DateTimePickerDateDébut
        '
        Me.DateTimePickerDateDébut.Location = New System.Drawing.Point(228, 220)
        Me.DateTimePickerDateDébut.Name = "DateTimePickerDateDébut"
        Me.DateTimePickerDateDébut.Size = New System.Drawing.Size(304, 26)
        Me.DateTimePickerDateDébut.TabIndex = 32
        '
        'DateTimePickerDateFin
        '
        Me.DateTimePickerDateFin.Location = New System.Drawing.Point(228, 269)
        Me.DateTimePickerDateFin.Name = "DateTimePickerDateFin"
        Me.DateTimePickerDateFin.Size = New System.Drawing.Size(304, 26)
        Me.DateTimePickerDateFin.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date de début"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Date de fin"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(358, 789)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(203, 55)
        Me.ButtonCancel.TabIndex = 36
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'NouveauContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 897)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePickerDateFin)
        Me.Controls.Add(Me.DateTimePickerDateDébut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButtonMensuel)
        Me.Controls.Add(Me.RadioButtonAnnuel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelTotalAnnée)
        Me.Controls.Add(Me.LabelTotalMois)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextboxID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxPaiement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCodeClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxDuree)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_ajouter)
        Me.Controls.Add(Me.ComboBoxLocation)
        Me.Controls.Add(Me.ComboBoxForfait)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents ComboBoxDuree As ComboBox
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
    Friend WithEvents RadioButtonAnnuel As RadioButton
    Friend WithEvents RadioButtonMensuel As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerDateDébut As DateTimePicker
    Friend WithEvents DateTimePickerDateFin As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonCancel As Button
End Class
