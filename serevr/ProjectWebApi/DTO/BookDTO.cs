using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string summary { get; set; }
        public int ageCategory { get; set; }
        public int pageCount { get; set; }
    }
}
