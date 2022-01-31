using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicOnline.DTO;
using MusicOnline.DAL.Model;

namespace MusicOnline.DAL
{
    public class UserDAL
    {
        private Music_OnlineContext db;
        public UserDAL()
        {
            db = new Music_OnlineContext();
        }
        public IList<UserDTO> GetAll()
        {
            List<UserDTO> res = new List<UserDTO>();
            try
            {
                var ls = db.Users.ToList();
                foreach (var u in ls)
                {
                    UserDTO uDto = new UserDTO();
                    uDto.id = u.Id;
                    uDto.username = u.UserName;
                    uDto.password = u.Password;
                    uDto.fullname = u.FullName;
                    uDto.email = u.Email;
                    uDto.phone = u.Phone;
                    uDto.yearofbirth = u.YearOfBirth;
                    uDto.gender = u.Gender;
                    uDto.active = u.Active;
                    res.Add(uDto);
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public bool Update(UserDTO user)
        {
            bool res = false;
            var u = db.Users.FirstOrDefault(x => x.Id == user.id);
            if (!BCrypt.Net.BCrypt.Verify(user.password, u.Password))
                u.Password = BCrypt.Net.BCrypt.HashPassword(user.password);
            if (u.Email != user.email)
                u.Email = user.email;
            if (u.Phone != user.phone)
                u.Phone = user.phone;
            if (u.Gender != user.gender)
                u.Gender = user.gender;
            if (u.Active != user.active)
                u.Active = user.active;
            if (u.FullName != user.fullname)
                u.FullName = user.fullname;
            if (u.YearOfBirth != user.yearofbirth)
                u.YearOfBirth = user.yearofbirth;
            try
            {
                db.Users.Update(u);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int userId)
        {
            bool res = false;
            var u = db.Users.FirstOrDefault(x => x.Id == userId);
            try
            {
                db.Users.Remove(u);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public UserDTO Add(UserDTO user)
        {
            UserDTO res = new UserDTO();
            var u = new User();
            u.UserName = user.username;
            u.Password = BCrypt.Net.BCrypt.HashPassword(user.password);
            u.FullName = user.fullname;
            u.Email = user.email;
            u.Phone = user.phone;
            u.Gender = user.gender;
            u.YearOfBirth = user.yearofbirth;
            u.Active = 0;
            u.Role = "ROLE_USER";
            try
            {
                db.Users.Add(u);
                db.SaveChanges();
                res.id = u.Id;
                res.username = u.UserName;
                res.gender = u.Gender;
                res.password = u.Password;
                res.phone = u.Phone;
                res.email = u.Email;
                res.active = u.Active;
                res.fullname = u.FullName;
                res.yearofbirth = u.YearOfBirth;
                res.role = u.Role;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public UserDTO Login(LoginDTO user)
        {
            UserDTO res = new UserDTO();
            var u = db.Users.SingleOrDefault(x => x.UserName.Equals(user.username));
            if (u != null)
            {
                bool isValid = BCrypt.Net.BCrypt.Verify(user.password, u.Password);
                if (isValid)
                {
                    res.id = u.Id;
                    res.username = u.UserName;
                    res.gender = u.Gender;
                    res.password = u.Password;
                    res.phone = u.Phone;
                    res.email = u.Email;
                    res.active = u.Active;
                    res.fullname = u.FullName;
                    res.yearofbirth = u.YearOfBirth;
                    res.role = u.Role;
                }
                else
                    res = null;
            }
            else
                res = null;
            return res;
        }
    }
}
