namespace Mercure
{
    partial class ListBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBrand));
            this.Brand_List_View = new System.Windows.Forms.ListView();
            this.Context_Menu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add_Brand_Menu_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ModifierLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerLaMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Menu_Strip.SuspendLayout();
            this.Menu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Brand_List_View
            // 
            this.Brand_List_View.ContextMenuStrip = this.Context_Menu_Strip;
            this.Brand_List_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Brand_List_View.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_List_View.FullRowSelect = true;
            this.Brand_List_View.GridLines = true;
            this.Brand_List_View.Location = new System.Drawing.Point(0, 24);
            this.Brand_List_View.MultiSelect = false;
            this.Brand_List_View.Name = "Brand_List_View";
            this.Brand_List_View.Size = new System.Drawing.Size(800, 426);
            this.Brand_List_View.TabIndex = 0;
            this.Brand_List_View.UseCompatibleStateImageBehavior = false;
            this.Brand_List_View.View = System.Windows.Forms.View.Details;
            this.Brand_List_View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Click);
            this.Brand_List_View.DoubleClick += new System.EventHandler(this.On_Double_Click);
            this.Brand_List_View.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Key_Pressed);
            // 
            // Context_Menu_Strip
            // 
            this.Context_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Brand_Menu_Strip,
            this.toolStripSeparator2,
            this.ModifierLaMarqueToolStripMenuItem,
            this.SupprimerLaMarqueToolStripMenuItem});
            this.Context_Menu_Strip.Name = "contextMenuStrip1";
            this.Context_Menu_Strip.Size = new System.Drawing.Size(186, 76);
            this.Context_Menu_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // Add_Brand_Menu_Strip
            // 
            this.Add_Brand_Menu_Strip.Image = global::Mercure.Properties.Resources.storeplus;
            this.Add_Brand_Menu_Strip.Name = "Add_Brand_Menu_Strip";
            this.Add_Brand_Menu_Strip.Size = new System.Drawing.Size(185, 22);
            this.Add_Brand_Menu_Strip.Text = "Ajouter une marque";
            this.Add_Brand_Menu_Strip.Click += new System.EventHandler(this.ajouterUneMarqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // ModifierLaMarqueToolStripMenuItem
            // 
            this.ModifierLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.storepencil;
            this.ModifierLaMarqueToolStripMenuItem.Name = "ModifierLaMarqueToolStripMenuItem";
            this.ModifierLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ModifierLaMarqueToolStripMenuItem.Text = "Modifier la marque";
            this.ModifierLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Event);
            // 
            // SupprimerLaMarqueToolStripMenuItem
            // 
            this.SupprimerLaMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.storeminus;
            this.SupprimerLaMarqueToolStripMenuItem.Name = "SupprimerLaMarqueToolStripMenuItem";
            this.SupprimerLaMarqueToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.SupprimerLaMarqueToolStripMenuItem.Text = "Supprimer la marque";
            this.SupprimerLaMarqueToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Event);
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marqueToolStripMenuItem});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.Size = new System.Drawing.Size(800, 24);
            this.Menu_Strip.TabIndex = 1;
            this.Menu_Strip.Text = "menuStrip1";
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneMarqueToolStripMenuItem,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // ajouterUneMarqueToolStripMenuItem
            // 
            this.ajouterUneMarqueToolStripMenuItem.Image = global::Mercure.Properties.Resources.storeplus;
            this.ajouterUneMarqueToolStripMenuItem.Name = "ajouterUneMarqueToolStripMenuItem";
            this.ajouterUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUneMarqueToolStripMenuItem.Text = "Ajouter une marque";
            this.ajouterUneMarqueToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneMarqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Image = global::Mercure.Properties.Resources.controlpower;
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // ListBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Brand_List_View);
            this.Controls.Add(this.Menu_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "ListBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des marques";
            this.Context_Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Brand_List_View;
        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Context_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem ModifierLaMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerLaMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Brand_Menu_Strip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}