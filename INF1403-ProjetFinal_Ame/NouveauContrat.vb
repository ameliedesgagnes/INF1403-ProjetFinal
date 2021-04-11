Imports System.ComponentModel
Public Class NouveauContrat
    'Initialisation variable de classe'
    Private modeConfig As Boolean = False

    'Changer l'écriture du bouton dépendemment de la raison pour laquelle le formulaire est utilisé'
    Public Sub changeMode()
        modeConfig = Not modeConfig
        If modeConfig = True Then
            Btn_ajouter.Text = "Modifier"
        Else
            Btn_ajouter.Text = "Ajouter le contrat"
        End If
    End Sub

    'Choix des forfaits'
    Private Sub ComboBoxForfait_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxForfait.Click
        ComboBoxForfait.Items.Clear()
        ComboBoxForfait.Items.Add("Basse vitesse")
        ComboBoxForfait.Items.Add("Moyenne vitesse")
        ComboBoxForfait.Items.Add("Haute vitesse")
        ComboBoxForfait.Items.Add("Vitesse Entreprise")
    End Sub

    'Choix de durée du contrat'
    Private Sub ComboBoxDuree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDuree.Click
        ComboBoxDuree.Items.Clear()
        ComboBoxDuree.Items.Add("Aucune location sélectionnée")

        If ComboBoxLocation.Text = "Modem" Or ComboBoxLocation.Text = "Micro PC" Then
            ComboBoxDuree.Items.Remove("Aucune location sélectionnée")
            ComboBoxDuree.Items.Add("1 Semaine")
            ComboBoxDuree.Items.Add("2 Semaine")
            ComboBoxDuree.Items.Add("1 Mois")
            ComboBoxDuree.Items.Add("6 Mois")
            ComboBoxDuree.Items.Add("1 An")
        End If
    End Sub

    'Choix de paiement'
    Private Sub ComboBoxPaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaiement.Click
        ComboBoxPaiement.Items.Clear()
        ComboBoxPaiement.Items.Add("Carte de crédit")
        ComboBoxPaiement.Items.Add("Carte débit")
        ComboBoxPaiement.Items.Add("Chèque")

    End Sub

    'Choix du type de location'
    Private Sub ComboBoxLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocation.Click
        ComboBoxLocation.Items.Clear()
        ComboBoxLocation.Items.Add("Aucune location")
        ComboBoxLocation.Items.Add("Modem")
        ComboBoxLocation.Items.Add("Micro PC")
    End Sub

    'Ajouter l'information dans le tableau du formulaire ContratsClient, selon s'il s'agit d'un nouveau contrat ou d'une modification'
    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click

        If modeConfig = True Then
            ContratsClient.TableauDonnees.SelectedRows(0).Cells(0).Value = TextboxID.Text
            ContratsClient.TableauDonnees.SelectedRows(0).Cells(1).Value = TextBoxCodeClient.Text
            ContratsClient.TableauDonnees.SelectedRows(0).Cells(2).Value = DateTimePickerDateDébut.Value
            ContratsClient.TableauDonnees.SelectedRows(0).Cells(3).Value = DateTimePickerDateFin.Value
            Me.Close()
            ContratsClient.Show()
        Else
            ContratsClient.TableauDonnees.Rows.Add(TextboxID.Text, TextBoxCodeClient.Text, DateTimePickerDateDébut.Value, DateTimePickerDateFin.Value)
            ContratsClient.setIDs(TextboxID.Text, TextBoxCodeClient.Text)
            Me.Close()
            ContratsClient.Show()
        End If
    End Sub

    'Défini le total dû par mois'
    Private Sub TotalMoisResultat_Click(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        If ComboBoxForfait.Text = "Basse vitesse" Then
            Lb_totalMoisResultat.Text = "30$"
        ElseIf ComboBoxForfait.Text = "Moyenne vitesse" Then
            Lb_totalMoisResultat.Text = "60$"
        ElseIf ComboBoxForfait.Text = "Haute vitesse" Then
            Lb_totalMoisResultat.Text = "90$"
        ElseIf ComboBoxForfait.Text = "Vitesse Entreprise" Then
            Lb_totalMoisResultat.Text = "200$"
        End If

    End Sub

    'Défini le total dû par année'
    Private Sub TotalAnneeResultat_Click(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        If ComboBoxForfait.Text = "Basse vitesse" Then
            Lb_TotalAnneeResultat.Text = "360$"
        ElseIf ComboBoxForfait.Text = "Moyenne vitesse" Then
            Lb_TotalAnneeResultat.Text = "720$"
        ElseIf ComboBoxForfait.Text = "Haute vitesse" Then
            Lb_TotalAnneeResultat.Text = "1 080$"
        ElseIf ComboBoxForfait.Text = "Vitesse Entreprise" Then
            Lb_TotalAnneeResultat.Text = "2 400$"
        End If
    End Sub

    'Bouton Cancel - ferme le formulaire'
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        ContratsClient.Show()
    End Sub

    Private Sub FrmNouveauContrat(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ContratsClient.Show()
    End Sub


End Class