namespace Ejercicio22
{
    class Program
    {
        enum Lamp { OFF, ON }
        static Lamp lamp = Lamp.OFF;

        static void Main()
        {
            do
            {
                Console.WriteLine("Escribe ON o OFF para encender o apagar la luz");
                string state = Convert.ToString(Console.ReadLine());
                state = state.ToUpper();
                if (state == "ON" || state == "OFF")
                {
                    if (lamp == Lamp.OFF)
                    {
                        if (state == "ON")
                        {
                            lamp = Lamp.ON;
                            Console.WriteLine($"El estado de la lámpara {state}");
                        }
                        else if (state == "OFF")
                        {
                            Console.WriteLine($"No se puede introducir el estado OFF porque esta sin luz");
                        }
                    }
                    else if (lamp == Lamp.ON)
                    {
                        if (state == "OFF")
                        {
                            lamp = Lamp.OFF;
                            Console.WriteLine($"El estado de la lámpara: {state}");
                        }
                        else if (state == "ON")
                        {
                            Console.WriteLine($"No se puede introducir el estado ON ya esta iluminada");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Debes introducir OFF o ON");
                }
            } while (true);
        }
    }
}