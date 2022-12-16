namespace Ejercicio20
{
    class Program
    {
      
       
        
        enum Months
        {
            January=1,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July,        // 6
            Agost,
            September,
            October,
            November,
            December,


        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce una cantidad de numeros");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad <= 12 && cantidad >= 1)
            {
                Months February = (Months)cantidad;
                Console.WriteLine(February);
            
                    
                    }
            else
                Console.WriteLine("Error introduzca los numeros dentro del rango");
        }
    }
   }
