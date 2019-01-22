using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Web_api_Polyanskiy.Models;
using System.Data;

namespace Web_api_Polyanskiy.Controllers
{
    public class FilmsController : ApiController
    {
        FilmContext db = new FilmContext();

        // GET api/films
        public IEnumerable<Film> GetFilms()
        {
            return db.Films;
        }

        // GET api/films/5
        public Film GetFilm(int id)
        {
            Film film = db.Films.Find(id);
            return film;
        }

        // POST api/films
        [HttpPost]
        public void AddFilm([FromBody]Film film)
        {
            db.Films.Add(film);
            db.SaveChanges();
        }

        // PUT api/films/5
        [HttpPut]
        public void EditFilm(int id, [FromBody]Film film)
        {
            if (id == film.Id)
            {
                db.Entry(film).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/films/5
        public void DeleteFilm(int id)
        {
            Film film = db.Films.Find(id);
            if (film != null)
            {
                db.Films.Remove(film);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}