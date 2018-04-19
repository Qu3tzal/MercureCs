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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierLaFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Family_Menu_Stip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Family_List_View
            // 
            this.Family_List_View.ContextMenuStrip = this.contextMenuStrip1;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFamilleToolStripMenuItem,
            this.toolStripSeparator1,
            this.fermerToolStripMenuItem});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // ajouterUneFamilleToolStripMenuItem
            // 
            this.ajouterUneFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__plus;
            this.ajouterUneFamilleToolStripMenuItem.Name = "ajouterUneFamilleToolStripMenuItem";
            this.ajouterUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ajouterUneFamilleToolStripMenuItem.Text = "Ajouter une famille";
            this.ajouterUneFamilleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneFamilleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Image = global::Mercure.Properties.Resources.control_power;
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Family_Menu_Stip,
            this.toolStripSeparator2,
            this.modifierLaFamilleToolStripMenuItem,
            this.supprimerLaFamilleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.On_Open_Menu_Strip);
            // 
            // modifierLaFamilleToolStripMenuItem
            // 
            this.modifierLaFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__pencil;
            this.modifierLaFamilleToolStripMenuItem.Name = "modifierLaFamilleToolStripMenuItem";
            this.modifierLaFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierLaFamilleToolStripMenuItem.Text = "Modifier la famille";
            this.modifierLaFamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Modify_Event);
            // 
            // supprimerLaFamilleToolStripMenuItem
            // 
            this.supprimerLaFamilleToolStripMenuItem.Image = global::Mercure.Properties.Resources.tag__minus;
            this.supprimerLaFamilleToolStripMenuItem.Name = "supprimerLaFamilleToolStripMenuItem";
            this.supprimerLaFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerLaFamilleToolStripMenuItem.Text = "Supprimer la famille";
            this.supprimerLaFamilleToolStripMenuItem.Click += new System.EventHandler(this.On_Delete_Event);
            // 
            // Add_Family_Menu_Stip
            // 
            this.Add_Family_Menu_Stip.Image = global::Mercure.Properties.Resources.tag__plus;
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
            // ListFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Family_List_View);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des familles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Family_List_View;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierLaFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Family_Menu_Stip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}