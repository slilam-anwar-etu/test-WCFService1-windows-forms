using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWCF
{
    public partial class Form1 : Form
    {
        WCFService1.ServiceClient cal = new WCFService1.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtz.Text = Convert.ToString(cal.WebAdd(int.Parse(txtx.Text), int.Parse(txty.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtz.Text = Convert.ToString(cal.WebSoustraction(int.Parse(txtx.Text), int.Parse(txty.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtz.Text = Convert.ToString(cal.WebMultiply(int.Parse(txtx.Text), int.Parse(txty.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtz.Text = Convert.ToString(cal.WebDivision(int.Parse(txtx.Text), int.Parse(txty.Text)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
