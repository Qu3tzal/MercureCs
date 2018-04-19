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
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFamilyForm aff = new AddFamilyForm();
            aff.ShowDialog();
        }
    }
}
