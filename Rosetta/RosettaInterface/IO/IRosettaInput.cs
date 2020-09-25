using System.IO;

namespace Rosetta.Interface.IO
{
    public interface IRosettaInput
    {
        IRosettaTabel Lees(Stream input);
        IRosettaTabel Lees(string bestandsnaam);
        IRosettaTabel Lees(FileInfo bestand);
    }
}
