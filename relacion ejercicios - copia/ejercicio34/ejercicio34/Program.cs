namespace Ejercicio33
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce números separados por coma");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(",");

            foreach (string numero in numerosDivididos)
            {
                int number = int.Parse(numero);

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number}");
                }
            }
        }
    }
}
namespace Ejercicio34
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce números separados por coma");

            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(",");

            int[] numerosVerdad = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosVerdad.Length; i++)
            {
                numerosVerdad[i] = int.Parse(numerosDivididos[i]);
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int numero in numerosVerdad)
            {
                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }
            }
            Console.WriteLine($"El número más pequeño es: {min}");
            Console.WriteLine($"El número más grande es: {max}");
        }
    }
}