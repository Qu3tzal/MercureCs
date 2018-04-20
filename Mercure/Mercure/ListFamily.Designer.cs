namespace Mercure
{
    partial class ListFamily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFamily));
            this.Family_List_View = new System.Windows.Forms.ListView();
            this.Context_Menu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add_Family_Menu_Stip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ModifierLaFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerLaFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.FamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_Menu_Strip.SuspendLayout();
            this.Menu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Family_List_View
            // 
            this.Family_List_View.ContextMenuStrip = this.Context_Menu_Strip;
            this.Family_List_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Family_List_View.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family_List_View.FullRowSelect = true;
            this.Family_List_View.GridLines = true;
            this.Family_List_View.Location = new System.Drawing.Point(0, 24);
            this.Family_List_View.MultiSelect = false;
            this.Family_List_View.Name = "Family_List_View";
            this.Family_List_View.Size = new System.Drawing.Size(800, 426);
            this.Family_List_View.TabIndex = 0;
            this.Family_List_View.UseCompatibleStateImageBehavior = false;
            this.Family_List_View.View = System.Windows.Forms.View.Details;
            this.Family_List_View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.On_Column_Click);
            this.Family_List_View.DoubleClick += new System.EventHandler(this.On_Double_Click);
            this.Family_List_View.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_Key_Pressed);
            // 
            // Context_Menu_Strip
            // 
            this.Context_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Family_Menu_Stip,
            this.toolStripSeparator2,
            this.ModifierLaFamilleToolStripMenuItem,
            this.SupprimerLaFamilleToolStripMenuItem});
            this.Context_Menu_Strip.Name = "contextMenuStrip1";
            this.Context_Menu_Strip.Size = new System.Drawing.Size(181, 98);
            this.Context_Menu_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // Add_Family_Menu_Stip
            // 
            this.Add_Family_Menu_Stip.Image = global::Mercure.Properties.Resources.tagplus;
            this.Add_Family_Menu_Stip.Name = "Add_Family_Menu_Stip";
            this.Add_Family_Menu_Stip.Size = new System.Drawing.Size(180, 22);
            this.Add_Family_Menu_Stip.Text = "Ajouter une famille";
            this.Add_Family_Menu_Stip.Click += new System.EventHandler(this.ajouterUneFamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ModifierLaFamilleToolStripMenuItem
            // 
            this.ModifierLaFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tagpencil;
            this.ModifierLaFamilleToolStripMenuItem.Name = "ModifierLaFamilleToolStripMenuItem";
            this.ModifierLaFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModifierLaFamilleToolStripMenuItem.Text = "Modifier la famille";
            this.ModifierLaFamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Event);
            // 
            // SupprimerLaFamilleToolStripMenuItem
            // 
            this.SupprimerLaFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tagminus;
            this.SupprimerLaFamilleToolStripMenuItem.Name = "SupprimerLaFamilleToolStripMenuItem";
            this.SupprimerLaFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SupprimerLaFamilleToolStripMenuItem.Text = "Supprimer la famille";
            this.SupprimerLaFamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Event);
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FamilleToolStripMenuItem});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.Size = new System.Drawing.Size(800, 24);
            this.Menu_Strip.TabIndex = 1;
            this.Menu_Strip.Text = "menuStrip1";
            // 
            // FamilleToolStripMenuItem
            // 
            this.FamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterUneFamilleToolStripMenuItem,
            this.toolStripSeparator1,
            this.FermerToolStripMenuItem});
            this.FamilleToolStripMenuItem.Name = "FamilleToolStripMenuItem";
            this.FamilleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FamilleToolStripMenuItem.Text = "Famille";
            // 
            // AjouterUneFamilleToolStripMenuItem
            // 
            this.AjouterUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tagplus;
            this.AjouterUneFamilleToolStripMenuItem.Name = "AjouterUneFamilleToolStripMenuItem";
            this.AjouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AjouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            this.AjouterUneFamilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneFamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // FermerToolStripMenuItem
            // 
            this.FermerToolStripMenuItem.Image = global::Mercure.Properties.Resources.controlpower;
            this.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem";
            this.FermerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.FermerToolStripMenuItem.Text = "Fermer";
            this.FermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // ListFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Family_List_View);
            this.Controls.Add(this.Menu_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "ListFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des familles";
            this.Context_Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Family_List_View;
        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem FamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterUneFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FermerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Context_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem ModifierLaFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerLaFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Family_Menu_Stip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}