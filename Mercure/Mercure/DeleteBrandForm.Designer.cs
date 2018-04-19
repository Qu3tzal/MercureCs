namespace Mercure
{
    partial class DeleteBrandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBrandForm));
            this.Main_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Delete_Brand_Label = new System.Windows.Forms.Label();
            this.Brand_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Command_Controls_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Main_Layout.SuspendLayout();
            this.Command_Controls_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Layout
            // 
            this.Main_Layout.AutoSize = true;
            this.Main_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Layout.Controls.Add(this.Delete_Brand_Label);
            this.Main_Layout.Controls.Add(this.Brand_Combo_Box);
            this.Main_Layout.Controls.Add(this.Command_Controls_Layout);
            this.Main_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout.Name = "Main_Layout";
            this.Main_Layout.Size = new System.Drawing.Size(198, 102);
            this.Main_Layout.TabIndex = 0;
            // 
            // Delete_Brand_Label
            // 
            this.Delete_Brand_Label.AutoSize = true;
            this.Delete_Brand_Label.Location = new System.Drawing.Point(3, 0);
            this.Delete_Brand_Label.Name = "Delete_Brand_Label";
            this.Delete_Brand_Label.Size = new System.Drawing.Size(180, 13);
            this.Delete_Brand_Label.TabIndex = 0;
            this.Delete_Brand_Label.Text = "Sélectionnez la marque à supprimer :";
            // 
            // Brand_Combo_Box
            // 
            this.Brand_Combo_Box.FormattingEnabled = true;
            this.Brand_Combo_Box.Location = new System.Drawing.Point(3, 16);
            this.Brand_Combo_Box.Name = "Brand_Combo_Box";
            this.Brand_Combo_Box.Size = new System.Drawing.Size(180, 21);
            this.Brand_Combo_Box.TabIndex = 1;
            // 
            // Command_Controls_Layout
            // 
            this.Command_Controls_Layout.AutoSize = true;
            this.Command_Controls_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Command_Controls_Layout.Controls.Add(this.Cancel_Button);
            this.Command_Controls_Layout.Controls.Add(this.Delete_Button);
            this.Command_Controls_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Command_Controls_Layout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Command_Controls_Layout.Location = new System.Drawing.Point(3, 43);
            this.Command_Controls_Layout.Name = "Command_Controls_Layout";
            this.Command_Controls_Layout.Size = new System.Drawing.Size(180, 29);
            this.Command_Controls_Layout.TabIndex = 2;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Image = global::Mercure.Properties.Resources.cross;
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(102, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Annuler";
            this.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_Button.Image = global::Mercure.Properties.Resources.tick;
            this.Delete_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Button.Location = new System.Drawing.Point(21, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Supprimer";
            this.Delete_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Button.UseVisualStyleBackColor = false;
            // 
            // DeleteBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(198, 102);
            this.Controls.Add(this.Main_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supprimer une marque";
            this.Main_Layout.ResumeLayout(false);
            this.Main_Layout.PerformLayout();
            this.Command_Controls_Layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main_Layout;
        private System.Windows.Forms.Label Delete_Brand_Label;
        private System.Windows.Forms.ComboBox Brand_Combo_Box;
        private System.Windows.Forms.FlowLayoutPanel Command_Controls_Layout;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Delete_Button;
    }
}