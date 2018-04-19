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
                // Refresh only the article
                Load_Articles();
        }

        /// <summary>
        /// Orders the columns and create item groups
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Column_Clicked(object sender, ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
            if (e.Column == 2 || e.Column == 3 || e.Column == 5)
            {
                string current = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (!current.Equals(listView1.Items[i].SubItems[e.Column].Text))
                    {
                        listView1.Groups.Add(new ListViewGroup(listView1.Items[i].SubItems[e.Column].Text, HorizontalAlignment.Left));
                        current = listView1.Items[i].SubItems[e.Column].Text;
                    }

                    listView1.Groups[listView1.Groups.Count - 1].Items.Add(listView1.Items[i]);
                }
            }
            else
                listView1.Groups.Clear();
        }

        /// <summary>
        /// Returns the selected item in the listView
        /// </summary>
        /// <returns>A model object of the selected article</returns>
        public Models.Article getSelectedArticle()
        {
            Models.Article Article = new Models.Article();

            if (listView1.SelectedItems.Count == 0) return null;
            
            ListViewItem Item = listView1.SelectedItems[0];
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
                        Load_Articles();
                }
                else
                {
                    Res = MessageBox.Show(this, "Erreur lors de la supression", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                contextMenuStrip1.Items[1].Visible = false;
                contextMenuStrip1.Items[2].Visible = false;

                // Modify/delete brand.
                contextMenuStrip1.Items[5].Visible = false;
               
                // Modify/delete sub-family.
                contextMenuStrip1.Items[8].Visible = false;     
            }
            else
            {
                // Modify/delete article.
                contextMenuStrip1.Items[1].Visible = true;
                contextMenuStrip1.Items[2].Visible = true;

                // Modify/delete brand.
                contextMenuStrip1.Items[5].Visible = true;

                // Modify/delete sub-family.
                contextMenuStrip1.Items[8].Visible = true;
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

            if(Result == DialogResult.OK)
                // Refresh the view.
                // Only add the row
                Load_Articles();
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
            listView1.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantité", -2, HorizontalAlignment.Left);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            int Width = 0;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                Width += listView1.Columns[i].Width;
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
            this.listView1.Clear();
            this.listView1.Groups.Clear();

            List<Models.Article> Articles = Database.GetInstance().Get_Articles_List();
            if (Articles.Count == 0) 
            {
                return;
            }

            listView1.Columns.Add("RefArticle", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Sous Famille", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Marque", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Prix HT", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantité", -2, HorizontalAlignment.Left);
            
            foreach (Models.Article A in Articles)
            {
                String[] Row = { A.Ref_Article, A.Description, A.Sub_Familly_Name, A.Brand_Name, "" + A.Price_HT, "" + A.Quantity };
                ListViewItem Item = new ListViewItem(Row);
                this.listView1.Items.Add(Item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[5].Width = 80;

            int Width = 0;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                Width += listView1.Columns[i].Width;
            }
            this.Width = Width + 37;
            this.Height = (int)(this.Width * (9 / 16.0f));

            this.CenterToScreen();
        }

        /// <summary>
        /// Event called when the user clicks the quit action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event called when the user clicks the clear the database action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nettoyerLaBaseDeDonnéeToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ajouterUneMarqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Brand();
        }

        /// <summary>
        /// Add brand menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Brand();      
        }

        /// <summary>
        /// List brands menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listerLesMarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBrand lb = new ListBrand();
            lb.ShowDialog();
        }

        /// <summary>
        /// List families menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listerLesFamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFamily lf = new ListFamily();
            lf.ShowDialog();
        }

        /// <summary>
        /// List sub-families menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listerLesSousfamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSubFamily lsf = new ListSubFamily();
            lsf.ShowDialog();
        }

        /// <summary>
        /// Add family menu item event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFamilyForm aff = new AddFamilyForm(null);
            aff.ShowDialog();
        }

        private void On_Add_Sub_Family(object sender, EventArgs e)
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(null);
            Form.ShowDialog();
        }

        private void On_Modify_Brand(object sender, EventArgs e)
        {
            // TODO refresh the line
            AddBrandForm Form = new AddBrandForm(getSelectedArticle().Brand_Name);
            DialogResult Result = Form.ShowDialog();
            if(Result == DialogResult.OK)
                // TODO refresh the line
                Load_Articles();
        }

        private void On_Modify_Sub_Family(object sender, EventArgs e)
        {
            // TODO refresh the line
            AddFamilyForm Form = new AddFamilyForm(getSelectedArticle().Sub_Familly_Name);
            DialogResult Result = Form.ShowDialog();
            if (Result == DialogResult.OK)
                // TODO refresh the line
                Load_Articles();
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
