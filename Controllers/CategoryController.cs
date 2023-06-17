using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodOrdaring2.ViewModels.Category;
using FoodOrdering.DBAccess;
using FoodOrdering.Models;
using FoodOrdering.ViewModels;
namespace FoodOrdaring2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly DbConnection _context;
        public CategoryController(DbConnection context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryVM>> Get()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories.Select(p => new CategoryVM
            {
                Id = p.Id,
                Name = p.Name,


            }).ToList();
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryVM categoryVM)
        {
            var category = new Category
            {
                Name = categoryVM.Name,

            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return Ok(category);

        }

    }
}