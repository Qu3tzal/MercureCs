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
    public partial class ListSubFamily : Form
    {
        public ListSubFamily()
        {
            InitializeComponent();
            Load_SubFamilies();
        }

        private void Load_SubFamilies()
        {
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
        }


        private void fermerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneSousfamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubFamilyForm asff = new AddSubFamilyForm(null);
            asff.ShowDialog();
        }
    }
}
