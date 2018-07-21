using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PU2
{
    public partial class Puntoventa : Form
    {
        public Puntoventa()
        {
            InitializeComponent();
        }

        private void Puntoventa_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, 10);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, label1.Height + 11);
            label3.Text = DateTime.Now.ToString();
            label3.Location = new Point(this.Width / 2 - label3.Width / 2, label1.Height + label2.Height + 21);
            dataGridView1.Width = this.Width - 3;
            dataGridView1.Height = int.Parse(this.Height * 075f + "");
            dataGridView1.Location = new Point(1, label1.Height + label2.Height +  label3.Height + 21);
            textBox1.Width = this.Width - 2;
            textBox1.Location = new Point(0, this.Height - textBox1.Height);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
