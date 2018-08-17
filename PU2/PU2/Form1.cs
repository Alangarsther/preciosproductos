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
    public partial class Form1 : Form
    {
        private List<Productos> listaProductos = new List<Productos>();
        Productos[] nproductos = new Productos[10];
        private int  RowSelect;
        public Form1()
        {
            InitializeComponent();
            //comentario test
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            //object objeto = new object();
            //productos.producto_codigo = 12345698764;
            //productos.producto_nombre = "Miller";
            //productos.producto_precio = 36.00f;

            //richTextBox1.Text += productos.ToString();
            //richTextBox1.Text += productos.producto_codigo + productos.producto_nombre + productos.producto_precio;

            //productos.producto_codigo = 750101700502;
            //productos.producto_nombre = "lata de chiles";
            //productos.producto_precio = 19.900f;

            //richTextBox1.Text += productos.ToString();
            //richTextBox1.Text += productos.producto_codigo + productos.producto_nombre + productos.producto_precio;


            //listaProductos.Add(productos);

            //listaProdustos.Add(new Productos(123456789, "no se", 36.50f));

            //Productos productos1 = new Productos();

           // Productos[] nproductos = new Productos[10];
            nproductos[0] = new Productos(10, "caguama", 36.00);
            nproductos[1] = new Productos(11, "caguama", 36.00);
            nproductos[2] = new Productos(12, "caguama", 36.00);
            cargaProductos();

        }

        private void cargaProductos()
        {

            /*try
            {
                // for (int i = 0; i < nproductos.Length; i++)
                for (int i = 0; i < 3; i++)
                {
                    dataGridView1.Rows.Add(nproductos[i].producto_codigo, nproductos[i].producto_nombre.ToString(),nproductos[i].producto_precio.ToString());
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show("no se" +err);
            }*/
            try
            {
                int counter = 0;
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(@"c:\Users\AlanGarcia\Documents\Visual Studio 2017\precios y productos.csv");
                while ((line = file.ReadLine()) != null)
                {
                    richTextBox1.Text += line + Environment.NewLine;
                    dataGridView1.Rows.Add(line.Split(','));
                    dataGridView1.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                    counter++;

                }
                file.Close();

            }
            catch
            {

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[0, i].Value.ToString() == txtcod.Text)
                {
                    existe = true;
                    break;
                }
            }
            if (existe == false)
            {
                dataGridView1.Rows.Add(txtcod.Text, txtnom.Text, txtprecio.Text);
                dataGridView1_Numerar();
            }
            else
            {
                MessageBox.Show("No puede agregarse productos con codigo repetido", (MessageBoxButtons.OK).ToString());
                limpiar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtcod.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtnom.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtprecio.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                RowSelect = e.RowIndex;
                txtcod.Enabled = false;
            }

        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea eliminar " + dataGridView1[1, RowSelect].Value.ToString() + "con precio de : " + dataGridView1[2, RowSelect].Value.ToString(), "titulo de ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(RowSelect);
            }
            limpiar();
            dataGridView1_Numerar();
        }
        private void limpiar()
        {
            txtcod.Clear();
            txtnom.Clear();
            txtprecio.Clear();
            //txtcod.Enabled = true;
            txtcod.Focus();

        }
        private void dataGridView1_Numerar()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea modificar " + dataGridView1[1, RowSelect].Value.ToString()+ "con precio de : " + dataGridView1[2, RowSelect].Value.ToString(), "titulo de ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1[1,RowSelect].Value=txtnom.Text;
                dataGridView1[2,RowSelect].Value = txtprecio.Text; 
            }
            limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("favor de guardar el archivo");
            dataGridView1.SelectAll();
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DataObject dataObject = dataGridView1.GetClipboardContent();
            //File.WriteAllText(@"c:\Users\AlanGarcia\Documents\Visual Studio 2017\precios y productos.csv");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    class Productos
    {
        //propiedades
        public long producto_codigo = 0;
        public String producto_nombre = "";
        public float producto_precio = 0.00f;

        public Productos()
        {
            //MessageBox.Show("se llamaron");
        }

        public Productos(long producto_codigo, String producto_nombre, double producto_precio)
        {
            this.producto_codigo = producto_codigo;
            this.producto_nombre = producto_nombre;
            //this.producto_precio = float.Parse(producto_precio.ToString());
            this.producto_precio = (float)producto_precio;
        }
    }
}
