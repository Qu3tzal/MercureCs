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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.Data_Integration_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 270);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Clicked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.Load += new System.EventHandler(this.InitList);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void Select_XML_File_Menu_Item_Click(object sender, System.EventArgs e)
        {
           DataIntegrationForm Dif = new DataIntegrationForm(this);
           Dif.ShowDialog();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private ToolStripMenuItem File_Menu_Item;
        private ToolStripMenuItem Data_Integration_Menu_Item;
        private ListView listView1;

        public void InitList(object sender, System.EventArgs e)
        {
            listView1.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantité", -2, HorizontalAlignment.Left);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            int Width = 0;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                Width += listView1.Columns[i].Width;
            }

            int LastWidth = this.Width;
            this.Width = Width + 40;
            this.Height = (int)(this.Width * (9 / 16.0f));

            this.Location = new System.Drawing.Point(this.Left - (this.Width - LastWidth) / 2, this.Top);
        }

        public void loadArticles()
        {
            this.listView1.Clear();

            listView1.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantité", -2, HorizontalAlignment.Left);

            List<Models.Article> Articles = Database.GetInstance().getArticles();

            foreach (Models.Article A in Articles)
            {
                String[] Row = { A.Ref_Article, A.Description, A.Sub_Familly_Name, A.Brand_Name, "" + A.Price_HT, "" + A.Quantity };
                ListViewItem Item = new ListViewItem(Row);
                this.listView1.Items.Add(Item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            int Width = 0;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                Width += listView1.Columns[i].Width;
            }
            int LastWidth = this.Width;
            this.Width = Width + 40;
            this.Height = (int)(this.Width * (9 / 16.0f));

            this.Location = new System.Drawing.Point(this.Left - (this.Width - LastWidth) / 2, this.Top);
        }

    }
}

