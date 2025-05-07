namespace Pizaria_Registro.Entities.Itens
{
    class Product

    {
        public string Nome { get; set; }
        public double Preco { get; set; }


        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
