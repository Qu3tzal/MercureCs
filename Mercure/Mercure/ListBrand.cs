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
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrandForm abf = new AddBrandForm(null);
            abf.ShowDialog();
        }
    }
}
