using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;
using NzWalks.API.RepositoryPattern.Interfaces;

namespace NzWalks.API.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly NZWalksDbContext dbContext;
        private readonly DbSet<T> table;

        public Repository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
            table = dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T item)
        {
            await table.AddAsync(item);
            await dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<T?> DeleteAsync(Guid id)
        {
            var existingItem = await table.FirstOrDefaultAsync(x => x.ID == id);

            if (existingItem == null)
            {
                return null;
            }

            table.Remove(existingItem);
            await dbContext.SaveChangesAsync();

            return existingItem;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T?> GetByIDAsync(Guid id)
        {
            return await table.FirstOrDefaultAsync(x => x.ID == id);
        }

      
    }
}
