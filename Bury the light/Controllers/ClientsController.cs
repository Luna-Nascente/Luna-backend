using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;

namespace Bury_the_light.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly Context _context;
        public ClientsController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Clients context)
        {
            if (context == null)
            {
                return BadRequest();
            }
            _context.Clients.Add(context);
            await _context.SaveChangesAsync();
            return Ok(context);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = await _context.Clients.ToListAsync();
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var context = await _context.Clients.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }
            return Ok(context);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, Clients context)
        {
            var ClientToUpdate = await _context.Clients.FindAsync(id);
            if (context == null)
            {
                return BadRequest();
            }
            if (ClientToUpdate == null)
            {
                return NotFound();
            }

            ClientToUpdate.Client_birthday = context.Client_birthday;
            ClientToUpdate.Client_email = context.Client_email;
            ClientToUpdate.Client_password = context.Client_password;
            ClientToUpdate.Client_name = context.Client_name;
            ClientToUpdate.Client_address = context.Client_address;

            _context.Entry(ClientToUpdate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(context);
        }
    }
}