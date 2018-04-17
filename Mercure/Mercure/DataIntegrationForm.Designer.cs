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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.File_Name_Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 454);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.File_Name_Input);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(606, 32);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // File_Name_Input
            // 
            this.File_Name_Input.AccessibleDescription = "";
            this.File_Name_Input.AllowDrop = true;
            this.File_Name_Input.Location = new System.Drawing.Point(3, 3);
            this.File_Name_Input.Name = "File_Name_Input";
            this.File_Name_Input.ReadOnly = true;
            this.File_Name_Input.Size = new System.Drawing.Size(405, 20);
            this.File_Name_Input.TabIndex = 2;
            this.File_Name_Input.Text = "Glissez déposez ici";
            this.File_Name_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.File_Name_Input.TextChanged += new System.EventHandler(this.File_Name_Input_TextChanged);
            this.File_Name_Input.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_Path_DragDrop);
            this.File_Name_Input.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_Path_DragEnter);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(414, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sélectionner un fichier XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.File_Select_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(606, 32);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nouvelle intégration, purge des données actuelles.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.New_Data_Integration);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Mise à jour.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Data_Integration);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.progressBar1);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 79);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(606, 39);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "0%";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.textBox1);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 124);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(606, 318);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(603, 303);
            this.textBox1.TabIndex = 7;
            this.textBox1.WordWrap = false;
            // 
            // DataIntegrationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataIntegrationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DataIntegrationForm";
            this.Load += new System.EventHandler(this.DataIntegrationForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private delegate void Update_Progress_Bar_Delegate(int progress);
        private delegate void Print_To_Log_Delegate(string s);

        private void Update_Progress_Bar(int progress)
        {
            this.progressBar1.Value = progress;
            this.progressBar1.Refresh();
            this.label1.Text = progress + "%";
            this.label1.Refresh();
        }

        private void Print_To_Log(string s)
        {
            this.textBox1.AppendText(s + "\r\n");
            this.textBox1.Refresh();
        }

        private void New_Data_Integration(object sender, System.EventArgs e)
        {
            // Try to open the file.
            System.Xml.XmlDocument Xml_File = new System.Xml.XmlDocument();
            if (this.File_Name_Input.Text != "")
            {
                try
                {
                    Xml_File.Load(this.File_Name_Input.Text);
                }
                catch (System.Exception exception)
                {
                    Print_To_Log(exception.Message);
                }
            }
            else
                return;

            Print_To_Log("New integration from file '" + this.File_Name_Input.Text + "'.");

            // Clear the database as it is a new integration.
            Database.GetInstance().Clear_Database();

            // Counters.
            int Articles_Integrated = 0, Errors = 0;
            System.DateTime Start_Time = System.DateTime.Now;

            for(int Article = 0 ; Article < Xml_File.SelectNodes("/materiels/article").Count; Article++)
            {
                Update_Progress_Bar((Article * 100) / Xml_File.SelectNodes("/materiels/article").Count);

                // Extract article data.
                System.Xml.XmlNode ArticleXML = Xml_File.SelectNodes("/materiels/article").Item(Article);
                string Description = ArticleXML.SelectSingleNode("description").InnerText;
                string Reference = ArticleXML.SelectSingleNode("refArticle").InnerText;
                string Marque = ArticleXML.SelectSingleNode("marque").InnerText;
                string Famille = ArticleXML.SelectSingleNode("famille").InnerText;
                string Sous_Famille = ArticleXML.SelectSingleNode("sousFamille").InnerText;
                float PrixHT = float.Parse(ArticleXML.SelectSingleNode("prixHT").InnerText);

                // Load article in DB.
                bool Success = Load_Article(Description, Reference, Marque, Famille, Sous_Famille, PrixHT);

                if (Success)
                {
                    Print_To_Log("Article " + Reference + " created.");
                    Articles_Integrated++;
                }
                else
                {
                    Print_To_Log("Could not create article " + Reference + ".");
                    Errors++;
                }
            }

            System.DateTime End_Time = System.DateTime.Now;
            float Time = (float)(End_Time.Subtract(Start_Time)).TotalSeconds;

            Print_To_Log(Articles_Integrated + " article(s) integrated successfully, " + Errors + " error(s) in " + Time + "s.");

            // Finish progress.
            Update_Progress_Bar(100);
        }

        private void Update_Data_Integration(object sender, System.EventArgs e)
        {
            // Try to open the file.
            System.Xml.XmlDocument Xml_File = new System.Xml.XmlDocument();
            if (this.File_Name_Input.Text != "")
            {
                try
                {
                    Xml_File.Load(this.File_Name_Input.Text);
                }
                catch (System.Exception exception)
                {
                    Print_To_Log(exception.Message);
                }
            }
            else
                return;

            Print_To_Log("Update from file '" + this.File_Name_Input.Text + "'.");

            // Counters.
            int Articles_Created = 0, Articles_Udpated = 0, Errors = 0;
            System.DateTime Start_Time = System.DateTime.Now;

            for (int Article = 0; Article < Xml_File.SelectNodes("/materiels/article").Count; Article++)
            {
                Update_Progress_Bar((Article * 100) / Xml_File.SelectNodes("/materiels/article").Count);

                // Extract article data.
                System.Xml.XmlNode ArticleXML = Xml_File.SelectNodes("/materiels/article").Item(Article);
                string Description = ArticleXML.SelectSingleNode("description").InnerText;
                string Reference = ArticleXML.SelectSingleNode("refArticle").InnerText;
                string Marque = ArticleXML.SelectSingleNode("marque").InnerText;
                string Famille = ArticleXML.SelectSingleNode("famille").InnerText;
                string Sous_Famille = ArticleXML.SelectSingleNode("sousFamille").InnerText;
                float PrixHT = float.Parse(ArticleXML.SelectSingleNode("prixHT").InnerText);

                // Update article in DB.
                int Result = Update_Article(Description, Reference, Marque, Famille, Sous_Famille, PrixHT);

                switch(Result)
                {
                    case 1:
                        Print_To_Log("Article " + Reference + " created.");
                        Articles_Created++;
                        break;
                    case 2:
                        Print_To_Log("Article " + Reference + " updated.");
                        Articles_Udpated++;
                        break;
                    default:
                        Print_To_Log("Could not create nor update article " + Reference + ".");
                        Errors++;
                        break;
                }
            }

            System.DateTime End_Time = System.DateTime.Now;
            float Time = (float)(End_Time.Subtract(Start_Time)).TotalSeconds;

            Print_To_Log(Articles_Created + " article(s) created successfully, " + Articles_Udpated + " article(s) updated successfully, " + Errors + " error(s) in " + Time + "s.");

            // Finish progress.
            Update_Progress_Bar(100);
        }

        private bool Load_Article(string Description, string Reference, string Marque, string Famille, string SousFamille, float PrixHT)
        {
            Database DB = Database.GetInstance();

            int Familly_Id = DB.Get_Or_Create_Familly(Famille);
            int Sub_Familly_Id = DB.Get_Or_Create_Sub_Familly(Familly_Id, SousFamille);
            int Brand_Id = DB.Get_Or_Create_Brand(Marque);

            if (Familly_Id == -1)
                Print_To_Log("Error on Familly_Id");

            if (Sub_Familly_Id == -1)
                Print_To_Log("Error on Sub_Familly_Id");

            if (Brand_Id == -1)
                Print_To_Log("Error on Brand_Id");

            return DB.Create_Article(Reference, Sub_Familly_Id, Brand_Id, Description, PrixHT);
        }

        private int Update_Article(string Description, string Reference, string Marque, string Famille, string SousFamille, float PrixHT)
        {
            Database DB = Database.GetInstance();

            if (DB.Count_Articles_Id(Reference) == -1)
            {
                if (Load_Article(Description, Reference, Marque, Famille, SousFamille, PrixHT))
                    return 1;
                else
                    return 0;
            }
            else
            {
                int Familly_Id = DB.Get_Or_Create_Familly(Famille);
                int Sub_Familly_Id = DB.Get_Or_Create_Sub_Familly(Familly_Id, SousFamille);
                int Brand_Id = DB.Get_Or_Create_Brand(Marque);

                if (Familly_Id == -1)
                    Print_To_Log("Error on Familly_Id");

                if (Sub_Familly_Id == -1)
                    Print_To_Log("Error on Sub_Familly_Id");

                if (Brand_Id == -1)
                    Print_To_Log("Error on Brand_Id");

                if (DB.Update_Article(Description, Reference, Brand_Id, Familly_Id, Sub_Familly_Id, PrixHT))
                    return 2;
                else
                    return 0;
            }
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox File_Name_Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBox1;
    }
}