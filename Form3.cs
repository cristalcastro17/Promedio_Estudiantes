using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promestudents26
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, prom, notaFinalCompletivo, notaCompletivo = 0;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);

            prom = (n1 + n2 + n3 + n4) / 4; 

           notaFinalCompletivo = (prom * 0.3) + (notaCompletivo * 0.7);

            if (notaFinalCompletivo > 69)
                MessageBox.Show("EL ESTUDIANTE ESTA APROBADO");

            if (notaFinalCompletivo <= 69)
                MessageBox.Show("EL ESTUDIANTE ESTA REPROBADO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
