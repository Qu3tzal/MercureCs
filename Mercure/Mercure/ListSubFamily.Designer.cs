namespace Mercure
{
    partial class ListSubFamily
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSubFamily));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SubFamily_List_View = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sousfamilleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sousfamilleToolStripMenuItem
            // 
            this.sousfamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneSousfamilleToolStripMenuItem,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem1});
            this.sousfamilleToolStripMenuItem.Name = "sousfamilleToolStripMenuItem";
            this.sousfamilleToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sousfamilleToolStripMenuItem.Text = "Sous-famille";
            // 
            // ajouterUneSousfamilleToolStripMenuItem
            // 
            this.ajouterUneSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.ajouterUneSousfamilleToolStripMenuItem.Name = "ajouterUneSousfamilleToolStripMenuItem";
            this.ajouterUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneSousfamilleToolStripMenuItem.Text = "Ajouter une sous-famille";
            this.ajouterUneSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneSousfamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // fermerToolStripMenuItem1
            // 
            this.fermerToolStripMenuItem1.Image = global::Mercure.Properties.Resources.control_power;
            this.fermerToolStripMenuItem1.Name = "fermerToolStripMenuItem1";
            this.fermerToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.fermerToolStripMenuItem1.Text = "Fermer";
            this.fermerToolStripMenuItem1.Click += new System.EventHandler(this.fermerToolStripMenuItem1_Click);
            // 
            // SubFamily_List_View
            // 
            this.SubFamily_List_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFamily_List_View.Location = new System.Drawing.Point(0, 24);
            this.SubFamily_List_View.Name = "SubFamily_List_View";
            this.SubFamily_List_View.Size = new System.Drawing.Size(800, 426);
            this.SubFamily_List_View.TabIndex = 1;
            this.SubFamily_List_View.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLaSousfamilleToolStripMenuItem,
            this.supprimerLaSousfamilleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 48);
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
            // ListSubFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubFamily_List_View);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListSubFamily";
            this.Text = "Liste des sous-familles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneSousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem1;
        private System.Windows.Forms.ListView SubFamily_List_View;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierLaSousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaSousfamilleToolStripMenuItem;
    }
}