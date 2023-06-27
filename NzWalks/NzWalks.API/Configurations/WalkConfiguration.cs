using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Configurations
{
    public class WalkConfiguration : IEntityTypeConfiguration<Walk>
    {
        public void Configure(EntityTypeBuilder<Walk> builder)
        {
            builder.HasOne(w => w.Difficulty).WithOne(d => d.Walk).HasForeignKey<Walk>(w => w.DifficultyID);
            builder.HasOne(w => w.Region).WithOne(d => d.Walk).HasForeignKey<Walk>(w => w.RegionID);
        }
    }
}
