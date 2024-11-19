using System;
using System.Windows.Forms;

namespace Exercicio1_Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, res = 0;

            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                n2 = Convert.ToDouble(txt_n2.Text);
            }
            catch
            {
                MessageBox.Show("Insira números por favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (rdoBtn_add.Checked)
            {
                res = n1 + n2;
            }
            else if (rdoBtn_sub.Checked)
            {
                res = n1 - n2;
            }
            else if (rdoBtn_mult.Checked)
            {
                res = n1 * n2;
            }
            else if (rdoBtn_div.Checked)
            {
                res = n1 / n2;
            }
            else
            {
                MessageBox.Show("Carregue numa das opções.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_total.Text = res.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_n1.Text.Length > 0)
            {
                txt_n1.Text = txt_n1.Text.Substring(0, txt_n1.Text.Length - 1);
            }
        }
    }
}
