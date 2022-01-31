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
    public class LoginModel : PageModel
    {
        public UserBLL bus;
        public LoginModel()
        {
            bus = new UserBLL();
        }
        public IActionResult OnPostLogin(string user)
        {
            var obj = JsonSerializer.Deserialize<LoginDTO>(user);
            var res = bus.Login(obj);
            if (res != null)
                return new ObjectResult(new { success = true, user = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }

    }
}
