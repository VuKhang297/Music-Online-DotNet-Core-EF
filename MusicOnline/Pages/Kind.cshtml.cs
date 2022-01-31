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
    public class KindModel : PageModel
    {
        public KindBLL bus;
        public List<KindDTO> lst;
        public KindModel()
        {
            bus = new KindBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(string kin)
        {
            var obj = JsonSerializer.Deserialize<KindDTO>(kin);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, kin = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(string id)
        {
            var kId = int.Parse(id);
            var res = bus.Delete(kId);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string kin)
        {
            var obj = JsonSerializer.Deserialize<KindDTO>(kin);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, kin = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
