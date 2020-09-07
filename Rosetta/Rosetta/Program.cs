using System;
using System.Collections.Generic;

namespace Rosetta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke talen wil je gebruiken op je Rosetta-tabel?");

            List<string> talen = new List<string>();
            Console.WriteLine("Geef een taal in of STOP om te stoppen");
            string taal = Console.ReadLine();
            while (taal.ToLower().Trim() != "stop")
            {
                if (!string.IsNullOrWhiteSpace(taal))
                    talen.Add(taal);
                Console.WriteLine("Geef een taal in of STOP om te stoppen");
                taal = Console.ReadLine();
            }

            // Geef hier de woorden per taal in

            Console.WriteLine(string.Join('\t', talen));
        }
    }
}
