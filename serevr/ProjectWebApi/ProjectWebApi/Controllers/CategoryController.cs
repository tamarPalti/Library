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
    public class CategoryController : Controller
    {
        private readonly Library library;
        private readonly CategoryBLL categoryBLL;
        public CategoryController(Library library, CategoryBLL categoryBLL)
        {
            this.library = library;
            this.categoryBLL = categoryBLL;
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Category category = library.category.Find(id);
            if (category == null)
                return NotFound();
            return Ok(categoryBLL.GetCategoryDTO(category.id));
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> Get()
        {
            return Ok(categoryBLL.GetCategoryDTO());
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        [HttpPost]
        public ActionResult<CategoryDTO> Post(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
                return NotFound();
            library.category.Add(BLL.cast.CategoryCast.GetCategory(categoryDTO));
            library.SaveChanges();
            return Ok(categoryDTO);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public ActionResult<CategoryDTO> Put(int id, CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
                return BadRequest();
            if (id != categoryDTO.id)
                return Conflict();
            Category category = BLL.cast.CategoryCast.GetCategory(categoryDTO);
            library.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Category category = library.category.Find(id);
            if (category == null)
                return NotFound();
            library.Remove(category);
            library.SaveChanges();
            return NoContent();
        }
    }
}
