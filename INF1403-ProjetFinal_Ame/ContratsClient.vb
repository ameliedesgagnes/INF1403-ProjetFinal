Public Class ContratsClient

    Private Sub Btn_Consulter_Click(sender As Object, e As EventArgs) Handles Btn_Consulter.Click
        MessageBox.Show(GetChecked())

    End Sub

    Private Function GetChecked()
        'Variable du message
        Dim Text As String = ""

        'Get la case qui est cochée
        If CheckB1.Checked Then
            Text = "Boite 1"

        ElseIf CheckB2.Checked Then
            Text = "Boite 2"
        ElseIf CheckB3.Checked Then
            Text = "Boite 3"
        Else
            Text = "Aucune boite n'est cochée"
        End If

        Return Text

    End Function




End Class
