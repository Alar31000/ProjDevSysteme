<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnEmployerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerUnEmployerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PompesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnEmployéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PompesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pompes1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Pompe2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpayésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComptantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CréerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpayésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PompesToolStripMenuItem1, Me.PompesToolStripMenuItem, Me.FacturationToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.ImpayésToolStripMenuItem1, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(16, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnEmployerToolStripMenuItem, Me.SupprimerUnEmployerToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.ToolStripSeparator2, Me.FermerToolStripMenuItem, Me.ToolStripSeparator7})
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(84, 28)
        Me.AdminToolStripMenuItem.Text = "Aides"
        '
        'AjouterUnEmployerToolStripMenuItem
        '
        Me.AjouterUnEmployerToolStripMenuItem.Name = "AjouterUnEmployerToolStripMenuItem"
        Me.AjouterUnEmployerToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.AjouterUnEmployerToolStripMenuItem.Text = "Aides"
        '
        'SupprimerUnEmployerToolStripMenuItem
        '
        Me.SupprimerUnEmployerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.SupprimerUnEmployerToolStripMenuItem.Name = "SupprimerUnEmployerToolStripMenuItem"
        Me.SupprimerUnEmployerToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.SupprimerUnEmployerToolStripMenuItem.Text = "Nous contacter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(87, 6)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.ModifierToolStripMenuItem.Text = "Heures de travails"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(304, 6)
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'PompesToolStripMenuItem
        '
        Me.PompesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PompesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnEmployéToolStripMenuItem})
        Me.PompesToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PompesToolStripMenuItem.Name = "PompesToolStripMenuItem"
        Me.PompesToolStripMenuItem.Size = New System.Drawing.Size(190, 28)
        Me.PompesToolStripMenuItem.Text = "Administration"
        '
        'AjouterUnEmployéToolStripMenuItem
        '
        Me.AjouterUnEmployéToolStripMenuItem.Name = "AjouterUnEmployéToolStripMenuItem"
        Me.AjouterUnEmployéToolStripMenuItem.Size = New System.Drawing.Size(337, 34)
        Me.AjouterUnEmployéToolStripMenuItem.Text = "Gestion des employés"
        '
        'PompesToolStripMenuItem1
        '
        Me.PompesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PompesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pompes1ToolStripMenuItem, Me.Pompe2ToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.PompesToolStripMenuItem1.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PompesToolStripMenuItem1.Name = "PompesToolStripMenuItem1"
        Me.PompesToolStripMenuItem1.Size = New System.Drawing.Size(105, 28)
        Me.PompesToolStripMenuItem1.Text = "Pompes"
        '
        'Pompes1ToolStripMenuItem
        '
        Me.Pompes1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripSeparator4})
        Me.Pompes1ToolStripMenuItem.Name = "Pompes1ToolStripMenuItem"
        Me.Pompes1ToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.Pompes1ToolStripMenuItem.Text = "Activer..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(267, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(267, 6)
        '
        'Pompe2ToolStripMenuItem
        '
        Me.Pompe2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5})
        Me.Pompe2ToolStripMenuItem.Name = "Pompe2ToolStripMenuItem"
        Me.Pompe2ToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.Pompe2ToolStripMenuItem.Text = "Désactiver..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(267, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerToolStripMenuItem, Me.ModifierToolStripMenuItem1, Me.ConsulterToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(270, 34)
        Me.ToolStripMenuItem2.Text = "Mettre à Jour"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaiementsToolStripMenuItem, Me.ImpayésToolStripMenuItem, Me.ListeDesTransactionsParMasterCardToolStripMenuItem, Me.ToolStripSeparator6, Me.ListeDesTrasactionParCarteDébitToolStripMenuItem})
        Me.RapportsToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(123, 28)
        Me.RapportsToolStripMenuItem.Text = "Rapports"
        '
        'PaiementsToolStripMenuItem
        '
        Me.PaiementsToolStripMenuItem.Name = "PaiementsToolStripMenuItem"
        Me.PaiementsToolStripMenuItem.Size = New System.Drawing.Size(528, 34)
        Me.PaiementsToolStripMenuItem.Text = "Liste des transactions impayéess"
        '
        'ImpayésToolStripMenuItem
        '
        Me.ImpayésToolStripMenuItem.Name = "ImpayésToolStripMenuItem"
        Me.ImpayésToolStripMenuItem.Size = New System.Drawing.Size(528, 34)
        Me.ImpayésToolStripMenuItem.Text = "Liste des transactions par MasterCard"
        '
        'FacturationToolStripMenuItem
        '
        Me.FacturationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.FacturationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaiementToolStripMenuItem, Me.TaxesToolStripMenuItem})
        Me.FacturationToolStripMenuItem.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturationToolStripMenuItem.Name = "FacturationToolStripMenuItem"
        Me.FacturationToolStripMenuItem.Size = New System.Drawing.Size(154, 28)
        Me.FacturationToolStripMenuItem.Text = "Facturation"
        '
        'PaiementToolStripMenuItem
        '
        Me.PaiementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem, Me.ComptantToolStripMenuItem})
        Me.PaiementToolStripMenuItem.Name = "PaiementToolStripMenuItem"
        Me.PaiementToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PaiementToolStripMenuItem.Text = "Paiement"
        '
        'ImprimerLaFactureToolStripMenuItem
        '
        Me.ImprimerLaFactureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem1})
        Me.ImprimerLaFactureToolStripMenuItem.Name = "ImprimerLaFactureToolStripMenuItem"
        Me.ImprimerLaFactureToolStripMenuItem.Size = New System.Drawing.Size(299, 34)
        Me.ImprimerLaFactureToolStripMenuItem.Text = "Carte crédit/débit"
        '
        'ImprimerLaFactureToolStripMenuItem1
        '
        Me.ImprimerLaFactureToolStripMenuItem1.Name = "ImprimerLaFactureToolStripMenuItem1"
        Me.ImprimerLaFactureToolStripMenuItem1.Size = New System.Drawing.Size(326, 34)
        Me.ImprimerLaFactureToolStripMenuItem1.Text = "imprimer la Facture"
        '
        'ComptantToolStripMenuItem
        '
        Me.ComptantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem2})
        Me.ComptantToolStripMenuItem.Name = "ComptantToolStripMenuItem"
        Me.ComptantToolStripMenuItem.Size = New System.Drawing.Size(299, 34)
        Me.ComptantToolStripMenuItem.Text = "Comptant"
        '
        'ImprimerLaFactureToolStripMenuItem2
        '
        Me.ImprimerLaFactureToolStripMenuItem2.Name = "ImprimerLaFactureToolStripMenuItem2"
        Me.ImprimerLaFactureToolStripMenuItem2.Size = New System.Drawing.Size(321, 34)
        Me.ImprimerLaFactureToolStripMenuItem2.Text = "Imprimer la facture"
        '
        'TaxesToolStripMenuItem
        '
        Me.TaxesToolStripMenuItem.Name = "TaxesToolStripMenuItem"
        Me.TaxesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.TaxesToolStripMenuItem.Text = "Taxes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 360)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Main_page.My.Resources.Resources.cs_1
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(504, 278)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenue a votre environnement de travail."
        '
        'CréerToolStripMenuItem
        '
        Me.CréerToolStripMenuItem.Name = "CréerToolStripMenuItem"
        Me.CréerToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CréerToolStripMenuItem.Text = "Créer..."
        '
        'ModifierToolStripMenuItem1
        '
        Me.ModifierToolStripMenuItem1.Name = "ModifierToolStripMenuItem1"
        Me.ModifierToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.ModifierToolStripMenuItem1.Text = "Modifier"
        '
        'ConsulterToolStripMenuItem
        '
        Me.ConsulterToolStripMenuItem.Name = "ConsulterToolStripMenuItem"
        Me.ConsulterToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ConsulterToolStripMenuItem.Text = "Consulter..."
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer..."
        '
        'ListeDesTransactionsParMasterCardToolStripMenuItem
        '
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Name = "ListeDesTransactionsParMasterCardToolStripMenuItem"
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Size = New System.Drawing.Size(528, 34)
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Text = "Liste des transactions par Carte credit"
        '
        'ImpayésToolStripMenuItem1
        '
        Me.ImpayésToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ImpayésToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerToolStripMenuItem1})
        Me.ImpayésToolStripMenuItem1.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpayésToolStripMenuItem1.Name = "ImpayésToolStripMenuItem1"
        Me.ImpayésToolStripMenuItem1.Size = New System.Drawing.Size(114, 28)
        Me.ImpayésToolStripMenuItem1.Text = "Impayés"
        '
        'CréerToolStripMenuItem1
        '
        Me.CréerToolStripMenuItem1.Name = "CréerToolStripMenuItem1"
        Me.CréerToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.CréerToolStripMenuItem1.Text = "Créer..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(525, 6)
        '
        'ListeDesTrasactionParCarteDébitToolStripMenuItem
        '
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Name = "ListeDesTrasactionParCarteDébitToolStripMenuItem"
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Size = New System.Drawing.Size(528, 34)
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Text = "Liste des Trasaction par carte débit"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(304, 6)
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 652)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Principal"
        Me.Text = "Système de gestion du Station service PATROL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterUnEmployerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerUnEmployerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PompesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterUnEmployéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PompesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Pompes1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pompe2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaiementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpayésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaiementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerLaFactureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaxesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerLaFactureToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComptantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerLaFactureToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CréerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsulterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesTransactionsParMasterCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpayésToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CréerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ListeDesTrasactionParCarteDébitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
End Class
