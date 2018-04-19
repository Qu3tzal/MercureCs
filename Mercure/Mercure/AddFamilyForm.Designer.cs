namespace Mercure
{
    partial class AddFamilyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFamilyForm));
            this.Main_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Family_Name_Label = new System.Windows.Forms.Label();
            this.Family_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Command_Control_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Main_Layout.SuspendLayout();
            this.Command_Control_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Layout
            // 
            this.Main_Layout.AutoSize = true;
            this.Main_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Layout.Controls.Add(this.Family_Name_Label);
            this.Main_Layout.Controls.Add(this.Family_Name_Text_Box);
            this.Main_Layout.Controls.Add(this.Command_Control_Layout);
            this.Main_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout.Name = "Main_Layout";
            this.Main_Layout.Size = new System.Drawing.Size(800, 450);
            this.Main_Layout.TabIndex = 0;
            // 
            // Family_Name_Label
            // 
            this.Family_Name_Label.AutoSize = true;
            this.Family_Name_Label.Location = new System.Drawing.Point(3, 0);
            this.Family_Name_Label.Name = "Family_Name_Label";
            this.Family_Name_Label.Size = new System.Drawing.Size(93, 13);
            this.Family_Name_Label.TabIndex = 0;
            this.Family_Name_Label.Text = "Nom de la famille :";
            // 
            // Family_Name_Text_Box
            // 
            this.Family_Name_Text_Box.Location = new System.Drawing.Point(3, 16);
            this.Family_Name_Text_Box.Name = "Family_Name_Text_Box";
            this.Family_Name_Text_Box.Size = new System.Drawing.Size(206, 20);
            this.Family_Name_Text_Box.TabIndex = 1;
            // 
            // Command_Control_Layout
            // 
            this.Command_Control_Layout.AutoSize = true;
            this.Command_Control_Layout.Controls.Add(this.Cancel_Button);
            this.Command_Control_Layout.Controls.Add(this.Add_Button);
            this.Command_Control_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Command_Control_Layout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Command_Control_Layout.Location = new System.Drawing.Point(3, 42);
            this.Command_Control_Layout.Name = "Command_Control_Layout";
            this.Command_Control_Layout.Size = new System.Drawing.Size(206, 29);
            this.Command_Control_Layout.TabIndex = 2;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Image = global::Mercure.Properties.Resources.cross;
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(128, 3);
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
            this.Add_Button.Location = new System.Drawing.Point(47, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Ajouter";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // AddFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFamilyForm";
            this.Text = "Ajouter une famille";
            this.Main_Layout.ResumeLayout(false);
            this.Main_Layout.PerformLayout();
            this.Command_Control_Layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main_Layout;
        private System.Windows.Forms.Label Family_Name_Label;
        private System.Windows.Forms.TextBox Family_Name_Text_Box;
        private System.Windows.Forms.FlowLayoutPanel Command_Control_Layout;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
    }
}