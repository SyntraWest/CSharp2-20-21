using Rosetta.Interface;
using Rosetta.Interface.IO;
using System.IO;

namespace Rosetta.IO
{
    internal class ExcelOutput : IRosettaOutput
    {
        public void Schrijf(IRosettaTabel rosettaTabel, Stream output)
        {
            throw new System.NotImplementedException();
        }

        public void Schrijf(IRosettaTabel rosettaTabel, string bestandsnaam)
        {
            throw new System.NotImplementedException();
        }

        public void Schrijf(IRosettaTabel rosettaTabel, FileInfo bestand)
        {
            throw new System.NotImplementedException();
        }
    }
}