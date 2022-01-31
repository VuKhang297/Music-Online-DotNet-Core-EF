using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class Song
    {
        public Song()
        {
            PlaylistSongs = new HashSet<PlaylistSong>();
            SongSingers = new HashSet<SongSinger>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lyric { get; set; }
        public string Link { get; set; }
        public int KindId { get; set; }
        public string Country { get; set; }
        public int GenreId { get; set; }
        public int UserId { get; set; }
        public int AlbumId { get; set; }
        public int Composed { get; set; }
        public int? Likes { get; set; }
        public int? Listens { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist ComposedNavigation { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Kind Kind{ get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; }
        public virtual ICollection<SongSinger> SongSingers { get; set; }
    }
}
