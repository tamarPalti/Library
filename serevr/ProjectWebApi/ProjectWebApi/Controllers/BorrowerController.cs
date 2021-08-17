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
    public class BorrowerController : ControllerBase
    {
        private readonly Library library;
        private readonly BorrowerBLL borrowerBLL;
        public BorrowerController(Library library, BorrowerBLL borrowerBLL)
        {
            this.library = library;
            this.borrowerBLL = borrowerBLL;
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Borrower borrower =  library.Borrower.Find(id);
            if (borrower == null)
                return NotFound();
            return Ok(borrowerBLL.GetBorrowerDTO(borrower.id));
        }  
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet]
        public ActionResult<IEnumerable<BorrowerDTO>> Get()
        {
            return Ok(borrowerBLL.GetBorrowerDTO());
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpPost]
        public ActionResult<BorrowerDTO> Post(BorrowerDTO borrowerDTO)
        {
            if (borrowerDTO == null)
                return NotFound();
            library.Borrower.Add(BLL.cast.BorrowerCast.GetBorrower(borrowerDTO));
            library.SaveChanges();
            return Ok(borrowerDTO);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public ActionResult<BorrowerDTO> Put(int id, BorrowerDTO borrowerDTO)
        {
            if (borrowerDTO == null)
                return BadRequest();
            if (id != borrowerDTO.id)
                return Conflict();
            Borrower borrower = BLL.cast.BorrowerCast.GetBorrower(borrowerDTO);
            library.Entry(borrower).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Borrower borrower = library.Borrower.Find(id);
            if (borrower == null)
                return NotFound();
            library.Remove(borrower);
            library.SaveChanges();
            return NoContent();
        }
    }
}
