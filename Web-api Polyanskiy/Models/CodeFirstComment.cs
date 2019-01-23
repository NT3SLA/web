using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// 
// Не действует без инициализатора, данные можно добавить методом model first, непосредственно через конструктор
//

namespace Web_api_Polyanskiy.Models
{
    class CodeFirstComment
    {
        static void Main(string[] args)
        {
            using (FilmContext db = new FilmContext())
            {
                db.Comments.Add(new Comment { FilmName = "Matrix", Content = "Хороший сюжет" });
                db.Comments.Add(new Comment { FilmName = "Matrix 2", Content = "Хороший сюжет"});
                db.Comments.Add(new Comment { FilmName = "Matrix 3", Content = "Хороший сюжет"});
            }
        }
    }
}