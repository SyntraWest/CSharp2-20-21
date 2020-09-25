using Rosetta.Interface;
using Rosetta.Interface.IO;
using System.IO;

namespace Rosetta.IO
{
    internal class ExcelInput : IRosettaInput
    {
        public IRosettaTabel Lees(Stream input)
        {
            throw new System.NotImplementedException();
        }

        public IRosettaTabel Lees(string bestandsnaam)
        {
            throw new System.NotImplementedException();
        }

        public IRosettaTabel Lees(FileInfo bestand)
        {
            throw new System.NotImplementedException();
        }
    }
}