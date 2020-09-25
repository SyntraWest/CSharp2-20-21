using Rosetta.Interface;
using System;

namespace RosettaTabelLibrary
{
    internal class TermCombinatie : ITermCombinatie
    {
        private RosettaTabel rosettaTabel;

        public TermCombinatie(RosettaTabel rosettaTabel, int index)
        {
            this.rosettaTabel = rosettaTabel;
            Index = index;
        }

        public ITerm this[int index] => this[rosettaTabel.Talen[index]];

        public ITerm this[ITaal taal]
        {
            get
            {
                if (taal is TabelTaal t)
                {
                    return new TabelTerm(t, this);
                }
                throw new InvalidOperationException();
            }
        }

        public int Index { get; }
    }
}