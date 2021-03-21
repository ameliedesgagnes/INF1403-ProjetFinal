Imports System.ComponentModel

Public Class NouveauContrat


    Private Sub ComboBoxForfait_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        ComboBoxForfait.Items.Clear()
        ComboBoxForfait.Items.Add("Sûreté")
        ComboBoxForfait.Items.Add("Sécurité")
        ComboBoxForfait.Items.Add("Bonne Santé")
        ComboBoxForfait.Items.Add("Education")

    End Sub

    'TODO: Jamais mettre d'accent dans les variable'
    Private Sub ComboBoxDurée_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDurée.SelectedIndexChanged
        ComboBoxDurée.Items.Clear()
        ComboBoxDurée.Items.Add("1 Semaine")
        ComboBoxDurée.Items.Add("2 Semaine")
        ComboBoxDurée.Items.Add("1 Mois")
        ComboBoxDurée.Items.Add("6 Mois")
        ComboBoxDurée.Items.Add("1 An")

    End Sub

    Private Sub ComboBoxPaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaiement.SelectedIndexChanged
        ComboBoxPaiement.Items.Clear()
        ComboBoxPaiement.Items.Add("Carte de crédit")
        ComboBoxPaiement.Items.Add("Carte débit")
        ComboBoxPaiement.Items.Add("Chèque")

    End Sub

    Private Sub ComboBoxLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocation.SelectedIndexChanged
        ComboBoxLocation.Items.Clear()
        ComboBoxLocation.Items.Add("Modem")
        ComboBoxLocation.Items.Add("Micro PC")

    End Sub

    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click

        ContratsClient.DataGridView1.Rows.Add(TexboxID.Text, TextBoxCodeClient.Text)

        Me.Close()
        ContratsClient.Show()
    End Sub


End Class