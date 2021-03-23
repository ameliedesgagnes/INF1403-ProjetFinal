Imports System.ComponentModel
Public Class NouveauContrat

    Private modeConfig As Boolean = False


    Public Sub changeMode()
        modeConfig = Not modeConfig
        If modeConfig = True Then
            Btn_ajouter.Text = "Modifier"
        Else
            Btn_ajouter.Text = "Ajouter le contrat"
        End If
    End Sub


    Private Sub ComboBoxForfait_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxForfait.Click
        ComboBoxForfait.Items.Clear()
        ComboBoxForfait.Items.Add("Basse vitesse")
        ComboBoxForfait.Items.Add("Moyenne vitesse")
        ComboBoxForfait.Items.Add("Haute vitesse")
        ComboBoxForfait.Items.Add("Vitesse Entreprise")

    End Sub

    'TODO: Jamais mettre d'accent dans les variable'
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

    Private Sub ComboBoxPaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaiement.Click
        ComboBoxPaiement.Items.Clear()
        ComboBoxPaiement.Items.Add("Carte de crédit")
        ComboBoxPaiement.Items.Add("Carte débit")
        ComboBoxPaiement.Items.Add("Chèque")

    End Sub

    Private Sub ComboBoxLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocation.Click
        ComboBoxLocation.Items.Clear()
        ComboBoxLocation.Items.Add("Aucune location")
        ComboBoxLocation.Items.Add("Modem")
        ComboBoxLocation.Items.Add("Micro PC")

    End Sub

    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click

        If modeConfig = True Then
            ContratsClient.DataGridView1.SelectedRows(0).Cells(0).Value = TextboxID.Text
            ContratsClient.DataGridView1.SelectedRows(0).Cells(1).Value = TextBoxCodeClient.Text
            Me.Close()
            ContratsClient.Show()
        Else
            ContratsClient.DataGridView1.Rows.Add(TextboxID.Text, TextBoxCodeClient.Text)
            ContratsClient.setIDs(TextboxID.Text, TextBoxCodeClient.Text)
            Me.Close()
            ContratsClient.Show()
        End If



    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        If ComboBoxForfait.Text = "Basse vitesse" Then
            Label14.Text = "30$"
        ElseIf ComboBoxForfait.Text = "Moyenne vitesse" Then
            Label14.Text = "60$"
        ElseIf ComboBoxForfait.Text = "Haute vitesse" Then
            Label14.Text = "90$"
        ElseIf ComboBoxForfait.Text = "Vitesse Entreprise" Then
            Label14.Text = "200$"
        End If

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        If ComboBoxForfait.Text = "Basse vitesse" Then
            Label13.Text = "360$"
        ElseIf ComboBoxForfait.Text = "Moyenne vitesse" Then
            Label13.Text = "720$"
        ElseIf ComboBoxForfait.Text = "Haute vitesse" Then
            Label13.Text = "1 080$"
        ElseIf ComboBoxForfait.Text = "Vitesse Entreprise" Then
            Label13.Text = "2 400$"
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        ContratsClient.Show()
    End Sub
    Private Sub frmNouveauContrat(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ContratsClient.Show()
    End Sub

End Class