using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicOnline.DTO;
using MusicOnline.DAL.Model;

namespace MusicOnline.DAL
{
    public class GenreDAL
    {
        private Music_OnlineContext db;

        public GenreDAL()
        {
            db = new Music_OnlineContext();
        }

        public IList<GenreDTO> GetAll()
        {
            List<GenreDTO> res = new List<GenreDTO>();
            try
            {
                var ls = db.Genres.ToList();
                foreach(var g in ls)
                {
                    GenreDTO gDto = new GenreDTO();
                    gDto.id = g.Id;
                    gDto.name = g.Name;
                    res.Add(gDto);
                }
            }
            catch(Exception e)
            {
                res = null;
            }
            return res;
        }
        public bool Update(GenreDTO gen)
        {
            bool res = false;
            var g = db.Genres.FirstOrDefault(x => x.Id == gen.id);
            if (g.Name != gen.name)
                g.Name = gen.name;
            try
            {
                db.Genres.Update(g);
                db.SaveChanges();
                res = true;
            }
            catch(Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int genId)
        {
            bool res = false;
            var g = db.Genres.FirstOrDefault(x => x.Id == genId);
            try
            {
                db.Genres.Remove(g);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public GenreDTO Add(GenreDTO gen)
        {
            GenreDTO res = new GenreDTO();
            var g = new Genre();
            g.Name = gen.name;
            try
            {
                db.Genres.Add(g);
                db.SaveChanges();
                res.id = g.Id;
                res.name = g.Name;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
    }
}
