using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe2CSharp
{
    internal class NomeCompleto
    {
        public string nome;      //propriedade da classe
        public string sobreNome; //propriedade da classe

        public void NomeInteiro()
        {
            MessageBox.Show(Resposta());
        }

        private string Resposta()
        {
            string completo = nome + " " + sobreNome;
            return completo;
        }
    }
}
