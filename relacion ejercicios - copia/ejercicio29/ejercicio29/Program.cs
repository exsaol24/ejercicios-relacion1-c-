using System.Globalization;

namespace ejercicio29
{
    internal class Program
    {
        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLA = 1.28611;
        const double EURO_A_YEN = 129.852;
        enum Moneda { Libra,Dolar,Yen};
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Elige una opcion libra,dolar,yen");
            string moneda = (Console.ReadLine());
            Console.WriteLine("introduce la cantidad de euros");
            double euros = double.Parse(Console.ReadLine());
            Convertir(euros,moneda);
            
        }
        static void Convertir(double euros,string moneda)
        {
            
            object currency;
            if (Enum.TryParse(typeof(Moneda), moneda, true, out currency))
            {
                double result;
                switch((Moneda)currency)
                {
                    case Moneda.Libra:
                        result = euros * EURO_A_LIBRA;
                        break;
                    case Moneda.Dolar:
                        result = euros * EURO_A_DOLA;
                        break;
                    case Moneda.Yen:
                        result = euros * EURO_A_YEN;
                        break;
                        Console.WriteLine($"{currency}");
                }
            }
            
        }
    }
}