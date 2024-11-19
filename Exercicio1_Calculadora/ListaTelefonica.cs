using System;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Exercicio1_Calculadora
{
    public partial class ListaTelefonica : Form
    {
        ListaPessoas lp = new ListaPessoas();
        public ListaTelefonica()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();

                if (!soLetras(textBox1.Text))
                {
                    MessageBox.Show("Ocorreu um erro. Corrija o seu input e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    p.Nome = textBox1.Text;
                }

                if (!soNum(textBox3.Text))
                {
                    MessageBox.Show("Ocorreu um erro. Corrija o seu input e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    p.Contacto = textBox3.Text;
                }

                lp.insere_pessoa(p);
                lst_ListaNomes.Items.Add($"{p.Nome} - {p.Contacto}");

                label2.Text = "Quantidade de Contactos: " + lp.contaPessoas().ToString();
                textBox1.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro. Corrija o seu input e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lst_ListaNomes.SelectedIndex;
                Pessoa pessoaSelecionada = lp.getLp()[index];

                lp.getLp().RemoveAt(index);

                mostraPessoa();

                label2.Text = "Quantidade de Contactos: " + lp.contaPessoas().ToString();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                if (!soLetras(textBox1.Text))
                {
                    return;
                }
                else
                {
                    p.Nome = textBox1.Text;
                }

                if (!soNum(textBox3.Text))
                {
                    return;
                }
                else
                {
                    p.Contacto = textBox3.Text;
                }

                int index = lst_ListaNomes.SelectedIndex;
                lst_ListaNomes.Items[index] = $"{p.Nome} - {p.Contacto}";


                textBox1.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ord_Click(object sender, EventArgs e)
        {
            lp.ordenaPessoa();

            mostraPessoa();
        }

        public void mostraPessoa()
        {
            lst_ListaNomes.Items.Clear();
            foreach (var pessoa in lp.getLp())
            {
                lst_ListaNomes.Items.Add($"{pessoa.Nome} - {pessoa.Contacto}");
            }
        }

        public bool soLetras(string s1)
        {
            Regex lettersOnly = new Regex("^[a-zA-Z]+$");
            if (!lettersOnly.IsMatch(s1))
            {
                MessageBox.Show("Só são permitidos caracteres alfabéticos (letras) no Nome. O campo não pode estar vazio.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool soNum(string s1)
        {
            Regex lettersOnly = new Regex(@"^\d+$");
            if (!lettersOnly.IsMatch(s1))
            {
                MessageBox.Show("Só são permitidos caracteres numéricos (números) no Contacto. O campo não pode estar vazio.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
