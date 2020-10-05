using Rosetta.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Rosetta.Impl
{
    public class RosettaTabel : IRosettaTabel
    {

        private readonly List<RosettaTaal> talen;
        private readonly List<ITermCombinatie> termcombinaties;

        public RosettaTabel()
        {
            talen = new List<RosettaTaal>();
            termcombinaties = new List<ITermCombinatie>();
        }

        #region niet in interface

        public void VoegTermenToe(string[] termen)
        {
            if(termen.Length != talen.Count)
                throw new ArgumentException("Er zijn niet even veel termen als talen");

            for (int i = 0; i < talen.Count; i++)
            {
                talen[i].VoegTermToe(termen[i]);
            }
        }

        #endregion niet in interface

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
