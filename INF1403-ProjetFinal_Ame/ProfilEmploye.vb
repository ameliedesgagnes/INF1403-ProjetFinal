Public Class ProfilEmploye


    'Affiche le Portail de l'Employé et ferme la page ProfilEmploye
    Private Sub MnItem_MonPortail_Click(sender As Object, e As EventArgs) Handles MnItem_MonPortailEmploye.Click
        Me.Hide()
        PortailEmploye.Show()
    End Sub



    'Afficherai une form pour changer le mot de passe de l'Employé (OPTIONNEL au projet final)
    Private Sub Btn_ChangerMDPEmploye_Click(sender As Object, e As EventArgs) Handles Btn_ChangerMDPEmploye.Click
        MessageBox.Show("Option à venir")
    End Sub



    'Afficherai une form pour changer les informations personnelles de l'Employe (OPTIONNEL au projet final)
    Private Sub Btn_ChangerInfoEmploye_Click(sender As Object, e As EventArgs) Handles Btn_ChangerInfoEmploye.Click
        MessageBox.Show("Option à venir")
    End Sub



End Class