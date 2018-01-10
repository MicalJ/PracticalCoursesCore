using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.ViewComponents
{
    public class MenuCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public MenuCategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = AutoMapper.Mapper.Map<List<CategoryResponse>>(await _categoryService.GetAllCategory());

            return View("_MenuCategories", categories);
        }
    }
}
