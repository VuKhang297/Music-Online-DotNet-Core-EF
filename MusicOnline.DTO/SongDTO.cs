using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DTO
{
    public class SongDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lyric { get; set; }
        public string link { get; set; }
        public string country { get; set; }
        public int genreId { get; set; }
        public int kindId { get; set; }
        public int userId { get; set; }
        public int albumId { get; set; }
        public int composed { get; set; }
        public int? likes { get; set; }
        public int? listens { get; set; }
        public DateTime? createdDate { get; set; }
    }
}
