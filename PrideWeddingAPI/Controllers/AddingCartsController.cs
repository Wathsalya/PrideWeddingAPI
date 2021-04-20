using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrideWeddingAPI.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using PrideWeddingAPI.Data;

namespace PrideWeddingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddingCartsController : ControllerBase
    {
        private readonly WeddingDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AddingCartsController(WeddingDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/AddingCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddingCart>>> GetCartItems()
        {
            return await _context.CartItems
                .Select(x => new AddingCart() { 
                CompanyID = x.CompanyID,
                CompanyName = x.CompanyName,
                CompanyCategory = x.CompanyCategory,
                LocatedDistrict=x.LocatedDistrict,
                LocatedProvince = x.LocatedProvince,
                TelephoneNumber=x.TelephoneNumber,
				CompanyWebsite=x.CompanyWebsite,
                Min_package=x.Min_package,
                Max_package = x.Max_package,
                ImageName = x.ImageName,
                ImageSrc = String.Format("{0}://{1}{2}/Images/{3}",Request.Scheme,Request.Host,Request.PathBase,x.ImageName)
                })
                .ToListAsync();
        }

        // GET: api/AddingCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddingCart>> GetAddingCart(int id)
        {
            var addingCart = await _context.CartItems.FindAsync(id);

            if (addingCart == null)
            {
                return NotFound();
            }

            return addingCart;
        }

        // PUT: api/AddingCarts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddingCart(int id, [FromForm]AddingCart addingCart)
        {
            if (id != addingCart.CompanyID)
            {
                return BadRequest();
            }

            if(addingCart.ImageFile != null)
            {
                DeleteImage(addingCart.ImageName);
                addingCart.ImageName =await SaveImage(addingCart.ImageFile);
            }

            _context.Entry(addingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddingCartExists(id))
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

        // POST: api/AddingCarts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AddingCart>> PostAddingCart([FromForm]AddingCart addingCart)
        {
            addingCart.ImageName =await SaveImage(addingCart.ImageFile);
            _context.CartItems.Add(addingCart);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/AddingCarts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AddingCart>> DeleteAddingCart(int id)
        {
            var addingCart = await _context.CartItems.FindAsync(id);
            if (addingCart == null)
            {
                return NotFound();
            }
            DeleteImage(addingCart.ImageName);
            _context.CartItems.Remove(addingCart);
            await _context.SaveChangesAsync();

            return addingCart;
        }

        private bool AddingCartExists(int id)
        {
            return _context.CartItems.Any(e => e.CompanyID == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

        [NonAction]
        public void DeleteImage(string imageName)
        {
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
        }
    }
}
