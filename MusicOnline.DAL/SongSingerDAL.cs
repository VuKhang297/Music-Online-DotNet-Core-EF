using MusicOnline.DAL.Model;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DAL
{
    public class SongSingerDAL
    {
        public Music_OnlineContext db = new Music_OnlineContext();
        public IList<SongSingerDTO> GetSingersBySongId(int songId)
        {
            List<SongSingerDTO> res = new List<SongSingerDTO>();
            try
            {
                var ls = db.SongSingers.Where(x => x.SongId == songId).ToList();
                foreach (var ss in ls)
                {
                    SongSingerDTO ssDto = new SongSingerDTO();
                    ssDto.songId = ss.SongId;
                    ssDto.singerId = ss.SingerId;
                    res.Add(ssDto);
                }
            }
            catch (Exception e)
            {
                throw e;
                res = null;
            }
            return res;
        }
    }
}
