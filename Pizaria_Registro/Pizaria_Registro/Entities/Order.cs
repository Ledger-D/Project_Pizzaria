using Pizaria_Registro.Enums;
using Pizaria_Registro.Entities.Itens;

namespace Pizaria_Registro.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Lista = new List<OrderItem>();

        public Order() { }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            ///, Product produto) { 
            ///   List<Product> prod = new List<Product>();


            Lista.Add(item);
            /// prod.Add(produto);

        }
        public void RemoveItem()
        {
            Console.WriteLine(Lista.Count);
            if (Lista.Count == 0)
            {
                throw new InvalidOperationException("Item vazio;");
            }
            

        }


    }
}
