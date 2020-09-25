using Rosetta.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RosettaTabelLibrary
{
    internal class TabelTaal : ITaal
    {
        public TabelTaal(int index, string taal)
        {
            termen = new List<string>();
            Index = index;
            Taal = taal;
        }

        internal readonly List<string> termen;

        public int Index { get; }

        public string Taal { get; }

        public int AantalTermen => termen.Count;

        public int MaximumTermLengte() => termen.Max(t => t.Length);

        public int MinimumTermLengte() => termen.Min(t => t.Length);

        internal void WisselTermen(int index1, int index2)
        {
            string wacht = termen[index1];
            termen[index2] = termen[index1];
            termen[index1] = wacht;
        }
    }
}