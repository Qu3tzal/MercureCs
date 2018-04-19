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
            this.Add_Sub_Family_Menu_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.SubFamily_List_View.ContextMenuStrip = this.contextMenuStrip1;
            this.SubFamily_List_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFamily_List_View.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubFamily_List_View.FullRowSelect = true;
            this.SubFamily_List_View.GridLines = true;
            this.SubFamily_List_View.Location = new System.Drawing.Point(0, 24);
            this.SubFamily_List_View.MultiSelect = false;
            this.SubFamily_List_View.Name = "SubFamily_List_View";
            this.SubFamily_List_View.Size = new System.Drawing.Size(800, 426);
            this.SubFamily_List_View.TabIndex = 1;
            this.SubFamily_List_View.UseCompatibleStateImageBehavior = false;
            this.SubFamily_List_View.View = System.Windows.Forms.View.Details;
            this.SubFamily_List_View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Click);
            this.SubFamily_List_View.DoubleClick += new System.EventHandler(this.On_Double_Click);
            this.SubFamily_List_View.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Key_Pressed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Sub_Family_Menu_Strip,
            this.toolStripSeparator2,
            this.modifierLaSousfamilleToolStripMenuItem,
            this.supprimerLaSousfamilleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // modifierLaSousfamilleToolStripMenuItem
            // 
            this.modifierLaSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.modifierLaSousfamilleToolStripMenuItem.Name = "modifierLaSousfamilleToolStripMenuItem";
            this.modifierLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierLaSousfamilleToolStripMenuItem.Text = "Modifier la sous-famille";
            this.modifierLaSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Event);
            // 
            // supprimerLaSousfamilleToolStripMenuItem
            // 
            this.supprimerLaSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.supprimerLaSousfamilleToolStripMenuItem.Name = "supprimerLaSousfamilleToolStripMenuItem";
            this.supprimerLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerLaSousfamilleToolStripMenuItem.Text = "Supprimer la sous-famille";
            this.supprimerLaSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Event);
            // 
            // Add_Sub_Family_Menu_Strip
            // 
            this.Add_Sub_Family_Menu_Strip.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.Add_Sub_Family_Menu_Strip.Name = "Add_Sub_Family_Menu_Strip";
            this.Add_Sub_Family_Menu_Strip.Size = new System.Drawing.Size(209, 22);
            this.Add_Sub_Family_Menu_Strip.Text = "Ajouter une sous famille";
            this.Add_Sub_Family_Menu_Strip.Click += new System.EventHandler(this.ajouterUneSousfamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Add_Sub_Family_Menu_Strip;
    }
}