using Rosetta.Interface;
using RosettaInterface.IO;

namespace Rosetta.IO
{
    internal class SqlServerDbToegang : IRosettaDb
    {
        public string TabelNaam { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IRosettaTabel LeesDbTabel()
        {
            throw new System.NotImplementedException();
        }

        public void SchrijfDbTabel(IRosettaTabel rosettaTabel)
        {
            throw new System.NotImplementedException();
        }

        public void SetConnectionString(string connectionString)
        {
            throw new System.NotImplementedException();
        }
    }
}