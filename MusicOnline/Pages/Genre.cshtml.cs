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
    public class GenreModel : PageModel
    {
        public GenreBLL bus;
        public List<GenreDTO> lst;
        public GenreModel()
        {
            bus = new GenreBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(string gen)
        {
            var obj = JsonSerializer.Deserialize<GenreDTO>(gen);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, gen = obj }){ StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(string id)
        {
            var gId = int.Parse(id);
            var res = bus.Delete(gId);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string gen)
        {
            var obj = JsonSerializer.Deserialize<GenreDTO>(gen);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, gen = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
