using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PracticalCourses.Infrastructure;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;
using PracticalCourses.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticalCourses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;
        private readonly IMemoryCache _cache;

        public HomeController(ICategoryService categoryService, ICourseService courseService, IMemoryCache cache)
        {
            _categoryService = categoryService;
            _courseService = courseService;
            _cache = cache;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            List<CategoryResponse> categories = await await _cache.GetOrCreateAsync(Consts.categoriesCacheKey,  entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromMinutes(60));
                return Task.FromResult(AutoMapper.Mapper.Map<Task<List<CategoryResponse>>>(_categoryService.GetAllCategory()));
            });

            if (_cache.TryGetValue(Consts.newsCacheKey, out List<CourseResponse> newsCourses))
            {
                newsCourses = _cache.Get(Consts.newsCacheKey) as List<CourseResponse>;
            }
            else
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(60));
                newsCourses = AutoMapper.Mapper.Map<List<CourseResponse>>(_courseService.GetThreeNews());
                _cache.Set(Consts.newsCacheKey, newsCourses, cacheEntryOptions);
            }

            if (_cache.TryGetValue(Consts.bestellersCacheKey, out List<CourseResponse> bestsellersCourses))
            {
                bestsellersCourses = _cache.Get(Consts.bestellersCacheKey) as List<CourseResponse>;
            }
            else
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(60));
                bestsellersCourses = AutoMapper.Mapper.Map<List<CourseResponse>>(_courseService.GetThreeBestsellers());
                _cache.Set(Consts.bestellersCacheKey, bestsellersCourses, cacheEntryOptions);
            }
            
            var vm = new HomeIndexViewModel
            {
                Categories = categories,
                News = newsCourses,
                Bestsellers = bestsellersCourses
            };

            return View(vm);
        }

        public IActionResult SitesStatic(string name)
        {
            return View(name);
        }
    }
}