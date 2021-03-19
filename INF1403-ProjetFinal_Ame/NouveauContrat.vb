Imports System.ComponentModel

Public Class NouveauContrat

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TexboxID.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxForfait_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxForfait.SelectedIndexChanged
        ComboBoxForfait.Items.Clear()
        ComboBoxForfait.Items.Add("Sûreté")
        ComboBoxForfait.Items.Add("Sécurité")
        ComboBoxForfait.Items.Add("Bonne Santé")
        ComboBoxForfait.Items.Add("Education")

    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub ComboBoxDurée_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDurée.SelectedIndexChanged
        ComboBoxDurée.Items.Clear()
        ComboBoxDurée.Items.Add("1 Semaine")
        ComboBoxDurée.Items.Add("2 Semaine")
        ComboBoxDurée.Items.Add("1 Mois")
        ComboBoxDurée.Items.Add("6 Mois")
        ComboBoxDurée.Items.Add("1 An")

    End Sub

    Private Sub ComboBoxPaiement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaiement.SelectedIndexChanged
        ComboBoxPaiement.Items.Clear()
        ComboBoxPaiement.Items.Add("Carte de crédit")
        ComboBoxPaiement.Items.Add("Carte débit")
        ComboBoxPaiement.Items.Add("Chèque")

    End Sub

    Private Sub ComboBoxLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocation.SelectedIndexChanged
        ComboBoxLocation.Items.Clear()
        ComboBoxLocation.Items.Add("Modem")
        ComboBoxLocation.Items.Add("Micro PC")

    End Sub



    '________________________________________________________________________________________________________________________________

    '                                                           VIEUX CODE AMELIE
    '________________________________________________________________________________________________________________________________

    'Private IdClient As String
    'Dim CodeClient As String
    ' Dim DateDebut As String
    ' Dim DateFin As String

    ' Public Sub New()
    'End Sub

    'Public Sub New(idClient As String, codeClient As String, dateDebut As String, dateFin As String)
    'If String.IsNullOrWhiteSpace(idClient) Then
    'Throw New ArgumentException($"'{NameOf(idClient)}' ne peut pas être null ou un espace", NameOf(idClient))
    'End If

    'Me.IdClient = idClient
    'Me.CodeClient = codeClient
    'Me.DateDebut = dateDebut
    'Me.DateFin = dateFin
    'End Sub
    '    Private Sub NouveauContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub
    '   Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
    '      ContratsClient.DataGridView1.Rows.Add(TxtBoxIdContrat.Text, TxtBoxCodeClient.Text, TxtBoxDateDebut.Text, TxtBoxDateFin.Text)

    'Vide les zones de text'
    '     TxtBoxIdContrat.Text = ""
    '    TxtBoxCodeClient.Text = ""
    '   TxtBoxDateDebut.Text = ""
    '  TxtBoxDateFin.Text = ""

    '    End Sub

End Class