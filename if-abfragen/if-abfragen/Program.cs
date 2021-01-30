using System;
using System.Net.NetworkInformation;

namespace if_abfragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Namen ein!");
            string Anwender = Console.ReadLine ();

            if (Anwender == "Peter" | Anwender == "peter")
            {
                Console.WriteLine("Herzlich Willkommen Peter!");
                Console.WriteLine("Bitte geben Sie Ihren Pin ein!");
                int pin = int.Parse(Console.ReadLine());

                if (pin == 9988)
                {
                    Console.WriteLine("Sie sind berechtigt das Programm zu verwenden!");
                }
                else
                {
                    Console.WriteLine("Sie sind nicht berechtigt das Programm zu verewenden!");
                }

            }
            else if (Anwender == "Alexander" | Anwender == "alexander")
            {
                Console.WriteLine("Herzlich Willkommen Alexander!");
                Console.WriteLine("Bitte geben Sie Ihren Pin ein!");
                int pin = int.Parse(Console.ReadLine());

                if (pin == 4455)
                {
                    Console.WriteLine("Sie sind berechtigt das Programm zu verwenden!");
                }
                else
                {
                    Console.WriteLine("Sie sind nicht berechtigt das Programm zu verewenden!");
                }
            }
            else if (Anwender == "Sabine" | Anwender == "sabine")
            {
                Console.WriteLine("Herzlich Willkommen Sabine!");
                Console.WriteLine("Bitte geben Sie Ihren Pin ein!");
                int pin = int.Parse(Console.ReadLine());

                if (pin == 1457)
                {
                    Console.WriteLine("Sie sind berechtigt das Programm zu verwenden!");
                }
                else
                {
                    Console.WriteLine("Sie sind nicht berechtigt das Programm zu verewenden!");
                }
            }
            else
            {
                Console.WriteLine("Sie sind nicht berechtigt das Programm zu verewenden!");
            }
            
        }
    }
}
