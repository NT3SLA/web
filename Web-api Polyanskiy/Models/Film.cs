using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_api_Polyanskiy.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public int Duration { get; set; }
    }
}