using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly Context _context;
        public CategoriesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Categories.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }
    }
}
