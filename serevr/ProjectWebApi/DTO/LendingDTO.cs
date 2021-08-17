using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LendingDTO
    {
        public int id { get; set; }
        public int borrowerid { get; set; }
        public string borrowerFirstName { get; set; }
        public string borrowerLastName { get; set; }
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public DateTime landingDate { get; set; }
        public DateTime returnDate { get; set; }
    }
}
