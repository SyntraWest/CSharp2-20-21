using System.IO;

namespace Rosetta.Interface.IO
{
    public interface IRosettaOutput
    {
        void Schrijf(IRosettaTabel rosettaTabel, Stream output);
        void Schrijf(IRosettaTabel rosettaTabel, string bestandsnaam);
        void Schrijf(IRosettaTabel rosettaTabel, FileInfo bestand);
    }
}
