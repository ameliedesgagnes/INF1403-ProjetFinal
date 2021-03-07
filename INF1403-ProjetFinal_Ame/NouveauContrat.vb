Imports System.ComponentModel

Public Class NouveauContrat
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        ContratsClient.DataGridView1.Rows.Add(TxtBoxIdContrat.Text, TxtBoxCodeClient.Text, TxtBoxDateDebut.Text, TxtBoxDateFin.Text)

    End Sub
End Class