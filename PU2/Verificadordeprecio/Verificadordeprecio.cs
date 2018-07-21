using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificadordeprecio
{
    public partial class Verificadordeprecio : Form
    {
        DateTime fecha = new DateTime();
        public Verificadordeprecio()
        {
            InitializeComponent();
        }

        private void Verificadordeprecio_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, 10);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, label1.Height + 11);
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = label2.Location = new Point(this.Width / 2 - lblfecha.Width / 2, label1.Height+label2.Height + 21);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = label2.Location = new Point(this.Width / 2 - lblfecha.Width / 2, label1.Height + label2.Height + 21);

        }
    }
}
