// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Introduce una cantidad de numeros");
int cantidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Introduce {cantidad} de numeros");
double num;
double media;
double cuad = 0;

for (int i = 0; i < cantidad; i++)
    
{
    num = Convert.ToDouble(Console.ReadLine());
    cuad += Math.Pow(num, 2);
}

media = Math.Sqrt(cuad/cantidad);
Console.WriteLine($"la media cuadratica es{media}");
