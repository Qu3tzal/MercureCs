namespace Mercure
{
    partial class AddSubFamilyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubFamilyForm));
            this.Main_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Family_Group_Box = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Select_Family_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Select_Family_Combo_Box = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.New_Family_Name = new System.Windows.Forms.TextBox();
            this.SubFamily_Group_Box = new System.Windows.Forms.GroupBox();
            this.SubFamily_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.SubFamily_Name_Label = new System.Windows.Forms.Label();
            this.SubFamily_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Command_Control_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_SubFamily = new System.Windows.Forms.Button();
            this.Main_Layout.SuspendLayout();
            this.Family_Group_Box.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SubFamily_Group_Box.SuspendLayout();
            this.SubFamily_Layout.SuspendLayout();
            this.Command_Control_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Layout
            // 
            this.Main_Layout.AutoSize = true;
            this.Main_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Layout.Controls.Add(this.Family_Group_Box);
            this.Main_Layout.Controls.Add(this.SubFamily_Group_Box);
            this.Main_Layout.Controls.Add(this.Command_Control_Layout);
            this.Main_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout.Name = "Main_Layout";
            this.Main_Layout.Size = new System.Drawing.Size(800, 450);
            this.Main_Layout.TabIndex = 0;
            // 
            // Family_Group_Box
            // 
            this.Family_Group_Box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Family_Group_Box.Controls.Add(this.flowLayoutPanel1);
            this.Family_Group_Box.Location = new System.Drawing.Point(3, 3);
            this.Family_Group_Box.Name = "Family_Group_Box";
            this.Family_Group_Box.Size = new System.Drawing.Size(245, 120);
            this.Family_Group_Box.TabIndex = 0;
            this.Family_Group_Box.TabStop = false;
            this.Family_Group_Box.Text = "Famille associée";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Select_Family_Radio_Button);
            this.flowLayoutPanel1.Controls.Add(this.Select_Family_Combo_Box);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.New_Family_Name);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 101);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Select_Family_Radio_Button
            // 
            this.Select_Family_Radio_Button.AutoSize = true;
            this.Select_Family_Radio_Button.Location = new System.Drawing.Point(3, 3);
            this.Select_Family_Radio_Button.Name = "Select_Family_Radio_Button";
            this.Select_Family_Radio_Button.Size = new System.Drawing.Size(188, 17);
            this.Select_Family_Radio_Button.TabIndex = 5;
            this.Select_Family_Radio_Button.TabStop = true;
            this.Select_Family_Radio_Button.Text = "Sélectionner une famille existante :";
            this.Select_Family_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Select_Family_Combo_Box
            // 
            this.Select_Family_Combo_Box.FormattingEnabled = true;
            this.Select_Family_Combo_Box.Location = new System.Drawing.Point(3, 26);
            this.Select_Family_Combo_Box.Name = "Select_Family_Combo_Box";
            this.Select_Family_Combo_Box.Size = new System.Drawing.Size(230, 21);
            this.Select_Family_Combo_Box.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Créer une nouvelle famille :";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // New_Family_Name
            // 
            this.New_Family_Name.Location = new System.Drawing.Point(3, 76);
            this.New_Family_Name.Name = "New_Family_Name";
            this.New_Family_Name.Size = new System.Drawing.Size(230, 20);
            this.New_Family_Name.TabIndex = 3;
            // 
            // SubFamily_Group_Box
            // 
            this.SubFamily_Group_Box.Controls.Add(this.SubFamily_Layout);
            this.SubFamily_Group_Box.Location = new System.Drawing.Point(3, 129);
            this.SubFamily_Group_Box.Name = "SubFamily_Group_Box";
            this.SubFamily_Group_Box.Size = new System.Drawing.Size(245, 61);
            this.SubFamily_Group_Box.TabIndex = 2;
            this.SubFamily_Group_Box.TabStop = false;
            this.SubFamily_Group_Box.Text = "Sous-famille";
            // 
            // SubFamily_Layout
            // 
            this.SubFamily_Layout.Controls.Add(this.SubFamily_Name_Label);
            this.SubFamily_Layout.Controls.Add(this.SubFamily_Name_Text_Box);
            this.SubFamily_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFamily_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SubFamily_Layout.Location = new System.Drawing.Point(3, 16);
            this.SubFamily_Layout.Name = "SubFamily_Layout";
            this.SubFamily_Layout.Size = new System.Drawing.Size(239, 42);
            this.SubFamily_Layout.TabIndex = 0;
            // 
            // SubFamily_Name_Label
            // 
            this.SubFamily_Name_Label.AutoSize = true;
            this.SubFamily_Name_Label.Location = new System.Drawing.Point(3, 0);
            this.SubFamily_Name_Label.Name = "SubFamily_Name_Label";
            this.SubFamily_Name_Label.Size = new System.Drawing.Size(118, 13);
            this.SubFamily_Name_Label.TabIndex = 0;
            this.SubFamily_Name_Label.Text = "Nom de la sous-famille :";
            // 
            // SubFamily_Name_Text_Box
            // 
            this.SubFamily_Name_Text_Box.Location = new System.Drawing.Point(3, 16);
            this.SubFamily_Name_Text_Box.Name = "SubFamily_Name_Text_Box";
            this.SubFamily_Name_Text_Box.Size = new System.Drawing.Size(230, 20);
            this.SubFamily_Name_Text_Box.TabIndex = 1;
            // 
            // Command_Control_Layout
            // 
            this.Command_Control_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Command_Control_Layout.Controls.Add(this.Cancel_Button);
            this.Command_Control_Layout.Controls.Add(this.Add_SubFamily);
            this.Command_Control_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Command_Control_Layout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Command_Control_Layout.Location = new System.Drawing.Point(3, 196);
            this.Command_Control_Layout.Name = "Command_Control_Layout";
            this.Command_Control_Layout.Size = new System.Drawing.Size(245, 30);
            this.Command_Control_Layout.TabIndex = 1;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Image = global::Mercure.Properties.Resources.cross;
            this.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Button.Location = new System.Drawing.Point(167, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Annuler";
            this.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Add_SubFamily
            // 
            this.Add_SubFamily.Image = global::Mercure.Properties.Resources.tick;
            this.Add_SubFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_SubFamily.Location = new System.Drawing.Point(86, 3);
            this.Add_SubFamily.Name = "Add_SubFamily";
            this.Add_SubFamily.Size = new System.Drawing.Size(75, 23);
            this.Add_SubFamily.TabIndex = 1;
            this.Add_SubFamily.Text = "Ajouter";
            this.Add_SubFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_SubFamily.UseVisualStyleBackColor = true;
            // 
            // AddSubFamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubFamilyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une sous-famille";
            this.Main_Layout.ResumeLayout(false);
            this.Family_Group_Box.ResumeLayout(false);
            this.Family_Group_Box.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.SubFamily_Group_Box.ResumeLayout(false);
            this.SubFamily_Layout.ResumeLayout(false);
            this.SubFamily_Layout.PerformLayout();
            this.Command_Control_Layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Main_Layout;
        private System.Windows.Forms.GroupBox Family_Group_Box;
        private System.Windows.Forms.ComboBox Select_Family_Combo_Box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton Select_Family_Radio_Button;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox New_Family_Name;
        private System.Windows.Forms.FlowLayoutPanel Command_Control_Layout;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_SubFamily;
        private System.Windows.Forms.GroupBox SubFamily_Group_Box;
        private System.Windows.Forms.FlowLayoutPanel SubFamily_Layout;
        private System.Windows.Forms.Label SubFamily_Name_Label;
        private System.Windows.Forms.TextBox SubFamily_Name_Text_Box;
    }
}