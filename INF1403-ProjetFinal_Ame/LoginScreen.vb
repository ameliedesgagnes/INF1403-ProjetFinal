Public Class LoginScreen
    Dim signUpMode As Boolean = False

    Dim credentials = {{"username", "password"}}


    Private Sub btn_SignUp_Click(sender As Object, e As EventArgs) Handles btn_SignUp.Click

        If signUpMode = False Then

            pnl_NewUser.Visible = False
            Pnl_Inscription.Visible = True
            signUpMode = True

        End If

    End Sub

    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click

        If signUpMode = True Then

            pnl_NewUser.Visible = True
            Pnl_Inscription.Visible = False
            signUpMode = False

        End If

    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click



        For i = 0 To credentials.GetLength(0) - 1
            If txtfld_Username.Text = credentials(i, 0) Then
                If txtfld_Password.Text = credentials(i, 1) Then
                    Me.Hide()
                    PortailClient.Show()
                    Exit Sub
                End If
            End If
        Next i

        MsgBox("Informations saisies incorrectes.")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtfld_NewUser.Text <> "" Then
            If txtfld_NewPass.Text <> "" Then
                If txtfld_NewPassCnf.Text = txtfld_NewPass.Text Then

                    Dim len = credentials.GetLength(0)
                    Dim newArray(len, len) As String


                    For i = 0 To credentials.GetLength(0) - 1
                        newArray(i, 0) = credentials(i, 0)
                        newArray(i, 1) = credentials(i, 1)
                    Next i
                    newArray(len, 0) = txtfld_NewUser.Text
                    newArray(len, 1) = txtfld_NewPass.Text
                    credentials = newArray

                    MsgBox("Nouvel utilisateur créé!")

                End If

            End If

        End If


    End Sub
End Class
