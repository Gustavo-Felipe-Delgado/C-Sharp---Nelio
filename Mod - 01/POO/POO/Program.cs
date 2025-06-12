
using System.Globalization;

double N1;
double S1;
string AS;

AS = "";

while (AS != "N")
{
    Console.Write("Insira um valor: ");
    N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    S1 = Math.Sqrt(N1);

    Console.WriteLine("A raiz quadrado do valor indicado é: " + S1.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Gostaria de continuar? (Insira 'N' para não): ");
    AS = Console.ReadLine();
        
}

Console.WriteLine("Agradecemos a preferência!");