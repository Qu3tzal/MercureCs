﻿namespace Mercure
{
    partial class AddArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticleForm));
            this.Main_Panel_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Ref_Description_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Reference_Label = new System.Windows.Forms.Label();
            this.Ref_Text_Box = new System.Windows.Forms.TextBox();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_Text_Box = new System.Windows.Forms.TextBox();
            this.SubFamily_Label = new System.Windows.Forms.Label();
            this.Select_SubFamily_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.SubFamily_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Create_SubFamily_Button = new System.Windows.Forms.Button();
            this.Select_Brand_Label = new System.Windows.Forms.Label();
            this.Select_Brand_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Brand_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Create_Brand_Button = new System.Windows.Forms.Button();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Command_Buttons_Group_Box = new System.Windows.Forms.FlowLayoutPanel();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Main_Panel_Layout.SuspendLayout();
            this.Ref_Description_Layout.SuspendLayout();
            this.Select_SubFamily_Layout.SuspendLayout();
            this.Select_Brand_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Command_Buttons_Group_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel_Layout
            // 
            this.Main_Panel_Layout.AutoSize = true;
            this.Main_Panel_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Panel_Layout.Controls.Add(this.Ref_Description_Layout);
            this.Main_Panel_Layout.Controls.Add(this.Command_Buttons_Group_Box);
            this.Main_Panel_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_Panel_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel_Layout.Name = "Main_Panel_Layout";
            this.Main_Panel_Layout.Size = new System.Drawing.Size(800, 450);
            this.Main_Panel_Layout.TabIndex = 0;
            // 
            // Ref_Description_Layout
            // 
            this.Ref_Description_Layout.AutoSize = true;
            this.Ref_Description_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ref_Description_Layout.Controls.Add(this.Reference_Label);
            this.Ref_Description_Layout.Controls.Add(this.Ref_Text_Box);
            this.Ref_Description_Layout.Controls.Add(this.Description_Label);
            this.Ref_Description_Layout.Controls.Add(this.Description_Text_Box);
            this.Ref_Description_Layout.Controls.Add(this.SubFamily_Label);
            this.Ref_Description_Layout.Controls.Add(this.Select_SubFamily_Layout);
            this.Ref_Description_Layout.Controls.Add(this.Select_Brand_Label);
            this.Ref_Description_Layout.Controls.Add(this.Select_Brand_Layout);
            this.Ref_Description_Layout.Controls.Add(this.Quantity_Label);
            this.Ref_Description_Layout.Controls.Add(this.numericUpDown1);
            this.Ref_Description_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ref_Description_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Ref_Description_Layout.Location = new System.Drawing.Point(3, 3);
            this.Ref_Description_Layout.Name = "Ref_Description_Layout";
            this.Ref_Description_Layout.Size = new System.Drawing.Size(449, 258);
            this.Ref_Description_Layout.TabIndex = 0;
            // 
            // Reference_Label
            // 
            this.Reference_Label.AutoSize = true;
            this.Reference_Label.Location = new System.Drawing.Point(3, 0);
            this.Reference_Label.Name = "Reference_Label";
            this.Reference_Label.Size = new System.Drawing.Size(113, 13);
            this.Reference_Label.TabIndex = 0;
            this.Reference_Label.Text = "Référence de l\'article :";
            // 
            // Ref_Text_Box
            // 
            this.Ref_Text_Box.Location = new System.Drawing.Point(3, 16);
            this.Ref_Text_Box.Name = "Ref_Text_Box";
            this.Ref_Text_Box.Size = new System.Drawing.Size(443, 20);
            this.Ref_Text_Box.TabIndex = 1;
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(3, 39);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(116, 13);
            this.Description_Label.TabIndex = 2;
            this.Description_Label.Text = "Description de l\'article :";
            // 
            // Description_Text_Box
            // 
            this.Description_Text_Box.Location = new System.Drawing.Point(3, 55);
            this.Description_Text_Box.Multiline = true;
            this.Description_Text_Box.Name = "Description_Text_Box";
            this.Description_Text_Box.Size = new System.Drawing.Size(443, 64);
            this.Description_Text_Box.TabIndex = 3;
            // 
            // SubFamily_Label
            // 
            this.SubFamily_Label.AutoSize = true;
            this.SubFamily_Label.Location = new System.Drawing.Point(3, 122);
            this.SubFamily_Label.Name = "SubFamily_Label";
            this.SubFamily_Label.Size = new System.Drawing.Size(140, 13);
            this.SubFamily_Label.TabIndex = 0;
            this.SubFamily_Label.Text = "Choisissez une sous-famille :";
            this.SubFamily_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Select_SubFamily_Layout
            // 
            this.Select_SubFamily_Layout.AutoSize = true;
            this.Select_SubFamily_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Select_SubFamily_Layout.Controls.Add(this.SubFamily_Combo_Box);
            this.Select_SubFamily_Layout.Controls.Add(this.Create_SubFamily_Button);
            this.Select_SubFamily_Layout.Location = new System.Drawing.Point(3, 138);
            this.Select_SubFamily_Layout.Name = "Select_SubFamily_Layout";
            this.Select_SubFamily_Layout.Size = new System.Drawing.Size(443, 29);
            this.Select_SubFamily_Layout.TabIndex = 4;
            // 
            // SubFamily_Combo_Box
            // 
            this.SubFamily_Combo_Box.FormattingEnabled = true;
            this.SubFamily_Combo_Box.Location = new System.Drawing.Point(3, 3);
            this.SubFamily_Combo_Box.Name = "SubFamily_Combo_Box";
            this.SubFamily_Combo_Box.Size = new System.Drawing.Size(296, 21);
            this.SubFamily_Combo_Box.TabIndex = 1;
            // 
            // Create_SubFamily_Button
            // 
            this.Create_SubFamily_Button.Image = global::Mercure.Properties.Resources.sitemap_application_blue;
            this.Create_SubFamily_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_SubFamily_Button.Location = new System.Drawing.Point(305, 3);
            this.Create_SubFamily_Button.Name = "Create_SubFamily_Button";
            this.Create_SubFamily_Button.Size = new System.Drawing.Size(135, 23);
            this.Create_SubFamily_Button.TabIndex = 3;
            this.Create_SubFamily_Button.Text = "Créer une sous-famille";
            this.Create_SubFamily_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Create_SubFamily_Button.UseVisualStyleBackColor = true;
            // 
            // Select_Brand_Label
            // 
            this.Select_Brand_Label.AutoSize = true;
            this.Select_Brand_Label.Location = new System.Drawing.Point(3, 170);
            this.Select_Brand_Label.Name = "Select_Brand_Label";
            this.Select_Brand_Label.Size = new System.Drawing.Size(121, 13);
            this.Select_Brand_Label.TabIndex = 0;
            this.Select_Brand_Label.Text = "Choisissez une marque :";
            // 
            // Select_Brand_Layout
            // 
            this.Select_Brand_Layout.AutoSize = true;
            this.Select_Brand_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Select_Brand_Layout.Controls.Add(this.Brand_Combo_Box);
            this.Select_Brand_Layout.Controls.Add(this.Create_Brand_Button);
            this.Select_Brand_Layout.Location = new System.Drawing.Point(3, 186);
            this.Select_Brand_Layout.Name = "Select_Brand_Layout";
            this.Select_Brand_Layout.Size = new System.Drawing.Size(443, 30);
            this.Select_Brand_Layout.TabIndex = 1;
            // 
            // Brand_Combo_Box
            // 
            this.Brand_Combo_Box.FormattingEnabled = true;
            this.Brand_Combo_Box.Location = new System.Drawing.Point(3, 3);
            this.Brand_Combo_Box.Name = "Brand_Combo_Box";
            this.Brand_Combo_Box.Size = new System.Drawing.Size(296, 21);
            this.Brand_Combo_Box.TabIndex = 0;
            // 
            // Create_Brand_Button
            // 
            this.Create_Brand_Button.Image = global::Mercure.Properties.Resources.store__plus;
            this.Create_Brand_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Brand_Button.Location = new System.Drawing.Point(305, 3);
            this.Create_Brand_Button.Name = "Create_Brand_Button";
            this.Create_Brand_Button.Size = new System.Drawing.Size(135, 24);
            this.Create_Brand_Button.TabIndex = 1;
            this.Create_Brand_Button.Text = "Créer une marque";
            this.Create_Brand_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Create_Brand_Button.UseVisualStyleBackColor = true;
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Location = new System.Drawing.Point(3, 219);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(89, 13);
            this.Quantity_Label.TabIndex = 0;
            this.Quantity_Label.Text = "Quantité à créer :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 235);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // Command_Buttons_Group_Box
            // 
            this.Command_Buttons_Group_Box.AutoSize = true;
            this.Command_Buttons_Group_Box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Command_Buttons_Group_Box.Controls.Add(this.Cancel_Button);
            this.Command_Buttons_Group_Box.Controls.Add(this.Add_Button);
            this.Command_Buttons_Group_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Command_Buttons_Group_Box.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Command_Buttons_Group_Box.Location = new System.Drawing.Point(3, 267);
            this.Command_Buttons_Group_Box.Name = "Command_Buttons_Group_Box";
            this.Command_Buttons_Group_Box.Size = new System.Drawing.Size(449, 29);
            this.Command_Buttons_Group_Box.TabIndex = 4;
            // 
            // Add_Button
            // 
            this.Add_Button.Image = global::Mercure.Properties.Resources.tick;
            this.Add_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Button.Location = new System.Drawing.Point(290, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Ajouter";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Image = global::Mercure.Properties.Resources.cross;
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(371, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Annuler";
            this.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_Panel_Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArticleForm";
            this.Text = "Ajouter un article";
            this.Main_Panel_Layout.ResumeLayout(false);
            this.Main_Panel_Layout.PerformLayout();
            this.Ref_Description_Layout.ResumeLayout(false);
            this.Ref_Description_Layout.PerformLayout();
            this.Select_SubFamily_Layout.ResumeLayout(false);
            this.Select_Brand_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Command_Buttons_Group_Box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main_Panel_Layout;
        private System.Windows.Forms.FlowLayoutPanel Command_Buttons_Group_Box;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.FlowLayoutPanel Ref_Description_Layout;
        private System.Windows.Forms.Label Reference_Label;
        private System.Windows.Forms.TextBox Ref_Text_Box;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.TextBox Description_Text_Box;
        private System.Windows.Forms.Label SubFamily_Label;
        private System.Windows.Forms.FlowLayoutPanel Select_SubFamily_Layout;
        private System.Windows.Forms.ComboBox SubFamily_Combo_Box;
        private System.Windows.Forms.Button Create_SubFamily_Button;
        private System.Windows.Forms.Label Select_Brand_Label;
        private System.Windows.Forms.FlowLayoutPanel Select_Brand_Layout;
        private System.Windows.Forms.ComboBox Brand_Combo_Box;
        private System.Windows.Forms.Button Create_Brand_Button;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}