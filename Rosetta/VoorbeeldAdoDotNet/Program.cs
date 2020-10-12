using System;

namespace VoorbeeldAdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var voorbeeld = new AdoDotNetVoorbeeld2())
            {
                // alle methodes van voorbeeld gebruikden dezelfde DbConnection
                voorbeeld.MaakTabel();

                var album = new Album
                {
                    ArtistId = 100,
                    AlbumId = 200,
                    Title = "Album 300",
                };

                int aantalToegevoegd = voorbeeld.InsertData(album);

                var albums = voorbeeld.Albumdata();
                foreach (var selectedAlbum in albums)
                {
                    Console.WriteLine($"{selectedAlbum.AlbumId}\t{selectedAlbum.ArtistId}\t{selectedAlbum.Title}");
                }

                voorbeeld.VerwijderTabel();
            }
        }

        static void Main002(string[] args)
        {
            using (var voorbeeld = new AdoDotNetVoorbeeld2())
            {
                // alle methodes van voorbeeld gebruikden dezelfde DbConnection
                voorbeeld.MaakTabel();

                int artistId = 100;
                int albumId = 200;
                string title = "Album 200";

                int aantalToegevoegd = voorbeeld.InsertData(artistId, albumId, title);

                var albums = voorbeeld.Albumdata();
                foreach (var album in albums)
                {
                    Console.WriteLine($"{album.AlbumId}\t{album.ArtistId}\t{album.Title}");
                }

                voorbeeld.VerwijderTabel();
            }
        }

        static void Main001(string[] args)
        {
            var voorbeeld = new AdoDotNetVoorbeeld();

            voorbeeld.MaakTabel();

            int aantalToegevoegd = voorbeeld.InsertData();
            Console.WriteLine(aantalToegevoegd);

            voorbeeld.Albumdata();



            voorbeeld.VerwijderTabel();
        }
    }
}
