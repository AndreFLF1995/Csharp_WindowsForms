using System;
using System.Windows.Forms;

namespace Exercicio1_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Calculadora c1 = new Calculadora();
            c1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaTelefonica lista = new ListaTelefonica();
            lista.Show();
        }
    }
}
