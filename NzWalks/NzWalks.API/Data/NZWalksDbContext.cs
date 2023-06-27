using Microsoft.EntityFrameworkCore;
using NzWalks.API.Configurations;
using NzWalks.API.DataInitializer;
using NzWalks.API.Models.Domain;


namespace NzWalks.API.Data

{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDataInitializer.Seed(modelBuilder);

            modelBuilder.ApplyConfiguration(new WalkConfiguration());
        }


        public DbSet<Difficulty> Diffuculties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

    }
}
