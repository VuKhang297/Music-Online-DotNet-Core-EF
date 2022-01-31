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
    public class ArtistModel : PageModel
    {
        public ArtistBLL bus;
        public List<ArtistDTO> lst;
        public ArtistModel()
        {
            bus = new ArtistBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(string art)
        {
            var obj = JsonSerializer.Deserialize<ArtistDTO>(art);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, art = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(string id)
        {
            var aId = int.Parse(id);
            var res = bus.Delete(aId);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string art)
        {
            var obj = JsonSerializer.Deserialize<ArtistDTO>(art);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, art = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
