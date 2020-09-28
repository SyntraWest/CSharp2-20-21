using Rosetta.Interface;
using Rosetta.Interface.IO;
using System.IO;
using System.Text;

namespace Rosetta.IO
{
    internal abstract class BaseRosettaTextInput : IRosettaTextInput
    {
        public abstract IRosettaTabel Lees(TextReader input);

        public IRosettaTabel Lees(Stream input, Encoding encoding)
        {
            // TextReader is abstract, dus dit kan niet: new TextReader(input, encoding)
            using (TextReader reader = new StreamReader(input, encoding))
                return Lees(reader);
        }

        public IRosettaTabel Lees(string bestand, Encoding encoding)
        {
            throw new System.NotImplementedException();
        }

        public IRosettaTabel Lees(FileInfo bestand, Encoding encoding)
        {
            throw new System.NotImplementedException();
        }


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