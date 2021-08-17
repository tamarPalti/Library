using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public virtual List<Borrower> borrowers { get; set; }
        public virtual List<Book> books { get; set; }
    }
}
