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
        private double total = 0, cambio = 0, monedas = 0, subtotal = 0;
        bool existe = false;
        private string[] cantidadproducto;
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
            dataGridView1.Location = new Point(1, label1.Height + label2.Height + label3.Height + 21);
            textBox1.Width = this.Width - 2;
            textBox1.Location = new Point(0, this.Height - textBox1.Height);

            dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.15);
            dataGridView1.Columns[1].Width = Convert.ToInt32(this.Width * 0.645);
            dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.20);
            lbltotal.Location = new Point(this.Width - lbltotal.Width + 2, this.Height - textBox1.Height - lbltotal.Height);
            updateFontDgv();

            textBox1.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show(textBox1.Text);
                if (textBox1.Text.IndexOf("*")==-1)
                {
                    buscarproducto(1,textBox1.Text);
                }
               // else if (textBox1.Text.ToLower() == "menu")
                //{
                    //Menu menu = new Menu();
                    //menu.Show();
                    //this.Hide();
                //}
                else
                {
                    cantidadproducto=textBox1.Text.Split('*');
                    buscarproducto(int.Parse(cantidadproducto[0]), cantidadproducto[1]);
                }
                
                textBox1.Clear();
                textBox1.Focus();
            }
            if (e.KeyChar == 27)
            {
                Eliminarproducto();
                Total();
            }

            if (e.KeyChar == 9)
            {
                dublicarultimoproducto();
                Total();
            }

            if (e.KeyChar.ToString() == "p")
            {
                Pago();
                Total();
            }
        }
        private void buscarproducto(int cantidad,string idproducto)
        {
            string[] infoproducto;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\AlanGarcia\source\repos\PU2\PU2\bin\Debug\precios y productos.csv");
            MessageBox.Show(idproducto);
            while ((line = file.ReadLine()) != null)
            {
                infoproducto = (line.Split(','));
                //MessageBox.Show(idproducto + " " + infoproducto[0]);
                if (idproducto == infoproducto[0])
                {
                    dataGridView1.Rows.Add(cantidad, infoproducto[1], infoproducto[2], cantidad * double.Parse(infoproducto[2]));
                    total = total + Convert.ToDouble(infoproducto[2]);

                    Total();
                    existe = true;

                    //label4.Text = "Nombre" + precioproducto[1] + "Precio:$" + precioproducto[2];
                }
            }
            file.Close();
        }
        private void updateFontDgv()
        {
            foreach ( DataGridViewColumn c in dataGridView1.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Arial", 20, GraphicsUnit.Pixel);
            }
            dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.15);
            dataGridView1.Columns[1].Width = Convert.ToInt32(this.Width * 0.645);
            dataGridView1.Columns[0].Width = Convert.ToInt32(this.Width * 0.20);
        }
        private void Eliminarproducto()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
           
        }
        private void Total()
        {
            double total = 0;
            for (int i = 0; i <dataGridView1.Rows.Count;i++)
            {
                total += Convert.ToDouble(dataGridView1[2, i].Value.ToString());

            }
            lbltotal.Text = "total$:" + total.ToString("n");
            lbltotal.Location = new Point(this.Width - lbltotal.Width + 2, this.Height - textBox1.Height - lbltotal.Height);

        }
        private void Pago()
        {
            monedas = Convert.ToDouble(textBox1.Text);
            subtotal += this.total;


            this.total = Convert.ToDouble(textBox1.Text) - this.total;
            cambio = total;
            lbltotal.Text = "Cambio: $" + total;
            lbltotal.Location = new Point(this.Width - 120, this.Height - lbltotal.Height - 60);
            textBox1.Clear();

            Imprimir();
            dataGridView1.Rows.Clear();
            textBox1.Clear();
        }
        private void dublicarultimoproducto()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Add(dataGridView1[0, dataGridView1.Rows.Count - 1].Value.ToString());
                dataGridView1[1, dataGridView1.Rows.Count - 1].Value.ToString();
                dataGridView1[2, dataGridView1.Rows.Count - 1].Value.ToString();
                dataGridView1[3, dataGridView1.Rows.Count - 1].Value.ToString();
            }
        }
        private void Imprimir()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
