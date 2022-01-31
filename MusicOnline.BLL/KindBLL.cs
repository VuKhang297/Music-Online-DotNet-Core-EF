using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicOnline.DAL;
using MusicOnline.DTO;

namespace MusicOnline.BLL
{
    public class KindBLL
    {
        private KindDAL dal;
        public KindBLL()
        {
            dal = new KindDAL();
        }
        public IList<KindDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(KindDTO kin)
        {
            return dal.Update(kin);
        }
        public bool Delete(int kinId)
        {
            return dal.Delete(kinId);
        }
        public KindDTO Add(KindDTO kin)
        {
            return dal.Add(kin);
        }
    }
}
