using System;
using Rosetta.Interface.IO;
using RosettaInterface.IO;

namespace Rosetta.IO
{
    public class RosettaIoFactory : IRosettaIoFactory
    {
        public IRosettaTextInput MaakCsvInput()
        {
            return new CsvInput();
        }

        public IRosettaTextOutput MaakCsvOutput()
        {
            throw new NotImplementedException();
        }

        public IRosettaInput MaakExcelInput()
        {
            throw new NotImplementedException();
        }

        public IRosettaOutput MaakExcelOutput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextInput MaakHtmlInput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextOutput MaakHtmlOutput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextInput MaakJsonInput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextOutput MaakJsonOutput()
        {
            throw new NotImplementedException();
        }

        public IRosettaDb MaakSqliteDbToegang()
        {
            throw new NotImplementedException();
        }

        public IRosettaDb MaakSqlServerDbToegang()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextInput MaakTabDelimitedInput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextOutput MaakTabDelimitedOutput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextInput MaakXmlInput()
        {
            throw new NotImplementedException();
        }

        public IRosettaTextOutput MaakXmlOutput()
        {
            throw new NotImplementedException();
        }
    }
}
