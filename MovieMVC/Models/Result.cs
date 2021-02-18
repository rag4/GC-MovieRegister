using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public string actors { get; set; }
        public string directors { get; set; }
    }
}
