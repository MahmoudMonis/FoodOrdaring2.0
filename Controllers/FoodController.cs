using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.ViewModels;
using FoodOrdering.ViewModels.FoodItem;
using FoodOrdering.DBAccess;
using FoodOrdering.Models;
namespace FoodOrdaring.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FoodController : ControllerBase
    {
         private readonly DbConnection _context;
        public FoodController(DbConnection context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<FoodItemVM>> GetFoodByCategory(int CategoryId)
        {
            var items=await _context.Items.Include(p=> p.subcategory).Where(p => p.subcategory.CategoryId==CategoryId ).ToListAsync();
            return items.Select(p=> new FoodItemVM 
            {
                
                Name = p.Name,
               
                SubCategory =new SubCategoryVM
                {
                    Id = p.subcategory.Id,
                    Name = p.subcategory.Name,
                    
                }

                
            }).ToList();
        }
       [HttpGet]
               public async Task<IEnumerable<FoodItemVM>> GetFoodBySubCategory(int SubCategoryId)
               {
                var items = await _context.Items.Include(I=>I.subcategory).Where(I=>I.SubcategoryId==SubCategoryId).ToListAsync();
                return items.Select(I=> new FoodItemVM
                {
                   
                    Name = I.Name,
                   
                   
                  
                    SubCategory =new SubCategoryVM
                    {
                        Id = I.subcategory.Id,
                        Name = I.subcategory.Name,
                        
                         } 
               }).ToList();
              
               }

        [HttpGet]
        public async Task<IEnumerable<FoodItemVM>> Get()
        {
            var items= await _context.Items.Include(p=> p.subcategory).ToListAsync();
            return items.Select(p=> new FoodItemVM
            {
                
                Name = p.Name,
                
                SubCategory=new SubCategoryVM
                {
                    Id = p.subcategory.Id,
                    Name = p.subcategory.Name,
                 
                }
            }).ToList();
        }
        [HttpPost]
        public async Task<IActionResult> Post( CreateFoodVM itemVM)
        {

        var foodItem =new  FoodItem{
            Name = itemVM.Name,
            SubcategoryId=itemVM.SubCategoryId,
        };
            _context.Items.Add(foodItem);
            await _context.SaveChangesAsync();
            return Ok();

    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int  id) 
    {

        var item = await _context.Items.FindAsync(id);
        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
        return Ok();
}
    }
}
