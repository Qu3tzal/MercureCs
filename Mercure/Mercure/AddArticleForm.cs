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
            this.Ref_Text_Box.Text = Article.Ref_Article;
            this.Description_Text_Box.Text = Article.Description;
            this.numericUpDown1.Value = Article.Quantity;
        }

        private void Load_Brand()
        {
            List<string> Brands = Database.GetInstance().getBrands();
            foreach (string S in Brands)
            {
                this.Brand_Combo_Box.Items.Add(S);
                if(Article != null && Article.Brand_Name.Equals(S))
                    this.Brand_Combo_Box.SelectedItem = S;
            }
        }

        private void Load_Sub_Familly()
        {
            List<string> Sub_Famillies = Database.GetInstance().getSubFamillies();
            foreach(string S in Sub_Famillies)
            {
                this.SubFamily_Combo_Box.Items.Add(S);
                if (Article != null && Article.Sub_Familly_Name.Equals(S))
                    this.SubFamily_Combo_Box.SelectedItem = S;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
