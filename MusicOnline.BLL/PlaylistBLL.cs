using MusicOnline.DAL;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.BLL
{
    public class PlaylistBLL
    {
        private PlaylistDAL dal;
        public PlaylistBLL()
        {
            dal = new PlaylistDAL();
        }
        public IList<PlaylistDTO> GetAll()
        {
            return dal.GetAll();
        }
        public PlaylistDTO Add(PlaylistDTO pll)
        {
            return dal.Add(pll);
        }
    }
}
