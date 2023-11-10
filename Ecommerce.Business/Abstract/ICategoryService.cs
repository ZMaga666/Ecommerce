using Ecommerce.Core.Utilities.Results.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DTOs;
using Ecommerce.Entities.DTOs.CategoryDTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Abstract
{
    public interface ICategoryService
    {
        IResult AddCategory(CategoryAddDTO category);

        IResult DeleteCategory(Category category);
        IResult UpdateCategory(Category category);
        IDataResult<List<CategoryHomeListDTO>> GetCategories(string langcode);
       IDataResult<List<Category>> GetNavbarCategories(string langcode);

    }
}
