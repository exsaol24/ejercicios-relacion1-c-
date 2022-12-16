namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce los numeros enteros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = Fibonacci(a) + Fibonacci(b);
            Console.WriteLine(result);
        }
        static int Fibonacci(int x)
        {
            int result;
            if (x <= 1)
                result = x;
            else
                result = Fibonacci(x - 1) + Fibonacci(x - 2);
            return result;


        }
    }
}