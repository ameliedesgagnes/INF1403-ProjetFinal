Public Class PortailEmploye




    Private Sub Btn_GestionContrat_Click(sender As Object, e As EventArgs) Handles Btn_GestionContrat.Click
        'Ouvre la form ContratClients de Amelie (pour l'employer)
    End Sub



    Private Sub Btn_Formation_Click(sender As Object, e As EventArgs) Handles Btn_Formation.Click
        'Afficherait une form contenant toutes les formations disponible pour les employés (OPTIONNEL au projet final)
        MessageBox.Show("Option à venir")
    End Sub



    Private Sub Btn_RapportStats_Click(sender As Object, e As EventArgs) Handles Btn_RapportStats.Click
        'Afficherait une form contenant les rapports et les statistiques pour les employés (OPTIONNEL au projet final)
        MessageBox.Show("Option à venir")
    End Sub



    Private Sub Btn_HistoriqueContrat_Click(sender As Object, e As EventArgs) Handles Btn_HistoriqueContrat.Click
        'Afficherait une form contenant tout l'Historique des Contrats enregistré dans une base de donnees (OPTIONNEL au projet final)
        MessageBox.Show("Option à venir")
    End Sub



    Private Sub MnItem_MonProfil_Click(sender As Object, e As EventArgs) Handles MnItem_MonProfil.Click
        Me.Hide()
        ProfilEmploye.Show()
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub


End Class
