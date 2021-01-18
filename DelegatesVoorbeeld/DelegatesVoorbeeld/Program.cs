using System;

namespace DelegatesVoorbeeld
{

    // zichtbaarheid is standaard internal
    delegate void DoeIets();

    // parameters zijn mogelijk
    delegate void DoeIets2(string alpha, int beta, DateTime gamma);

    // return types zijn mogelijk
    delegate string GeefStringTerug();


    class DelegateVoorbeeld
    {

        internal void GebruikDelegate()
        {
            // Een instantie van een delegate kan gedeclareerd worden
            DoeIets doeIets = null;

            if (doeIets == null)
            {
                Console.WriteLine("doeIets is null");
            }

        }

        internal void GebruikDelegateGeefStringTerug()
        {
            // var geefStringTerug = new GeefStringTerug(GeefStringTerugInDelegateVoorbeeld2); // niet OK: de methode die gebruikt wordt moet overeenkomen met de definitie van de delegate


            // het maken van een instantie van een delegate gebeurt meestal op een andere plaats dan waar de delegate wordt uitgevoerd.
            var geefStringTerug = new GeefStringTerug(GeefStringTerugInDelegateVoorbeeld);

            if (geefStringTerug == null)
                Console.WriteLine("geefStringTerug is null");
            else
            {
                string output = geefStringTerug(); // lijkt op uitvoeren van een methode, maar de instantie van de delegate wordt uitgevoerd.
                Console.WriteLine(output);
            }

        }

        internal void GebruikDelegateAlsParameter(string param1, DoeIets doeIets, DoeIets2 doeIets2, GeefStringTerug geefStringTerug)
        {
            Random rand = new Random();

            Console.WriteLine(param1);

            if (doeIets != null)
                doeIets();

            doeIets2?.Invoke(param1, rand.Next(1000, 2000), DateTime.Now);

            // eerste manier: ook Console.WriteLine niet uitvoeren als geefStringTerug null is
            if (geefStringTerug != null)
                Console.WriteLine(geefStringTerug.Invoke());

            // tweede manier: Console.WriteLine wordt uitgevoerd, ook als geefStringTerug null is
            Console.WriteLine(geefStringTerug?.Invoke());
        }

        private string GeefStringTerugInDelegateVoorbeeld()
        {
            return "deze string komt uit " + nameof(GeefStringTerugInDelegateVoorbeeld);
        }

        private string GeefStringTerugInDelegateVoorbeeld2(string parameter1)
        {
            return "deze string komt uit " + nameof(GeefStringTerugInDelegateVoorbeeld);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //new DelegateVoorbeeld().GebruikDelegate();

            //new DelegateVoorbeeld().GebruikDelegateGeefStringTerug();

            //new DelegateVoorbeeld().GebruikDelegateAlsParameter(null, null, null, null);

            // eerste manier om actie toe te kennen aan een delegate
            // met de constructor van de delegate
            DoeIets doeIets = new DoeIets(Methode1);
            
            // tweede manier om actie toe te kennen aan een delegate
            // direct een methode toekennen aan een delegate
            DoeIets2 doeIets2 = Methode2;

            // derde manier
            GeefStringTerug geefStringTerug = null;
            geefStringTerug += new GeefStringTerug(Methode4);
            geefStringTerug += Methode3;


            new DelegateVoorbeeld().GebruikDelegateAlsParameter("parameter 1", doeIets, doeIets2, geefStringTerug);

            Console.ReadKey();
        }


        static void Methode1()
        {
            Console.WriteLine("Methode 1 uitgevoerd");
        }

        static void Methode2(string s2, int i2, DateTime dt2)
        {
            Console.WriteLine($"Methode 2 opgeroepen met parameters {s2}, {i2} en {dt2}");
        }

        static string Methode3()
        {
            return "Methode 3 uitgevoerd";
        }

        static string Methode4()
        {
            return "Methode 4 uitgevoerd";
        }

    }
}
