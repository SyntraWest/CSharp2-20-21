using Rosetta.Interface;

namespace Rosetta.Impl
{
    public class RosettaTermCombinatie : ITermCombinatie
    {
        private readonly RosettaTabel tabel;

        public RosettaTermCombinatie(RosettaTabel tabel, int index)
        {
            this.tabel = tabel;
            Index = index;
        }

        public ITerm this[int index]
        {
            get
            {
                var taal = (RosettaTaal)(tabel.Talen[index]);
                return taal.termen[Index];
            }
        }

        public ITerm this[ITaal iTaal]
        {
            get
            {
                var taal = (RosettaTaal)iTaal;
                return taal.termen[Index];
            }
        }

        public int Index { get; }
    }
}