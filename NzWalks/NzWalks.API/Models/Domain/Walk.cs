namespace NzWalks.API.Models.Domain
{
    public class Walk : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImgUrl { get; set; }


        public Guid DifficultyID { get; set; }
        public Guid RegionID { get; set; }


        // Navigation properties

        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
