using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DAL.Model
{
    public partial class Kind
    {
        public Kind()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
