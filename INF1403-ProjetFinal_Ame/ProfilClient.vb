Public Class ProfilClient


    'Affiche le Portail du Client et ferme la page ProfilClient
    Private Sub MnItem_MonPortail_Click(sender As Object, e As EventArgs) Handles MnItem_MonPortailClient.Click
        Me.Hide()
        PortailClient.Show()
    End Sub



    'Afficherai une form pour changer le mot de passe du Client (OPTIONNEL au projet final)
    Private Sub Btn_ChangerMDPClient_Click(sender As Object, e As EventArgs) Handles Btn_ChangerMDPClient.Click
        MessageBox.Show("Option à venir")
    End Sub



    'Afficherai une form pour changer les informations personnelles du Client (OPTIONNEL au projet final)
    Private Sub Btn_ChangerInfoCLient_Click(sender As Object, e As EventArgs) Handles Btn_ChangerInfoCLient.Click
        MessageBox.Show("Option à venir")
    End Sub


    'Déconnecte le client, ferme la page actuelle et affiche la page de Login (le loginScreen)
    Private Sub MnItem_DeconnexionClient_Click(sender As Object, e As EventArgs) Handles MnItem_DeconnexionClient.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub
End Class