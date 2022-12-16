using System.Reflection.Metadata.Ecma335;

namespace ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = sumatorio(n);
            Console.WriteLine(result);
        }
        static int sumatorio(int x)
        {
            int result = 0;
            for(int i = 1; i <= x;i++)
            {
                result += Factorial(i) + i;
            }
            return result;
        }
        
     static int Factorial(int x)
        {
            int result;
            if (x == 0) result = 1;
            else result = x * Factorial(x - 1);
            return result;
        }
        
    }
}