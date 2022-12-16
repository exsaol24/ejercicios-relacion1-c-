// See https://aka.ms/new-console-template for more information
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;

Console.WriteLine("El número {0} es {1}", number, isEven ? "par" : "impar");

