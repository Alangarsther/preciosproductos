using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PU2
{
    public partial class VerificadordePrecio : Form
    {
        private  string codigo="";
        public VerificadordePrecio()
        {
            InitializeComponent();
        }

        private void VerificadordePrecio_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, 10);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, label1.Height + 11);
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = label2.Location = new Point(this.Width / 2 - lblfecha.Width / 2, label1.Height + label2.Height + 21);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = label2.Location = new Point(this.Width / 2 - lblfecha.Width / 2, label1.Height + label2.Height + 21);

        }


        private void buscar(string texto)
        {
            string[] precioproducto;
            string line;
            StreamReader file= new StreamReader("precios y productos.csv");
            MessageBox.Show(texto);
            while ((line= file.ReadLine())!=null)
            {
                precioproducto = line.Split(',');
                if (texto==precioproducto[0])
                {
                    label3.Text = "Nombre" + precioproducto[1] + "Precio:$" + precioproducto[2];
                }
            }
            file.Close();
        }

        private void VerificadordePrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigo += e.KeyChar;
            if (e.KeyChar == 13)
            {
                //MessageBox.Show(codigo.Trim());
                buscar(codigo.Trim());
                codigo="";
            }
        }
    }
}
