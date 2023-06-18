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

public class UsersController : ControllerBase
{
    private readonly DbContext _context;

    public UsersController(DbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<User>> Get()
    {
        var userList = await _context.Set<User>().ToListAsync();
        return userList;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> Get(int id)
    {
        var user = await _context.Set<User>().FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

    [HttpPost]
    public async Task<ActionResult> Post(UsersVM vm)
    {
        var user = new User
        {
            Name = vm.Name,
            Id = vm.Id,
        };

        _context.Set<User>().Add(user);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, UsersVM vm)
    {
        var user = await _context.Set<User>().FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }

        user.Name = vm.Name;
        user.Id = vm.Id;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _context.Set<User>().FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }

        _context.Set<User>().Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}

/* public class UsersVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }*/