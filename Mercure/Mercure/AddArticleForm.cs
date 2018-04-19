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
    /// <summary>
    /// Allows the user to create or modify an article.
    /// </summary>
    public partial class AddArticleForm : Form
    {
        private Models.Article Article;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Article">null for a creation or the article to modify one</param>
        public AddArticleForm(Models.Article Article)
        {
            InitializeComponent();
            this.Article = Article;

            Load_Sub_Familly();
            Load_Brand();

            if (Article != null)
                Auto_Fill();
        }

        /// <summary>
        /// Fills the form if this is a modification
        /// </summary>
        private void Auto_Fill()
        {
            this.Ref_Text_Box.Text = Article.Ref_Article;
            this.Description_Text_Box.Text = Article.Description;
            this.Quantity_upDown.Value = Article.Quantity;
            this.Price_UpDown.Value = new Decimal(Article.Price_HT);
            this.Add_Button.Text = "Modifier";
            this.Ref_Text_Box.ReadOnly = true;
            this.Text = "Modification de l'article : " + Article.Ref_Article;
        }

        /// <summary>
        /// Fills the brands combo box
        /// </summary>
        private void Load_Brand()
        {
            this.Brand_Combo_Box.Items.Clear();
            List<Models.Brand> Brands = Database.GetInstance().Get_Brands();
            foreach (Models.Brand S in Brands)
            {
                this.Brand_Combo_Box.Items.Add(S.Name);
                if(Article != null && Article.Brand_Name.Equals(S.Name))
                    this.Brand_Combo_Box.SelectedItem = S.Name;
            }
        }

        /// <summary>
        /// Fills the sub-family combo box
        /// </summary>
        private void Load_Sub_Familly()
        {
            this.SubFamily_Combo_Box.Items.Clear();
            List<Models.SubFamily> Sub_Famillies = Database.GetInstance().Get_Sub_Families();
            foreach (Models.SubFamily S in Sub_Famillies)
            {
                this.SubFamily_Combo_Box.Items.Add(S.Name);
                if (Article != null && Article.Sub_Familly_Name.Equals(S.Name))
                    this.SubFamily_Combo_Box.SelectedItem = S.Name;
            }
        }

        /// <summary>
        /// Event handler of the Add button. Validates the data then act on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
                string Reference = this.Ref_Text_Box.Text;
                string Description = this.Description_Text_Box.Text;
                int Quantity = (int)this.Quantity_upDown.Value;
                float Price = (float)this.Price_UpDown.Value;
                string Sub_Familly = "";
                if(this.SubFamily_Combo_Box.SelectedItem != null)
                    Sub_Familly = this.SubFamily_Combo_Box.SelectedItem.ToString();
                
                string Brand = "";
                if (this.Brand_Combo_Box.SelectedItem != null)
                    Brand = this.Brand_Combo_Box.SelectedItem.ToString();

                // Validator
                if (Reference != "" && Description != "" && Quantity != 0 && Price != 0 && Sub_Familly != "" && Brand != "")
                {

                    if (Article != null)
                    {

                        Database DB = Database.GetInstance();
                        bool Result = DB.Update_Article(Description, Reference, DB.Get_Brand_ID(Brand), DB.Get_Sub_Familly_ID(Sub_Familly), Price, Quantity);

                        if (Result)
                        {
                            MessageBox.Show(this, "L'article à bien été modifié", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(this, "Erreur l'article n'a pas pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        Database DB = Database.GetInstance();
                        bool Result = DB.Create_Article(Reference, DB.Get_Sub_Familly_ID(Sub_Familly), DB.Get_Brand_ID(Brand), Description, Price, Quantity);

                        if (Result)
                        {
                            MessageBox.Show(this, "L'article à bien été crée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(this, "Erreur l'article n'a pas pu être Crée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult Res = MessageBox.Show(this, "Erreur un ou plusieurs champ est invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        /// <summary>
        /// Event handler when the form is canceled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Event handler when the create sub-family button is cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Create_SubFamily_Button_Click(object sender, EventArgs e)
        {
            AddSubFamilyForm Form = new AddSubFamilyForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                Load_Sub_Familly();

        }

        /// <summary>
        /// Event handler when the create brand button is cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Create_Brand_Button_Click(object sender, EventArgs e)
        {
            AddBrandForm Form = new AddBrandForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                Load_Brand();
        }

    }
}
