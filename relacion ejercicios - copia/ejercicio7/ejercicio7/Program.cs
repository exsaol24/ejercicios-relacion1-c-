// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Triángulo equilátero");
}
else if (a != b && a != c && b != c)
{
    Console.WriteLine("Triángulo escaleno");
}
else
{
    Console.WriteLine("Triángulo isósceles");
}
