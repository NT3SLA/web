using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web_api_Polyanskiy.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext() : base("FilmContext")
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}