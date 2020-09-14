using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace VoorbeeldLezenSchrijvenBestanden
{
    class Program
    {
        static void Main001(string[] args)
        {
            var prog = new Program();

            // Lees een bestand dat deel uitmaakt van het project
            // Properties > Copy to Output Directory > Copy Always
            prog.LeesBestand("jupla.txt");

            if (File.Exists("alpha.txt"))
                File.Delete("alpha.txt");

            // Tekstbestand schrijven in 1 keer
            // en dan het bestand openen
            prog.SchrijfBestand("alpha.txt");

        }

        static void Main(string[] args)
        {
            var prog = new Program();

            // Lees telkens een lijn van console en schrijf die naar
            // een bestand
            //prog.LeesVanConsoleEnSchrijfNaarBestand("beta.txt");
            //prog.LeesVanConsoleEnSchrijfNaarBestandMetUsing("beta.txt");

            prog.LeesVanConsoleEnSchrijfNaar(Console.Out);
            // Probeer hetzelfde met schrijven naar een StreamWriter

            // Voorbeeld argumenten meegeven via de command line
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        private void LeesVanConsoleEnSchrijfNaarBestand(string bestandsnaam)
        {
            Stream outputStream = null;
            TextWriter writer = null;

            try
            {
                outputStream = new FileStream(bestandsnaam, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(outputStream);

                string lijn = Console.ReadLine();
                while (!string.IsNullOrEmpty(lijn))
                {
                    // schrijf lijn naar bestand.
                    writer.WriteLine(lijn);
                    lijn = Console.ReadLine();
                }

            }
            catch (IOException e)
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
                if (outputStream != null)
                    outputStream.Dispose();
            }

        }


        private void LeesVanConsoleEnSchrijfNaarBestandMetUsing(string bestandsnaam)
        {
            try
            {
                using (Stream outputStream = new FileStream(bestandsnaam, FileMode.OpenOrCreate, FileAccess.Write))
                using (TextWriter writer = new StreamWriter(outputStream))
                {

                    string lijn = Console.ReadLine();
                    while (!string.IsNullOrEmpty(lijn))
                    {
                        // schrijf lijn naar bestand.
                        writer.WriteLine(lijn);
                        lijn = Console.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {

            }
            catch (Exception e)
            {

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer">Een TextWriter om naar te schrijven</param>
        private void LeesVanConsoleEnSchrijfNaar(TextWriter writer)
        {
            string lijn = Console.ReadLine();
            while (!string.IsNullOrEmpty(lijn))
            {
                // schrijf lijn naar bestand.
                writer.WriteLine(lijn);
                lijn = Console.ReadLine();
            }
        }

        private void LeesVanConsoleEnSchrijfNaarBestandMetUsing2(string bestandsnaam)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(bestandsnaam))
                {

                    string lijn = Console.ReadLine();
                    while (!string.IsNullOrEmpty(lijn))
                    {
                        // schrijf lijn naar bestand.
                        writer.WriteLine(lijn);
                        lijn = Console.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {

            }
            catch (Exception e)
            {

            }

        }


        private void SchrijfBestand(string bestandsnaam)
        {
            // Volgende lijn (in commentaa) zorgt dat het bestand in gebruik is.
            // var stream = new FileStream(bestandsnaam, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);


            string inhoud = string.Join("\n", Enumerable.Repeat("Dit is een lijn tekst.", 10000));
            string groteInhoud = string.Join("\n", Enumerable.Repeat(inhoud, 500));
            File.WriteAllText(bestandsnaam, groteInhoud);

            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = bestandsnaam
            });
        }

        void LeesBestand(string bestandsnaam)
        {
            // een tekstbestand volledig inlezen in een string
            try
            {
                string text = File.ReadAllText(bestandsnaam);
                Console.WriteLine(bestandsnaam);
                Console.WriteLine("".PadRight(bestandsnaam.Length, '-'));
                Console.WriteLine(text);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
        }


    }
}
