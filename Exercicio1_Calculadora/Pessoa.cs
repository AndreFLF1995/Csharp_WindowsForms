using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Calculadora
{
    internal class Pessoa
    {
        private string nome;
        private string contacto;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        public Pessoa(string nome, string contacto)
        {
            this.nome = nome;
            this.contacto = contacto;
        }

        public Pessoa()
        {
            this.nome = "";
            this.contacto = "";
        }
    }
}
