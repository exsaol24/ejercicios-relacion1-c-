// See https://aka.ms/new-console-template for more information

try
{
    Console.Write("Ingrese un valor:");
    string linea = Console.ReadLine();
    string linea2 = Console.ReadLine();
    int num = int.Parse(linea);
    int num2 = int.Parse(linea2);
    int division = num / num2;
    Console.WriteLine($"EL resultado es {division}");
}
catch (FormatException e)
{
    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
    Console.WriteLine("Ingrese un valor:");
    string linea3 = Console.ReadLine();
    string linea4 = Console.ReadLine();
    int num1 = int.Parse(linea3);
    int num3 = int.Parse(linea4);
    int division1 = num1 / num3;
    Console.WriteLine($"EL resultado es {division1}");
}
Console.ReadKey();
        
