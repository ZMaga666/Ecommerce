using Ecommerce.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    { 
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/values
        [HttpGet("getall/{langcode}")]
        public IActionResult Get(string langcode)
        {
            var categories = _categoryService.GetCategories(langcode);
            return Ok(categories);
        }
    }
}
