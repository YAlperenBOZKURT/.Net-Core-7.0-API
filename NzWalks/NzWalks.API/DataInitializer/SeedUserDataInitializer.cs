using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NzWalks.API.DataInitializer
{
    public class SeedUserDataInitializer
    {
        public static void Seed(ModelBuilder  modelBuilder)
        {

            var readerRoleId = "6eb732ec-8a45-435e-9d6c-656f88fb30c5";
            var writerRoleId = "5de96e87-fd8d-4448-a6d7-74efa81bc411";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp =  readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp =  writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                },
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
