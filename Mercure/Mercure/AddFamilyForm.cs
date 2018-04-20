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
    /// Allows the user to create or modify a family.
    /// </summary>
    public partial class AddFamilyForm : Form
    {
        string Family;

        /// <summary>
        /// Inserted id
        /// </summary>
        public int Inserted_Id {get;set;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Familly">null for a creation or the family to modify one</param>
        public AddFamilyForm(string Familly)
        {
            InitializeComponent();

            this.Family = Familly;
            if (this.Family != null)
                Auto_Fill();

        }

        /// <summary>
        /// Fills the form when the form is used for modification
        /// </summary>
        private void Auto_Fill()
        {
            this.Text = "Modification de la famille : " + Family;
            this.Family_Name_Text_Box.Text = Family;
        }

        /// <summary>
        /// Event handler of the Add button. Validates the data then act on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // Validator
            if (this.Family_Name_Text_Box.Text != "")
            {
                Database DB = Database.GetInstance();
                if (this.Family == null)
                {
                    int id = DB.Get_Or_Create_Familly(this.Family_Name_Text_Box.Text);
                    if (id != -1)
                    {
                        Inserted_Id = id;
                        MessageBox.Show(this, "La famille à bien été crée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(this, "Erreur la famille n'a pas pu être crée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool Sucess = DB.Update_Familly(DB.Get_Or_Create_Familly(this.Family), this.Family_Name_Text_Box.Text);
                    if (Sucess)
                    {
                        MessageBox.Show(this, "La famille à bien été modifié !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(this, "Erreur la famille n'a pas pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
