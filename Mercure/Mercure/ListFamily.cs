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
    public partial class ListFamily : Form
    {
        public ListFamily()
        {
            InitializeComponent();
            Load_Families();
        }

        private void Load_Families()
        {
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
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFamilyForm aff = new AddFamilyForm(null);
            aff.ShowDialog();
        }
    }
}
