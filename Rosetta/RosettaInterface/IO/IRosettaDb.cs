using Rosetta.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RosettaInterface.IO
{
    public interface IRosettaDb
    {
        void SetConnectionString(string connectionString);
        string TabelNaam { get; set; }

        void SchrijfDbTabel(IRosettaTabel rosettaTabel);

        IRosettaTabel LeesDbTabel();
    }
}
