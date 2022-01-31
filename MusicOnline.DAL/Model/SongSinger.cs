using System;
using System.Collections.Generic;

#nullable disable

namespace MusicOnline.DAL.Model
{
    public partial class SongSinger
    {
        public int SongId { get; set; }
        public int SingerId { get; set; }

        public virtual Artist Singer { get; set; }
        public virtual Song Song { get; set; }
    }
}
