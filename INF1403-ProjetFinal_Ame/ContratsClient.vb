Public Class ContratsClient

    Private Sub ContratsClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub AjouterLigne(idClient As String, codeClient As String, dateDebut As String, dateFin As String)
        'Tableau des données
        Dim ligne As String() = New String() {idClient, codeClient, dateDebut, dateFin}
        'Ajouter la ligne dans le dataGridView'
        DataGridView1.Rows.Add(ligne)

    End Sub

    Private Sub Btn_NouveauContrat_Click(sender As Object, e As EventArgs) Handles Btn_NouveauContrat.Click
        Me.Hide()
        NouveauContrat.Show()

        'AjouterLigne()'
    End Sub
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'get les items de la ligne sélectionnée'
        Dim idcontrat As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim codeclient As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()

    End Sub

    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click


    End Sub


End Class
