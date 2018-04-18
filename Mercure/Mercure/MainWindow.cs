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
            if (e.Column == 2 || e.Column == 3 || e.Column == 5)
            {
                string current = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (!current.Equals(listView1.Items[i].SubItems[e.Column].Text))
                    {
                        listView1.Groups.Add(new ListViewGroup(listView1.Items[i].SubItems[e.Column].Text, HorizontalAlignment.Left));
                        current = listView1.Items[i].SubItems[e.Column].Text;
                    }

                    listView1.Groups[listView1.Groups.Count - 1].Items.Add(listView1.Items[i]);
                }
            }
            else
                listView1.Groups.Clear();
        }

        public Models.Article getSelectedArticle()
        {
            Models.Article Article = new Models.Article();

            if (listView1.SelectedItems.Count == 0) return null;
            
            ListViewItem Item = listView1.SelectedItems[0];
            Models.Article A =  Database.GetInstance().getArticle(Item.SubItems[0].Text);
            return A;
        }

        private void On_Clicked_Item(object sender, EventArgs e)
        {
            Console.WriteLine(getSelectedArticle().Description);
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
