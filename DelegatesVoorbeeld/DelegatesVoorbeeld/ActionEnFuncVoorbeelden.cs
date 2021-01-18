using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesVoorbeeld
{
    class ActionEnFuncVoorbeelden
    {

        void Voorbeeld1()
        {

            // op deze manier wordt een Action eigenlijk nooit gebruikt
            //Action a = new Action(Voorbeeld1);

            // Wel: met lambda-uitdrukking (lambda expression)
            Action a = () => Console.WriteLine("a");

            a();

            // Een Action heeft nooit een returnwaarde, altijd void

            // parameters kunnen wel:
            Action<string> b = s => Console.WriteLine(s);

            b = Console.WriteLine;



            // Als je een returnwaarde nodig hebt: Func
            // Func heeft altijd een returnwaarde

            //Func c; // is fout, want Func heeft altijd een typeargument nodig

            Func<string> c = () => "dit is de returnwaarde van de Func<string> c";


            string x = c();


            // We hebben gezien:
            // Action en Func zijn delegates
            // Action: altijd void, Func: altijd returntype
            // Action|Func zonder parameters: () => ...;
            // Action met 1 parameter: x => ...;

            // Func met 1 parameter
            // voorbeeld: parameter van type int en returntype string
            Func<int, string> d = i => i.ToString();

            // Action met 2 of meer parameters
            // haakjes zijn nodig in de lambda-uitdrukking
            Action<int, string> e = (i, s) => Console.WriteLine($"{s} {i}");

            // Func met 2 of meer parameters
            Func<int, string, string> f = (i, s) => $"{s} {i}";

            // Action met meerdere instructies om uit te voeren
            Action g = () => {
                Console.WriteLine("eerste instructie");
                Console.WriteLine("tweede instructie");
            };
            
            // Func met meerdere instructies om uit te voeren
            Func<string> h = () =>
            {
                // meerdere instructies...
                return "";
            };



            // capturen van variabelen
            string alpha = "alpha";

            Action beta = () => Console.WriteLine(alpha);

            // Predicate:
            Predicate<string> p = s => true;
            Func<string, bool> p2 = s => true;
            //p = p2; // kan niet
            //p2 = p; // kan niet

        }
    }
}
