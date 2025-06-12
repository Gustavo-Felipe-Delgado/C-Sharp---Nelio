
using pr;
using System.Globalization;

Triangulo t1 = new Triangulo();
Triangulo t2 = new Triangulo();

Console.WriteLine("Insira os valores dos lados do triãngulo 1:");
t1.l1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
t1.l2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
t1.l3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Insira os valores dos lados do triãngulo 2:");
t2.l1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
t2.l2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
t2.l3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(t1.area() > t2.area())
{
    Console.WriteLine("t1 é maior que t2");
} else {
    Console.WriteLine("t2 é maior que t1.");
}