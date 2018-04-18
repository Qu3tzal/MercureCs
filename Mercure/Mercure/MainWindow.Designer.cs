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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu_Item});
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
            this.Data_Integration_Menu_Item});
            this.File_Menu_Item.Name = "File_Menu_Item";
            this.File_Menu_Item.Size = new System.Drawing.Size(54, 20);
            this.File_Menu_Item.Text = "Fichier";
            // 
            // Data_Integration_Menu_Item
            // 
            this.Data_Integration_Menu_Item.Image = global::Mercure.Properties.Resources.database_import;
            this.Data_Integration_Menu_Item.Name = "Data_Integration_Menu_Item";
            this.Data_Integration_Menu_Item.Size = new System.Drawing.Size(180, 22);
            this.Data_Integration_Menu_Item.Text = "Intégrer les données";
            this.Data_Integration_Menu_Item.Click += new System.EventHandler(this.Select_XML_File_Menu_Item_Click);
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
            this.supprimerLarticleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // ajouterUnArticleToolStripMenuItem
            // 
            this.ajouterUnArticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__plus;
            this.ajouterUnArticleToolStripMenuItem.Name = "ajouterUnArticleToolStripMenuItem";
            this.ajouterUnArticleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ajouterUnArticleToolStripMenuItem.Text = "Ajouter un article";
            this.ajouterUnArticleToolStripMenuItem.Click += new System.EventHandler(this.On_Create_Article_Event);
            // 
            // modifierLarticleToolStripMenuItem
            // 
            this.modifierLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__pencil;
            this.modifierLarticleToolStripMenuItem.Name = "modifierLarticleToolStripMenuItem";
            this.modifierLarticleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modifierLarticleToolStripMenuItem.Text = "Modifier l\'article";
            this.modifierLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Article_Event);
            // 
            // supprimerLarticleToolStripMenuItem
            // 
            this.supprimerLarticleToolStripMenuItem.Image = global::Mercure.Properties.Resources.box__minus;
            this.supprimerLarticleToolStripMenuItem.Name = "supprimerLarticleToolStripMenuItem";
            this.supprimerLarticleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.supprimerLarticleToolStripMenuItem.Text = "Supprimer l\'article";
            this.supprimerLarticleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Article_Event);
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

    }
}

