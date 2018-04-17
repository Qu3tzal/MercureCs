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
    public partial class DataIntegrationForm : Form
    {
        public DataIntegrationForm()
        {
            InitializeComponent();
        }

        private void File_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.Filter = "Fichiers XML (*.xml)|*.xml|Tous les fichiers (*.*)|*.*";
            Dialog.FilterIndex = 1;
            Dialog.ShowDialog();

            this.File_Name_Input.Text = Dialog.FileName;
            Console.WriteLine("Selected file : " + Dialog.FileName);
        }

        private void File_Path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void File_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if(file != null && file.Length > 0)
                this.File_Name_Input.Text = file[0];
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataIntegrationForm_Load(object sender, EventArgs e)
        {

        }

        private void File_Name_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
