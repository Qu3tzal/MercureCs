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
    public partial class DeleteBrandForm : Form
    {
        private readonly string brand;

        public DeleteBrandForm(string brand)
        {
            InitializeComponent();

            this.brand = brand;
            Load_Brands();
        }

        private void Load_Brands()
        {
            List<string> Brands = Database.GetInstance().getBrands();
            foreach (string S in Brands)
            {
                this.Brand_Combo_Box.Items.Add(S);
                if (brand != null && brand.Equals(S))
                    this.Brand_Combo_Box.SelectedItem = S;
            }
        }
    }
}
