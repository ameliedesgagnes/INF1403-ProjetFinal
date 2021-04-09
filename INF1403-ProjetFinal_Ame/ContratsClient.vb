Public Class ContratsClient

    'Initialisation des variables de classe'
    Dim contratID As String
    Dim clientID As String
    Dim ligneSelectionnee As Boolean = False

    'Fonction setIDs'
    Public Sub setIDs(conID As String, cliID As String)
        contratID = conID
        clientID = cliID
    End Sub

    'Assigne une valeur booléenne à la variable ligneSelectionnee si une ligne du tableau fut sélectionnée par l'utilisateur'
    Public Sub BoolLigneSelectionnee(bool As Boolean)
        ligneSelectionnee = bool
    End Sub

    'Charger le Data Grid View nommé TableauDonnees'
    Private Sub ContratsClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableauDonnees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ''
    Private Sub AjouterLigne(idClient As String, codeClient As String, dateDebut As String, dateFin As String)
        'Enregistrement des données dans la variable ligne'
        Dim ligne As String() = New String() {idClient, codeClient, dateDebut, dateFin}
        'Ajouter la ligne dans le dataGridView'
        TableauDonnees.Rows.Add(ligne)
    End Sub

    'Quand le bouton Nouveau Contrat est cliqué, cacher la fenêtre actuelle et ouvrir le formulaire NouveauContrat'
    Private Sub Btn_NouveauContrat_Click(sender As Object, e As EventArgs) Handles Btn_NouveauContrat.Click
        Me.Hide()
        NouveauContrat.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles TableauDonnees.CellClick
        'get les items de la ligne sélectionnée'
        BoolLigneSelectionnee(True)
        Dim IdContrat As String = TableauDonnees.SelectedRows(0).Cells(0).Value.ToString()
        Dim CodeClient As String = TableauDonnees.SelectedRows(0).Cells(1).Value.ToString()
        setIDs(IdContrat, CodeClient)
    End Sub

    'Permet de modifier le contrat pour lequel la rangée est sélectionnée'
    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click
        'Si aucune ligne n'est sélectionnée, demander à l'utilisateur de sélectionner une ligne'
        If TableauDonnees.SelectedRows.Count = 0 Then
            MessageBox.Show("Assurez-vous de sélectionner un contrat!")
            'Sinon cacher l'écran actuelle et montrer le formulaire nouveauContrat et insérer les données de la ligne sélectionnée'
        Else
            Me.Hide()
            NouveauContrat.Show()
            NouveauContrat.changeMode()
            NouveauContrat.TextboxID.Text = contratID
            NouveauContrat.TextBoxCodeClient.Text = clientID
        End If
    End Sub

    'Supression d'un contrat du tableau de données'
    Private Sub Btn_Resilier_Click(sender As Object, e As EventArgs) Handles Btn_Resilier.Click
        'Si aucune ligne n'est sélectionnée, demander à l'utilisateur de sélectionner une ligne'
        If TableauDonnees.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un contrat et réappuyer sur le bouton Résilier")
        Else
            'Sinon confirmer avec l'utilisateur la supression d'un contrat et supprimer le contrat s'il confirme OUI
            Select Case MsgBox("Êtes-vous certain de vouloir supprimer le contrat sélectionné?", MsgBoxStyle.YesNo, "Attention!")
                Case MsgBoxResult.Yes
                    TableauDonnees.Rows.RemoveAt(TableauDonnees.SelectedRows(0).Index)
            End Select
        End If
    End Sub

    'Flèche de retour en arrière ramène à la page précédente: le portail client'
    Private Sub Fleche_Lb_Click(sender As Object, e As EventArgs) Handles Fleche_Lb.Click
        Me.Hide()
        PortailClient.Show()
    End Sub


    'Affiche la page MonProfilClient et ferme la page actuelle 
    Private Sub MnItem_MonProfil_Click(sender As Object, e As EventArgs) Handles MnItem_MonProfil.Click
        Me.Hide()
        ProfilClient.Show()
    End Sub

End Class
