using NzWalks.API.Models.Domain;

namespace NzWalks.API.RepositoryPattern.Interfaces
{
    public interface IRegionRepository : IRepository<Region>
    {
        Task<Region?> UpdateAsync(Guid id, Region region);
    }
}
