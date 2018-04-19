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
    /// Allows the user to create or modify a brand.
    /// </summary>
    public partial class AddBrandForm : Form
    {
        string Brand;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Brand">null for a creation or the brand to modify one</param>
        public AddBrandForm(string Brand)
        {   
            InitializeComponent();

            this.Brand = Brand;

            if (this.Brand != null)
                Auto_Fill();
        }

        /// <summary>
        /// Fills the form when the form is used for modification
        /// </summary>
        public void Auto_Fill()
        {
            this.Text = "Modification de la marque : " + Brand;
            this.Brand_Name_Text_Box.Text = Brand;
        }

        /// <summary>
        /// Event handler of the Add button. Validates the data then act on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // Validator
            if (this.Brand_Name_Text_Box.Text != "")
            {
                Database DB = Database.GetInstance();
                if (this.Brand == null)
                {
                    int id = DB.Get_Or_Create_Brand(this.Brand_Name_Text_Box.Text);
                    if (id != -1)
                    {
                        MessageBox.Show(this, "La marque à bien été crée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(this, "Erreur la marque n'a pas pu être crée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool Sucess = DB.Update_Brand(DB.Get_Or_Create_Brand(this.Brand), this.Brand_Name_Text_Box.Text);
                    if (Sucess)
                    {
                        MessageBox.Show(this, "La marque à bien été modifié !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(this, "Erreur la marque n'a pas pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
