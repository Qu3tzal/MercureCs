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
    public partial class AddFamilyForm : Form
    {      
        string Family;
        public AddFamilyForm(string Familly)
        {
            InitializeComponent();

            this.Family = Familly;
            if (this.Family != null)
                Auto_Fill();

        }

        private void Auto_Fill()
        {
            this.Text = "Modification de la famille : " + Family;
            this.Family_Name_Text_Box.Text = Family;
        }

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

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
