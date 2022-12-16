namespace Ejercicio32
{
    class Program
    {
        const int size = 10;
        static void Main(string[] args)
        {
            int[] nums = new int[size];
            CrearArray(nums);

            Mostrar(nums);
        }
        static void CrearArray(int[] nums)
        {
            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
        }
        static int[] CrearArray()
        {
            int[] nums = new int[size];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            return nums;
        }
        static void Mostrar(int[] nums)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i} => {nums[i]}");
            }
        }
    }
}