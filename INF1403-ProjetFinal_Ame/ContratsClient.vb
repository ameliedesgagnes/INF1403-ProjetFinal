Public Class ContratsClient

    Private Sub ContratsClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.ColumnCount() = 4
        DataGridView1.Columns(0).Name = "IDContrat"
        DataGridView1.Columns(1).Name = "CodeClient"
        DataGridView1.Columns(2).Name = "DateDebut"
        DataGridView1.Columns(3).Name = "DateFin"

    End Sub

    Private Sub AjouterLigne(idClient As String, codeClient As String, dateDebut As String, dateFin As String)
        'Tableau des données
        Dim ligne As String() = New String() {idClient, codeClient, dateDebut, dateFin}
        'Ajouter la ligne dans le dataGridView'
        DataGridView1.Rows.Add(ligne)

        'Vide les zones de text'
        TxtBoxIdContrat.Text = ""
        TxtBoxCodeClient.Text = ""
        TxtBoxDateDebut.Text = ""
        TxtBoxDateFin.Text = ""
    End Sub

    Private Sub Btn_NouveauContrat_Click(sender As Object, e As EventArgs) Handles Btn_NouveauContrat.Click
        AjouterLigne(TxtBoxIdContrat.Text, TxtBoxCodeClient.Text, TxtBoxDateDebut.Text, TxtBoxDateFin.Text)

    End Sub
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'get les items de la ligne sélectionnée'
        Dim idcontrat As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim codeclient As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Dim datedebut As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Dim datefin As String = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()

        TxtBoxIdContrat.Text = idcontrat
        TxtBoxCodeClient.Text = codeclient
        TxtBoxDateDebut.Text = datedebut
        TxtBoxDateFin.Text = datefin
    End Sub

    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click

        'Modifier la ligne dans le DataGrid
        DataGridView1.SelectedRows(0).Cells(0).Value = TxtBoxIdContrat.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = TxtBoxCodeClient.Text
        DataGridView1.SelectedRows(0).Cells(2).Value = TxtBoxDateDebut.Text
        DataGridView1.SelectedRows(0).Cells(3).Value = TxtBoxDateFin.Text

    End Sub


End Class
