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
    public class PlaylistModel : PageModel
    {
        public PlaylistBLL bus;
        public List<PlaylistDTO> lst;
        public PlaylistModel()
        {
            bus = new PlaylistBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostAdd(string pll)
        {
            var obj = JsonSerializer.Deserialize<PlaylistDTO>(pll);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, pll = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
