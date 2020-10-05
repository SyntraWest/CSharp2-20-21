using Rosetta.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Rosetta.Impl
{
    public class RosettaTabel : IRosettaTabel
    {

        private readonly List<ITaal> talen;
        private readonly List<ITermCombinatie> termcombinaties;

        public RosettaTabel()
        {
            talen = new List<ITaal>();
            termcombinaties = new List<ITermCombinatie>();
        }

        public ITermCombinatie this[int index] => termcombinaties[index];

        public IReadOnlyList<ITaal> Talen => talen.AsReadOnly();

        public IEnumerator<ITermCombinatie> GetEnumerator()
        {
            return termcombinaties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return termcombinaties.GetEnumerator();
        }

        public ITaal VoegTaalToe(string taal)
        {
            var taalObject = new RosettaTaal(taal, talen.Count);
            talen.Add(taalObject);
            return taalObject;
        }


        #region voorlopig niet geïmplementeerd
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

        public void WisselTalen(int index1, int index2)
        {
            throw new NotImplementedException();
        }

        public void WisselTermen(int index1, int index2)
        {
            throw new NotImplementedException();
        }

        public IRosettaTabel ZonderTaal(ITaal taal)
        {
            throw new NotImplementedException();
        }

        public IRosettaTabel ZonderTaal(int taal)
        {
            throw new NotImplementedException();
        }

        #endregion voorlopig niet geïmplementeerd
    }
}
