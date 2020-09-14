using System;
using System.IO;
using System.Runtime.InteropServices;

namespace VoorbeeldLezenSchrijvenBestanden
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();

            // Lees een bestand dat deel uitmaakt van het project
            // Properties > Copy to Output Directory > Copy Always
            prog.LeesBestand("jupla.txt");


        }

        void LeesBestand(string bestandsnaam)
        {
            // een tekstbestand volledig inlezen in een string
            try
            {
                string text = File.ReadAllText(bestandsnaam);
                Console.WriteLine(bestandsnaam);
                Console.WriteLine("".PadRight(bestandsnaam.Length,'-'));
                Console.WriteLine(text);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
        }


    }
}
