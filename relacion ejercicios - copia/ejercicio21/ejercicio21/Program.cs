// See https://aka.ms/new-console-template for more information
namespace Ejercicio21
{


    class Program
    {
        enum Dias
        {
            LUNES = 1,
            MARTES,
            MIERCOLES,
            JUEVES,
            VIERNES,
            SABADO,
            DOMINGO,
           
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Introduce un dia de la semana");
            
            Dias day = (Dias)Enum.Parse(typeof(Dias), Console.ReadLine(), true);

            int dinau = (int)day;
            if(dinau <=5 )
            {
                Console.WriteLine("Son dias Laborales");
            }
            // Console.WriteLine(valor);
            //  Dias myVar = Dias.Lunes;
            // Console.WriteLine(myVar);
           
            else
            {
                Console.WriteLine("No laboral");
            }

        }
    }
}
    
