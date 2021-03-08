using System;
using System.Collections.Generic;
using System.Text;

namespace JsonConsoleApp
{
    public class Voorbeeld
    {
        public int Getal { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public bool WaarOfNietWaar { get; set; }
        public double NogEenGetal { get; set; }

        public override string ToString()
        {
            return $@"Getal: {Getal}, Tekst: {Tekst}, Datum: {Datum}, {(WaarOfNietWaar? "waar": "niet waar")}, {NogEenGetal}";
        }
    }
}
