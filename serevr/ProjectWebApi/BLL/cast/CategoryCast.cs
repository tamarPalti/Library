using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL.cast
{
    public class CategoryCast
    {
        public static CategoryDTO GetCategoryDTO(Category c)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.id = c.id;
            categoryDTO.color = c.color;
            categoryDTO.description = c.description;
            categoryDTO.name = c.name;
            return categoryDTO;
        }
        public static Category GetCategory(CategoryDTO c)
        {
            Category category = new Category();
            category.id = c.id;
            category.color = c.color;
            category.description = c.description;
            category.name = c.name;
            return category;
        }
    }
}
