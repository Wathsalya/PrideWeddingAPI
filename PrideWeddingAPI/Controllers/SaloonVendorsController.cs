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
    public class SaloonVendorsController : ControllerBase
    {
        CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=pridewedding;AccountKey=VSV77ls5Ansp9Ro7CQvs/026Ptwr9URXsWqI1M++c0KucDWWt7mwfj/YkZAwqRRrR/iejH/6/QX9xt4/YrtZIA==;EndpointSuffix=core.windows.net");

        private readonly WeddingDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public SaloonVendorsController(WeddingDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/SaloonVendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaloonVendor>>> GetSaloons()
        {
            return await _context.Saloons
                .Select(x => new SaloonVendor() { 
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

        // GET: api/SaloonVendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaloonVendor>> GetSaloonVendor(int id)
        {
            var saloonVendor = await _context.Saloons.FindAsync(id);

            if (saloonVendor == null)
            {
                return NotFound();
            }

            return saloonVendor;
        }

        // PUT: api/SaloonVendors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaloonVendor(int id, [FromForm]SaloonVendor saloonVendor)
        {
            if (id != saloonVendor.CompanyID)
            {
                return BadRequest();
            }

            if(saloonVendor.ImageFile != null)
            {
                DeleteImage(saloonVendor.ImageName);
                saloonVendor.ImageName =await SaveImage(saloonVendor.ImageFile);
            }

            _context.Entry(saloonVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaloonVendorExists(id))
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

        // POST: api/SaloonVendors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SaloonVendor>> PostSaloonVendor([FromForm]SaloonVendor saloonVendor)
        {
            saloonVendor.ImageName =await SaveImage(saloonVendor.ImageFile);
            _context.Saloons.Add(saloonVendor);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/SaloonVendors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SaloonVendor>> DeleteSaloonVendor(int id)
        {
            var saloonVendor = await _context.Saloons.FindAsync(id);
            if (saloonVendor == null)
            {
                return NotFound();
            }
            DeleteImage(saloonVendor.ImageName);
            _context.Saloons.Remove(saloonVendor);
            await _context.SaveChangesAsync();

            return saloonVendor;
        }

        private bool SaloonVendorExists(int id)
        {
            return _context.Saloons.Any(e => e.CompanyID == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).ToArray());
            imageName = imageName + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
         //   using (var fileStream = new FileStream(imagePath, FileMode.Create))
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
