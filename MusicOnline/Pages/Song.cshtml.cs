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
    public class SongModel : PageModel
    {
        public SongBLL bus;
        public SongSingerBLL ssbus = new SongSingerBLL();
        public ArtistBLL abus;
        public List<SongDTO> lst;
        public List<SongSingerDTO> sslst;
        public string ketQua;
        public int TotalPage;
        public SongModel()
        {
            bus = new SongBLL();
        }
        public void OnGet()
        {
            int size = 5;
            lst = bus.GetAll().Take(size).ToList();
            
            sslst = ssbus.GetSingersBySongId(4).ToList();
            var totalRecord = bus.GetAll().Count();
            TotalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
            //lst = bus.GetAll().ToList();
            //ArtistDTO art = abus.GetArtistById(1);
        }
        public IActionResult OnPostList(string filter)
        {
            var obj = JsonSerializer.Deserialize<Filter>(filter);
            var Data = bus.GetSongByPage(obj.Page, obj.Size);
            return new ObjectResult(new { success = true, data = Data }) { StatusCode = 200 };
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 2, Name = "Happy" }) { StatusCode = 200};
        }
        public IActionResult OnPostUpdate(string song)
        {
            var obj = JsonSerializer.Deserialize<SongDTO>(song);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, song = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(string id)
        {
            var sId = int.Parse(id);
            var res = bus.Delete(sId);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(string song)
        {
            var obj = JsonSerializer.Deserialize<SongDTO>(song);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, song = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
