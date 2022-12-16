namespace ejercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int suma = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            for(int i = 0; i< numbers.Length; i++)
            {

                suma += numbers[i];
            }
            Console.WriteLine($"Media: {suma / numbers.Length}");
        }
    }
}