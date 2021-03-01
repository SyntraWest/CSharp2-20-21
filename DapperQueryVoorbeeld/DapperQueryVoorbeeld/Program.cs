using System;
using Dapper;
using DapperQueryVoorbeeld.Models;
using Microsoft.Data.SqlClient;

namespace DapperQueryVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {

            string sql = @"
SELECT 'een' Alpha, @beta Beta, CURRENT_TIMESTAMP Gamma, @delta1 Delta
UNION ALL
SELECT 'twee' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, @delta2 Delta
UNION ALL
SELECT 'drie' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
UNION ALL
SELECT 'vier' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
UNION ALL
SELECT 'vijf' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
UNION ALL
SELECT 'zes' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
UNION ALL
SELECT 'zeven' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
UNION ALL
SELECT 'acht' Alpha, 123 Beta, CURRENT_TIMESTAMP Gamma, 123.4/567.8 Delta
";

            // normaal zorg je dat je de connection string kan configureren
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using SqlConnection connection = new SqlConnection(connectionString);


            var resultaten = connection.Query<AlphaBeta, GammaDelta, AlphaBetaGammaDelta>(
                sql,
                (ab, gd) => new AlphaBetaGammaDelta
                {
                    Ab = ab,
                    Gd = gd
                },
                new
                {
                    beta = 33,
                    delta1 = 33.44,
                    delta2 = 55.66,
                },
                splitOn: "Gamma");


            foreach (AlphaBetaGammaDelta abgd in resultaten)
            {
                Console.WriteLine(@$"
Resultaat:
==========
Alpha: {abgd.Ab.Alpha}
Beta:  {abgd.Ab.Beta}
Gamma: {abgd.Gd.Gamma}
Delta: {abgd.Gd.Delta}
");


            }

        }


        void VoegIetsToe(SqlConnection connection, AlphaBetaGammaDelta abgd)
        {

            string sql = @"
insert into bla(kolomA, kolomB, kolomG, kolomD)
values(@a, @b, @g, @d)";

            connection.Execute(sql,
                new
                {
                    a = abgd.Ab.Alpha,
                    b = abgd.Ab.Beta,
                    c = abgd.Gd.Gamma,
                    d = abgd.Gd.Delta
                });

        }

    }
}

