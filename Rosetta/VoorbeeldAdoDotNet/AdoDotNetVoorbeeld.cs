using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace VoorbeeldAdoDotNet
{
    class AdoDotNetVoorbeeld
    {

        /// <summary>
        /// Maakt een verbinding en opent hem.
        /// </summary>
        /// <returns>Een open DbConnection</returns>
        private DbConnection CreateConnection()
        {
            var connection = new SqlConnection("Data Source=.;Integrated Security=True;Initial Catalog=Chinook;");
            connection.Open(); // connectie moet geopend zijn, want anders krijg je foutmelding bij het uitvoeren van een commando.
            return connection;
        }

        internal void MaakTabel()
        {

            using (DbConnection connection = CreateConnection())
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
CREATE TABLE [dbo].[Album2] (
    [AlbumId]  INT            NOT NULL,
    [Title]    NVARCHAR (160) NOT NULL,
    [ArtistId] INT            NOT NULL,
)";
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Het aantal records dat is toegevoegd, verwijderd of aangepast</returns>
        internal int InsertData()
        {
            using (DbConnection connection = CreateConnection())
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Album2 (AlbumId, Title, ArtistId) Select * from dbo.Album";
                return command.ExecuteNonQuery();
            }
        }

        internal void Albumdata()
        {
            using(DbConnection connection = CreateConnection())
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT * from Album";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    int colAlbumId = reader.GetOrdinal("AlbumId");
                    int colTitle = reader.GetOrdinal("Title");
                    int colArtistId = reader.GetOrdinal("ArtistId");

                    while (reader.Read())
                    {
                        int albumId = reader.GetInt32(colAlbumId);
                        string title = reader.GetString(colTitle);
                        int artistId = reader.GetInt32(colArtistId);

                        Console.WriteLine($"{albumId:##0}\t{artistId:##0}\t{title}");
                    }
                }
            }

        }


        internal void VerwijderTabel()
        {
            using (DbConnection connection = CreateConnection())
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DROP TABLE [dbo].[Album2]";
                command.ExecuteNonQuery();
            }

        }
    }
}
