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
            Load_Families();
        }

        private void Load_Families()
        {
            this.Family_List_View.Clear();

            Database db = Database.GetInstance();
            List<Models.Family> families = db.Get_Families();

            Family_List_View.Columns.Add("Id Famille", -2, HorizontalAlignment.Left);
            Family_List_View.Columns.Add("Nom", -2, HorizontalAlignment.Left);

            foreach (Models.Family f in families)
            {
                String[] row = { "" + f.Id, f.Name };
                ListViewItem lvi = new ListViewItem(row);
                Family_List_View.Items.Add(lvi);
            }

            Family_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Family_List_View.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Family();
        }

        private Models.Family Get_Selected_Item()
        {
            if (this.Family_List_View.SelectedItems.Count != 0)
            {
                Models.Family Family = new Models.Family();
                ListViewItem Item = this.Family_List_View.SelectedItems[0];

                Family.Id = int.Parse(Item.SubItems[0].Text);
                Family.Name = Item.SubItems[1].Text;

                return Family;
            }
            else return null;
        }

        private void On_Open_Menu_Strip(object sender, CancelEventArgs e)
        {
            if (Get_Selected_Item() == null)
            {
                this.contextMenuStrip1.Items[1].Visible = false;
                this.contextMenuStrip1.Items[2].Visible = false;
                this.contextMenuStrip1.Items[3].Visible = false;
            }
            else
            {
                this.contextMenuStrip1.Items[1].Visible = true;
                this.contextMenuStrip1.Items[2].Visible = true;
                this.contextMenuStrip1.Items[3].Visible = true;
            }
        }

        private void On_Key_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Load_Families();
            else if (e.KeyCode == Keys.Enter)
            {
                Models.Family Family = Get_Selected_Item();
                if (Family != null)
                    Modify_Family(Family);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Models.Family Family = Get_Selected_Item();
                if (Family != null)
                    Delete_Family(Family);
            }
        }

        private void Modify_Family(Models.Family Family)
        {
            AddFamilyForm Form = new AddFamilyForm(Family.Name);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Families();
        }

        private void Add_Family()
        {
            AddFamilyForm Form = new AddFamilyForm(null);
            DialogResult Result = Form.ShowDialog();

            if (Result == DialogResult.OK)
                // TODO Only refresh affected article
                Load_Families();
        }

        private void Delete_Family(Models.Family Family)
        {
            // Todo detect if connected to an article
            // Only load the affected row
        }

        private void On_Double_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Item() != null)
                Modify_Family(Get_Selected_Item());
        }

        private void On_Modify_Event(object sender, EventArgs e)
        {
            Modify_Family(Get_Selected_Item());
        }

        private void On_Delete_Event(object sender, EventArgs e)
        {
            Delete_Family(Get_Selected_Item());
        }

    }
}
