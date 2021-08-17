using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Borrower
    {   
        public int  id { get; set; }
        public string tz { get; set; }
        public int? CategoryId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public virtual Category category { get; set; }
        public virtual List<Lendings> lending { get; set; }
    }
}
