using MusicOnline.DAL;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.BLL
{
    public class UserBLL
    {
        private UserDAL dal;
        public UserBLL()
        {
            dal = new UserDAL();
        }
        public IList<UserDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(UserDTO user)
        {
            return dal.Update(user);
        }
        public bool Delete(int userId)
        {
            return dal.Delete(userId);
        }
        public UserDTO Add(UserDTO user)
        {
            return dal.Add(user);
        }
        public UserDTO Login(LoginDTO user)
        {
            return dal.Login(user);
        }
    }
}
