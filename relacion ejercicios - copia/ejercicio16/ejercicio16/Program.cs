// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Introduce un numero en base 10 de ");
int base10 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce la base a la que quieres pasarlo ");
int basex = int.Parse(Console.ReadLine());
int rest = 0;
string resultado = "";
string resultado2 = "";
bool exit = true;
if (basex <= 9 && basex >= 2)
{




    for (int i = base10; base10 > 0 && exit; i--)
    {


        rest = base10 % basex;
        base10 /= basex;
        resultado += rest;



    }
    for (int i = resultado.Length - 1; i >= 0; i--)
    {
        resultado2 += resultado[i];
    }
    Console.WriteLine(resultado2);

}
else
{
    Console.WriteLine("Ingrese un numero dentro del rango");

    exit = false;
}




