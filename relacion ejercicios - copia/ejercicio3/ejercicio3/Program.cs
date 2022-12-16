// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduce la temperatura en ºF");
int fahrenheitText = int.Parse(Console.ReadLine());

int fahrenheit = fahrenheitText;

int celsius = (fahrenheit - 32) / 9 * 5;

Console.Write("Temperatura en ºC: "); Console.WriteLine(celsius);
