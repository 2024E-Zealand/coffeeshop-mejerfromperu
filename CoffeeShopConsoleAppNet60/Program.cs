// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");



Latte latte = new Latte();


double pris = latte.Price();
Console.WriteLine(pris);


Cortado cortado = new Cortado();

Console.WriteLine(cortado.Price());