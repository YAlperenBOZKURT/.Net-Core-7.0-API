namespace NzWalks.API.Models.DTO
{
    public class WalkDto
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImgUrl { get; set; }
    
        //public Guid DifficultyID { get; set; }

        //public Guid RegionID { get; set; }

        public RegionDto Region { get; set; }
        public DifficultyDto Difficulty { get; set; }
    }
}
