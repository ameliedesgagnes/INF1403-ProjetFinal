Public Class LoginScreen

    Dim creation_Compte As Boolean = False 'Détermine si le mode création de compte est actif
    Dim credentials = {{"username", "password"}} 'Utilisateurs/comptes et mot de passe relié 


    '@Function btn_Creation_Click : Active le mode de création de compte. Modifie la visibilité des paneaux
    'de l'écran de connection afin de permettre le remplissage des champs.
    Private Sub btn_Creation_Click(sender As Object, e As EventArgs) Handles btn_Creation.Click
        If creation_Compte = False Then
            pnl_NvUtil.Visible = False
            Pnl_Inscription.Visible = True
            creation_Compte = True
        End If
    End Sub

    '@Function btn_Annuler_Click : Désactive le mode de création de compte. Modifie la visibilité des paneaux
    'de l'écran de connection afin de retourner à l'état original.
    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        If creation_Compte = True Then
            pnl_NvUtil.Visible = True
            Pnl_Inscription.Visible = False
            creation_Compte = False
        End If
    End Sub

    '@Function btn_Connect_Click : Tente une connection au portail de l'application. 
    'Vérifie d'abord si le nom d'utilisateur saisi appartient à la liste.
    'Vérifie ensuite si le mot de passe saisi correspond à celui assigné au nom d'utilisateur.
    'À tout moment, en cas de champ vide ou d'erreur de saisie, une message d'avertissement est lancé.
    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connection.Click
        For i = 0 To credentials.GetLength(0) - 1
            If txtfld_NomUtil.Text = credentials(i, 0) Then
                If txtfld_MDPass.Text = credentials(i, 1) Then
                    Me.Hide()
                    PortailClient.Show()
                    Exit Sub
                End If
            End If
        Next i
        MsgBox("Informations saisies incorrectes.")
    End Sub

    '@Function btn_Inscription_Click : Tente d'insérer une nouvelle pair utilisateur/mot de passe dans la liste établie.
    'Vérifie d'abord si les champs pour utilisateur et mot de passe sont remplis.
    'Insère ensuite la pair utilisateur/mot de passe dans la liste établie.
    Private Sub btn_Inscription_Click(sender As Object, e As EventArgs) Handles btn_SInscrire.Click
        If txtfld_NvUtil.Text <> "" Then
            If txtfld_NvMDPass.Text <> "" Then

                For i = 0 To credentials.GetLength(0) - 1
                    If txtfld_NvUtil.Text = credentials(i, 0) Then
                        MsgBox("Ce nom d'utilisateur existe déjà!")
                        Exit Sub
                    End If
                Next i

                If txtfld_NvMDPassCnf.Text = txtfld_NvMDPass.Text Then
                    Dim len = credentials.GetLength(0)
                    Dim newArray(len, len) As String
                    For i = 0 To credentials.GetLength(0) - 1
                        newArray(i, 0) = credentials(i, 0)
                        newArray(i, 1) = credentials(i, 1)
                    Next i
                    newArray(len, 0) = txtfld_NvUtil.Text
                    newArray(len, 1) = txtfld_NvMDPass.Text
                    credentials = newArray
                    MsgBox("Nouvel utilisateur créé!")
                End If
            Else
                MsgBox("Veuillez remplir tous les champs!")
            End If
        Else
            MsgBox("Veuillez remplir tous les champs!")
        End If
    End Sub


End Class
