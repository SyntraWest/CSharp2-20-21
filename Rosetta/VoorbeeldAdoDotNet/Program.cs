using System;

namespace VoorbeeldAdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var voorbeeld = new AdoDotNetVoorbeeld2())
            {
                // alle methodes van voorbeeld gebruikden dezelfde DbConnection
                voorbeeld.MaakTabel();

                int aantalToegevoegd = voorbeeld.InsertData();
                Console.WriteLine(aantalToegevoegd);

                voorbeeld.Albumdata();

                voorbeeld.VerwijderTabel();
            }
        }

        static void Main001(string[] args)
        {
            var voorbeeld = new AdoDotNetVoorbeeld();

            voorbeeld.MaakTabel();

            int aantalToegevoegd = voorbeeld.InsertData();
            Console.WriteLine(aantalToegevoegd);

            voorbeeld.Albumdata();



            voorbeeld.VerwijderTabel();
        }
    }
}
