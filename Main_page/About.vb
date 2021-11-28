Public NotInheritable Class About

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = "/ À Propos"
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Nom du Produit : Winergie. INC pour SGP."
        Me.LabelVersion.Text = "Version : 1.2b."
        Me.LabelCopyright.Text = "Droit Légal :Tous droits sont non réservés."
        Me.LabelCompanyName.Text = "Conçu par : Les Voltigeurs."
        Me.TextBoxDescription.Text = "Winergie est une compagnie spécialisée dans la conception des logiciels pour la gestion d’une station de service. Le logiciel permet la gestion des pompes et la reconnaissance de l’état des réservoirs; la gestion des transactions réalisées sur les pompes comportant, entre autres, l’archivage des transactions impayées, le paiement de la facture de la transaction; la gestion des rapports permettant d’éditer de rapports à des fins statistiques (par exemple : Liste des transactions impayées, liste des transactions payées par carte de crédit, etc.). Ce scénario doit figurer dans l’interface principale du prototype du système mais aller dans le détail de chacun. Le détail sera développé dans la prochaine version du système, et la gestion des comptes des utilisateurs (création, suppression des noms et mots de passe des utilisateurs)."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
