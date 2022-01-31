using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class AlbumArtist
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
