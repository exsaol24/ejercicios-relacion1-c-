namespace ejercicio37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cantidad de numeros");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = CreateArray(size);
            Console.WriteLine($"{string.Join(",",numbers)}");
        }
        static int[] CreateArray(int size)
        {
            int[] result = new int[size]; 
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                int number;
                do
                {
                    number = random.Next(20);
                }
                while (Contains(result,number));
                     result[i] = number;   
            }
            return result;
        }
        
        static bool Contains(int[] array, int item)
        {
            bool found = false;

            for(int i = 0; i < array.Length && !found; i++)
            {
                int num = array[i];

                if(num == item) found = true;
            }
            return found;
            

        }
    }
}