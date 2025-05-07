using Pizaria_Registro.Entities;
using Pizaria_Registro.Entities.Itens;
OrderItem list = new OrderItem();
Order order = new Order();

Console.WriteLine("digite o produto");
int a = 2;
double b = 0;
list = new ( a,b );
order.RemoveItem();
Console.WriteLine( order.Lista.Count());



