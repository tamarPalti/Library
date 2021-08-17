using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BookBLL
    {
        private readonly Library library;
       
        public BookBLL(Library l)
        {
            library = l;
        }
        public BookDTO GetBookDTO(int id)
        {
            Book book = library.Book.Find(id);
            return cast.BookCast.GetBookDTO(book);
        }
        public List<BookDTO> GetBookDTO()
        {
            List <BookDTO> bookDTO = new List<BookDTO>();
            library.Book.ToList().ForEach(b => bookDTO.Add(cast.BookCast.GetBookDTO(b)));
            return bookDTO;
        }
        public List<BookDTO> GetBookDTOByAgeCategory(int age)
        {
            List<BookDTO> bookDTO = new List<BookDTO>();
            library.Book.ToList().ForEach(b =>
            {
                if (b.CategoryId == age)
                    bookDTO.Add(cast.BookCast.GetBookDTO(b));
            });
            return bookDTO;
        }
        public List<BookDTO> GetBookDTOByName(string name)
        {
            List<BookDTO> bookDTO = new List<BookDTO>();
            library.Book.ToList().ForEach(b =>
            {
                if (b.title.Contains(name))
                    bookDTO.Add(cast.BookCast.GetBookDTO(b));
            });
            return bookDTO;
        }
    }
}
