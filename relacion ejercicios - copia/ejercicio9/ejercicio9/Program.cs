// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce tu estado:");
string input = Console.ReadLine();
char state = input[0];

string result;

switch (state)
{
    case 'C':
        result = "Casado";
        break;

    case 'S':
        result = "Soltero";
        break;

    case 'V':
        result = "Viudo";
        break;

    case 'D':
        result = "Divorciado";
        break;

    default:
        result = "Estado no existe";
        break;
}
Console.WriteLine($"Tu estado civil es: {result}");