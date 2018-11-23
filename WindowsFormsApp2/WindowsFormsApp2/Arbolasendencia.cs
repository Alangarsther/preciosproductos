using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Arbolasendencia : Form
    {
        int cont=0;
        private String[] generacion;

        public Arbolasendencia()
        {
            InitializeComponent();
            generacion = new string[13];
            generacion[0] = "abuelop";
            generacion[1] = "abuelap";
            generacion[2] = "abuelom";
            generacion[3] = "abuelam";
            generacion[4] = "bisabuelop";
            generacion[5] = "bisabuelap";
            generacion[6] = "bisabuelom";
            generacion[7] = "bisabuelom";
            generacion[8] = "tatarabuelop";
            generacion[9] = "tatarabuelap";
            generacion[10] = "tatarabuelom";
            generacion[11] = "tatarabuelam";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = 0;
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Yo");
            Asendencia(treeView1.Nodes[0]);
            treeView1.ExpandAll();
        }

        private void Asendencia(TreeNode node)
        {
            int level = node.Level;
            if (level<genUpDown.Value)
            {
                cont++;

                string nom1 = "papa";
                string nom2 = "mama";
                if (level > 0)
                {
                    nom1 = generacion[level - 1] + "a";
                    nom2 = generacion[level - 1] + "b";
                }
                TreeNode papa = node.Nodes.Add(nom1 + "part1" + cont.ToString());
                Asendencia(papa);
                cont++;
                TreeNode mama = node.Nodes.Add(nom2 + "part2" + cont.ToString());
                Asendencia(mama);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
