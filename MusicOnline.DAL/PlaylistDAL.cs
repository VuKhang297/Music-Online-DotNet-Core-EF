using MusicOnline.DAL.Model;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DAL
{
    public class PlaylistDAL
    {
        private Music_OnlineContext db;
        public PlaylistDAL()
        {
            db = new Music_OnlineContext();
        }
        public IList<PlaylistDTO> GetAll()
        {
            List<PlaylistDTO> res = new List<PlaylistDTO>();
            try
            {
                var ls = db.Playlists.ToList();
                foreach (var p in ls)
                {
                    PlaylistDTO pDto = new PlaylistDTO();
                    pDto.id = p.Id;
                    pDto.name = p.Name;
                    res.Add(pDto);
                }
                return res;
            }
            catch (Exception e)
            {
                //res = null;
                throw e;
            }
            //return res;
        }
        public PlaylistDTO Add(PlaylistDTO pll)
        {
            PlaylistDTO res = new PlaylistDTO();
            var p = new Playlist();
            p.Name = pll.name;
            p.UserId = 1;
            
            try
            {
                db.Playlists.Add(p);
                db.SaveChanges();
                res.id = p.Id;
                res.name = p.Name;
                res.userId = 1;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
    }
}
