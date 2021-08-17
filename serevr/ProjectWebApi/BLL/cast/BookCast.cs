using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL.cast
{
   public class BookCast
    {
        public static BookDTO  GetBookDTO(Book b)
        {
            BookDTO bookDTO = new BookDTO();
            bookDTO.id = b.id;
            bookDTO.pageCount = b.pageCount;
            bookDTO.summary = b.summary;
            bookDTO.title = b.title;
            bookDTO.ageCategory = b.CategoryId.Value;
            bookDTO.author = b.author;
            return bookDTO;
        }
        public static Book GetBook(BookDTO b)
        {
            Book book = new Book();
            book.id = b.id;
            book.pageCount = b.pageCount;
            book.summary = b.summary;
            book.title = b.title;
            book.CategoryId = b.ageCategory;
            book.author = b.author;
            return book;
        }

    }
}
