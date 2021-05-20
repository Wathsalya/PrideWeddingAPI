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
    public class ContactFormDetailsController : ControllerBase
    {
        private readonly WeddingDBContext _context;

        public ContactFormDetailsController(WeddingDBContext context)
        {
            _context = context;
        }

        // GET: api/ContactFormDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactFormDetails>>> GetContactFormDetails()
        {
            return await _context.ContactUS.ToListAsync();
        }

        // GET: api/ContactFormDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactFormDetails>> GetContactFormDetails(int id)
        {
            var contact = await _context.ContactUS.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // PUT: api/ContactFormDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactFormDetails(int id, ContactFormDetails contact)
        {
            if (id != contact.ID)
            {
                return BadRequest();
            }

            _context.Entry(contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactFormDetailsExists(id))
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

        // POST: api/ContactFormDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ContactFormDetails>> PostContactFormDetails(ContactFormDetails contact)
        {
            _context.ContactUS.Add(contact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactFormDetails", new { id = contact.ID }, contact);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ContactFormDetails>> DeleteContactFormDetails(int id)
        {
            var contact = await _context.ContactUS.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.ContactUS.Remove(contact);
            await _context.SaveChangesAsync();

            return contact;
        }

        private bool ContactFormDetailsExists(int id)
        {
            return _context.ContactUS.Any(e => e.ID == id);
        }
    }
}
