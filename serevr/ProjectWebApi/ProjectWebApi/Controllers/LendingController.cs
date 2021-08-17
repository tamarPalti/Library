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
    public class LendingController : Controller
    {
        private readonly Library library;
        private readonly LendingBLL lendingBLL;
        public LendingController(Library library, LendingBLL lendingBLL)
        {
            this.library = library;
            this.lendingBLL = lendingBLL;
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Lendings lendings = library.Lendings.Find(id);
            if (lendings == null)
                return NotFound();
            return Ok(lendingBLL.GetLendingDTO(lendings.id));
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet]
        public ActionResult<IEnumerable<LendingDTO>> Get()
        {
            return Ok(lendingBLL.GetLendingDTO());
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpPost]
        public ActionResult<LendingDTO> Post(LendingDTO lendingDTO)
        {
            if (lendingDTO == null)
                return NotFound();
            library.Lendings.Add(BLL.cast.LendingCast.Getlending(lendingDTO));
            library.SaveChanges();
            return Ok(lendingDTO);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public ActionResult<LendingDTO> Put(int id, LendingDTO lendingDTO)
        {
            if (lendingDTO == null)
                return BadRequest();
            if (id != lendingDTO.id)
                return Conflict();
            Lendings lendings = BLL.cast.LendingCast.Getlending(lendingDTO);
            library.Entry(lendings).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Lendings lendings = library.Lendings.Find(id);
            if (lendings == null)
                return NotFound();
            library.Remove(lendings);
            library.SaveChanges();
            return NoContent();
        }
    }
}
