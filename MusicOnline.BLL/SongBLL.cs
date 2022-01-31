using MusicOnline.DAL;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.BLL
{
    public class SongBLL
    {
        private SongDAL dal;
        public SongBLL()
        {
            dal = new SongDAL();
        }
        public IList<SongDTO> GetAll()
        {
            return dal.GetAll();
        }
        public object GetSongByPage(int page, int size)
        {
            return dal.GetSongByPage(page, size);
        }
        public bool Update(SongDTO song)
        {
            return dal.Update(song);
        }
        public bool Delete(int songId)
        {
            return dal.Delete(songId);
        }
        public SongDTO Add(SongDTO song)
        {
            return dal.Add(song);
        }
        public SongDTO GetSongById(int id)
        {
            return dal.GetSongById(id);
        }
    }
}
