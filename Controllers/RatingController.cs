using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.DBAccess;
using FoodOrdering.Models;
using FoodOrdering.ViewModels;

[ApiController]
[Route("[Controller]/[action]")]

public class RatingController : ControllerBase
    {
        private readonly DbContext _context;

    public RatingController(DbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Rating>> Get()
    {
        var ratingList = await _context.Set<Rating>().ToListAsync();
        return ratingList;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Rating>> Get(int id)
    {
        var rating = await _context.Set<Rating>().FirstOrDefaultAsync(r => r.Id == id);
        if (rating == null)
        {
            return NotFound();
        }
        return rating;
    }

    [HttpPost]
    public async Task<ActionResult> Post(RatingVM vm)
    {
        var rating = new RatingVM();
        {
            /*Id = vm.Id,
            Name = vm.Name,
            Users = vm.Users,*/
        };

        //_context.Set<Rating>().Add(rating);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, RatingVM vm)
    {
        var rating = await _context.Set<Rating>().FirstOrDefaultAsync(r => r.Id == id);
        if (rating == null)
        {
            return NotFound();
        }

        /*rating.Id = vm.Id;
        rating.Name = vm.Name;
        rating.Users = vm.Users;*/

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var rating = await _context.Set<Rating>().FirstOrDefaultAsync(r => r.Id == id);
        if (rating == null)
        {
            return NotFound();
        }

        _context.Set<Rating>().Remove(rating);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    }


    /*public class RatingVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UsersVM users { get; set; }
    }*/