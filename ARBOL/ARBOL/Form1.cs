using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARBOL
{
    public partial class Form1 : Form
    {
        int nump;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmComenzar_Click(object sender, EventArgs e)
        {
            nump = Convert.ToInt32(txtnump.Text);
            treeView1.Nodes.Add("Yo");
            treeView1.Nodes[0].Nodes.Add("Papa");
            treeView1.Nodes[0].Nodes.Add("Mama");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("AbueloP");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("AbuelaP");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("AbueloM");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("AbuelaM");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Tatarabuelop");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Tatarabuelap");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Tatarabuelom");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Tatarabuelam");
        }
    }
}
