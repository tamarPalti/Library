using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BorrowerDTO
    {
        public int id { get; set; }
        public string tz { get; set; }
        public int ageCategory { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
    }
}
