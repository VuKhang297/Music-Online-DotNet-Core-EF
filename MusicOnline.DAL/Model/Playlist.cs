using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class Playlist
    {
        public Playlist()
        {
            PlaylistSongs = new HashSet<PlaylistSong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}
