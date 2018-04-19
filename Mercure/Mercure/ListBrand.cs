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
