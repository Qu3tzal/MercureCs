using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Mercure
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToutesLesMarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToutesLesFamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToutesLesSousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_Integration_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnArticleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerTousLesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMarqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSousfamilleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu_Item,
            this.articlesToolStripMenuItem,
            this.marquesToolStripMenuItem,
            this.famillesToolStripMenuItem,
            this.sousfamillesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_Menu_Item
            // 
            this.File_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data_Integration_Menu_Item,
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitterToolStripMenuItem});
            this.File_Menu_Item.Name = "File_Menu_Item";
            this.File_Menu_Item.Size = new System.Drawing.Size(54, 20);
            this.File_Menu_Item.Text = "Fichier";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnArticleToolStripMenuItem1,
            this.modifierUnArticleToolStripMenuItem,
            this.supprimerUnArticleToolStripMenuItem,
            this.toolStripSeparator4,
            this.supprimerTousLesArticlesToolStripMenuItem});
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articlesToolStripMenuItem.Text = "Articles";
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneMarqueToolStripMenuItem1,
            this.modifierUneMarqueToolStripMenuItem,
            this.supprimerUneMarqueToolStripMenuItem,
            this.toolStripSeparator5,
            this.supprimerToutesLesMarquesToolStripMenuItem});
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.marquesToolStripMenuItem.Text = "Marques";
            // 
            // famillesToolStripMenuItem
            // 
            this.famillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFamilleToolStripMenuItem,
            this.modifierUneFamilleToolStripMenuItem,
            this.supprimerUneFamilleToolStripMenuItem,
            this.toolStripSeparator6,
            this.supprimerToutesLesFamillesToolStripMenuItem});
            this.famillesToolStripMenuItem.Name = "famillesToolStripMenuItem";
            this.famillesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.famillesToolStripMenuItem.Text = "Familles";
            // 
            // sousfamillesToolStripMenuItem
            // 
            this.sousfamillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSousfamilleToolStripMenuItem1,
            this.modifierUneSousfamilleToolStripMenuItem,
            this.supprimerUneSousfamilleToolStripMenuItem,
            this.toolStripSeparator7,
            this.supprimerToutesLesSousfamillesToolStripMenuItem});
            this.sousfamillesToolStripMenuItem.Name = "sousfamillesToolStripMenuItem";
            this.sousfamillesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sousfamillesToolStripMenuItem.Text = "Sous-familles";
            // 
            // modifierUneSousfamilleToolStripMenuItem
            // 
            this.modifierUneSousfamilleToolStripMenuItem.Name = "modifierUneSousfamilleToolStripMenuItem";
            this.modifierUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.modifierUneSousfamilleToolStripMenuItem.Text = "Modifier une sous-famille";
            // 
            // supprimerUneSousfamilleToolStripMenuItem
            // 
            this.supprimerUneSousfamilleToolStripMenuItem.Name = "supprimerUneSousfamilleToolStripMenuItem";
            this.supprimerUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.supprimerUneSousfamilleToolStripMenuItem.Text = "Supprimer une sous-famille";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(410, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(0, 17);
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 270);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Clicked);
            this.listView1.DoubleClick += new System.EventHandler(this.On_Clicked_Item);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Key_Pressed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnArticleToolStripMenuItem,
            this.modifierLarticleToolStripMenuItem,
            this.supprimerLarticleToolStripMenuItem,
            this.toolStripSeparator1,
            this.ajouterUneMarqueToolStripMenuItem,
            this.modifierLaMarqueToolStripMenuItem,
            this.supprimerLaMarqueToolStripMenuItem,
            this.toolStripSeparator2,
            this.ajouterUneSousfamilleToolStripMenuItem,
            this.modifierLaSousfamilleToolStripMenuItem,
            this.supprimerLaSousfamilleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 214);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // modifierLaSousfamilleToolStripMenuItem
            // 
            this.modifierLaSousfamilleToolStripMenuItem.Name = "modifierLaSousfamilleToolStripMenuItem";
            this.modifierLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierLaSousfamilleToolStripMenuItem.Text = "Modifier la sous-famille";
            // 
            // supprimerLaSousfamilleToolStripMenuItem
            // 
            this.supprimerLaSousfamilleToolStripMenuItem.Name = "supprimerLaSousfamilleToolStripMenuItem";
            this.supprimerLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLaSousfamilleToolStripMenuItem.Text = "Supprimer la sous-famille";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // supprimerToutesLesMarquesToolStripMenuItem
            // 
            this.supprimerToutesLesMarquesToolStripMenuItem.Image = global::Mercure.Properties.Resources.exclamation;
            this.supprimerToutesLesMarquesToolStripMenuItem.Name = "supprimerToutesLesMarquesToolStripMenuItem";
            this.supprimerToutesLesMarquesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.supprimerToutesLesMarquesToolStripMenuItem.Text = "Supprimer toutes les marques";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(228, 6);
            // 
            // supprimerToutesLesFamillesToolStripMenuItem
            // 
            this.supprimerToutesLesFamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.exclamation;
            this.supprimerToutesLesFamillesToolStripMenuItem.Name = "supprimerToutesLesFamillesToolStripMenuItem";
            this.supprimerToutesLesFamillesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.supprimerToutesLesFamillesToolStripMenuItem.Text = "Supprimer toutes les familles";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(223, 6);
            // 
            // supprimerToutesLesSousfamillesToolStripMenuItem
            // 
            this.supprimerToutesLesSousfamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.exclamation;
            this.supprimerToutesLesSousfamillesToolStripMenuItem.Name = "supprimerToutesLesSousfamillesToolStripMenuItem";
            this.supprimerToutesLesSousfamillesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.supprimerToutesLesSousfamillesToolStripMenuItem.Text = "Supprimer toutes les sous-familles";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(252, 6);
            // 
            // ajouterUnArticleToolStripMenuItem
            // 
            this.ajouterUnArticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__plus;
            this.ajouterUnArticleToolStripMenuItem.Name = "ajouterUnArticleToolStripMenuItem";
            this.ajouterUnArticleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ajouterUnArticleToolStripMenuItem.Text = "Ajouter un article";
            this.ajouterUnArticleToolStripMenuItem.Click += new System.EventHandler(this.On_Create_Article_Event);
            // 
            // modifierLarticleToolStripMenuItem
            // 
            this.modifierLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__pencil;
            this.modifierLarticleToolStripMenuItem.Name = "modifierLarticleToolStripMenuItem";
            this.modifierLarticleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierLarticleToolStripMenuItem.Text = "Modifier l\'article";
            this.modifierLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Article_Event);
            // 
            // supprimerLarticleToolStripMenuItem
            // 
            this.supprimerLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__minus;
            this.supprimerLarticleToolStripMenuItem.Name = "supprimerLarticleToolStripMenuItem";
            this.supprimerLarticleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLarticleToolStripMenuItem.Text = "Supprimer l\'article";
            this.supprimerLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Article_Event);
            // 
            // ajouterUneMarqueToolStripMenuItem
            // 
            this.ajouterUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__plus;
            this.ajouterUneMarqueToolStripMenuItem.Name = "ajouterUneMarqueToolStripMenuItem";
            this.ajouterUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ajouterUneMarqueToolStripMenuItem.Text = "Ajouter une marque";
            // 
            // modifierLaMarqueToolStripMenuItem
            // 
            this.modifierLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__pencil;
            this.modifierLaMarqueToolStripMenuItem.Name = "modifierLaMarqueToolStripMenuItem";
            this.modifierLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierLaMarqueToolStripMenuItem.Text = "Modifier la marque";
            // 
            // supprimerLaMarqueToolStripMenuItem
            // 
            this.supprimerLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__minus;
            this.supprimerLaMarqueToolStripMenuItem.Name = "supprimerLaMarqueToolStripMenuItem";
            this.supprimerLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLaMarqueToolStripMenuItem.Text = "Supprimer la marque";
            // 
            // ajouterUneSousfamilleToolStripMenuItem
            // 
            this.ajouterUneSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.ajouterUneSousfamilleToolStripMenuItem.Name = "ajouterUneSousfamilleToolStripMenuItem";
            this.ajouterUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ajouterUneSousfamilleToolStripMenuItem.Text = "Ajouter une sous-famille";
            // 
            // Data_Integration_Menu_Item
            // 
            this.Data_Integration_Menu_Item.Image = global::Mercure.Properties.Resources.database_import;
            this.Data_Integration_Menu_Item.Name = "Data_Integration_Menu_Item";
            this.Data_Integration_Menu_Item.Size = new System.Drawing.Size(218, 22);
            this.Data_Integration_Menu_Item.Text = "Intégrer les données";
            this.Data_Integration_Menu_Item.Click += new System.EventHandler(this.Select_XML_File_Menu_Item_Click);
            // 
            // nettoyerLaBaseDeDonnéeToolStripMenuItem
            // 
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem.Image = global::Mercure.Properties.Resources.database__minus;
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem.Name = "nettoyerLaBaseDeDonnéeToolStripMenuItem";
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem.Text = "Nettoyer la base de donnée";
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem.Click += new System.EventHandler(this.nettoyerLaBaseDeDonnéeToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::Mercure.Properties.Resources.control_power;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // ajouterUnArticleToolStripMenuItem1
            // 
            this.ajouterUnArticleToolStripMenuItem1.Image = global::Mercure.Properties.Resources.box__plus;
            this.ajouterUnArticleToolStripMenuItem1.Name = "ajouterUnArticleToolStripMenuItem1";
            this.ajouterUnArticleToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.ajouterUnArticleToolStripMenuItem1.Text = "Ajouter un article";
            // 
            // modifierUnArticleToolStripMenuItem
            // 
            this.modifierUnArticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__pencil;
            this.modifierUnArticleToolStripMenuItem.Name = "modifierUnArticleToolStripMenuItem";
            this.modifierUnArticleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modifierUnArticleToolStripMenuItem.Text = "Modifier un article";
            // 
            // supprimerUnArticleToolStripMenuItem
            // 
            this.supprimerUnArticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__minus;
            this.supprimerUnArticleToolStripMenuItem.Name = "supprimerUnArticleToolStripMenuItem";
            this.supprimerUnArticleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.supprimerUnArticleToolStripMenuItem.Text = "Supprimer un article";
            // 
            // supprimerTousLesArticlesToolStripMenuItem
            // 
            this.supprimerTousLesArticlesToolStripMenuItem.Image = global::Mercure.Properties.Resources.exclamation;
            this.supprimerTousLesArticlesToolStripMenuItem.Name = "supprimerTousLesArticlesToolStripMenuItem";
            this.supprimerTousLesArticlesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.supprimerTousLesArticlesToolStripMenuItem.Text = "Supprimer tous les articles";
            // 
            // ajouterUneMarqueToolStripMenuItem1
            // 
            this.ajouterUneMarqueToolStripMenuItem1.Image = global::Mercure.Properties.Resources.store__plus;
            this.ajouterUneMarqueToolStripMenuItem1.Name = "ajouterUneMarqueToolStripMenuItem1";
            this.ajouterUneMarqueToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.ajouterUneMarqueToolStripMenuItem1.Text = "Ajouter une marque";
            // 
            // modifierUneMarqueToolStripMenuItem
            // 
            this.modifierUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__pencil;
            this.modifierUneMarqueToolStripMenuItem.Name = "modifierUneMarqueToolStripMenuItem";
            this.modifierUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.modifierUneMarqueToolStripMenuItem.Text = "Modifier une marque";
            // 
            // supprimerUneMarqueToolStripMenuItem
            // 
            this.supprimerUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__minus;
            this.supprimerUneMarqueToolStripMenuItem.Name = "supprimerUneMarqueToolStripMenuItem";
            this.supprimerUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.supprimerUneMarqueToolStripMenuItem.Text = "Supprimer une marque";
            // 
            // ajouterUneFamilleToolStripMenuItem
            // 
            this.ajouterUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__plus;
            this.ajouterUneFamilleToolStripMenuItem.Name = "ajouterUneFamilleToolStripMenuItem";
            this.ajouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ajouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            // 
            // modifierUneFamilleToolStripMenuItem
            // 
            this.modifierUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__pencil;
            this.modifierUneFamilleToolStripMenuItem.Name = "modifierUneFamilleToolStripMenuItem";
            this.modifierUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.modifierUneFamilleToolStripMenuItem.Text = "Modifier une famille";
            // 
            // supprimerUneFamilleToolStripMenuItem
            // 
            this.supprimerUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__minus;
            this.supprimerUneFamilleToolStripMenuItem.Name = "supprimerUneFamilleToolStripMenuItem";
            this.supprimerUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.supprimerUneFamilleToolStripMenuItem.Text = "Supprimer une famille";
            // 
            // ajouterUneSousfamilleToolStripMenuItem1
            // 
            this.ajouterUneSousfamilleToolStripMenuItem1.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.ajouterUneSousfamilleToolStripMenuItem1.Name = "ajouterUneSousfamilleToolStripMenuItem1";
            this.ajouterUneSousfamilleToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.ajouterUneSousfamilleToolStripMenuItem1.Text = "Ajouter une sous-famille";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 316);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercure - Logiciel de gestion de fournitures de bureau";
            this.Load += new System.EventHandler(this.On_Load_Event);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private ToolStripMenuItem File_Menu_Item;
        private ToolStripMenuItem Data_Integration_Menu_Item;
        private ListView listView1;

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ajouterUnArticleToolStripMenuItem;
        private ToolStripMenuItem modifierLarticleToolStripMenuItem;
        private ToolStripMenuItem supprimerLarticleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ajouterUneMarqueToolStripMenuItem;
        private ToolStripMenuItem modifierLaMarqueToolStripMenuItem;
        private ToolStripMenuItem supprimerLaMarqueToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ajouterUneSousfamilleToolStripMenuItem;
        private ToolStripMenuItem modifierLaSousfamilleToolStripMenuItem;
        private ToolStripMenuItem supprimerLaSousfamilleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem articlesToolStripMenuItem;
        private ToolStripMenuItem marquesToolStripMenuItem;
        private ToolStripMenuItem famillesToolStripMenuItem;
        private ToolStripMenuItem sousfamillesToolStripMenuItem;
        private ToolStripMenuItem ajouterUnArticleToolStripMenuItem1;
        private ToolStripMenuItem ajouterUneMarqueToolStripMenuItem1;
        private ToolStripMenuItem ajouterUneFamilleToolStripMenuItem;
        private ToolStripMenuItem ajouterUneSousfamilleToolStripMenuItem1;
        private ToolStripMenuItem modifierUnArticleToolStripMenuItem;
        private ToolStripMenuItem supprimerUnArticleToolStripMenuItem;
        private ToolStripMenuItem modifierUneMarqueToolStripMenuItem;
        private ToolStripMenuItem supprimerUneMarqueToolStripMenuItem;
        private ToolStripMenuItem modifierUneFamilleToolStripMenuItem;
        private ToolStripMenuItem supprimerUneFamilleToolStripMenuItem;
        private ToolStripMenuItem modifierUneSousfamilleToolStripMenuItem;
        private ToolStripMenuItem supprimerUneSousfamilleToolStripMenuItem;
        private ToolStripMenuItem nettoyerLaBaseDeDonnéeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem supprimerTousLesArticlesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem supprimerToutesLesMarquesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem supprimerToutesLesFamillesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem supprimerToutesLesSousfamillesToolStripMenuItem;
    }
}

