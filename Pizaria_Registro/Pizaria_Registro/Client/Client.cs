using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizaria_Registro.Client
{
    class Client
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Client(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
