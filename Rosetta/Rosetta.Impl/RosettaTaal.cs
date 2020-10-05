using Rosetta.Interface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Rosetta.Impl
{
    internal class RosettaTaal : ITaal
    {

        internal readonly List<ITerm> termen;

        public RosettaTaal(string taal, int index)
        {
            Index = index;
            Taal = taal;
            termen = new List<ITerm>();
        }

        public int Index { get; } // read-only property
        // Een readonly property is een property met enkel
        // een getter, zonder setter (ook zonder private setter)

        public int AantalTermen => termen.Count;

        public string Taal { get; }

        public int MaximumTermLengte()
        {
            int maxLengte = 0;
            foreach (var term in termen)
            {
                int len = term.Term.Length;
                if(len > maxLengte)
                {
                    maxLengte = len;
                }
            }
            return maxLengte;

            // Voorbeeldje voor een beetje later:
            // met Linq kan je dit veel korter noteren
            // return termen.Max(t => t.Term.Length);
        }

        internal void VoegTermToe(string term, )
        {
            termen.Add(new RosettaTerm(this, term));
        }

        public int MinimumTermLengte()
        {
            int minLengte = int.MaxValue;
            // rest is oefening.
            throw new NotImplementedException();
        }
    }
}