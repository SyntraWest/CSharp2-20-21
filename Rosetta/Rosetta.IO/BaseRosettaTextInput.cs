using Rosetta.Interface;
using Rosetta.Interface.IO;
using System.IO;
using System.Text;

namespace Rosetta.IO
{
    internal abstract class BaseRosettaTextInput : IRosettaTextInput
    {
        public abstract IRosettaTabel Lees(TextReader input);

        #region methodes die delegeren naar Lees(TextReader)

        public IRosettaTabel Lees(Stream input, Encoding encoding)
        {
            using (var reader = new StreamReader(input, encoding))
                return Lees(reader);
        }

        public IRosettaTabel Lees(string bestand, Encoding encoding)
        {
            using (var reader = new StreamReader(bestand, encoding))
                return Lees(reader);
        }

        public IRosettaTabel Lees(FileInfo bestand, Encoding encoding)
        {
            using (var reader = new StreamReader(bestand.FullName, encoding))
                return Lees(reader);
        }


        public IRosettaTabel Lees(Stream input)
        {
            using (var reader = new StreamReader(input))
                return Lees(reader);
        }

        public IRosettaTabel Lees(string bestandsnaam)
        {
            using (var reader = new StreamReader(bestandsnaam))
                return Lees(reader);
        }

        public IRosettaTabel Lees(FileInfo bestand)
        {
            using (var reader = bestand.OpenText())
                return Lees(reader);
        }

        #endregion methodes die delegeren naar Lees(TextReader)
    }
}