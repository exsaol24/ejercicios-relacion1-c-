using System.Globalization;

namespace ejercicio28
{
    internal class Program
    {
        enum Option {Circle,Triangle,Square};
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Elige una opcion():");
            Console.WriteLine("Circle,Triangle,Square");
            Option option = (Option)Enum.Parse(typeof(Option),Console.ReadLine(),true);
            double area = 0;
            switch(option)
            {
                case Option.Circle:
                    area = CalcularCirculo();
                    break;
                case Option.Triangle:
                    area = CalcularTriangulo();
                    break;
                case Option.Square:
                    area = CalcularCuadrado();
                    break;
            }
            Console.WriteLine($"El area es {area}");
            static double CalcularCirculo()
            {
                double result;
                Console.WriteLine("Introduce el radio del circulo");
                double radio = double.Parse(Console.ReadLine());
                return Math.PI * Math.Pow(radio, 2);
            }
            static double CalcularTriangulo()
            {
                double result;
                Console.WriteLine("Introduce la base del triangulo");
                double @base = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la base del triangulo");
                double altura = double.Parse(Console.ReadLine());
                return @base * altura / 2;
            }
            static double CalcularCuadrado()
            {
                
                Console.WriteLine("Introduce la base del cuadrado");
                double lado = double.Parse(Console.ReadLine());
                
                return lado * lado;
            }

        }
    }
}