using GethashCode_e_Equals.Entities;


Client a = new Client { name= "Maria", email="maria@gmail.com"};
Client b = new Client { name = "maria",email="maria@gmail.com" };
Console.WriteLine("get");
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine("equals");
Console.WriteLine(a.Equals(b));
Console.WriteLine(b.Equals(a));


