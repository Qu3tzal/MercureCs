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
    public partial class AddArticleForm : Form
    {
        private Models.Article Article;

        public AddArticleForm(Models.Article Article)
        {
            InitializeComponent();
            this.Article = Article;

            Load_Sub_Familly();
            Load_Brand();

            if (Article != null)
                Auto_Fill();
        }

        private void Auto_Fill()
        {

        }

        private void Load_Brand()
        {
            List<string> Brands = Database.GetInstance().getBrands();
            foreach (string S in Brands)
            {
                this.Brand_Combo_Box.Items.Add(S);
            }
        }

        private void Load_Sub_Familly()
        {
            List<string> Sub_Famillies = Database.GetInstance().getSubFamillies();
            foreach(string S in Sub_Famillies)
            {
                this.SubFamily_Combo_Box.Items.Add(S);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
