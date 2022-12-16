// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.SetCursorPosition(15, 2);
Console.WriteLine("Mi reloj digital");
int hours, minutes, seconds;
DateTime now = DateTime.Now;
while (true)
{
    for (hours = now.Hour; hours < 24; hours++)
    {
        for (minutes = now.Minute; minutes < 60; minutes++)
        {
            for (seconds = now.Second; seconds < 60; seconds++)
            {

                Console.SetCursorPosition(20, 10);
                Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
                Thread.Sleep(1000);
            }
        }
    }
    hours++;
    if (hours == 24) hours = 0;
}