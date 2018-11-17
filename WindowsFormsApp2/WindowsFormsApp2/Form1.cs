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
    public partial class Form1 : Form
    {
        int i=1, nump, numgen, totalp, cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nump = Convert.ToInt32(txtnump.Text);
            numgen = Convert.ToInt32(txtnumgen.Text);
            ListBoxRes.Items.Clear();
            for (int i = 1; i <=5; i++)
            {
                if (nump < numgen)
                {
                    totalp = nump + (numgen * i);
                    ListBoxRes.Items.Add(totalp.ToString());
                    //richTxttotalp.Text = totalp.ToString("###,###");
                    cont++;
                }
            }
            
        }
    }
}
