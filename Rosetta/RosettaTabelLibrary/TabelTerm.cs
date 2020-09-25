using Rosetta.Interface;

namespace RosettaTabelLibrary
{
    internal class TabelTerm : ITerm
    {
        private readonly TabelTaal taal;

        public TabelTerm(TabelTaal taal, TermCombinatie combo)
        {
            this.taal = taal;
            Combinatie = combo;
        }

        public ITaal Taal => taal;

        public ITermCombinatie Combinatie { get; }

        public string Term
        {
            get => taal.termen[Combinatie.Index];
            set => taal.termen[Combinatie.Index] = value;
        }
    }
}