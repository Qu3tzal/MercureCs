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
            this.Data_Integration_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerLaBaseDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnArticleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMarqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesMarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesFamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSousfamilleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesSousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::Mercure.Properties.Resources.control_power;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnArticleToolStripMenuItem1});
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articlesToolStripMenuItem.Text = "Articles";
            // 
            // ajouterUnArticleToolStripMenuItem1
            // 
            this.ajouterUnArticleToolStripMenuItem1.Image = global::Mercure.Properties.Resources.box__plus;
            this.ajouterUnArticleToolStripMenuItem1.Name = "ajouterUnArticleToolStripMenuItem1";
            this.ajouterUnArticleToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.ajouterUnArticleToolStripMenuItem1.Text = "Ajouter un article";
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneMarqueToolStripMenuItem1,
            this.listerLesMarquesToolStripMenuItem});
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.marquesToolStripMenuItem.Text = "Marques";
            // 
            // ajouterUneMarqueToolStripMenuItem1
            // 
            this.ajouterUneMarqueToolStripMenuItem1.Image = global::Mercure.Properties.Resources.store__plus;
            this.ajouterUneMarqueToolStripMenuItem1.Name = "ajouterUneMarqueToolStripMenuItem1";
            this.ajouterUneMarqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajouterUneMarqueToolStripMenuItem1.Text = "Ajouter une marque";
            this.ajouterUneMarqueToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneMarqueToolStripMenuItem1_Click);
            // 
            // listerLesMarquesToolStripMenuItem
            // 
            this.listerLesMarquesToolStripMenuItem.Image = global::Mercure.Properties.Resources.store;
            this.listerLesMarquesToolStripMenuItem.Name = "listerLesMarquesToolStripMenuItem";
            this.listerLesMarquesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listerLesMarquesToolStripMenuItem.Text = "Lister les marques";
            this.listerLesMarquesToolStripMenuItem.Click += new System.EventHandler(this.listerLesMarquesToolStripMenuItem_Click);
            // 
            // famillesToolStripMenuItem
            // 
            this.famillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFamilleToolStripMenuItem,
            this.listerLesFamillesToolStripMenuItem});
            this.famillesToolStripMenuItem.Name = "famillesToolStripMenuItem";
            this.famillesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.famillesToolStripMenuItem.Text = "Familles";
            // 
            // ajouterUneFamilleToolStripMenuItem
            // 
            this.ajouterUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__plus;
            this.ajouterUneFamilleToolStripMenuItem.Name = "ajouterUneFamilleToolStripMenuItem";
            this.ajouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            // 
            // listerLesFamillesToolStripMenuItem
            // 
            this.listerLesFamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag;
            this.listerLesFamillesToolStripMenuItem.Name = "listerLesFamillesToolStripMenuItem";
            this.listerLesFamillesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listerLesFamillesToolStripMenuItem.Text = "Lister les familles";
            this.listerLesFamillesToolStripMenuItem.Click += new System.EventHandler(this.listerLesFamillesToolStripMenuItem_Click);
            // 
            // sousfamillesToolStripMenuItem
            // 
            this.sousfamillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSousfamilleToolStripMenuItem1,
            this.listerLesSousfamillesToolStripMenuItem});
            this.sousfamillesToolStripMenuItem.Name = "sousfamillesToolStripMenuItem";
            this.sousfamillesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sousfamillesToolStripMenuItem.Text = "Sous-familles";
            // 
            // ajouterUneSousfamilleToolStripMenuItem1
            // 
            this.ajouterUneSousfamilleToolStripMenuItem1.Name = "ajouterUneSousfamilleToolStripMenuItem1";
            this.ajouterUneSousfamilleToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneSousfamilleToolStripMenuItem1.Text = "Ajouter une sous-famille";
            // 
            // listerLesSousfamillesToolStripMenuItem
            // 
            this.listerLesSousfamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.listerLesSousfamillesToolStripMenuItem.Name = "listerLesSousfamillesToolStripMenuItem";
            this.listerLesSousfamillesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listerLesSousfamillesToolStripMenuItem.Text = "Lister les sous-familles";
            this.listerLesSousfamillesToolStripMenuItem.Click += new System.EventHandler(this.listerLesSousfamillesToolStripMenuItem_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // ajouterUneMarqueToolStripMenuItem
            // 
            this.ajouterUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__plus;
            this.ajouterUneMarqueToolStripMenuItem.Name = "ajouterUneMarqueToolStripMenuItem";
            this.ajouterUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ajouterUneMarqueToolStripMenuItem.Text = "Ajouter une marque";
            this.ajouterUneMarqueToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneMarqueToolStripMenuItem_Click);
            // 
            // modifierLaMarqueToolStripMenuItem
            // 
            this.modifierLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__pencil;
            this.modifierLaMarqueToolStripMenuItem.Name = "modifierLaMarqueToolStripMenuItem";
            this.modifierLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierLaMarqueToolStripMenuItem.Text = "Modifier la marque";
            this.modifierLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.modifierLaMarqueToolStripMenuItem_Click);
            // 
            // supprimerLaMarqueToolStripMenuItem
            // 
            this.supprimerLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.store__minus;
            this.supprimerLaMarqueToolStripMenuItem.Name = "supprimerLaMarqueToolStripMenuItem";
            this.supprimerLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLaMarqueToolStripMenuItem.Text = "Supprimer la marque";
            this.supprimerLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.supprimerLaMarqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // ajouterUneSousfamilleToolStripMenuItem
            // 
            this.ajouterUneSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.ajouterUneSousfamilleToolStripMenuItem.Name = "ajouterUneSousfamilleToolStripMenuItem";
            this.ajouterUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ajouterUneSousfamilleToolStripMenuItem.Text = "Ajouter une sous-famille";
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
        private ToolStripMenuItem nettoyerLaBaseDeDonnéeToolStripMenuItem;
        private ToolStripMenuItem listerLesMarquesToolStripMenuItem;
        private ToolStripMenuItem listerLesFamillesToolStripMenuItem;
        private ToolStripMenuItem listerLesSousfamillesToolStripMenuItem;
    }
}

