// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduzca un numero entero");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= i / 2 && isPrime; j++)
    {
        if (i % j == 0) isPrime = false;
            
    }
if (isPrime) Console.WriteLine(i);
}
Console.ReadLine();
