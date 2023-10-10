using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Shopping_cartController : ControllerBase
    {
        private readonly Context _context;
        public Shopping_cartController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Shopping_cart.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Shopping_cart context)
        {
            if (context == null)
            {
                return BadRequest();
            }
            _context.Shopping_cart.Add(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, Shopping_cart context)
        {
            var ShoppingCartUpdate = await _context.Shopping_cart.FindAsync(id);
            if (context == null)
            {
                return BadRequest();
            }
            if (ShoppingCartUpdate == null)
            {
                return NotFound();
            }

            ShoppingCartUpdate.Product_idf = context.Product_idf;
            ShoppingCartUpdate.Client_emailf = context.Client_emailf;
            ShoppingCartUpdate.Product_size = context.Product_size;
            ShoppingCartUpdate.Product_count = context.Product_count;

            _context.Entry(ShoppingCartUpdate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(context);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShopping_cart(int id)
        {
            var context = await _context.Shopping_cart.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }
            _context.Shopping_cart.RemoveRange(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }
    }
}