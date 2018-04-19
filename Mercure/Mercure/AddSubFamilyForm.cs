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
    /// Allows the user to create or modify a sub-family.
    /// </summary>
    public partial class AddSubFamilyForm : Form
    {
        string SubFamily;
        string Family;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Familly">null for a creation or the sub-family to modify one</param>
        public AddSubFamilyForm(string SubFamilly)
        {
            InitializeComponent();

            this.SubFamily = SubFamilly;

            if (SubFamilly != null)
            {
                Family = Database.GetInstance().Get_Family_With_Id(Database.GetInstance().Get_Sub_Family(SubFamilly).Family_Id).Name;
                Auto_Fill();
            }
            else
            {
                Family = null;
            }
            this.Select_Family_Radio_Button.Checked = true;
            Load_Famillies(); 
        }

        /// <summary>
        /// Fills the form when the form is used for modification
        /// </summary>
        private void Auto_Fill()
        {
            this.Text = "Modification : " + SubFamily;
            this.SubFamily_Name_Text_Box.Text = SubFamily;
        }

        /// <summary>
        /// Fills the families combo box
        /// </summary>
        private void Load_Famillies()
        {
            this.Select_Family_Combo_Box.Items.Clear();
            List<Models.Family> Famillies = Database.GetInstance().Get_Families();
            foreach (Models.Family S in Famillies)
            {
                this.Select_Family_Combo_Box.Items.Add(S.Name);
                if (SubFamily != null && Family.Equals(S.Name))
                    this.Select_Family_Combo_Box.SelectedItem = S.Name;
            }
        }

        /// <summary>
        /// Event handler when the radio button selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Checked(object sender, EventArgs e)
        {

           On_Familly_Checked(this.Select_Family_Radio_Button.Checked);

           On_Create_Checked(this.radioButton1.Checked);

        }

        /// <summary>
        /// Enable/disable the family name text box
        /// </summary>
        /// <param name="Checked"></param>
        private void On_Familly_Checked(bool Checked)
        {
            if (Checked)
            {
                this.New_Family_Name.Enabled = false;
            }
            else
            {
                this.New_Family_Name.Enabled = true;
            }

        }

        /// <summary>
        /// Enable/disable the select family combo box
        /// </summary>
        /// <param name="Checked"></param>
        private void On_Create_Checked(bool Checked)
        {
            if (Checked)
            {
                this.Select_Family_Combo_Box.Enabled = false;
            }
            else
            {
                this.Select_Family_Combo_Box.Enabled = true;
            }
        }

        /// <summary>
        /// Event handler of the Add button. Validates the data then act on the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_SubFamily_Click(object sender, EventArgs e)
        {
            if (this.Select_Family_Radio_Button.Checked)
            {
                //If the family already exists
                // Validator
                string Family = "";
                if(this.Select_Family_Combo_Box.SelectedItem != null)
                    Family = this.Select_Family_Combo_Box.SelectedItem.ToString();

                if (this.SubFamily_Name_Text_Box.Text != "" && Family != "")
                {
                    Database DB = Database.GetInstance();
                    if (this.SubFamily == null)
                    {
                        int Id = DB.Get_Or_Create_Sub_Familly(DB.Get_Familly_ID(Family), this.SubFamily_Name_Text_Box.Text);
                        if (Id != -1)
                        {
                            MessageBox.Show(this, "La Sous Famille a bien été crée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(this, "Erreur la sous famille n'a pas pu être crée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool Sucess = DB.Update_Sub_Familly(DB.Get_Sub_Familly_ID(this.SubFamily), DB.Get_Familly_ID(Family), this.SubFamily_Name_Text_Box.Text);
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
            // If we create the familly
            else
            {
                // Validator
                if (this.New_Family_Name.Text != "" && this.SubFamily_Name_Text_Box.Text != "")
                {
                    Database DB = Database.GetInstance();
                    if (this.SubFamily == null)
                    {
                        int Id = DB.Get_Or_Create_Familly(this.New_Family_Name.Text);
                        Id = DB.Get_Or_Create_Sub_Familly(Id, this.SubFamily_Name_Text_Box.Text);
                        if (Id != -1)
                        {
                            MessageBox.Show(this, "La Sous Famille et la Famille ont bien été crée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(this, "Erreur la sous famille n'a pas pu être crée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        int Id = DB.Get_Or_Create_Familly(this.New_Family_Name.Text);
                        bool Sucess = DB.Update_Sub_Familly(DB.Get_Sub_Familly_ID(this.SubFamily), Id, this.SubFamily_Name_Text_Box.Text);
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
