using Grpc.Core;
using MusicOnline.DAL.Model;
using MusicOnline.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.DAL
{
    public class SongDAL
    {
        private Music_OnlineContext db;
        public SongDAL()
        {
            db = new Music_OnlineContext();
        }
        public IList<SongDTO> GetAll()
        {
            List<SongDTO> res = new List<SongDTO>();
            try
            {
                var ls = db.Songs.ToList();
                foreach (var s in ls)
                {
                    SongDTO sDto = new SongDTO();
                    sDto.id = s.Id;
                    sDto.name = s.Name;
                    sDto.kindId = s.KindId;
                    sDto.genreId = s.GenreId;
                    sDto.link = s.Link;
                    sDto.listens = s.Listens;
                    sDto.likes = s.Likes;
                    sDto.userId = s.UserId;
                    sDto.lyric = s.Lyric;
                    sDto.composed = s.Composed;
                    sDto.country = s.Country;
                    sDto.createdDate = s.CreatedDate;
                    sDto.albumId = s.AlbumId;
                    res.Add(sDto);
                }
                return res;
            }
            catch (Exception e)
            {
                //res = null;
                throw e;
            }
            //return res;
        }
        public object GetSongByPage(int page, int size)
        {
            List<SongDTO> data = new List<SongDTO>();
            var res = new
            {
                Data = data,
                TotalRecord = 0,
                TotalPage = 0,
                Page = page,
                Size = size
            };
            try
            {
                var ls = db.Songs.ToList();
                var offset = (page - 1) * size;
                var totalRecord = ls.Count();
                int totalPage = (totalRecord % size) == 0 ? (int)(totalRecord / size) : (int)((totalRecord / size) + 1);
                var lst = ls.Skip(offset).Take(size);
                foreach (var s in lst)
                {
                    SongDTO sDto = new SongDTO();
                    sDto.id = s.Id;
                    sDto.name = s.Name;
                    sDto.kindId = s.KindId;
                    sDto.genreId = s.GenreId;
                    sDto.link = s.Link;
                    sDto.listens = s.Listens;
                    sDto.likes = s.Likes;
                    sDto.userId = s.UserId;
                    sDto.lyric = s.Lyric;
                    sDto.composed = s.Composed;
                    sDto.country = s.Country;
                    sDto.createdDate = s.CreatedDate;
                    sDto.albumId = s.AlbumId;
                    data.Add(sDto);
                }
                res = new
                {
                    Data = data,
                    TotalRecord = totalRecord,
                    TotalPage = totalPage,
                    Page = page,
                    Size = size
                };
                return res;
            }
            catch (Exception e)
            {
                //res = null;
                throw e;
            }
            //return res;
        }
        public bool Update(SongDTO song)
        {
            bool res = false;
            var s = db.Songs.FirstOrDefault(x => x.Id == song.id);
            if (s.Lyric != song.lyric)
                s.Lyric = song.lyric;
            try
            {
                db.Songs.Update(s);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int songId)
        {
            bool res = false;
            var s = db.Songs.FirstOrDefault(x => x.Id == songId);
            try
            {
                db.Songs.Remove(s);
                db.SaveChanges();
                res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public SongDTO Add(SongDTO song)
        {
            SongDTO res = new SongDTO();
            var s = new Song();
            s.Name = song.name;
            s.KindId = song.kindId;
            s.GenreId = song.genreId;
            s.Lyric = song.lyric;
            s.Likes = song.likes;
            string filename = Path.GetFileName(song.link);
            string path = "./wwwroot/Songs/" + filename;
            var stream = System.IO.File.Create(path);
            s.Link = path;
            s.Listens = song.listens;
            s.UserId = song.userId;
            s.Composed = song.composed;
            s.Country = song.country;
            try
            {
                db.Songs.Add(s);
                db.SaveChanges();
                res.id = s.Id;
                res.name = s.Name;
                res.kindId = s.KindId;
                res.genreId = s.GenreId;
                res.lyric = s.Lyric;
                res.likes = s.Likes;
                res.listens = s.Listens;
                res.link = s.Link;
                res.composed = s.Composed;
                res.userId = s.UserId;
                res.country = s.Country;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        public SongDTO GetSongById(int id)
        {
            SongDTO res = new SongDTO();
            var s = db.Songs.FirstOrDefault(x => x.Id == id);
            try
            {
                db.Songs.Add(s);
                db.SaveChanges();
                res.id = s.Id;
                res.name = s.Name;
                res.kindId = s.KindId;
                res.genreId = s.GenreId;
                res.lyric = s.Lyric;
                res.likes = s.Likes;
                res.listens = s.Listens;
                res.link = s.Link;
                res.composed = s.Composed;
                res.userId = s.UserId;
                res.country = s.Country;
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
    }
}
