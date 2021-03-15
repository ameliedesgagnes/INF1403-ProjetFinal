Public Class Form1
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
            MsgBox(credentials(0, 1))

        End If

    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click

    End Sub
End Class
