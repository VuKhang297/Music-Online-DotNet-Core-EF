using MusicOnline.DAL.Model;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DAL
{
    public class ArtistDAL
    {
        private Music_OnlineContext db;

        public ArtistDAL()
        {
            db = new Music_OnlineContext();
        }

        public IList<ArtistDTO> GetAll()
        {
            List<ArtistDTO> res = new List<ArtistDTO>();
            try
            {
                var ls = db.Artists.ToList();
                foreach (var a in ls)
                {
                    ArtistDTO aDto = new ArtistDTO();
                    aDto.id = a.Id;
                    aDto.name = a.Name;
                    aDto.profile = a.Profile;
                    res.Add(aDto);
                }
            }
            catch (Exception e)
            {
                throw e;
                res = null;
            }
            return res;
        }
        public bool Update(ArtistDTO art)
        {
            bool res = false;
            var a = db.Artists.FirstOrDefault(x => x.Id == art.id);
            if (a.Name != art.name)
                a.Name = "N'" + art.name + "'";
            if (a.Profile != art.profile)
                a.Profile = art.profile;
            try
            {
                db.Artists.Update(a);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int artId)
        {
            bool res = false;
            var g = db.Artists.FirstOrDefault(x => x.Id == artId);
            try
            {
                db.Artists.Remove(g);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public ArtistDTO Add(ArtistDTO art)
        {
            ArtistDTO res = new ArtistDTO();
            var a = new Artist();
            a.Name = art.name;
            a.Profile = art.profile;
            try
            {
                db.Artists.Add(a);
                db.SaveChanges();
                res.id = a.Id;
                res.name = a.Name;
                res.profile = a.Profile;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public ArtistDTO GetArtistById(int aId)
        {
            ArtistDTO res = new ArtistDTO();
            var a = db.Artists.FirstOrDefault(x => x.Id == aId);
            res.id = a.Id;
            res.name = a.Name;
            res.profile = a.Profile;
            return res;
        }
    }
}
