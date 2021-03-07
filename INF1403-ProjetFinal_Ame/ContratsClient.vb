Public Class ContratsClient

    Private Sub Btn_NouveauContrat_Click(sender As Object, e As EventArgs) Handles Btn_NouveauContrat.Click
        'Instance vierge du formulaire Nouveau Contrat
        Dim fContrat As New NouveauContrat()
        fContrat.Show()
    End Sub
End Class
