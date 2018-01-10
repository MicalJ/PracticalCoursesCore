using Microsoft.EntityFrameworkCore;
using PCDatabase;
using PCDatabase.DbModels;
using PracticalCourses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly PCContext _context;

        public CategoryService(PCContext pCContext)
        {
            _context = pCContext;
        }

        public async Task<List<Category>> GetAllCategory()
        {
            return _context.Categories.AsNoTracking().ToList();
        }
    }
}
