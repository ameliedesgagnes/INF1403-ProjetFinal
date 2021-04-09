Public Class PortailEmploye



    'Ouvre la form ContratEmploye (pour l'employer) et ferme la page actuelle 
    '(pour le prototype nous avons repris le contratClient juste pour démontrait à quoi ça pourrait ressembler dans une version finale)
    Private Sub Btn_GestionContrat_Click(sender As Object, e As EventArgs) Handles Btn_GestionContrat.Click
        Me.Hide()
        MessageBox.Show("Option dédié au Prototype (temporaire et possible de changement dans de futur version pour amélioration)")
        ContratsClient.Show()
    End Sub


    'Afficherait une form contenant toutes les formations disponible pour les employés (OPTIONNEL au projet final)
    Private Sub Btn_Formation_Click(sender As Object, e As EventArgs) Handles Btn_Formation.Click
        MessageBox.Show("Option à venir")
    End Sub


    'Afficherait une form contenant les rapports et les statistiques pour les employés (OPTIONNEL au projet final)
    Private Sub Btn_RapportStats_Click(sender As Object, e As EventArgs) Handles Btn_RapportStats.Click
        MessageBox.Show("Option à venir")
    End Sub


    'Afficherait une form contenant tout l'Historique des Contrats enregistré dans une base de donnees (OPTIONNEL au projet final)
    Private Sub Btn_HistoriqueContrat_Click(sender As Object, e As EventArgs) Handles Btn_HistoriqueContrat.Click
        MessageBox.Show("Option à venir")
    End Sub


    'Affiche la page MonProfilEmploye et ferme le PortailEmploye
    Private Sub MnItem_MonProfil_Click(sender As Object, e As EventArgs) Handles MnItem_MonProfil.Click
        Me.Hide()
        ProfilEmploye.Show()
    End Sub


    'Déconnecte l'employe, ferme la page actuelle et affiche la page de Login (le loginScreen)
    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub


End Class
