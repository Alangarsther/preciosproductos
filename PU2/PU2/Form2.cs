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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificadordePrecio verificadordePrecio = new VerificadordePrecio();
            verificadordePrecio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 crow = new Form1();
            crow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Puntoventa puntoventa = new Puntoventa();
            puntoventa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CHECADOR_DE_PERSONAL CHECADOR = new CHECADOR_DE_PERSONAL();
            CHECADOR.Show();
        }
    }
}
