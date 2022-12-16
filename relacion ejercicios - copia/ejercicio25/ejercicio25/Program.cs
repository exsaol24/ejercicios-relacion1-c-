namespace ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Introduce dos numeros");
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
           
        }
        static int Factorial(int x)
        {
            int result;
            if (x == 0) result = 1;

            else result = x * Factorial(x -1);
           return result;
        }
    }
}