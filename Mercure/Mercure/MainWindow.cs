using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Constructor of the main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the modify Article form
        /// </summary>
        /// <param name="Article"></param>
        public void Open_Modify_Article(Models.Article Article)
        {
            AddArticleForm Aaf = new AddArticleForm(Article);
            DialogResult Result = Aaf.ShowDialog();

            // Refresh the view.
            if (Result == DialogResult.OK)
            {
                // Get the new value.
                Database DB = Database.GetInstance();
                Models.Article Modified_Article = DB.Get_Article(Article.Ref_Article);

                ListViewItem Lvi = Article_List_View.SelectedItems[0];
                Lvi.SubItems[0].Text = Modified_Article.Ref_Article;
                Lvi.SubItems[1].Text = Modified_Article.Description;
                Lvi.SubItems[2].Text = Modified_Article.Sub_Familly_Name;
                Lvi.SubItems[3].Text = Modified_Article.Brand_Name;
                Lvi.SubItems[4].Text = "" + Modified_Article.Price_HT;
                Lvi.SubItems[5].Text = "" + Modified_Article.Quantity;
            }
        }

        /// <summary>
        /// Orders the columns and create item groups
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Column_Clicked(object sender, ColumnClickEventArgs e)
        {
            this.Article_List_View.ListViewItemSorter = new ListViewItemComparer(e.Column);
            if (e.Column == 2 || e.Column == 3 || e.Column == 5)
            {
                string current = "";
                for (int i = 0; i < Article_List_View.Items.Count; i++)
                {
                    if (!current.Equals(Article_List_View.Items[i].SubItems[e.Column].Text))
                    {
                        Article_List_View.Groups.Add(new ListViewGroup(Article_List_View.Items[i].SubItems[e.Column].Text, HorizontalAlignment.Left));
                        current = Article_List_View.Items[i].SubItems[e.Column].Text;
                    }

                    Article_List_View.Groups[Article_List_View.Groups.Count - 1].Items.Add(Article_List_View.Items[i]);
                }
            }
            else
                Article_List_View.Groups.Clear();
            this.Status_Label.Text = "Colonne " + e.Column + " triée !";
        }

        /// <summary>
        /// Returns the selected item in the listView
        /// </summary>
        /// <returns>A model object of the selected article</returns>
        public Models.Article getSelectedArticle()
        {
            Models.Article Article = new Models.Article();

            if (Article_List_View.SelectedItems.Count == 0) return null;
            
            ListViewItem Item = Article_List_View.SelectedItems[0];
            Models.Article A =  Database.GetInstance().Get_Article(Item.SubItems[0].Text);
            return A;
        }

        /// <summary>
        /// Executes de modify function when we double click in an Article
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Clicked_Item(object sender, EventArgs e)
        {
            Open_Modify_Article(getSelectedArticle());
        }

        /// <summary>
        /// Checks the key pressed and execute the corresponding action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Key_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Load_Articles();
            else if (e.KeyCode == Keys.Enter)
            {
                Models.Article Article = getSelectedArticle();
                    if (Article != null)
                Open_Modify_Article(getSelectedArticle());
            }                
            else if (e.KeyCode == Keys.Delete)
            {
                Models.Article Article = getSelectedArticle();
                if (Article != null)
                    On_Delete_Article(getSelectedArticle());
            }
                
        }

        /// <summary>
        /// Executes the article erasement
        /// </summary>
        /// <param name="Article"></param>
        private void On_Delete_Article(Models.Article Article)
        {
            DialogResult Res = MessageBox.Show(this, "Etes vous sûr de vouloir supprimer l'article : " + Article.Ref_Article + " ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                bool success = Database.GetInstance().Delete_Article(Article.Ref_Article);
                if (success)
                {
                    Res = MessageBox.Show(this, "Suppression réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Res == DialogResult.OK)
                        Article_List_View.Items.Remove(Article_List_View.SelectedItems[0]);
                    this.Status_Label.Text = "Suppréssion réussi !";
                }
                else
                {
                    Res = MessageBox.Show(this, "Erreur lors de la supression", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Status_Label.Text = "Echec de la suppréssion réussi !";
                }
            }
        }

        /// <summary>
        /// Hides or shows items in function of if an article is selected or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Open_Menu_Strip(object sender, CancelEventArgs e)
        {
            if (getSelectedArticle() == null)
            {
                // Modify/delete article.
                Context_Menu_Strip.Items[1].Visible = false;
                Context_Menu_Strip.Items[2].Visible = false;

                // Modify/delete brand.
                Context_Menu_Strip.Items[5].Visible = false;
               
                // Modify/delete sub-family.
                Context_Menu_Strip.Items[8].Visible = false;     
            }
            else
            {
                // Modify/delete article.
                Context_Menu_Strip.Items[1].Visible = true;
                Context_Menu_Strip.Items[2].Visible = true;

                // Modify/delete brand.
                Context_Menu_Strip.Items[5].Visible = true;

                // Modify/delete sub-family.
                Context_Menu_Strip.Items[8].Visible = true;
            }
        }

        /// <summary>
        /// Executed when we click on the create article button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Create_Article_Event(object sender, EventArgs e)
        {
            AddArticleForm Aaf = new AddArticleForm(null);
            DialogResult Result = Aaf.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // Get the new value.
                Database DB = Database.GetInstance();
                Models.Article A = DB.Get_Article(Aaf.Inserted_Id);

                String[] Row = { A.Ref_Article, A.Description, A.Sub_Familly_Name, A.Brand_Name, "" + A.Price_HT, "" + A.Quantity };
                ListViewItem Item = new ListViewItem(Row);
                this.Article_List_View.Items.Add(Item);
                this.Status_Label.Text = "Article : " + A.Ref_Article + " ajouté !";
            }
        }

        /// <summary>
        /// Executed when we click on the modify article button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Article_Event(object sender, EventArgs e)
        {
            Models.Article Article = getSelectedArticle();
            if (Article != null)
                Open_Modify_Article(getSelectedArticle());
        }

        /// <summary>
        /// Executed when we click on the delete article button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Delete_Article_Event(object sender, EventArgs e)
        {
            Models.Article Article = getSelectedArticle();
            if(Article != null)
                On_Delete_Article(getSelectedArticle());
        }

        /// <summary>
        /// Executed when we click on the select XML file button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_XML_File_Menu_Item_Click(object sender, System.EventArgs e)
        {
            DataIntegrationForm Dif = new DataIntegrationForm(this);
            Dif.ShowDialog();
        }

        /// <summary>
        /// Calls load articles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void On_Load_Event(object sender, System.EventArgs e)
        {
            Init_List();
            Load_Articles();          
        }

        /// <summary>
        /// Initializates the list view.
        /// </summary>
        private void Init_List()
        {
            Article_List_View.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Description", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Quantité", -2, HorizontalAlignment.Left);

            Article_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Article_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            int Width = 0;
            for (int i = 0; i < Article_List_View.Columns.Count; i++)
            {
                Width += Article_List_View.Columns[i].Width;
            }

            this.Width = Width + 25;
            this.Height = (int)(this.Width * (9 / 16.0f));

            this.CenterToScreen();

        }

        /// <summary>
        /// Loads article from DB and show them in the list view
        /// </summary>
        public void Load_Articles()
        {
            this.Article_List_View.Clear();
            this.Article_List_View.Groups.Clear();

            List<Models.Article> Articles = Database.GetInstance().Get_Articles_List();
            if (Articles.Count == 0) 
            {
                return;
            }

            Article_List_View.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Description", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            Article_List_View.Columns.Add("Quantité", -2, HorizontalAlignment.Left);
            
            foreach (Models.Article A in Articles)
            {
                String[] Row = { A.Ref_Article, A.Description, A.Sub_Familly_Name, A.Brand_Name, "" + A.Price_HT, "" + A.Quantity };
                ListViewItem Item = new ListViewItem(Row);
                this.Article_List_View.Items.Add(Item);
            }

            Article_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Article_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Article_List_View.Columns[5].Width = 80;

            int Width = 0;
            for (int i = 0; i < Article_List_View.Columns.Count; i++)
            {
                Width += Article_List_View.Columns[i].Width;
            }
            this.Width = Width + 37;

            // auto 16/9 with the list view size
            this.Height = (int)(this.Width * (9 / 16.0f));

            this.CenterToScreen();
            this.Status_Label.Text = "Chargement via la base de données réussi !";
        }

        /// <summary>
        /// Event called when the user clicks the quit action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event called when the user clicks the clear the database action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NettoyerLaBaseDeDonnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Nettoyage en cours");
            Database.GetInstance().Clear_Database();
            Load_Articles();
        }

        /// <summary>
        /// Launches the add brand form.
        /// </summary>
        public void Add_Brand()
        {
            AddBrandForm abf = new AddBrandForm(null);
            abf.ShowDialog();
        }

        /// <summary>
        /// Add brand menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterUneMarqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Brand();
        }

        /// <summary>
        /// Add brand menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Brand();      
        }

        /// <summary>
        /// List brands menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListerLesMarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBrand lb = new ListBrand();
            lb.ShowDialog();
        }

        /// <summary>
        /// List families menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListerLesFamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFamily lf = new ListFamily();
            lf.ShowDialog();
        }

        /// <summary>
        /// List sub-families menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListerLesSousfamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSubFamily lsf = new ListSubFamily();
            lsf.ShowDialog();
        }

        /// <summary>
        /// Add family menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFamilyForm aff = new AddFamilyForm(null);
            aff.ShowDialog();
        }
        
        /// <summary>
        /// Displays the add family form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Add_Sub_Family(object sender, EventArgs e)
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(null);
            Form.ShowDialog();
        }

        /// <summary>
        /// Displays the modify brand form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Brand(object sender, EventArgs e)
        {
            AddBrandForm Form = new AddBrandForm(getSelectedArticle().Brand_Name);
            DialogResult Result = Form.ShowDialog();
            if(Result == DialogResult.OK)
            {
                Load_Articles();
            }
        }

        /// <summary>
        /// Displays the modify sub-family form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Sub_Family(object sender, EventArgs e)
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(getSelectedArticle().Sub_Familly_Name);
            DialogResult Result = Form.ShowDialog();
            if (Result == DialogResult.OK)
            {
                Load_Articles();
            }
        }

    }

    /// <summary>
    /// The comparer class for the list View sort
    /// </summary>
    class ListViewItemComparer : IComparer
    {
        private int Col;
        private static bool ascendent = true;
        private static int lastSortedCol;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="column"></param>
        public ListViewItemComparer(int column)
        {
            
            if (lastSortedCol == column)
                ascendent = !ascendent;
            else
                ascendent = true;

            lastSortedCol = column;
            Col = column;
        }

        /// <summary>
        /// Compare string and numbers in asc or desc
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            int result = 0;
           
            if(Col == 4 || Col == 5)
            {
                float a = float.Parse(((ListViewItem)x).SubItems[Col].Text);
                float b = float.Parse(((ListViewItem)y).SubItems[Col].Text);

                if(a == b) result =  0;
                else if(a < b) result = -1;
                else result =  1;
            }                 
            else
                result = String.Compare(((ListViewItem)x).SubItems[Col].Text, ((ListViewItem)y).SubItems[Col].Text);

            if (!ascendent)
                return -result;
            return result;
                
        }
    }
}
