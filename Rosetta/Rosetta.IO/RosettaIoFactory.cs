using System;
using System.Xml;
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
            return new CsvOutput();
        }

        public IRosettaInput MaakExcelInput()
        {
            return new ExcelInput();
        }

        public IRosettaOutput MaakExcelOutput()
        {
            return new ExcelOutput();
        }

        public IRosettaTextInput MaakHtmlInput()
        {
            return new HtmlInput();
        }

        public IRosettaTextOutput MaakHtmlOutput()
        {
            return new HtmlOutput();
        }

        public IRosettaTextInput MaakJsonInput()
        {
            return new JsonInput();
        }

        public IRosettaTextOutput MaakJsonOutput()
        {
            return new JsonOutput();
        }

        public IRosettaDb MaakSqliteDbToegang()
        {
            return new SqliteDbToegang();
        }

        public IRosettaDb MaakSqlServerDbToegang()
        {
            return new SqlServerDbToegang();
        }

        public IRosettaTextInput MaakTabDelimitedInput()
        {
            return new TabDelimitedInput();
        }

        public IRosettaTextOutput MaakTabDelimitedOutput()
        {
            return new TabDelimitedOutput();
        }

        public IRosettaTextInput MaakXmlInput()
        {
            return new XmlInput();
        }

        public IRosettaTextOutput MaakXmlOutput()
        {
            return new XmlOutput();
        }
    }
}
