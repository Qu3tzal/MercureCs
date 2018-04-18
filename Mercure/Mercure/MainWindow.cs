using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void yoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void On_Column_Clicked(object sender, ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }


    }

    class ListViewItemComparer : IComparer
    {
        private int Col;
        private static bool ascendent = true;
        private static int lastSortedCol;
        
        public ListViewItemComparer(int column)
        {
            
            if (lastSortedCol == column)
                ascendent = !ascendent;
            else
                ascendent = true;

            lastSortedCol = column;
            Col = column;
        }

        public int Compare(object x, object y)
        {
            int result = 0;
           
            if(Col == 4 || Col == 5)
            {
                float a = float.Parse(((ListViewItem)x).SubItems[Col].Text);
                float b = float.Parse(((ListViewItem)y).SubItems[Col].Text);

                if(a == b) result =  0;
                else if(a < b) result = -1;
                else result =  1;
            }                 
            else
                result = String.Compare(((ListViewItem)x).SubItems[Col].Text, ((ListViewItem)y).SubItems[Col].Text);

            if (!ascendent)
                return -result;
            return result;
                
        }
    }
}
