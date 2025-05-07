using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizaria_Registro.Entities.Itens
{
    class OrderItem
    {
        public OrderItem()
        {
        }

        public int Quantidade { get; set; }
        public Double Preco { get; set; }

        public OrderItem(int quantidade, double preco)
        {
            Quantidade = quantidade;
            Preco = preco;
        }

        public double SubTotal() {


            return Quantidade * Preco;
        }

    }
}
