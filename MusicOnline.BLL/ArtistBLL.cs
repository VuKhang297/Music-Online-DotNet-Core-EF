using MusicOnline.DAL;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.BLL
{
    public class ArtistBLL
    {
        private ArtistDAL dal;
        public ArtistBLL()
        {
            dal = new ArtistDAL();
        }
        public IList<ArtistDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(ArtistDTO art)
        {
            return dal.Update(art);
        }
        public bool Delete(int artId)
        {
            return dal.Delete(artId);
        }
        public ArtistDTO Add(ArtistDTO art)
        {
            return dal.Add(art);
        }
        public ArtistDTO GetArtistById(int aId)
        {
            return dal.GetArtistById(aId);
        }
    }
}
