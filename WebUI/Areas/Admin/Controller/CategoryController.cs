﻿using Ecommerce.Business.Abstract;
using Ecommerce.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() 
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(CategoryAddDTO category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction("Index");

        }
    }
}
