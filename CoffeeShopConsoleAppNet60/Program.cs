// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");



Latte latte = new Latte();


double pris = latte.Price();
Console.WriteLine(pris);


List<CoffeeClass> coffees = new List<CoffeeClass>();
Latte latte2 = new Latte();
Latte latte3 = new Latte();
Cortado cortado = new Cortado();
Cortado cortado2 = new Cortado();
BlackCoffee blackCoffee = new BlackCoffee();
BlackCoffee blackCoffee2 = new BlackCoffee();
Console.WriteLine(cortado.Price());

coffees.Add(blackCoffee);
coffees.Add(blackCoffee2);
coffees.Add(latte2);
coffees.Add(latte3);
coffees.Add(cortado);
coffees.Add(cortado2);

foreach (var coffe in coffees)
{
    Console.WriteLine(coffe);
}


