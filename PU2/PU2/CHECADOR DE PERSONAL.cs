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
    public partial class CHECADOR_DE_PERSONAL : Form
    {
        string ruta = Application.StartupPath;
        string Empleado = "";
        bool existe = "";
        public CHECADOR_DE_PERSONAL()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CHECADOR_DE_PERSONAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Empleado += e.KeyChar;
            if (e.KeyChar==13)
            {
                BuscarEmpleado(Empleado);
                System.Threading.Thread.Sleep(200);
                Empleado = "";
            }
        }
        private void BuscarEmpleado(string Empleado)
        {
            String[] InfoEmpleado;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("Empleados.csv");

        }

        private void CHECADOR_DE_PERSONAL_Load(object sender, EventArgs e)
        {
            lbltitulo.Location = new Point(this.Width / 2 - lbltitulo.Width / 2, 10);
            lblsubtitulo.Location = new Point(this.Width / 2 - lblsubtitulo.Width / 2, lbltitulo.Height + 11);

            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lblsubtitulo.Height + 11);

            label2.locatiom
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lblsubtitulo.Height + 11);
        }
    }
}
