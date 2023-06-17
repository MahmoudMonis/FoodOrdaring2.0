using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.ViewModels;
using FoodOrdering.DBAccess;
using FoodOrdering.ViewModels.SubCategory;
using FoodOrdering.Models;
namespace FoodOrdaring2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SubCategoryController
    {
        private readonly DbConnection _context;
        public SubCategoryController(DbConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<SubCategoryVM>> Get()
        {
            var subCategories = await _context.SubCategories.Include(sc => sc.Category).ToListAsync();
            return subCategories.Select(sc => new SubCategoryVM
            {
                Id = sc.Id,
                Name = sc.Name,

                Category = new CategoryVM
                {
                    Id = sc.Category.Id,
                    Name = sc.Category.Name,

                }

            }).ToList();
        }
        [HttpPost]
        public async Task<ActionResult<SubCategory>> Post(CreateSubCategoryVm subCategoryVM)
        {
            return null;
            // var subcategory = new SubCategory
            // {
            //     Name = subCategoryVM.Name,
            //     CategoryId = subCategoryVM.CategoryId,
            // };
            // _context.SubCategories.Add(subcategory);
            // await _context.SaveChangesAsync();
            // return Ok(subcategory);
        }
    }
}