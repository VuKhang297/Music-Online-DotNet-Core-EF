using MusicOnline.DTO;
using MusicOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicOnline.DAL
{
    public class KindDAL
    {
        private Music_OnlineContext db;
        public KindDAL()
        {
            db = new Music_OnlineContext();
        }

        public IList<KindDTO> GetAll()
        {
            List<KindDTO> res = new List<KindDTO>();
            try
            {
                var ls = db.Kinds.ToList();
                foreach (var k in ls)
                {
                    KindDTO kDto = new KindDTO();
                    kDto.id = k.Id;
                    kDto.name = k.Name;
                    res.Add(kDto);
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public bool Update(KindDTO kin)
        {
            bool res = false;
            var k = db.Kinds.FirstOrDefault(x => x.Id == kin.id);
            if (k.Name != kin.name)
                k.Name = kin.name;
            try
            {
                db.Kinds.Update(k);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int kinId)
        {
            bool res = false;
            var k = db.Kinds.FirstOrDefault(x => x.Id == kinId);
            try
            {
                db.Kinds.Remove(k);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public KindDTO Add(KindDTO kin)
        {
            KindDTO res = new KindDTO();
            var k = new Kind();
            k.Name = kin.name;
            try
            {
                db.Kinds.Add(k);
                db.SaveChanges();
                res.id = k.Id;
                res.name = k.Name;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
    }
}
