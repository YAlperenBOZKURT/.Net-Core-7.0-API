using NzWalks.API.Models.Domain;

namespace NzWalks.API.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T item);
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIDAsync(Guid id);
        Task<T?> DeleteAsync(Guid id);

    }
}
