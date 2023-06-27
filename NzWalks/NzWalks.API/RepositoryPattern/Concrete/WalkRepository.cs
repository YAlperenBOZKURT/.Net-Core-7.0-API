using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;
using NzWalks.API.RepositoryPattern.Base;
using NzWalks.API.RepositoryPattern.Interfaces;

namespace NzWalks.API.RepositoryPattern.Concrete
{
    public class WalkRepository : Repository<Walk>, IWalkRepository
    {
        private readonly NZWalksDbContext dbContext;

        public WalkRepository(NZWalksDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var walks = await dbContext.Walks.Include("Difficulty").Include("Region").ToListAsync();

            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                var prop = typeof(Walk).GetProperty(filterOn);
                if (prop != null)
                {
                    walks = walks.Where(w => prop.GetValue(w)?.ToString()?.Contains(filterQuery) == true).ToList();
                }
            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                var prop = typeof(Walk).GetProperty(sortBy);
                if (prop != null)
                {
                    walks = isAscending ? walks.OrderBy(w => prop.GetValue(w)).ToList() : walks.OrderByDescending(w => prop.GetValue(w)).ToList();
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return walks.Skip(skipResults).Take(pageSize).ToList();
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await dbContext.Walks.FirstOrDefaultAsync(x => x.ID == id);

            if (existingWalk == null)
            {
                return null;
            }

            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.LengthInKm = walk.LengthInKm;
            existingWalk.DifficultyID = walk.DifficultyID;
            existingWalk.WalkImgUrl = walk.WalkImgUrl;
            existingWalk.RegionID = walk.RegionID;

            await dbContext.SaveChangesAsync();
            return existingWalk;
        }
    }
}
