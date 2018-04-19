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
    public partial class ListBrand : Form
    {
        public ListBrand()
        {
            InitializeComponent();
            
            Load_Brands();
        }

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

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Brand();
        }

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

        private void Modify_Brand(Models.Brand Brand)
        {
            AddBrandForm Form = new AddBrandForm(Brand.Name);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Brands();
        }

        private void Add_Brand()
        {
            AddBrandForm Form = new AddBrandForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Brands();
        }

        private void Delete_Brand(Models.Brand Brand)
        {
            // Todo detect if connected to an article
            // Only load the affected row
        }

        private void On_Double_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Item() != null)
                Modify_Brand(Get_Selected_Item());
        }

        private void On_Modify_Event(object sender, EventArgs e)
        {
            Modify_Brand(Get_Selected_Item());
        }

        private void On_Delete_Event(object sender, EventArgs e)
        {
            Delete_Brand(Get_Selected_Item());
        }

    }
}
