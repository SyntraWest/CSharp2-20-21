using System;
using System.Collections.Generic;
using System.Text;

namespace VoorbeeldAdoDotNet
{
    /// <summary>
    /// Entity klasse voor de albums uit de Chinook database
    /// </summary>
    class Album
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
    }
}
