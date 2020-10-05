using Rosetta.Interface;

namespace Rosetta.Impl
{
    internal class RosettaTerm : ITerm
    {

        public RosettaTerm(RosettaTaal taal, RosettaTermCombinatie combo, string term)
        {
            Taal = taal;
            Term = term;
            Combinatie = combo;
        }

        public ITaal Taal { get; }

        public ITermCombinatie Combinatie { get; }

        public string Term { get; set; }
    }
}