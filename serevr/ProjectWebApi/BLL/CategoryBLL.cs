using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class CategoryBLL
    {
        private readonly Library library;
        public CategoryBLL(Library l)
        {
            library = l;
        }
        public CategoryDTO GetCategoryDTO(int id)
        {
            Category category = library.category.Find(id);
            return cast.CategoryCast.GetCategoryDTO(category);
        }
        public List<CategoryDTO> GetCategoryDTO()
        {
            List<CategoryDTO> categoryDTO = new List<CategoryDTO>();
            library.category.ToList().ForEach(c => categoryDTO.Add(cast.CategoryCast.GetCategoryDTO(c)));
            return categoryDTO;
        }
    }
}
