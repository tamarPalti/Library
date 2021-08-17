using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using BLL;
using DTO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace ProjectWebApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [EnableCors("myLibrary")]    
    public class BookController : ControllerBase
    {
        private readonly Library library;
        private readonly BookBLL bookBLL;
        public BookController (Library library, BookBLL bookBLL)
        {
            this.library = library;
            this.bookBLL = bookBLL;
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK,Type =typeof(BookDTO))]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = library.Book.Find(id);
            if (book == null)
                return NotFound();
            return Ok(bookBLL.GetBookDTO(book.id)); 
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet]
        public ActionResult<IEnumerable<BookDTO>> Get()
        {
            return Ok(bookBLL.GetBookDTO());
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet("bookListByAge/{id:int}")]
        public ActionResult<IEnumerable<BookDTO>> GetListBookByAge(int id)
        {
            if (bookBLL.GetBookDTOByAgeCategory(id) == null)
                return NotFound();
            return Ok(bookBLL.GetBookDTOByAgeCategory(id));
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet("bookListByName/{id}")]
        public ActionResult<IEnumerable<BookDTO>> GetBookDTOByName(string id)
        {
            return Ok(bookBLL.GetBookDTOByName(id));
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpPost]
        
        public ActionResult <BookDTO> Post(BookDTO bookDTO)
        {
            if (bookDTO == null)
                return NotFound();
            library.Book.Add(BLL.cast.BookCast.GetBook(bookDTO));
            library.SaveChanges();
            return Ok(bookDTO);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public ActionResult<BookDTO> Put(int id,BookDTO bookDTO)
        {
            if (bookDTO == null)
                return BadRequest();
            if (id != bookDTO.id)
                return Conflict();
            Book book = BLL.cast.BookCast.GetBook(bookDTO);
            library.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Book book = library.Book.Find(id);
            if (book == null)
                return NotFound();
            library.Remove(book);
            library.SaveChanges();
            return NoContent();
        }
    }
}
