

namespace Pizaria_Registro.Entities
{
    class Product

    {
        public String Nome { get; set; }
        public double Preco { get; set; }


        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
