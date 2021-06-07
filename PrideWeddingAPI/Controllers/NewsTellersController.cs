using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrideWeddingAPI.Data;
using PrideWeddingAPI.Models;

namespace PrideWeddingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsTellersController : ControllerBase
    {
        private readonly WeddingDBContext _context;

        public NewsTellersController(WeddingDBContext context)
        {
            _context = context;
        }

        // GET: api/NewsTellers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsTeller>>> GetNewsTeller()
        {
            return await _context.NewstellerSubscribers.ToListAsync();
        }

        // GET: api/NewsTellers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsTeller>> GetNewsTeller(int id)
        {
            var newsteller = await _context.NewstellerSubscribers.FindAsync(id);

            if (newsteller == null)
            {
                return NotFound();
            }

            return newsteller;
        }

        // PUT: api/NewsTellers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewsTeller(int id, NewsTeller newsteller)
        {
            if (id != newsteller.SubscriberID)
            {
                return BadRequest();
            }

            _context.Entry(newsteller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsTellerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/NewsTellers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NewsTeller>> PostNewsTeller(NewsTeller newsteller)
        {
            _context.NewstellerSubscribers.Add(newsteller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewsTeller", new { id = newsteller.SubscriberID }, newsteller);
        }

        // DELETE: api/NewsTellers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewsTeller>> DeleteNewsTeller(int id)
        {
            var newsteller = await _context.NewstellerSubscribers.FindAsync(id);
            if (newsteller == null)
            {
                return NotFound();
            }

            _context.NewstellerSubscribers.Remove(newsteller);
            await _context.SaveChangesAsync();

            return newsteller;
        }

        private bool NewsTellerExists(int id)
        {
            return _context.NewstellerSubscribers.Any(e => e.SubscriberID == id);
        }
    }
}
