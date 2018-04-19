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
    public partial class ListSubFamily : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ListSubFamily()
        {
            InitializeComponent();
            Load_SubFamilies();
        }

        /// <summary>
        /// Loads the list view with the sub-families from the database
        /// </summary>
        private void Load_SubFamilies()
        {
            this.SubFamily_List_View.Clear();

            Database db = Database.GetInstance();
            List<Models.SubFamily> subfamilies = db.Get_Sub_Families();

            SubFamily_List_View.Columns.Add("Id Sous Famille", -2, HorizontalAlignment.Left);
            SubFamily_List_View.Columns.Add("Id Famille associée", -2, HorizontalAlignment.Left);
            SubFamily_List_View.Columns.Add("Nom", -2, HorizontalAlignment.Left);

            foreach (Models.SubFamily f in subfamilies)
            {
                String[] row = { "" + f.Id, "" + f.Family_Id, f.Name };
                ListViewItem lvi = new ListViewItem(row);
                SubFamily_List_View.Items.Add(lvi);
            }

            SubFamily_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SubFamily_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Event handler of the close window menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fermerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event handler of the add sub-family menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneSousfamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_SubFamily();
        }

        /// <summary>
        /// Returns the currently selected item or null if none
        /// </summary>
        /// <returns>the currently selected item or null if none</returns>
        private Models.SubFamily Get_Selected_Item()
        {
            if (this.SubFamily_List_View.SelectedItems.Count != 0)
            {
                Models.SubFamily SubFamily = new Models.SubFamily();
                ListViewItem Item = this.SubFamily_List_View.SelectedItems[0];

                SubFamily.Id = int.Parse(Item.SubItems[0].Text);
                SubFamily.Family_Id = int.Parse(Item.SubItems[1].Text);
                SubFamily.Name = Item.SubItems[2].Text;

                return SubFamily;
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
                Load_SubFamilies();
            else if (e.KeyCode == Keys.Enter)
            {
                Models.SubFamily SubFamily = Get_Selected_Item();
                if (SubFamily != null)
                    Modify_SubFamily(SubFamily);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Models.SubFamily SubFamily = Get_Selected_Item();
                if (SubFamily != null)
                    Delete_SubFamily(SubFamily);
            }
        }

        /// <summary>
        /// Displays the modify sub-family form
        /// </summary>
        /// <param name="SubFamily"></param>
        private void Modify_SubFamily(Models.SubFamily SubFamily)
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(SubFamily.Name);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_SubFamilies();
        }

        /// <summary>
        /// Displays the add sub-family form
        /// </summary>
        private void Add_SubFamily()
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_SubFamilies();
        }

        /// <summary>
        /// Deletes the sub-family if no article is linked to it
        /// </summary>
        /// <param name="SubFamily"></param>
        private void Delete_SubFamily(Models.SubFamily SubFamily)
        {
            // Todo detect if connected to an article
            // Only load the affected row
            Database db = Database.GetInstance();
            if (db.SubFamily_Has_Articles_Associated(SubFamily.Id))
                return;

            db.Delete_Sub_Familly(SubFamily.Id);
            Load_SubFamilies();
        }

        /// <summary>
        /// Double click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Double_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Item() != null)
                Modify_SubFamily(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to modify a sub-family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Event(object sender, EventArgs e)
        {
            Modify_SubFamily(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to delete a sub-family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Delete_Event(object sender, EventArgs e)
        {
            Delete_SubFamily(Get_Selected_Item());
        }

        /// <summary>
        /// Event handler to sort the columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Column_Click(object sender, ColumnClickEventArgs e)
        {
            this.SubFamily_List_View.ListViewItemSorter = new SubFamilyItemComparer(e.Column);
        }
    }

    /// <summary>
    /// The comparer class for the list View sort
    /// </summary>
    class SubFamilyItemComparer : IComparer
    {
        private int Col;
        private static bool ascendent = true;
        private static int lastSortedCol;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="column"></param>
        public SubFamilyItemComparer(int column)
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

            if (Col == 0 || Col == 1)
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
