namespace Mercure
{
    partial class DataIntegrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataIntegrationForm));
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Output_Text_Box = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.Label_Percent = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.New_Integration_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.File_Name_Input = new System.Windows.Forms.TextBox();
            this.Select_XML_Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Log_Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.Output_Text_Box);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 125);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(593, 138);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // Output_Text_Box
            // 
            this.Output_Text_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Text_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Output_Text_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Text_Box.Location = new System.Drawing.Point(3, 3);
            this.Output_Text_Box.Multiline = true;
            this.Output_Text_Box.Name = "Output_Text_Box";
            this.Output_Text_Box.ReadOnly = true;
            this.Output_Text_Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output_Text_Box.Size = new System.Drawing.Size(587, 132);
            this.Output_Text_Box.TabIndex = 7;
            this.Output_Text_Box.WordWrap = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.Progress_Bar);
            this.flowLayoutPanel4.Controls.Add(this.Label_Percent);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(593, 29);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress_Bar.Location = new System.Drawing.Point(3, 3);
            this.Progress_Bar.MarqueeAnimationSpeed = 1;
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(559, 23);
            this.Progress_Bar.Step = 1;
            this.Progress_Bar.TabIndex = 0;
            // 
            // Label_Percent
            // 
            this.Label_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Percent.AutoSize = true;
            this.Label_Percent.Location = new System.Drawing.Point(568, 0);
            this.Label_Percent.Name = "Label_Percent";
            this.Label_Percent.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.Label_Percent.Size = new System.Drawing.Size(21, 22);
            this.Label_Percent.TabIndex = 1;
            this.Label_Percent.Text = "0%";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.New_Integration_Button);
            this.flowLayoutPanel3.Controls.Add(this.Update_Button);
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(593, 32);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // New_Integration_Button
            // 
            this.New_Integration_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Integration_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.New_Integration_Button.Image = global::Mercure.Properties.Resources.databaseplus;
            this.New_Integration_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Integration_Button.Location = new System.Drawing.Point(3, 3);
            this.New_Integration_Button.Name = "New_Integration_Button";
            this.New_Integration_Button.Size = new System.Drawing.Size(307, 26);
            this.New_Integration_Button.TabIndex = 0;
            this.New_Integration_Button.Text = "Nouvelle intégration, purge des données actuelles.";
            this.New_Integration_Button.UseVisualStyleBackColor = true;
            this.New_Integration_Button.Click += new System.EventHandler(this.New_Data_Integration);
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_Button.AutoEllipsis = true;
            this.Update_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update_Button.Image = global::Mercure.Properties.Resources.databasepencil;
            this.Update_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_Button.Location = new System.Drawing.Point(316, 3);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(270, 26);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = "Mise à jour.";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Data_Integration);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.File_Name_Input);
            this.flowLayoutPanel2.Controls.Add(this.Select_XML_Button);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(593, 30);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // File_Name_Input
            // 
            this.File_Name_Input.AccessibleDescription = "";
            this.File_Name_Input.AllowDrop = true;
            this.File_Name_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.File_Name_Input.Location = new System.Drawing.Point(3, 5);
            this.File_Name_Input.Name = "File_Name_Input";
            this.File_Name_Input.ReadOnly = true;
            this.File_Name_Input.Size = new System.Drawing.Size(405, 20);
            this.File_Name_Input.TabIndex = 2;
            this.File_Name_Input.Text = "Glissez-déposez votre fichier ici";
            this.File_Name_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.File_Name_Input.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_Path_DragDrop);
            this.File_Name_Input.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_Path_DragEnter);
            // 
            // Select_XML_Button
            // 
            this.Select_XML_Button.AllowDrop = true;
            this.Select_XML_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_XML_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Select_XML_Button.Image = global::Mercure.Properties.Resources.scriptimport;
            this.Select_XML_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Select_XML_Button.Location = new System.Drawing.Point(414, 3);
            this.Select_XML_Button.Name = "Select_XML_Button";
            this.Select_XML_Button.Size = new System.Drawing.Size(172, 24);
            this.Select_XML_Button.TabIndex = 1;
            this.Select_XML_Button.Text = "Sélectionner un fichier XML";
            this.Select_XML_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Select_XML_Button.UseVisualStyleBackColor = true;
            this.Select_XML_Button.Click += new System.EventHandler(this.File_Select_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.Log_Label);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(601, 291);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Log_Label
            // 
            this.Log_Label.AutoSize = true;
            this.Log_Label.Location = new System.Drawing.Point(3, 109);
            this.Log_Label.Name = "Log_Label";
            this.Log_Label.Size = new System.Drawing.Size(36, 13);
            this.Log_Label.TabIndex = 9;
            this.Log_Label.Text = "Logs :";
            // 
            // DataIntegrationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 291);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataIntegrationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intégration de données";
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private delegate void Update_Progress_Bar_Delegate(int progress);
        private delegate void Print_To_Log_Delegate(string s);

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox Output_Text_Box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ProgressBar Progress_Bar;
        private System.Windows.Forms.Label Label_Percent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button New_Integration_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox File_Name_Input;
        private System.Windows.Forms.Button Select_XML_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Log_Label;
    }
}