using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_api_Polyanskiy.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string Content { get; set; }
    }
}