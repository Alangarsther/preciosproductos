using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PU2
{
    public partial class CHECADOR_DE_PERSONAL : Form
    {
        string ruta = Application.StartupPath;
        string Empleado = "";
        bool existe = false;
        int contador = 0;
       

        public CHECADOR_DE_PERSONAL()
        {
            InitializeComponent();
            lblempleado.Text = "";
            lblinf.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CHECADOR_DE_PERSONAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Empleado += e.KeyChar;
            if (e.KeyChar==13)
            {
                //if (Empleado.Trim() == "menu" || Empleado.Trim() == "MENU")
                //{
                //Menu menu = new Menu();
                //menu.show();
                //this.Hide();
                //}
                //else
                //{
                    contador = 0;
                    BuscarEmpleado(Empleado);
                    //System.Threading.Thread.Sleep(200);
                    Empleado = "";
                //}
             
            }
        }
        private void BuscarEmpleado(string Empleado)
        {
            String[] InfoEmpleado;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("Empleados.csv");
            while ((line=file.ReadLine())!=null)
            {
                InfoEmpleado = line.Split(',');
                if (Empleado.Trim() == InfoEmpleado[0])
                {
                    //ruta = ruta.Replace("bin\\Debug", "");

                    lblempleado.Text = ("No. Empleado: " + InfoEmpleado[0] + "\n \n" +  "Nombre Empleado: " + InfoEmpleado[1] + "\n \n" +  "Hora de Checada:" + lblfecha.Text);
                    pictureBox1.Image = Image.FromFile(InfoEmpleado[2]);
                    file.Close();
                    if (InfoEmpleado[4] == "SALIDA" || InfoEmpleado[4] == "")
                    {
                        lineChanger(InfoEmpleado[0] + "," + InfoEmpleado[1] + "," + InfoEmpleado[2] + "," + InfoEmpleado[3] + ",ENTRADA", contador);
                        lblinf.Text = "A REALIZADO UN REGISTRO DE -ENTRADA-";
                        lblinf.BackColor = Color.Lime;
                    }
                    else
                    {
                        lineChanger(InfoEmpleado[0] + "," + InfoEmpleado[1] + "," + InfoEmpleado[2] + "," + InfoEmpleado[3] + ",SALIDA", contador);
                        lblinf.Text = "A REALIZADO UN REGISTRO DE -SALIDA-";
                        lblinf.BackColor = Color.Red;
                    }
                    lblempleado.Update();
                    pictureBox1.Update();
                    //System.Threading.Thread.Sleep(5000);
                    existe = true;

                    break;
                }

                contador++;
            }
            if (existe==false)
            {
                MessageBox.Show("NO ESTA REGISTRADO POR FAVOR VERIFIQUE O INTENTE DE NUEVO");
                contador = 0;
            }
        }

        private void CHECADOR_DE_PERSONAL_Load(object sender, EventArgs e)
        {
            lbltitulo.Location = new Point(this.Width / 2 - lbltitulo.Width / 2, 10);
            lblfecha.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lbltitulo.Height + 11);

            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lbltitulo.Height + lblsubtitulo.Height + 21);

            //lblempleado.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lbltitulo.Height + lblsubtitulo.Height + lblfecha.Height + 300);
            //lblinf.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lbltitulo.Height + lblsubtitulo.Height + lblfecha.Height + lblinf.Height + 30);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
            lblfecha.Location = new Point(this.Width / 2 - lblfecha.Width / 2, lbltitulo.Height + lblsubtitulo.Height + 20);
        }

        private void MandarCorreo(String Mensaje, string correo)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            try
            {
                msg.To.Add(correo);
                //msg.To.Add("ebarnett57@gmail.com");
                msg.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess;
                msg.Priority = System.Net.Mail.MailPriority.High;
                msg.From = new System.Net.Mail.MailAddress("alan_gh89@hotmail.com", "ALAN", System.Text.Encoding.UTF8);
                msg.Subject = "Checador";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = Mensaje;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = false;
                SmtpClient client = new SmtpClient(); 
                client.Host = "smtp.hotmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new
               System.Net.NetworkCredential("alan_gh89@hotmail.coM", "Contraseña");
                client.Send(msg);
                MessageBox.Show("ya mande el correo!!!");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK,
               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK,
               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        static void lineChanger(string newtext, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines("Empleados.csv");
            arrLine[line_to_edit] = newtext;
            File.WriteAllLines("Empleados.csv", arrLine);
        }
    }
}
