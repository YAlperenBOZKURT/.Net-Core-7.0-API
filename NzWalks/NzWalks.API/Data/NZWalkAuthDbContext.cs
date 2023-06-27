using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NzWalks.API.DataInitializer;

namespace NzWalks.API.Data
{
    public class NZWalkAuthDbContext : IdentityDbContext<IdentityUser>
    {
        public NZWalkAuthDbContext(DbContextOptions<NZWalkAuthDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUserDataInitializer.Seed(builder);
        }
    }
}
