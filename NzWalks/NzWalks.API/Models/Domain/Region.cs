namespace NzWalks.API.Models.Domain
{
    public class Region : BaseEntity
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }

        // Navigation properties

        public virtual Walk Walk { get; set; }

    }
}
