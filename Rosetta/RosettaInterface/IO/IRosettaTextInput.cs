using System.IO;
using System.Text;

namespace Rosetta.Interface.IO
{
    public interface IRosettaTextInput : IRosettaInput
    {
        IRosettaTabel Lees(Stream input, Encoding encoding);
        IRosettaTabel Lees(string bestand, Encoding encoding);
        IRosettaTabel Lees(FileInfo bestand, Encoding encoding);
        IRosettaTabel Lees(TextReader input);
    }
}
