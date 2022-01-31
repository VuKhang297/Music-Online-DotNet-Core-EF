using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class Album
    {
        public Album()
        {
            AlbumArtists = new HashSet<AlbumArtist>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<AlbumArtist> AlbumArtists { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
