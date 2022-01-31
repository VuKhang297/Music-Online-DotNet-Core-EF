using MusicOnline.DAL;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.BLL
{
    public class SongSingerBLL
    {
        private SongSingerDAL dal;
        public SongSingerBLL()
        {
            dal = new SongSingerDAL();
        }
        public IList<SongSingerDTO> GetSingersBySongId(int songId)
        {
            return dal.GetSingersBySongId(songId);
        }
    }
}
