// See https://aka.ms/new-console-template for more information
Console.WriteLine("Intrduce una semilla");
int seed = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce un numero");
int lenght = int.Parse(Console.ReadLine()); 
Random random = new Random(seed);


for (int i = 0; i < lenght; i++)
{
    int ascii = random.Next(256) ;
    Console.Write((char)ascii);
}
Console.WriteLine();


