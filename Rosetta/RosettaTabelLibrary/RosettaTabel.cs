using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rosetta.Interface;

namespace RosettaTabelLibrary
{
    /// <summary>
    /// Implementatie van een <see cref="IRosettaTabel"/>
    /// </summary>
    public class RosettaTabel : IRosettaTabel
    {

        private List<TabelTaal> talen;

        public ITermCombinatie this[int index] => new TermCombinatie(this, index);

        public IReadOnlyList<ITaal> Talen => talen.AsReadOnly();

        public IEnumerator<ITermCombinatie> GetEnumerator()
        {
            for (int i = 0; i < talen[0].AantalTermen; i++)
                yield return new TermCombinatie(this, i);
        }

        public IRosettaTabel MetEnkelDezeTermcombinaties(params int[] combinaties)
        {
            throw new NotImplementedException();
        }

        public IRosettaTabel MetWillekeurigeCombinaties(int aantal)
        {
            throw new NotImplementedException();
        }

        public void SchudDoorElkaar()
        {
            throw new NotImplementedException();
        }

        public void SorteerOpTaal(ITaal taal, bool oplopend)
        {
            throw new NotImplementedException();
        }

        public void SorteerOpTaal(ITaal taal)
        {
            throw new NotImplementedException();
        }

        public ITaal VoegTaalToe(string taal)
        {
            if (talen.Count != 0 && talen[0].AantalTermen != 0)
                throw new InvalidOperationException();

            var nieuweTaal = new TabelTaal(talen.Count, taal);
            talen.Add(nieuweTaal);
            return nieuweTaal;
        }

        public void WisselTalen(int index1, int index2)
        {
            var tmp = talen[index1];
            talen[index1] = talen[index2];
            talen[index2] = tmp;
        }

        public void WisselTermen(int index1, int index2)
        {
            foreach(var taal in talen)
            {
                taal.WisselTermen(index1, index2);
            }
        }

        public IRosettaTabel ZonderTaal(ITaal taal)
        {
            var tbl = new RosettaTabel();
            tbl.talen = talen.Where(t => t!= taal).ToList();
            return tbl;
        }

        public IRosettaTabel ZonderTaal(int taal)
        {
            var tbl = new RosettaTabel();
            tbl.talen = talen.Where((t,i) => i != taal).ToList();
            return tbl;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
