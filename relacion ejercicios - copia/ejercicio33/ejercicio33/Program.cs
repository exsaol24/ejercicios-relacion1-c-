﻿namespace Ejercicio33
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