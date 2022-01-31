using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class User
    {
        public User()
        {
            Playlists = new HashSet<Playlist>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public byte Active { get; set; }
        public int? YearOfBirth { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
