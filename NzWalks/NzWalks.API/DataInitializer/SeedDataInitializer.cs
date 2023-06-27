using Microsoft.EntityFrameworkCore;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.DataInitializer
{
    public class SeedDataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            //Seed data for Diffuculites
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>() {
                new Difficulty
                {
                    ID = Guid.Parse("a48dc7a3-334c-473c-a995-50f5975414ec"),
                    Name = "Easy",
                    
                },
                 new Difficulty
                {
                    ID = Guid.Parse("5b8483c8-5a27-4c17-9b4e-30fb1553426c"),
                    Name = "Medium"
                },
                  new Difficulty
                {
                    ID = Guid.Parse("d58a36f9-a5f2-437c-9436-c571149ed577"),
                    Name = "Hard"
                },

            };

            // seed difficulties to the data base
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            // seed data for Regions
            var regions = new List<Region>()
            {
                new Region
                {
                    ID = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    ID = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    ID = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    ID = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    ID = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region 
                {
                    ID = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
