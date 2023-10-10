using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : ControllerBase
    {
        private readonly Context _context;
        public FavoriteController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Favorite context)
        {
            if (context == null)
            {
                return BadRequest();
            }
            _context.Favorite.Add(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Favorite.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var context = await _context.Favorite.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }
            _context.Favorite.RemoveRange(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }
    }
}
