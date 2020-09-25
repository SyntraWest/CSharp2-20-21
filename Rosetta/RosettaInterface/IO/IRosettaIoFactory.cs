using RosettaInterface.IO;
using System.Collections;

namespace Rosetta.Interface.IO
{

    #region input/output

    public interface IRosettaIoFactory
    {
        IRosettaTextInput MaakHtmlInput();
        IRosettaTextOutput MaakHtmlOutput();

        IRosettaTextInput MaakCsvInput();
        IRosettaTextOutput MaakCsvOutput();

        IRosettaTextInput MaakTabDelimitedInput();
        IRosettaTextOutput MaakTabDelimitedOutput();

        IRosettaTextInput MaakXmlInput();
        IRosettaTextOutput MaakXmlOutput();

        IRosettaTextInput MaakJsonInput();
        IRosettaTextOutput MaakJsonOutput();

        IRosettaInput MaakExcelInput();
        IRosettaOutput MaakExcelOutput();

        IRosettaDb MaakSqliteDbToegang();
        IRosettaDb MaakSqlServerDbToegang();
    }

    #endregion

}
