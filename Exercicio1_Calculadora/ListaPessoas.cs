using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Calculadora
{
    internal class ListaPessoas
    {
        private static List<Pessoa> lpessoas = new List<Pessoa>();

        public List<Pessoa> getLp()
        {
            return lpessoas;
        }

        public void insere_pessoa(Pessoa p1)
        {
            lpessoas.Add(p1);
        }
        public void apaga_pessoa(int pos)
        {
            lpessoas.RemoveAt(pos);
        }
        public void apaga_pessoa(Pessoa p1)
        {
            lpessoas.Remove(p1);
        }
        public List<Pessoa> retornaElementos()
        {
            return lpessoas;
        }
        public int contaPessoas()
        {
            return lpessoas.Count;
        }
        public void editapessoa(Pessoa p1, int pos)
        {

            lpessoas[pos] = p1;
        }

        public void ordenaPessoa()
        {
            lpessoas.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));
        }
    }
}
