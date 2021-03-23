Public Class ContratsClient

    Dim contratID As String
    Dim clientID As String
    Dim rowSelected As Boolean = False

    Public Sub setIDs(conID As String, cliID As String)
        contratID = conID
        clientID = cliID
    End Sub

    Public Sub selectedRowBool(bool As Boolean)
        rowSelected = bool
    End Sub

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


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'get les items de la ligne sélectionnée'
        selectedRowBool(True)
        Dim IdContrat As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim CodeClient As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        setIDs(IdContrat, CodeClient)
    End Sub

    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click
        'Permet de modifier le contrat pour lequel la rangée est sélectionnée'

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Assurez-vous de sélectionner un contrat!")
        Else
            Me.Hide()

            NouveauContrat.Show()
            NouveauContrat.changeMode()
            NouveauContrat.TextboxID.Text = contratID
            NouveauContrat.TextBoxCodeClient.Text = clientID
        End If

    End Sub

    Private Sub Btn_Resilier_Click(sender As Object, e As EventArgs) Handles Btn_Resilier.Click

        If (DataGridView1.SelectedRows(0).Cells(0).Selected = True) Then

            Select Case MsgBox("Êtes-vous certain de vouloir supprimer le contrat sélectionné?", MsgBoxStyle.YesNo, "Attention!")
                Case MsgBoxResult.Yes
                    DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            End Select

        Else
            MessageBox.Show("Veuillez sélectionner un contrat et réappuyer sur le bouton Résilier")
        End If


    End Sub



End Class
