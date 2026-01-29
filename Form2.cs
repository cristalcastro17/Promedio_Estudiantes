using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promestudents26
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, prom, completivo = 0, notaFinal;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);

            prom = (n1 + n2 + n3 + n4) / 4;

            notaFinal = (prom * 0.5) + (completivo * 0.5);


            if (prom > 69)
                MessageBox.Show("La nota del completivo es " + notaFinal);

            else if (prom <= 69)
                MessageBox.Show("El estudiante no cumple con la nota suficiente, por favor ingresar sus notas de Extraordinario:");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
