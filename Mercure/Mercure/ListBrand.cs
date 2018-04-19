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
    /// List view of the brands
    /// </summary>
    public partial class ListBrand : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ListBrand()
        {
            InitializeComponent();
            
            Load_Brands();
        }

        /// <summary>
        /// Loads the list view with the brands from the database
        /// </summary>
        private void Load_Brands()
        {
            this.Brand_List_View.Clear();

            Database db = Database.GetInstance();
            List<Models.Brand> brands = db.Get_Brands();

            Brand_List_View.Columns.Add("Id Marque", -2, HorizontalAlignment.Left);
            Brand_List_View.Columns.Add("Nom", -2, HorizontalAlignment.Left);

            foreach (Models.Brand b in brands)
            {
                String[] row = { "" + b.Id, b.Name };
                ListViewItem lvi = new ListViewItem(row);
                Brand_List_View.Items.Add(lvi);
            }

            Brand_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Brand_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
        /// Event handler of the add brand menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Brand();
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
        /// Returns the currently selected item or null if none
        /// </summary>
        /// <returns>the currently selected item or null if none</returns>
        private Models.Brand Get_Selected_Item()
        {
            if (this.Brand_List_View.SelectedItems.Count != 0)
            {
                Models.Brand Brand = new Models.Brand();
                ListViewItem Item = this.Brand_List_View.SelectedItems[0];
                Brand.Id = int.Parse(Item.SubItems[0].Text);
                Brand.Name = Item.SubItems[1].Text;

                return Brand;
            }
            else return null;
        }

        /// <summary>
        /// Event handler for the F5, Enter & delete keys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Key_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Load_Brands();
            else if (e.KeyCode == Keys.Enter)
            {
                Models.Brand Brand = Get_Selected_Item();
                if (Brand != null)
                    Modify_Brand(Brand);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Models.Brand Brand = Get_Selected_Item();
                if (Brand != null)
                    Delete_Brand(Brand);
            }
        }

        /// <summary>
        /// Displays the modify brand form
        /// </summary>
        /// <param name="Brand"></param>
        private void Modify_Brand(Models.Brand Brand)
        {
            AddBrandForm Form = new AddBrandForm(Brand.Name);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Brands();
        }

        /// <summary>
        /// Displays the add brand form
        /// </summary>
        private void Add_Brand()
        {
            AddBrandForm Form = new AddBrandForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Brands();
        }

        /// <summary>
        /// Deletes the brand if no article is linked to it
        /// </summary>
        /// <param name="Brand"></param>
        private void Delete_Brand(Models.Brand Brand)
        {
            // Todo detect if connected to an article
            // Only load the affected row
        }

        /// <summary>
        /// Double click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Double_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Item() != null)
                Modify_Brand(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to modify a brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Modify_Event(object sender, EventArgs e)
        {
            Modify_Brand(Get_Selected_Item());
        }

        /// <summary>
        /// Generic function to call to delete a brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Delete_Event(object sender, EventArgs e)
        {
            Delete_Brand(Get_Selected_Item());
        }

        /// <summary>
        /// Event handler to sort the columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Column_Click(object sender, ColumnClickEventArgs e)
        {
            this.Brand_List_View.ListViewItemSorter = new BrandItemComparer(e.Column);
        }

    }
    /// <summary>
    /// The comparer class for the list View sort
    /// </summary>
    class BrandItemComparer : IComparer
    {
        private int Col;
        private static bool ascendent = true;
        private static int lastSortedCol;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="column"></param>
        public BrandItemComparer(int column)
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
