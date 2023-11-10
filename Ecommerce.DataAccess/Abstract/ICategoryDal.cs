using Ecommerce.Core.DataAccess;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DTOs;
using Ecommerce.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Abstract
{
    public interface ICategoryDal:IRepositoryBase<Category>
    { 
        List<CategoryHomeListDTO> GetCategorieByLanguage(string langcode);
        public Task<bool> AddCategory(CategoryAddDTO categoryAddDTO);


    }
}
