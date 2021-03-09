Imports System.ComponentModel

Public Class NouveauContrat
    Private IdClient As String
    Dim CodeClient As String
    Dim DateDebut As String
    Dim DateFin As String

    Public Sub New()
    End Sub

    Public Sub New(idClient As String, codeClient As String, dateDebut As String, dateFin As String)
        If String.IsNullOrWhiteSpace(idClient) Then
            Throw New ArgumentException($"'{NameOf(idClient)}' ne peut pas être null ou un espace", NameOf(idClient))
        End If

        Me.IdClient = idClient
        Me.CodeClient = codeClient
        Me.DateDebut = dateDebut
        Me.DateFin = dateFin
    End Sub
    Private Sub NouveauContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        ContratsClient.DataGridView1.Rows.Add(TxtBoxIdContrat.Text, TxtBoxCodeClient.Text, TxtBoxDateDebut.Text, TxtBoxDateFin.Text)

        'Vide les zones de text'
        TxtBoxIdContrat.Text = ""
        TxtBoxCodeClient.Text = ""
        TxtBoxDateDebut.Text = ""
        TxtBoxDateFin.Text = ""

    End Sub
End Class