using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DTOs;
using Ecommerce.Entities.DTOs.CategoryDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public async Task<bool>AddCategory(CategoryAddDTO categoryAddDTO)
        {
            try
            {
                using var context = new AppDbContext();
                var category = new Category()
                {
                    PhotoUrl = categoryAddDTO.PhotoUrl,
                    IsFeatured = false
                };
                await context.AddAsync(category);
                await context.SaveChangesAsync();

                for(int i = 0;i<categoryAddDTO.CategoryName.Count;i++)
                {
                    CategoryLanguage cl = new()
                    {
                        CategoryName = categoryAddDTO.CategoryName[i],
                        CategoryId = category.Id,
                        LangCode = categoryAddDTO.LangCode[i],
                        SeoUrl = "asdfg"
                    };
                    await context.SaveChangesAsync();
                }


                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CategoryHomeListDTO> GetCategorieByLanguage(string langcode)
        {
            using var context = new AppDbContext();
            
        var result = context.CategoryLanguages.Include(z=>z.Category).Where(x=>x.LangCode==langcode)
                .Select(x=> new CategoryHomeListDTO
                { Id=x.Category.Id,
                CategoryName=x.CategoryName,
                SeoUrl=x.Category.SeoUrl,
                PhotoUrl=x.Category.PhotoUrl,
                ProductCount=0,
        
        
        
        
        
        
       
                }).ToList();
            return result;


        }

    }
}
