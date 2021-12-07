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
        Me.PompesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pompes1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PompesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnEmployéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComptantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaFactureToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpayésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpayésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnEmployerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerUnEmployerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PompesToolStripMenuItem1, Me.PompesToolStripMenuItem, Me.FacturationToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.ImpayésToolStripMenuItem1, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PompesToolStripMenuItem1
        '
        Me.PompesToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.PompesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pompes1ToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.PompesToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PompesToolStripMenuItem1.Name = "PompesToolStripMenuItem1"
        Me.PompesToolStripMenuItem1.Size = New System.Drawing.Size(84, 27)
        Me.PompesToolStripMenuItem1.Text = "Pompes"
        '
        'Pompes1ToolStripMenuItem
        '
        Me.Pompes1ToolStripMenuItem.Name = "Pompes1ToolStripMenuItem"
        Me.Pompes1ToolStripMenuItem.Size = New System.Drawing.Size(231, 28)
        Me.Pompes1ToolStripMenuItem.Text = "Activer/Désactiver"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem1, Me.ConsulterToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(231, 28)
        Me.ToolStripMenuItem2.Text = "Mettre à Jour"
        '
        'ModifierToolStripMenuItem1
        '
        Me.ModifierToolStripMenuItem1.Name = "ModifierToolStripMenuItem1"
        Me.ModifierToolStripMenuItem1.Size = New System.Drawing.Size(224, 28)
        Me.ModifierToolStripMenuItem1.Text = "Modifier"
        '
        'ConsulterToolStripMenuItem
        '
        Me.ConsulterToolStripMenuItem.Name = "ConsulterToolStripMenuItem"
        Me.ConsulterToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ConsulterToolStripMenuItem.Text = "Consulter..."
        '
        'PompesToolStripMenuItem
        '
        Me.PompesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.PompesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnEmployéToolStripMenuItem})
        Me.PompesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PompesToolStripMenuItem.Name = "PompesToolStripMenuItem"
        Me.PompesToolStripMenuItem.Size = New System.Drawing.Size(136, 27)
        Me.PompesToolStripMenuItem.Text = "Administration"
        '
        'AjouterUnEmployéToolStripMenuItem
        '
        Me.AjouterUnEmployéToolStripMenuItem.Name = "AjouterUnEmployéToolStripMenuItem"
        Me.AjouterUnEmployéToolStripMenuItem.Size = New System.Drawing.Size(260, 28)
        Me.AjouterUnEmployéToolStripMenuItem.Text = "Gestion des employés"
        '
        'FacturationToolStripMenuItem
        '
        Me.FacturationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FacturationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaiementToolStripMenuItem, Me.TaxesToolStripMenuItem})
        Me.FacturationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturationToolStripMenuItem.Name = "FacturationToolStripMenuItem"
        Me.FacturationToolStripMenuItem.Size = New System.Drawing.Size(109, 27)
        Me.FacturationToolStripMenuItem.Text = "Facturation"
        '
        'PaiementToolStripMenuItem
        '
        Me.PaiementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem, Me.ComptantToolStripMenuItem})
        Me.PaiementToolStripMenuItem.Name = "PaiementToolStripMenuItem"
        Me.PaiementToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.PaiementToolStripMenuItem.Text = "Paiement"
        '
        'ImprimerLaFactureToolStripMenuItem
        '
        Me.ImprimerLaFactureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem1})
        Me.ImprimerLaFactureToolStripMenuItem.Name = "ImprimerLaFactureToolStripMenuItem"
        Me.ImprimerLaFactureToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.ImprimerLaFactureToolStripMenuItem.Text = "Carte crédit/débit"
        '
        'ImprimerLaFactureToolStripMenuItem1
        '
        Me.ImprimerLaFactureToolStripMenuItem1.Name = "ImprimerLaFactureToolStripMenuItem1"
        Me.ImprimerLaFactureToolStripMenuItem1.Size = New System.Drawing.Size(242, 28)
        Me.ImprimerLaFactureToolStripMenuItem1.Text = "Imprimer la Facture"
        '
        'ComptantToolStripMenuItem
        '
        Me.ComptantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLaFactureToolStripMenuItem2})
        Me.ComptantToolStripMenuItem.Name = "ComptantToolStripMenuItem"
        Me.ComptantToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.ComptantToolStripMenuItem.Text = "Comptant"
        '
        'ImprimerLaFactureToolStripMenuItem2
        '
        Me.ImprimerLaFactureToolStripMenuItem2.Name = "ImprimerLaFactureToolStripMenuItem2"
        Me.ImprimerLaFactureToolStripMenuItem2.Size = New System.Drawing.Size(240, 28)
        Me.ImprimerLaFactureToolStripMenuItem2.Text = "Imprimer la facture"
        '
        'TaxesToolStripMenuItem
        '
        Me.TaxesToolStripMenuItem.Name = "TaxesToolStripMenuItem"
        Me.TaxesToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.TaxesToolStripMenuItem.Text = "Taxes"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaiementsToolStripMenuItem, Me.ImpayésToolStripMenuItem, Me.ListeDesTransactionsParMasterCardToolStripMenuItem, Me.ToolStripSeparator6, Me.ListeDesTrasactionParCarteDébitToolStripMenuItem})
        Me.RapportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(92, 27)
        Me.RapportsToolStripMenuItem.Text = "Rapports"
        '
        'PaiementsToolStripMenuItem
        '
        Me.PaiementsToolStripMenuItem.Name = "PaiementsToolStripMenuItem"
        Me.PaiementsToolStripMenuItem.Size = New System.Drawing.Size(380, 28)
        Me.PaiementsToolStripMenuItem.Text = "Liste des transactions impayéess"
        '
        'ImpayésToolStripMenuItem
        '
        Me.ImpayésToolStripMenuItem.Name = "ImpayésToolStripMenuItem"
        Me.ImpayésToolStripMenuItem.Size = New System.Drawing.Size(380, 28)
        Me.ImpayésToolStripMenuItem.Text = "Liste des transactions par MasterCard"
        '
        'ListeDesTransactionsParMasterCardToolStripMenuItem
        '
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Name = "ListeDesTransactionsParMasterCardToolStripMenuItem"
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Size = New System.Drawing.Size(380, 28)
        Me.ListeDesTransactionsParMasterCardToolStripMenuItem.Text = "Liste des transactions par Carte credit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(377, 6)
        '
        'ListeDesTrasactionParCarteDébitToolStripMenuItem
        '
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Name = "ListeDesTrasactionParCarteDébitToolStripMenuItem"
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Size = New System.Drawing.Size(380, 28)
        Me.ListeDesTrasactionParCarteDébitToolStripMenuItem.Text = "Liste des Trasaction par carte débit"
        '
        'ImpayésToolStripMenuItem1
        '
        Me.ImpayésToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ImpayésToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerToolStripMenuItem1})
        Me.ImpayésToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpayésToolStripMenuItem1.Name = "ImpayésToolStripMenuItem1"
        Me.ImpayésToolStripMenuItem1.Size = New System.Drawing.Size(87, 27)
        Me.ImpayésToolStripMenuItem1.Text = "Impayés"
        '
        'CréerToolStripMenuItem1
        '
        Me.CréerToolStripMenuItem1.Name = "CréerToolStripMenuItem1"
        Me.CréerToolStripMenuItem1.Size = New System.Drawing.Size(224, 28)
        Me.CréerToolStripMenuItem1.Text = "Archivage"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnEmployerToolStripMenuItem, Me.SupprimerUnEmployerToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.ToolStripSeparator2, Me.ÀProposToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(58, 27)
        Me.AdminToolStripMenuItem.Text = "Aide"
        '
        'AjouterUnEmployerToolStripMenuItem
        '
        Me.AjouterUnEmployerToolStripMenuItem.Name = "AjouterUnEmployerToolStripMenuItem"
        Me.AjouterUnEmployerToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AjouterUnEmployerToolStripMenuItem.Text = "Aide"
        '
        'SupprimerUnEmployerToolStripMenuItem
        '
        Me.SupprimerUnEmployerToolStripMenuItem.Name = "SupprimerUnEmployerToolStripMenuItem"
        Me.SupprimerUnEmployerToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.SupprimerUnEmployerToolStripMenuItem.Text = "Nous contacter"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ModifierToolStripMenuItem.Text = "Horaire"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(221, 6)
        '
        'ÀProposToolStripMenuItem
        '
        Me.ÀProposToolStripMenuItem.Name = "ÀProposToolStripMenuItem"
        Me.ÀProposToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ÀProposToolStripMenuItem.Text = "À Propos"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(935, 530)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Système de gestion des pompes Winergie"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FermerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsulterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesTransactionsParMasterCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpayésToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CréerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ListeDesTrasactionParCarteDébitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÀProposToolStripMenuItem As ToolStripMenuItem
End Class
