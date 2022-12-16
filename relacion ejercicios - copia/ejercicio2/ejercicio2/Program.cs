// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduce un número");
int number1Text = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce otro número");
int number2Text = int.Parse(Console.ReadLine());

int number1 = number1Text;

int number2 = number2Text;


int result = number1 + number2;
Console.Write("Resultado: "); Console.WriteLine(result);
