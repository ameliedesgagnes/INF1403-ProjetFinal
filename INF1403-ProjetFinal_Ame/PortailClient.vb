Public Class PortailClient


    Private Sub Btn_ClientNouvelleLocation_Click(sender As Object, e As EventArgs) Handles Btn_ClientNouvelleLocation.Click
        'Ouvre le popUp de Guillaume sur la creation d'une nouvelle location (pour le client)
    End Sub


    Private Sub Btn_ClientMesContrats_Click(sender As Object, e As EventArgs) Handles Btn_ClientMesContrats.Click
        'Ouvre la form ContratClients de Amelie (pour le client)
        Me.Hide()
        ContratsClient.Show()
    End Sub




    Private Sub Btn_RecuImpot_Click(sender As Object, e As EventArgs) Handles Btn_RecuImpot.Click
        'Afficherait une form contenant les differents recu d'impot telechargeable (OPTIONNEL au projet final)
        MessageBox.Show("Option à venir")
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub



    Private Sub MnItem_MonProfil_Click(sender As Object, e As EventArgs) Handles MnItem_MonProfil.Click
        Me.Hide()
        ProfilClient.Show()
    End Sub


End Class