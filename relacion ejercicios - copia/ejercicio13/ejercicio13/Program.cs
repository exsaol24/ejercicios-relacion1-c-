// See https://aka.ms/new-console-template for more information
Console.WriteLine("Intrduce un numero");
int number = int.Parse(Console.ReadLine());
Random random = new Random();
bool match = false;

for (int i = 0; i < 5; i++)
{
    int radomNumber = random.Next(1,number + 1);
    Console.WriteLine(radomNumber);
    if (radomNumber == number && !match)
    {
        Console.WriteLine("Coincide");
        match = true;
    }
}