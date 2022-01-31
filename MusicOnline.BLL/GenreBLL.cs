using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicOnline.DAL;
using MusicOnline.DTO;

namespace MusicOnline.BLL
{
    public class GenreBLL
    {
        private GenreDAL dal;
        public GenreBLL()
        {
            dal = new GenreDAL();
        }
        public IList<GenreDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(GenreDTO gen)
        {
            return dal.Update(gen);
        }
        public bool Delete(int genId)
        {
            return dal.Delete(genId);
        }
        public GenreDTO Add(GenreDTO gen)
        {
            return dal.Add(gen);
        }
    }
}
