using NzWalks.API.Data;
using NzWalks.API.Models.Domain;
using NzWalks.API.Repositories;

namespace NzWalks.API.RepositoryPattern.Concrete
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly NZWalksDbContext DbContext;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, NZWalksDbContext DbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
            this.DbContext = DbContext;
        }   
        public async Task<Image> Upload(Image image)
        {

            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot", "Images", $"{image.FileName}{image.FileExtension}");

            // Upload Image to Local Path
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            // https://locaholst:port/images/image.jpg

            var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/Images/{image.FileName}{image.FileExtension}";
            image.FilePath = urlFilePath;

            // Add Image to the Images Table
            await DbContext.Images.AddAsync(image);
            await DbContext.SaveChangesAsync();

            return image;
        }
    }
}
