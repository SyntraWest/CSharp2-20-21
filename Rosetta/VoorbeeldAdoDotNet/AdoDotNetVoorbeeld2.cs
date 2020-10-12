using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace VoorbeeldAdoDotNet
{
    class AdoDotNetVoorbeeld2 : IDisposable
    {
        private readonly DbConnection connection;

        public AdoDotNetVoorbeeld2()
        {
            connection = CreateConnection();
        }

        /// <summary>
        /// Maakt een verbinding en opent hem.
        /// </summary>
        /// <returns>Een open DbConnection</returns>
        private DbConnection CreateConnection()
        {
            DbConnection connection = new SqlConnection(@"Data Source=.;Integrated Security=True;Initial Catalog=Chinook;");
            connection.Open(); // connectie moet geopend zijn, want anders krijg je foutmelding bij het uitvoeren van een commando.
            return connection;
        }

        internal void MaakTabel()
        {
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
        internal int InsertData(int artistId, int albumId, string title)
        {
            return InsertData(new Album
            {
                AlbumId = albumId,
                ArtistId = artistId,
                Title = title,
            });
        }

        internal int InsertData(Album album)
        {
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
INSERT INTO Album2 (AlbumId, Title, ArtistId)
VALUES (@albumId, @titel, @artiest)
";
                DbParameter param = command.CreateParameter();
                param.ParameterName = "@albumId";
                param.Value = album.AlbumId;
                command.Parameters.Add(param);

                var param2 = command.CreateParameter();
                param2.ParameterName = "@titel";
                param2.Value = album.Title;
                command.Parameters.Add(param2);

                var param3 = command.CreateParameter();
                param3.ParameterName = "@artiest";
                param3.Value = album.ArtistId;
                command.Parameters.Add(param3);

                return command.ExecuteNonQuery();
            }
        }

        internal List<Album> Albumdata()
        {
            var albums = new List<Album>();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT Title, AlbumId, ArtistId from Album2";
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

                        //albums.Add(new Album
                        //{
                        //    AlbumId = albumId,
                        //    Title = title,
                        //    ArtistId = artistId,
                        //});

                        Album album = new Album();
                        album.AlbumId = albumId;
                        album.Title = title;
                        album.ArtistId = artistId;

                        albums.Add(album);
                    }
                }
            }
            return albums;
        }


        internal void VerwijderTabel()
        {
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = @"DROP TABLE [dbo].[Album2]";
                command.ExecuteNonQuery();
            }

        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
