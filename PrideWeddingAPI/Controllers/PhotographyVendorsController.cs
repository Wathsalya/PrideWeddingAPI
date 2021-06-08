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
    public class PhotographyVendorsController : ControllerBase
    {
        CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=pridewedding;AccountKey=VSV77ls5Ansp9Ro7CQvs/026Ptwr9URXsWqI1M++c0KucDWWt7mwfj/YkZAwqRRrR/iejH/6/QX9xt4/YrtZIA==;EndpointSuffix=core.windows.net");

        private readonly WeddingDBContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PhotographyVendorsController(WeddingDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/PhotographyVendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotographyVendor>>> GetPhotographers()
        {
            return await _context.Photographers
                .Select(x => new PhotographyVendor() { 
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

        // GET: api/PhotographyVendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhotographyVendor>> GetPhotographyVendor(int id)
        {
            var photographyVendor = await _context.Photographers.FindAsync(id);

            if (photographyVendor == null)
            {
                return NotFound();
            }

            return photographyVendor;
        }

        // PUT: api/PhotographyVendors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhotographyVendor(int id, [FromForm]PhotographyVendor photographyVendor)
        {
            if (id != photographyVendor.CompanyID)
            {
                return BadRequest();
            }

            if(photographyVendor.ImageFile != null)
            {
                DeleteImage(photographyVendor.ImageName);
                photographyVendor.ImageName =await SaveImage(photographyVendor.ImageFile);
            }

            _context.Entry(photographyVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotographyVendorExists(id))
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

        // POST: api/PhotographyVendors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PhotographyVendor>> PostPhotographyVendor([FromForm]PhotographyVendor photographyVendor)
        {
            photographyVendor.ImageName =await SaveImage(photographyVendor.ImageFile);
            _context.Photographers.Add(photographyVendor);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/PhotographyVendors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PhotographyVendor>> DeletePhotographyVendor(int id)
        {
            var photographyVendor = await _context.Photographers.FindAsync(id);
            if (photographyVendor == null)
            {
                return NotFound();
            }
            DeleteImage(photographyVendor.ImageName);
            _context.Photographers.Remove(photographyVendor);
            await _context.SaveChangesAsync();

            return photographyVendor;
        }

        private bool PhotographyVendorExists(int id)
        {
            return _context.Photographers.Any(e => e.CompanyID == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).ToArray());
            imageName = imageName + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
           // using (var fileStream = new FileStream(imagePath, FileMode.Create))
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
