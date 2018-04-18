using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class DataIntegrationForm : Form
    {
        private MainWindow Parent;
        public DataIntegrationForm(MainWindow M)
        {
            this.Parent = M;
            InitializeComponent();
        }

        private void File_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.Filter = "Fichiers XML (*.xml)|*.xml|Tous les fichiers (*.*)|*.*";
            Dialog.FilterIndex = 1;
            Dialog.ShowDialog();

            this.File_Name_Input.Text = Dialog.FileName;
            Console.WriteLine("Selected file : " + Dialog.FileName);
        }

        private void File_Path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void File_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if(file != null && file.Length > 0)
                this.File_Name_Input.Text = file[0];
        }

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
            Parent.loadArticles();
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

                switch (Result)
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
            Parent.loadArticles();
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


    }
}
