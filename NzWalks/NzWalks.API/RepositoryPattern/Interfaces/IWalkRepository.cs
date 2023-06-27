using NzWalks.API.Models.Domain;

namespace NzWalks.API.RepositoryPattern.Interfaces
{
    public interface IWalkRepository : IRepository<Walk>
    {
        Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null,
            bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
    }
}
