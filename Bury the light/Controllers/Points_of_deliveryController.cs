using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Points_of_deliveryController : ControllerBase
    {
        private readonly Context _context;
        public Points_of_deliveryController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Points_of_delivery.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }
    }
}
