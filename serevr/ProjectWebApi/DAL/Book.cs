using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Book
    {
      public int id { get; set; }
      public string title { get; set; }
      public string author { get; set; }
      public string summary { get; set; }
      public int? CategoryId { get; set; }
      public int pageCount { get; set; }
      public virtual Category category { get; set; }
      public virtual List<Lendings> lending { get; set; }
    }
}
