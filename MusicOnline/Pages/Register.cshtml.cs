using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicOnline.BLL;
using MusicOnline.DTO;

namespace MusicOnline.Pages
{
    public class RegisterModel : PageModel
    {
        public UserBLL bus;
        public List<UserDTO> lst;
        public RegisterModel()
        {
            bus = new UserBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostAdd(string user)
        {
            var obj = JsonSerializer.Deserialize<UserDTO>(user);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, user = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
