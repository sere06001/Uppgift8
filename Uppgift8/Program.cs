using System;
using System.Collections.Generic;
namespace uppgift8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många koder vill du skriva in?");
            int antalKoder = int.Parse(Console.ReadLine());
            Dictionary<string, string> koder = new Dictionary<string, string>();

            for (int i = 0; i < antalKoder; i++)
            {
                string[] kod = Console.ReadLine().Split();
                koder[kod[0]] = kod[1];
            }

            Console.Write("Skriv in ditt hemliga meddelande: ");
            string hemligt = Console.ReadLine();

            Console.Write("Här är ditt avkodade meddelande: ");
            for (int i = 0; i < hemligt.Length; i++)
            {
                string tecken = hemligt[i].ToString();

                while (koder.ContainsKey(tecken))
                {
                    tecken = koder[tecken];
                }
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
}