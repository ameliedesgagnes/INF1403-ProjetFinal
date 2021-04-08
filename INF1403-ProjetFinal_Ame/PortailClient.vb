Public Class PortailClient



    'Ouvre la page sur la creation d'une nouvelle location (pour le client)
    Private Sub Btn_ClientNouvelleLocation_Click(sender As Object, e As EventArgs) Handles Btn_ClientNouvelleLocation.Click
        Me.Hide()
        NouveauContrat.Show()
    End Sub


    'Ouvre la form ContratClients (pour le client) et ferme la page actuelle
    Private Sub Btn_ClientMesContrats_Click(sender As Object, e As EventArgs) Handles Btn_ClientMesContrats.Click
        Me.Hide()
        ContratsClient.Show()
    End Sub



    'Afficherait une form contenant les differents recu d'impot telechargeable (OPTIONNEL au projet final)
    Private Sub Btn_RecuImpot_Click(sender As Object, e As EventArgs) Handles Btn_RecuImpot.Click
        MessageBox.Show("Option à venir")
    End Sub


    'Déconnecte le client, ferme la page actuelle et affiche la page de Login (le loginScreen)
    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub


    'Affiche la page MonProfilClient et ferme le PortailClient
    Private Sub MnItem_MonProfil_Click(sender As Object, e As EventArgs) Handles MnItem_MonProfil.Click
        Me.Hide()
        ProfilClient.Show()
    End Sub


End Class