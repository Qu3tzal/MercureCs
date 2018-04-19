namespace Mercure
{
    partial class AddBrandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrandForm));
            this.Main_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Brand_Label = new System.Windows.Forms.Label();
            this.Brand_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Command_Buttons_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Main_Layout_Panel.SuspendLayout();
            this.Command_Buttons_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Layout_Panel
            // 
            this.Main_Layout_Panel.AutoSize = true;
            this.Main_Layout_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Layout_Panel.Controls.Add(this.Brand_Label);
            this.Main_Layout_Panel.Controls.Add(this.Brand_Name_Text_Box);
            this.Main_Layout_Panel.Controls.Add(this.Command_Buttons_Layout);
            this.Main_Layout_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_Layout_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout_Panel.Name = "Main_Layout_Panel";
            this.Main_Layout_Panel.Size = new System.Drawing.Size(242, 77);
            this.Main_Layout_Panel.TabIndex = 0;
            // 
            // Brand_Label
            // 
            this.Brand_Label.AutoSize = true;
            this.Brand_Label.Location = new System.Drawing.Point(3, 0);
            this.Brand_Label.Name = "Brand_Label";
            this.Brand_Label.Size = new System.Drawing.Size(99, 13);
            this.Brand_Label.TabIndex = 0;
            this.Brand_Label.Text = "Nom de la marque :";
            // 
            // Brand_Name_Text_Box
            // 
            this.Brand_Name_Text_Box.Location = new System.Drawing.Point(3, 16);
            this.Brand_Name_Text_Box.Name = "Brand_Name_Text_Box";
            this.Brand_Name_Text_Box.Size = new System.Drawing.Size(232, 20);
            this.Brand_Name_Text_Box.TabIndex = 1;
            // 
            // Command_Buttons_Layout
            // 
            this.Command_Buttons_Layout.AutoSize = true;
            this.Command_Buttons_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Command_Buttons_Layout.Controls.Add(this.Cancel_Button);
            this.Command_Buttons_Layout.Controls.Add(this.Add_Button);
            this.Command_Buttons_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Command_Buttons_Layout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Command_Buttons_Layout.Location = new System.Drawing.Point(3, 42);
            this.Command_Buttons_Layout.Name = "Command_Buttons_Layout";
            this.Command_Buttons_Layout.Size = new System.Drawing.Size(232, 29);
            this.Command_Buttons_Layout.TabIndex = 2;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Image = global::Mercure.Properties.Resources.cross;
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(154, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Annuler";
            this.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Image = global::Mercure.Properties.Resources.tick;
            this.Add_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Button.Location = new System.Drawing.Point(73, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Ajouter";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // AddBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(242, 77);
            this.Controls.Add(this.Main_Layout_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une marque";
            this.Main_Layout_Panel.ResumeLayout(false);
            this.Main_Layout_Panel.PerformLayout();
            this.Command_Buttons_Layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main_Layout_Panel;
        private System.Windows.Forms.Label Brand_Label;
        private System.Windows.Forms.TextBox Brand_Name_Text_Box;
        private System.Windows.Forms.FlowLayoutPanel Command_Buttons_Layout;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
    }
}