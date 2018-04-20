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
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.File_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_Integration_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUnArticleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUneMarqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListerLesMarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListerLesFamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUneSousfamilleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListerLesSousfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_Bar = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Article_List_View = new System.Windows.Forms.ListView();
            this.Context_Menu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AjouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifierLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AjouterUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifierLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AjouterUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifierLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Strip.SuspendLayout();
            this.Status_Bar.SuspendLayout();
            this.Context_Menu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu_Item,
            this.articlesToolStripMenuItem,
            this.marquesToolStripMenuItem,
            this.famillesToolStripMenuItem,
            this.sousfamillesToolStripMenuItem});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_Strip.Size = new System.Drawing.Size(410, 24);
            this.Menu_Strip.TabIndex = 0;
            this.Menu_Strip.Text = "MenuStrip1";
            // 
            // File_Menu_Item
            // 
            this.File_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data_Integration_Menu_Item,
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem,
            this.toolStripSeparator3,
            this.QuitterToolStripMenuItem});
            this.File_Menu_Item.Name = "File_Menu_Item";
            this.File_Menu_Item.Size = new System.Drawing.Size(54, 20);
            this.File_Menu_Item.Text = "Fichier";
            // 
            // Data_Integration_Menu_Item
            // 
            this.Data_Integration_Menu_Item.Image = global::Mercure.Properties.Resources.databaseimport;
            this.Data_Integration_Menu_Item.Name = "Data_Integration_Menu_Item";
            this.Data_Integration_Menu_Item.Size = new System.Drawing.Size(218, 22);
            this.Data_Integration_Menu_Item.Text = "Intégrer les données";
            this.Data_Integration_Menu_Item.Click += new System.EventHandler(this.Select_XML_File_Menu_Item_Click);
            // 
            // NettoyerLaBaseDeDonnéeToolStripMenuItem
            // 
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem.Image = global::Mercure.Properties.Resources.databaseminus;
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem.Name = "NettoyerLaBaseDeDonnéeToolStripMenuItem";
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem.Text = "Nettoyer la base de donnée";
            this.NettoyerLaBaseDeDonnéeToolStripMenuItem.Click += new System.EventHandler(this.NettoyerLaBaseDeDonnéeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // QuitterToolStripMenuItem
            // 
            this.QuitterToolStripMenuItem.Image = global::Mercure.Properties.Resources.controlpower;
            this.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
            this.QuitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.QuitterToolStripMenuItem.Text = "Quitter";
            this.QuitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUnArticleToolStripMenuItem1});
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.articlesToolStripMenuItem.Text = "Articles";
            // 
            // AjouterUnArticleToolStripMenuItem1
            // 
            this.AjouterUnArticleToolStripMenuItem1.Image = global::Mercure.Properties.Resources.boxplus;
            this.AjouterUnArticleToolStripMenuItem1.Name = "AjouterUnArticleToolStripMenuItem1";
            this.AjouterUnArticleToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.AjouterUnArticleToolStripMenuItem1.Text = "Ajouter un article";
            this.AjouterUnArticleToolStripMenuItem1.Click += new System.EventHandler(this.On_Create_Article_Event);
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUneMarqueToolStripMenuItem1,
            this.ListerLesMarquesToolStripMenuItem});
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.marquesToolStripMenuItem.Text = "Marques";
            // 
            // AjouterUneMarqueToolStripMenuItem1
            // 
            this.AjouterUneMarqueToolStripMenuItem1.Image = global::Mercure.Properties.Resources.storeplus;
            this.AjouterUneMarqueToolStripMenuItem1.Name = "AjouterUneMarqueToolStripMenuItem1";
            this.AjouterUneMarqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AjouterUneMarqueToolStripMenuItem1.Text = "Ajouter une marque";
            this.AjouterUneMarqueToolStripMenuItem1.Click += new System.EventHandler(this.AjouterUneMarqueToolStripMenuItem1_Click);
            // 
            // ListerLesMarquesToolStripMenuItem
            // 
            this.ListerLesMarquesToolStripMenuItem.Image = global::Mercure.Properties.Resources.store;
            this.ListerLesMarquesToolStripMenuItem.Name = "ListerLesMarquesToolStripMenuItem";
            this.ListerLesMarquesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListerLesMarquesToolStripMenuItem.Text = "Lister les marques";
            this.ListerLesMarquesToolStripMenuItem.Click += new System.EventHandler(this.ListerLesMarquesToolStripMenuItem_Click);
            // 
            // famillesToolStripMenuItem
            // 
            this.famillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUneFamilleToolStripMenuItem,
            this.ListerLesFamillesToolStripMenuItem});
            this.famillesToolStripMenuItem.Name = "famillesToolStripMenuItem";
            this.famillesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.famillesToolStripMenuItem.Text = "Familles";
            // 
            // AjouterUneFamilleToolStripMenuItem
            // 
            this.AjouterUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tagplus;
            this.AjouterUneFamilleToolStripMenuItem.Name = "AjouterUneFamilleToolStripMenuItem";
            this.AjouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AjouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            this.AjouterUneFamilleToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneFamilleToolStripMenuItem_Click);
            // 
            // ListerLesFamillesToolStripMenuItem
            // 
            this.ListerLesFamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag;
            this.ListerLesFamillesToolStripMenuItem.Name = "ListerLesFamillesToolStripMenuItem";
            this.ListerLesFamillesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ListerLesFamillesToolStripMenuItem.Text = "Lister les familles";
            this.ListerLesFamillesToolStripMenuItem.Click += new System.EventHandler(this.ListerLesFamillesToolStripMenuItem_Click);
            // 
            // sousfamillesToolStripMenuItem
            // 
            this.sousfamillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUneSousfamilleToolStripMenuItem1,
            this.ListerLesSousfamillesToolStripMenuItem});
            this.sousfamillesToolStripMenuItem.Name = "sousfamillesToolStripMenuItem";
            this.sousfamillesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sousfamillesToolStripMenuItem.Text = "Sous-familles";
            // 
            // AjouterUneSousfamilleToolStripMenuItem1
            // 
            this.AjouterUneSousfamilleToolStripMenuItem1.Name = "AjouterUneSousfamilleToolStripMenuItem1";
            this.AjouterUneSousfamilleToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.AjouterUneSousfamilleToolStripMenuItem1.Text = "Ajouter une sous-famille";
            this.AjouterUneSousfamilleToolStripMenuItem1.Click += new System.EventHandler(this.On_Add_Sub_Family);
            // 
            // ListerLesSousfamillesToolStripMenuItem
            // 
            this.ListerLesSousfamillesToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
            this.ListerLesSousfamillesToolStripMenuItem.Name = "ListerLesSousfamillesToolStripMenuItem";
            this.ListerLesSousfamillesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ListerLesSousfamillesToolStripMenuItem.Text = "Lister les sous-familles";
            this.ListerLesSousfamillesToolStripMenuItem.Click += new System.EventHandler(this.ListerLesSousfamillesToolStripMenuItem_Click);
            // 
            // Status_Bar
            // 
            this.Status_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label});
            this.Status_Bar.Location = new System.Drawing.Point(0, 294);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.Size = new System.Drawing.Size(410, 22);
            this.Status_Bar.TabIndex = 1;
            this.Status_Bar.Text = "Status_Bar";
            // 
            // Status_Label
            // 
            this.Status_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(0, 17);
            // 
            // Article_List_View
            // 
            this.Article_List_View.ContextMenuStrip = this.Context_Menu_Strip;
            this.Article_List_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Article_List_View.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Article_List_View.FullRowSelect = true;
            this.Article_List_View.GridLines = true;
            this.Article_List_View.Location = new System.Drawing.Point(0, 24);
            this.Article_List_View.MultiSelect = false;
            this.Article_List_View.Name = "Article_List_View";
            this.Article_List_View.Size = new System.Drawing.Size(410, 270);
            this.Article_List_View.TabIndex = 2;
            this.Article_List_View.UseCompatibleStateImageBehavior = false;
            this.Article_List_View.View = System.Windows.Forms.View.Details;
            this.Article_List_View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Clicked);
            this.Article_List_View.DoubleClick += new System.EventHandler(this.On_Clicked_Item);
            this.Article_List_View.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Key_Pressed);
            // 
            // Context_Menu_Strip
            // 
            this.Context_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUnArticleToolStripMenuItem,
            this.ModifierLarticleToolStripMenuItem,
            this.SupprimerLarticleToolStripMenuItem,
            this.toolStripSeparator1,
            this.AjouterUneMarqueToolStripMenuItem,
            this.ModifierLaMarqueToolStripMenuItem,
            this.toolStripSeparator2,
            this.AjouterUneSousfamilleToolStripMenuItem,
            this.ModifierLaSousfamilleToolStripMenuItem});
            this.Context_Menu_Strip.Name = "contextMenuStrip1";
            this.Context_Menu_Strip.Size = new System.Drawing.Size(205, 170);
            this.Context_Menu_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // AjouterUnArticleToolStripMenuItem
            // 
            this.AjouterUnArticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.boxplus;
            this.AjouterUnArticleToolStripMenuItem.Name = "AjouterUnArticleToolStripMenuItem";
            this.AjouterUnArticleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AjouterUnArticleToolStripMenuItem.Text = "Ajouter un article";
            this.AjouterUnArticleToolStripMenuItem.Click += new System.EventHandler(this.On_Create_Article_Event);
            // 
            // ModifierLarticleToolStripMenuItem
            // 
            this.ModifierLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.boxpencil;
            this.ModifierLarticleToolStripMenuItem.Name = "ModifierLarticleToolStripMenuItem";
            this.ModifierLarticleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ModifierLarticleToolStripMenuItem.Text = "Modifier l\'article";
            this.ModifierLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Article_Event);
            // 
            // SupprimerLarticleToolStripMenuItem
            // 
            this.SupprimerLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.boxminus;
            this.SupprimerLarticleToolStripMenuItem.Name = "SupprimerLarticleToolStripMenuItem";
            this.SupprimerLarticleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.SupprimerLarticleToolStripMenuItem.Text = "Supprimer l\'article";
            this.SupprimerLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Article_Event);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // AjouterUneMarqueToolStripMenuItem
            // 
            this.AjouterUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.storeplus;
            this.AjouterUneMarqueToolStripMenuItem.Name = "AjouterUneMarqueToolStripMenuItem";
            this.AjouterUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AjouterUneMarqueToolStripMenuItem.Text = "Ajouter une marque";
            this.AjouterUneMarqueToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneMarqueToolStripMenuItem_Click);
            // 
            // ModifierLaMarqueToolStripMenuItem
            // 
            this.ModifierLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.storepencil;
            this.ModifierLaMarqueToolStripMenuItem.Name = "ModifierLaMarqueToolStripMenuItem";
            this.ModifierLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ModifierLaMarqueToolStripMenuItem.Text = "Modifier la marque";
            this.ModifierLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Brand);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // AjouterUneSousfamilleToolStripMenuItem
            // 
            this.AjouterUneSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
            this.AjouterUneSousfamilleToolStripMenuItem.Name = "AjouterUneSousfamilleToolStripMenuItem";
            this.AjouterUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AjouterUneSousfamilleToolStripMenuItem.Text = "Ajouter une sous-famille";
            this.AjouterUneSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Add_Sub_Family);
            // 
            // ModifierLaSousfamilleToolStripMenuItem
            // 
            this.ModifierLaSousfamilleToolStripMenuItem.Name = "ModifierLaSousfamilleToolStripMenuItem";
            this.ModifierLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ModifierLaSousfamilleToolStripMenuItem.Text = "Modifier la sous-famille";
            this.ModifierLaSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Sub_Family);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 316);
            this.Controls.Add(this.Article_List_View);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.Menu_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercure - Logiciel de gestion de fournitures de bureau";
            this.Load += new System.EventHandler(this.On_Load_Event);
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.Status_Bar.ResumeLayout(false);
            this.Status_Bar.PerformLayout();
            this.Context_Menu_Strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.StatusStrip Status_Bar;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private ToolStripMenuItem File_Menu_Item;
        private ToolStripMenuItem Data_Integration_Menu_Item;
        private ListView Article_List_View;

        private ContextMenuStrip Context_Menu_Strip;
        private ToolStripMenuItem AjouterUnArticleToolStripMenuItem;
        private ToolStripMenuItem ModifierLarticleToolStripMenuItem;
        private ToolStripMenuItem SupprimerLarticleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem AjouterUneMarqueToolStripMenuItem;
        private ToolStripMenuItem ModifierLaMarqueToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem AjouterUneSousfamilleToolStripMenuItem;
        private ToolStripMenuItem ModifierLaSousfamilleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem QuitterToolStripMenuItem;
        private ToolStripMenuItem articlesToolStripMenuItem;
        private ToolStripMenuItem marquesToolStripMenuItem;
        private ToolStripMenuItem famillesToolStripMenuItem;
        private ToolStripMenuItem sousfamillesToolStripMenuItem;
        private ToolStripMenuItem AjouterUnArticleToolStripMenuItem1;
        private ToolStripMenuItem AjouterUneMarqueToolStripMenuItem1;
        private ToolStripMenuItem AjouterUneFamilleToolStripMenuItem;
        private ToolStripMenuItem AjouterUneSousfamilleToolStripMenuItem1;
        private ToolStripMenuItem NettoyerLaBaseDeDonnéeToolStripMenuItem;
        private ToolStripMenuItem ListerLesMarquesToolStripMenuItem;
        private ToolStripMenuItem ListerLesFamillesToolStripMenuItem;
        private ToolStripMenuItem ListerLesSousfamillesToolStripMenuItem;
    }
}

