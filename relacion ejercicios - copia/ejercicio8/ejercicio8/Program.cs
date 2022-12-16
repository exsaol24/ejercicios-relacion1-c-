// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce un número entero de 2 cifras:");

int number = int.Parse(Console.ReadLine());
int result = number % 10 * 10 + number / 10;
Console.WriteLine(result);
