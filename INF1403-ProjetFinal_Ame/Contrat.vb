Imports System.ComponentModel

Public Class Contrat

    'https://stackoverflow.com/questions/3279106/how-to-implement-class-constructor-in-visual-basic
    'Variable pour les parametres du constructeur
    Public ContratId As Integer
    Public NomClient As String

    'Constructeur de la classe
    Public Sub New(ByVal nouveauContratId As Integer, nouveauNomClient As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ContratId = nouveauContratId
        NomClient = nouveauNomClient

    End Sub



End Class