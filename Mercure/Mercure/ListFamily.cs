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
    /// <summary>
    /// List view of the families
    /// </summary>
    public partial class ListFamily : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ListFamily()
        {
            InitializeComponent();
            Load_Families();
        }

        /// <summary>
        /// Loads the list view with the families from the database
        /// </summary>
        private void Load_Families()
        {
            this.Family_List_View.Clear();

            Database db = Database.GetInstance();
            List<Models.Family> families = db.Get_Families();

            Family_List_View.Columns.Add("Id Famille", -2, HorizontalAlignment.Left);
            Family_List_View.Columns.Add("Nom", -2, HorizontalAlignment.Left);

            foreach (Models.Family f in families)
            {
                String[] row = { "" + f.Id, f.Name };
                ListViewItem lvi = new ListViewItem(row);
                Family_List_View.Items.Add(lvi);
            }

            Family_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Family_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Event handler of the close window menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event handler of the add family menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Family();
        }

        /// <summary>
        /// Returns the currently selected item or null if none
        /// </summary>
        /// <returns>the currently selected item or null if none</returns>
        private Models.Family Get_Selected_Item()
        {
            if (this.Family_List_View.SelectedItems.Count != 0)
            {
                Models.Family Family = new Models.Family();
                ListViewItem Item = this.Family_List_View.SelectedItems[0];

                Family.Id = int.Parse(Item.SubItems[0].Text);
                Family.Name = Item.SubItems[1].Text;

                return Family;
            }
            else return null;
        }

        /// <summary>
        /// Event handler of the context menu strip that checks if a row is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Open_Menu_Strip(object sender, CancelEventArgs e)
        {
            if (Get_Selected_Item() == null)
            {
                this.contextMenuStrip1.Items[1].Visible = false;
                this.contextMenuStrip1.Items[2].Visible = false;
                this.contextMenuStrip1.Items[3].Visible = false;
            }
            else
            {
                this.contextMenuStrip1.Items[1].Visible = true;
                this.contextMenuStrip1.Items[2].Visible = true;
                this.contextMenuStrip1.Items[3].Visible = true;
            }
        }

        /// <summary>
        /// Event handler for the F5, Enter & delete keys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Key_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Load_Families();
            else if (e.KeyCode == Keys.Enter)
            {
                Models.Family Family = Get_Selected_Item();
                if (Family != null)
                    Modify_Family(Family);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Models.Family Family = Get_Selected_Item();
                if (Family != null)
                    Delete_Family(Family);
            }
        }

        /// <summary>
        /// Displays the modify family form
        /// </summary>
        /// <param name="Family"></param>
        private void Modify_Family(Models.Family Family)
        {
            AddFamilyForm Form = new AddFamilyForm(Family.Name);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // Get the new value.
                Database db = Database.GetInstance();
                Models.Family Modified_Family = db.Get_Family_With_Id(Family.Id);

                ListViewItem Lvi = Family_List_View.SelectedItems[0];
                Lvi.SubItems[0].Text = Modified_Family.Id.ToString();
                Lvi.SubItems[1].Text = Modified_Family.Name;
            }
        }

        /// <summary>
        /// Displays the add family form
        /// </summary>
        private void Add_Family()
        {
            AddFamilyForm Form = new AddFamilyForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // Get the new value.
                Database db = Database.GetInstance();
                Models.Family Modified_Family = db.Get_Family_With_Id(Form.Inserted_Id);

                String[] row = { "" + Modified_Family.Id, Modified_Family.Name };
                ListViewItem lvi = new ListViewItem(row);
                Family_List_View.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Deletes the family if no article is linked to it
        /// </summary>
        /// <param name="Family"></param>
        private void Delete_Family(Models.Family Family)
        {
            DialogResult Res = MessageBox.Show(this, "Etes vous sûr de vouloir supprimer la famille : " + Family.Name + " ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Todo detect if connected to an article
            // Only load the affected row
            if (Res == DialogResult.Yes)
            {
                // Todo detect if connected to an article
                // Only load the affected row
                Database db = Database.GetInstance();
                if (db.Family_Has_Articles_Associated(Family.Id))
                {
                    Res = MessageBox.Show(this, "Erreur la famille est lié à un article", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool Sucess = db.Delete_Familly(Family.Id);
                if (Sucess)
                {
                    Res = MessageBox.Show(this, "Suppression réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Family_List_View.Items.Remove(Family_List_View.SelectedItems[0]);
                }
                else
                {
                    Res = MessageBox.Show(this, "Erreur lors de la suppression", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
         
        }

        /// <summary>
        /// Double click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Double_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Item() != null)
                Modify_Family(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to modify a family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Event(object sender, EventArgs e)
        {
            Modify_Family(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to delete a family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Delete_Event(object sender, EventArgs e)
        {
            Delete_Family(Get_Selected_Item());
        }

        /// <summary>
        /// Event handler to sort the columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Column_Click(object sender, ColumnClickEventArgs e)
        {
            this.Family_List_View.ListViewItemSorter = new FamilyItemComparer(e.Column);
        }
    }

    /// <summary>
    /// The comparer class for the list View sort
    /// </summary>
    class FamilyItemComparer : IComparer
    {
        private int Col;
        private static bool ascendent = true;
        private static int lastSortedCol;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="column"></param>
        public FamilyItemComparer(int column)
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

            if (Col == 0)
            {
                int a = int.Parse(((ListViewItem)x).SubItems[Col].Text);
                int b = int.Parse(((ListViewItem)y).SubItems[Col].Text);

                if (a == b) result = 0;
                else if (a < b) result = -1;
                else result = 1;
            }
            else
                result = String.Compare(((ListViewItem)x).SubItems[Col].Text, ((ListViewItem)y).SubItems[Col].Text);

            if (!ascendent)
                return -result;
            return result;

        }
    }
}
