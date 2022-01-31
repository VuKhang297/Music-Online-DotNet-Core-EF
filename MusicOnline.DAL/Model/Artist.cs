using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class Artist
    {
        public Artist()
        {
            AlbumArtists = new HashSet<AlbumArtist>();
            SongSingers = new HashSet<SongSinger>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }

        public virtual ICollection<AlbumArtist> AlbumArtists { get; set; }
        public virtual ICollection<SongSinger> SongSingers { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
