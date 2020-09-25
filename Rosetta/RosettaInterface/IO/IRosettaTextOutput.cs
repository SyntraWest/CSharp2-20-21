using System.IO;
using System.Text;

namespace Rosetta.Interface.IO
{
    public interface IRosettaTextOutput : IRosettaOutput
    {
        void Schrijf(IRosettaTabel rosettaTabel, TextWriter output);
        void Schrijf(IRosettaTabel rosettaTabel, Stream output, Encoding encoding);
    }
}
