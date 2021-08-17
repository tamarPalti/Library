using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Lendings
    {
        public int id { get; set; }   
        
        public DateTime landing { get; set; }
        public DateTime returnDate { get; set; }
        public int? bookId { get; set; }
        public virtual Book book { get; set; }
        public int? borrowerid { get; set; }
        public virtual Borrower borrower { get; set; }
    }
}
