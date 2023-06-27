using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;
using NzWalks.API.RepositoryPattern.Base;
using NzWalks.API.RepositoryPattern.Interfaces;

namespace NzWalks.API.RepositoryPattern.Concrete
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        private readonly NZWalksDbContext dbContext;

        public RegionRepository(NZWalksDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Region> UpdateAsync(Guid id, Region region)
        {

            var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.ID == id);

            if (existingRegion == null)
            {
                return null;
            }

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;


            await dbContext.SaveChangesAsync();

            return existingRegion;

        }
    }
}
