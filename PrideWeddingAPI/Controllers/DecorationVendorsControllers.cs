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
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace PrideWeddingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecorationVendorsController : ControllerBase
    {
        CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=pridewedding;AccountKey=VSV77ls5Ansp9Ro7CQvs/026Ptwr9URXsWqI1M++c0KucDWWt7mwfj/YkZAwqRRrR/iejH/6/QX9xt4/YrtZIA==;EndpointSuffix=core.windows.net");

        private readonly WeddingDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public DecorationVendorsController(WeddingDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/DecorationVendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DecorationVendor>>> GetDecorators()
        {
            return await _context.Decorators
                .Select(x => new DecorationVendor() { 
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
                ImageSrc = String.Format("https://pridewedding.blob.core.windows.net/pridecontainer/{0}", x.ImageName)
                })
                .ToListAsync();
        }

        // GET: api/DecorationVendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DecorationVendor>> GetDecorationVendor(int id)
        {
            var decorationVendor = await _context.Decorators.FindAsync(id);

            if (decorationVendor == null)
            {
                return NotFound();
            }

            return decorationVendor;
        }

        // PUT: api/DecorationVendors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDecorationVendor(int id, [FromForm]DecorationVendor decorationVendor)
        {
            if (id != decorationVendor.CompanyID)
            {
                return BadRequest();
            }

            if(decorationVendor.ImageFile != null)
            {
                DeleteImage(decorationVendor.ImageName);
                decorationVendor.ImageName =await SaveImage(decorationVendor.ImageFile);
            }

            _context.Entry(decorationVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DecorationVendorExists(id))
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

        // POST: api/DecorationVendors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DecorationVendor>> PostDecorationVendor([FromForm]DecorationVendor decorationVendor)
        {
            decorationVendor.ImageName =await SaveImage(decorationVendor.ImageFile);
            _context.Decorators.Add(decorationVendor);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/DecorationVendors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DecorationVendor>> DeleteDecorationVendor(int id)
        {
            var decorationVendor = await _context.Decorators.FindAsync(id);
            if (decorationVendor == null)
            {
                return NotFound();
            }
            DeleteImage(decorationVendor.ImageName);
            _context.Decorators.Remove(decorationVendor);
            await _context.SaveChangesAsync();

            return decorationVendor;
        }

        private bool DecorationVendorExists(int id)
        {
            return _context.Decorators.Any(e => e.CompanyID == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).ToArray());
            imageName = imageName + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            //using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await UploadToAzureAsync(imageFile);
            }
            return imageName;
        }
        private async Task UploadToAzureAsync(IFormFile imageFile)
        {
            var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

            var cloudBlobContainer = cloudBlobClient.GetContainerReference("pridecontainer");

            if (await cloudBlobContainer.CreateIfNotExistsAsync())
            {
                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Container });
            }

            var cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(imageFile.FileName);
            cloudBlockBlob.Properties.ContentType = imageFile.ContentType;

            await cloudBlockBlob.UploadFromStreamAsync(imageFile.OpenReadStream());
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
