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
        }

        private void fermerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneSousfamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubFamilyForm asff = new AddSubFamilyForm();
            asff.ShowDialog();
        }
    }
}
