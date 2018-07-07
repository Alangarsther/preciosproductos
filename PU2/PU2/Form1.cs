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
    public partial class Form1 : Form
    {
        private List<Productos> listaProductos = new List<Productos>();
        Productos[] nproductos = new Productos[10];
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

            try
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
            }
          

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
            MessageBox.Show("se llamaron");
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
