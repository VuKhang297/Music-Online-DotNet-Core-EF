using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DTO
{
    public class UserDTO
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string role { get; set; }
        public byte active { get; set; }
        public int? yearofbirth { get; set; }
    }
}
