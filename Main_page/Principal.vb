Public Class Principal
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub SupprimerUnEmployerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerUnEmployerToolStripMenuItem.Click
        MsgBox("Pour Toute Information concernant La Formation ou Le Support Technique, contactez Mr. Mohamed TALEB au :" & Environment.NewLine & " +1 819-873-4466", MsgBoxStyle.OkOnly + vbInformation, "Information")
    End Sub



    Private Sub FacturationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturationToolStripMenuItem.Click

    End Sub

    Private Sub ImprimerLaFactureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLaFactureToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()


    End Sub



    Private Sub ActiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Pompe2.Show()


    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click


    End Sub


    Private Sub DesactiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub EtatDeLaPompeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pompe1.Show()


    End Sub

    Private Sub RapportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportsToolStripMenuItem.Click

    End Sub

    Private Sub ActiverToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        Pompe2.Show()

    End Sub

    Private Sub DésactiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'MessageBox.Show("Voulez-vous Désactiver?")

    End Sub

    Private Sub DésactiverToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'MessageBox.Show("Voulez-vous Désactiver?")
    End Sub

    Private Sub AjouterUnEmployéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnEmployéToolStripMenuItem.Click
        Employe.Show()


    End Sub

    Private Sub Pompes1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pompes1ToolStripMenuItem.Click
        frmActiverPompe.Show()

    End Sub

    Private Sub CréerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pompe1.Show()
    End Sub

    Private Sub CréerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CréerToolStripMenuItem1.Click
        frmImpaye.Show()
    End Sub

    Private Sub Pompe2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmDesactiverPompe.Show()

    End Sub

    Private Sub ImpayésToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImpayésToolStripMenuItem1.Click

    End Sub

    Private Sub ÀProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub AjouterUnEmployerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnEmployerToolStripMenuItem.Click
        Aide.Show()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        MsgBox("L'horaire est le suivant: " & vbCrLf & " Lun: 07:00 - 23:00 " & vbCrLf & " Mar: 07:00 - 23:00 " & vbCrLf & " Mer: 07:00 - 23:00 " & vbCrLf & " Jeu: 07:00 - 23:00 " & vbCrLf & " Ven: 07:00 - 23:00 " & vbCrLf & " Sam: 07:00 - 00:00 " & vbCrLf & " Dim: 07:00 - 00:00 ", MsgBoxStyle.OkOnly + vbInformation, "Information")
    End Sub

    Private Sub ModifierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem1.Click
        Miseajours.Show()
    End Sub

    Private Sub ConsulterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsulterToolStripMenuItem.Click
        frmConsulter.Show()
    End Sub
End Class
