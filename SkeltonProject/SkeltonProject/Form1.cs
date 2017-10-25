using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeltonProject
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ぼたんぼたん");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("リストが押されました");
        }

        private void Testbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ボタン1が押されました");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
    }
}
