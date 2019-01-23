using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// 
// Не действует без инициализатора, данные можно добавить методом model first, непосредственно через конструктор
//

namespace Web_api_Polyanskiy.Models
{
    class CodeFirst
    {
        static void Main(string[] args)
        {
            using (FilmContext db = new FilmContext())
            {
                db.Films.Add(new Film { Name = "Matrix", Director = "Br. Wachovski", Year = 1992, Genre = "Action", Country = "USA",
                Duration = 120});
                db.Films.Add(new Film { Name = "Matrix 2", Director = "Br. Wachovski", Year = 2003, Genre = "Action", Country = "USA",
                Duration = 126});
                db.Films.Add(new Film { Name = "Matrix 3", Director = "Br. Wachovski", Year = 2003, Genre = "Action", Country = "USA",
                Duration = 130});

                db.SaveChanges();
            }
        }
    }
}