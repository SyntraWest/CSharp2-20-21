using Rosetta.Interface;
using Rosetta.Interface.IO;
using System.IO;
using System.Text;

namespace Rosetta.IO
{
    internal abstract class BaseRosettaTextOutput : IRosettaTextOutput
    {
        public abstract void Schrijf(IRosettaTabel rosettaTabel, TextWriter output);

        #region Methodes die delegeren naar de abstracte methode

        public void Schrijf(IRosettaTabel rosettaTabel, Stream output, Encoding encoding)
        {
            using (var writer = new StreamWriter(output, encoding))
            {
                Schrijf(rosettaTabel, writer);
            }
        }

        public void Schrijf(IRosettaTabel rosettaTabel, Stream output)
        {
            using (var writer = new StreamWriter(output))
            {
                Schrijf(rosettaTabel, writer);
            }
        }

        public void Schrijf(IRosettaTabel rosettaTabel, string bestandsnaam)
        {
            using (var output = new StreamWriter(bestandsnaam))
            {
                Schrijf(rosettaTabel, output);
            }
        }

        public void Schrijf(IRosettaTabel rosettaTabel, FileInfo bestand)
        {
            using (var output = bestand.CreateText())
            {
                Schrijf(rosettaTabel, output);
            }
        }

        #endregion Methodes die delegeren naar de abstracte methode
    }
}