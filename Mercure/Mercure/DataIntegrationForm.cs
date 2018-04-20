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
    /// <summary>
    /// Data integration form. Allows the user to integrate or update the database from files.
    /// </summary>
    public partial class DataIntegrationForm : Form
    {
        private MainWindow Parent_Form;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="M">The parent window</param>
        public DataIntegrationForm(MainWindow M)
        {
            this.Parent_Form = M;
            InitializeComponent();
        }

        /// <summary>
        /// Function called when the user clicks on the File selection button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.Filter = "Fichiers XML (*.xml)|*.xml|Tous les fichiers (*.*)|*.*";
            Dialog.FilterIndex = 1;
            Dialog.ShowDialog();

            this.File_Name_Input.Text = Dialog.FileName;
            Console.WriteLine("Selected file : " + Dialog.FileName);
        }

        /// <summary>
        /// Event handler for the drag & drop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// Handles the event when the user drops a file in the file selection bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if(file != null && file.Length > 0)
                this.File_Name_Input.Text = file[0];
        }

        /// <summary>
        /// Updates the progress bar and the progress label.
        /// </summary>
        /// <param name="progress">The absolute progress</param>
        private void Update_Progress_Bar(int progress)
        {
            this.Progress_Bar.Value = progress;
            this.Progress_Bar.Refresh();
            this.Label_Percent.Text = progress + "%";
            this.Label_Percent.Refresh();
        }

        /// <summary>
        /// Prints a message to the log box.
        /// </summary>
        /// <param name="s"></param>
        private void Print_To_Log(string s)
        {
            this.Output_Text_Box.AppendText(s + "\r\n");
            this.Output_Text_Box.Refresh();
        }

        /// <summary>
        /// Integrates the data from the file. Cleans the database before.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(this, "Le chemin spécifié est invalide ou le fichier ne peut pas être lu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
            Parent_Form.Load_Articles();
        }

        /// <summary>
        /// Integrates the data from the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(this, "Le chemin spécifié est invalide ou le fichier ne peut pas être lu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
            Parent_Form.Load_Articles();
        }

        /// <summary>
        /// Loads an article into the database.
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="Reference"></param>
        /// <param name="Marque"></param>
        /// <param name="Famille"></param>
        /// <param name="SousFamille"></param>
        /// <param name="PrixHT"></param>
        /// <returns>true if the article was loaded without errors, false otherwise</returns>
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

        /// <summary>
        /// Updates an article data. Insert it if it does not exist yet.
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="Reference"></param>
        /// <param name="Marque"></param>
        /// <param name="Famille"></param>
        /// <param name="SousFamille"></param>
        /// <param name="PrixHT"></param>
        /// <returns>true if the article was updated without errors, false otherwise</returns>
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

                if (DB.Update_Article(Description, Reference, Brand_Id, Sub_Familly_Id, PrixHT, -1))
                    return 2;
                else
                    return 0;
            }
        }
    }
}
