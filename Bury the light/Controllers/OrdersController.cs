using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly Context _context;
        public OrdersController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Orders context)
        {
            if (context == null)
            {
                return BadRequest();
            }
            _context.Orders.Add(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Orders.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrders(int id)
        {
            var context = await _context.Orders.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }
            _context.Orders.RemoveRange(context);
            await _context.SaveChangesAsync();

            return Ok(context);
        }
    }
}
