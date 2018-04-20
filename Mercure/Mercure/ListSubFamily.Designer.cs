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
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.SousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AouterUneSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FermerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SubFamily_List_View = new System.Windows.Forms.ListView();
            this.Context_Menu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add_Sub_Family_Menu_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ModifierLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerLaSousfamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Strip.SuspendLayout();
            this.Context_Menu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SousfamilleToolStripMenuItem});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.Size = new System.Drawing.Size(800, 24);
            this.Menu_Strip.TabIndex = 0;
            this.Menu_Strip.Text = "menuStrip1";
            // 
            // SousfamilleToolStripMenuItem
            // 
            this.SousfamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AouterUneSousfamilleToolStripMenuItem,
            this.toolStripSeparator1,
            this.FermerToolStripMenuItem1});
            this.SousfamilleToolStripMenuItem.Name = "SousfamilleToolStripMenuItem";
            this.SousfamilleToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.SousfamilleToolStripMenuItem.Text = "Sous-famille";
            // 
            // AouterUneSousfamilleToolStripMenuItem
            // 
            this.AouterUneSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
            this.AouterUneSousfamilleToolStripMenuItem.Name = "AouterUneSousfamilleToolStripMenuItem";
            this.AouterUneSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.AouterUneSousfamilleToolStripMenuItem.Text = "Ajouter une sous-famille";
            this.AouterUneSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneSousfamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // FermerToolStripMenuItem1
            // 
            this.FermerToolStripMenuItem1.Image = global::Mercure.Properties.Resources.controlpower;
            this.FermerToolStripMenuItem1.Name = "FermerToolStripMenuItem1";
            this.FermerToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.FermerToolStripMenuItem1.Text = "Fermer";
            this.FermerToolStripMenuItem1.Click += new System.EventHandler(this.fermerToolStripMenuItem1_Click);
            // 
            // SubFamily_List_View
            // 
            this.SubFamily_List_View.ContextMenuStrip = this.Context_Menu_Strip;
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
            // Context_Menu_Strip
            // 
            this.Context_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Sub_Family_Menu_Strip,
            this.toolStripSeparator2,
            this.ModifierLaSousfamilleToolStripMenuItem,
            this.SupprimerLaSousfamilleToolStripMenuItem});
            this.Context_Menu_Strip.Name = "contextMenuStrip1";
            this.Context_Menu_Strip.Size = new System.Drawing.Size(210, 98);
            this.Context_Menu_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // Add_Sub_Family_Menu_Strip
            // 
            this.Add_Sub_Family_Menu_Strip.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
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
            // ModifierLaSousfamilleToolStripMenuItem
            // 
            this.ModifierLaSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
            this.ModifierLaSousfamilleToolStripMenuItem.Name = "ModifierLaSousfamilleToolStripMenuItem";
            this.ModifierLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ModifierLaSousfamilleToolStripMenuItem.Text = "Modifier la sous-famille";
            this.ModifierLaSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Event);
            // 
            // SupprimerLaSousfamilleToolStripMenuItem
            // 
            this.SupprimerLaSousfamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.sitemapapplicationblue;
            this.SupprimerLaSousfamilleToolStripMenuItem.Name = "SupprimerLaSousfamilleToolStripMenuItem";
            this.SupprimerLaSousfamilleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.SupprimerLaSousfamilleToolStripMenuItem.Text = "Supprimer la sous-famille";
            this.SupprimerLaSousfamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Event);
            // 
            // ListSubFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubFamily_List_View);
            this.Controls.Add(this.Menu_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "ListSubFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des sous-familles";
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.Context_Menu_Strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem SousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AouterUneSousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FermerToolStripMenuItem1;
        private System.Windows.Forms.ListView SubFamily_List_View;
        private System.Windows.Forms.ContextMenuStrip Context_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem ModifierLaSousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerLaSousfamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Add_Sub_Family_Menu_Strip;
    }
}