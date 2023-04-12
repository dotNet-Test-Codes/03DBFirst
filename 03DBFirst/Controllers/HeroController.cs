using _03DBFirst.Data;
using _03DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _03DBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroDbContext _heroDbContext;
        public HeroController(HeroDbContext heroDbContext)
        {
            _heroDbContext = heroDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetHeroes()
        {
            return Ok(await _heroDbContext.Heroes.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddHeroes(Hero hero)
        {
            await _heroDbContext.Heroes.AddAsync(hero);
            await _heroDbContext.SaveChangesAsync();

            return Ok(hero);
        }

    }
}
