﻿namespace ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";

            static void Main(string[] args)
            {
                Console.WriteLine("Introduce tu DNI sin la letra");

                int dni = int.Parse(Console.ReadLine());
                char letra = LETTERS[dni % LETTERS.Length];

                Console.WriteLine("Tu dni es {0}{1}", dni, letra);
            }
        }
    }
}