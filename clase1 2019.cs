using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarando las variablesw del evento
            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox1.Text);
            r = a + b;
            label3.Text = r.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox1.Text);
            r = a - b;
            label3.Text = r.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox1.Text);
            r = a * b;
            label3.Text = r.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string Dato;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox1.Text);
            r = a / b;
            Dato= "Resultado" + r.ToString();
            label3.Text = r.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
