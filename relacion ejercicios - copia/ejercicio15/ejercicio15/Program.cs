// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduce una cantidad de numeros:");
int size = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 0; i < size; i++)
{
    sum += double.Parse(Console.ReadLine());
}

double average = sum / size;
Console.WriteLine($"la media es la {average}");