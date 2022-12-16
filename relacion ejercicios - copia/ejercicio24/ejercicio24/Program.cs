// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

namespace Ejercicio22
{
    class Program
    {
        enum Radio { Inactivo, Reproduciendo,Pausado,Parado,Cerrado }
        static Radio radio = Radio.Inactivo;

        static void Main()
        {
            do
            {
                Console.WriteLine("Escribe p, s o q");
                string state = Convert.ToString(Console.ReadLine());
                state = state.ToLower();
                try
                {
                    if (state == "p" || state == "s" || state == "q")
                    {
                       
                        if (radio == Radio.Inactivo)
                            {
                            try
                            {
                                if (state == "q")
                                {
                                    radio = Radio.Cerrado;
                                    Console.WriteLine("Ahora esta cerrado");
                                }
                                else if (state == "p")
                                {
                                    radio = Radio.Reproduciendo;
                                    Console.WriteLine("Ahora se esta reproduciendo");
                                    Console.WriteLine("Puedes introducir p , s o q");
                                }
                                else
                                {

                                    throw new Exception();
                                }
                            }
                        catch (Exception)
                {
                    Console.WriteLine("Debes de escribir la letra p o q");
                }
            }



                         else if (radio == Radio.Reproduciendo)
                        {
                            if (state == "q")
                            {
                                radio = Radio.Cerrado;
                                Console.WriteLine("Ahora esta Cerrado");
                            }
                            else if (state == "p")
                            {
                                radio = Radio.Pausado;
                                Console.WriteLine("Ahora se esta Pausado");
                                Console.WriteLine("Puedes introducir p , s o q");
                            }

                            else
                            {
                                radio = Radio.Parado;
                                Console.WriteLine("se para la radio");
                                Console.WriteLine("Puedes introducir  q");
                            }
                        }
                        else if (radio == Radio.Pausado)
                        {
                            if (state == "q")
                            {
                                radio = Radio.Cerrado;
                                Console.WriteLine("Ahora esta Cerrado");
                            }
                            else if (state == "p")
                            {
                                radio = Radio.Reproduciendo;
                                Console.WriteLine("Ahora se esta reproduciendo");
                                Console.WriteLine("Puedes introducir p , s o q");
                            }

                            else
                            {
                                radio = Radio.Parado;
                                Console.WriteLine("Ahora esta parado");
                            }
                        }
                        else if (radio == Radio.Parado)
                        {
                            try {
                                if (state == "q")
                                {
                                    radio = Radio.Cerrado;
                                    Console.WriteLine("Ahora esta Cerrado");
                                }
                                
                                
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Solo puedes introducir la q");
                            }

                        }
                
                    
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                
                catch(Exception)
                {
                    Console.WriteLine("Debes de escribir la letra p,s,l o q");
                }

            } while (radio != Radio.Cerrado);
        }
    }
}
